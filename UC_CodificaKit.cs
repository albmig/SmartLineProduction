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
using System.Web.UI.Design;
using System.Net.Mail;
using System.Net;

namespace SmartLineProduction
{
    public partial class UC_CodificaKit : MetroFramework.Forms.MetroForm
    {
        string code_prefix = "XKIT";
        string code_cli = "";
        string code_variante = "";
        string code_prog = "";
        string code_combohw = "";
        string code_cablvar = "";
        string code_fam = "";
        string code_freq = "";
        string code_suffix = "_L";
        string code_KIT = "";

        string mail_subject = "Richiesta di documentazione: ";
        string mail_text = "Richiedo la creazione della documentazione ";

        public UC_CodificaKit()
        {
            InitializeComponent();
        }

        /// Control Events
        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_CodificaKit_Load(object sender, EventArgs e)
        {

            SetView();
            CreaCodice();

            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.Tab_Siglacli'. È possibile spostarla o rimuoverla se necessario.
            this.tab_SiglacliTableAdapter.FillBy_Tab_SIGLACLI(this.ds_SL.Tab_Siglacli);
            SettaCliSistematica();
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL1.Tab_Combokit'. È possibile spostarla o rimuoverla se necessario.
            this.tab_CombokitTableAdapter.FillBy_Tab_COMBOKIT(this.ds_SL.Tab_Combokit);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL1.Tab_Freq'. È possibile spostarla o rimuoverla se necessario.
            this.tab_FreqTableAdapter.FillBy_Tab_FREQ(this.ds_SL.Tab_Freq);
            SettaFreq868();
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL1.Tab_Fam'. È possibile spostarla o rimuoverla se necessario.
            this.tab_FamTableAdapter.FillBy_Tab_FAM(this.ds_SL.Tab_Fam);
            SettaFamSmartLine();
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL1.Tab_Cbl'. È possibile spostarla o rimuoverla se necessario.
            this.tab_CblTableAdapter.FillBy_Tab_CBL(this.ds_SL.Tab_Cbl);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.Tab_Combohw'. È possibile spostarla o rimuoverla se necessario.
            this.tab_CombohwTableAdapter.FillBy_Tab_COMBOHW(this.ds_SL.Tab_Combohw);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.Tab_Var'. È possibile spostarla o rimuoverla se necessario.
            this.tab_VarTableAdapter.FillBy_Tab_VAR(this.ds_SL.Tab_Var);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_ArticoliSchede'. È possibile spostarla o rimuoverla se necessario.
            //this.sF_ArticoliSchedeTableAdapter.FillBy_SchedeProdottoKit(this.ds_SL.SF_ArticoliSchede);
        }

        private void tabVarBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)tabVarBindingSource.Current;
            if (drview != null)
            {
                code_variante = drview["Tab_Valore"].ToString();
                lab_var.Text = code_variante;
                CreaCodice();
            }
        }

        private void tabCombohwBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)tabCombohwBindingSource.Current;
            if (drview != null)
            {
                code_combohw = drview["Tab_Valore"].ToString();
                lab_combohw.Text = code_combohw;
                CreaCodice();
            }
        }

        private void tabCblBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)tabCblBindingSource.Current;
            if (drview != null)
            {
                code_cablvar = drview["Tab_Valore"].ToString();
                lab_cbl.Text = code_cablvar;
                CreaCodice();
            }
        }

        private void tabFamBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)tabFamBindingSource.Current;
            if (drview != null)
            {
                code_fam = drview["Tab_Valore"].ToString();
                lab_fam.Text = code_fam;
                CreaCodice();
            }
        }

        private void tabFreqBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)tabFreqBindingSource.Current;
            if (drview != null)
            {
                code_freq = drview["Tab_Valore"].ToString();
                lab_freq.Text = code_freq;
                CreaCodice();
            }
        }

        private void tabCombokitBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)tabCombokitBindingSource.Current;
            if (drview != null)
            {
                code_prog = drview["Tab_Valore"].ToString();
                lab_prog.Text = code_prog;
                CreaCodice();
            }
        }

        private void tabSiglacliBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)tabSiglacliBindingSource.Current;
            if (drview != null)
            {
                code_cli = drview["Tab_Valore"].ToString();
                lab_cli.Text = code_cli;
                CreaCodice();
            }
        }

        private void sFArticoliSchedeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            AggiornaMail();

            DataRowView drview = (DataRowView)sFArticoliSchedeBindingSource.Current;
            if (drview == null) { return; }

            string articolo = drview["Articolo"].ToString();
            string famiglia = drview["Famiglia"].ToString();
            string sigla = "";

            //Calcolo del path
            string path = Properties.Settings.Default.Doc_folder;
            string path_it = "";
            string path_en = "";

            sigla = articolo.Substring(4, 2);
            path = path + @"XKIT\" + sigla + @"\";
            path_it = path + articolo + @"\IT\" + articolo + ".pdf";
            path_en = path + articolo + @"\EN\" + articolo + ".pdf";

            if (System.IO.File.Exists(path_it)) { Schede_pdf_it.LoadFile(path_it); } else { Schede_pdf_it.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
            if (System.IO.File.Exists(path_en)) { Schede_pdf_en.LoadFile(path_en); } else { Schede_pdf_en.LoadFile(@"Resources\Pdf_notpresent.pdf"); }
            SetPDFReader();
        }

        private void gv_Schede_Click(object sender, EventArgs e)
        {
            //if (gv_Schede.CurrentRow == null) { return; }

            int foundIndex = 0;
            string codice = gv_Schede.CurrentRow.Cells["gv_Schede_Articolo"].Value.ToString();
            foundIndex = tabSiglacliBindingSource.Find("Tab_Valore", "SE");
        }

        /// Routines
        private void SetView()
        {
            code_prefix = "XKIT";
            code_cli = "__";
            code_variante = "_";
            code_prog = "__";
            code_combohw = "_";
            code_cablvar = "_";
            code_fam = "_";
            code_freq = "_";
            code_suffix = "_L";
            code_KIT = "";

            tb_CodiceKit.Text = "XKIT";
        }

        private void CreaCodice()
        {
            code_KIT = code_prefix + code_cli + code_variante + code_prog + code_combohw + code_cablvar + code_fam + code_freq + code_suffix;
            tb_CodiceKit.Text = code_KIT;
            tb_CodiceKit.Refresh();
            FiltraKit();
        }

        private void FiltraKit()
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_ArticoliSchede'. È possibile spostarla o rimuoverla se necessario.
            this.sF_ArticoliSchedeTableAdapter.FillBy_CodificaKit(this.ds_SL.SF_ArticoliSchede, code_KIT);

            gv_Schede.Refresh();
            AggiornaMail();
        }

        private void SettaCliSistematica()
        {
            //Seleziona cliente Sistematica
            int foundIndex = tabSiglacliBindingSource.Find("Tab_Valore", "SE");
            if (foundIndex > -1) { cb_Cliente.SelectedIndex = foundIndex; }
            DataRowView drview = (DataRowView)tabSiglacliBindingSource.Current;
            code_cli = drview["Tab_Valore"].ToString();
            lab_cli.Text = code_cli;
        }

        private void SettaFreq868()
        {
            //Seleziona cliente Sistematica
            int foundIndex = tabFreqBindingSource.Find("Tab_Valore", "X");
            if (foundIndex > -1) { cb_Freq.SelectedIndex = foundIndex; }
            DataRowView drview = (DataRowView)tabFreqBindingSource.Current;
            code_freq = drview["Tab_Valore"].ToString();
            lab_freq.Text = code_freq;
        }

        private void SettaFamSmartLine()
        {
            //Seleziona cliente Sistematica
            int foundIndex = tabFamBindingSource.Find("Tab_Valore", "X");
            if (foundIndex > -1) { cb_Fam.SelectedIndex = foundIndex; }
            DataRowView drview = (DataRowView)tabFamBindingSource.Current;
            code_fam = drview["Tab_Valore"].ToString();
            lab_fam.Text = code_fam;
        }

        private void SetPDFReader()
        {
            Schede_pdf_it.setView("FitV");
            Schede_pdf_en.setView("FitV");

            Schede_pdf_it.setShowScrollbars(false);
            Schede_pdf_en.setShowScrollbars(false);

            Schede_pdf_it.setShowToolbar(false);
            Schede_pdf_en.setShowToolbar(false);

            Schede_pdf_it.setPageMode("none");
            Schede_pdf_en.setPageMode("none");
        }

        private void btn_send_mail_Click(object sender, EventArgs e)
        {
            try
            {
                string body = tb_mail_text.Text;
                string subject = tb_mail_subject.Text;

                MailAddress from = new MailAddress("webmaster@sistematica.it");
                MailAddress to = new MailAddress("albertomigliore2+hdol9c2p0wycggk9mgnd@boards.trello.com", "alberto.migliore@sistematica.it");

                MailMessage mail = new MailMessage(from, to);

                mail.Subject = subject;
                mail.Body = body;

                SmtpClient smtpMail = new SmtpClient("mail.truemail.it");
                smtpMail.Port = 587;
                smtpMail.EnableSsl = true;
                smtpMail.Credentials = new NetworkCredential("alberto.migliore@visualdata.it", "Chiara2009");
                // and then send the mail
                smtpMail.Send(mail);

                MessageBox.Show("Invio della mail effettuato correttamente!");
                tb_mail_subject.Text = "(INVIATA) " + tb_mail_subject.Text;
                tb_mail_text.Text = "(INVIATA) \n" + tb_mail_text.Text;
            }

            catch (SmtpException ex)
            {
                throw new ApplicationException
                  ("SmtpException has occured: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AggiornaMail()
        {
            tb_mail_subject.Text = mail_subject;
            tb_mail_text.Text = mail_text;
            DataRowView drview = (DataRowView)sFArticoliSchedeBindingSource.Current;
            if (drview == null) { return; }

            string articolo = drview["Articolo"].ToString();

            tb_mail_subject.Text = mail_subject + " " + articolo;
        }
    }
}
