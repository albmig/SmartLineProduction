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


namespace SmartLineProduction
{
    public partial class UC_SL_History : MetroFramework.Forms.MetroForm
    {
        public string WEB_path_image = Properties.Settings.Default.Doc_folder;

        public static string qr_read_device = "";                               // la lettura "pura" del barcode
        public static string qr_sn = "";                                        // serial number del barcode (non ID Smartline)
        public static string qr_SistematicaSN = "";                             // serial number del barcode (non ID Smartline)
        public static string qr_ID = "";                                        // lettura del barcode, può essere codice articolo (classic) o ID Smartline (smartline)
        public static string qr_device = "";                                    // se smartline, contiene l'articolo estrapolato dall'id - se classic, contiene l'articolo letto
        public static string qr_fw = "";                                        // lettura del barcode
        public static string qr_ClassicSmart = "";                              // C Classic - S Smartline
        public static string qr_LottoFornitore = "";                            // da implementare - lettura del lotto sulla scheda
        public static string qr_Commessa = "";                                  // la commessa selezionata

        public static string History_Filter = "";
        public static bool HF_show_changeconf = true;
        public static bool HF_show_changefreq = true;
        public static bool HF_show_changesw = true;
        public static bool HF_show_conndisconn = true;
        public static bool HF_show_pairing = true;
        public static bool HF_show_readlogs = true;

        public static string ConfigString = string.Empty;                       // stringa del config da passare a UC_ViewConfig
        public static string Device = string.Empty;                             // stringa del config da passare a UC_ViewConfig

        public UC_SL_History()
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
            }
        }

        private void tbx_ReadLabel_Device_Leave(object sender, EventArgs e)
        {
            qr_read_device = tbx_ReadLabel_Device.Text;
            if (AnalizzaQrDevice(qr_read_device))
            {
                //but_Reset.Focus();
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
                DataView dv = ds_SL_History.SerialNumbers.DefaultView;
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
            lab_SerialOfficial.Text = qr_ID;
            lab_read_Serial.Text = qr_device;
            lab_read_FW.Text = qr_fw;

            this.Refresh();

            return true;
        }

        private void UC_SL_History_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL_History.SerialNumbers_Obsolete'. È possibile spostarla o rimuoverla se necessario.
            this.serialNumbers_ObsoleteTableAdapter.Fill(this.ds_SL_History.SerialNumbers_Obsolete);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL_History1.BS_SN_History'. È possibile spostarla o rimuoverla se necessario.
            this.bS_SN_HistoryTableAdapter.Fill(this.ds_SL_History.BS_SN_History);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL_History1.Firmware'. È possibile spostarla o rimuoverla se necessario.
            this.firmwareTableAdapter.Fill(this.ds_SL_History.Firmware);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL_History.SerialNumbers'. È possibile spostarla o rimuoverla se necessario.
            this.serialNumbersTableAdapter.Fill(this.ds_SL_History.SerialNumbers);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL_History.SF_Clienti_SerialNumbers'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Clienti_SerialNumbersTableAdapter.Fill(this.ds_SL_History.SF_Clienti_SerialNumbers);

            sFClientiSerialNumbersBindingSource.Sort = "RagSocCognome ASC";
            serialNumbersBindingSource.Sort = "Ser_SN_prod DESC";
            bSSNHistoryBindingSource.Sort = "created_at desc";

            SettaForm();

            Filtra_History();

            this.WindowState = FormWindowState.Maximized;

            serialNumbersBindingSource.MoveFirst();
            Db2Screen();

            tbx_ReadLabel_Device.Focus();
        }

        private void SettaForm()
        {
            //this.ActiveControl = tbx_ReadLabel_Device;

            //var myControl = this.ActiveControl.Name;

            if (this.ActiveControl == null)
            {
                tbx_ReadLabel_Device.Focus();
            }
            //metroLabel4.Text = this.ActiveControl.Name;


            lab_read_SN.Text = "";
            lab_SerialOfficial.Text = "";
            lab_read_Serial.Text = "";
            lab_read_FW.Text = "";
            tbx_ReadLabel_Device.Text = "";

            //cb_clienti.Items.Insert(0, "-- Seleziona tutti --");
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

        private void but_view_device_Click(object sender, EventArgs e)
        {
            using (var form = new UC_ImageDevice(lab_Device.Text, WEB_path_image))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private void cb_obsolete_rev_CheckStateChanged(object sender, EventArgs e)
        {
            if (cb_obsolete_rev.Checked)
            {
                cb_obsolete_rev.Visible = true;
                lab_ultima_rev_fw.Visible = true;
                lab_ultimofw.Visible = true;
            }
            else
            {
                cb_obsolete_rev.Visible = false;
                lab_ultima_rev_fw.Visible = false;
                lab_ultimofw.Visible = false;
            }
        }

        private void connectDisconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HF_show_conndisconn) { HF_show_conndisconn = false; } else { HF_show_conndisconn = true; }
            Filtra_History();
        }

        private void changeConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HF_show_changeconf) { HF_show_changeconf = false; } else { HF_show_changeconf = true; }
            Filtra_History();
        }

        private void changeSwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HF_show_changesw) { HF_show_changesw = false; } else { HF_show_changesw = true; }
            Filtra_History();
        }

        private void Filtra_History()
        {
            if (!HF_show_changeconf || !HF_show_changefreq || !HF_show_changesw || !HF_show_conndisconn || !HF_show_pairing || !HF_show_readlogs)
                viewAllToolStripMenuItem.Visible = true;
            else
                viewAllToolStripMenuItem.Visible = false;

            // Setta immagini menu
            if (HF_show_conndisconn)
            {
                connectDisconnectToolStripMenuItem.Image = Properties.Resources.Hide_16x;
                connectDisconnectToolStripMenuItem.BackColor = Color.LightGreen;
            }
            else
            {
                connectDisconnectToolStripMenuItem.Image = Properties.Resources.Visible_16x;
                connectDisconnectToolStripMenuItem.BackColor = Color.LightSalmon;
            }

            if (HF_show_changeconf)
            {
                changeConfigToolStripMenuItem.Image = Properties.Resources.Hide_16x;
                changeConfigToolStripMenuItem.BackColor = Color.LightGreen;
            }
            else
            {
                changeConfigToolStripMenuItem.Image = Properties.Resources.Visible_16x;
                changeConfigToolStripMenuItem.BackColor = Color.LightSalmon;
            }

            if (HF_show_changesw)
            {
                changeSwToolStripMenuItem.Image = Properties.Resources.Hide_16x;
                changeSwToolStripMenuItem.BackColor = Color.LightGreen;
            }
            else
            {
                changeSwToolStripMenuItem.Image = Properties.Resources.Visible_16x;
                changeSwToolStripMenuItem.BackColor = Color.LightSalmon;
            }
            if (HF_show_changefreq)
            {
                changeFrequencyToolStripMenuItem.Image = Properties.Resources.Hide_16x;
                changeFrequencyToolStripMenuItem.BackColor = Color.LightGreen;
            }
            else
            {
                changeFrequencyToolStripMenuItem.Image = Properties.Resources.Visible_16x;
                changeFrequencyToolStripMenuItem.BackColor = Color.LightSalmon;
            }
            if (HF_show_pairing)
            {
                pairingToolStripMenuItem.Image = Properties.Resources.Hide_16x;
                pairingToolStripMenuItem.BackColor = Color.LightGreen;
            }
            else
            {
                pairingToolStripMenuItem.Image = Properties.Resources.Visible_16x;
                pairingToolStripMenuItem.BackColor = Color.LightSalmon;
            }
            if (HF_show_readlogs)
            {
                readEventLogsToolStripMenuItem.Image = Properties.Resources.Hide_16x;
                readEventLogsToolStripMenuItem.BackColor = Color.LightGreen;
            }
            else
            {
                readEventLogsToolStripMenuItem.Image = Properties.Resources.Visible_16x;
                readEventLogsToolStripMenuItem.BackColor = Color.LightSalmon;
            }

            //Setta filtro
            string filtro = "";
            if (HF_show_conndisconn) { filtro = "(type = 'connect' OR type = 'disconnect')"; }
            if (HF_show_changeconf)
            {
                if (filtro != "") { filtro = filtro + " OR "; }
                filtro = filtro + "(type = 'change_config')";
            }
            if (HF_show_changesw)
            {
                if (filtro != "") { filtro = filtro + " OR "; }
                filtro = filtro + "(type = 'change_sw')";
            }
            if (HF_show_changefreq)
            {
                if (filtro != "") { filtro = filtro + " OR "; }
                filtro = filtro + "(type = 'change_freq')";
            }
            if (HF_show_pairing)
            {
                if (filtro != "") { filtro = filtro + " OR "; }
                filtro = filtro + "(type = 'pairing')";
            }
            if (HF_show_readlogs)
            {
                if (filtro != "") { filtro = filtro + " OR "; }
                filtro = filtro + "(type = 'read_event_logs')";
            }

            if (filtro != "")
            {
                filtro = History_Filter + " and (" + filtro + ")";
            }
            else
            {
                filtro = History_Filter;
            }

            bSSNHistoryBindingSource.Filter = filtro;
        }

        private void changeFrequencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HF_show_changefreq) { HF_show_changefreq = false; } else { HF_show_changefreq = true; }
            Filtra_History();
        }

        private void pairingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HF_show_pairing) { HF_show_pairing = false; } else { HF_show_pairing = true; }
            Filtra_History();
        }

        private void readEventLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HF_show_readlogs) { HF_show_readlogs = false; } else { HF_show_readlogs = true; }
            Filtra_History();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HF_show_changeconf = true;
            HF_show_changefreq = true;
            HF_show_changesw = true;
            HF_show_conndisconn = true;
            HF_show_pairing = true;
            HF_show_readlogs = true;
            Filtra_History();
        }

        private void sFClientiSerialNumbersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            string codcli = string.Empty;
            if (sFClientiSerialNumbersBindingSource.Current != null)
            {
                DataRowView current = (DataRowView)sFClientiSerialNumbersBindingSource.Current;
                codcli = Convert.ToString(current["CodAnagrafico"]);

                serialNumbersBindingSource.Filter = "Ser_ID_Cli = " + "'" + codcli + "'";
            }
            else
            {
                serialNumbersBindingSource.Filter = string.Empty;
            }

            serialNumbersBindingSource.MoveFirst();
        }

        private void serialNumbersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            string Fw_ver = string.Empty;
            string Fw_rev = string.Empty;
            string Serial = string.Empty;
            int lastrevint = 0;
            string lastRev = string.Empty;

            if (serialNumbersBindingSource.Current != null)
            {
                DataRowView current = (DataRowView)serialNumbersBindingSource.Current;
                Fw_ver = Convert.ToString(current["Ser_SW_Code"]);
                Fw_rev = Convert.ToString(current["Ser_SW_Code_Rev"]);
                Serial = Convert.ToString(current["Ser_SN_prod"]);
                string codFw = Convert.ToString(current["Ser_SW_Code"]);

                firmwareBindingSource.Filter = "SW_Code = " + "'" + Fw_ver + "' and SW_Revisione = " + "'" + Fw_rev + "'";

                bSSNHistoryBindingSource.Filter = "serialnumber = " + "'" + Serial + "'";
                History_Filter = bSSNHistoryBindingSource.Filter;

                lastRev = Convert.ToString(this.firmwareTableAdapter.GetLastRevision(codFw));
                lastrevint = Convert.ToInt32(this.firmwareTableAdapter.GetLastRevision(codFw));
                lab_ultimofw.Text = lastRev;
                //Verifica se obsoleto
                int lastrevcurrent = Convert.ToInt32(current["Ser_SW_Code_Rev"]);
                if (lastrevcurrent < lastrevint)
                {
                    cb_obsolete_rev.Checked = true;
                }
                else
                {
                    cb_obsolete_rev.Checked = false;
                }
            }
            else
            {
                firmwareBindingSource.Filter = string.Empty;
                bSSNHistoryBindingSource.Filter = string.Empty;
            }

            Db2Screen();
        }

        private void Db2Screen()
        {
            if (serialNumbersBindingSource.Current != null)
            {
                DataRowView current = (DataRowView)serialNumbersBindingSource.Current;
                lab_read_SN.Text = (string)current["Ser_SN_prod"];
                lab_SerialOfficial.Text = (string)current["Ser_OfficialSerial"];
                lab_read_Serial.Text = (string)current["Ser_ReadSerial"];
            }
        }

        private void gv_History_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == gv_History.Columns["ButViewConfig"].Index)
                {
                    bool isChangeConfig = false;
                    string TypeHistory = gv_History.Rows[e.RowIndex].Cells["gv_History_Type"].FormattedValue.ToString();

                    if (TypeHistory == "change_config") { isChangeConfig = true; }

                    if (!isChangeConfig)
                    {
                        Rectangle newRect = new Rectangle(e.CellBounds.X + 1, e.CellBounds.Y + 1, e.CellBounds.Width - 4, e.CellBounds.Height - 4);
                        using (Brush gridBrush = new SolidBrush(this.gv_History.GridColor), backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                        {
                            using (Pen gridLinePen = new Pen(gridBrush))
                            {
                                // Erase the cell.
                                e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                                // Draw the grid lines (only the right and bottom lines;
                                // DataGridView takes care of the others).
                                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
                                e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
                                e.CellBounds.Bottom - 1);
                                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
                                e.CellBounds.Top, e.CellBounds.Right - 1,
                                e.CellBounds.Bottom);
                                e.Handled = true;
                            }
                        }
                    }
                }
            }
        }

        private void gv_History_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gv_History.Columns["ButViewConfig"].Index)
            {
                bool isChangeConfig = false;
                string TypeHistory = gv_History.Rows[e.RowIndex].Cells["gv_History_Type"].FormattedValue.ToString();

                if (TypeHistory == "change_config") { isChangeConfig = true; }

                if (isChangeConfig)
                {
                    ConfigString = gv_History.Rows[e.RowIndex].Cells["gv_History_Extras"].FormattedValue.ToString();
                    Device = lab_Device.Text;

                    UC_ViewConfig uC_ViewConfig = new UC_ViewConfig();
                    uC_ViewConfig.Show();
                }


            }

        }

        private void copiaIlValoreNellaClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aaa = string.Empty;

            aaa = gv_History.CurrentRow.Cells["gv_History_Extras"].Value.ToString();
            Clipboard.SetDataObject(aaa);
        }
    }
}
