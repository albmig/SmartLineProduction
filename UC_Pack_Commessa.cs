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
using Syncfusion.Windows.Forms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using SmartLineProduction.ds_SLTableAdapters;

namespace SmartLineProduction
{
    public partial class UC_Pack_Commessa : MetroFramework.Forms.MetroForm
    {
        public UC_Pack_Commessa()
        {
            InitializeComponent();
        }

        //// LOAD
        private void UC_Pack_Commessa_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_Commesse_SL'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Commesse_SLTableAdapter.FillBy_CommessePack(this.ds_Programmazione.SF_Commesse_SL);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL1.SF_Commesse_SL_Pack_Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Commesse_SL_Pack_CommesseTableAdapter.Fill(this.ds_SL.SF_Commesse_SL_Pack_Commesse);

            SetView();
        }

        //// CONTROLS EVENTS
        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tab_pack_doc_Enter(object sender, EventArgs e)
        {
        }

        private void btn_do_pack_kit_Click(object sender, EventArgs e)
        {
            //Get the folder path into DirectoryInfo
            string temppath = @"C:\SEFactoryTemp";
            bool exists = System.IO.Directory.Exists(temppath);
            if (!exists) System.IO.Directory.CreateDirectory(temppath);

            // Delete all files
            System.IO.DirectoryInfo di = new DirectoryInfo(temppath);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }

            //Download needed files
            Application.UseWaitCursor = true;
            foreach (DataGridViewRow row in gv_pack_explo.Rows)
            {
                if ((bool)row.Cells["gv_pack_explo_daincludere"].Value == false) { continue; }

                string nomfile = System.IO.Path.GetFileName(row.Cells["gv_pack_explo_Path"].Value.ToString());
                string destfile = temppath + @"\" + nomfile;
                System.IO.File.Copy(row.Cells["gv_pack_explo_Path"].Value.ToString(), destfile, true);
            }
            Application.UseWaitCursor = false;


            //DirectoryInfo directoryInfo = new DirectoryInfo(temppath);

            //Get the PDF files in folder path into FileInfo
            //FileInfo[] files = directoryInfo.GetFiles("*.pdf");
            var sorted = Directory.GetFiles(temppath, "*.pdf").Select(fn => new FileInfo(fn)).OrderBy(f => f.Name); ;

            //Create a new PDF document 
            PdfDocument document = new PdfDocument();

            //Set enable memory optimization as true 
            document.EnableMemoryOptimization = true;

            foreach (FileInfo file in sorted)
            {
                //Load the PDF document 
                FileStream fileStream = new FileStream(file.FullName, FileMode.Open);
                PdfLoadedDocument loadedDocument = new PdfLoadedDocument(fileStream);

                //Merge PDF file
                PdfDocumentBase.Merge(document, loadedDocument);

                //Close the existing PDF document 
                loadedDocument.Close(true);
            }

            //Save the PDF document
            string pathout = temppath + @"\" + "MergedPDF.pdf";
            document.Save(pathout);

            //Close the instance of PdfDocument
            document.Close(true);

            pack_Kit_pdf.LoadFile(pathout);
            panel_pack_kit.Visible = true;
        }

        private void cb_Doc_IT_Click(object sender, EventArgs e)
        {
            switch (cb_Doc_IT.CheckState)
            {
                case CheckState.Checked:
                    cb_Doc_EN.Checked = false;
                    break;
                case CheckState.Unchecked:
                    cb_Doc_EN.Checked = true;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            ConvertiLinguaDoc("IT");
        }

        private void cb_Doc_EN_Click(object sender, EventArgs e)
        {
            switch (cb_Doc_EN.CheckState)
            {
                case CheckState.Checked:
                    cb_Doc_IT.Checked = false;
                    break;
                case CheckState.Unchecked:
                    cb_Doc_IT.Checked = true;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
            ConvertiLinguaDoc("EN");
        }

        private void tb_grid_commessa_pack_TextChanged(object sender, EventArgs e)
        {
            string filtro = string.Format("CommessaShort LIKE '%{0}%'", tb_grid_commessa_pack.Text);
            sFCommesseSLPackCommesseBindingSource.Filter = filtro;
            tb_grid_commessa_pack.Focus();
        }

        //// OTHER ROUTINES
        private void SetPDFReader()
        {
            pack_Kit_pdf.setView("FitV");

            pack_Kit_pdf.setShowScrollbars(false);

            pack_Kit_pdf.setShowToolbar(false);

            pack_Kit_pdf.setPageMode("none");
        }

        private void CreaTreeView(DataRowView drview)
        {
            if (drview == null) { return; }
            //DataTable dt_treeview = new DataTable();
            string filtro = "CommessaShort = " + "'" + drview["CommessaShort"].ToString() + "'";
            DataView dv = ds_Programmazione.SF_Commesse_SL.DefaultView;
            dv.RowFilter = filtro;
            gv_pack_explo.DataSource = dv;

            string linguadoc = "";
            if (cb_Doc_IT.Checked) { linguadoc = "IT"; }
            if (cb_Doc_EN.Checked) { linguadoc = "EN"; }

            //Riempio Path e Check
            foreach (DataGridViewRow row in gv_pack_explo.Rows)
            {
                row.Cells["gv_pack_explo_daincludere"].Value = true;

                if (row.Cells["gv_pack_explo_isKit"].Value.ToString() == "1")
                {
                    row.Cells["gv_pack_explo_Path"].Value = TrovaPath("Kit", row.Cells["gv_pack_explo_artcommessa"].Value.ToString(), linguadoc);
                }
                if (row.Cells["gv_pack_explo_isSWRP"].Value.ToString() == "1")
                {
                    row.Cells["gv_pack_explo_Path"].Value = TrovaPath("Swr", row.Cells["gv_pack_explo_artcommessa"].Value.ToString(), linguadoc);
                }
                if (row.Cells["gv_pack_explo_isSWRR"].Value.ToString() == "1")
                {
                    row.Cells["gv_pack_explo_Path"].Value = TrovaPath("Swr", row.Cells["gv_pack_explo_artcommessa"].Value.ToString(), linguadoc);
                }
            }
        }

        private string TrovaPath(string tiporicerca, string codice, string lingua)
        {
            string path = Properties.Settings.Default.Doc_folder;
            string sigla = codice.Substring(4, 2);

            if ((tiporicerca == "Kit") && (lingua == "IT"))
            {
                path = path + @"XKIT\" + sigla + @"\";
                string path_it = path + codice + @"\IT\" + codice + ".pdf";
                return path_it;
            }
            if ((tiporicerca == "Kit") && (lingua == "EN"))
            {
                path = path + @"XKIT\" + sigla + @"\";
                string path_en = path + codice + @"\EN\" + codice + ".pdf";
                return path_en;
            }
            if (tiporicerca == "Swr")
            {
                if (codice.StartsWith("XSWRP")) { path = path + @"XSWRP\"; }
                if (codice.StartsWith("XSWRR")) { path = path + @"XSWRR\"; }

                if (lingua == "IT") { string path_it = path + codice + @"\IT\" + codice + ".pdf"; return path_it; }
                if (lingua == "EN") { string path_en = path + codice + @"\EN\" + codice + ".pdf"; return path_en; }
            }

            return null;
        }

        private void SetView()
        {
            tb_grid_commessa_pack.Text = "";
            gv_pack_explo.Columns["gv_pack_explo_artcommessa"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gv_pack_explo.Columns["gv_pack_explo_qtaord"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_pack_explo.Columns["gv_pack_explo_qta_evadere"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_pack_explo.Columns["gv_pack_explo_device"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gv_pack_explo.Columns["gv_pack_explo_swdevice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gv_pack_explo.Columns["gv_pack_explo_daincludere"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void ConvertiLinguaDoc(string lingua)
        {
            foreach (DataGridViewRow row in gv_pack_explo.Rows)
            {
                string path = row.Cells["gv_pack_explo_Path"].Value.ToString();
                string prefit = @"\IT\";
                string prefen = @"\EN\";

                string newpath = "";
                if (lingua == "IT") { newpath = path.Replace(prefen, prefit); }
                if (lingua == "EN") { newpath = path.Replace(prefit, prefen); }
                row.Cells["gv_pack_explo_Path"].Value = newpath;
            }

        }

        private void sFCommesseSLPackCommesseBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            cb_Doc_IT.Checked = true;
            cb_Doc_EN.Checked = false;

            DataRowView drview = (DataRowView)sFCommesseSLPackCommesseBindingSource.Current;

            CreaTreeView(drview);
            SetPDFReader();

            panel_pack_kit.Visible = false;
        }
    }
}
