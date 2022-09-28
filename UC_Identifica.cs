using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace SmartLineProduction
{
    public partial class UC_Identifica : MetroFramework.Forms.MetroForm
    {

        private string numerimancanti = "";

        public UC_Identifica()
        {
            InitializeComponent();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_Identifica_Load(object sender, EventArgs e)
        {
            Splash SplashDB = new Splash();
            SplashDB.Show();

            Cursor.Current = Cursors.WaitCursor;

            // TODO: questa riga di codice carica i dati nella tabella 'ds_QuerySN.LottiSpedizione'. È possibile spostarla o rimuoverla se necessario.
            this.lottiSpedizioneTableAdapter.Fill(this.ds_QuerySN.LottiSpedizione);

            // TODO: questa riga di codice carica i dati nella tabella 'ds_QuerySN.SF_OrdiniDDT_SerialNumbers'. È possibile spostarla o rimuoverla se necessario.
            this.sF_OrdiniDDT_SerialNumbersTableAdapter.Fill(this.ds_QuerySN.SF_OrdiniDDT_SerialNumbers);

            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_sn_moma'. È possibile spostarla o rimuoverla se necessario.
            this.sF_sn_momaTableAdapter.Fill(this.ds_QuerySN.SF_sn_moma);

            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_SN_Query'. È possibile spostarla o rimuoverla se necessario.
            this.sF_SN_QueryTableAdapter.Fill(this.ds_QuerySN.SF_SN_Query);

            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_SN_CicloAttivo_Kit'. È possibile spostarla o rimuoverla se necessario.
            this.sF_SN_CicloAttivo_KitTableAdapter.Fill(this.ds_QuerySN.SF_SN_CicloAttivo_Kit);

            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_SN_CicloAttivo_Kit'. È possibile spostarla o rimuoverla se necessario.
            this.sF_SN_artaTableAdapter.Fill(this.ds_QuerySN.SF_SN_arta);

            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_SN_arsn'. È possibile spostarla o rimuoverla se necessario.
            this.sF_SN_arsnTableAdapter.Fill(this.ds_QuerySN.SF_SN_arsn);

            Cursor.Current = Cursors.Default;

            sFSNarsnBindingSource.MoveFirst();
            sFSNarsnSFSNartaBindingSource.ResetBindings(true);
            sFSNarsnSFSNQueryBindingSource.ResetBindings(true);
            sFSNarsnSFSNCicloAttivoKitBindingSource.ResetBindings(true);
            sFSNCicloAttivoKitSFOrdiniDDTSerialNumbersBindingSource.ResetBindings(true);
            sFSNarsnLottiSpedizioneBindingSource.ResetBindings(true);

            SplashDB.Close();


            tb_search.Text = "";
        }

        private void verificaSaltiNumerazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!VerificaSalti())
            {
                MessageBox.Show("Nessun salto di numerazione rilevato!");
            }
            else
            {
                string text = "Salto di numerazione rilevato!" + "\n" + numerimancanti;
                MessageBox.Show(text);
            }
        }

        private bool VerificaSalti()
        {
            object firstsn = this.ds_QuerySN.SF_SN_arsn.Compute("MIN(SerialNumber)", null);
            object lastsn = this.ds_QuerySN.SF_SN_arsn.Compute("MAX(SerialNumber)", null);
            int primo = Convert.ToInt32(firstsn);
            int ultimo = Convert.ToInt32(lastsn);
            int conta = primo;
            sFSNarsnBindingSource.MoveFirst();
            foreach (DataRowView snrow in sFSNarsnBindingSource)
            {
                int snletto = Convert.ToInt32(snrow["SerialNumber"]);
                if (snletto != conta)
                {
                    for (int i = conta; i < snletto; i++)
                    {
                        conta = i;
                        numerimancanti = numerimancanti + conta.ToString() + "//";
                    }
                }
                conta++;
            }

            if (numerimancanti == "") return false; else return true;
        }

        private void sFSNarsnSFSNQueryBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            DataRowView serialrow = (DataRowView)sFSNarsnSFSNQueryBindingSource.Current;
            if (serialrow == null)
            {
                panel_Smartline.Visible = false;
            }
            else
            {
                panel_Smartline.Visible = true;
            }

            if (panel_Smartline.Visible) { TrovaPdf(serialrow["Ser_Device"].ToString()); }
        }

        private void gv_CicloAttivo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) { return; }

            DataGridViewCell cell = this.gv_CicloAttivo.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewRow gridRow = gv_CicloAttivo.Rows[e.RowIndex];
            if ((gv_CicloAttivo.Columns[e.ColumnIndex].Name == "gv_CicloAttivo_ArticoloOrdine") && (e.Value != null))
            {
                string ArtOrd = e.Value.ToString();
                if (ArtOrd.StartsWith("XKIT"))
                {
                    cell.Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
                }
            }
        }

        private void sFSNarsnSFSNCicloAttivoKitBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            DataRowView ciclorow = (DataRowView)sFSNarsnSFSNCicloAttivoKitBindingSource.Current;
            if (ciclorow == null)
            {
                gv_CicloAttivo.Visible = false;
                gv_moma.Visible = false;
                return;
            }

            gv_CicloAttivo.Visible = true;

            string articolo = ciclorow["Articolo"].ToString();
            string articolokit = ciclorow["Articolo_Ordine"].ToString();
            string comm = ciclorow["Commessa"].ToString();

            if (articolokit != articolo)
            {
                gv_moma.Visible = true;

                string filtro = "Commessa = " + "'" + comm + "'" + " AND Articolo = " + "'" + articolokit + "'";
                sFsnmomaBindingSource.Filter = filtro;
            }
            else
            {
                gv_moma.Visible = false;
            }
        }

        private void gv_moma_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) { return; }

            DataGridViewCell cell = this.gv_moma.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewRow gridRow = gv_moma.Rows[e.RowIndex];
            if ((gv_moma.Columns[e.ColumnIndex].Name == "gv_Moma_Articolo") && (e.Value != null))
            {
                string ArtOrd = e.Value.ToString();
                if (ArtOrd.StartsWith("XKIT"))
                {
                    cell.Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
                }
            }

        }

        private void TrovaPdf(string articolo)
        {
            //Calcolo del path
            string path = Properties.Settings.Default.Doc_folder;
            string path_it = "";
            string btn_view = articolo.Substring(5, 1); // K-P-R-C-FR-FP
            string sigla = "";
            string famiglia = "";

            switch (btn_view)
            {
                case "P":
                    sigla = articolo.Substring(7, 2);
                    famiglia = articolo.Substring(0, 3);

                    path = path + famiglia + @"\" + sigla + @"\";
                    path_it = path + articolo + @"\IT\" + articolo + ".pdf";
                    break;
                case "R":
                    sigla = articolo.Substring(7, 2);
                    famiglia = articolo.Substring(0, 5);
                    path = path + famiglia + @"\" + sigla + @"\";
                    path_it = path + articolo + @"\IT\" + articolo + ".pdf";
                    break;
            }

            //if (System.IO.File.Exists(path_it)) { Schede_pdf_it.LoadFile(path_it); } else { Schede_pdf_it.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
            if (System.IO.File.Exists(path_it)) { Schede_pdf_it.LoadDocument(path_it); } else { Schede_pdf_it.LoadDocument(@"Resources\Pdf_notpresent.pdf"); }
            SetPDFReader();

        }

        private void SetPDFReader()
        {
            //Schede_pdf_it.setView("FitV");
            //Schede_pdf_it.setShowScrollbars(false);
            //Schede_pdf_it.setShowToolbar(false);
            //Schede_pdf_it.setPageMode("none");
            //Schede_pdf_it.setLayoutMode("SinglePage");
            Schede_pdf_it.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth;
            Schede_pdf_it.NavigationPaneVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            string filtro = string.Format("SerialNumber LIKE '%{0}%'", tb_search.Text);
            sFSNarsnBindingSource.Filter = filtro;
        }

        private void gv_DDT_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) { return; }

            DataGridViewCell cell = this.gv_Lotti.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewRow gridRow = gv_Lotti.Rows[e.RowIndex];
            if ((gv_Lotti.Columns[e.ColumnIndex].Name == "gv_DDT_ArticoloTrimmed") && (e.Value != null))
            {
                string ArtOrd = e.Value.ToString();
                if (ArtOrd.StartsWith("XKIT"))
                {
                    cell.Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
                }
            }

        }

        private void Schede_pdf_it_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (var form = new UC_PdfReader("XKITSE001XXUX_L", @"\\192.168.0.8\sistematica\AREA_PRODOTTO\SMARTLINE\XKIT\SE\XKITSE001XXUX_L\IT\XKITSE001XXUX_L.pdf"))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                }
            }

        }
    }
}
