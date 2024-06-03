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
        private int ultcodice = 0;

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

                if (sel_ProjProdArea != "___")
                {
                    filtro = filtro + "(Qual_ProjProdArea like " + "'" + sel_ProjProdArea + "')";
                    firstfilter = true;
                }
                if (sel_Org != "___")
                {
                    if (firstfilter) { filtro = filtro + " AND "; }
                    filtro = filtro + "(Qual_Org like " + "'" + sel_Org + "')";
                    firstfilter = true;
                }
                if (sel_Type != "___")
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
            //Trova ultimo codice
            ultcodice = 0;

            DataView view = new DataView(ds_Quality_new.Quality);
            view.RowFilter = qualityBindingSource.Filter;
            int contarec = view.Count;
            if (contarec > 0)
            {
                DataTable result = view.ToTable();
                ultcodice = Convert.ToInt32(result.Compute("max(Qual_Prog)", ""));
            }

            ultcodice++;

            string codvers = "";
            string codrev = "";
            if (tb_vers.Text != "") { codvers = tb_vers.Text; } else { codvers = "__"; }
            if (tb_rev.Text != "") { codrev = tb_rev.Text; } else { codrev = "__"; }

            //,CONCAT(Quality.Qual_ProjProdArea, '-', Quality.Qual_Org, '-', Quality.Qual_Type, '-', Quality.Qual_Class, '-', FORMAT(Quality.Qual_Prog, '0000'), '-', Quality.Qual_Ver, '.', Quality.Qual_Rev) AS Codice_Quality
            string codice = sel_ProjProdArea + "-" + sel_Org + "-" + sel_Type + "-" + sel_Class + "-" + ultcodice.ToString("0000") + "-" + codvers + "." + codrev;
            lab_Codice_Edit.Text = codice;
        }

        private void AggiornaArchivi()
        {
            this.dt_Quality_ClassificationTableAdapter.Fill(this.ds_Quality_new.dt_Quality_Classification);
            this.dt_Quality_TipoDocTableAdapter.Fill(this.ds_Quality_new.dt_Quality_TipoDoc);
            this.dt_Quality_CompanyTableAdapter.Fill(this.ds_Quality_new.dt_Quality_Company);
            this.dt_Quality_ProjProdAreaTableAdapter.Fill(this.ds_Quality_new.dt_Quality_ProjProdArea);
            this.usersTableAdapter.Fill(this.ds_Quality_new.Users);
            this.qualityTableAdapter.Fill(this.ds_Quality_new.Quality);

            if (!VediObsolete)
                qualityBindingSource.Filter = "Qual_Rev_Obsolete = false";
            else
                qualityBindingSource.Filter = "";


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
                    //this.dt_QualityTableAdapter.FillBy_CodiceQuality(this.ds_Quality.dt_Quality);

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

                    cntxt_Obsolete.Visible = true;

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

                    cntxt_Obsolete.Visible = false;

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

                    cntxt_Obsolete.Visible = false;

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

                    break;
            }
        }

        //private void Riga2Db()
        //{
        //    if (displayform == "I")
        //    {
        //        var newrow = ds_Quality.dt_Quality.NewRow();
        //        newrow["Qual_ProjProdArea"] = lab_projprodarea.Text;
        //        newrow["Qual_Org"] = lab_org.Text;
        //        newrow["Qual_Type"] = lab_type.Text;
        //        newrow["Qual_Class"] = lab_class.Text;
        //        newrow["Qual_Prog"] = ultcodice.ToString();
        //        newrow["Qual_Ver"] = tb_vers.Text;
        //        newrow["Qual_Rev"] = tb_rev.Text;
        //        newrow["Qual_Des"] = tb_Des.Text;
        //        newrow["Qual_Path"] = tb_folder.Text;
        //        newrow["Qual_Richiedente"] = sel_User;
        //        newrow["Qual_DateRequest"] = DateTime.Now;
        //        newrow["Qual_IPRequest"] = FindIP();
        //        newrow["Qual_Rev_Obsolete"] = false;

        //        ds_Quality.dt_Quality.Rows.Add(newrow);
        //        dt_QualityTableAdapter.Update(newrow);
        //    }
        //    if (displayform == "E")
        //    {
        //        //                DataRowView findrowview = this.dtQualityBindingSource.Current as DataRowView;
        //        //                DataRow findrow = (DataRow)findrowview.Row;
        //        //                DataRow editrow = ds_Quality.dt_Quality.Rows.Find(findrow["Id"]);
        //        DataRow editrow = ds_Quality.dt_Quality.Rows.Find(Glob_RowId);
        //        editrow.BeginEdit();
        //        //                editrow["Qual_ProjProdArea"] = lab_projprodarea.Text;
        //        //                editrow["Qual_Org"] = lab_org.Text;
        //        //                editrow["Qual_Type"] = lab_type.Text;
        //        //                editrow["Qual_Class"] = lab_class.Text;
        //        //                editrow["Qual_Prog"] = ultcodice.ToString();
        //        editrow["Qual_Ver"] = tb_vers.Text;
        //        editrow["Qual_Rev"] = tb_rev.Text;
        //        editrow["Qual_Des"] = tb_Des.Text;
        //        editrow["Qual_Path"] = tb_folder.Text;
        //        editrow["Qual_Richiedente"] = sel_User;
        //        editrow["Qual_DateRequest"] = DateTime.Now;
        //        editrow["Qual_IPRequest"] = FindIP();
        //        //editrow.EndEdit();

        //        try
        //        {
        //            this.Validate();
        //            this.dtQualityBindingSource.EndEdit();
        //            this.dt_QualityTableAdapter.Update(editrow);
        //        }
        //        catch (System.Exception ex)
        //        {
        //            MessageBox.Show("Update failed");
        //        }
        //        //dt_QualityTableAdapter. Update(editrow);
        //    }
        //    if (displayform == "R")
        //    {
        //        //                DataRowView findrowview = this.dtQualityBindingSource.Current as DataRowView;
        //        //                DataRow findrow = (DataRow)findrowview.Row;

        //        ////Localizzo il vecchio record
        //        //                DataRow editrow = ds_Quality.dt_Quality_EditRec.Rows.Find(findrow["Id"]);
        //        //                DataRow backuprow = ds_Quality.dt_Quality_EditRec.Rows.Find(findrow["Id"]);
        //        DataRow editrow = ds_Quality.dt_Quality_EditRec.Rows.Find(Glob_RowId);
        //        DataRow backuprow = ds_Quality.dt_Quality_EditRec.Rows.Find(Glob_RowId);

        //        editrow.BeginEdit();
        //        editrow.SetModified();

        //        //              editrow["Qual_ProjProdArea"] = backuprow["Qual_ProjProdArea"];
        //        //              editrow["Qual_Org"] = backuprow["Qual_Org"];
        //        //              editrow["Qual_Type"] = backuprow["Qual_Type"];
        //        //              editrow["Qual_Class"] = backuprow["Qual_Class"];
        //        //              editrow["Qual_Prog"] = backuprow["Qual_Prog"];
        //        editrow["Qual_Ver"] = backuprow["Qual_Ver"];
        //        editrow["Qual_Rev"] = backuprow["Qual_Rev"];
        //        editrow["Qual_Des"] = backuprow["Qual_Des"];
        //        editrow["Qual_Path"] = backuprow["Qual_Path"];
        //        editrow["Qual_Richiedente"] = backuprow["Qual_Richiedente"];
        //        editrow["Qual_DateRequest"] = backuprow["Qual_DateRequest"];
        //        editrow["Qual_IPRequest"] = backuprow["Qual_IPRequest"];

        //        editrow["Qual_Rev_Obsolete"] = true;


        //        try
        //        {
        //            //editrow.AcceptChanges();

        //            this.Validate();
        //            this.dtQualityEditRecBindingSource.EndEdit();
        //            this.dt_Quality_EditRecTableAdapter.Update(editrow);
        //        }
        //        catch (System.Exception ex)
        //        {
        //            MessageBox.Show("Update failed");
        //        }

        //        //Inserisco nuovo record
        //        var newrow = ds_Quality.dt_Quality.NewRow();
        //        newrow.ItemArray = backuprow.ItemArray;

        //        //newrow["Id"] = DBNull.Value;
        //        int MaxValue = Convert.ToInt32(ds_Quality.dt_Quality.AsEnumerable().Max(row => row["Id"]));
        //        MaxValue++;
        //        //newrow["Id"] = (Convert.ToInt32(ds_Quality.dt_Quality.AsEnumerable().Max(row => Glob_RowId))+1);
        //        newrow["Id"] = MaxValue;
        //        newrow["Qual_Des"] = tb_Des.Text;
        //        newrow["Qual_Path"] = tb_folder.Text;
        //        newrow["Qual_Ver"] = tb_vers.Text;
        //        newrow["Qual_Rev"] = tb_rev.Text;
        //        newrow["Qual_Rev_Obsolete"] = false;

        //        ds_Quality.dt_Quality.Rows.Add(newrow);
        //        dt_QualityTableAdapter.Update(newrow);
        //    }
        //}

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

        private void visualizzaRevisioniObsoleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView1.Columns["Qual_Rev_Obsolete"].Visible = true;
            VediObsolete = true;
            AggiornaArchivi();
        }

        private void nascondiRevisioniObsoleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView1.Columns["Qual_Rev_Obsolete"].Visible = false;
            VediObsolete = false;
            AggiornaArchivi();
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
            if (cb_User.Text == "___")
            {
                MessageBox.Show("Si prega di compilare correttamente il campo Utente. \nNon può essere vuoto!");
                cb_projprodarea.Focus();
                return;
            }
            if (lab_projprodarea.Text == "___")
            {
                MessageBox.Show("Si prega di compilare correttamente il campo Project / Product / Area. \nNon può essere vuoto!");
                cb_projprodarea.Focus();
                return;
            }
            if (lab_org.Text == "___")
            {
                MessageBox.Show("Si prega di compilare correttamente il campo Organization. \nNon può essere vuoto!");
                cb_org.Focus();
                return;
            }
            if (lab_type.Text == "___")
            {
                MessageBox.Show("Si prega di compilare correttamente il campo Type Document. \nNon può essere vuoto!");
                cb_type.Focus();
                return;
            }
            if (lab_class.Text == "___")
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
                DataView view = new DataView(ds_Quality.dt_Quality);
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
    }
}
