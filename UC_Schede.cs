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
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace SmartLineProduction
{
    public partial class UC_Schede : MetroFramework.Forms.MetroForm
    {
        private string btn_view = "K"; // K-P-R-C-FR-FP
        private string siglacli = "";
        private string glob_articolo = "";
        string path_it = "";
        string path_en = "";

        public UC_Schede()
        {
            InitializeComponent();
        }

        //// LOAD
        private void UC_Schede_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_ArticoliSchede'. È possibile spostarla o rimuoverla se necessario.
            this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdottoKit(this.ds_SL.SF_ArticoliSchede);
            //this.sF_ArticoliSchedeTableAdapter.Fill(this.ds_SL.SF_ArticoliSchede);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.Tab_Siglacli'. È possibile spostarla o rimuoverla se necessario.
            this.tab_SiglacliTableAdapter.FillBy_Tab_SIGLACLI(this.ds_SL.Tab_Siglacli);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_Articoli'. È possibile spostarla o rimuoverla se necessario.
            //this.sF_ArticoliTableAdapter.Fill(this.ds_SL.SF_Articoli);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.Fam_Prod'. È possibile spostarla o rimuoverla se necessario.
            this.fam_ProdTableAdapter.FillBy_SchedePack(this.ds_SL.Fam_Prod);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_DistinteBasi_Schede'. È possibile spostarla o rimuoverla se necessario.
            this.sF_DistinteBasi_SchedeTableAdapter.Fill(this.ds_SL.SF_DistinteBasi_Schede);

            //Seleziona cliente Sistematica
            siglacli = "SE";
            int foundIndex = tabSiglacliBindingSource.Find("Tab_Valore", siglacli);
            if (foundIndex > -1) { cb_Cliente.SelectedIndex = foundIndex; }

            GVar.gl_tipofiltro_FW_R = "A";
            GVar.gl_tipofiltro_FW_P = "A";
            radio_FW_all.Checked = true;
            radio_FW_standard.Checked = false;
            radio_FW_custom.Checked = false;

            SetView();
        }

        //// BINDINGSOURCE CHANGED
        private void sFArticoliSchedeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //DataRowView drview = (DataRowView)sFArticoliSchedeBindingSource.Current;
            //if (drview == null) { return; }

            //string articolo = drview["Articolo"].ToString();
            //string famiglia = drview["Famiglia"].ToString();
            //string sigla = "";

            ////Calcolo del path
            //string path = Properties.Settings.Default.Doc_folder;
            //string path_it = "";
            //string path_en = "";
            //switch (btn_view)
            //{
            //    case "K":
            //        sigla = articolo.Substring(4, 2);
            //        path = path + @"XKIT\" + sigla + @"\";
            //        path_it = path + articolo + @"\IT\" + articolo + ".pdf";
            //        path_en = path + articolo + @"\EN\" + articolo + ".pdf";
            //        break;
            //    case "P":
            //        sigla = articolo.Substring(7, 2);
            //        path = path + famiglia + @"\" + sigla + @"\";
            //        path_it = path + articolo + @"\IT\" + articolo + ".pdf";
            //        path_en = path + articolo + @"\EN\" + articolo + ".pdf";
            //        break;
            //    case "R":
            //        sigla = articolo.Substring(7, 2);
            //        path = path + famiglia + @"\" + sigla + @"\";
            //        path_it = path + articolo + @"\IT\" + articolo + ".pdf";
            //        path_en = path + articolo + @"\EN\" + articolo + ".pdf";
            //        break;
            //    case "C":
            //        sigla = articolo.Substring(4, 2);
            //        path = path + @"XCBL\" + sigla + @"\";
            //        // Cerca il folder giusto
            //        string cblstart = articolo + "*";
            //        string[] dirs = Directory.GetDirectories(path, cblstart, SearchOption.TopDirectoryOnly);
            //        foreach (string dir in dirs)
            //        {
            //            path = dir + @"\";
            //        }
            //        path_it = path + @"\IT\" + articolo + ".pdf";
            //        path_en = path + @"\EN\" + articolo + ".pdf";
            //        break;
            //    case "FR":
            //        path = path + @"XSWRR\";
            //        path_it = path + articolo + @"\IT\" + articolo + ".pdf";
            //        path_en = path + articolo + @"\EN\" + articolo + ".pdf";
            //        break;
            //    case "FP":
            //        path = path + @"XSWRP\";
            //        path_it = path + articolo + @"\IT\" + articolo + ".pdf";
            //        path_en = path + articolo + @"\EN\" + articolo + ".pdf";
            //        break;
            //}

            //if (System.IO.File.Exists(path_it)) { Schede_pdf_it.LoadFile(path_it); } else { Schede_pdf_it.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
            //if (System.IO.File.Exists(path_en)) { Schede_pdf_en.LoadFile(path_en); } else { Schede_pdf_en.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
            //SetPDFReader();
        }

        //// CONTROLS EVENTS
        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_grid_kit_TextChanged(object sender, EventArgs e)
        {
            FiltraArticoliCliente();
            //string filtro = string.Format("Articolo LIKE '%{0}%'", tb_search.Text);
            //sFArticoliSchedeBindingSource.Filter = filtro;
            tb_search.Focus();
        }

        private void btn_Kit_Click(object sender, EventArgs e)
        {
            btn_view = "K";
            SetView();
        }

        private void btn_Palmari_Click(object sender, EventArgs e)
        {
            btn_view = "P";
            SetView();
        }

        private void btn_Ricevitori_Click(object sender, EventArgs e)
        {
            btn_view = "R";
            SetView();
        }

        private void btn_Cablaggi_Click(object sender, EventArgs e)
        {
            btn_view = "C";
            SetView();
        }

        private void btn_FW_P_Click(object sender, EventArgs e)
        {
            btn_view = "FP";
            GVar.gl_tipofiltro_FW_P = "A";
            radio_FW_all.Checked = true;
            radio_FW_standard.Checked = false;
            radio_FW_custom.Checked = false;

            SetView();
        }

        private void btn_FW_R_Click(object sender, EventArgs e)
        {
            btn_view = "FR";
            GVar.gl_tipofiltro_FW_R = "A";
            radio_FW_all.Checked = true;
            radio_FW_standard.Checked = false;
            radio_FW_custom.Checked = false;

            SetView();
        }

        private void radio_FW_standard_Click(object sender, EventArgs e)
        {
            if (btn_view == "FR") { GVar.gl_tipofiltro_FW_R = "S"; }
            if (btn_view == "FP") { GVar.gl_tipofiltro_FW_P = "S"; }
            SetView();
        }

        private void radio_FW_custom_Click(object sender, EventArgs e)
        {
            if (btn_view == "FR") { GVar.gl_tipofiltro_FW_R = "C"; }
            if (btn_view == "FP") { GVar.gl_tipofiltro_FW_P = "C"; }
            SetView();
        }

        private void radio_FW_all_Click(object sender, EventArgs e)
        {
            if (btn_view == "FR") { GVar.gl_tipofiltro_FW_R = "A"; }
            if (btn_view == "FP") { GVar.gl_tipofiltro_FW_P = "A"; }
            SetView();
        }

        //// OTHER ROUTINES
        private void SetPDFReader()
        {
            //Schede_pdf_it.setView("FitV");
            //Schede_pdf_en.setView("FitV");

            //Schede_pdf_it.setShowScrollbars(false);
            //Schede_pdf_en.setShowScrollbars(false);

            //Schede_pdf_it.setShowToolbar(false);
            //Schede_pdf_en.setShowToolbar(false);

            //Schede_pdf_it.setPageMode("none");
            //Schede_pdf_en.setPageMode("none");
        }

        private string TrovaPath(string tiporicerca, string codice, string lingua)
        {
            string path = Properties.Settings.Default.Doc_folder;

            if ((tiporicerca == "Kit") && (lingua == "IT"))
            {
                path = path + @"XKIT\";
                string path_it = path + codice + @"\IT\" + codice + ".pdf";
                return path_it;
            }
            if ((tiporicerca == "Kit") && (lingua == "EN"))
            {
                path = path + @"XKIT\";
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
            btn_Kit.BackColor = Color.White;
            btn_Palmari.BackColor = Color.White;
            btn_Ricevitori.BackColor = Color.White;
            btn_Cablaggi.BackColor = Color.White;
            btn_FW_P.BackColor = Color.White;
            btn_FW_R.BackColor = Color.White;

            switch (btn_view)
            {
                case "K":
                    this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdottoKit(this.ds_SL.SF_ArticoliSchede);
                    FiltraArticoliCliente();
                    gv_Schede_Articolo.HeaderText = "Kit";
                    panel_filter_FW.Visible = false;
                    panel_filter_cli.Visible = true;
                    //gv_Schede.DataSource = sFArticoliSchedeBindingSource;
                    gv_Schede.Refresh();
                    btn_Kit.BackColor = Color.Red;
                    break;
                case "P":
                    this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdottoPalmari(this.ds_SL.SF_ArticoliSchede);
                    FiltraArticoliCliente();

                    gv_Schede_Articolo.HeaderText = "Palmare";
                    panel_filter_FW.Visible = false;
                    panel_filter_cli.Visible = true;
                    gv_Schede.Refresh();
                    btn_Palmari.BackColor = Color.Red;
                    break;
                case "R":
                    this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdottoRicevitori(this.ds_SL.SF_ArticoliSchede);
                    FiltraArticoliCliente();

                    gv_Schede_Articolo.HeaderText = "Ricevitore";
                    panel_filter_FW.Visible = false;
                    panel_filter_cli.Visible = true;
                    gv_Schede.Refresh();
                    btn_Ricevitori.BackColor = Color.Red;
                    break;
                case "C":
                    this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdottoCablaggi(this.ds_SL.SF_ArticoliSchede);
                    FiltraArticoliCliente();

                    gv_Schede_Articolo.HeaderText = "Cablaggio";
                    panel_filter_cli.Visible = true;
                    panel_filter_FW.Visible = false;
                    gv_Schede.Refresh();
                    btn_Cablaggi.BackColor = Color.Red;
                    break;
                case "FR":
                    if (GVar.gl_tipofiltro_FW_R == "A") { this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdottoFw_R(this.ds_SL.SF_ArticoliSchede); }
                    if (GVar.gl_tipofiltro_FW_R == "S") { this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdotto_Fw_R_Standard(this.ds_SL.SF_ArticoliSchede); }
                    if (GVar.gl_tipofiltro_FW_R == "C") { this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdotto_Fw_R_Custom(this.ds_SL.SF_ArticoliSchede); }
                    FiltraArticoliCliente();
                    gv_Schede_Articolo.HeaderText = "FW Ricevitore";
                    panel_filter_FW.Visible = true;
                    panel_filter_cli.Visible = false;
                    gv_Schede.Refresh();
                    btn_FW_R.BackColor = Color.Red;
                    break;
                case "FP":
                    if (GVar.gl_tipofiltro_FW_P == "A") { this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdottoFw_P(this.ds_SL.SF_ArticoliSchede); }
                    if (GVar.gl_tipofiltro_FW_P == "S") { this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdotto_Fw_P_Standard(this.ds_SL.SF_ArticoliSchede); }
                    if (GVar.gl_tipofiltro_FW_P == "C") { this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdotto_Fw_P_Custom(this.ds_SL.SF_ArticoliSchede); }
                    FiltraArticoliCliente();
                    gv_Schede_Articolo.HeaderText = "FW Palmare";
                    panel_filter_FW.Visible = true;
                    panel_filter_cli.Visible = false;
                    gv_Schede.Refresh();
                    btn_FW_P.BackColor = Color.Red;
                    break;
            }

            tb_search.Text = "";
        }

        private void copiaIlValoreNellaClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.gv_Schede.GetClipboardContent());
        }

        private void tabSiglacliBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            FiltraArticoliCliente();
        }

        private void FiltraArticoliCliente()
        {
            string filtro = "";
            string filtrocli = "";
            string filtro_tb_search = "";

            DataRowView drview = (DataRowView)tabSiglacliBindingSource.Current;
            if (drview == null) { return; }
            siglacli = drview["Tab_Valore"].ToString();

            if ((btn_view == "K") || (btn_view == "P") || (btn_view == "R") || (btn_view == "C"))
            {
                if (siglacli != "__")
                {
                    filtrocli = "SiglaCli_Kit = " + "'" + siglacli + "'";
                }
            }
            else
            {
                filtrocli = "";
            }

            //Aggiungo filtro su tb_search
            if (tb_search.Text != "")
            {
                filtro_tb_search = string.Format("Articolo LIKE '%{0}%'", tb_search.Text);
            }

            //Applico filtro
            if ((filtrocli != "") && (filtro_tb_search != "")) { filtro = filtrocli + " AND " + filtro_tb_search; }
            else
            {
                if (filtrocli != "") { filtro = filtrocli; }
                if (filtro_tb_search != "") { filtro = filtro_tb_search; }
            }

            this.ds_SL.SF_ArticoliSchede.DefaultView.RowFilter = filtro;


            gv_Schede.DataSource = this.ds_SL.SF_ArticoliSchede.DefaultView;
            if (this.ds_SL.SF_ArticoliSchede.DefaultView.Count == 0)
            {
                Schede_pdf.Visible = false;
                //Schede_pdf_en.Visible = false;
            }
            else
            {
                Schede_pdf.Visible = true;
                //Schede_pdf_en.Visible = true;
            }
        }

        private void gv_Schede_SelectionChanged(object sender, EventArgs e)
        {
            //DataRowView drview = (DataRowView)sFArticoliSchedeBindingSource.Current;
            //if (drview == null) { return; }

            if (gv_Schede.CurrentRow == null) { return; }

            lab_des1_articolo.Text = gv_Schede.CurrentRow.Cells["gv_Schede_Des_1"].Value.ToString();
            lab_des2_articolo.Text = gv_Schede.CurrentRow.Cells["gv_Schede_Des_2"].Value.ToString();
            lab_des1_articolo.Refresh();
            lab_des2_articolo.Refresh();

            string articolo = gv_Schede.CurrentRow.Cells["gv_Schede_Articolo"].Value.ToString(); //drview["Articolo"].ToString();
            string famiglia = gv_Schede.CurrentRow.Cells["gv_Schede_Famiglia"].Value.ToString(); //drview["Famiglia"].ToString();
            string sigla = "";
            glob_articolo = articolo; // setto per implosione

            //Calcolo del path
            string path = Properties.Settings.Default.Doc_folder;
            path_it = "";
            path_en = "";
            switch (btn_view)
            {
                case "K":
                    sigla = articolo.Substring(4, 2);
                    path = path + @"XKIT\" + sigla + @"\";
                    path_it = path + articolo + @"\IT\" + articolo + ".pdf";
                    path_en = path + articolo + @"\EN\" + articolo + ".pdf";
                    break;
                case "P":
                    sigla = articolo.Substring(7, 2);
                    path = path + famiglia + @"\" + sigla + @"\";
                    path_it = path + articolo + @"\IT\" + articolo + ".pdf";
                    path_en = path + articolo + @"\EN\" + articolo + ".pdf";
                    break;
                case "R":
                    sigla = articolo.Substring(7, 2);
                    path = path + famiglia + @"\" + sigla + @"\";
                    path_it = path + articolo + @"\IT\" + articolo + ".pdf";
                    path_en = path + articolo + @"\EN\" + articolo + ".pdf";
                    break;
                case "C":
                    sigla = articolo.Substring(4, 2);
                    path = path + @"XCBL\" + sigla + @"\";
                    // Cerca il folder giusto
                    string cblstart = articolo + "*";
                    string[] dirs = Directory.GetDirectories(path, cblstart, SearchOption.TopDirectoryOnly);
                    foreach (string dir in dirs)
                    {
                        path = dir + @"\";
                    }
                    path_it = path + @"\IT\" + articolo + ".pdf";
                    path_en = path + @"\EN\" + articolo + ".pdf";
                    break;
                case "FR":
                    path = path + @"XSWRR\";
                    path_it = path + articolo + @"\IT\" + articolo + ".pdf";
                    path_en = path + articolo + @"\EN\" + articolo + ".pdf";
                    break;
                case "FP":
                    path = path + @"XSWRP\";
                    path_it = path + articolo + @"\IT\" + articolo + ".pdf";
                    path_en = path + articolo + @"\EN\" + articolo + ".pdf";
                    break;
            }

            //if (System.IO.File.Exists(path_it)) { Schede_pdf_it.LoadFile(path_it); } else { Schede_pdf_it.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
            //if (System.IO.File.Exists(path_en)) { Schede_pdf_en.LoadFile(path_en); } else { Schede_pdf_en.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
            if (System.IO.File.Exists(path_it)) { Schede_pdf.LoadDocument(path_it); } else { Schede_pdf.LoadDocument(@"Resources\Pdf_notpresent.pdf"); }
            //if (System.IO.File.Exists(path_en)) { Schede_pdf_en.LoadDocument(path_en); } else { Schede_pdf_en.LoadDocument(@"Resources\Pdf_notpresent.pdf"); }
            SetPDFReader();

        }

        private void but_implosion_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Implosion uC_Implosion = new UC_Implosion();
            SplashDB.Close();
            uC_Implosion.LoadArticolo(glob_articolo);
            uC_Implosion.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void but_pdf_eng_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(path_en)) { Schede_pdf.LoadDocument(path_en); } else { Schede_pdf.LoadDocument(@"Resources\Pdf_notpresent.pdf"); }
        }

        private void but_pdf_ita_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(path_it)) { Schede_pdf.LoadDocument(path_it); } else { Schede_pdf.LoadDocument(@"Resources\Pdf_notpresent.pdf"); }
        }
    }
}
