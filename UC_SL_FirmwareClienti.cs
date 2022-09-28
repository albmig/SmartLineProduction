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
using System.Diagnostics;

namespace SmartLineProduction
{
    public partial class UC_SL_FirmwareClienti : MetroFramework.Forms.MetroForm
    {
        public int glob_nominativo = 0;
        public string glob_firmware = "";
        public string glob_des1 = "";
        public string glob_des2 = "";

        public UC_SL_FirmwareClienti()
        {
            InitializeComponent();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            string MessageBoxTitle = "Aggiornamento archivi in cloud";
            string MessageBoxContent = "Effettuare l'aggiornamento?";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ExecCmd();
            }

            this.Close();
        }

        private void UC_SL_FirmwareClientiLabel_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_FwClienti.Firmware_DB'. È possibile spostarla o rimuoverla se necessario.
            this.firmware_DBTableAdapter.Fill(this.ds_FwClienti.Firmware_DB);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_FwClienti.SF_Clienti_SN'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Clienti_SNTableAdapter.Fill(this.ds_FwClienti.SF_Clienti_SN);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_FwClienti.FW_Clienti_DB'. È possibile spostarla o rimuoverla se necessario.
            this.fW_Clienti_DBTableAdapter.Fill(this.ds_FwClienti.FW_Clienti_DB);

            this.fW_Clienti_DBTableAdapter.DisableFWClientiTrigger();
            AggiornaFirmware();
            this.fW_Clienti_DBTableAdapter.EnableFWClientiTrigger();

            LoadData();

            this.WindowState = FormWindowState.Maximized;
        }

        private void gv_PalmStand_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) { return; }

            DataGridViewCell cell = this.gv_PalmStand.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewCell cellbutton = this.gv_PalmStand.Rows[e.RowIndex].Cells["gv_PalmStand_Present"];

            DataGridViewRow gridRow = gv_PalmStand.Rows[e.RowIndex];

            if ((gv_PalmStand.Columns[e.ColumnIndex].Name == "gv_PalmStand_Code") && (e.Value != null))
            {
                cell.Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
            }

            if ((gv_PalmStand.Columns[e.ColumnIndex].Name == "gv_PalmStand_Present") && (e.Value != null))
            {
                bool presente = Convert.ToBoolean(e.Value);
                if (presente)
                {
                    e.Value = "Elimina";
                    gridRow.DefaultCellStyle.ForeColor = Color.LightGray;
                    gridRow.DefaultCellStyle.SelectionForeColor = Color.LightGray;
                }
                else
                {
                    e.Value = "Aggiungi";
                    gridRow.DefaultCellStyle.ForeColor = Color.DarkGreen;
                    gridRow.DefaultCellStyle.SelectionForeColor = Color.DarkGreen;
                }
            }

        }

        private void gv_PalmCust_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) { return; }

            DataGridViewCell cell = this.gv_PalmCust.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewRow gridRow = gv_PalmCust.Rows[e.RowIndex];
            if ((gv_PalmCust.Columns[e.ColumnIndex].Name == "gv_PalmCust_Code") && (e.Value != null))
            {
                cell.Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
            }

            if ((gv_PalmCust.Columns[e.ColumnIndex].Name == "gv_PalmCust_Present") && (e.Value != null))
            {
                bool presente = Convert.ToBoolean(e.Value);
                if (presente)
                {
                    e.Value = "Elimina";
                    gridRow.DefaultCellStyle.ForeColor = Color.LightGray;
                    gridRow.DefaultCellStyle.SelectionForeColor = Color.LightGray;
                }
                else
                {
                    e.Value = "Aggiungi";
                    gridRow.DefaultCellStyle.ForeColor = Color.DarkGreen;
                    gridRow.DefaultCellStyle.SelectionForeColor = Color.DarkGreen;
                }
            }

        }

        private void gv_RicStand_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) { return; }

            DataGridViewCell cell = this.gv_RicStand.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewRow gridRow = gv_RicStand.Rows[e.RowIndex];
            if ((gv_RicStand.Columns[e.ColumnIndex].Name == "gv_RicStand_Code") && (e.Value != null))
            {
                cell.Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
            }

            if ((gv_RicStand.Columns[e.ColumnIndex].Name == "gv_RicStand_Present") && (e.Value != null))
            {
                bool presente = Convert.ToBoolean(e.Value);
                if (presente)
                {
                    e.Value = "Elimina";
                    gridRow.DefaultCellStyle.ForeColor = Color.LightGray;
                    gridRow.DefaultCellStyle.SelectionForeColor = Color.LightGray;
                }
                else
                {
                    e.Value = "Aggiungi";
                    gridRow.DefaultCellStyle.ForeColor = Color.DarkGreen;
                    gridRow.DefaultCellStyle.SelectionForeColor = Color.DarkGreen;
                }
            }

        }

        private void gv_RicCust_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) { return; }

            DataGridViewCell cell = this.gv_RicCust.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewRow gridRow = gv_RicCust.Rows[e.RowIndex];
            if ((gv_RicCust.Columns[e.ColumnIndex].Name == "gv_RicCust_Code") && (e.Value != null))
            {
                cell.Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
            }

            if ((gv_RicCust.Columns[e.ColumnIndex].Name == "gv_RicCust_Present") && (e.Value != null))
            {
                bool presente = Convert.ToBoolean(e.Value);
                if (presente)
                {
                    e.Value = "Elimina";
                    gridRow.DefaultCellStyle.ForeColor = Color.LightGray;
                    gridRow.DefaultCellStyle.SelectionForeColor = Color.LightGray;
                }
                else
                {
                    e.Value = "Aggiungi";
                    gridRow.DefaultCellStyle.ForeColor = Color.DarkGreen;
                    gridRow.DefaultCellStyle.SelectionForeColor = Color.DarkGreen;
                }
            }

        }

        private void gv_FWCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) { return; }

            DataGridViewCell cell = this.gv_FWCliente.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewRow gridRow = gv_FWCliente.Rows[e.RowIndex];
            if ((gv_FWCliente.Columns[e.ColumnIndex].Name == "gv_FWCliente_SWCode") && (e.Value != null))
            {
                cell.Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
            }
        }

        private void AggiornaFirmware()
        {
            bool dascrivere;

            foreach (DataRow row_clientisn in ds_FwClienti.SF_Clienti_SN)
            {
                //Console.Write(row_clientisn["CodAnagrafico"].ToString());
                foreach (DataRow row_firmware in ds_FwClienti.Firmware_DB.Rows)
                {
                    //Console.Write(row_firmware["Id"]);

                    if ((bool)row_firmware["SW_Obsolete_ver"]) { continue; }

                    dascrivere = false;

                    int codnominativo = (int)row_clientisn["CodAnagrafico"];
                    string codfw = row_firmware["SW_Code"].ToString();
                    string des1 = row_firmware["SW_Descrizione"].ToString();
                    string des2 = row_firmware["SW_Descrizione_EN"].ToString();


                    if (codnominativo == 1) { dascrivere = true; }
                    if ((codnominativo != 1) && ((bool)row_firmware["SW_Standard"])) { dascrivere = true; }
                    if (!RecordPresente(codnominativo, codfw) && (dascrivere)) { AggiornaRecord(codnominativo, codfw, des1, des2); }
                }
            }
        }

        private void LoadData()
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_FwClienti.Bouquet_RicCust'. È possibile spostarla o rimuoverla se necessario.
            this.bouquet_RicCustTableAdapter.Fill(this.ds_FwClienti.Bouquet_RicCust);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_FwClienti.Bouquet_RicStand'. È possibile spostarla o rimuoverla se necessario.
            this.bouquet_RicStandTableAdapter.Fill(this.ds_FwClienti.Bouquet_RicStand);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_FwClienti.Bouquet_PalmCust'. È possibile spostarla o rimuoverla se necessario.
            this.bouquet_PalmCustTableAdapter.Fill(this.ds_FwClienti.Bouquet_PalmCust);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_FwClienti.Bouquet_PalmStand'. È possibile spostarla o rimuoverla se necessario.
            this.bouquet_PalmStandTableAdapter.Fill(this.ds_FwClienti.Bouquet_PalmStand);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_FwClienti.FW_Clienti'. È possibile spostarla o rimuoverla se necessario.
            this.fW_ClientiTableAdapter.Fill(this.ds_FwClienti.FW_Clienti);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL_History.SF_Clienti_SerialNumbers'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Clienti_SerialNumbersTableAdapter.Fill(this.ds_FwClienti.SF_Clienti_SerialNumbers);
        }

        private void ReLoadData()
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_FwClienti.Firmware_DB'. È possibile spostarla o rimuoverla se necessario.
            this.firmware_DBTableAdapter.Fill(this.ds_FwClienti.Firmware_DB);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_FwClienti.SF_Clienti_SN'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Clienti_SNTableAdapter.Fill(this.ds_FwClienti.SF_Clienti_SN);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_FwClienti.FW_Clienti_DB'. È possibile spostarla o rimuoverla se necessario.
            this.fW_Clienti_DBTableAdapter.Fill(this.ds_FwClienti.FW_Clienti_DB);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_FwClienti.FW_Clienti'. È possibile spostarla o rimuoverla se necessario.
            this.fW_ClientiTableAdapter.Fill(this.ds_FwClienti.FW_Clienti);

            // TODO: questa riga di codice carica i dati nella tabella 'ds_FwClienti.Bouquet_RicCust'. È possibile spostarla o rimuoverla se necessario.
            this.bouquet_RicCustTableAdapter.Fill(this.ds_FwClienti.Bouquet_RicCust);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_FwClienti.Bouquet_RicStand'. È possibile spostarla o rimuoverla se necessario.
            this.bouquet_RicStandTableAdapter.Fill(this.ds_FwClienti.Bouquet_RicStand);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_FwClienti.Bouquet_PalmCust'. È possibile spostarla o rimuoverla se necessario.
            this.bouquet_PalmCustTableAdapter.Fill(this.ds_FwClienti.Bouquet_PalmCust);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_FwClienti.Bouquet_PalmStand'. È possibile spostarla o rimuoverla se necessario.
            this.bouquet_PalmStandTableAdapter.Fill(this.ds_FwClienti.Bouquet_PalmStand);

            this.sFClientiSerialNumbersFWClientiBindingSource.ResetBindings(true);
            this.sFClientiSerialNumbersFWClientiBindingSource.Sort = "SW_SortCode asc";
        }

        private void AggiornaRecord(int codnominativo, string codfw, string des1, string des2)
        {
            DataRow newrow = ds_FwClienti.FW_Clienti.NewRow();
            newrow["Cod_Nominativo"] = codnominativo;
            newrow["SW_Code"] = codfw;
            newrow["SW_Des1"] = des1;
            newrow["SW_Des2"] = des2;

            ds_FwClienti.FW_Clienti.Rows.Add(newrow);

            fW_ClientiTableAdapter.Update(newrow);

        }

        private bool RecordPresente(int codnominativo, string codfw)
        {
            string sel = "Cod_Nominativo = " + "'" + codnominativo.ToString() + "'" + " AND SW_Code = " + "'" + codfw + "'";
            DataRow[] result = ds_FwClienti.FW_Clienti_DB.Select(sel);
            if (result.Count() > 0) { return true; } else { return false; }
        }

        private void gv_PalmStand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gv_PalmStand.Columns["gv_PalmStand_Present"].Index)
            {
                DataGridViewCell cell = this.gv_PalmStand.Rows[e.RowIndex].Cells[e.ColumnIndex];
                bool fwpresente = Convert.ToBoolean(cell.Value);

                glob_firmware = this.gv_PalmStand.Rows[e.RowIndex].Cells["gv_PalmStand_Code"].Value.ToString();
                glob_des1 = this.gv_PalmStand.Rows[e.RowIndex].Cells["gv_PalmStand_DesIt"].Value.ToString();
                glob_des2 = this.gv_PalmStand.Rows[e.RowIndex].Cells["gv_PalmStand_DesEn"].Value.ToString();

                if (fwpresente) // Presente, quindi eliminare
                {
                    fW_Clienti_DBTableAdapter.DeleteQuery(glob_nominativo, glob_firmware);
                    EliminaFwClienti(glob_nominativo, glob_firmware);
                }
                else // Assente, quindi aggiungere
                {
                    AggiornaRecord(glob_nominativo, glob_firmware, glob_des1, glob_des2);
                }

                ReLoadData();
                gv_FWCliente.Refresh();
            }
        }

        private void gv_PalmCust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gv_PalmCust.Columns["gv_PalmCust_Present"].Index)
            {
                DataGridViewCell cell = this.gv_PalmCust.Rows[e.RowIndex].Cells[e.ColumnIndex];
                bool fwpresente = Convert.ToBoolean(cell.Value);

                glob_firmware = this.gv_PalmCust.Rows[e.RowIndex].Cells["gv_PalmCust_Code"].Value.ToString();
                glob_des1 = this.gv_PalmCust.Rows[e.RowIndex].Cells["gv_PalmCust_DesIt"].Value.ToString();
                glob_des2 = this.gv_PalmCust.Rows[e.RowIndex].Cells["gv_PalmCust_DesEn"].Value.ToString();

                if (fwpresente) // Presente, quindi eliminare
                {
                    fW_Clienti_DBTableAdapter.DeleteQuery(glob_nominativo, glob_firmware);
                    EliminaFwClienti(glob_nominativo, glob_firmware);
                }
                else // Assente, quindi aggiungere
                {
                    AggiornaRecord(glob_nominativo, glob_firmware, glob_des1, glob_des2);
                }

                ReLoadData();
                gv_FWCliente.Refresh();

            }
        }

        private void gv_RicStand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gv_RicStand.Columns["gv_RicStand_Present"].Index)
            {
                DataGridViewCell cell = this.gv_RicStand.Rows[e.RowIndex].Cells[e.ColumnIndex];
                bool fwpresente = Convert.ToBoolean(cell.Value);

                glob_firmware = this.gv_RicStand.Rows[e.RowIndex].Cells["gv_RicStand_Code"].Value.ToString();
                glob_des1 = this.gv_RicStand.Rows[e.RowIndex].Cells["gv_RicStand_DesIt"].Value.ToString();
                glob_des2 = this.gv_RicStand.Rows[e.RowIndex].Cells["gv_RicStand_DesEn"].Value.ToString();

                if (fwpresente) // Presente, quindi eliminare
                {
                    fW_Clienti_DBTableAdapter.DeleteQuery(glob_nominativo, glob_firmware);
                    EliminaFwClienti(glob_nominativo, glob_firmware);
                }
                else // Assente, quindi aggiungere
                {
                    AggiornaRecord(glob_nominativo, glob_firmware, glob_des1, glob_des2);
                }

                ReLoadData();
                gv_FWCliente.Refresh();
            }
        }

        private void gv_RicCust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gv_RicCust.Columns["gv_RicCust_Present"].Index)
            {
                DataGridViewCell cell = this.gv_RicCust.Rows[e.RowIndex].Cells[e.ColumnIndex];
                bool fwpresente = Convert.ToBoolean(cell.Value);

                glob_firmware = this.gv_RicCust.Rows[e.RowIndex].Cells["gv_RicCust_Code"].Value.ToString();
                glob_des1 = this.gv_RicCust.Rows[e.RowIndex].Cells["gv_RicCust_DesIt"].Value.ToString();
                glob_des2 = this.gv_RicCust.Rows[e.RowIndex].Cells["gv_RicCust_DesEn"].Value.ToString();

                if (fwpresente) // Presente, quindi eliminare
                {
                    fW_Clienti_DBTableAdapter.DeleteQuery(glob_nominativo, glob_firmware);
                    EliminaFwClienti(glob_nominativo, glob_firmware);
                }
                else // Assente, quindi aggiungere
                {
                    AggiornaRecord(glob_nominativo, glob_firmware, glob_des1, glob_des2);
                }

                ReLoadData();
                gv_FWCliente.Refresh();
            }
        }

        private void sFClientiSerialNumbersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView currentcli = (DataRowView)sFClientiSerialNumbersBindingSource.Current;
            glob_nominativo = (int)currentcli["CodAnagrafico"];
        }

        private void ExecCmd()
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"\\192.168.0.8\sistematica\AREA_FIRMWARE\SmartLine\db_sync-win.exe",
                    UseShellExecute = true,
                    RedirectStandardOutput = false,
                    CreateNoWindow = true
                }
            };

            proc.Start();
        }

        private void EliminaFwClienti(int codnominativo, string codfw)
        {
            string select = "Cod_Nominativo = " + "'" + codnominativo.ToString() + "'" + " AND SW_Code = " + "'" + codfw + "'";
            var rows = ds_FwClienti.FW_Clienti.Select(select);
            foreach (var row in rows)
                row.Delete();
        }
    }
}
