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
using System.Drawing.Printing;

namespace SmartLineProduction
{
    public partial class UC_IndividuaLabel : MetroFramework.Forms.MetroForm
    {
        public static string qr_read_device = "";                               // la lettura "pura" del barcode
        public static string qr_sn = "";                                        // serial number del barcode (non ID Smartline)
        public static string qr_SistematicaSN = "";                             // serial number del barcode (non ID Smartline)
        public static string qr_ID = "";                                        // lettura del barcode, può essere codice articolo (classic) o ID Smartline (smartline)
        public static string qr_device = "";                                    // se smartline, contiene l'articolo estrapolato dall'id - se classic, contiene l'articolo letto
        public static string qr_fw = "";                                        // lettura del barcode
        public static string qr_ClassicSmart = "";                              // C Classic - S Smartline
        public static string qr_LottoFornitore = "";                            // da implementare - lettura del lotto sulla scheda
        public static string qr_Commessa = "";                                  // la commessa selezionata

        public UC_IndividuaLabel()
        {
            InitializeComponent();
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
                qr_read_device = tbx_ReadLabel_Device.Text;
                AnalizzaQrDevice(qr_read_device);
                but_Reset.Focus();
            }
        }

        private void tbx_ReadLabel_Device_Leave(object sender, EventArgs e)
        {
            qr_read_device = tbx_ReadLabel_Device.Text;
            if (AnalizzaQrDevice(qr_read_device))
            {
                but_Reset.Focus();

                but_Print.Visible = true;
            }
        }

        private bool AnalizzaQrDevice(string letturabarcode)
        {
            string[] codici = letturabarcode.Split('|');
            int conta = 1;
            foreach (var word in codici)
            {
                switch (conta)
                {
                    case 1: qr_sn = word; conta++; break;
                    case 2: qr_ID = word; conta++; break;
                    case 3: qr_fw = word; conta++; break;
                }
            }

            int lungSN = qr_sn.Length;
            if (lungSN == 16)
            {
                qr_ID = qr_sn; // aggiusto la situazione di confusione che si può creare...
                qr_sn = "";
                qr_ClassicSmart = "S";
                string filtro = "Ser_OfficialSerial = " + "'" + qr_ID + "'";
                DataView dv = ds_Programmazione.SerialNumbers.DefaultView;
                dv.RowFilter = filtro;

                if (dv.Count == 0)
                {
                    MessageBox.Show("Errore grave! Impossibile trovare il numero di serie indicato!");
                    return false;
                }
                foreach (DataRowView rowView in dv)
                {
                    qr_device = rowView["Ser_Device"].ToString();
                    qr_fw = rowView["Ser_SW_Code"].ToString();
                    qr_SistematicaSN = rowView["Ser_SN_Prod"].ToString();
                }
            }
            else
            {
                qr_ClassicSmart = "C";
                qr_device = qr_ID;
            }

            lab_read_SN.Text = qr_sn;
            lab_read_ID.Text = qr_ID;
            lab_read_Device.Text = qr_device;
            lab_read_FW.Text = qr_fw;
            lab_label_SN.Text = qr_SistematicaSN;

            this.Refresh();

            return true;
        }

        private void UC_IndividuaLabel_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SerialNumbers'. È possibile spostarla o rimuoverla se necessario.
            this.serialNumbersTableAdapter.Fill(this.ds_Programmazione.SerialNumbers);

            SettaForm();

            this.WindowState = FormWindowState.Maximized;
            tbx_ReadLabel_Device.Focus();
        }

        private void SettaForm()
        {
            if (this.ActiveControl == null)
            {
                tbx_ReadLabel_Device.Focus();
            }

            lab_read_SN.Text = "";
            lab_read_ID.Text = "";
            lab_read_Device.Text = "";
            lab_read_FW.Text = "";
            lab_label_SN.Text = "";
            tbx_ReadLabel_Device.Text = "";

            but_Print.Visible = false;
            tbx_ReadLabel_Device.Focus();
        }

        private void but_AttivaProc_Click(object sender, EventArgs e)
        {
            SettaForm();
        }

        private void UC_IndividuaLabel_Shown(object sender, EventArgs e)
        {
            tbx_ReadLabel_Device.Focus();
            //base.OnShown(e);
        }

        private void but_Print_Click(object sender, EventArgs e)
        {
            GVar.PrintMask_String = tbx_ReadLabel_Device.Text;
            //GVar.PrintMask_WarningPic = false;
            GVar.PrintMask_Firmware = lab_read_FW.Text;

            if (!GFunctions.PrintMask()) { MessageBox.Show("Riscontrato problema sulla stampante! Verificare connessione!"); }
        }
    }
}