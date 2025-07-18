﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.IO;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace SmartLineProduction
{
    public partial class UC_Programmazione_GL_Commessa : MetroFramework.Forms.MetroForm
    {
        public static string glob_FW_folder = "";

        public static string glob_Commander_path = "";
        public string glob_device = "--device EFR32BG24B220F1024IM48";  // Stringa Global Line
        //public string glob_device = "--device EFR32BG13P733F512GM48"; // Stringa SmartLine
        public bool glob_Program_OK = true;
        public string glob_codice_kit = "";
        public string glob_codice_sistema = "";
        public string glob_codice_fw = "";
        public string glob_codice_fw_fulltmppath = "";
        public string glob_ser_num_read = "";
        public string glob_ser_num_write = "";
        public string glob_ID_code = "";
        public string glob_ID_newcode = "";
        public string glob_UNIQUE_ID = "";
        public string glob_Form_ID = "";
        public string WEB_path_image = Properties.Settings.Default.Doc_folder;
        public string glob_tipo_progr = ""; //C-Commessa K-Kit D-Device L-Libera
        public string glob_ID_cli = "";
        public int glob_LockLevel = 0;

        public bool glob_Standard_FW = true;
        public bool glob_IsGolden = false;

        public bool glob_show_evasi = true;
        public int glob_selectedrecord = 0;
        public string UT_Crea_Unique_Official_Serial_Code = string.Empty;

        public string glob_tag_1 = string.Empty;
        public string glob_tag_2 = string.Empty;

        public UC_Programmazione_GL_Commessa()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        /// Funzioni personali
        ///////////////////////////////////////////////////////////////////////////////////////////////

        private void LeggiConfig()
        {
            // Lettura impostazioni
            glob_FW_folder = Properties.Settings.Default.FW_folder;
            //glob_Commander_path = Properties.Settings.Default.Commander_path_SL + "_GL";
            glob_Commander_path = Properties.Settings.Default.Commander_path_GL;
            if (!Directory.Exists(glob_Commander_path))
            {
                MessageBox.Show("Attenzione! Folder Commander: " + glob_Commander_path + " non trovato!");
            }
        }

        private void CaricaArchivi()
        {
            //ds_commander.dt_Tmp_Fw.Clear();
            ds_Programmazione_GL.dt_GL_Tmp_Programma.Clear();
            dg_dt_tmp_programmazione.Refresh();
            AbilitaSchermo();

            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            //-------------------------------------------------------------------------------//
            //    GLOBAL LINE
            //-------------------------------------------------------------------------------//

            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL.SF_Commesse_GL'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Commesse_GLTableAdapter.Fill(this.ds_Programmazione_GL.SF_Commesse_GL);

            //-------------------------------------------------------------------------------//
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL1.SF_GL_id2_Programmazione'. È possibile spostarla o rimuoverla se necessario.
            this.sF_GL_id2_ProgrammazioneTableAdapter.Fill(this.ds_Programmazione_GL.SF_GL_id2_Programmazione);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL.SF_GL_id1_Programmazione'. È possibile spostarla o rimuoverla se necessario.
            this.sF_GL_id1_ProgrammazioneTableAdapter.Fill(this.ds_Programmazione_GL.SF_GL_id1_Programmazione);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL.SF_LastSerialNumber_GL'. È possibile spostarla o rimuoverla se necessario.
            this.sF_LastSerialNumber_GLTableAdapter.Fill(this.ds_Programmazione_GL.SF_LastSerialNumber_GL);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL.SF_DistinteBasi_GL'. È possibile spostarla o rimuoverla se necessario.
            this.sF_DistinteBasi_GLTableAdapter.Fill(this.ds_Programmazione_GL.SF_DistinteBasi_GL);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL.GL_Firmware'. È possibile spostarla o rimuoverla se necessario.
            this.gL_FirmwareTableAdapter.Fill(this.ds_Programmazione_GL.GL_Firmware);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL.SF_Articoli_GL'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Articoli_GLTableAdapter.Fill(this.ds_Programmazione_GL.SF_Articoli_GL);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL.SF_ArticoliToXSWR_GL'. È possibile spostarla o rimuoverla se necessario.
            this.sF_ArticoliToXSWR_GLTableAdapter.Fill(this.ds_Programmazione_GL.SF_ArticoliToXSWR_GL);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL.GL_FW_Clienti'. È possibile spostarla o rimuoverla se necessario.
            this.gL_FW_ClientiTableAdapter.Fill(this.ds_Programmazione_GL.GL_FW_Clienti);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_commander1.SF_Commesse_SL'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Commesse_GLTableAdapter.Fill(this.ds_Programmazione_GL.SF_Commesse_GL);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL.SafetyPointRFID_GL'. È possibile spostarla o rimuoverla se necessario.
            this.safetyPointRFID_GLTableAdapter.Fill(this.ds_Programmazione_GL.SafetyPointRFID_GL);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL.GL_SerialNumbers'. È possibile spostarla o rimuoverla se necessario.
            this.gL_SerialNumbersTableAdapter.Fill(this.ds_Programmazione_GL.GL_SerialNumbers);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL.GL_Firmware_PG'. È possibile spostarla o rimuoverla se necessario.
            this.gL_Firmware_PGTableAdapter.Fill(this.ds_Programmazione_GL.GL_Firmware_PG);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL.GL_PG_Config_Hex'. È possibile spostarla o rimuoverla se necessario.
            this.gL_PG_Config_HexTableAdapter.Fill(this.ds_Programmazione_GL.GL_PG_Config_Hex);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL1.SF_GL_Can_Active'. È possibile spostarla o rimuoverla se necessario.
            this.sF_GL_Can_ActiveTableAdapter.Fill(this.ds_Programmazione_GL1.SF_GL_Can_Active);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL.SF_GL_ID_Unlock'. È possibile spostarla o rimuoverla se necessario.
            this.sF_GL_ID_UnlockTableAdapter.Fill(this.ds_Programmazione_GL.SF_GL_ID_Unlock);

            SplashDB.Close();
        }

        private void AbilitaSchermo()
        {
            lab_IDNumber_read.Text = "---";
            lab_IDNumber_write.Text = "---";
            lab_PartNumber.Text = "---";
            lab_SN.Text = "---";

            //ds_commander.dt_Tmp_Fw.Clear();
            dg_dt_tmp_programmazione.Refresh();

            LeggiConfig();

            //Verifica pagina attiva
            menu_commesse_nas.Checked = false;
            menu_commesse_vis.Checked = true;
            grid_commesse.Refresh();
        }

        private void AggiornaFwCliente(string CodAnaCli, string Fw)
        {
            // Verifica se nuovo SN o già esistente
            bool newrecord = false;
            //string sel = "Cod_Nominativo = " + "'" + CodAnaCli + "' AND SW_Code = '" + Fw + "'";
            string sel = "Cod_Nominativo = " + CodAnaCli + " AND SW_Code = '" + Fw + "'";
            DataRow[] result = ds_Programmazione_GL.GL_FW_Clienti.Select(sel);
            if (result.Length > 0)
            { newrecord = false; }
            else
            { newrecord = true; }

            if (newrecord)
            {
                string des_ita = "";
                string des_en = "";
                DataView dv_fw = new DataView(ds_Programmazione_GL.GL_Firmware);
                dv_fw.RowFilter = "SW_Code = " + "'" + Fw + "'";
                if (dv_fw != null)
                {
                    des_ita = dv_fw[0]["SW_Descrizione"].ToString();
                    des_en = dv_fw[0]["SW_Descrizione_EN"].ToString();
                }

                DataRow newrow = ds_Programmazione_GL.GL_FW_Clienti.NewRow();
                newrow["Cod_Nominativo"] = CodAnaCli;
                newrow["SW_Code"] = Fw;
                newrow["SW_Des1"] = des_ita;
                newrow["SW_Des2"] = des_en;

                ds_Programmazione_GL.GL_FW_Clienti.Rows.Add(newrow);

                gL_FW_ClientiTableAdapter.Update(newrow);
            }
        }

        private void TrovaFWDeviceCommesse(string commessashort)
        {
            ds_SL.dt_TMP_Firmware.Clear();

            string filtro = "CommessaShort = " + "'" + commessashort + "'";

            // Ricerca FW in commesse
            foreach (DataRow rows in ds_Programmazione_GL.SF_Commesse_GL.Select(filtro))
            {
                bool isswrP = Convert.ToBoolean(rows["Is_SWR_P"]);
                bool isswrR = Convert.ToBoolean(rows["Is_SWR_R"]);

                if (isswrP || isswrR)
                {
                    DataRow dr_tmp_fw = ds_SL.dt_TMP_Firmware.NewRow();

                    dr_tmp_fw["CommessaLong"] = rows["CommessaLong"];
                    dr_tmp_fw["CommessaShort"] = rows["CommessaShort"];
                    dr_tmp_fw["CodAnagrafico"] = rows["CodAnagrafico"];
                    dr_tmp_fw["Cod_FW"] = rows["Art_Commessa"];
                    dr_tmp_fw["Is_SWR_P"] = rows["Is_SWR_P"];
                    dr_tmp_fw["Is_SWR_R"] = rows["Is_SWR_R"];
                    dr_tmp_fw["Livello_FW"] = 100; // Firmware da commessa

                    ds_SL.dt_TMP_Firmware.Rows.Add(dr_tmp_fw);
                }
            }
        }

        private void TrovaFWDeviceKit(string kit, string commessalong, string commessashort, int codanacli, string artcommessa)
        {
            string filtro = "ArticoloComposto = " + "'" + kit + "'" + " AND DataFineValidita = '' AND ArticoloComponente like 'GSWR%'";

            // Ricerca FW in commesse
            //foreach (DataRow rows in ds_SL.SF_DistinteBasi.Select(filtro))
            foreach (DataRow rows in ds_Programmazione_GL.SF_DistinteBasi_GL.Select(filtro))
            {
                string componente = rows["ArticoloComponente"].ToString().Trim();

                bool isswrP = false;
                bool isswrR = false;

                if (componente.StartsWith("GSWRP")) { isswrP = true; }
                if (componente.StartsWith("GSWRR")) { isswrR = true; }

                if (isswrP || isswrR)
                {
                    DataRow dr_tmp_fw = ds_SL.dt_TMP_Firmware.NewRow();

                    dr_tmp_fw["CommessaLong"] = commessalong;
                    dr_tmp_fw["CommessaShort"] = commessashort;
                    dr_tmp_fw["CodAnagrafico"] = codanacli;
                    dr_tmp_fw["Cod_FW"] = componente;
                    dr_tmp_fw["Is_SWR_P"] = isswrP;
                    dr_tmp_fw["Is_SWR_R"] = isswrR;
                    dr_tmp_fw["Livello_FW"] = 200; // Firmware da KIT

                    ds_SL.dt_TMP_Firmware.Rows.Add(dr_tmp_fw);
                }
            }
        }

        private bool AggiungiRigaProg(string Commessa, string Kit, string Item, string cod_fw, int fw_key_id, string ID_Hw, char TipoDevice)
        {
            DataRow dr = ds_Programmazione_GL.dt_GL_Tmp_Programma.NewRow();
            dr["tmp_prog_commessa"] = Commessa;
            dr["tmp_prog_codart_kit"] = Kit;
            dr["tmp_prog_codart_item"] = Item;
            dr["tmp_prog_codart_fw"] = cod_fw;
            dr["tmp_fw_key_id"] = fw_key_id;
            dr["tmp_ID_Hardware"] = ID_Hw;
            dr["tmp_TipoDevice"] = TipoDevice;
            ds_Programmazione_GL.dt_GL_Tmp_Programma.Rows.Add(dr);

            return true;
        }

        private bool ProgrammaSilicon(string Commessa, string Kit, string Item, string cod_fw, int fw_key_id, string ID_Hw, string tipodev, string ID1, string ID2, string ID3, bool is_standard_fw, bool is_golden)
        {
            string nome_fw_full = "";
            string nome_fw_boot = "";
            string nome_fw_conf = "";

            if (fw_key_id == 0) // Arriva da codice device
            {
                nome_fw_full = glob_FW_folder + @"\" + cod_fw + @"\" + "full_" + cod_fw + ".s37";
                nome_fw_boot = glob_FW_folder + @"\" + cod_fw + @"\" + "boot_" + cod_fw + ".s37";
                nome_fw_conf = glob_FW_folder + @"\" + cod_fw + @"\" + "conf_" + cod_fw + ".s37";

            }
            else
            {
                DataView dv = new DataView(ds_Programmazione_GL.dt_GL_Tmp_Fw);

                dv.RowFilter = "fw_id = " + fw_key_id;
                if (dv.Count > 0)
                {
                    nome_fw_full = dv[0]["fw_pathfw"].ToString();

                    string nomepath = Path.GetDirectoryName(nome_fw_full);
                    string nomefilefull = "\\full_" + Path.GetFileName(nome_fw_full);
                    string nomefileboot = "\\boot_" + Path.GetFileName(nome_fw_full);
                    string nomefileconf = "\\conf_" + Path.GetFileName(nome_fw_full);
                    nome_fw_full = nomepath + nomefilefull;
                    nome_fw_boot = nomepath + nomefileboot;
                    nome_fw_conf = nomepath + nomefileconf;
                }
            }


            UT_Crea_Unique_Official_Serial_Code = Define_Unique_Serial_Code(ID2);

            glob_Program_OK = true;
            Program_Board(Commessa, Kit, Item, fw_key_id, nome_fw_full, nome_fw_boot, nome_fw_conf, UT_Crea_Unique_Official_Serial_Code, ID1, ID2, ID3, is_standard_fw, is_golden, tipodev);           //nuovo sistema

            string DB_Ser_Kit = Kit;
            int DB_Ser_ID_Cli = Int32.Parse(glob_ID_cli);
            string DB_Ser_Device = Item;
            string DB_Ser_Device_ID_Code = ID2;
            string DB_Ser_OfficialSerial = UT_Crea_Unique_Official_Serial_Code;
            string DB_Ser_ReadSerial = glob_ser_num_read;
            string DB_Ser_SW_Code = cod_fw;
            int DB_Ser_SW_Code_Rev = (int)this.gL_Firmware_PGTableAdapter.GetRev(cod_fw);
            bool DB_Ser_SW_Std_Type = is_standard_fw;
            string DB_Ser_SN_prod = string.Empty;                             //NULL
            string DB_Ser_Commessa = Commessa;
            DateTime DB_Ser_DateProduction = DateTime.Now;
            bool DB_Ser_Spedito = false;
            //DateTime? DB_Ser_Data_Spedito                = DBNull.Value;                                     //NULL
            string DB_Ser_Substition_ID_ReadSerial = string.Empty;                             //NULL
            string DB_Ser_Note = string.Empty;                             //NULL                                                                   //NULL
            int DB_Ser_LockLevel = 0;
            string DB_Ser_Device_ID_Code_Start = ID1;

            bool DB_Ser_Golden_Unlock;
            if (this.sF_GL_ID_UnlockTableAdapter.GetUnlock(Commessa) == "NO") { DB_Ser_Golden_Unlock = false; } else { DB_Ser_Golden_Unlock = true; }
            string DB_Ser_Cfg_Init = ID3;
            bool DB_Ser_CAN;
            if (this.sF_GL_Can_ActiveTableAdapter.GetCanValue(Item) == "NO") { DB_Ser_CAN = false; } else { DB_Ser_CAN = true; }

            if (glob_Program_OK)
            {
                if (glob_tipo_progr == "C")
                {
                    //                    AggiornaSN(Commessa, Kit, Item, fw_key_id, nome_fw_full, ID_Hw, glob_ser_num_read, glob_ser_num_write, glob_ID_cli);
                    AggiornaSN_GL(DB_Ser_Kit,
                                    DB_Ser_ID_Cli,
                                    DB_Ser_Device,
                                    DB_Ser_Device_ID_Code,
                                    DB_Ser_OfficialSerial,
                                    DB_Ser_ReadSerial,
                                    DB_Ser_SW_Code,
                                    DB_Ser_SW_Code_Rev,
                                    DB_Ser_SW_Std_Type,
                                    DB_Ser_SN_prod,
                                    DB_Ser_Commessa,
                                    DB_Ser_DateProduction,
                                    DB_Ser_Spedito,
                                    //DB_Ser_Data_Spedito, 
                                    DB_Ser_Substition_ID_ReadSerial,
                                    DB_Ser_Note,
                                    DB_Ser_LockLevel,
                                    DB_Ser_Device_ID_Code_Start,
                                    DB_Ser_Golden_Unlock,
                                    DB_Ser_Cfg_Init,
                                    DB_Ser_CAN
                                    );

                    //AggiornaFwCliente(glob_ID_cli, glob_codice_fw);
                    //AggiornaSafetyPointRfid(Commessa, glob_ser_num_write, glob_tag_1, glob_tag_2);
                }
            }

            //Autosize delle colonne della tabella
            TableLayoutColumnStyleCollection styles = this.tbl_Label_ID.ColumnStyles;

            foreach (ColumnStyle style in styles)
            {
                style.SizeType = SizeType.AutoSize;
            }

            return true;
        }

        private void PrintLabel(string Item)
        {
            //Stampa Etichetta
            GVar.PrintMask_String = Item;
            //GVar.PrintMask_WarningPic = (bool)this.firmwareTableAdapter.IsCustomPic(glob_codice_fw);
            GVar.PrintMask_Firmware = glob_codice_fw;

            if (!GFunctions.PrintMask()) { MessageBox.Show("Riscontrato problema sulla stampante! Verificare connessione!"); }
        }
        private void PrintLabel_GL(string Item)
        {
            //Stampa Etichetta
            GVar.PrintMask_String = Item;
            //GVar.PrintMask_WarningPic = (bool)this.firmwareTableAdapter.IsCustomPic(glob_codice_fw);
            GVar.PrintMask_Firmware = glob_codice_fw;

            if (!GFunctions.PrintMask_GL()) { MessageBox.Show("Riscontrato problema sulla stampante! Verificare connessione!"); }
        }

        public bool Program_Board(string Commessa, string Kit, string Item, int fw_key_id, string nome_fw_full, string nome_fw_boot, string nome_fw_conf, string ID_Hw, string ID1, string ID2, string ID3, bool is_standard_fw, bool is_golden, string tipodev)
        {
            glob_Program_OK = true;
            //glob_ID_code = ID_Hw;
            glob_ID_code = ID1;

            dos_box.Clear();

            System.Media.SoundPlayer newplayer = new System.Media.SoundPlayer();
            string newsound = @"\\dc\AREA_IT\AREA_SOFTWARE_SISTEMATICA\SmartLineProduction\Windows Notify.wav";
            newplayer.SoundLocation = newsound;
            newplayer.Load();
            newplayer.Play();

            ProcessStartInfo psi = new ProcessStartInfo(@"cmd");
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;
            psi.RedirectStandardInput = true;
            string text_dos = "";

            //Interrogazione interfaccia
            try
            {
                var proc = Process.Start(psi);

                // Setting "DEBUG MODE"
                proc.StandardInput.WriteLine(Properties.Settings.Default.Commander_path_GL + @"\commander.exe adapter dbgmode OUT");

                // La riga sottostante è da verificare
                proc.StandardInput.WriteLine(Properties.Settings.Default.Commander_path_GL + @"\commander.exe device info " + glob_device);
                proc.StandardInput.WriteLine(Properties.Settings.Default.Commander_path_GL + @"\commander.exe --version");
                proc.StandardInput.WriteLine("exit");

                text_dos = proc.StandardOutput.ReadToEnd();
                dos_box.Text = text_dos + "\n======================================================================" + Environment.NewLine;
                dos_box.Refresh();

                if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                    text_dos.Contains("ERROR: Could not open J-Link connection.") ||
                    text_dos.Contains("ERROR: Could not connect debugger."))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente!");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            {

            }

            // Ricerca delle informazioni

            //Part Number
            if (text_dos.Contains("Part Number    :"))
            {

                for (int i = 0; i <= dos_box.Lines.Length; i++)
                {
                    if (dos_box.Lines[i].Contains("Part Number    :"))
                    {
                        string linea_PN = dos_box.Lines[i].ToString();
                        lab_PartNumber.Text = linea_PN.Substring(17);
                        break;
                    }
                }
            }

            //Unique ID
            if (text_dos.Contains("Unique ID      :"))
            {

                for (int i = 0; i <= dos_box.Lines.Length; i++)
                {
                    if (dos_box.Lines[i].Contains("Unique ID      :"))
                    {
                        string linea_ID = dos_box.Lines[i].ToString();
                        lab_IDNumber_read.Text = linea_ID.Substring(17, 16);
                        glob_ser_num_read = linea_ID.Substring(17, 16);

                        // 23.02.2025 - parte non più necessaria
                        ////Doppia versione per nome bluetooth
                        //if (ID_Hw.Count() == 4)
                        //{
                        //    glob_ser_num_write = ConvertiID(glob_ser_num_read);
                        //    lab_IDNumber_write.Text = glob_ser_num_write;
                        //}
                        //else
                        //{
                        //    glob_ser_num_write = ID_Hw;
                        //    lab_IDNumber_write.Text = glob_ser_num_write;
                        //}
                        ////ser_num_write = GVar.glob_result_id[0].ToString() + GVar.glob_result_id[1].ToString() + GVar.glob_result_id[2].ToString() + GVar.glob_result_id[3].ToString() +
                        ////                lab_IDNumber.Text.Substring(0, 6) + lab_IDNumber.Text.Substring(10, 6);
                        break;
                    }
                }
            }

            //Serial Number
            if (text_dos.Contains("Emulator found with SN="))
            {

                for (int i = 0; i <= dos_box.Lines.Length; i++)
                {
                    if (dos_box.Lines[i].Contains("Emulator found with SN="))
                    {
                        string linea_SN = dos_box.Lines[i].ToString();
                        lab_SN.Text = linea_SN.Substring(23, 9);
                        break;
                    }
                }
            }

            //Cancellazione (Versione con Tommaso)
            try
            {
                var proc = Process.Start(psi);

                string programstring = Properties.Settings.Default.Commander_path_GL + @"\commander.exe device masserase " + glob_device;
                proc.StandardInput.WriteLine(programstring);
                proc.StandardInput.WriteLine("exit");

                text_dos = proc.StandardOutput.ReadToEnd();
                dos_box.Text = dos_box.Text + text_dos + "\n======================================================================" + Environment.NewLine;
                dos_box.Refresh();

                if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                    text_dos.Contains("ERROR: Could not open J-Link connection.") ||
                    text_dos.Contains("ERROR: Could not connect debugger."))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente!");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            {

            }

            //Inserimento firmware (conf_ Versione con Tommaso)
            try
            {
                var proc = Process.Start(psi);

                string programstring = Properties.Settings.Default.Commander_path_GL + @"\commander.exe flash " + '"' + nome_fw_conf + '"' + " --address 0x0 " + glob_device;
                proc.StandardInput.WriteLine(programstring);
                proc.StandardInput.WriteLine("exit");

                text_dos = proc.StandardOutput.ReadToEnd();
                dos_box.Text = dos_box.Text + text_dos + "\n======================================================================" + Environment.NewLine;
                dos_box.Refresh();

                if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                    text_dos.Contains("ERROR: Could not open J-Link connection.") ||
                    text_dos.Contains("ERROR: Unspecified error during flashing.") ||
                    text_dos.Contains("ERROR: Could not connect debugger."))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente / Errore di programmazione");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }
                if (text_dos.Contains("ERROR: Verification failed!"))
                {
                    MessageBox.Show("La verifica ha riscontrato un problema!");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            {

            }

            //Verifica (conf_ Versione con Eugeniu)
            try
            {
                var proc = Process.Start(psi);

                //string verifyprogramstring = Properties.Settings.Default.Commander_path + @"\commander.exe verify " + glob_codice_fw_fulltmppath + " " + glob_device;
                string verifyprogramstring = Properties.Settings.Default.Commander_path_GL + @"\commander.exe verify " + '"' + nome_fw_conf + '"' + " " + glob_device;
                proc.StandardInput.WriteLine(verifyprogramstring);
                proc.StandardInput.WriteLine("exit");

                text_dos = proc.StandardOutput.ReadToEnd();
                dos_box.Text = dos_box.Text + text_dos + "\n======================================================================" + Environment.NewLine;
                dos_box.Refresh();

                if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                    text_dos.Contains("ERROR: Could not open J-Link connection.") ||
                    text_dos.Contains("ERROR: Unspecified error during flashing.") ||
                    text_dos.Contains("ERROR: Could not connect debugger."))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente / Errore di programmazione");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }
                if (text_dos.Contains("ERROR: Verification failed!"))
                {
                    MessageBox.Show("La verifica ha riscontrato un problema!");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }

                if (text_dos.Contains("DONE"))
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    string sound = @"\\dc\AREA_IT\AREA_SOFTWARE_SISTEMATICA\SmartLineProduction\tada.wav";
                    player.SoundLocation = sound;
                    player.Load();
                    player.Play();
                }
                else
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    string sound = @"\\dc\AREA_IT\AREA_SOFTWARE_SISTEMATICA\SmartLineProduction\Yamaha.wav";
                    player.SoundLocation = sound;
                    player.Load();
                    player.Play();
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            {

            }

            //Scrittura glob_ID_code - Attributo
            try
            {
                string coppia_1 = "";
                string coppia_2 = "";
                string coppia_3 = "";
                string coppia_4 = "";
                string coppia_5 = "";

                coppia_1 = ID2.Substring(0, 2);
                coppia_2 = ID2.Substring(2, 2);
                coppia_3 = ID2.Substring(4, 2);
                coppia_4 = ID2.Substring(6, 2);
                coppia_5 = ID2.Substring(8, 2);

                var proc = Process.Start(psi);

                string verifyprogramstring = Properties.Settings.Default.Commander_path_GL + @"\commander.exe flash --patch 0x0fe00000:0x" + coppia_5 + coppia_4 + coppia_3 + coppia_2 + coppia_1 + ":5" + " " + glob_device;

                proc.StandardInput.WriteLine(verifyprogramstring);
                proc.StandardInput.WriteLine("exit");

                text_dos = proc.StandardOutput.ReadToEnd();
                dos_box.Text = dos_box.Text + text_dos + "\n======================================================================" + Environment.NewLine;

                if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                    text_dos.Contains("ERROR: Could not open J-Link connection.") ||
                    text_dos.Contains("ERROR: Unspecified error during flashing.") ||
                    text_dos.Contains("ERROR: Could not connect debugger."))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente / Errore di programmazione");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }
                if (text_dos.Contains("ERROR: Verification failed!"))
                {
                    MessageBox.Show("La verifica ha riscontrato un problema!");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }

                if (text_dos.Contains("DONE"))
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    string sound = @"\\dc\AREA_IT\AREA_SOFTWARE_SISTEMATICA\SmartLineProduction\tada.wav";
                    player.SoundLocation = sound;
                    player.Load();
                    player.Play();
                }
                else
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    string sound = @"\\dc\AREA_IT\AREA_SOFTWARE_SISTEMATICA\SmartLineProduction\Yamaha.wav";
                    player.SoundLocation = sound;
                    player.Load();
                    player.Play();
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            {

            }

            //Scrittura ID1 - OM Model Active
            if (ID1.Length == 10)
            {
                try
                {
                    string ID1_coppia_1 = ID1.Substring(2, 2);
                    string ID1_coppia_2 = ID1.Substring(4, 2);
                    string ID1_coppia_3 = ID1.Substring(6, 2);
                    string ID1_coppia_4 = ID1.Substring(8, 2);

                    var proc = Process.Start(psi);

                    string verifyprogramstring = "";
                    verifyprogramstring = Properties.Settings.Default.Commander_path_GL + @"\commander.exe flash --patch 0x0FE00024:0x" + ID1_coppia_4 + ID1_coppia_3 + ID1_coppia_2 + ID1_coppia_1 + ":4" + " " + glob_device;

                    proc.StandardInput.WriteLine(verifyprogramstring);
                    proc.StandardInput.WriteLine("exit");

                    text_dos = proc.StandardOutput.ReadToEnd();
                    dos_box.Text = dos_box.Text + text_dos + "\n======================================================================" + Environment.NewLine;

                    if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                        text_dos.Contains("ERROR: Could not open J-Link connection.") ||
                        text_dos.Contains("ERROR: Unspecified error during flashing.") ||
                        text_dos.Contains("ERROR: Could not connect debugger."))
                    {
                        MessageBox.Show("Interfaccia non collegata correttamente / Errore di programmazione");
                        dos_box.Clear();
                        dos_box.Refresh();
                        text_dos = "";
                        glob_Program_OK = false;
                        return glob_Program_OK;
                    }
                    if (text_dos.Contains("ERROR: Verification failed!"))
                    {
                        MessageBox.Show("La verifica ha riscontrato un problema!");
                        dos_box.Clear();
                        dos_box.Refresh();
                        text_dos = "";
                        glob_Program_OK = false;
                        return glob_Program_OK;
                    }

                    if (text_dos.Contains("DONE"))
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        string sound = @"\\dc\AREA_IT\AREA_SOFTWARE_SISTEMATICA\SmartLineProduction\tada.wav";
                        player.SoundLocation = sound;
                        player.Load();
                        player.Play();
                    }
                    else
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        string sound = @"\\dc\AREA_IT\AREA_SOFTWARE_SISTEMATICA\SmartLineProduction\Yamaha.wav";
                        player.SoundLocation = sound;
                        player.Load();
                        player.Play();
                        glob_Program_OK = false;
                        return glob_Program_OK;
                    }

                    dos_box.SelectionStart = dos_box.Text.Length;
                    dos_box.ScrollToCaret();
                }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
                catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
                {

                }

            }

            //Scrittura UT_Crea_Unique_Official_Serial_Code

            string UI_car_1 = string.Empty;
            string UI_car_2 = string.Empty;
            string UI_car_3 = string.Empty;
            string UI_car_4 = string.Empty;
            string UI_car_5 = string.Empty;
            string UI_car_6 = string.Empty;
            string UI_car_7 = string.Empty;
            string UI_car_8 = string.Empty;
            string UI_car_9 = string.Empty;
            string UI_car_10 = string.Empty;
            string UI_car_11 = string.Empty;
            string UI_car_12 = string.Empty;
            string UI_car_13 = string.Empty;
            string UI_car_14 = string.Empty;
            string UI_car_15 = string.Empty;
            string UI_car_16 = string.Empty;
            string UI_car_17 = string.Empty;
            string UI_car_18 = string.Empty;
            string UI_car_19 = string.Empty;
            string UI_car_20 = string.Empty;

            //if (UT_Crea_Unique_Official_Serial_Code.Length == 20)
            //{
            UI_car_1 = UT_Crea_Unique_Official_Serial_Code.Substring(0, 1);
            UI_car_2 = UT_Crea_Unique_Official_Serial_Code.Substring(1, 1);
            UI_car_3 = UT_Crea_Unique_Official_Serial_Code.Substring(2, 1);
            UI_car_4 = UT_Crea_Unique_Official_Serial_Code.Substring(3, 1);
            UI_car_5 = UT_Crea_Unique_Official_Serial_Code.Substring(4, 1);
            UI_car_6 = UT_Crea_Unique_Official_Serial_Code.Substring(5, 1);
            UI_car_7 = UT_Crea_Unique_Official_Serial_Code.Substring(6, 1);
            UI_car_8 = UT_Crea_Unique_Official_Serial_Code.Substring(7, 1);
            UI_car_9 = UT_Crea_Unique_Official_Serial_Code.Substring(8, 1);
            UI_car_10 = UT_Crea_Unique_Official_Serial_Code.Substring(9, 1);
            UI_car_11 = UT_Crea_Unique_Official_Serial_Code.Substring(10, 1);
            UI_car_12 = UT_Crea_Unique_Official_Serial_Code.Substring(11, 1);
            UI_car_13 = UT_Crea_Unique_Official_Serial_Code.Substring(12, 1);
            UI_car_14 = UT_Crea_Unique_Official_Serial_Code.Substring(13, 1);
            UI_car_15 = UT_Crea_Unique_Official_Serial_Code.Substring(14, 1);
            UI_car_16 = UT_Crea_Unique_Official_Serial_Code.Substring(15, 1);
            UI_car_17 = UT_Crea_Unique_Official_Serial_Code.Substring(16, 1);
            UI_car_18 = UT_Crea_Unique_Official_Serial_Code.Substring(17, 1);
            UI_car_19 = UT_Crea_Unique_Official_Serial_Code.Substring(18, 1);
            UI_car_20 = UT_Crea_Unique_Official_Serial_Code.Substring(19, 1);

            byte[] hex_1 = Encoding.ASCII.GetBytes(UI_car_1);
            byte[] hex_2 = Encoding.ASCII.GetBytes(UI_car_2);
            byte[] hex_3 = Encoding.ASCII.GetBytes(UI_car_3);
            byte[] hex_4 = Encoding.ASCII.GetBytes(UI_car_4);
            byte[] hex_5 = Encoding.ASCII.GetBytes(UI_car_5);
            byte[] hex_6 = Encoding.ASCII.GetBytes(UI_car_6);
            byte[] hex_7 = Encoding.ASCII.GetBytes(UI_car_7);
            byte[] hex_8 = Encoding.ASCII.GetBytes(UI_car_8);
            byte[] hex_9 = Encoding.ASCII.GetBytes(UI_car_9);
            byte[] hex_10 = Encoding.ASCII.GetBytes(UI_car_10);
            byte[] hex_11 = Encoding.ASCII.GetBytes(UI_car_11);
            byte[] hex_12 = Encoding.ASCII.GetBytes(UI_car_12);
            byte[] hex_13 = Encoding.ASCII.GetBytes(UI_car_13);
            byte[] hex_14 = Encoding.ASCII.GetBytes(UI_car_14);
            byte[] hex_15 = Encoding.ASCII.GetBytes(UI_car_15);
            byte[] hex_16 = Encoding.ASCII.GetBytes(UI_car_16);
            byte[] hex_17 = Encoding.ASCII.GetBytes(UI_car_17);
            byte[] hex_18 = Encoding.ASCII.GetBytes(UI_car_18);
            byte[] hex_19 = Encoding.ASCII.GetBytes(UI_car_19);
            byte[] hex_20 = Encoding.ASCII.GetBytes(UI_car_20);

            string s_hex_1 = BitConverter.ToString(hex_1);
            string s_hex_2 = BitConverter.ToString(hex_2);
            string s_hex_3 = BitConverter.ToString(hex_3);
            string s_hex_4 = BitConverter.ToString(hex_4);
            string s_hex_5 = BitConverter.ToString(hex_5);
            string s_hex_6 = BitConverter.ToString(hex_6);
            string s_hex_7 = BitConverter.ToString(hex_7);
            string s_hex_8 = BitConverter.ToString(hex_8);
            string s_hex_9 = BitConverter.ToString(hex_9);
            string s_hex_10 = BitConverter.ToString(hex_10);
            string s_hex_11 = BitConverter.ToString(hex_11);
            string s_hex_12 = BitConverter.ToString(hex_12);
            string s_hex_13 = BitConverter.ToString(hex_13);
            string s_hex_14 = BitConverter.ToString(hex_14);
            string s_hex_15 = BitConverter.ToString(hex_15);
            string s_hex_16 = BitConverter.ToString(hex_16);
            string s_hex_17 = BitConverter.ToString(hex_17);
            string s_hex_18 = BitConverter.ToString(hex_18);
            string s_hex_19 = BitConverter.ToString(hex_19);
            string s_hex_20 = BitConverter.ToString(hex_20);

            //}

            //Scrittura Unique_ID - I Parte
            if (UT_Crea_Unique_Official_Serial_Code.Length == 20)
            {
                try
                {
                    var proc = Process.Start(psi);

                    string verifyprogramstring = "";
                    verifyprogramstring = Properties.Settings.Default.Commander_path_GL + @"\commander.exe flash --patch 0x0FE00010:0x" + s_hex_15 + s_hex_14 + s_hex_13 + s_hex_12 + s_hex_11 + ":5" + " " + glob_device;

                    proc.StandardInput.WriteLine(verifyprogramstring);
                    proc.StandardInput.WriteLine("exit");

                    text_dos = proc.StandardOutput.ReadToEnd();
                    dos_box.Text = dos_box.Text + text_dos + "\n======================================================================" + Environment.NewLine;

                    if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                        text_dos.Contains("ERROR: Could not open J-Link connection.") ||
                        text_dos.Contains("ERROR: Unspecified error during flashing.") ||
                        text_dos.Contains("ERROR: Could not connect debugger."))
                    {
                        MessageBox.Show("Interfaccia non collegata correttamente / Errore di programmazione");
                        dos_box.Clear();
                        dos_box.Refresh();
                        text_dos = "";
                        glob_Program_OK = false;
                        return glob_Program_OK;
                    }
                    if (text_dos.Contains("ERROR: Verification failed!"))
                    {
                        MessageBox.Show("La verifica ha riscontrato un problema!");
                        dos_box.Clear();
                        dos_box.Refresh();
                        text_dos = "";
                        glob_Program_OK = false;
                        return glob_Program_OK;
                    }

                    if (text_dos.Contains("DONE"))
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        string sound = @"\\dc\AREA_IT\AREA_SOFTWARE_SISTEMATICA\SmartLineProduction\tada.wav";
                        player.SoundLocation = sound;
                        player.Load();
                        player.Play();
                    }
                    else
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        string sound = @"\\dc\AREA_IT\AREA_SOFTWARE_SISTEMATICA\SmartLineProduction\Yamaha.wav";
                        player.SoundLocation = sound;
                        player.Load();
                        player.Play();
                        glob_Program_OK = false;
                        return glob_Program_OK;
                    }

                    dos_box.SelectionStart = dos_box.Text.Length;
                    dos_box.ScrollToCaret();
                }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
                catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
                {

                }

            }

            //Scrittura Unique_ID - II Parte
            if (UT_Crea_Unique_Official_Serial_Code.Length == 20)
            {
                try
                {
                    var proc = Process.Start(psi);

                    string verifyprogramstring = "";
                    verifyprogramstring = Properties.Settings.Default.Commander_path_GL + @"\commander.exe flash --patch 0x0FE00015:0x" + s_hex_20 + s_hex_19 + s_hex_18 + s_hex_17 + s_hex_16 + ":5" + " " + glob_device;
                    proc.StandardInput.WriteLine(verifyprogramstring);
                    proc.StandardInput.WriteLine("exit");

                    text_dos = proc.StandardOutput.ReadToEnd();
                    dos_box.Text = dos_box.Text + text_dos + "\n======================================================================" + Environment.NewLine;

                    if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                        text_dos.Contains("ERROR: Could not open J-Link connection.") ||
                        text_dos.Contains("ERROR: Unspecified error during flashing.") ||
                        text_dos.Contains("ERROR: Could not connect debugger."))
                    {
                        MessageBox.Show("Interfaccia non collegata correttamente / Errore di programmazione");
                        dos_box.Clear();
                        dos_box.Refresh();
                        text_dos = "";
                        glob_Program_OK = false;
                        return glob_Program_OK;
                    }
                    if (text_dos.Contains("ERROR: Verification failed!"))
                    {
                        MessageBox.Show("La verifica ha riscontrato un problema!");
                        dos_box.Clear();
                        dos_box.Refresh();
                        text_dos = "";
                        glob_Program_OK = false;
                        return glob_Program_OK;
                    }

                    if (text_dos.Contains("DONE"))
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        string sound = @"\\dc\AREA_IT\AREA_SOFTWARE_SISTEMATICA\SmartLineProduction\tada.wav";
                        player.SoundLocation = sound;
                        player.Load();
                        player.Play();
                    }
                    else
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        string sound = @"\\dc\AREA_IT\AREA_SOFTWARE_SISTEMATICA\SmartLineProduction\Yamaha.wav";
                        player.SoundLocation = sound;
                        player.Load();
                        player.Play();
                        glob_Program_OK = false;
                        return glob_Program_OK;
                    }

                    dos_box.SelectionStart = dos_box.Text.Length;
                    dos_box.ScrollToCaret();
                }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
                catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
                {

                }

            }

            //Inserimento Hex File
            if ((is_golden) && (tipodev == "R"))
            {

                // Lettura Hex
                //Cancellare assegnazione temporanea

                string hex_value = string.Empty;
                try
                {
                    hex_value = this.gL_PG_Config_HexTableAdapter.Get_Hex(ID3).ToString();
                }
                catch (NullReferenceException ex)
                {
                    string mess = "Configurazione " + ID3 + " non presente nella tabella GL_PG_Config_Hex";
                    MessageBox.Show(mess);

                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }

                if (hex_value == null)
                {
                    string mess = "Configurazione " + ID3 + " non presente nella tabella GL_PG_Config_Hex";
                    MessageBox.Show(mess);

                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }

                //Scrittura Hex su file

                string hextempfile = Path.Combine(Path.GetTempPath(), "HexTempFile.bin");
                if (File.Exists(hextempfile)) { File.Delete(hextempfile); }

                int lung = (hex_value.Length / 2);
                //byte[] Hex_Array = Enumerable.Repeat(0x20, lung).ToArray();
                byte[] byteArray = new byte[lung];

                int y = 0;
                for (int i = 0; i < hex_value.Length; i = i + 2)
                {
                    if (i == 270)
                    { }

                    string pezzo = (string)hex_value.Substring(i, 2);
                    string pezzomaiusc = pezzo.ToUpper();
                    byteArray[y] = Convert.ToByte(pezzomaiusc, 16);
                    y++;
                }


                try
                {
                    using (BinaryWriter bw = new BinaryWriter(File.Open(hextempfile, FileMode.Create)))
                    {
                        //writes the data to the stream
                        bw.Write(byteArray);
                    }
                }
                catch (IOException ioexp)
                {
                    Console.WriteLine("Error: {0}", ioexp.Message);
                }

                try
                {
                    var proc = Process.Start(psi);

                    //string programstring = Properties.Settings.Default.Commander_path + @"\commander.exe flash " + '"' + hextempfile + '"' + " --address 0x020 " + glob_device;
                    string programstring = Properties.Settings.Default.Commander_path_GL + @"\commander.exe flash " + '"' + hextempfile + '"' + " --address 0x0fe00020 " + glob_device;

                    proc.StandardInput.WriteLine(programstring);
                    proc.StandardInput.WriteLine("exit");

                    text_dos = proc.StandardOutput.ReadToEnd();
                    dos_box.Text = dos_box.Text + text_dos + "\n======================================================================" + Environment.NewLine;
                    dos_box.Refresh();

                    if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                        text_dos.Contains("ERROR: Could not open J-Link connection.") ||
                        text_dos.Contains("ERROR: Unspecified error during flashing.") ||
                        text_dos.Contains("ERROR: Could not connect debugger."))
                    {
                        MessageBox.Show("Interfaccia non collegata correttamente / Errore di programmazione");
                        dos_box.Clear();
                        dos_box.Refresh();
                        text_dos = "";
                        glob_Program_OK = false;
                        return glob_Program_OK;
                    }
                    if (text_dos.Contains("ERROR: Verification failed!"))
                    {
                        MessageBox.Show("La verifica ha riscontrato un problema!");
                        dos_box.Clear();
                        dos_box.Refresh();
                        text_dos = "";
                        glob_Program_OK = false;
                        return glob_Program_OK;
                    }

                    dos_box.SelectionStart = dos_box.Text.Length;
                    dos_box.ScrollToCaret();
                }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
                catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
                {

                }
            }

            //Inserimento firmware (boot_ Versione con Tommaso)
            try
            {
                var proc = Process.Start(psi);

                string programstring = Properties.Settings.Default.Commander_path_GL + @"\commander.exe flash " + '"' + nome_fw_boot + '"' + " --address 0x0 " + glob_device;
                proc.StandardInput.WriteLine(programstring);
                proc.StandardInput.WriteLine("exit");

                text_dos = proc.StandardOutput.ReadToEnd();
                dos_box.Text = dos_box.Text + text_dos + "\n======================================================================" + Environment.NewLine;
                dos_box.Refresh();

                if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                    text_dos.Contains("ERROR: Could not open J-Link connection.") ||
                    text_dos.Contains("ERROR: Unspecified error during flashing.") ||
                    text_dos.Contains("ERROR: Could not connect debugger."))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente / Errore di programmazione");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }
                if (text_dos.Contains("ERROR: Verification failed!"))
                {
                    MessageBox.Show("La verifica ha riscontrato un problema!");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            {

            }

            //Verifica (boot_ Versione con Eugeniu)
            try
            {
                var proc = Process.Start(psi);

                //string verifyprogramstring = Properties.Settings.Default.Commander_path + @"\commander.exe verify " + glob_codice_fw_fulltmppath + " " + glob_device;
                string verifyprogramstring = Properties.Settings.Default.Commander_path_GL + @"\commander.exe verify " + '"' + nome_fw_boot + '"' + " " + glob_device;
                proc.StandardInput.WriteLine(verifyprogramstring);
                proc.StandardInput.WriteLine("exit");

                text_dos = proc.StandardOutput.ReadToEnd();
                dos_box.Text = dos_box.Text + text_dos + "\n======================================================================" + Environment.NewLine;
                dos_box.Refresh();

                if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                    text_dos.Contains("ERROR: Could not open J-Link connection.") ||
                    text_dos.Contains("ERROR: Unspecified error during flashing.") ||
                    text_dos.Contains("ERROR: Could not connect debugger."))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente / Errore di programmazione");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }
                if (text_dos.Contains("ERROR: Verification failed!"))
                {
                    MessageBox.Show("La verifica ha riscontrato un problema!");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }

                if (text_dos.Contains("DONE"))
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    string sound = @"\\dc\AREA_IT\AREA_SOFTWARE_SISTEMATICA\SmartLineProduction\tada.wav";
                    player.SoundLocation = sound;
                    player.Load();
                    player.Play();
                }
                else
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    string sound = @"\\dc\AREA_IT\AREA_SOFTWARE_SISTEMATICA\SmartLineProduction\Yamaha.wav";
                    player.SoundLocation = sound;
                    player.Load();
                    player.Play();
                    glob_Program_OK = false;
                    return glob_Program_OK;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            {

            }

            //////////////////////////////////////////////////////////////////////////

            if (glob_tipo_progr != "L")
            {
                if (glob_Program_OK)
                {
                    //PrintLabel(UT_Crea_Unique_Official_Serial_Code);
                    PrintLabel_GL(UT_Crea_Unique_Official_Serial_Code);
                }
            }

            return glob_Program_OK;
        }

        private void AggiornaSN(string Commessa, string Kit, string Item, int fw_key_id, string nome_fw_full, string ID_Hw, string serial_read, string serial_write, string ID_Cli)
        {
            // Recupero Codice Firmware
            DataView dv = new DataView(ds_Programmazione_GL.dt_GL_Tmp_Fw);
            string codice_fw = "";
            bool Fw_isStandard = false;
            string Fw_Rev = "";


            if (glob_tipo_progr == "L") //programmazione libera
            {
                dv.RowFilter = "fw_id = " + fw_key_id;
                if (dv.Count > 0)
                {
                    codice_fw = dv[0]["fw_codfw"].ToString();
                }
            }
            else
            {
                codice_fw = glob_codice_fw;

                // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL.dt_Firmware_lookupCommesseGL'. È possibile spostarla o rimuoverla se necessario.
                this.dt_Firmware_lookupCommesseGLTableAdapter1.Fill(this.ds_Programmazione_GL.dt_Firmware_lookupCommesseGL);
                DataRowCollection rowCol = this.ds_Programmazione_GL.dt_Firmware_lookupCommesseGL.Rows;
                Fw_isStandard = (bool)rowCol[0]["SW_Standard"];
                Fw_Rev = rowCol[0]["SW_Revisione"].ToString();

                //Ottengo LockLevel
                string tipodev = rowCol[0]["SW_TipoDevice"].ToString();
                if (tipodev == "P") { glob_LockLevel = (int)rowCol[0]["SW_P_Lock"]; }
                if (tipodev == "R") { glob_LockLevel = (int)rowCol[0]["SW_R_Lock"]; }
            }

            // Verifica se nuovo SN o già esistente
            bool newrecord = false;
            string sel = "Ser_ReadSerial = " + "'" + serial_read + "'";
            DataRow[] result = ds_Programmazione_GL.GL_SerialNumbers.Select(sel);
            if (result.Count() > 0) { newrecord = false; } else { newrecord = true; }

            //Cancello il record prima di scrivere il nuovo
            if (!newrecord)
            {
                foreach (DataRow row in result)
                {
                    row.Delete();
                }
            }

            try
            {
                Validate();
                gLSerialNumbersBindingSource.EndEdit();
                gL_SerialNumbersTableAdapter.Update(this.ds_Programmazione_GL.GL_SerialNumbers);
            }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            catch (System.Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            {
                MessageBox.Show("Table 'SerialNumbers' - Update failed");
            }

            DataRow newrow = ds_Programmazione_GL.GL_SerialNumbers.NewRow();
            newrow["Ser_Device_ID_Code"] = ID_Hw;
            newrow["Ser_OfficialSerial"] = serial_write;
            newrow["Ser_ReadSerial"] = serial_read;
            newrow["Ser_SW_Code"] = codice_fw;
            newrow["Ser_Spedito"] = false;
            newrow["Ser_DateProduction"] = DateTime.Now;
            newrow["Ser_LockLevel"] = glob_LockLevel;

            if (glob_tipo_progr == "C") //C-Commessa K-Kit D-Device L-Libera
            {
                newrow["Ser_Commessa"] = Commessa;
                newrow["Ser_Kit"] = Kit;
                newrow["Ser_ID_Cli"] = ID_Cli;
                newrow["Ser_Device"] = Item;

                //riga modificata il 20/05/2021 per programmare i custom ma consentire di vedere anche gli altri firmware
                //newrow["Ser_SW_Std_Type"] = Fw_isStandard;
                newrow["Ser_SW_Std_Type"] = true;
                newrow["Ser_SW_Code_Rev"] = Fw_Rev;
            }

            try
            {
                ds_Programmazione_GL.GL_SerialNumbers.Rows.Add(newrow);
                serialNumbersTableAdapter.Update(newrow);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Table 'SerialNumbers' - Update failed");
            }
        }

        private void AggiornaSN_GL(string DB_Ser_Kit,
                                    int DB_Ser_ID_Cli,
                                    string DB_Ser_Device,
                                    string DB_Ser_Device_ID_Code,
                                    string DB_Ser_OfficialSerial,
                                    string DB_Ser_ReadSerial,
                                    string DB_Ser_SW_Code,
                                    int DB_Ser_SW_Code_Rev,
                                    bool DB_Ser_SW_Std_Type,
                                    string DB_Ser_SN_prod,
                                    string DB_Ser_Commessa,
                                    DateTime DB_Ser_DateProduction,
                                    bool DB_Ser_Spedito,
                                    //DateTime DB_Ser_Data_Spedito,
                                    string DB_Ser_Substition_ID_ReadSerial,
                                    string DB_Ser_Note,
                                    int DB_Ser_LockLevel,
                                    string DB_Ser_Device_ID_Code_Start,
                                    bool DB_Ser_Golden_Unlock,
                                    string DB_Ser_Cfg_Init,
                                    bool DB_Ser_CAN
            )
        {
            if (glob_tipo_progr == "L") //programmazione libera
            {
                //dv.RowFilter = "fw_id = " + fw_key_id;
                //if (dv.Count > 0)
                //{
                //    codice_fw = dv[0]["fw_codfw"].ToString();
                //}
            }

            // Verifica se nuovo SN o già esistente
            bool newrecord = false;
            string sel = "Ser_ReadSerial = " + "'" + DB_Ser_ReadSerial + "'";
            DataRow[] result = ds_Programmazione_GL.GL_SerialNumbers.Select(sel);
            if (result.Count() > 0) { newrecord = false; } else { newrecord = true; }

            //Cancello il record prima di scrivere il nuovo
            if (!newrecord)
            {
                foreach (DataRow row in result)
                {
                    row.Delete();
                }
            }

            try
            {
                Validate();
                gLSerialNumbersBindingSource.EndEdit();
                gL_SerialNumbersTableAdapter.Update(this.ds_Programmazione_GL.GL_SerialNumbers);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Table 'SerialNumbers' - Update failed");
            }

            DataRow newrow = ds_Programmazione_GL.GL_SerialNumbers.NewRow();
            newrow["Ser_Kit"] = DB_Ser_Kit.Trim();
            newrow["Ser_ID_Cli"] = DB_Ser_ID_Cli;
            newrow["Ser_Device"] = DB_Ser_Device.Trim();
            newrow["Ser_Device_ID_Code"] = DB_Ser_Device_ID_Code.Trim();
            newrow["Ser_OfficialSerial"] = DB_Ser_OfficialSerial.Trim();
            newrow["Ser_ReadSerial"] = DB_Ser_ReadSerial.Trim();
            newrow["Ser_SW_Code"] = DB_Ser_SW_Code.Trim();
            newrow["Ser_SW_Code_Rev"] = DB_Ser_SW_Code_Rev;
            newrow["Ser_SW_Std_Type"] = DB_Ser_SW_Std_Type;
            newrow["Ser_SN_prod"] = DB_Ser_SN_prod;
            newrow["Ser_Commessa"] = DB_Ser_Commessa.Trim();
            newrow["Ser_DateProduction"] = DB_Ser_DateProduction;
            newrow["Ser_Spedito"] = DB_Ser_Spedito;
            //newrow["Ser_Data_Spedito"] = DB_Ser_Data_Spedito;
            newrow["Ser_Data_Spedito"] = DBNull.Value;
            newrow["Ser_Substition_ID_ReadSerial"] = DB_Ser_Substition_ID_ReadSerial;
            //newrow["Ser_Note"] = DB_Ser_Note;
            newrow["Ser_Note"] = DBNull.Value;
            newrow["Ser_LockLevel"] = DB_Ser_LockLevel;
            newrow["Ser_Device_ID_Code_Start"] = DB_Ser_Device_ID_Code_Start.Trim();
            newrow["Ser_Golden_Unlock"] = DB_Ser_Golden_Unlock;
            newrow["Ser_Cfg_Init"] = DB_Ser_Cfg_Init.Trim();
            //newrow["Ser_CAN"] = DB_Ser_CAN;



            //newrow["Ser_Device_ID_Code"] = ID_Hw;
            //newrow["Ser_OfficialSerial"] = serial_write;
            //newrow["Ser_ReadSerial"] = serial_read;
            //newrow["Ser_SW_Code"] = codice_fw;
            //newrow["Ser_Spedito"] = false;
            //newrow["Ser_DateProduction"] = DateTime.Now;
            //newrow["Ser_LockLevel"] = glob_LockLevel;

            //if (glob_tipo_progr == "C") //C-Commessa K-Kit D-Device L-Libera
            //{
            //    newrow["Ser_Commessa"] = DB_Ser_Commessa;
            //    newrow["Ser_Kit"] = DB_Ser_Kit;
            //    newrow["Ser_ID_Cli"] = DB_Ser_ID_Cli;
            //    newrow["Ser_Device"] = DB_Ser_Device;

            //    //riga modificata il 20/05/2021 per programmare i custom ma consentire di vedere anche gli altri firmware
            //    //newrow["Ser_SW_Std_Type"] = Fw_isStandard;
            //    newrow["Ser_SW_Std_Type"] = true;
            //    newrow["Ser_SW_Code_Rev"] = Fw_Rev;
            //}

            try
            {
                ds_Programmazione_GL.GL_SerialNumbers.Rows.Add(newrow);
                gL_SerialNumbersTableAdapter.Update(newrow);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Table 'SerialNumbers' - Update failed");
            }
        }

        private string ConvertiID(string ID)
        {
            string id_write = "";
            id_write = glob_ID_code;
            id_write = id_write + ID.Substring(0, 6) + ID.Substring(10, 6);
            return id_write;
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int TrovaLastProgr(string ID_Hw)
        {
            int returnLastNumber = 0;
            string anno = Convert.ToString(DateTime.Now.Year);

            sFLastSerialNumberBindingSource.Filter = "Anno = " + "'" + anno + "'";
            if (sFLastSerialNumberBindingSource.Count != 0)
            {
                DataRowView current = (DataRowView)sFLastSerialNumberBindingSource.Current;
                returnLastNumber = Convert.ToInt32(current["LastSerialID"]);
            }
            return returnLastNumber;
        }

        private string Define_Unique_Serial_Code(string device_item)
        {
            string return_Code = string.Empty;
            bool already_exists = true;

            do
            {
                return_Code = this.uT_Crea_Unique_Official_Serial_CodeTableAdapter.UT_Crea_Unique_Official_Serial_CodeGetRandomCode(device_item, 10).ToString();

                if (this.gL_SerialNumbersTableAdapter.Check_Ser_OfficialSerial_Exists(return_Code) == 1)
                {
                    already_exists = true;
                }
                else
                {
                    already_exists = false;
                }

            } while (already_exists);

            return return_Code;
        }

        private void RiposizionaGridCommesse()
        {
            if (glob_selectedrecord != 0)
            {
                sFCommesseGLBindingSource.Position = glob_selectedrecord;
            }
        }

        private void AggiornaSafetyPointRfid(string Commessa, string bt_device, string tag1, string tag2)
        {
            // Prima ricerca - pulizia per UUID 1
            string filtro = "Rfid_UUID = " + "'" + tag1 + "'";
            safetyPointRFIDGLBindingSource.Filter = filtro;
            foreach (DataRowView tagRow in safetyPointRFIDGLBindingSource)
            {
                if ((tagRow["Rfid_Ser_SN_Prod"].ToString() != string.Empty) || (tagRow["Rfid_Ser_OfficialSerial"].ToString() != string.Empty))
                {
                    tagRow["Rfid_Ser_SN_Prod"] = null;
                    tagRow["Rfid_Ser_OfficialSerial"] = null;
                    string oldcontent = tagRow["Rfid_Note"].ToString();
                    oldcontent = oldcontent + " - Eliminato l'accoppiamento con palmare il " + DateTime.Now.ToString("dd/MM/yyyy");
                    tagRow["Rfid_Note"] = oldcontent;
                    try
                    {
                        Validate();
                        this.safetyPointRFIDGLBindingSource.EndEdit();
                        this.safetyPointRFID_GLTableAdapter.Update(this.ds_Programmazione_GL.SafetyPointRFID_GL);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Table 'SafetyPointRfid' - Update failed");
                    }
                }
            }

            // Seconda ricerca - pulizia per UUID 2
            filtro = "Rfid_UUID = " + "'" + tag2 + "'";
            safetyPointRFIDGLBindingSource.Filter = filtro;
            foreach (DataRowView tagRow in safetyPointRFIDGLBindingSource)
            {
                if ((tagRow["Rfid_Ser_SN_Prod"].ToString() != string.Empty) || (tagRow["Rfid_Ser_OfficialSerial"].ToString() != string.Empty))
                {
                    tagRow["Rfid_Ser_SN_Prod"] = null;
                    tagRow["Rfid_Ser_OfficialSerial"] = null;
                    string oldcontent = tagRow["Rfid_Note"].ToString();
                    oldcontent = oldcontent + " - Eliminato l'accoppiamento con palmare il " + DateTime.Now.ToString("dd/MM/yyyy");
                    tagRow["Rfid_Note"] = oldcontent;
                    try
                    {
                        Validate();
                        this.safetyPointRFIDGLBindingSource.EndEdit();
                        this.safetyPointRFID_GLTableAdapter.Update(this.ds_Programmazione_GL.SafetyPointRFID_GL);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Table 'SafetyPointRfid' - Update failed");
                    }
                }
            }

            // Terza ricerca - pulizia per codice device
            filtro = "Rfid_Ser_OfficialSerial = " + "'" + bt_device + "'";
            safetyPointRFIDGLBindingSource.Filter = filtro;
            foreach (DataRowView tagRow in safetyPointRFIDGLBindingSource)
            {
                if ((tagRow["Rfid_Ser_SN_Prod"].ToString() != string.Empty) || (tagRow["Rfid_Ser_OfficialSerial"].ToString() != string.Empty))
                {
                    tagRow["Rfid_Ser_SN_Prod"] = null;
                    tagRow["Rfid_Ser_OfficialSerial"] = null;
                    string oldcontent = tagRow["Rfid_Note"].ToString();
                    oldcontent = oldcontent + " - Eliminato l'accoppiamento con palmare il " + DateTime.Now.ToString("dd/MM/yyyy");
                    tagRow["Rfid_Note"] = oldcontent;
                    try
                    {
                        Validate();
                        this.safetyPointRFIDGLBindingSource.EndEdit();
                        this.safetyPointRFID_GLTableAdapter.Update(this.ds_Programmazione_GL.SafetyPointRFID_GL);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Table 'SafetyPointRfid' - Update failed");
                    }
                }
            }

            //Scrittura - Tag 1
            filtro = "Rfid_UUID = " + "'" + tag1 + "'";
            safetyPointRFIDGLBindingSource.Filter = filtro;
            foreach (DataRowView tag1Row in safetyPointRFIDGLBindingSource)
            {
                tag1Row["Rfid_Ser_OfficialSerial"] = bt_device;
                string oldcontent = tag1Row["Rfid_Note"].ToString();
                oldcontent = oldcontent + " - " + Commessa + ": Palmare " + bt_device;
                tag1Row["Rfid_Note"] = oldcontent;
                try
                {
                    Validate();
                    this.safetyPointRFIDGLBindingSource.EndEdit();
                    this.safetyPointRFID_GLTableAdapter.Update(this.ds_Programmazione_GL.SafetyPointRFID_GL);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Table 'SafetyPointRfid' - Update failed");
                }
            }

            //Scrittura - Tag 2
            filtro = "Rfid_UUID = " + "'" + tag2 + "'";
            safetyPointRFIDGLBindingSource.Filter = filtro;
            foreach (DataRowView tag2Row in safetyPointRFIDGLBindingSource)
            {
                tag2Row["Rfid_Ser_OfficialSerial"] = bt_device;
                string oldcontent = tag2Row["Rfid_Note"].ToString();
                oldcontent = oldcontent + " - " + Commessa + ": Palmare " + bt_device;
                tag2Row["Rfid_Note"] = oldcontent;
                try
                {
                    Validate();
                    this.safetyPointRFIDGLBindingSource.EndEdit();
                    this.safetyPointRFID_GLTableAdapter.Update(this.ds_Programmazione_GL.SafetyPointRFID_GL);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Table 'SafetyPointRfid' - Update failed");
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        /// Funzioni generate
        ///////////////////////////////////////////////////////////////////////////////////////////////

        private void UC_Programmazione_GL_Commessa_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL.SF_GL_Can_Active'. È possibile spostarla o rimuoverla se necessario.
            this.sF_GL_Can_ActiveTableAdapter.Fill(this.ds_Programmazione_GL.SF_GL_Can_Active);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione_GL.SF_GL_ID_Unlock'. È possibile spostarla o rimuoverla se necessario.
            this.sF_GL_ID_UnlockTableAdapter.Fill(this.ds_Programmazione_GL.SF_GL_ID_Unlock);
            // Abilita zone dello schermo
            ds_Programmazione_GL.dt_GL_Tmp_Fw.Clear();
            ds_Programmazione_GL.dt_GL_Tmp_Programma.Clear();
            AbilitaSchermo();

            CaricaArchivi();
        }

        private void grid_commesse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //////////////////////////////////////////////////////////////////////////////////////////
            // Controllo se posizionato sulla riga corretta

            int pos_rowselected = grid_commesse.CurrentCell.RowIndex;
            int pos_rowclicked = e.RowIndex;
            if (pos_rowselected != pos_rowclicked)
            {
                string mess = "Rilevata incongruenza. Selezionare altra riga!";
                //+"Selected = " + pos_rowclicked.ToString() + " / " + "Clicked = " + pos_rowclicked.ToString()

                MessageBox.Show(mess);
                return;
            }
            //string findCommessaLong = (string)grid_commesse.Rows[e.RowIndex].Cells["grid_commesse_CommessaLong"].Value;
            //int pos_teorica = sFCommesseSLBindingSource.Position;
            //int pos_reale = sFCommesseSLBindingSource.Find("CommessaLong", findCommessaLong);
            //if (pos_reale != pos_teorica)
            //{
            //    sFCommesseSLBindingSource.Position = pos_reale;
            //}
            //////////////////////////////////////////////////////////////////////////////////////////


            // controllo se già evasa
            if (e.ColumnIndex == grid_commesse.Columns["grid_commesse_CommessaSelezionata"].Index)
            {
                int qtadaeva = 0;
                int qtaevasa = 0;

                try
                {
                    qtadaeva = Convert.ToInt32(grid_commesse.Rows[e.RowIndex].Cells["grid_commesse_QtaInOrdine"].Value);
                }
                catch (FormatException)
                {
                    qtadaeva = 0;
                }

                try
                {
                    qtaevasa = Convert.ToInt32(grid_commesse.Rows[e.RowIndex].Cells["grid_commesse_Qta_Evasa"].Value);
                }
                catch (FormatException)
                {
                    qtaevasa = 0;
                }


                if ((qtaevasa != 0) && (qtaevasa >= qtadaeva))
                {
                    MessageBox.Show("Commessa già evasa totalmente!");
                    //return;
                }
            }

            //Setto tipo programmazione
            glob_tipo_progr = "C";

            //Memorizzo indice riga
            glob_selectedrecord = sFCommesseGLBindingSource.Position;

            //Controllo su tipo riga
            DataGridViewRow row = grid_commesse.Rows[e.RowIndex];
            string CommessaLong = row.Cells["grid_commesse_CommessaLong"].Value.ToString().Trim();
            string CommessaShort = row.Cells["grid_commesse_CommessaShort"].Value.ToString().Trim();
            string Kit = row.Cells["grid_commesse_CodArticoloCommessa"].Value.ToString().Trim();
            string Item = row.Cells["grid_commesse_Device"].Value.ToString().Trim();
            string Fw = row.Cells["grid_commesse_SwDevice"].Value.ToString().Trim();
            glob_ID_cli = row.Cells["grid_commesse_CodAnagrafico"].Value.ToString().Trim();

            if ((e.ColumnIndex == grid_commesse.Columns["grid_commesse_ViewDevice"].Index) && (Item != ""))
            {
                using (var form = new UC_ImageDevice(Item, WEB_path_image))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                    }
                }
            }

            if (e.ColumnIndex == grid_commesse.Columns["grid_commesse_CommessaSelezionata"].Index) // Aggiorna
            {
                if (Item == "") // Solo Software
                {
                    Fw = Kit; //Sovrascrivo il codice software (non ce l'ho) con l'item
                    AggiornaFwCliente(glob_ID_cli, Fw);
                }
                else
                {
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    // 09.02.2025 - commentato e rifatto completamente
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    //ds_Programmazione_GL.dt_GL_Tmp_Programma.Clear();
                    //ds_SL.dt_TMP_Firmware.Clear();

                    ////Ricerca di tutti i device e di tutti i software
                    //TrovaFWDeviceCommesse(CommessaShort);
                    //TrovaFWDeviceKit(Kit, CommessaLong, CommessaShort, Convert.ToInt32(glob_ID_cli), Kit);

                    ////Controllo oggetto per capire che FW mettere
                    //ds_SL.dt_TMP_Firmware.DefaultView.Sort = "Livello_FW desc, Cod_FW asc";
                    //string tipodevice = Item.Substring(5, 1);
                    //string filtro = "";
                    //if (tipodevice == "P")
                    //{
                    //    filtro = "Is_SWR_P = '1'";
                    //}
                    //if (tipodevice == "R")
                    //{
                    //    filtro = "Is_SWR_R = '1'";
                    //}
                    //foreach (DataRow rows in ds_SL.dt_TMP_Firmware.Select(filtro))
                    //{
                    //    Fw = rows["Cod_FW"].ToString();
                    //    break;
                    //}

                    //DataRowView currentRowView = sFCommesseSLSFArticoliBindingSource.Current as DataRowView;
                    //string ID = currentRowView["Modello"].ToString();
                    //AggiungiRigaProg(CommessaLong, Kit, Item, Fw, 0, ID);

                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    ds_Programmazione_GL.dt_GL_Tmp_Programma.Clear();
                    ds_SL.dt_TMP_Firmware.Clear();

                    //Ricerca di tutti i device e di tutti i software
                    TrovaFWDeviceCommesse(CommessaShort);
                    TrovaFWDeviceKit(Kit, CommessaLong, CommessaShort, Convert.ToInt32(glob_ID_cli), Kit);

                    //Controllo oggetto per capire che FW mettere
                    ds_SL.dt_TMP_Firmware.DefaultView.Sort = "Livello_FW desc, Cod_FW asc";

                    //string tipodevice = Item.Substring(5, 1);
                    string tipodevice = string.Empty;
                    try
                    {
                        tipodevice = this.gL_Firmware_PGTableAdapter.GetDeviceType(Fw).ToString();
                    }
                    catch (NullReferenceException ex)
                    {
                        string mess = "Firmware non presente nella tabella\r\nGL_Firmware_PG";

                        MessageBox.Show(mess);
                        return;
                    }

                    string filtro = "";
                    if (tipodevice == "P")
                    {
                        filtro = "Is_SWR_P = '1'";
                    }
                    if (tipodevice == "R")
                    {
                        filtro = "Is_SWR_R = '1'";
                    }
                    foreach (DataRow rows in ds_SL.dt_TMP_Firmware.Select(filtro))
                    {
                        Fw = rows["Cod_FW"].ToString();
                        break;
                    }

                    DataRowView currentRowView = sFCommesseSLSFArticoliBindingSource.Current as DataRowView;
                    string ID = currentRowView["Modello"].ToString();
                    //AggiungiRigaProg(CommessaLong, Kit, Item, Fw, 0, ID, 'R');
                    AggiungiRigaProg(CommessaLong, Kit, Item, Fw, 0, ID, char.Parse(tipodevice));

                    //Definisco se Standard FW
                    int res = (int)this.gL_Firmware_PGTableAdapter.IsStandardFW(Fw);
                    if (res == 0) { glob_Standard_FW = false; } else { glob_Standard_FW = true; }

                    //Definisco se sw Golden
                    glob_IsGolden = (bool)this.gL_Firmware_PGTableAdapter.IsGoldenFW(Fw);
                    //bool result = this.gL_Firmware_PGTableAdapter.IsGoldenFW(Fw);
                    //if (res == 0) { glob_IsGolden = false; } else { glob_IsGolden = true; }
                }
            }

            grid_commesse.Refresh();
        }

        private void grid_commesse_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == grid_commesse.Columns["grid_commesse_ViewDevice"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Lente.Width;
                var h = Properties.Resources.Lente.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Lente, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex == grid_commesse.Columns["grid_commesse_Device"].Index)
            {
                if (grid_commesse.Rows[e.RowIndex].Cells["grid_commesse_Device"].Value.ToString() == "")
                {
                    // Verifica se il firmware è già associato al cliente
                    bool newrecord = false;

                    string CodAnaCli = grid_commesse.Rows[e.RowIndex].Cells["grid_commesse_CodAnagrafico"].Value.ToString();
                    string Fw = grid_commesse.Rows[e.RowIndex].Cells["grid_commesse_CodArticoloCommessa"].Value.ToString();

                    string sel = "Cod_Nominativo = " + "'" + CodAnaCli + "' AND SW_Code = '" + Fw + "'";
                    DataRow[] result = ds_Programmazione_GL.GL_FW_Clienti.Select(sel);
                    if (result.Count() > 0) { newrecord = false; } else { newrecord = true; }

                    if (!newrecord)
                    {
                        //grid_commesse.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
                        grid_commesse.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(grid_commesse.DefaultCellStyle.Font, System.Drawing.FontStyle.Strikeout);
                        if (!glob_show_evasi) { grid_commesse.Rows[e.RowIndex].Visible = false; } else { grid_commesse.Rows[e.RowIndex].Visible = true; }
                    }
                }
            }

            if (e.ColumnIndex == grid_commesse.Columns["grid_commesse_Qta_Evasa"].Index)
            {
                if ((grid_commesse.Rows[e.RowIndex].Cells["grid_commesse_Qta_Evasa"].Value != null) && (grid_commesse.Rows[e.RowIndex].Cells["grid_commesse_Qta_Evasa"].Value.ToString() != ""))
                {
                    decimal qtadaeva = 0;
                    decimal qtaevasa = 0;

                    try
                    {
                        //qtadaeva = Int32.Parse(grid_commesse.Rows[e.RowIndex].Cells["grid_commesse_QtaDaEvadere"].Value.ToString());
                        qtadaeva = Convert.ToDecimal(grid_commesse.Rows[e.RowIndex].Cells["grid_commesse_QtaDaEvadere"].Value.ToString());
                    }
                    catch (FormatException)
                    {
                        qtadaeva = 0;
                    }

                    try
                    {
                        //qtaevasa = Int32.Parse(grid_commesse.Rows[e.RowIndex].Cells["grid_commesse_Qta_Evasa"].Value.ToString());
                        qtaevasa = Convert.ToDecimal(grid_commesse.Rows[e.RowIndex].Cells["grid_commesse_Qta_Evasa"].Value.ToString());
                    }
                    catch (FormatException)
                    {
                        qtaevasa = 0;
                    }


                    if ((qtaevasa != 0) && (qtaevasa >= qtadaeva))
                    {
                        //grid_commesse.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
                        grid_commesse.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(grid_commesse.DefaultCellStyle.Font, System.Drawing.FontStyle.Strikeout);
                        //                        if (!glob_show_evasi) { grid_commesse.Rows[e.RowIndex].Visible = false; } else { grid_commesse.Rows[e.RowIndex].Visible = true; }
                    }
                }
            }
        }

        private void grid_commesse_menu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            CaricaArchivi();

            Cursor.Current = Cursors.Default;
        }

        private void grid_commesse_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var menuText = e.ClickedItem.Text;
            switch (menuText)
            {
                case "Visualizza le commesse evase":
                    glob_show_evasi = true;
                    break;

                case "Nascondi le commesse evase":
                    glob_show_evasi = false;
                    break;
            }

            //filtraggio delle righe
            string filter = "";

            if (!glob_show_evasi)
            {
                filter = "Qta_da_Evadere > Qta_Evasa";
            }
            sFCommesseGLBindingSource.Filter = filter;
        }

        private void grid_commesse_menu_Opened(object sender, EventArgs e)
        {
            if (glob_show_evasi)
            {
                menu_commesse_vis.Checked = true;
                menu_commesse_nas.Checked = false;
            }
            else
            {
                menu_commesse_vis.Checked = false;
                menu_commesse_nas.Checked = true;
            }
        }

        private void dg_dt_tmp_programmazione_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_commesse.Enabled = false;

            dos_box.Clear();
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewRow row = dg_dt_tmp_programmazione.Rows[e.RowIndex];
                string Commessa = row.Cells["dg_dt_tmp_progr_Commessa"].Value.ToString();

                string Kit = row.Cells["dg_dt_tmp_progr_Kit"].Value.ToString();
                string Item = row.Cells["dg_dt_tmp_progr_Device"].Value.ToString();
                glob_codice_sistema = Item;
                string Fw = row.Cells["dg_dt_tmp_progr_Fw"].Value.ToString();
                glob_codice_fw = Fw;

                string tipodev = row.Cells["dg_tmp_progr_TipoDevice"].Value.ToString();

                int Key_Id = Int16.Parse(row.Cells["dg_dt_tmp_progr_FwKeyId"].Value.ToString());
                string ID_Hw = row.Cells["dg_dt_tmp_progr_ID_Hardware"].Value.ToString();
                glob_ID_newcode = ID_Hw;

                string ID1 = row.Cells["dg_dt_tmp_progr_ID_Hardware"].Value.ToString().Trim();
                string ID2 = this.sF_GL_id1_ProgrammazioneTableAdapter.Get_ID1(Item).Trim();
                string ID3 = string.Empty;
                try
                {
                    ID3 = this.sF_GL_id2_ProgrammazioneTableAdapter.Get_ID2(Commessa).Trim();
                }
                catch (Exception ex)
                {
                }

                // ID1 = ID HW
                // ID2 = ID Opzioni Attivate --> arat0000 - attributo 4000: campo "Valore"
                // ID3 - IDConfigurazione ----> DATT0000 - TipoDocumento = 'G' and Attributo = 1000 and Gruppo = 1 - campo "Valore"

                ProgrammaSilicon(Commessa, Kit, Item, Fw, Key_Id, ID_Hw, tipodev, ID1, ID2, ID3, glob_Standard_FW, glob_IsGolden);
                CaricaArchivi();
                RiposizionaGridCommesse();
            }

            grid_commesse.Enabled = true;
        }

        private void tab_control_Program_Selected(object sender, TabControlEventArgs e)
        {
            CaricaArchivi();
        }

        private void toggle_tipo_device_Libera_CheckedChanged(object sender, EventArgs e)
        {
            AbilitaSchermo();
        }

        private void toggle_tipo_firmware_CheckedChanged(object sender, EventArgs e)
        {
            AbilitaSchermo();
        }

        private void aggiornaArchiviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            CaricaArchivi();

            Cursor.Current = Cursors.Default;
        }
    }
}
