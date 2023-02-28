using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.IO;
using System.Drawing.Imaging;

namespace SmartLineProduction
{
    public partial class UC_VerificaNFC : MetroFramework.Forms.MetroForm
    {
        public const char div_1 = 'ç';
        public const char div_2 = ':';

        private int len_nfc = 16;
        private int len_qr = 23;

        private int tick_conta = 0;
        private int tick_max = 6000;
        private int tick_step = 100;

        private string raw_lettura = string.Empty;
        private string read_qr = string.Empty;
        private string read_nfc = string.Empty;

        private bool new_tag = false;

        public UC_VerificaNFC()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////
        /// Funzioni create
        ///////////////////////////////////////////////////////////////////////////////////////////////////

        private void SettaForm()
        {
            tick_conta = 0;
            Lab_ReadRfid.Text = string.Empty;
            Lab_ReadScanner.Text = string.Empty;
            Progress.Maximum = tick_max;
            time_read.Interval = tick_max + tick_step;

            if (this.ActiveControl == null)
            {
                tbx_ReadLabel_Device.Focus();
            }
            tbx_ReadLabel_Device.Text = "";
            tbx_ReadLabel_Device.Focus();
            read_nfc = string.Empty;
            read_qr = string.Empty;

            tb_Nfc.Text = string.Empty;
            tb_Qr.Text = string.Empty;

            new_tag = false;

            pan_newtag_Rfid.Visible = false;
            pan_newtag_Scanner.Visible = false;
            pic_Result.Hide();

        }

        private bool AnalizzaLettura(string letturabarcode)
        {
            bool isNfc = false;
            bool isQR = false;
            string temp_str_Nfc = string.Empty;
            string temp_str_Qr = string.Empty;

            int len_bc = letturabarcode.Length;
            if ((len_bc != len_nfc) && (len_bc != len_qr)) { return false; } // Lettura errata

            if (letturabarcode.Contains(div_1) || (letturabarcode.Contains(div_2))) { isQR = true; } else { isNfc = true; }

            if (isQR)
            {
                temp_str_Qr = letturabarcode.Replace(div_1, div_2);
                temp_str_Qr = temp_str_Qr.ToUpper();

                read_qr = temp_str_Qr;

                int err = LeggiNoteQr();
                switch (err)
                {
                    case 0:
                        break;
                    case 1:
                        //MessageBox.Show("TAG non trovato nel DataBase!");
                        new_tag = true;
                        pan_newtag_Scanner.Visible = true;
                        return false;
                        break;
                    case 2:
                        MessageBox.Show("TAG marcato come OBSOLETO nel DataBase!");
                        return false;
                        break;
                    case 3:
                        MessageBox.Show("TAG già verificato!");
                        return false;
                        break;
                }
            }

            if (isNfc)
            {
                temp_str_Nfc = letturabarcode.Substring(0, 2) + div_2 +
                               letturabarcode.Substring(2, 2) + div_2 +
                               letturabarcode.Substring(4, 2) + div_2 +
                               letturabarcode.Substring(6, 2) + div_2 +
                               letturabarcode.Substring(8, 2) + div_2 +
                               letturabarcode.Substring(10, 2) + div_2 +
                               letturabarcode.Substring(12, 2) + div_2 +
                               letturabarcode.Substring(14, 2);
                temp_str_Nfc = temp_str_Nfc.ToUpper();
                read_nfc = temp_str_Nfc;

                int err = LeggiNoteNfc();

                switch (err)
                {
                    case 0:
                        break;
                    case 1:
                        //MessageBox.Show("TAG non trovato nel DataBase!");
                        new_tag = true;
                        pan_newtag_Rfid.Visible = true;
                        return false;
                        break;
                    case 2:
                        MessageBox.Show("TAG marcato come OBSOLETO nel DataBase!");
                        return false;
                        break;
                    case 3:
                        MessageBox.Show("TAG già verificato!");
                        return false;
                        break;
                }
            }

            return true;
        }

        private bool WriteTable()
        {
            if ((read_nfc != string.Empty) && (read_qr != string.Empty) && (read_nfc == read_qr))
            {
                if (new_tag)
                {
                    DataRow newrow = ds_SafetyPointNFC.dt_SafetyPointRFID.NewRow();
                    newrow["Rfid_UUID"] = read_nfc;
                    newrow["Rfid_Technology"] = "SLIX2";
                    newrow["Rfid_Obsolete"] = false;
                    newrow["Rfid_Verified"] = true;

                    try
                    {
                        ds_SafetyPointNFC.dt_SafetyPointRFID.Rows.Add(newrow);
                        this.dt_SafetyPointRFIDTableAdapter.Update(newrow);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Update failed");
                        return false;
                    }

                    return true;
                }
                else
                {
                    int foundindex = dtSafetyPointRFIDBindingSource.Find("Rfid_UUID", read_qr);
                    if (foundindex > 0)
                    {
                        DataRowView current = (DataRowView)dtSafetyPointRFIDBindingSource.Current;
                        dtSafetyPointRFIDBindingSource.Position = foundindex;

                        DataRow editrow = ds_SafetyPointNFC.dt_SafetyPointRFID.Rows.Find(current["Rfid_ID"]);
                        editrow.BeginEdit();
                        editrow["Rfid_Verified"] = true;

                        try
                        {
                            this.Validate();
                            this.dtSafetyPointRFIDBindingSource.EndEdit();
                            this.dt_SafetyPointRFIDTableAdapter.Update(editrow);
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("Update failed");
                            return false;
                        }

                        return true;
                    }
                }
            }
            return false;
        }

        private int LeggiNoteQr() //Restituisce: 0-nessun errore/1-Not Found/2-Obsoleto/3-Già verificato
        {
            int foundindex = dtSafetyPointRFIDBindingSource.Find("Rfid_UUID", read_qr);
            if (foundindex > 0)
            {
                dtSafetyPointRFIDBindingSource.Position = foundindex;
                DataRowView current = (DataRowView)dtSafetyPointRFIDBindingSource.Current;
                tb_Qr.Text = current["Rfid_Note"].ToString();
                if (Convert.ToBoolean(current["Rfid_Obsolete"])) { return 2; }
                if (Convert.ToBoolean(current["Rfid_Verified"])) { return 3; }
                return 0;
            }
            else { return 1; }
        }

        private int LeggiNoteNfc() //Restituisce: 0-nessun errore/1-Not Found/2-Obsoleto/3-Già verificato
        {
            int foundindex = dtSafetyPointRFIDBindingSource.Find("Rfid_UUID", read_nfc);
            if (foundindex > 0)
            {
                dtSafetyPointRFIDBindingSource.Position = foundindex;
                DataRowView current = (DataRowView)dtSafetyPointRFIDBindingSource.Current;
                tb_Nfc.Text = current["Rfid_Note"].ToString();
                if (Convert.ToBoolean(current["Rfid_Obsolete"])) { return 2; }
                if (Convert.ToBoolean(current["Rfid_Verified"])) { return 3; }
                return 0;
            }
            else { return 1; }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////
        /// Funzioni automatiche
        ///////////////////////////////////////////////////////////////////////////////////////////////////

        private void UC_VerificaNFC_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SafetyPointNFC.dt_SafetyPointRFID'. È possibile spostarla o rimuoverla se necessario.
            this.dt_SafetyPointRFIDTableAdapter.Fill(this.ds_SafetyPointNFC.dt_SafetyPointRFID);
            SettaForm();

            this.WindowState = FormWindowState.Maximized;

            tbx_ReadLabel_Device.Focus();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbx_ReadLabel_Device_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\t' || e.KeyChar == (char)13)
            {
                e.Handled = true;
                raw_lettura = tbx_ReadLabel_Device.Text;
                if (AnalizzaLettura(raw_lettura)) 
                { 
                    but_Reset.Focus(); 
                } 
                else 
                { 
                    if (!new_tag) { SettaForm(); }
                }

                ///alberto///
            }
        }

        private void tbx_ReadLabel_Device_Leave(object sender, EventArgs e)
        {
            if (tbx_ReadLabel_Device.Text == "") return;

            raw_lettura = tbx_ReadLabel_Device.Text;

            if (AnalizzaLettura(raw_lettura))
            {
                tick_conta = 0;
                Lab_ReadScanner.Text = read_qr;
                Lab_ReadRfid.Text = read_nfc;

                Lab_ReadScanner.Refresh();
                Lab_ReadRfid.Refresh();

                tbx_ReadLabel_Device.Text = string.Empty;
                tbx_ReadLabel_Device.Focus();
            }
            else
            {
                if (new_tag)
                {
                    tick_conta = 0;

                    Lab_ReadScanner.Text = read_qr;
                    Lab_ReadRfid.Text = read_nfc;

                    Lab_ReadScanner.Refresh();
                    Lab_ReadRfid.Refresh();

                    tbx_ReadLabel_Device.Text = string.Empty;
                    tbx_ReadLabel_Device.Focus();
                }
                else
                {
                    tbx_ReadLabel_Device.Text = string.Empty;
                    raw_lettura = string.Empty;
                    SettaForm();
                }
            }
        }

        public static RotateFlipType Rotate(Image bmp)
        {
            //const int OrientationId = 0x0112;
            //PropertyItem pi = bmp.PropertyItems.Select(x => x)
            //                            .FirstOrDefault(x => x.Id == OrientationId);
            //if (pi == null)
            //    return RotateFlipType.RotateNoneFlipNone;

            //byte o = pi.Value[0];

            ////Orientations
            //if (o == 2) //TopRight
            //    return RotateFlipType.RotateNoneFlipX;
            //if (o == 3) //BottomRight
            //    return RotateFlipType.RotateNoneFlipXY;
            //if (o == 4) //BottomLeft
            //    return RotateFlipType.RotateNoneFlipY;
            //if (o == 5) //LeftTop
            //    return RotateFlipType.Rotate90FlipX;
            //if (o == 6) //RightTop
            //    return RotateFlipType.Rotate90FlipNone;
            //if (o == 7) //RightBottom
            //    return RotateFlipType.Rotate90FlipY;
            //if (o == 8) //LeftBottom
            //    return RotateFlipType.Rotate90FlipXY;

            return RotateFlipType.RotateNoneFlipNone; //TopLeft (what the image looks by default) [or] Unknown
        }

        private void but_AttivaProc_Click(object sender, EventArgs e)
        {
            SettaForm();
        }

        private void UC_VerificaNFC_Shown(object sender, EventArgs e)
        {
            tbx_ReadLabel_Device.Focus();
        }

        private void time_read_Tick(object sender, EventArgs e) // Pulisci
        {
            SettaForm();
        }

        private void time_progress_Tick(object sender, EventArgs e)
        {
            tick_conta = tick_conta + tick_step;
            Progress.Value = tick_conta;
            if (tick_conta == tick_max + tick_step)
            {
                SettaForm();
            }

            if ((read_nfc == string.Empty) || (read_qr == string.Empty))
            { pic_Result.Hide(); }

            if ((read_nfc != string.Empty) && (read_qr != string.Empty) && (read_nfc == read_qr))
            {
                pic_Result.Image = SmartLineProduction.Properties.Resources.Icona_OK;
                pic_Result.Show();

                if (!WriteTable()) { MessageBox.Show("Errore di scrittura sul DataBase!"); }
                SettaForm();
            }

            if ((read_nfc != string.Empty) && (read_qr != string.Empty) && (read_nfc != read_qr))
            {
                pic_Result.Image = SmartLineProduction.Properties.Resources.Icona_NotOK;
                pic_Result.Show();
                SettaForm();
            }
        }
    }
}
