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

namespace SmartLineProduction
{
    public partial class UC_Quality_new_version : MetroFramework.Forms.MetroForm
    {
        private string displayform = "V"; // V-View/I-Insert/E-Edit/R-Revision
        private string sel_ProjProdArea = "";
        private string sel_Org = "";
        private string sel_Type = "";
        private string sel_Class = "";
        private string sel_User = "";

        public const string NoValue = "___";

        //valori per Creazione Revisione
        string Qual_ProjProdArea = "";
        string Qual_Org = "";
        string Qual_Type = "";
        string Qual_Class = "";
        string Qual_Prog = "";
        string Qual_Ver = "";
        string Qual_Rev = "";
        string Qual_Ver_old = "";
        string Qual_Rev_old = "";
        DataRow sourceRow;
        bool VediObsolete = false;

        int Glob_RowId = 0;
        private int ultimoProg = 0;

        public UC_Quality_new_version()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////
        /// Funzioni private
        ////////////////////////////////////////////////////////////////////////////////////

        private void FiltraQuality()
        {
            if (displayform == "I")
            {
                string filtro = "";
                bool firstfilter = false;

                if (sel_ProjProdArea != NoValue)
                {
                    filtro = filtro + "(Qual_ProjProdArea like " + "'" + sel_ProjProdArea + "')";
                    firstfilter = true;
                }
                if (sel_Org != NoValue)
                {
                    if (firstfilter) { filtro = filtro + " AND "; }
                    filtro = filtro + "(Qual_Org like " + "'" + sel_Org + "')";
                    firstfilter = true;
                }
                if (sel_Type != NoValue)
                {
                    if (firstfilter) { filtro = filtro + " AND "; }
                    filtro = filtro + "(Qual_Type like " + "'" + sel_Type + "')";
                    firstfilter = true;
                }

                qualityBindingSource.Filter = filtro;

                CreaCodice();
            }
        }

        private void CreaCodice()
        {
            string codvers = "";
            string codrev = "";

            ultimoProg = 0;
            if ((sel_ProjProdArea != null) && (sel_ProjProdArea != NoValue)
               && (sel_Org != null) && (sel_Org != NoValue)
               && (sel_Type != null) && (sel_Type != NoValue))
            {
                var checkNull = this.qualityTableAdapter.FindMaxProg(sel_ProjProdArea, sel_Org, sel_Type);
                if (checkNull != null)
                {
                    ultimoProg = Convert.ToInt32(checkNull);
                }
            }

            ultimoProg++;
            if (tb_vers.Text != "") { codvers = tb_vers.Text; } else { codvers = NoValue; }
            if (tb_rev.Text != "") { codrev = tb_rev.Text; } else { codrev = NoValue; }

            //,CONCAT(Quality.Qual_ProjProdArea, '-', Quality.Qual_Org, '-', Quality.Qual_Type, '-', Quality.Qual_Class, '-', FORMAT(Quality.Qual_Prog, '0000'), '-', Quality.Qual_Ver, '.', Quality.Qual_Rev) AS Codice_Quality
            string codice = sel_ProjProdArea + "-" + sel_Org + "-" + sel_Type + "-" + sel_Class + "-" + ultimoProg.ToString("0000") + "-" + codvers + "." + codrev;
            lab_Codice_Edit.Text = codice;
        }

        private void AggiornaArchivi()
        {
            this.qualityTableAdapter.Fill(this.ds_Quality_new.Quality);
            if (this.qualityBindingSource.Count == 0)
            {
                AzzeraForm();
            }
            this.sF_QualityViewNewTableAdapter.Fill(this.ds_Quality_new.SF_QualityViewNew);

            this.dt_Quality_EditRecTableAdapter.Fill(this.ds_Quality_new.dt_Quality_EditRec);

            this.dt_Quality_ClassificationTableAdapter.Fill(this.ds_Quality_new.dt_Quality_Classification);
            this.dt_Quality_TipoDocTableAdapter.Fill(this.ds_Quality_new.dt_Quality_TipoDoc);
            this.dt_Quality_CompanyTableAdapter.Fill(this.ds_Quality_new.dt_Quality_Company);
            this.dt_Quality_ProjProdAreaTableAdapter.Fill(this.ds_Quality_new.dt_Quality_ProjProdArea);

            this.usersTableAdapter.Fill(this.ds_Quality_new.Users);

            if (!VediObsolete)
                sFQualityViewNewBindingSource.Filter = "Qual_Rev_Obsolete = false";
            else
                sFQualityViewNewBindingSource.Filter = "";


            Qual_ProjProdArea = "";
            Qual_Org = "";
            Qual_Type = "";
            Qual_Class = "";
            Qual_Prog = "";
            Qual_Ver = "";
            Qual_Rev = "";
            Qual_Ver_old = "";
            Qual_Rev_old = "";

        }

        private string FindIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void PreparaForm()
        {
            switch (displayform)
            {
                case "V":
                    //this.dt_QualityTableAdapter.FillBy_CodiceQuality(this.ds_Quality_new.dt_Quality);

                    cb_User.Enabled = false;
                    cb_projprodarea.Enabled = false;
                    cb_org.Enabled = false;
                    cb_type.Enabled = false;
                    cb_class.Enabled = false;

                    //dtQualityBindingSource.ResumeBinding();
                    gv_Quality.Enabled = true;
                    tb_Des.Enabled = false;
                    tb_folder.Enabled = false;
                    tb_rev.Enabled = false;
                    tb_vers.Enabled = false;

                    pan_Menu_comandi.Enabled = true;
                    pan_Menu_salva.Enabled = false;
                    pan_Menu_exit.Enabled = true;

                    //dtQualityBindingSource.RemoveFilter();
                    //dtQualityBindingSource.MoveFirst();

                    label_codview.Visible = true;
                    label_codedit.Visible = false;
                    lab_Codice_View.Visible = true;
                    lab_Codice_Edit.Visible = false;

                    but_view_obsolete.Visible = true;
                    but_hide_obsolete.Visible = false;
                    break;
                case "I":
                    //dtQualityBindingSource.SuspendBinding();

                    cb_User.Enabled = true;
                    cb_projprodarea.Enabled = true;
                    cb_org.Enabled = true;
                    cb_type.Enabled = true;
                    cb_class.Enabled = true;

                    tb_Des.Enabled = true;
                    tb_Des.Text = "";
                    tb_folder.Enabled = true;
                    tb_rev.Enabled = true;
                    tb_vers.Enabled = true;

                    gv_Quality.Enabled = false;

                    usersBindingSource.RemoveFilter();
                    dtQualityProjProdAreaBindingSource.RemoveFilter();
                    dtQualityCompanyBindingSource.RemoveFilter();
                    dtQualityTipoDocBindingSource.RemoveFilter();
                    dtQualityClassificationBindingSource.RemoveFilter();

                    usersBindingSource.RemoveFilter();
                    dtQualityProjProdAreaBindingSource.Sort = "Qual_Des asc";
                    dtQualityCompanyBindingSource.Sort = "Qual_Des asc";
                    dtQualityTipoDocBindingSource.Sort = "Qual_Des asc";
                    dtQualityClassificationBindingSource.Sort = "Qual_Des asc";

                    label_codview.Visible = false;
                    label_codedit.Visible = true;
                    lab_Codice_View.Visible = false;
                    lab_Codice_Edit.Visible = true;

                    gv_Quality.Enabled = false;

                    pan_Menu_comandi.Enabled = false;
                    pan_Menu_salva.Enabled = true;
                    pan_Menu_exit.Enabled = false;

                    but_view_obsolete.Visible = false;
                    but_hide_obsolete.Visible = false;

                    ShowPanelDati();
                    break;
                case "R":
                    //dtQualityBindingSource.SuspendBinding();
                    tb_Des.Enabled = true;
                    //tb_Des.Text = "";
                    tb_folder.Enabled = true;
                    tb_rev.Enabled = true;
                    tb_vers.Enabled = true;

                    gv_Quality.Enabled = false;

                    cb_User.Enabled = false;
                    cb_projprodarea.Enabled = false;
                    cb_org.Enabled = false;
                    cb_type.Enabled = false;
                    cb_class.Enabled = false;

                    //usersBindingSource.RemoveFilter();
                    //dtQualityProjProdAreaBindingSource.RemoveFilter();
                    //dtQualityCompanyBindingSource.RemoveFilter();
                    //dtQualityTipoDocBindingSource.RemoveFilter();
                    //dtQualityClassificationBindingSource.RemoveFilter();

                    //usersBindingSource.RemoveFilter();
                    //dtQualityProjProdAreaBindingSource.Sort = "Qual_Des asc";
                    //dtQualityCompanyBindingSource.Sort = "Qual_Des asc";
                    //dtQualityTipoDocBindingSource.Sort = "Qual_Des asc";
                    //dtQualityClassificationBindingSource.Sort = "Qual_Des asc";

                    label_codview.Visible = true;
                    label_codedit.Visible = false;
                    lab_Codice_View.Visible = true;
                    lab_Codice_Edit.Visible = false;

                    gv_Quality.Enabled = false;

                    pan_Menu_comandi.Enabled = false;
                    pan_Menu_salva.Enabled = true;
                    pan_Menu_exit.Enabled = false;

                    but_view_obsolete.Visible = false;
                    but_hide_obsolete.Visible = false;

                    break;

                case "E":
                    //dtQualityBindingSource.SuspendBinding();
                    gv_Quality.Enabled = false;

                    cb_User.Enabled = false;
                    cb_projprodarea.Enabled = false;
                    cb_org.Enabled = false;
                    cb_type.Enabled = false;
                    cb_class.Enabled = false;
                    tb_Des.Enabled = true;
                    tb_folder.Enabled = true;
                    tb_rev.Enabled = false;
                    tb_vers.Enabled = false;

                    label_codview.Visible = true;
                    label_codedit.Visible = false;
                    lab_Codice_View.Visible = true;
                    lab_Codice_Edit.Visible = false;

                    pan_Menu_comandi.Enabled = false;
                    pan_Menu_salva.Enabled = true;
                    pan_Menu_exit.Enabled = false;

                    but_view_obsolete.Visible = false;
                    but_hide_obsolete.Visible = false;

                    break;
            }
        }

        private void CreaCodiceRevisione(string loc_Qual_ProjProdArea, string loc_Qual_Org, string loc_Qual_Type, string loc_Qual_Class, string loc_Qual_Prog, string loc_Qual_Ver, string loc_Qual_Rev)
        {
            loc_Qual_Prog = Qual_Prog.PadLeft(4, '0');

            string codice = loc_Qual_ProjProdArea + "-" + loc_Qual_Org + "-" + loc_Qual_Type + "-" + loc_Qual_Class + "-" + loc_Qual_Prog + "-" + loc_Qual_Ver + "." + loc_Qual_Rev;
            lab_Codice_View.Text = codice;
            lab_Codice_View.Refresh();
        }

        private void Riga2Db()
        {
            if (displayform == "I")
            {
                var newrow = ds_Quality_new.Quality.NewRow();
                newrow["Qual_ProjProdArea"] = lab_projprodarea.Text;
                newrow["Qual_Org"] = lab_org.Text;
                newrow["Qual_Type"] = lab_type.Text;
                newrow["Qual_Class"] = lab_class.Text;
                newrow["Qual_Prog"] = ultimoProg.ToString();
                newrow["Qual_Ver"] = tb_vers.Text;
                newrow["Qual_Rev"] = tb_rev.Text;
                newrow["Qual_Des"] = tb_Des.Text;
                newrow["Qual_Path"] = tb_folder.Text;
                newrow["Qual_Richiedente"] = sel_User;
                newrow["Qual_DateRequest"] = DateTime.Now;
                newrow["Qual_IPRequest"] = FindIP();
                newrow["Qual_Rev_Obsolete"] = false;

                ds_Quality_new.Quality.Rows.Add(newrow);
                qualityTableAdapter.Update(newrow);
            }
            if (displayform == "E")
            {
                //                DataRowView findrowview = this.dtQualityBindingSource.Current as DataRowView;
                //                DataRow findrow = (DataRow)findrowview.Row;
                //                DataRow editrow = ds_Quality.ds_Quality_new.Rows.Find(findrow["Id"]);
                DataRow editrow = ds_Quality_new.Quality.Rows.Find(Glob_RowId);
                editrow.BeginEdit();
                //                editrow["Qual_ProjProdArea"] = lab_projprodarea.Text;
                //                editrow["Qual_Org"] = lab_org.Text;
                //                editrow["Qual_Type"] = lab_type.Text;
                //                editrow["Qual_Class"] = lab_class.Text;
                //                editrow["Qual_Prog"] = ultcodice.ToString();
                editrow["Qual_Ver"] = tb_vers.Text;
                editrow["Qual_Rev"] = tb_rev.Text;
                editrow["Qual_Des"] = tb_Des.Text;
                editrow["Qual_Path"] = tb_folder.Text;
                editrow["Qual_Richiedente"] = sel_User;
                editrow["Qual_DateRequest"] = DateTime.Now;
                editrow["Qual_IPRequest"] = FindIP();
                //editrow.EndEdit();

                try
                {
                    this.Validate();
                    this.qualityBindingSource.EndEdit();
                    this.qualityTableAdapter.Update(editrow);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Update failed");
                }
                //dt_QualityTableAdapter. Update(editrow);
            }
            if (displayform == "R")
            {
                //                DataRowView findrowview = this.dtQualityBindingSource.Current as DataRowView;
                //                DataRow findrow = (DataRow)findrowview.Row;

                ////Localizzo il vecchio record
                //                DataRow editrow = ds_Quality_new.dt_Quality_EditRec.Rows.Find(findrow["Id"]);
                //                DataRow backuprow = ds_Quality_new.dt_Quality_EditRec.Rows.Find(findrow["Id"]);
                DataRow editrow = ds_Quality_new.dt_Quality_EditRec.Rows.Find(Glob_RowId);
                DataRow backuprow = ds_Quality_new.dt_Quality_EditRec.Rows.Find(Glob_RowId);

                editrow.BeginEdit();
                editrow.SetModified();

                //              editrow["Qual_ProjProdArea"] = backuprow["Qual_ProjProdArea"];
                //              editrow["Qual_Org"] = backuprow["Qual_Org"];
                //              editrow["Qual_Type"] = backuprow["Qual_Type"];
                //              editrow["Qual_Class"] = backuprow["Qual_Class"];
                //              editrow["Qual_Prog"] = backuprow["Qual_Prog"];
                editrow["Qual_Ver"] = backuprow["Qual_Ver"];
                editrow["Qual_Rev"] = backuprow["Qual_Rev"];
                editrow["Qual_Des"] = backuprow["Qual_Des"];
                editrow["Qual_Path"] = backuprow["Qual_Path"];
                editrow["Qual_Richiedente"] = backuprow["Qual_Richiedente"];
                editrow["Qual_DateRequest"] = backuprow["Qual_DateRequest"];
                editrow["Qual_IPRequest"] = backuprow["Qual_IPRequest"];

                editrow["Qual_Rev_Obsolete"] = true;


                try
                {
                    //editrow.AcceptChanges();

                    this.Validate();
                    this.dtQualityEditRecBindingSource.EndEdit();
                    this.dt_Quality_EditRecTableAdapter.Update(editrow);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Update failed");
                }

                //Inserisco nuovo record
                var newrow = ds_Quality_new.Quality.NewRow();
                newrow.ItemArray = backuprow.ItemArray;

                //newrow["Id"] = DBNull.Value;
                int MaxValue = Convert.ToInt32(ds_Quality_new.Quality.AsEnumerable().Max(row => row["Id"]));
                MaxValue++;
                newrow["Id"] = MaxValue;
                newrow["Qual_Des"] = tb_Des.Text;
                newrow["Qual_Path"] = tb_folder.Text;
                newrow["Qual_Ver"] = tb_vers.Text;
                newrow["Qual_Rev"] = tb_rev.Text;
                newrow["Qual_Rev_Obsolete"] = false;

                ds_Quality_new.Quality.Rows.Add(newrow);
                qualityTableAdapter.Update(newrow);
            }
        }

        private void AzzeraForm()
        {
            lab_Codice_Edit.Text = string.Empty;
            lab_Codice_View.Text = string.Empty;
            tb_Des.Text = string.Empty;
            tb_folder.Text = string.Empty;
            tb_vers.Text = string.Empty;
            tb_rev.Text = string.Empty;
            lab_MyIp.Text = string.Empty;
            dtQualityProjProdAreaBindingSource.MoveFirst();
            dtQualityCompanyBindingSource.MoveFirst();
            dtQualityTipoDocBindingSource.MoveFirst();
            dtQualityClassificationBindingSource.MoveFirst();
            if (!VediObsolete)
                qualityBindingSource.Filter = "Qual_Rev_Obsolete = false";
            else
                qualityBindingSource.Filter = string.Empty;
        }

        private void HidePanelDati()
        {
            label_codview.Visible = false;
            lab_Codice_View.Visible = false;
            label_codedit.Visible = false;
            lab_Codice_Edit.Visible = false;
            lab_des.Visible = false;
            tb_Des.Visible = false;
            lab_folder.Visible = false;
            tb_folder.Visible = false;
            lab_vers.Visible = false;
            tb_vers.Visible = false;
            lab_rev.Visible = false;
            tb_rev.Visible = false;

            panel_Sigle.Visible = false;
        }

        private void ShowPanelDati()
        {
            label_codview.Visible = true;
            lab_Codice_View.Visible = true;
            label_codedit.Visible = true;
            lab_Codice_Edit.Visible = true;
            lab_des.Visible = true;
            tb_Des.Visible = true;
            lab_folder.Visible = true;
            tb_folder.Visible = true;
            lab_vers.Visible = true;
            tb_vers.Visible = true;
            lab_rev.Visible = true;
            tb_rev.Visible = true;

            panel_Sigle.Visible = true;

            switch (displayform)
            {
                case "V":
                    label_codview.Visible = true;
                    label_codedit.Visible = false;
                    lab_Codice_View.Visible = true;
                    lab_Codice_Edit.Visible = false;
                    break;
                case "I":
                    label_codview.Visible = false;
                    label_codedit.Visible = true;
                    lab_Codice_View.Visible = false;
                    lab_Codice_Edit.Visible = true;
                    break;
                case "R":
                    label_codview.Visible = true;
                    label_codedit.Visible = false;
                    lab_Codice_View.Visible = true;
                    lab_Codice_Edit.Visible = false;
                    break;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////
        /// Funzioni automatiche
        ////////////////////////////////////////////////////////////////////////////////////

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_Quality_new_version_Load(object sender, EventArgs e)
        {
            AggiornaArchivi();

            lab_MyIp.Text = FindIP();
            PreparaForm();
        }

        private void menu_new_Click(object sender, EventArgs e)
        {
            displayform = "I";
            Application.UseWaitCursor = true;
            PreparaForm();
            Application.UseWaitCursor = false;
        }

        private void menu_sw_annulla_Click(object sender, EventArgs e)
        {
            displayform = "V";
            AzzeraForm();
            PreparaForm();
        }

        private void tb_vers_Leave(object sender, EventArgs e)
        {
            //Controlla versione
            int oldvers = 0;
            int newvers = 0;
            if (Qual_Ver != "") oldvers = Convert.ToInt32(Qual_Ver);
            if (tb_vers.Text != "") newvers = Convert.ToInt32(tb_vers.Text);

            if (newvers < oldvers)
            {
                MessageBox.Show("La versione digitata non può essere minore della precedente!");
                tb_vers.Text = oldvers.ToString();
                tb_vers.Focus();
                return;
            }
            Qual_Ver = tb_vers.Text;
            if (displayform != "R")
                CreaCodice();
            else
                CreaCodiceRevisione(Qual_ProjProdArea, Qual_Org, Qual_Type, Qual_Class, Qual_Prog, Qual_Ver, Qual_Rev);
        }

        private void tb_rev_Leave(object sender, EventArgs e)
        {

            ////Controlla versione
            Qual_Rev = tb_rev.Text;
            if (displayform != "R")
                CreaCodice();
            else
                CreaCodiceRevisione(Qual_ProjProdArea, Qual_Org, Qual_Type, Qual_Class, Qual_Prog, Qual_Ver, Qual_Rev);
        }

        private void tb_folder_ButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.SelectedPath = @"\\dc";
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_folder.Text = folderDlg.SelectedPath;
            }
        }

        private void menu_sw_salva_Click(object sender, EventArgs e)
        {
            //Verifica che tutti i campi siano stati compilati correttamente
            if (cb_User.Text == NoValue)
            {
                MessageBox.Show("Si prega di compilare correttamente il campo Utente. \nNon può essere vuoto!");
                cb_projprodarea.Focus();
                return;
            }
            if (lab_projprodarea.Text == NoValue)
            {
                MessageBox.Show("Si prega di compilare correttamente il campo Project / Product / Area. \nNon può essere vuoto!");
                cb_projprodarea.Focus();
                return;
            }
            if (lab_org.Text == NoValue)
            {
                MessageBox.Show("Si prega di compilare correttamente il campo Organization. \nNon può essere vuoto!");
                cb_org.Focus();
                return;
            }
            if (lab_type.Text == NoValue)
            {
                MessageBox.Show("Si prega di compilare correttamente il campo Type Document. \nNon può essere vuoto!");
                cb_type.Focus();
                return;
            }
            if (lab_class.Text == NoValue)
            {
                MessageBox.Show("Si prega di compilare correttamente il campo Classification. \nNon può essere vuoto!");
                cb_class.Focus();
                return;
            }
            if (tb_Des.Text == "")
            {
                MessageBox.Show("Si prega di compilare correttamente il campo Descrizione. \nNon può essere vuoto!");
                tb_Des.Focus();
                return;
            }
            if (tb_vers.Text == "")
            {
                MessageBox.Show("Si prega di compilare correttamente il campo Versione. \nNon può essere vuoto!");
                tb_vers.Focus();
                return;
            }
            if (tb_rev.Text == "")
            {
                MessageBox.Show("Si prega di compilare correttamente il campo Revisione. \nNon può essere vuoto!");
                tb_rev.Focus();
                return;
            }

            //Verifica che non esista già il codice
            if (displayform == "I")
            {
                DataView view = new DataView(ds_Quality_new.Quality);
                view.RowFilter = "Codice_Quality = " + "'" + lab_Codice_Edit.Text + "'";
                int contarec = view.Count;
                if (contarec > 0)
                {
                    MessageBox.Show("Attenzione! Il codice richiesto esiste già! \nRivedere le selezioni!");
                    tb_rev.Focus();
                    return;
                }
            }

            Riga2Db();

            AggiornaArchivi();

            displayform = "V";
            PreparaForm();
        }

        private void menu_edit_Click(object sender, EventArgs e)
        {
            displayform = "E";
            Application.UseWaitCursor = true;
            PreparaForm();
            Application.UseWaitCursor = false;
        }

        private void copiaIlValoreNellaClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lab_Codice_View.Text);
        }

        private void creaRevisioneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            displayform = "R";
            PreparaForm();

            cb_User.Enabled = false;
            cb_projprodarea.Enabled = false;
            cb_org.Enabled = false;
            cb_type.Enabled = false;
            cb_class.Enabled = false;

            //Modifico valori iniziali
            sourceRow = ((DataRowView)qualityBindingSource.Current).Row;

            //Riempio campi
            tb_Des.Text = sourceRow["Qual_Des"].ToString();
            tb_folder.Text = sourceRow["Qual_Path"].ToString();
            tb_vers.Text = sourceRow["Qual_Ver"].ToString();

            int rev = Convert.ToInt32(sourceRow["Qual_Rev"].ToString());
            rev++;
            tb_rev.Text = rev.ToString();
            tb_rev.Refresh();

            Qual_ProjProdArea = sourceRow["Qual_ProjProdArea"].ToString();
            Qual_Org = sourceRow["Qual_Org"].ToString();
            Qual_Type = sourceRow["Qual_Type"].ToString();
            Qual_Class = sourceRow["Qual_Class"].ToString();
            Qual_Prog = sourceRow["Qual_Prog"].ToString();
            Qual_Ver = sourceRow["Qual_Ver"].ToString();
            Qual_Rev = rev.ToString();

            //Memorizzo per recuperare in fase di salvataggio
            Qual_Ver_old = sourceRow["Qual_Ver"].ToString();
            Qual_Rev_old = sourceRow["Qual_Rev"].ToString();

            CreaCodiceRevisione(Qual_ProjProdArea, Qual_Org, Qual_Type, Qual_Class, Qual_Prog, Qual_Ver, Qual_Rev);
        }

        private void dtQualityProjProdAreaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)dtQualityProjProdAreaBindingSource.Current;
            if (drview != null && displayform == "I") { sel_ProjProdArea = drview["Qual_Codice"].ToString(); FiltraQuality(); } else { sel_ProjProdArea = null; }
        }

        private void dtQualityCompanyBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)dtQualityCompanyBindingSource.Current;
            if (drview != null && displayform == "I") { sel_Org = drview["Qual_Codice"].ToString(); FiltraQuality(); } else { sel_Org = null; }
        }

        private void dtQualityTipoDocBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)dtQualityTipoDocBindingSource.Current;
            if (drview != null && displayform == "I") { sel_Type = drview["Qual_Codice"].ToString(); FiltraQuality(); } else { sel_Type = null; }
        }

        private void dtQualityClassificationBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)dtQualityClassificationBindingSource.Current;
            if (drview != null && displayform == "I") { sel_Class = drview["Qual_Codice"].ToString(); FiltraQuality(); } else { sel_Class = null; }
        }

        private void usersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)usersBindingSource.Current;
            if (drview != null && displayform == "I") { sel_User = drview["UTENTE"].ToString(); }
        }

        private void qualityBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (displayform == "V")
            {
                //DataRowView drview = (DataRowView)QualityBindingSource.Current;
                //if (drview != null)
                //{
                //    string filtro = "UTENTE = " + "'" + drview["Qual_Richiedente"].ToString() + "'";
                //    usersBindingSource.Filter = filtro;

                //    filtro = "Qual_Codice = " + "'" + drview["Qual_ProjProdArea"].ToString() + "'";
                //    dtQualityProjProdAreaBindingSource.Filter = filtro;

                //    filtro = "Qual_Codice = " + "'" + drview["Qual_Org"].ToString() + "'";
                //    dtQualityCompanyBindingSource.Filter = filtro;

                //    filtro = "Qual_Codice = " + "'" + drview["Qual_Type"].ToString() + "'";
                //    dtQualityTipoDocBindingSource.Filter = filtro;

                //    filtro = "Qual_Codice = " + "'" + drview["Qual_Class"].ToString() + "'";
                //    dtQualityClassificationBindingSource.Filter = filtro;
                //}
            }

        }

        private void but_view_obsolete_Click(object sender, EventArgs e)
        {
            MainGridView.Columns["Qual_Rev_Obsolete"].Visible = true;
            VediObsolete = true;
            AggiornaArchivi();
            but_view_obsolete.Visible = false;
            but_hide_obsolete.Visible = true;
        }

        private void but_hide_obsolete_Click(object sender, EventArgs e)
        {
            MainGridView.Columns["Qual_Rev_Obsolete"].Visible = false;
            VediObsolete = false;
            AggiornaArchivi();
            but_view_obsolete.Visible = true;
            but_hide_obsolete.Visible = false;
        }

        private void cb_projprodarea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int rowHandle = MainGridView.FocusedRowHandle;

            if (rowHandle < 0)
            {
                HidePanelDati();
            }
            else
            {
                ShowPanelDati();
            }
        }

        private void sFQualityViewNewBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (displayform == "V")
            {
                DataRowView drview = (DataRowView)sFQualityViewNewBindingSource.Current;
                if (drview != null)
                {
                    string filtro = "UTENTE = " + "'" + drview["Qual_Richiedente"].ToString() + "'";
                    usersBindingSource.Filter = filtro;

                    filtro = "Qual_Codice = " + "'" + drview["Qual_ProjProdArea"].ToString() + "'";
                    dtQualityProjProdAreaBindingSource.Filter = filtro;

                    filtro = "Qual_Codice = " + "'" + drview["Qual_Org"].ToString() + "'";
                    dtQualityCompanyBindingSource.Filter = filtro;

                    filtro = "Qual_Codice = " + "'" + drview["Qual_Type"].ToString() + "'";
                    dtQualityTipoDocBindingSource.Filter = filtro;

                    filtro = "Qual_Codice = " + "'" + drview["Qual_Class"].ToString() + "'";
                    dtQualityClassificationBindingSource.Filter = filtro;
                }

                int rowHandle = MainGridView.FocusedRowHandle;
                MainGridView.ExpandGroupRow(0, true);
            }

        }

        private void MainGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int rowHandle = MainGridView.FocusedRowHandle;

            if (MainGridView.GetRowExpanded(rowHandle))
            {
                MainGridView.CollapseGroupRow(rowHandle, true);

            }
            else
            {
                MainGridView.ExpandGroupRow(rowHandle, true);
            }
        }
    }
}
