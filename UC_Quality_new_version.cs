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

        /// Valori del current bindingsource
        private string currentbs_User = string.Empty;
        private string currentbs_ProjProdArea = string.Empty;
        private string currentbs_Org = string.Empty;
        private string currentbs_Type = string.Empty;
        private string currentbs_Class = string.Empty;
        private string currentbs_Des = string.Empty;
        private string currentbs_Path = string.Empty;
        private string currentbs_Ver = string.Empty;
        private string currentbs_Rev = string.Empty;
        private int currentbs_Prog = 0;

        private string input_User = string.Empty;
        private string input_ProjProdArea = string.Empty;
        private string input_Org = string.Empty;
        private string input_Type = string.Empty;
        private string input_Class = string.Empty;
        private string input_Des = string.Empty;
        private string input_Path = string.Empty;
        private string input_Ver = string.Empty;
        private string input_Rev = string.Empty;
        private int input_Prog = 0;

        public const string NoValue = "___";

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

                if (input_ProjProdArea != NoValue)
                {
                    filtro = filtro + "(Qual_ProjProdArea like " + "'" + input_ProjProdArea + "')";
                    firstfilter = true;
                }
                if (input_Org != NoValue)
                {
                    if (firstfilter) { filtro = filtro + " AND "; }
                    filtro = filtro + "(Qual_Org like " + "'" + input_Org + "')";
                    firstfilter = true;
                }
                if (input_Type != NoValue)
                {
                    if (firstfilter) { filtro = filtro + " AND "; }
                    filtro = filtro + "(Qual_Type like " + "'" + input_Type + "')";
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
            if ((input_ProjProdArea != null) && (input_ProjProdArea != NoValue)
               && (input_Org != null) && (input_Org != NoValue)
               && (input_Type != null) && (input_Type != NoValue))
            {
                var checkNull = this.qualityTableAdapter.FindMaxProg(input_ProjProdArea, input_Org, input_Type);
                if (checkNull != null)
                {
                    ultimoProg = Convert.ToInt32(checkNull);
                }
            }

            ultimoProg++;
            input_Prog = ultimoProg;
            input_Rev = tb_rev.Text;
            input_Ver = tb_vers.Text;

            if (tb_vers.Text != "") { codvers = tb_vers.Text; } else { codvers = NoValue; }
            if (tb_rev.Text != "") { codrev = tb_rev.Text; } else { codrev = NoValue; }

            string codice = input_ProjProdArea + "-" + input_Org + "-" + input_Type + "-" + input_Class + "-" + input_Prog.ToString("0000") + "-" + input_Ver + "." + input_Rev;
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

            this.dt_Quality_ClassificationTableAdapter.Fill(this.ds_Quality_new.dt_Quality_Classification);
            this.dt_Quality_TipoDocTableAdapter.Fill(this.ds_Quality_new.dt_Quality_TipoDoc);
            this.dt_Quality_CompanyTableAdapter.Fill(this.ds_Quality_new.dt_Quality_Company);
            this.dt_Quality_ProjProdAreaTableAdapter.Fill(this.ds_Quality_new.dt_Quality_ProjProdArea);

            this.usersTableAdapter.Fill(this.ds_Quality_new.Users);

            if (!VediObsolete)
                sFQualityViewNewBindingSource.Filter = "Qual_Rev_Obsolete = false";
            else
                sFQualityViewNewBindingSource.Filter = "";


            currentbs_User = string.Empty;
            currentbs_ProjProdArea = string.Empty;
            currentbs_Org = string.Empty;
            currentbs_Type = string.Empty;
            currentbs_Class = string.Empty;
            currentbs_Des = string.Empty;
            currentbs_Path = string.Empty;
            currentbs_Ver = string.Empty;
            currentbs_Rev = string.Empty;

            input_User = string.Empty;
            input_ProjProdArea = string.Empty;
            input_Org = string.Empty;
            input_Type = string.Empty;
            input_Class = string.Empty;
            input_Des = string.Empty;
            input_Path = string.Empty;
            input_Ver = string.Empty;
            input_Rev = string.Empty;
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

        private void CreaCodiceRevisione(string loc_ProjProdArea, string loc_Org, string loc_Type, string loc_Class, int loc_Prog, string loc_Ver, string loc_Rev)
        {
            string CodiceProg = Convert.ToString(loc_Prog);
            string loc_Qual_Prog = CodiceProg.PadLeft(4, '0');

            string codice = loc_ProjProdArea + "-" + loc_Org + "-" + loc_Type + "-" + loc_Class + "-" + loc_Qual_Prog + "-" + loc_Ver + "." + loc_Rev;
            lab_Codice_View.Text = codice;
            lab_Codice_View.Refresh();
        }

        private void Riga2Db()
        {
            if (displayform == "I")
            {
                var newrow = ds_Quality_new.Quality.NewRow();
                newrow["Qual_ProjProdArea"] = input_ProjProdArea;
                newrow["Qual_Org"] = input_Org;
                newrow["Qual_Type"] = input_Type;
                newrow["Qual_Class"] = input_Class;
                newrow["Qual_Prog"] = input_Prog.ToString();
                newrow["Qual_Ver"] = input_Ver;
                newrow["Qual_Rev"] = input_Rev;
                newrow["Qual_Des"] = input_Des;
                newrow["Qual_Path"] = input_Path;
                newrow["Qual_Richiedente"] = input_User;
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
                editrow["Qual_Ver"] = input_Ver;
                editrow["Qual_Rev"] = input_Rev;
                editrow["Qual_Des"] = input_Des;
                editrow["Qual_Path"] = input_Path;
                editrow["Qual_Richiedente"] = input_User;
                editrow["Qual_DateRequest"] = DateTime.Now;
                editrow["Qual_IPRequest"] = FindIP();
                editrow.EndEdit();

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
                /////////////////////////////////////////////////////////////////
                /// Update old records                                        ///
                /////////////////////////////////////////////////////////////////

                var SetObs = this.qualityTableAdapter.SetObsolete(currentbs_ProjProdArea, currentbs_Org, currentbs_Type, currentbs_Prog);
                if (SetObs != null)
                { }

                //Inserisco nuovo record
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
                newrow["Qual_Richiedente"] = cb_User.Text;
                newrow["Qual_DateRequest"] = DateTime.Now;
                newrow["Qual_IPRequest"] = FindIP();
                newrow["Qual_Rev_Obsolete"] = false;

                //newrow["Id"] = DBNull.Value;
                int MaxValue = Convert.ToInt32(ds_Quality_new.Quality.AsEnumerable().Max(row => row["Id"]));
                MaxValue++;
                newrow["Id"] = MaxValue;

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

            tb_vers.Text = "1";
            tb_rev.Text = "0";
        }

        private void menu_sw_annulla_Click(object sender, EventArgs e)
        {
            displayform = "V";
            AggiornaArchivi();
            AzzeraForm();
            PreparaForm();
        }

        private void tb_vers_Leave(object sender, EventArgs e)
        {
            if (displayform == "V") return;
            //Controlla versione
            int oldvers = 0;
            int newvers = 0;
            if (input_Ver != "") oldvers = Convert.ToInt32(input_Ver);
            if (tb_vers.Text != "") newvers = Convert.ToInt32(tb_vers.Text);

            if (newvers < oldvers)
            {
                MessageBox.Show("La versione digitata non può essere minore della precedente!");
                tb_vers.Text = oldvers.ToString();
                tb_vers.Focus();
                return;
            }
            input_Ver = tb_vers.Text;
            if (displayform != "R")
                CreaCodice();
            else
                CreaCodiceRevisione(input_ProjProdArea, input_Org, input_Type, input_Class, input_Prog, input_Ver, input_Rev);
        }

        private void tb_rev_Leave(object sender, EventArgs e)
        {
            if (displayform == "V") return;

            ////Controlla versione
            input_Rev = tb_rev.Text;
            if (displayform != "R")
                CreaCodice();
            else
                CreaCodiceRevisione(input_ProjProdArea, input_Org, input_Type, input_Class, input_Prog, input_Ver, input_Rev);
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
                var CheckUnique = this.qualityTableAdapter.FindDuplicate(input_ProjProdArea, input_Org, input_Type, input_Ver, input_Rev, input_Prog);
                if ((CheckUnique != null) && ((int)CheckUnique > 0))
                {
                    MessageBox.Show("Questo codice esiste già. \nRivedere i dati inseriti!");
                    tb_vers.Focus();
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

            //Passaggio da valori di BindingSource a valori di input
            input_User = currentbs_User;
            input_ProjProdArea = currentbs_ProjProdArea;
            input_Org = currentbs_Org;
            input_Type = currentbs_Type;
            input_Class = currentbs_Class;
            input_Des = currentbs_Des;
            input_Path = currentbs_Path;
            input_Ver = currentbs_Ver;
            input_Rev = currentbs_Rev;
            input_Prog = currentbs_Prog;

            PreparaForm();
        }

        private void copiaIlValoreNellaClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lab_Codice_View.Text);
        }

        private void creaRevisioneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            displayform = "R";

            //Passaggio da valori di BindingSource a valori di input
            input_User = currentbs_User;
            input_ProjProdArea = currentbs_ProjProdArea;
            input_Org = currentbs_Org;
            input_Type = currentbs_Type;
            input_Class = currentbs_Class;
            input_Des = currentbs_Des;
            input_Path = currentbs_Path;
            input_Ver = currentbs_Ver;
            input_Rev = currentbs_Rev;
            input_Prog = currentbs_Prog;

            PreparaForm();

            //Riempio campi
            int rev = Convert.ToInt32(tb_rev.Text);
            rev++;
            tb_rev.Text = rev.ToString();
            tb_rev.Refresh();

            input_Rev = tb_rev.Text;
            input_Ver = tb_vers.Text;
            
            CreaCodiceRevisione(input_ProjProdArea, input_Org, input_Type, input_Class, input_Prog, input_Ver, input_Rev);

        }

        private void dtQualityProjProdAreaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)dtQualityProjProdAreaBindingSource.Current;
            if (drview != null && displayform == "I") { input_ProjProdArea = drview["Qual_Codice"].ToString(); FiltraQuality(); } else { input_ProjProdArea = null; }
        }

        private void dtQualityCompanyBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)dtQualityCompanyBindingSource.Current;
            if (drview != null && displayform == "I") { input_Org = drview["Qual_Codice"].ToString(); FiltraQuality(); } else { input_Org = null; }
        }

        private void dtQualityTipoDocBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)dtQualityTipoDocBindingSource.Current;
            if (drview != null && displayform == "I") { input_Type = drview["Qual_Codice"].ToString(); FiltraQuality(); } else { input_Type = null; }
        }

        private void dtQualityClassificationBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)dtQualityClassificationBindingSource.Current;
            if (drview != null && displayform == "I") { input_Class = drview["Qual_Codice"].ToString(); FiltraQuality(); } else { input_Class = null; }
        }

        private void usersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)usersBindingSource.Current;
            if (drview != null && displayform == "I") { input_User = drview["UTENTE"].ToString(); }
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
            DataRowView drview = (DataRowView)sFQualityViewNewBindingSource.Current;
            if (drview != null)
            {
                ultimoProg = (int)drview["Qual_Prog"];
                Glob_RowId = (int)drview["Id"];

                currentbs_User = drview["Qual_Richiedente"].ToString();
                currentbs_ProjProdArea = drview["Qual_ProjProdArea"].ToString();
                currentbs_Org = drview["Qual_Org"].ToString();
                currentbs_Type = drview["Qual_Type"].ToString();
                currentbs_Class = drview["Qual_Class"].ToString();
                currentbs_Des = drview["Qual_Des"].ToString();
                currentbs_Path = drview["Qual_Path"].ToString();
                currentbs_Ver = drview["Qual_Ver"].ToString();
                currentbs_Rev = drview["Qual_Rev"].ToString();
                currentbs_Prog = (int)drview["Qual_Prog"];

                if (displayform == "V")
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
            }
        }

        private void tb_Des_Leave(object sender, EventArgs e)
        {
            input_Des = tb_Des.Text;
        }

        private void tb_folder_TextChanged(object sender, EventArgs e)
        {
            input_Path = tb_folder.Text;
        }
    }
}
