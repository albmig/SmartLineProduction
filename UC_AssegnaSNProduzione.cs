using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
//using PCSC;

namespace SmartLineProduction
{
    public partial class UC_AssegnaSNProduzione : MetroFramework.Forms.MetroForm
    {

        public static string qr_read_device = "";                               // la lettura "pura" del barcode
        public static string qr_sn = "";                                        // serial number del barcode (non ID Smartline)
        public static string qr_ID = "";                                        // lettura del barcode, può essere codice articolo (classic) o ID Smartline (smartline)
        public static string qr_device = "";                                    // se smartline, contiene l'articolo estrapolato dall'id - se classic, contiene l'articolo letto
        public static string qr_fw = "";                                        // lettura del barcode
        public static string qr_ClassicSmart = "";                              // C Classic - S Smartline
        public static string qr_LottoFornitore = "";                            // da implementare - lettura del lotto sulla scheda
        public static string qr_Commessa = "";                                  // la commessa selezionata

        //int retCode;
        //int hCard;
        //int hContext;
        //int Protocol;
        //public bool connActive = false;
        //string readername = "ACS ACR122 0";      // change depending on reader
        //public byte[] SendBuff = new byte[263];
        //public byte[] RecvBuff = new byte[263];
        //public int SendLen, RecvLen, nBytesRet, reqType, Aprotocol, dwProtocol, cbPciLength;
        //public Card.SCARD_READERSTATE RdrState;
        //public Card.SCARD_IO_REQUEST pioSendRequest;

        public UC_AssegnaSNProduzione()
        {
            InitializeComponent();
        }

        // Controlli
        private void UC_AssegnaSNProduzione_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.Spedizioni_IDSerialNumbers'. È possibile spostarla o rimuoverla se necessario.
            this.spedizioni_IDSerialNumbersTableAdapter.Fill(this.ds_SL.Spedizioni_IDSerialNumbers);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.Spedizioni_Lotti'. È possibile spostarla o rimuoverla se necessario.
            this.spedizioni_LottiTableAdapter.Fill(this.ds_SL.Spedizioni_Lotti);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.Spedizioni'. È possibile spostarla o rimuoverla se necessario.
            this.spedizioniTableAdapter.FillBy_Spedizioni(this.ds_SL.Spedizioni);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_AnagraficaClienti'. È possibile spostarla o rimuoverla se necessario.
            //this.sF_AnagraficaClientiTableAdapter.Fill(this.ds_SL.SF_AnagraficaClienti);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SerialNumbers'. È possibile spostarla o rimuoverla se necessario.
            this.serialNumbersTableAdapter.Fill(this.ds_Programmazione.SerialNumbers);
            PulisciForm();
        }

        private void spedizioniBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            but_ChiusuraCollConf.Visible = false;
            AggiornaSpedizioniSN();
            Cursor.Current = Cursors.Default;
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void tbx_ReadLabel_Chip_TextChanged(object sender, EventArgs e)
        //{
            //labchip_ID.Text = "";
            //labchip_Kit.Text = "";
            //labchip_Cliente.Text = "";
        //}

        private void tbx_ReadLabel_Device_Leave(object sender, EventArgs e)
        {
            //if (tbx_ReadLabel_Device.Text == "") { tbx_ReadLabel_Device.Focus(); return; }

            qr_read_device = tbx_ReadLabel_Device.Text;
            if (AnalizzaQrDevice(qr_read_device))
            {
                tbx_ReadLabel_NFC.Focus();
            }
            else
            {
                ////CHE FACCIO?????
                panel_SN.Enabled = false;
                panel_grid_avanzamento.Enabled = true;
                PulisciFormPostProcedura();
            }
        }

        //private void tbx_ReadLabel_Chip_Leave(object sender, EventArgs e)
        //{
        //    //if (tbx_ReadLabel_Chip.Text == "") { tbx_ReadLabel_Chip.Focus(); }
        //}

        private void but_Associa_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = gv_SerialNumber.DataSource;
            bs.Filter = "HasLotti = 0";
            gv_SerialNumber.DataSource = bs;

            but_AttivaProc.Visible = false;
            but_TerminaProc.Visible = true;
            panel_grid_avanzamento.Enabled = false;
            panel_SN.Enabled = true;
            tbx_ReadLabel_Device.Focus();
        }

        private void tbx_ReadLabel_Device_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\t' || e.KeyChar == (char)13)
            {
                e.Handled = true;
                tbx_ReadLabel_NFC.Focus();
            }
        }

        private void but_ChiusuraSpedizione_Click(object sender, EventArgs e)
        {

            PulisciForm();
        }

        private void but_AssegnaLottoVuoto_Click(object sender, EventArgs e)
        {
            //Check if SmartLine
            DataRowView drview = (DataRowView)spedizioniBindingSource.Current;
            if (drview == null) { return; }
            string CodiceArticolo = drview["ARTICOLO"].ToString().Trim();
            if (CodiceArticolo.EndsWith("_L"))
            {
                MessageBox.Show("Non è possibile procedere con quest'operazione per la linea SmartLine!");
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Sei sicuro di non assegnare lotti?", "Richiesta conferma da parte dell'operatore", buttons);
            if (result != DialogResult.Yes)
            {
                PulisciFormPostProcedura();
                return;
            }

            DataView dv_serial = new DataView(ds_SL.Spedizioni_SN);
            foreach (DataRowView row in dv_serial)
            {
                if (!AnalizzaQrDevice(row["QR_CODE"].ToString()))
                {
                    return;
                }

                //Verifico non sia già presente
                DataView dv = new DataView(ds_SL.Spedizioni_Lotti);
                dv.RowFilter = "Lt_SerialNumber = " + "'" + row["SerialNumber"].ToString() + "'";
                if (dv.Count > 0)
                {
                    continue;
                }
                ///

                DataRow newrow = ds_SL.Spedizioni_Lotti.NewRow();
                newrow["Lt_CreationTime"] = DateTime.Now;
                newrow["Lt_LottoFornitore"] = "-UNDEFINED-";
                newrow["Lt_SerialNumber"] = row["SerialNumber"].ToString();
                newrow["Lt_CommessaLong"] = row["Commessa"].ToString();
                newrow["Lt_Articolo"] = qr_device;
                //newrow["Lt_Firmware"] = qr_fw;

                ds_SL.Spedizioni_Lotti.Rows.Add(newrow);

                spedizioni_LottiTableAdapter.Update(newrow);
            }

            PulisciFormPostProcedura();

            Cursor.Current = Cursors.Default;
        }

        private void but_TerminaProc_Click(object sender, EventArgs e)
        {
            gv_SerialNumber.DataSource = spedizioniSNBindingSource;
            panel_SN.Enabled = false;
            AggiornaSpedizioniSN();
        }

        private void tbx_ReadLabel_NFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                btn_conf_serial.Focus();
            }
        }

        private void tbx_ReadLabel_NFC_Leave(object sender, EventArgs e)
        {
            ManageNFC_leave();
        }

        //Funzioni
        private void PulisciForm()
        {
            tbx_ReadLabel_Device.Text = "";

            lab_read_SN.Text = "";
            lab_read_ID.Text = "";
            lab_read_Device.Text = "";
            lab_read_FW.Text = "";

            qr_read_device = "";
            qr_sn = "";
            qr_device = "";
            qr_ID = "";
            qr_fw = "";

            lab_SN_todo.Text = "";
            lab_articolo_todo.Text = "";

            panel_SN.Enabled = false;
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
            // Classic o Smartline??
            int lungSN = qr_sn.Length;
            if (lungSN == 16)
            {
                qr_ID = qr_sn; // aggiusto la situazione di confusione che si può creare...
                qr_sn = "";
                qr_ClassicSmart = "S";
                string filtro = "Ser_OfficialSerial = " + "'" + qr_ID + "'";
                DataView dv = ds_Programmazione.SerialNumbers.DefaultView;
                dv.RowFilter = filtro;
                
                if (dv.Count==0)
                {
                    MessageBox.Show("Errore grave! Impossibile trovare il numero di serie indicato!");
                    return false;
                }
                foreach (DataRowView rowView in dv)
                {
                    qr_device = rowView["Ser_Device"].ToString();
                    qr_fw= rowView["Ser_SW_Code"].ToString();
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
            this.Refresh();

            return true;
        }

        private void AggiornaSpedizioniSN()
        {
            but_AttivaProc.Visible = true;
            but_TerminaProc.Visible = false;
            but_AssegnaLottoVuoto.Visible = true;
            but_ChiusuraCollConf.Visible = false;

            DataRowView drview = (DataRowView)spedizioniBindingSource.Current;
            if (drview == null) { return; }
            string CodiceCommessa = drview["Commessa"].ToString().Trim();
            qr_Commessa = CodiceCommessa;
            this.spedizioni_SNTableAdapter.FillBy_SpedizioniXCommessa(this.ds_SL.Spedizioni_SN, CodiceCommessa);
            this.spedizioniSNBindingSource.Sort = "SerialNumber asc";

            DataView dv_serial = new DataView(ds_SL.Spedizioni_SN);
            dv_serial.RowFilter = "HasLotti = 0";
            if (dv_serial.Count == 0)
            {
                //MessageBox.Show("Non ci sono ulteriori numeri di serie da abbinare!!");
                but_AttivaProc.Visible = false;
                but_TerminaProc.Visible = false;
                but_AssegnaLottoVuoto.Visible = false;
                //but_ChiusuraCollConf.Visible = true;
                but_ChiusuraCollConf.Refresh();
            }
            else
            {
                if (panel_SN.Enabled)
                {
                    but_AttivaProc.Visible = false;
                    but_TerminaProc.Visible = true;
                }
                else
                {
                    but_AttivaProc.Visible = true;
                    but_TerminaProc.Visible = false;
                }
                but_AssegnaLottoVuoto.Visible = true;
                but_ChiusuraCollConf.Visible = false;
            }
        }

        private void ScriviLotto()
        {
            DataView dv = new DataView(ds_SL.Spedizioni_Lotti);
            dv.RowFilter = "Lt_SerialNumber = " + "'" + qr_sn + "'";
            if (dv.Count > 0)
            {
                MessageBox.Show("Il numero seriale preso in esame non corrisponde a quelli della commessa!");
                return;
            }

            DataRow newrow = ds_SL.Spedizioni_Lotti.NewRow();
            newrow["Lt_CreationTime"] = DateTime.Now;
            newrow["Lt_LottoFornitore"] = qr_LottoFornitore;
            newrow["Lt_SerialNumber"] = qr_sn;
            newrow["Lt_CommessaLong"] = qr_Commessa;
            newrow["Lt_Articolo"] = qr_device;
            //newrow["Lt_Firmware"] = qr_fw;

            ds_SL.Spedizioni_Lotti.Rows.Add(newrow);

            spedizioni_LottiTableAdapter.Update(newrow);
        }

        private void ScriviSerial()
        {
            string filtrorow = "Ser_OfficialSerial = " + "'" + qr_ID + "'" + " AND Ser_Commessa = " + "'" + qr_Commessa + "'";
            DataRow[] selected = ds_Programmazione.SerialNumbers.Select(filtrorow);
            if (selected.Count() == 0)
            {
                MessageBox.Show("L'ID preso in esame non corrisponde a quelli della commessa!");
                return;
            }

            foreach (DataRow dr in selected) // search whole table
            {
                dr.BeginEdit();
                dr["Ser_SN_prod"] = lab_SN_todo.Text;
                dr["Ser_Spedito"] = true;
                dr["Ser_Data_Spedito"] = DateTime.Now;
                this.Validate();
                dr.EndEdit();
                this.serialNumbersTableAdapter.Update(dr);
            }
        }

        private void PulisciFormPostProcedura()
        {
            AggiornaSpedizioniSN();
            PulisciForm();
        }

        private void spedizioniSNBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)spedizioniSNBindingSource.Current;
            if (drview == null) { return; }
            string lab_SN = drview["SerialNumber"].ToString().Trim();
            string lab_articolo = drview["ARTICOLO"].ToString().Trim();
            lab_SN_todo.Text = lab_SN;
            lab_articolo_todo.Text = lab_articolo;
            qr_sn = lab_SN;
        }

        private void ManageNFC_leave()
        {
            qr_LottoFornitore = tbx_ReadLabel_NFC.Text;
            if (qr_LottoFornitore == "")
            {
                qr_LottoFornitore = "-UNDEFINED-";
            }
        }

        private void btn_conf_serial_Click(object sender, EventArgs e)
        {
            qr_sn = lab_SN_todo.Text;
            ScriviSerial();
            ScriviLotto();
            System.Media.SystemSounds.Asterisk.Play();
            Thread.Sleep(1000);
            System.Media.SystemSounds.Beep.Play();
            PulisciForm();
            AggiornaSpedizioniSN();
        }
    }
}

