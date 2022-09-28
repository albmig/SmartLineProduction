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

namespace SmartLineProduction
{
    public partial class UC_SchedeProdotti : MetroFramework.Forms.MetroForm
    {
        public UC_SchedeProdotti()
        {
            InitializeComponent();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_SchedeProdotti_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_DistinteBasi'. È possibile spostarla o rimuoverla se necessario.
            this.sF_DistinteBasiTableAdapter.FillBy_Kit(this.ds_SL.SF_DistinteBasi);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_ItemDevice_FW_Des'. È possibile spostarla o rimuoverla se necessario.
            //this.sF_ItemDevice_FW_DesTableAdapter.Fill(this.ds_SL.SF_ItemDevice_FW_Des);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_ArticoliSchede'. È possibile spostarla o rimuoverla se necessario.
            this.sF_ArticoliSchedeTableAdapter.Fill(this.ds_SL.SF_ArticoliSchede);

            SetView();
        }

        private void tab_Kit_Enter(object sender, EventArgs e)
        {
            this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdottoKit(this.ds_SL.SF_ArticoliSchede);
            gv_Kit.Refresh();
        }

        private void sFArticoliSchedeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (Tab_Schede.SelectedTab == Tab_Schede.TabPages["tab_Kit"])
            {
                DataRowView drview = (DataRowView)sFArticoliSchedeBindingSource.Current;
                if (drview == null) { return; }

                string articolo = drview["Articolo"].ToString();

                if (articolo.Substring(0, 4) != "XKIT") { return; }

                string path = Properties.Settings.Default.Doc_folder;
                path = path + @"XKIT\";
                string path_it = path + drview["Articolo"].ToString() + @"\IT\" + drview["Articolo"].ToString() + ".pdf";
                string path_en = path + drview["Articolo"].ToString() + @"\EN\" + drview["Articolo"].ToString() + ".pdf";

                if (System.IO.File.Exists(path_it)) { Kit_pdf_it.LoadFile(path_it); } else { Kit_pdf_it.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
                if (System.IO.File.Exists(path_en)) { Kit_pdf_en.LoadFile(path_en); } else { Kit_pdf_en.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
                SetPDFReader();
            }

            if (Tab_Schede.SelectedTab == Tab_Schede.TabPages["tab_Cablaggi"])
            {

                DataRowView drview = (DataRowView)sFArticoliSchedeBindingSource.Current;
                if (drview == null) { return; }

                string articolo = drview["Articolo"].ToString();

                string path = Properties.Settings.Default.Doc_folder;
                path = path + @"XCBL\";

                // Cerca il folder giusto
                string cblstart = articolo + "*";
                string[] dirs = Directory.GetDirectories(path, cblstart, SearchOption.TopDirectoryOnly);

                foreach (string dir in dirs)
                {
                    string path_it = dir + @"\IT\" + drview["Articolo"].ToString() + ".pdf";
                    string path_en = dir + @"\EN\" + drview["Articolo"].ToString() + ".pdf";

                    if (System.IO.File.Exists(path_it)) { Cablaggi_pdf_it.LoadFile(path_it); } else { Cablaggi_pdf_it.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
                    if (System.IO.File.Exists(path_en)) { Cablaggi_pdf_en.LoadFile(path_en); } else { Cablaggi_pdf_en.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
                    SetPDFReader();
                }

                if ((dirs != null) && (!dirs.Any()))
                {
                    Cablaggi_pdf_it.LoadFile(@"Resources\Pdf_notpresent.pdf");
                    Cablaggi_pdf_en.LoadFile(@"Resources\Pdf_notpresent.pdf");
                    SetPDFReader();
                }
            }

            if (Tab_Schede.SelectedTab == Tab_Schede.TabPages["tab_FW_P"])
            {

                DataRowView drview = (DataRowView)sFArticoliSchedeBindingSource.Current;
                if (drview == null) { return; }

                string articolo = drview["Articolo"].ToString();

                string path = Properties.Settings.Default.Doc_folder;
                path = path + @"XSWRP\";

                string path_it = path + drview["Articolo"].ToString() + @"\IT\" + drview["Articolo"].ToString() + ".pdf";
                string path_en = path + drview["Articolo"].ToString() + @"\EN\" + drview["Articolo"].ToString() + ".pdf";

                if (System.IO.File.Exists(path_it)) { FW_P_pdf_it.LoadFile(path_it); } else { FW_P_pdf_it.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
                if (System.IO.File.Exists(path_en)) { FW_P_pdf_en.LoadFile(path_en); } else { FW_P_pdf_en.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
                SetPDFReader();
            }

            if (Tab_Schede.SelectedTab == Tab_Schede.TabPages["tab_FW_R"])
            {

                DataRowView drview = (DataRowView)sFArticoliSchedeBindingSource.Current;
                if (drview == null) { return; }

                string articolo = drview["Articolo"].ToString();

                string path = Properties.Settings.Default.Doc_folder;
                path = path + @"XSWRR\";

                string path_it = path + drview["Articolo"].ToString() + @"\IT\" + drview["Articolo"].ToString() + ".pdf";
                string path_en = path + drview["Articolo"].ToString() + @"\EN\" + drview["Articolo"].ToString() + ".pdf";

                if (System.IO.File.Exists(path_it)) { FW_R_pdf_it.LoadFile(path_it); } else { FW_R_pdf_it.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
                if (System.IO.File.Exists(path_en)) { FW_R_pdf_en.LoadFile(path_en); } else { FW_R_pdf_en.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
                SetPDFReader();
            }

            if (Tab_Schede.SelectedTab == Tab_Schede.TabPages["tab_pack_doc"])
            {
                CreaTreeView();
            }
        }

        private void CreaTreeView()
        {
            DataTable dt_treeview = new DataTable();
            dt_treeview.Clear();
            dt_treeview.Columns.Add("DisplayMember", typeof(string));
            dt_treeview.Columns.Add("ChildMember", typeof(string));
            dt_treeview.Columns.Add("ParentMember", typeof(string));
            dt_treeview.Columns.Add("ValueMember", typeof(string));

            DataRowView drview = (DataRowView)sFArticoliSchedeBindingSource.Current;
            if (drview == null) { return; }
            string filtro = "ArticoloComposto = " + "'" + drview["Articolo"].ToString() + "'";
            sFDistinteBasiBindingSource.Filter = filtro;
            sFDistinteBasiBindingSource.Sort = "ProgrComponente Asc";

            DataRow newrecpadre = dt_treeview.NewRow();
            newrecpadre["DisplayMember"] = drview["Articolo"].ToString();
            newrecpadre["ChildMember"] = "1";
            newrecpadre["ParentMember"] = "";
            newrecpadre["ValueMember"] = drview["Articolo"].ToString();
            dt_treeview.Rows.Add(newrecpadre);


            foreach (DataRowView bs_row in sFDistinteBasiBindingSource)
            {
                if (bs_row["DataFineValidita"] != "") { continue; }

                DataRow newrec = dt_treeview.NewRow();
                newrec["DisplayMember"] = bs_row["ArticoloComposto"];
                newrec["ChildMember"] = "2" ;
                newrec["ParentMember"] = "1";
                newrec["ValueMember"] = bs_row["ArticoloComponente"];
                dt_treeview.Rows.Add(newrec);
            }

            MessageBox.Show("aaa");
            treeViewAdv1.SelfRelationRootValue = "";
            treeViewAdv1.DisplayMember = "DisplayMember";
            treeViewAdv1.ParentMember = "ParentMember";
            treeViewAdv1.ChildMember = "ChildMember";
            treeViewAdv1.ValueMember = "ValueMember";
            //treeViewAdv1.CheckedMember = "IsActive";
            treeViewAdv1.DataSource = dt_treeview;
        }

        private void SetPDFReader()
        {
            Kit_pdf_it.setView("FitV");
            Kit_pdf_en.setView("FitV");
            Palmari_pdf_it.setView("FitV");
            Palmari_pdf_en.setView("FitV");
            Ricevitori_pdf_it.setView("FitV");
            Ricevitori_pdf_en.setView("FitV");
            Cablaggi_pdf_it.setView("FitV");
            Cablaggi_pdf_en.setView("FitV");
            FW_P_pdf_it.setView("FitV");
            FW_P_pdf_en.setView("FitV");
            FW_R_pdf_it.setView("FitV");
            FW_R_pdf_en.setView("FitV");

            Kit_pdf_it.setShowScrollbars(false);
            Kit_pdf_en.setShowScrollbars(false);
            Palmari_pdf_it.setShowScrollbars(false);
            Palmari_pdf_en.setShowScrollbars(false);
            Ricevitori_pdf_it.setShowScrollbars(false);
            Ricevitori_pdf_en.setShowScrollbars(false);
            Cablaggi_pdf_it.setShowScrollbars(false);
            Cablaggi_pdf_en.setShowScrollbars(false);
            FW_P_pdf_it.setShowScrollbars(false);
            FW_P_pdf_en.setShowScrollbars(false);
            FW_R_pdf_it.setShowScrollbars(false);
            FW_R_pdf_en.setShowScrollbars(false);

            Kit_pdf_it.setShowToolbar(false);
            Kit_pdf_en.setShowToolbar(false);
            Palmari_pdf_it.setShowToolbar(false);
            Palmari_pdf_en.setShowToolbar(false);
            Ricevitori_pdf_it.setShowToolbar(false);
            Ricevitori_pdf_en.setShowToolbar(false);
            Cablaggi_pdf_it.setShowToolbar(false);
            Cablaggi_pdf_en.setShowToolbar(false);
            FW_P_pdf_it.setShowToolbar(false);
            FW_P_pdf_en.setShowToolbar(false);
            FW_R_pdf_it.setShowToolbar(false);
            FW_R_pdf_en.setShowToolbar(false);

            Kit_pdf_it.setPageMode("none");
            Kit_pdf_en.setPageMode("none");
            Palmari_pdf_it.setPageMode("none");
            Palmari_pdf_en.setPageMode("none");
            Ricevitori_pdf_it.setPageMode("none");
            Ricevitori_pdf_en.setPageMode("none");
            Cablaggi_pdf_it.setPageMode("none");
            Cablaggi_pdf_en.setPageMode("none");
            FW_P_pdf_it.setPageMode("none");
            FW_P_pdf_en.setPageMode("none");
            FW_R_pdf_it.setPageMode("none");
            FW_R_pdf_en.setPageMode("none");
        }

        private void SetView()
        {
            tb_grid_kit.Text = "";
            tb_grid_palmari.Text = "";
            tb_grid_ricevitori.Text = "";
            tb_grid_cablaggi.Text = "";
            tb_grid_FW_P.Text = "";
            tb_grid_FW_R.Text = "";
            Tab_Schede.SelectTab("tab_Kit");
        }

        private void tb_grid_kit_TextChanged(object sender, EventArgs e)
        {
            string filtro = string.Format("Articolo LIKE '%{0}%'", tb_grid_kit.Text);
            sFArticoliSchedeBindingSource.Filter = filtro;
            tb_grid_kit.Focus();
        }

        private void sFItemDeviceFWDesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (Tab_Schede.SelectedTab == Tab_Schede.TabPages["tab_Palmari"])
            {
                if (Palmari_pdf_it.src != null) { Palmari_pdf_it.LoadFile("Empty"); }
                if (Palmari_pdf_en.src != null) { Palmari_pdf_en.LoadFile("Empty"); }

                DataRowView drview = (DataRowView)sFItemDeviceFWDesBindingSource.Current;
                if (drview == null) { return; }

                string articolo = drview["Articolo_Device"].ToString();
                string famdevice = drview["FamDevice"].ToString();
                string tipodevice = drview["TipoDevice"].ToString();

                string path = Properties.Settings.Default.Doc_folder;
                path = path + famdevice + @"\";
                string path_it = path + drview["Articolo_Device"].ToString() + @"\IT\" + drview["Articolo_Device"].ToString() + ".pdf";
                string path_en = path + drview["Articolo_Device"].ToString() + @"\EN\" + drview["Articolo_Device"].ToString() + ".pdf";

                if (System.IO.File.Exists(path_it)) { Palmari_pdf_it.LoadFile(path_it); } else { Palmari_pdf_it.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
                if (System.IO.File.Exists(path_en)) { Palmari_pdf_en.LoadFile(path_en); } else { Palmari_pdf_en.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
                SetPDFReader();
            }

            if (Tab_Schede.SelectedTab == Tab_Schede.TabPages["tab_Ricevitori"])
            {
                if (Ricevitori_pdf_it.src != null) { Ricevitori_pdf_it.LoadFile("Empty"); }
                if (Ricevitori_pdf_en.src != null) { Ricevitori_pdf_en.LoadFile("Empty"); }

                DataRowView drview = (DataRowView)sFItemDeviceFWDesBindingSource.Current;
                if (drview == null) { return; }

                string articolo = drview["Articolo_Device"].ToString();
                string famdevice = drview["FamDevice"].ToString();
                string tipodevice = drview["TipoDevice"].ToString();
                string numfunzioni = drview["NumFunzioni"].ToString();

                string path = Properties.Settings.Default.Doc_folder;
                path = path + famdevice + numfunzioni + @"\";
                string path_it = path + drview["Articolo_Device"].ToString() + @"\IT\" + drview["Articolo_Device"].ToString() + ".pdf";
                string path_en = path + drview["Articolo_Device"].ToString() + @"\EN\" + drview["Articolo_Device"].ToString() + ".pdf";

                if (System.IO.File.Exists(path_it)) { Ricevitori_pdf_it.LoadFile(path_it); } else { Ricevitori_pdf_it.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
                if (System.IO.File.Exists(path_en)) { Ricevitori_pdf_en.LoadFile(path_en); } else { Ricevitori_pdf_en.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
                SetPDFReader();
            }

        }

        private void tab_Palmari_Enter(object sender, EventArgs e)
        {
            this.sF_ItemDevice_FW_DesTableAdapter.FillBy_SchedeProdottoPalmari(this.ds_SL.SF_ItemDevice_FW_Des);
            gv_Palmari.Refresh();

        }

        private void tb_grid_palmari_TextChanged(object sender, EventArgs e)
        {
            string filtro = string.Format("Articolo_Device LIKE '%{0}%'", tb_grid_palmari.Text);
            sFItemDeviceFWDesBindingSource.Filter = filtro;
            tb_grid_palmari.Focus();
        }

        private void tab_Ricevitori_Enter(object sender, EventArgs e)
        {
            this.sF_ItemDevice_FW_DesTableAdapter.FillBy_SchedeProdottoRicevitori(this.ds_SL.SF_ItemDevice_FW_Des);
            gv_Ricevitori.Refresh();
        }

        private void tb_grid_ricevitori_TextChanged(object sender, EventArgs e)
        {
            string filtro = string.Format("Articolo_Device LIKE '%{0}%'", tb_grid_ricevitori.Text);
            sFItemDeviceFWDesBindingSource.Filter = filtro;
        }

        private void tab_Cablaggi_Enter(object sender, EventArgs e)
        {
            this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdottoCablaggi(this.ds_SL.SF_ArticoliSchede);
            gv_Cablaggi.Refresh();
        }

        private void tb_grid_cablaggi_TextChanged(object sender, EventArgs e)
        {
            string filtro = string.Format("Articolo LIKE '%{0}%'", tb_grid_cablaggi.Text);
            sFArticoliSchedeBindingSource.Filter = filtro;
            tb_grid_cablaggi.Focus();
        }

        private void tab_FW_P_Enter(object sender, EventArgs e)
        {
            radio_FW_P_all.Checked = true;
            radio_FW_P_standard.Checked = false;
            radio_FW_P_custom.Checked = false;
            GVar.gl_tipofiltro_FW_P = "A";

            LoadData_FW_P();
            gv_FW_P.Refresh();
        }

        private void LoadData_FW_P()
        {
            switch (GVar.gl_tipofiltro_FW_P)
            {
                case "S":
                    this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdotto_Fw_P_Standard(this.ds_SL.SF_ArticoliSchede);
                    break;
                case "C":
                    this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdotto_Fw_P_Custom(this.ds_SL.SF_ArticoliSchede);
                    break;
                case "A":
                    this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdottoFw_P(this.ds_SL.SF_ArticoliSchede);
                    break;
                default:
                    this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdottoFw_P(this.ds_SL.SF_ArticoliSchede);
                    break;
            }
        }

        private void LoadData_FW_R()
        {
            switch (GVar.gl_tipofiltro_FW_R)
            {
                case "S":
                    this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdotto_Fw_R_Standard(this.ds_SL.SF_ArticoliSchede);
                    break;
                case "C":
                    this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdotto_Fw_R_Custom(this.ds_SL.SF_ArticoliSchede);
                    break;
                case "A":
                    this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdottoFw_R(this.ds_SL.SF_ArticoliSchede);
                    break;
                default:
                    this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdottoFw_R(this.ds_SL.SF_ArticoliSchede);
                    break;
            }
        }

        private void tab_FW_R_Enter(object sender, EventArgs e)
        {
            radio_FW_R_all.Checked = true;
            radio_FW_R_standard.Checked = false;
            radio_FW_R_custom.Checked = false;
            GVar.gl_tipofiltro_FW_R = "A";

            LoadData_FW_R();
            gv_FW_R.Refresh();
        }

        private void radio_FW_P_all_CheckedChanged(object sender, EventArgs e)
        {
            GVar.gl_tipofiltro_FW_P = "A";
            LoadData_FW_P();
            gv_FW_P.Refresh();
        }

        private void radio_FW_P_standard_CheckedChanged(object sender, EventArgs e)
        {
            GVar.gl_tipofiltro_FW_P = "S";
            LoadData_FW_P();
            gv_FW_P.Refresh();
        }

        private void radio_FW_P_custom_CheckedChanged(object sender, EventArgs e)
        {
            GVar.gl_tipofiltro_FW_P = "C";
            LoadData_FW_P();
            gv_FW_P.Refresh();
        }

        private void radio_FW_R_all_CheckedChanged(object sender, EventArgs e)
        {
            GVar.gl_tipofiltro_FW_R = "A";
            LoadData_FW_R();
            gv_FW_R.Refresh();
        }

        private void radio_FW_R_standard_CheckedChanged(object sender, EventArgs e)
        {
            GVar.gl_tipofiltro_FW_R = "S";
            LoadData_FW_R();
            gv_FW_R.Refresh();
        }

        private void radio_FW_R_custom_CheckedChanged(object sender, EventArgs e)
        {
            GVar.gl_tipofiltro_FW_R = "C";
            LoadData_FW_R();
            gv_FW_R.Refresh();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Get the folder path into DirectoryInfo
            string path = @"C:\Users\Sistematica\Desktop\mergepdf";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            //Get the PDF files in folder path into FileInfo
            FileInfo[] files = directoryInfo.GetFiles("*.pdf");

            //Create a new PDF document 
            PdfDocument document = new PdfDocument();

            //Set enable memory optimization as true 
            document.EnableMemoryOptimization = true;

            foreach (FileInfo file in files)
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
            string pathout = path + @"\" + "MergedPDF.pdf";
            document.Save(pathout);

            //Close the instance of PdfDocument
            document.Close(true);
        }

    }
}
