using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Net.NetworkInformation; //Include this

namespace SmartLineProduction
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void tile_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_MdiChildActivate(object sender, EventArgs e)
        {
            Form f = this.ActiveMdiChild;

            if (f == null)
            {
                //the last child form was just closed
                layout_Menu.Visible = true;
                Brother_timer.Enabled = true;
            }
            else
            {
                layout_Menu.Visible = false;
                Brother_timer.Enabled = false;
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Icon = global::SmartLineProduction.Properties.Resources.logo_new_32;

            lab_resources_path.Text = Properties.Settings.Default.Doc_folder;

            ShowPrinterStatus();
        }

        private void pan_Menu_exit_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Application.Exit();
        }

        private void spedizioneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_AssegnaSNProduzione uC_AssegnaSNProduzione = new UC_AssegnaSNProduzione();
            SplashDB.Close();
            uC_AssegnaSNProduzione.MdiParent = this;
            uC_AssegnaSNProduzione.Dock = DockStyle.Fill;
            Cursor.Current = Cursors.Default;
            uC_AssegnaSNProduzione.Show();
        }

        private void fasiDiAvanzamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Avanzamento uC_Avanzamento = new UC_Avanzamento();
            SplashDB.Close();
            uC_Avanzamento.MdiParent = this;
            uC_Avanzamento.Dock = DockStyle.Fill;
            uC_Avanzamento.Show();
        }

        private void prodottiAttivatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void schedeProdottiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void codificaKitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_CodificaKit uC_CodificaKit = new UC_CodificaKit();
            SplashDB.Close();
            uC_CodificaKit.MdiParent = this;
            uC_CodificaKit.Dock = DockStyle.Fill;
            uC_CodificaKit.Show();

        }

        private void fWPalmariToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_FW_P uC_FW_P = new UC_FW_P();
            SplashDB.Close();
            uC_FW_P.MdiParent = this;
            uC_FW_P.Dock = DockStyle.Fill;
            uC_FW_P.Show();
        }

        private void fWRicevitoriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_FW_R uC_FW_R = new UC_FW_R();
            SplashDB.Close();
            uC_FW_R.MdiParent = this;
            uC_FW_R.Dock = DockStyle.Fill;
            uC_FW_R.Show();
        }

        private void verificaFattibilitàToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void raccoltaDatasheetPerCommessaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Pack_Commessa uC_Pack_Commessa = new UC_Pack_Commessa();
            SplashDB.Close();
            uC_Pack_Commessa.MdiParent = this;
            uC_Pack_Commessa.Dock = DockStyle.Fill;
            uC_Pack_Commessa.Show();
        }

        private void programmazioneSchedeSmartLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Programmazione_Commessa uC_Programmazione_Commessa = new UC_Programmazione_Commessa();
            SplashDB.Close();
            uC_Programmazione_Commessa.MdiParent = this;
            uC_Programmazione_Commessa.Dock = DockStyle.Fill;
            uC_Programmazione_Commessa.Show();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {

        }

        private void classificazioneDocumentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Quality uC_Quality = new UC_Quality();
            SplashDB.Close();
            uC_Quality.MdiParent = this;
            uC_Quality.Dock = DockStyle.Fill;
            uC_Quality.Show();
        }

        private void interrogazioneDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Identifica uC_Identifica = new UC_Identifica();
            SplashDB.Close();
            uC_Identifica.MdiParent = this;
            uC_Identifica.Dock = DockStyle.Fill;
            uC_Identifica.Show();

        }

        private void ssswsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            Form1 form1 = new Form1();
            SplashDB.Close();
            form1.MdiParent = this;
            form1.Dock = DockStyle.Fill;
            form1.Show();
        }

        private void storiaNumeriDiSerieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Identifica uC_Identifica = new UC_Identifica();
            SplashDB.Close();
            uC_Identifica.MdiParent = this;
            uC_Identifica.Dock = DockStyle.Fill;
            uC_Identifica.Show();
        }

        private void prodottiAttivatiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_ReportProdotti uC_ReportProdotti = new UC_ReportProdotti();
            SplashDB.Close();
            uC_ReportProdotti.MdiParent = this;
            uC_ReportProdotti.Dock = DockStyle.Fill;
            uC_ReportProdotti.Show();
        }

        private void schedeProdottiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Schede uC_Schede = new UC_Schede();
            SplashDB.Close();
            uC_Schede.MdiParent = this;
            uC_Schede.Dock = DockStyle.Fill;
            uC_Schede.Show();
        }

        private void analisiDisponibilitàDiMagazzinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Fattibilita uC_Fattibilita = new UC_Fattibilita();
            SplashDB.Close();
            uC_Fattibilita.MdiParent = this;
            uC_Fattibilita.Dock = DockStyle.Fill;
            uC_Fattibilita.Show();
        }

        private void configuratoreUsciteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_ConfigurazioneOutput uC_ConfigurazioneOutput = new UC_ConfigurazioneOutput();
            SplashDB.Close();
            uC_ConfigurazioneOutput.MdiParent = this;
            uC_ConfigurazioneOutput.Dock = DockStyle.Fill;
            uC_ConfigurazioneOutput.Show();
        }

        private void analisiCostiDelVendutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;

#if (DEBUG)
            {
                Splash SplashDB = new Splash();
                SplashDB.Show();

                UC_Amm_AnalisiCosti uC_Amm_AnalisiCosti = new UC_Amm_AnalisiCosti();
                SplashDB.Close();
                uC_Amm_AnalisiCosti.MdiParent = this;
                uC_Amm_AnalisiCosti.Dock = DockStyle.Fill;
                uC_Amm_AnalisiCosti.Show();
            }
#else
            UC_Password uC_Password = new UC_Password();
            if (uC_Password.ShowDialog() == DialogResult.Cancel)
                return;
            //if (pf.password == Properties.Settings.Default.pass)
            if (uC_Password.password == "Mattia12")
            {
                Splash SplashDB = new Splash();
                SplashDB.Show();

                UC_Amm_AnalisiCosti uC_Amm_AnalisiCosti = new UC_Amm_AnalisiCosti();
                SplashDB.Close();
                uC_Amm_AnalisiCosti.MdiParent = this;
                uC_Amm_AnalisiCosti.Dock = DockStyle.Fill;
                uC_Amm_AnalisiCosti.Show();
            }
#endif
        }

        private void lavorazioneProgettiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Projects uC_Projects = new UC_Projects();
            SplashDB.Close();
            uC_Projects.MdiParent = this;
            uC_Projects.Dock = DockStyle.Fill;
            uC_Projects.Show();
        }

        private void individuazioneEtichetteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_IndividuaLabel uC_IndividuaLabel = new UC_IndividuaLabel();
            SplashDB.Close();
            uC_IndividuaLabel.MdiParent = this;
            uC_IndividuaLabel.Dock = DockStyle.Fill;
            uC_IndividuaLabel.Show();
            this.ActiveControl = uC_IndividuaLabel;
        }

        private void oldVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Spedizione uC_Spedizione = new UC_Spedizione();
            SplashDB.Close();
            uC_Spedizione.MdiParent = this;
            uC_Spedizione.Dock = DockStyle.Fill;
            Cursor.Current = Cursors.Default;
            uC_Spedizione.Show();
        }

        private void nuovaVersioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void programmaDaCommessaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Programmazione_Commessa uC_Programmazione_Commessa = new UC_Programmazione_Commessa();
            SplashDB.Close();
            uC_Programmazione_Commessa.MdiParent = this;
            uC_Programmazione_Commessa.Dock = DockStyle.Fill;
            uC_Programmazione_Commessa.Show();
        }

        private void riprogrammazionePlugClonazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Programmazione_Clona uC_Programmazione_Clona = new UC_Programmazione_Clona();
            SplashDB.Close();
            uC_Programmazione_Clona.MdiParent = this;
            uC_Programmazione_Clona.Dock = DockStyle.Fill;
            uC_Programmazione_Clona.Show();
        }

        private void tracciaiblitàDeiNumeriDiSerieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Identifica uC_Identifica = new UC_Identifica();
            SplashDB.Close();
            uC_Identifica.MdiParent = this;
            uC_Identifica.Dock = DockStyle.Fill;
            uC_Identifica.Show();
        }

        private void tracciaturaProdottiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_SL_History uC_SL_History = new UC_SL_History();
            SplashDB.Close();
            uC_SL_History.MdiParent = this;
            uC_SL_History.Dock = DockStyle.Fill;
            uC_SL_History.Show();
        }

        private void bouquetFirmwarePerClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;

#if (DEBUG)
            {
                Splash SplashDB = new Splash();
                SplashDB.Show();

                UC_SL_FirmwareClienti uC_SL_FirmwareClienti = new UC_SL_FirmwareClienti();
                SplashDB.Close();
                uC_SL_FirmwareClienti.MdiParent = this;
                uC_SL_FirmwareClienti.Dock = DockStyle.Fill;
                uC_SL_FirmwareClienti.Show();
            }
#else
            UC_Password uC_Password = new UC_Password();
            if (uC_Password.ShowDialog() == DialogResult.Cancel)
                return;
            //if (pf.password == Properties.Settings.Default.pass)
            if (uC_Password.password == "MatriX")
            {
                Splash SplashDB = new Splash();
                SplashDB.Show();

                UC_SL_FirmwareClienti uC_SL_FirmwareClienti = new UC_SL_FirmwareClienti();
                SplashDB.Close();
                uC_SL_FirmwareClienti.MdiParent = this;
                uC_SL_FirmwareClienti.Dock = DockStyle.Fill;
                uC_SL_FirmwareClienti.Show();
            }
#endif
        }

        private void visioneSchedeDiLavorazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_SchedeLavorazione uC_SchedeLavorazione = new UC_SchedeLavorazione();
            SplashDB.Close();
            uC_SchedeLavorazione.MdiParent = this;
            uC_SchedeLavorazione.Dock = DockStyle.Fill;
            uC_SchedeLavorazione.Show();
        }

        private void programmazionePerProgettazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Programmazione_Progettazione uC_Programmazione_Progettazione = new UC_Programmazione_Progettazione();
            SplashDB.Close();
            uC_Programmazione_Progettazione.MdiParent = this;
            uC_Programmazione_Progettazione.Dock = DockStyle.Fill;
            uC_Programmazione_Progettazione.Show();
        }

        private void visioneDatasheetClassicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_ClassicDS uC_ClassicDS = new UC_ClassicDS();
            SplashDB.Close();
            uC_ClassicDS.MdiParent = this;
            uC_ClassicDS.Dock = DockStyle.Fill;
            uC_ClassicDS.Show();
        }

        private void datasheetClassicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_ClassicDS uC_ClassicDS = new UC_ClassicDS();
            SplashDB.Close();
            uC_ClassicDS.MdiParent = this;
            uC_ClassicDS.Dock = DockStyle.Fill;
            uC_ClassicDS.Show();
        }

        //private void aaaaaaaaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    GVar.CloseSplash = false;
        //    Splash SplashDB = new Splash();
        //    SplashDB.Show();

        //    Prova prova = new Prova();
        //    SplashDB.Close();
        //    prova.MdiParent = this;
        //    prova.Dock = DockStyle.Fill;
        //    prova.Show();
        //}

        private void messaggiRealTimeAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_RealTime uC_RealTime = new UC_RealTime();
            SplashDB.Close();
            uC_RealTime.MdiParent = this;
            uC_RealTime.Dock = DockStyle.Fill;
            uC_RealTime.Show();
        }

        private void eventiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Eventi uC_Eventi = new UC_Eventi();
            SplashDB.Close();
            uC_Eventi.MdiParent = this;
            uC_Eventi.Dock = DockStyle.Fill;
            uC_Eventi.Show();

        }

        private void verificaSensoriRFìdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_VerificaNFC uC_VerificaNFC = new UC_VerificaNFC();
            SplashDB.Close();
            uC_VerificaNFC.MdiParent = this;
            uC_VerificaNFC.Dock = DockStyle.Fill;
            uC_VerificaNFC.Show();
        }

        private void Brother_timer_Tick(object sender, EventArgs e)
        {
            FindBrotherPrinters();
            ShowPrinterStatus();
        }

        private void FindBrotherPrinters()
        {
            //Interroga 192.168.0.221 - TJ-4120TN_SL
            //Eliminata l'interrogazione tramite openport in quanto crea processo di spool
            //int Result_ip_221 = BROLIB_DLL.openport(GVar.Brother_SL_addr);

            //Interroga IP tramite ping
            bool Result_ping_221 = false;
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send("192.168.0.221", 1000);
                if (reply.Status.ToString() == "Success") { Result_ping_221 = true; }
            }
            catch { }
            //if ((Result_ip_221 == 1) && (Result_ping_221))
            if (Result_ping_221)
            {
                pic_SL.Image = global::SmartLineProduction.Properties.Resources.Small_Icona_OK;
                pic_SL.Refresh();
            }
            else
            {
                pic_SL.Image = global::SmartLineProduction.Properties.Resources.Small_Icona_NotOK;
                pic_SL.Refresh();
            }

            //Interroga 192.168.0.222 - TJ-4120TN_Antiman
            //Eliminata l'interrogazione tramite openport in quanto crea processo di spool
            //int Result_ip_222 = BROLIB_DLL.openport(GVar.Brother_Antiman_addr);

            //Interroga IP tramite ping
            bool Result_ping_222 = false;
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send("192.168.0.222", 1000);
                if (reply.Status.ToString() == "Success") { Result_ping_222 = true; }
            }
            catch { }
            //if ((Result_ip_222 == 1) && (Result_ping_222))
            if (Result_ping_222)
            {
                pic_Antiman.Image = global::SmartLineProduction.Properties.Resources.Small_Icona_OK;
                pic_Antiman.Refresh();
            }
            else
            {
                pic_Antiman.Image = global::SmartLineProduction.Properties.Resources.Small_Icona_NotOK;
                pic_Antiman.Refresh();
            }

            //Interroga 192.168.0.222 - TJ-4120TN_Antiman
            //Eliminata l'interrogazione tramite openport in quanto crea processo di spool
            //int Result_ip_222 = BROLIB_DLL.openport(GVar.Brother_Antiman_addr);

            //Interroga IP tramite ping
            bool Result_ping_255 = false;
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send("192.168.0.255", 1000);
                if (reply.Status.ToString() == "Success") { Result_ping_255 = true; }
            }
            catch { }
            //if ((Result_ip_255 == 1) && (Result_ping_255))
            if (Result_ping_255)
            {
                pict_GL.Image = global::SmartLineProduction.Properties.Resources.Small_Icona_OK;
                pict_GL.Refresh();
            }
            else
            {
                pict_GL.Image = global::SmartLineProduction.Properties.Resources.Small_Icona_NotOK;
                pict_GL.Refresh();
            }

            //Lettura Configurazione in risorse
            if (GFunctions.LeggiConfig_GL())
            {
                Brother_GL_pos_x.Text = "x: " + GVar.Brother_GL_pos_x.ToString();
                Brother_GL_pos_y.Text = "y: " + GVar.Brother_GL_pos_y.ToString();
            }

            if (GFunctions.LeggiConfig_SL())
            {
                Brother_SL_pos_x.Text = "x: " + GVar.Brother_SL_pos_x.ToString();
                Brother_SL_pos_y.Text = "y: " + GVar.Brother_SL_pos_y.ToString();
            }

            if (GFunctions.LeggiConfig_Antiman())
            {
                Brother_Antiman_pos_x.Text = "x: " + GVar.Brother_Antiman_pos_x.ToString();
                Brother_Antiman_pos_y.Text = "y: " + GVar.Brother_Antiman_pos_y.ToString();
            }

            lab_Brother_Default.Text = GVar.Brother_default;
        }

        private void ShowPrinterStatus()
        {
            tog_Printers.Properties.OffText = GVar.Brother_SL_addr;
            tog_Printers.Properties.OnText = GVar.Brother_Antiman_addr;
            string def_printer = Properties.Settings.Default.Settings_Brother_Default;
            GVar.Brother_default = Properties.Settings.Default.Settings_Brother_Default;
            if (def_printer == GVar.Brother_SL_addr) { tog_Printers.IsOn = false; }
            if (def_printer == GVar.Brother_Antiman_addr) { tog_Printers.IsOn = true; }

            tog_Printers.Refresh();
        }

        private void tog_Printers_Toggled(object sender, EventArgs e)
        {
            if ((bool)tog_Printers.EditValue) { Properties.Settings.Default.Settings_Brother_Default = tog_Printers.Properties.OnText; }
            if (!(bool)tog_Printers.EditValue) { Properties.Settings.Default.Settings_Brother_Default = tog_Printers.Properties.OffText; }
            Properties.Settings.Default.Save();
        }

        private void fWPalmariClassicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_FW_P_Classic uC_FW_P_Classic = new UC_FW_P_Classic();
            SplashDB.Close();
            uC_FW_P_Classic.MdiParent = this;
            uC_FW_P_Classic.Dock = DockStyle.Fill;
            uC_FW_P_Classic.Show();
        }

        private void fWRicevitoriClassicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_FW_R_Classic uC_FW_R_Classic = new UC_FW_R_Classic();
            SplashDB.Close();
            uC_FW_R_Classic.MdiParent = this;
            uC_FW_R_Classic.Dock = DockStyle.Fill;
            uC_FW_R_Classic.Show();
        }

        private void queryFWOrdinatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Classic_XSWR_Query uC_Classic_XSWR_Query = new UC_Classic_XSWR_Query();
            SplashDB.Close();
            uC_Classic_XSWR_Query.MdiParent = this;
            uC_Classic_XSWR_Query.Dock = DockStyle.Fill;
            uC_Classic_XSWR_Query.Show();

        }

        private void newVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Quality_new_version uC_Quality_New_Version = new UC_Quality_new_version();
            SplashDB.Close();
            uC_Quality_New_Version.MdiParent = this;
            uC_Quality_New_Version.Dock = DockStyle.Fill;
            uC_Quality_New_Version.Show();

        }

        private void programmazioneCommessaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            UC_Programmazione_GL_Commessa uC_Programmazione_GL_Commessa = new UC_Programmazione_GL_Commessa();
            SplashDB.Close();
            uC_Programmazione_GL_Commessa.MdiParent = this;
            uC_Programmazione_GL_Commessa.Dock = DockStyle.Fill;
            uC_Programmazione_GL_Commessa.Show();
        }
    }
}
