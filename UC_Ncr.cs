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
using Spire.Pdf;
using Spire.Pdf.Widget;
using Spire.Pdf.Fields;

namespace SmartLineProduction
{
    public partial class UC_Ncr : MetroFramework.Forms.MetroForm
    {
        public static int NCR_Id = 0;
        private string displayform = "V"; // V-View/I-Insert/E-Edit
        public static int NCR_Phase = 0; //1-Identificazione/2-Azioni/3-Chiusura
        //private string pathForPdf = @"\\192.168.0.8\sistematica\AREA_QUALITA\Modulo NON CONFORMITA\NCR - IT.pdf";
        //private string pathForPdf = @"\\192.168.0.8\sistematica\AREA_QUALITA\Modulo NON CONFORMITA\new.pdf";
        private string pathForPdf = @"\\192.168.0.8\sistematica\AREA_QUALITA\Modulo NON CONFORMITA\ModuloNCR.pdf";
            
        private string PathDef = @"\\192.168.0.8\sistematica\AREA_QUALITA\Modulo NON CONFORMITA\";
        private string FileDef = "";
        //public int Ncr_Progr;
        //public string Ncr_Progr_Nome;
        //public int Ncr_Phase;
        //public int Ncr_Ident_Originatore;
        //public string Ncr_Ident_Originatore_Nome;
        //public string Ncr_Ident_Prodotto;
        //public DateTime Ncr_Ident_DateCreation;
        //public string Ncr_Ident_DateCreation_Nome;
        //public string Ncr_Ident_Descrizione;
        //public int Ncr_Ident_Level;
        //public string Ncr_Ident_Level_Name;
        //public string Ncr_Ident_Coinvolti;
        //public bool Ncr_Ident_Customer;
        //public bool Ncr_Ident_Deviazione;
        //public string Ncr_Azioni_Pianificazione;
        //public int Ncr_Azioni_Responsabile;
        //public string Ncr_Azioni_Responsabile_Nome;
        //public DateTime Ncr_Azioni_RespDate;
        //public int Ncr_Azioni_RespApprovazione;
        //public DateTime Ncr_Azioni_RespAppDate;
        //public int Ncr_Close_Azione_RespUser;
        //public DateTime Ncr_Close_Azione_RespUserDate;
        //public string Ncr_Close_Azione_RespCustomer;
        //public DateTime Ncr_Close_Azione_RespCustDate;
        //public string Ncr_Close_Disposition;

        public int glob_NCR_Id;                            // Id Ncr Record
        public int glob_NCR_SegnalazioneNumero_Page1;      // NUMERO SEGNALAZIONE
        public int glob_NCR_Level;                         // Livello Criticità 0-Maggiore 1-Minore 2-Osservazione
        public DateTime glob_NCR_Data_Page1;               // DATA INSERIMENTO
        public string glob_NCR_Codice_Articolo_Page1;      // DESCRIZIONE ARTICOLO
        public string glob_NCR_Des_Articolo;               // DESCRIZIONE ARTICOLO
        public string glob_NCR_CliFor;                     // CLIENTE o FORNITORE RAGIONE SOCIALE
        public string glob_NCR_RagSoc_CliFor;              // CLIENTE o FORNITORE RAGIONE SOCIALE
        public int glob_NCR_Provenienza;                   // Provenienza
        public string glob_NCR_Provenienza_Altro;          // ALTRO - DESCRIZIONE
        public int glob_NCR_Problema;                      // Problema
        public string glob_NCR_Problema_Des;               // PROBLEMA - DESCRIZIONE

        public int glob_NCR_RespSoluzione;                   // Riferimento
        public int glob_NCR_Emissione;                     // Emesso da:
        public int glob_NCR_Destinatario;                  // Destinatario:
        public string glob_NCR_RespSoluzione_Des;            // Riferimento
        public string glob_NCR_Emissione_Des;              // Emesso da:
        public string glob_NCR_Destinatario_Des;           // Destinatario:

        public bool glob_NCR_Causa_01;                     // causa - RISCONTRATA
        public bool glob_NCR_Causa_02;                     // causa - POTENZIALE
        public bool glob_NCR_Causa_03;                     // causa - RGQ
        public bool glob_NCR_Causa_04;                     // causa - R. Area
        public string glob_NCR_Causa_Des;                  // CAUSA - DESCRIZIONE
        public bool glob_NCR_Azione_01;                    // AZIONE - (EVENTUALE) AZIONE IMMEDIATA
        public bool glob_NCR_Azione_02;                    // AZIONE - AZIONE CORRETTIVA
        public bool glob_NCR_Azione_03;                    // AZIONE - AZIONE AZIONE PREVENTIVA
        public bool glob_NCR_Azione_04;                    // AZIONE - (EVENTUALE) AZIONE IMMEDIATA - RGQ
        public bool glob_NCR_Azione_05;                    // AZIONE - (EVENTUALE) AZIONE IMMEDIATA - R. Area
        public bool glob_NCR_Azione_06;                    // AZIONE - AZIONE CORRETTIVA - RGQ
        public bool glob_NCR_Azione_07;                    // AZIONE - AZIONE CORRETTIVA - R. Area
        public string glob_NCR_Azione_Des_01;              // AZIONE - (EVENTUALE) AZIONE IMMEDIATA - DES
        public string glob_NCR_Azione_Des_02;              // AZIONE - CORRETTIVA/PREVENTIVA - DES
        public string glob_NCR_Pianificazione_01;          // Tempi programmati per l’ATTUAZIONE dell’azione intrapresa
        public string glob_NCR_Pianificazione_02;          // Tempi programmati per la VERIFICA DELL’EFFICACIA dell’azione intrapresa
        public bool glob_NCR_VerificaAttuazione_01;        // VERIFICHE INTRAPRESE - ATTUAZIONE - RGQ
        public bool glob_NCR_VerificaAttuazione_02;        // VERIFICHE INTRAPRESE - ATTUAZIONE - R. Area
        public string glob_NCR_VerificaAttuazione_Des;     // VERIFICHE INTRAPRESE - ATTUAZIONE - DES
        public bool glob_NCR_VerificaEfficacia_01;         // VERIFICHE INTRAPRESE - EFFICACIA - RGQ
        public bool glob_NCR_VerificaEfficacia_02;         // VERIFICHE INTRAPRESE - EFFICACIA - R. Area
        public string glob_NCR_VerificaEfficacia_Des;      // VERIFICHE INTRAPRESE - EFFICACIA - DES
        public bool glob_NCR_GiudRisolutiva;               // GIUDIZIO FINALE - RISOLUTIVA
        public bool glob_NCR_GiudBuona;                    // GIUDIZIO FINALE - BUONA
        public bool glob_NCR_GiudScarsa;                   // GIUDIZIO FINALE - SCARSA
        public bool glob_NCR_GiudInsuff;                   // GIUDIZIO FINALE - INSUFF

        public int glob_NCR_SegnalazioneNumero_Page2;      // NUMERO SEGNALAZIONE
        //public bool glob_NCR_Maggiore_Page2;               // NON CONFORMITÀ MAGGIORE
        //public bool glob_NCR_Minore_Page2;                 // NON CONFORMITÀ MINORE
        //public bool glob_NCR_Osservazione_Page2;           // OSSERVAZIONE
        public DateTime glob_NCR_Data_Page2;               // DATA INSERIMENTO
        public string glob_NCR_Codice_Articolo_Page2;      // DESCRIZIONE ARTICOLO
        //public bool glob_NCR_CliFor_C_Page2;               // CLIENTE
        //public bool glob_NCR_CliFor_F_Page2;               // FORNITORE
        //public string glob_NCR_CliFor_Page2;               // CLIENTE o FORNITORE RAGIONE SOCIALE

        public DateTime glob_NCR_Att_Data_01;              // ATTIVITÀ INTRAPRESE - DATA
        public DateTime glob_NCR_Att_Data_02;              // ATTIVITÀ INTRAPRESE - DATA
        public DateTime glob_NCR_Att_Data_03;              // ATTIVITÀ INTRAPRESE - DATA
        public DateTime glob_NCR_Att_Data_04;              // ATTIVITÀ INTRAPRESE - DATA
        public DateTime glob_NCR_Att_Data_05;              // ATTIVITÀ INTRAPRESE - DATA
        public DateTime glob_NCR_Att_Data_06;              // ATTIVITÀ INTRAPRESE - DATA
        public DateTime glob_NCR_Att_Data_07;              // ATTIVITÀ INTRAPRESE - DATA
        public DateTime glob_NCR_Att_Data_08;              // ATTIVITÀ INTRAPRESE - DATA
        public DateTime glob_NCR_Att_Data_09;              // ATTIVITÀ INTRAPRESE - DATA
        public DateTime glob_NCR_Att_Data_010;             // ATTIVITÀ INTRAPRESE - DATA
        public DateTime glob_NCR_Att_Data_011;             // ATTIVITÀ INTRAPRESE - DATA
        public DateTime glob_NCR_Att_Data_012;             // ATTIVITÀ INTRAPRESE - DATA
        public DateTime glob_NCR_Att_Data_013;             // ATTIVITÀ INTRAPRESE - DATA
        public DateTime glob_NCR_Att_Data_014;             // ATTIVITÀ INTRAPRESE - DATA
        public DateTime glob_NCR_Att_Data_015;             // ATTIVITÀ INTRAPRESE - DATA
        public string glob_NCR_Att_Des_01;                 // ATTIVITÀ INTRAPRESE - DES
        public string glob_NCR_Att_Des_02;                 // ATTIVITÀ INTRAPRESE - DES
        public string glob_NCR_Att_Des_03;                 // ATTIVITÀ INTRAPRESE - DES
        public string glob_NCR_Att_Des_04;                 // ATTIVITÀ INTRAPRESE - DES
        public string glob_NCR_Att_Des_05;                 // ATTIVITÀ INTRAPRESE - DES
        public string glob_NCR_Att_Des_06;                 // ATTIVITÀ INTRAPRESE - DES
        public string glob_NCR_Att_Des_07;                 // ATTIVITÀ INTRAPRESE - DES
        public string glob_NCR_Att_Des_08;                 // ATTIVITÀ INTRAPRESE - DES
        public string glob_NCR_Att_Des_09;                 // ATTIVITÀ INTRAPRESE - DES
        public string glob_NCR_Att_Des_010;                // ATTIVITÀ INTRAPRESE - DES
        public string glob_NCR_Att_Des_011;                // ATTIVITÀ INTRAPRESE - DES
        public string glob_NCR_Att_Des_012;                // ATTIVITÀ INTRAPRESE - DES
        public string glob_NCR_Att_Des_013;                // ATTIVITÀ INTRAPRESE - DES
        public string glob_NCR_Att_Des_014;                // ATTIVITÀ INTRAPRESE - DES
        public string glob_NCR_Att_Des_015;                // ATTIVITÀ INTRAPRESE - DES

        public UC_Ncr()
        {
            InitializeComponent();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_Ncr_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Ncr.Ncr_SerialNumbers'. È possibile spostarla o rimuoverla se necessario.
            this.ncr_SerialNumbersTableAdapter.Fill(this.ds_Ncr.Ncr_SerialNumbers);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Ncr.User_RespApprovazione'. È possibile spostarla o rimuoverla se necessario.
            this.user_RespApprovazioneTableAdapter.Fill(this.ds_Ncr.User_RespApprovazione);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Ncr.User_Responsabile'. È possibile spostarla o rimuoverla se necessario.
            this.user_ResponsabileTableAdapter.Fill(this.ds_Ncr.User_Responsabile);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Ncr.User_Originatore'. È possibile spostarla o rimuoverla se necessario.
            this.user_OriginatoreTableAdapter.Fill(this.ds_Ncr.User_Originatore);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Ncr.SF_Ncr_CliFor'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Ncr_CliForTableAdapter.Fill(this.ds_Ncr.SF_Ncr_CliFor);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Ncr.SF_Ncr_Articoli'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Ncr_ArticoliTableAdapter.Fill(this.ds_Ncr.SF_Ncr_Articoli);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Ncr.SF_Ncr_CliFor'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Ncr_CliForTableAdapter.Fill(this.ds_Ncr.SF_Ncr_CliFor);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Ncr.Ncr'. È possibile spostarla o rimuoverla se necessario.
            this.ncrTableAdapter.Fill(this.ds_Ncr.Ncr);



            //Rendere attivo prima di rilasciare versione
            //UC_Login uC_Login = new UC_Login();
            //uC_Login.ShowDialog();
            NCR_Id = 2;

            SettaForm();

            tab_fasi.SelectedTab = tab_fasi.TabPages["tab_inserimento"];
            ncrBindingSource.MoveFirst();
        }

        private void UC_Ncr_Activated(object sender, EventArgs e)
        {
            //string ppp = "Activated " + NCR_Id.ToString();
            //MessageBox.Show(ppp);
        }

        private void menu_new_Click(object sender, EventArgs e)
        {
            displayform = "I";
            NCR_Phase = 1;
            Application.UseWaitCursor = true;
            SettaForm();
            Application.UseWaitCursor = false;

        }

        private void ncrBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            PulisciVar();

            if (ncrBindingSource.Current != null)
            {
                ToClass();
                ToScreen();

                //Filtra e verifica relazione con SF_NCRUsersGroups
                LoadNcrUserGroups(glob_NCR_Id);

            }

            if (tab_fasi.SelectedIndex == 3)
            {
                CreaPdf();
            }
        }

        private void tab_fasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tab_fasi.SelectedIndex)
            {
                case 0: //Identificazione
                    {
                        break;
                    }
                case 1: //Azioni correttive/preventive e disposizioni
                    {
                        break;
                    }
                case 2: //Chiusura delle non conformità
                    {
                        break;
                    }
                case 3: //Visualizza Pdf
                    {
                        CreaPdf();
                        break;
                    }
            }
        }

        private void menu_edit_Click(object sender, EventArgs e)
        {
            displayform = "E";
            SettaForm();
        }

        /////////////////////////////////////////////////////////////////////////////// FUNZIONI

        private void SettaForm()
        {

            switch (displayform)
            {
                case "V":
                    pan_Menu_comandi.Enabled = true;
                    pan_Menu_salva.Enabled = false;
                    pan_Menu_exit.Enabled = true;

                    panel_identificazione.Enabled = false;
                    panel_azioni.Enabled = false;
                    panel_chiusura.Enabled = false;
                    panel_pdf.Enabled = true;

                    //this.dt_QualityTableAdapter.FillBy_CodiceQuality(this.ds_Quality.dt_Quality);

                    //dtQualityBindingSource.ResumeBinding();
                    //gv_Quality.Enabled = true;
                    //tb_Des.Enabled = false;
                    //tb_folder.Enabled = false;
                    //tb_rev.Enabled = false;
                    //tb_vers.Enabled = false;

                    //dtQualityBindingSource.RemoveFilter();
                    //dtQualityBindingSource.MoveFirst();

                    //label_codview.Visible = true;
                    //label_codedit.Visible = false;
                    //lab_Codice_View.Visible = true;
                    //lab_Codice_Edit.Visible = false;
                    break;
                case "I":
                    ncrBindingSource.SuspendBinding();
                    var newrow = ds_Ncr.Ncr.NewRow();

                    switch (NCR_Phase)
                    {
                        case 1:
                            panel_identificazione.Enabled = true;
                            panel_azioni.Enabled = false;
                            panel_chiusura.Enabled = false;
                            panel_pdf.Enabled = true;
                            break;
                        case 2:
                            panel_identificazione.Enabled = false;
                            panel_azioni.Enabled = true;
                            panel_chiusura.Enabled = false;
                            panel_pdf.Enabled = true;
                            break;
                        case 3:
                            panel_identificazione.Enabled = false;
                            panel_azioni.Enabled = false;
                            panel_chiusura.Enabled = true;
                            panel_pdf.Enabled = true;
                            break;
                    }

                    //dtQualityBindingSource.SuspendBinding();
                    //tb_Des.Enabled = true;
                    //tb_Des.Text = "";
                    //tb_folder.Enabled = true;
                    //tb_rev.Enabled = true;
                    //tb_vers.Enabled = true;

                    //gv_Quality.Enabled = false;

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

                    //label_codview.Visible = false;
                    //label_codedit.Visible = true;
                    //lab_Codice_View.Visible = false;
                    //lab_Codice_Edit.Visible = true;

                    //gv_Quality.Enabled = false;

                    //pan_Menu_comandi.Enabled = false;
                    //pan_Menu_salva.Enabled = true;
                    //pan_Menu_exit.Enabled = false;

                    break;
                case "E":
                    pan_Menu_comandi.Enabled = false;
                    pan_Menu_salva.Enabled = true;
                    pan_Menu_exit.Enabled = false;

                    panel_identificazione.Enabled = true;
                    panel_azioni.Enabled = true;
                    panel_chiusura.Enabled = true;
                    panel_pdf.Enabled = true;

                    //gv_Quality.Enabled = false;

                    //cb_User.Enabled = false;
                    //cb_projprodarea.Enabled = false;
                    //cb_org.Enabled = false;
                    //cb_type.Enabled = false;
                    //cb_class.Enabled = false;
                    //tb_Des.Enabled = true;
                    //tb_folder.Enabled = true;
                    //tb_rev.Enabled = false;
                    //tb_vers.Enabled = false;

                    //label_codview.Visible = true;
                    //label_codedit.Visible = false;
                    //lab_Codice_View.Visible = true;
                    //lab_Codice_Edit.Visible = false;



                    break;
            }
        }

        private void ToClass()
        {
            DataRowView current_ncr = (DataRowView)ncrBindingSource.Current;

            glob_NCR_Id = convInt(current_ncr["Ncr_Id"]);
            glob_NCR_SegnalazioneNumero_Page1 = convInt(current_ncr["Ncr_Progr"]);
            glob_NCR_SegnalazioneNumero_Page2 = convInt(current_ncr["Ncr_Progr"]);
            glob_NCR_Data_Page1 = Convert.ToDateTime(current_ncr["Ncr_DataCreaz"]);
            glob_NCR_Data_Page2 = Convert.ToDateTime(current_ncr["Ncr_DataCreaz"]);
            glob_NCR_Level = convInt(current_ncr["NCR_Level"]);

            //Lettura articoli
            glob_NCR_Codice_Articolo_Page1 = Convert.ToString(current_ncr["Ncr_CodArticolo"]);
            glob_NCR_Codice_Articolo_Page2 = Convert.ToString(current_ncr["Ncr_CodArticolo"]);
            DataRowView linked_articolo = (DataRowView)ncrSFNcrArticoliBindingSource.Current;
            if (linked_articolo != null)
            {
                glob_NCR_Des_Articolo = linked_articolo["Descrizione"].ToString();
            }
            else
            {
                glob_NCR_Des_Articolo = string.Empty;
            }

            //Lettura Cliente / Fornitore
            // Evento Bindingsource current changed
            glob_NCR_CliFor = Convert.ToString(current_ncr["Ncr_Clifor"]);
            glob_NCR_Provenienza = convInt(current_ncr["Ncr_Provenienza"]);
            if (glob_NCR_Provenienza == 7)
            {
                glob_NCR_Provenienza_Altro = Convert.ToString(current_ncr["Ncr_Provenienza_Altro"]);
            }
            else
            {
                glob_NCR_Provenienza_Altro = string.Empty;
            }
            glob_NCR_Problema = convInt(current_ncr["Ncr_Problema_Tipo"]);
            glob_NCR_Problema_Des = Convert.ToString(current_ncr["Ncr_Problema_Des"]);
            glob_NCR_RespSoluzione = convInt(current_ncr["Ncr_User_RespSoluzione"]);
            glob_NCR_Emissione = convInt(current_ncr["Ncr_User_Emissione"]);
            glob_NCR_Destinatario = convInt(current_ncr["Ncr_User_RespAnalisi"]);

            //Lettura Originatore
            userOriginatoreBindingSource.Position = userOriginatoreBindingSource.Find("ID", glob_NCR_Emissione);
            if (userOriginatoreBindingSource.Position >= 0)
            {
                DataRowView linked_Originatore = (DataRowView)userOriginatoreBindingSource.Current;
                glob_NCR_Emissione_Des = linked_Originatore["CognomeNome"].ToString();
            }
            else
            {
                glob_NCR_Emissione_Des = string.Empty;
            }

            //Lettura Responsabile
            userResponsabileBindingSource.Position = userResponsabileBindingSource.Find("ID", glob_NCR_RespSoluzione);
            if (userResponsabileBindingSource.Position >= 0)
            {
                DataRowView linked_Responsabile = (DataRowView)userResponsabileBindingSource.Current;
                glob_NCR_RespSoluzione_Des = linked_Responsabile["CognomeNome"].ToString();
            }
            else
            {
                glob_NCR_RespSoluzione_Des = string.Empty;
            }

            //Lettura Destinatario
            userRespApprovazioneBindingSource.Position = userRespApprovazioneBindingSource.Find("ID", glob_NCR_Destinatario);
            if (userRespApprovazioneBindingSource.Position >= 0)
            {
                DataRowView linked_Destinatario = (DataRowView)userRespApprovazioneBindingSource.Current;
                glob_NCR_Destinatario_Des = linked_Destinatario["CognomeNome"].ToString();
            }
            else
            {
                glob_NCR_Destinatario_Des = string.Empty;
            }


            //public bool glob_NCR_Problema_01;                  // RISCONTRATO
            //public bool glob_NCR_Problema_02;                  // POTENZIALE
            //public string glob_NCR_Problema_Des;               // PROBLEMA - DESCRIZIONE
            //public string glob_NCR_Riferimento;                // Riferimento 
            //public string glob_NCR_Emissione;                  // Emesso da:
            //public string glob_NCR_Destinatario;               // Destinatario:
            //public bool glob_NCR_Causa_01;                     // causa - RISCONTRATA
            //public bool glob_NCR_Causa_02;                     // causa - POTENZIALE
            //public bool glob_NCR_Causa_03;                     // causa - RGQ
            //public bool glob_NCR_Causa_04;                     // causa - R. Area
            //public string glob_NCR_Causa_Des;                  // CAUSA - DESCRIZIONE
            //public bool glob_NCR_Azione_01;                    // AZIONE - (EVENTUALE) AZIONE IMMEDIATA
            //public bool glob_NCR_Azione_02;                    // AZIONE - AZIONE CORRETTIVA
            //public bool glob_NCR_Azione_03;                    // AZIONE - AZIONE AZIONE PREVENTIVA
            //public bool glob_NCR_Azione_04;                    // AZIONE - (EVENTUALE) AZIONE IMMEDIATA - RGQ
            //public bool glob_NCR_Azione_05;                    // AZIONE - (EVENTUALE) AZIONE IMMEDIATA - R. Area
            //public bool glob_NCR_Azione_06;                    // AZIONE - AZIONE CORRETTIVA - RGQ
            //public bool glob_NCR_Azione_07;                    // AZIONE - AZIONE CORRETTIVA - R. Area
            //public string glob_NCR_Azione_Des_01;              // AZIONE - (EVENTUALE) AZIONE IMMEDIATA - DES
            //public string glob_NCR_Azione_Des_02;              // AZIONE - CORRETTIVA/PREVENTIVA - DES
            //public string glob_NCR_Pianificazione_01;          // Tempi programmati per l’ATTUAZIONE dell’azione intrapresa
            //public string glob_NCR_Pianificazione_02;          // Tempi programmati per la VERIFICA DELL’EFFICACIA dell’azione intrapresa
            //public bool glob_NCR_VerificaAttuazione_01;        // VERIFICHE INTRAPRESE - ATTUAZIONE - RGQ
            //public bool glob_NCR_VerificaAttuazione_02;        // VERIFICHE INTRAPRESE - ATTUAZIONE - R. Area
            //public string glob_NCR_VerificaAttuazione_Des;     // VERIFICHE INTRAPRESE - ATTUAZIONE - DES
            //public bool glob_NCR_VerificaEfficacia_01;         // VERIFICHE INTRAPRESE - EFFICACIA - RGQ
            //public bool glob_NCR_VerificaEfficacia_02;         // VERIFICHE INTRAPRESE - EFFICACIA - R. Area
            //public string glob_NCR_VerificaEfficacia_Des;      // VERIFICHE INTRAPRESE - EFFICACIA - DES
            //public bool glob_NCR_GiudRisolutiva;               // GIUDIZIO FINALE - RISOLUTIVA
            //public bool glob_NCR_GiudBuona;                    // GIUDIZIO FINALE - BUONA
            //public bool glob_NCR_GiudScarsa;                   // GIUDIZIO FINALE - SCARSA
            //public bool glob_NCR_GiudInsuff;                   // GIUDIZIO FINALE - INSUFF

            //public string glob_NCR_Articolo_Page2;             // DESCRIZIONE ARTICOLO
            //public bool glob_NCR_CliFor_C_Page2;               // CLIENTE
            //public bool glob_NCR_CliFor_F_Page2;               // FORNITORE
            //public string glob_NCR_CliFor_Page2;               // CLIENTE o FORNITORE RAGIONE SOCIALE

            //public DateTime glob_NCR_Att_Data_01;              // ATTIVITÀ INTRAPRESE - DATA
            //public DateTime glob_NCR_Att_Data_02;              // ATTIVITÀ INTRAPRESE - DATA
            //public DateTime glob_NCR_Att_Data_03;              // ATTIVITÀ INTRAPRESE - DATA
            //public DateTime glob_NCR_Att_Data_04;              // ATTIVITÀ INTRAPRESE - DATA
            //public DateTime glob_NCR_Att_Data_05;              // ATTIVITÀ INTRAPRESE - DATA
            //public DateTime glob_NCR_Att_Data_06;              // ATTIVITÀ INTRAPRESE - DATA
            //public DateTime glob_NCR_Att_Data_07;              // ATTIVITÀ INTRAPRESE - DATA
            //public DateTime glob_NCR_Att_Data_08;              // ATTIVITÀ INTRAPRESE - DATA
            //public DateTime glob_NCR_Att_Data_09;              // ATTIVITÀ INTRAPRESE - DATA
            //public DateTime glob_NCR_Att_Data_010;             // ATTIVITÀ INTRAPRESE - DATA
            //public DateTime glob_NCR_Att_Data_011;             // ATTIVITÀ INTRAPRESE - DATA
            //public DateTime glob_NCR_Att_Data_012;             // ATTIVITÀ INTRAPRESE - DATA
            //public DateTime glob_NCR_Att_Data_013;             // ATTIVITÀ INTRAPRESE - DATA
            //public DateTime glob_NCR_Att_Data_014;             // ATTIVITÀ INTRAPRESE - DATA
            //public DateTime glob_NCR_Att_Data_015;             // ATTIVITÀ INTRAPRESE - DATA
            //public string glob_NCR_Att_Des_01;                 // ATTIVITÀ INTRAPRESE - DES
            //public string glob_NCR_Att_Des_02;                 // ATTIVITÀ INTRAPRESE - DES
            //public string glob_NCR_Att_Des_03;                 // ATTIVITÀ INTRAPRESE - DES
            //public string glob_NCR_Att_Des_04;                 // ATTIVITÀ INTRAPRESE - DES
            //public string glob_NCR_Att_Des_05;                 // ATTIVITÀ INTRAPRESE - DES
            //public string glob_NCR_Att_Des_06;                 // ATTIVITÀ INTRAPRESE - DES
            //public string glob_NCR_Att_Des_07;                 // ATTIVITÀ INTRAPRESE - DES
            //public string glob_NCR_Att_Des_08;                 // ATTIVITÀ INTRAPRESE - DES
            //public string glob_NCR_Att_Des_09;                 // ATTIVITÀ INTRAPRESE - DES
            //public string glob_NCR_Att_Des_010;                // ATTIVITÀ INTRAPRESE - DES
            //public string glob_NCR_Att_Des_011;                // ATTIVITÀ INTRAPRESE - DES
            //public string glob_NCR_Att_Des_012;                // ATTIVITÀ INTRAPRESE - DES
            //public string glob_NCR_Att_Des_013;                // ATTIVITÀ INTRAPRESE - DES
            //public string glob_NCR_Att_Des_014;                // ATTIVITÀ INTRAPRESE - DES
            //public string glob_NCR_Att_Des_015;                // ATTIVITÀ INTRAPRESE - DES
        }

        private void ToScreen()
        {
            //cb_Originatore
            //tb_prodotto.Text = Ncr_Ident_Prodotto;
            //cb_Criticità.SelectedIndex =  Ncr_Ident_Level;
            //string progr = Ncr_Progr.ToString();
            //lab_Ncr_Progr.Text = progr.PadLeft(7, '0');
            //lab_Ncr_Ident_DateCreation.Text = Ncr_Ident_DateCreation.ToString("dd/MM/yyyy");
            //tb_Ncr_Ident_Descrizione.Text = Ncr_Ident_Descrizione;
            //tb_Ncr_Azioni_Pianificazione.Text = Ncr_Azioni_Pianificazione;

            //Pagina identificazione
            lab_glob_NCR_SegnalazioneNumero.Text = glob_NCR_SegnalazioneNumero_Page1.ToString().PadLeft(4, '0');
            //cb_Originatore.SelectedText = glob_NCR_Emissione;
            lab_glob_NCR_Data.Text = glob_NCR_Data_Page1.ToString("dd/MM/yyyy");
            lab_glob_NCR_Codice_Articolo.Text = glob_NCR_Codice_Articolo_Page1;
            lab_glob_NCR_Des_Articolo.Text = glob_NCR_Des_Articolo;
            lab_glob_NCR_RagSoc_CliFor.Text = glob_NCR_RagSoc_CliFor;
            cb_Criticità.SelectedIndex = glob_NCR_Level;
            cb_provenienza.SelectedIndex = glob_NCR_Provenienza;
            lab_glob_NCR_Provenienza_Altro.Text = glob_NCR_Provenienza_Altro;
            cb_problema.SelectedIndex = glob_NCR_Problema;
            lab_glob_NCR_Problema_Des.Text = glob_NCR_Problema_Des;
        }

        private int convInt(object daconvertire)
        {
            int conv = 0;
            if (daconvertire != DBNull.Value) { conv = Convert.ToInt32(daconvertire); }
            return conv;
        }

        private string convStr(object daconvertire)
        {
            string conv = "";
            if (daconvertire != DBNull.Value) { conv = Convert.ToString(daconvertire); }
            return conv;
        }

        private DateTime convDate(object daconvertire)
        {
            DateTime conv = default(DateTime);
            if (daconvertire != DBNull.Value) { conv = Convert.ToDateTime(daconvertire); }
            return conv;
        }

        private bool convBool(object daconvertire)
        {
            bool conv = false;
            if (daconvertire != DBNull.Value) { conv = Convert.ToBoolean(daconvertire); }
            return conv;
        }

        private void CreaPdf()
        {
            NCR_PDF.CloseDocument();

            AggiornaVariabili();

            //Creazione del pdf interattivo
            PdfDocument doc = new PdfDocument();
            //Load from file
            doc.LoadFromFile(pathForPdf);

            //Get the PDF field collection on the Form.
            PdfFormWidget widget = doc.Form as PdfFormWidget;

            //Traverse each PDF field in pdf field collection.
            for (int i = 0; i < widget.FieldsWidget.List.Count; i++)
            {
                PdfField f = widget.FieldsWidget.List[i] as PdfField;

                //Find a PDF field named username and set the value for it.
                PdfTextBoxFieldWidget textboxField = f as PdfTextBoxFieldWidget;
                switch (f.Name)
                {
                    case "gen_NumeroNcr_Page1":
                        textboxField.Text = glob_NCR_SegnalazioneNumero_Page1.ToString() + "/" + glob_NCR_Data_Page1.ToString("yy");
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "gen_DataNcr_Page1":
                        textboxField.Text = glob_NCR_Data_Page1.ToString("dd/MM/yyyy");
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "gen_OrigineNcr_Page1":
                        if (cb_provenienza.Text != "Altro") { textboxField.Text = cb_provenienza.Text.ToString(); } else { textboxField.Text = "Altro - " + glob_NCR_Provenienza_Altro.ToString(); }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "gen_ArticoloNcr_Page1":
                        textboxField.Text = glob_NCR_Codice_Articolo_Page1;
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "gen_CliForNcr":
                        string CF = string.Empty;
                        if (glob_NCR_CliFor == "C") { CF = "C"; } else { CF = "F"; }
                        CF = CF + " - " + glob_NCR_RagSoc_CliFor.ToString();
                        textboxField.Text = CF;
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "gen_DescrizioneNcr":
                        textboxField.Text = glob_NCR_Problema_Des.ToString();
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "gen_CriticitaNcr":
                        textboxField.Text = cb_Criticità.Text.ToString();
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "gen_RilevatoDa":
                        textboxField.Text = glob_NCR_Emissione_Des.ToString();
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "gen_RespSoluzione":
                        textboxField.Text = glob_NCR_RespSoluzione_Des.ToString();
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "gen_GruppoLavoro":
                        textboxField.Text = AssemblaStringaWorkGroup();
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "gen_RespAnalisi":
                        textboxField.Text = glob_NCR_Destinatario_Des.ToString();
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;









                    case "NCR_Maggiore_Page1":
                        if (glob_NCR_Level == 0) { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Minore_Page1":
                        if (glob_NCR_Level == 1) { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Osservazione_Page1":
                        if (glob_NCR_Level == 2) { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Articolo_Page1":
                        textboxField.Text = glob_NCR_Codice_Articolo_Page1;
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;

                    case "NCR_Provenienza_01":
                        if (glob_NCR_Provenienza == 0) { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Provenienza_02":
                        if (glob_NCR_Provenienza == 1) { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Provenienza_03":
                        if (glob_NCR_Provenienza == 2) { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Provenienza_04":
                        if (glob_NCR_Provenienza == 3) { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Provenienza_05":
                        if (glob_NCR_Provenienza == 4) { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Provenienza_06":
                        if (glob_NCR_Provenienza == 5) { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Provenienza_07":
                        if (glob_NCR_Provenienza == 6) { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Provenienza_08":
                        if (glob_NCR_Provenienza == 7) { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Provenienza_Altro":
                        textboxField.Text = glob_NCR_Provenienza_Altro.ToString();
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Problema_01":
                        if (glob_NCR_Problema == 0) { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Problema_02":
                        if (glob_NCR_Problema == 1) { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Riferimento":
                        textboxField.Text = glob_NCR_RespSoluzione_Des.ToString();
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Emissione":
                        textboxField.Text = glob_NCR_Emissione_Des.ToString();
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Destinatario":
                        textboxField.Text = glob_NCR_Destinatario_Des.ToString();
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;


                    //------------------------------------------------------------------------------------//
                    case "NCR_SegnalazioneNumero_Page2":
                        textboxField.Text = glob_NCR_SegnalazioneNumero_Page2.ToString() + "/" + glob_NCR_Data_Page2.ToString("yy");
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Maggiore_Page2":
                        if (glob_NCR_Level == 0) { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Minore_Page2":
                        if (glob_NCR_Level == 1) { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Osservazione_Page2":
                        if (glob_NCR_Level == 2) { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Data_Page2":
                        textboxField.Text = glob_NCR_Data_Page2.ToString("dd/MM/yyyy");
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_Articolo_Page2":
                        textboxField.Text = glob_NCR_Codice_Articolo_Page2;
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_CliFor_C_Page2":
                        if (glob_NCR_CliFor == "C") { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_CliFor_F_Page2":
                        if (glob_NCR_CliFor == "F") { textboxField.Text = "X"; } else { textboxField.Text = string.Empty; }
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                    case "NCR_CliFor_Page2":
                        textboxField.Text = glob_NCR_RagSoc_CliFor.ToString();
                        f.Flatten = true;
                        f.ReadOnly = true;
                        break;
                }
            }

            //Save
            FileDef = PathDef + "NCR_" + glob_NCR_SegnalazioneNumero_Page1.ToString().PadLeft(4, '0') + ".pdf";
            doc.SaveToFile(FileDef);
            NCR_PDF.LoadDocument(FileDef);
        }

        private void AggiornaVariabili()
        {
            //Ncr_Ident_Originatore_Nome = cb_Originatore.Text;
            //Ncr_Ident_Level_Name = cb_Criticità.Text;
            //Ncr_Progr_Nome = lab_Ncr_Progr.Text;
            //Ncr_Ident_DateCreation_Nome = lab_Ncr_Ident_DateCreation.Text;
            //Ncr_Azioni_Responsabile_Nome = cb_Responsabile.Text;

        }

        private void gv_ncr_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) { return; }

            if ((gv_ncr.Columns[e.ColumnIndex].Name == "NCR_Phase_Indicator") && (e.Value != null))
            {
                DataGridViewCell cell = this.gv_ncr.Rows[e.RowIndex].Cells[e.ColumnIndex];

                switch (cell.Value)
                {
                    case 1:
                        //cell.Value = Properties.Resources.Indicatore__1;
                        break;
                    case 2:
                        //cell.Value = Properties.Resources.Indicatore__2;
                        break;
                    case 3:
                        //cell.Value = Properties.Resources.Indicatore__3;
                        break;
                }
            }
        }

        private void PulisciVar()
        {
            glob_NCR_SegnalazioneNumero_Page1 = 0;         // NUMERO SEGNALAZIONE
            glob_NCR_Level = 0;
            //glob_NCR_Maggiore_Page1 = false;             // NON CONFORMITÀ MAGGIORE
            //glob_NCR_Minore_Page1 = false;               // NON CONFORMITÀ MINORE
            //glob_NCR_Osservazione_Page1 = false;         // OSSERVAZIONE
            glob_NCR_Data_Page1 = DateTime.MinValue;       // DATA INSERIMENTO
            glob_NCR_Codice_Articolo_Page1 = string.Empty; // DESCRIZIONE ARTICOLO
            glob_NCR_Des_Articolo = string.Empty;          // DESCRIZIONE ARTICOLO
            glob_NCR_CliFor = string.Empty;                // CLIENTE o FORNITORE RAGIONE SOCIALE
            glob_NCR_RagSoc_CliFor = string.Empty;         // Ragione Sociale C/F
            glob_NCR_Provenienza = 0;                      // Provenienza
            glob_NCR_Provenienza_Altro = string.Empty;     // ALTRO - DESCRIZIONE
            glob_NCR_Problema = 0;                         // RISCONTRATO
            glob_NCR_Problema_Des = string.Empty;          // PROBLEMA - DESCRIZIONE
            glob_NCR_Emissione = 0;                        // Emesso da:
            glob_NCR_Destinatario = 0;                     // Destinatario:
            glob_NCR_RespSoluzione = 0;
            //glob_NCR_Emissione_Des = string.Empty;
            //glob_NCR_Responsabile_Des = string.Empty;
            glob_NCR_Destinatario_Des = string.Empty;

            glob_NCR_Causa_01 = false;                     // causa - RISCONTRATA
            glob_NCR_Causa_02 = false;                     // causa - POTENZIALE
            glob_NCR_Causa_03 = false;                     // causa - RGQ
            glob_NCR_Causa_04 = false;                     // causa - R. Area
            glob_NCR_Causa_Des = string.Empty;             // CAUSA - DESCRIZIONE
            glob_NCR_Azione_01 = false;                    // AZIONE - (EVENTUALE) AZIONE IMMEDIATA
            glob_NCR_Azione_02 = false;                    // AZIONE - AZIONE CORRETTIVA
            glob_NCR_Azione_03 = false;                    // AZIONE - AZIONE AZIONE PREVENTIVA
            glob_NCR_Azione_04 = false;                    // AZIONE - (EVENTUALE) AZIONE IMMEDIATA - RGQ
            glob_NCR_Azione_05 = false;                    // AZIONE - (EVENTUALE) AZIONE IMMEDIATA - R. Area
            glob_NCR_Azione_06 = false;                    // AZIONE - AZIONE CORRETTIVA - RGQ
            glob_NCR_Azione_07 = false;                    // AZIONE - AZIONE CORRETTIVA - R. Area
            glob_NCR_Azione_Des_01 = string.Empty;         // AZIONE - (EVENTUALE) AZIONE IMMEDIATA - DES
            glob_NCR_Azione_Des_02 = string.Empty;         // AZIONE - CORRETTIVA/PREVENTIVA - DES
            glob_NCR_Pianificazione_01 = string.Empty;     // Tempi programmati per l’ATTUAZIONE dell’azione intrapresa
            glob_NCR_Pianificazione_02 = string.Empty;     // Tempi programmati per la VERIFICA DELL’EFFICACIA dell’azione intrapresa
            glob_NCR_VerificaAttuazione_01 = false;        // VERIFICHE INTRAPRESE - ATTUAZIONE - RGQ
            glob_NCR_VerificaAttuazione_02 = false;        // VERIFICHE INTRAPRESE - ATTUAZIONE - R. Area
            glob_NCR_VerificaAttuazione_Des = string.Empty;// VERIFICHE INTRAPRESE - ATTUAZIONE - DES
            glob_NCR_VerificaEfficacia_01 = false;         // VERIFICHE INTRAPRESE - EFFICACIA - RGQ
            glob_NCR_VerificaEfficacia_02 = false;         // VERIFICHE INTRAPRESE - EFFICACIA - R. Area
            glob_NCR_VerificaEfficacia_Des = string.Empty; // VERIFICHE INTRAPRESE - EFFICACIA - DES
            glob_NCR_GiudRisolutiva = false;               // GIUDIZIO FINALE - RISOLUTIVA
            glob_NCR_GiudBuona = false;                    // GIUDIZIO FINALE - BUONA
            glob_NCR_GiudScarsa = false;                   // GIUDIZIO FINALE - SCARSA
            glob_NCR_GiudInsuff = false;                   // GIUDIZIO FINALE - INSUFF

            glob_NCR_SegnalazioneNumero_Page2 = 0;         // NUMERO SEGNALAZIONE
            glob_NCR_Data_Page2 = DateTime.MinValue;       // DATA INSERIMENTO
            glob_NCR_Codice_Articolo_Page2 = string.Empty; // DESCRIZIONE ARTICOLO

            glob_NCR_Att_Data_01 = DateTime.MinValue;      // ATTIVITÀ INTRAPRESE - DATA
            glob_NCR_Att_Data_02 = DateTime.MinValue;      // ATTIVITÀ INTRAPRESE - DATA
            glob_NCR_Att_Data_03 = DateTime.MinValue;      // ATTIVITÀ INTRAPRESE - DATA
            glob_NCR_Att_Data_04 = DateTime.MinValue;      // ATTIVITÀ INTRAPRESE - DATA
            glob_NCR_Att_Data_05 = DateTime.MinValue;      // ATTIVITÀ INTRAPRESE - DATA
            glob_NCR_Att_Data_06 = DateTime.MinValue;      // ATTIVITÀ INTRAPRESE - DATA
            glob_NCR_Att_Data_07 = DateTime.MinValue;      // ATTIVITÀ INTRAPRESE - DATA
            glob_NCR_Att_Data_08 = DateTime.MinValue;      // ATTIVITÀ INTRAPRESE - DATA
            glob_NCR_Att_Data_09 = DateTime.MinValue;      // ATTIVITÀ INTRAPRESE - DATA
            glob_NCR_Att_Data_010 = DateTime.MinValue;     // ATTIVITÀ INTRAPRESE - DATA
            glob_NCR_Att_Data_011 = DateTime.MinValue;     // ATTIVITÀ INTRAPRESE - DATA
            glob_NCR_Att_Data_012 = DateTime.MinValue;     // ATTIVITÀ INTRAPRESE - DATA
            glob_NCR_Att_Data_013 = DateTime.MinValue;     // ATTIVITÀ INTRAPRESE - DATA
            glob_NCR_Att_Data_014 = DateTime.MinValue;     // ATTIVITÀ INTRAPRESE - DATA
            glob_NCR_Att_Data_015 = DateTime.MinValue;     // ATTIVITÀ INTRAPRESE - DATA
            glob_NCR_Att_Des_01 = string.Empty;            // ATTIVITÀ INTRAPRESE - DES
            glob_NCR_Att_Des_02 = string.Empty;            // ATTIVITÀ INTRAPRESE - DES
            glob_NCR_Att_Des_03 = string.Empty;            // ATTIVITÀ INTRAPRESE - DES
            glob_NCR_Att_Des_04 = string.Empty;            // ATTIVITÀ INTRAPRESE - DES
            glob_NCR_Att_Des_05 = string.Empty;            // ATTIVITÀ INTRAPRESE - DES
            glob_NCR_Att_Des_06 = string.Empty;            // ATTIVITÀ INTRAPRESE - DES
            glob_NCR_Att_Des_07 = string.Empty;            // ATTIVITÀ INTRAPRESE - DES
            glob_NCR_Att_Des_08 = string.Empty;            // ATTIVITÀ INTRAPRESE - DES
            glob_NCR_Att_Des_09 = string.Empty;            // ATTIVITÀ INTRAPRESE - DES
            glob_NCR_Att_Des_010 = string.Empty;           // ATTIVITÀ INTRAPRESE - DES
            glob_NCR_Att_Des_011 = string.Empty;           // ATTIVITÀ INTRAPRESE - DES
            glob_NCR_Att_Des_012 = string.Empty;           // ATTIVITÀ INTRAPRESE - DES
            glob_NCR_Att_Des_013 = string.Empty;           // ATTIVITÀ INTRAPRESE - DES
            glob_NCR_Att_Des_014 = string.Empty;           // ATTIVITÀ INTRAPRESE - DES
            glob_NCR_Att_Des_015 = string.Empty;           // ATTIVITÀ INTRAPRESE - DES
        }

        private void but_ric_CF_Click(object sender, EventArgs e)
        {
            using (var form = new UC_NCR_Search_Clienti())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DataRowView findrowview = this.ncrBindingSource.Current as DataRowView;
                    DataRow findrow = (DataRow)findrowview.Row;

                    DataRow editrow = ds_Ncr.Ncr.Rows.Find(findrow["NCR_Id"]);
                    editrow.BeginEdit();

                    editrow["Ncr_Clifor"] = form.PassCF;
                    editrow["Ncr_Mastro"] = form.PassMastro;
                    editrow["Ncr_Conto"] = form.PassConto;
                    editrow["Ncr_SottoConto"] = form.PassSottoconto;
                    editrow.EndEdit();
                }
            }
        }

        private void but_ric_Articolo_Click(object sender, EventArgs e)
        {
            using (var form = new UC_NCR_Search_Articoli())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DataRowView findrowview = this.ncrBindingSource.Current as DataRowView;
                    DataRow findrow = (DataRow)findrowview.Row;

                    DataRow editrow = ds_Ncr.Ncr.Rows.Find(findrow["NCR_Id"]);
                    editrow.BeginEdit();

                    editrow["Ncr_CodArticolo"] = form.PassCodiceArticolo;
                    editrow.EndEdit();
                }
            }

        }

        private void ncrSFNcrCliForBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {
            DataRowView linked_clifor = (DataRowView)ncrSFNcrCliForBindingSource.Current;
            if (linked_clifor != null)
            {
                string cf = linked_clifor["CliFor"].ToString();

                if (cf == "C")
                {
                    pic_CF.Image = global::SmartLineProduction.Properties.Resources.IconaCF_C;
                    pic_CF.Refresh();
                }

                if (cf == "F")
                {
                    pic_CF.Image = global::SmartLineProduction.Properties.Resources.IconaCF_F;
                    pic_CF.Refresh();
                }

                glob_NCR_RagSoc_CliFor = linked_clifor["RAGIONESOCIALE"].ToString();
            }
            else
            {
                glob_NCR_RagSoc_CliFor = string.Empty;
            }

            ToScreen();
        }

        private void layout_Identificazione_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Row == 4) || (e.Row == 5) || (e.Row == 6) || (e.Row == 7))
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.LightCyan), e.CellBounds);
            }
        }

        private void cb_provenienza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_provenienza.SelectedIndex != 7)
            {
                glob_NCR_Provenienza_Altro = string.Empty;
                lab_glob_NCR_Provenienza_Altro.Visible = false;
            }
            else
            {
                lab_glob_NCR_Provenienza_Altro.Visible = true;
            }
        }

        private void cb_Originatore_Leave(object sender, EventArgs e)
        {
            glob_NCR_Emissione = Convert.ToInt32(cb_Originatore.EditValue);
            glob_NCR_Emissione_Des = cb_Originatore.Text;
        }

        private void cb_Responsabile_Leave(object sender, EventArgs e)
        {
            glob_NCR_RespSoluzione = Convert.ToInt32(cb_RespSoluzione.EditValue);
            glob_NCR_RespSoluzione_Des = cb_RespSoluzione.Text;
        }

        private void cb_destinatario_Leave(object sender, EventArgs e)
        {
            glob_NCR_Destinatario = Convert.ToInt32(cb_destinatariorespanalisi.EditValue);
            glob_NCR_Destinatario_Des = cb_destinatariorespanalisi.Text;
        }

        private void lab_glob_NCR_Provenienza_Altro_Leave(object sender, EventArgs e)
        {
            glob_NCR_Provenienza_Altro = lab_glob_NCR_Provenienza_Altro.Text;
        }

        private void LoadNcrUserGroups(int NCR_Id)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Ncr.SF_NCRUsersGroups'. È possibile spostarla o rimuoverla se necessario.
            this.sF_NCRUsersGroupsTableAdapter.Fill(this.ds_Ncr.SF_NCRUsersGroups);

            // TODO: questa riga di codice carica i dati nella tabella 'ds_Ncr.Users_Ncr_Groups'. È possibile spostarla o rimuoverla se necessario.
            this.users_Ncr_GroupsTableAdapter.Fill(this.ds_Ncr.Users_Ncr_Groups);


            //filtro su vista
            string filtro = "Ncr_Id = " + "'" + NCR_Id.ToString() + "'";
            sFNCRUsersGroupsBindingSource.Filter = filtro;

            foreach (DataRow rowAllUser in this.ds_Ncr.SF_NCRUsersGroups)
            {
                bool exists = false;


                //filtro su tabella
                filtro = "Ncr_Id = " + "'" + NCR_Id.ToString() + "'" + " AND User_Id = " + "'" + rowAllUser["User_Id"].ToString() + "'";
                usersNcrGroupsBindingSource.Filter = filtro;


                //return;

                //Verifico se già presente in tabella associazione
                if (usersNcrGroupsBindingSource.Count > 0)
                {
                    exists = true;
                }

                if (exists) 
                {
                    rowAllUser["RecordExist"] = true;
                }

            }

            //cb_WorkGroup.DataSource = this.usersNcrGroupsBindingSource;
            cb_WorkGroup.Refresh();
        }

        private string AssemblaStringaWorkGroup()
        {
            string WorkGroup = string.Empty;

            //filtro su vista
            string filtro = "Ncr_Id = " + "'" + NCR_Id.ToString() + "'";
            this.ds_Ncr.SF_NCRUsersGroups.DefaultView.RowFilter = filtro;
            this.ds_Ncr.SF_NCRUsersGroups.DefaultView.Sort = "COGNOME asc";

            foreach (DataRowView rowAllUser in this.ds_Ncr.SF_NCRUsersGroups.DefaultView)
            {
                bool check = Convert.ToBoolean(rowAllUser["RecordExist"]);
                if (check)
                {
                    if (WorkGroup != string.Empty)
                    {
                        WorkGroup = WorkGroup + " / ";
                    }
                    
                    WorkGroup = WorkGroup + rowAllUser["COGNOME"].ToString();
                }
            }


            return WorkGroup;
        }
    }
}
