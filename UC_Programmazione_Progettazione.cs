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
using System.IO;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace SmartLineProduction
{
    public partial class UC_Programmazione_Progettazione : MetroFramework.Forms.MetroForm
    {
        public string glob_device = "--device EFR32BG13P733F512GM48";
        //public string glob_device = "--device EFR32MG12P332F1024GL125";


        // Lettura impostazioni
        public static string glob_FW_folder = "";
        public static string glob_IP_printer = "";
        public static bool glob_use_printer = false;
        public static string glob_Commander_path = "";

        //Variabili globali utilizzate
        public bool glob_Program_OK = true;
        public string glob_Commessa = "";
        public string glob_Kit = "";
        public string glob_Device = "";
        public string glob_Codice_FW = "";
        public int glob_FW_Key_ID = 0; //Puntatore al firmware
        public int glob_ID_Cli = 0; // Codice Nominativo del cliente
        public string glob_ID_device = "";

        public string glob_ser_num_read = "";
        public string glob_ser_num_write = "";

        public string glob_tag_1 = string.Empty;
        public string glob_tag_2 = string.Empty;

        //Riposizionamento
        public int glob_selectedrecord = 0;

        //public string glob_codice_kit = "";
        //public string glob_codice_sistema = "";
        //public string glob_codice_fw = "";
        //public string glob_codice_fw_fulltmppath = "";
        public string glob_ID_code = "";
        public string glob_ID_newcode = "";
        public string glob_UNIQUE_ID = "";
        public string glob_Form_ID = "";
        //public string WEB_path_image = @"\\192.168.0.8\ricerca e sviluppo\Documentazione_SL\doc_SL (sinc per web)\";
        public string WEB_path_image = Properties.Settings.Default.Doc_folder;
        //public string glob_ID_cli = "";

        public string glob_Printer_Name = "";
        public string glob_Printer_Tray = "";
        public bool glob_show_evasi = true;

        public string TipoDevice = ""; // P - Palmare / R - Ricevitore

        public UC_Programmazione_Progettazione()
        {
            InitializeComponent();
        }

        private void UC_Programmazione_Progettazione_Load(object sender, EventArgs e)
        {
            // Abilita zone dello schermo
            ds_Prototipi.dt_Tmp_Fw.Clear();
            ds_Prototipi.dt_Tmp_Programma.Clear();
            AbilitaSchermo();

            LeggiConfig();

            CaricaArchivi();
        }

        /// Routines generiche

        private void AbilitaSchermo()
        {
            TipoDevice = "";

            //Verifica pagina attiva
            menu_commesse_nas.Checked = false;
            menu_commesse_vis.Checked = true;
            grid_prototipi.Refresh();
        }

        private void CaricaArchivi()
        {
            ds_Prototipi.dt_Tmp_Programma.Clear();
            AbilitaSchermo();

            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            // TODO: questa riga di codice carica i dati nella tabella 'ds_Prototipi1.Fam_Prod'. È possibile spostarla o rimuoverla se necessario.
            this.fam_ProdTableAdapter.Fill(this.ds_Prototipi.Fam_Prod);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Prototipi.FW_Clienti'. È possibile spostarla o rimuoverla se necessario.
            this.fW_ClientiTableAdapter.Fill(this.ds_Prototipi.FW_Clienti);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Prototipi.Firmware'. È possibile spostarla o rimuoverla se necessario.
            this.firmwareTableAdapter.Fill(this.ds_Prototipi.Firmware);

            // TODO: questa riga di codice carica i dati nella tabella 'ds_Prototipi.SF_LastSerialNumber'. È possibile spostarla o rimuoverla se necessario.
            this.sF_LastSerialNumberTableAdapter.Fill(this.ds_Prototipi.SF_LastSerialNumber);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Prototipi.SerialNumbers'. È possibile spostarla o rimuoverla se necessario.
            this.serialNumbersTableAdapter.Fill(this.ds_Prototipi.SerialNumbers);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Prototipi.SF_Progettazione_SL'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Progettazione_SLTableAdapter.Fill(this.ds_Prototipi.SF_Progettazione_SL);

            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.Firmware'. È possibile spostarla o rimuoverla se necessario.
            this.firmwareTableAdapter.Fill(this.ds_Prototipi.Firmware);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SerialNumbers'. È possibile spostarla o rimuoverla se necessario.
            this.serialNumbersTableAdapter.Fill(this.ds_Prototipi.SerialNumbers);

            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione.SafetyPointRFID'. È possibile spostarla o rimuoverla se necessario.
            this.safetyPointRFIDTableAdapter.Fill(this.ds_Programmazione.SafetyPointRFID);

            //// TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione.SF_LastSerialNumber'. È possibile spostarla o rimuoverla se necessario.
            //this.sF_LastSerialNumberTableAdapter.Fill(this.ds_Prototipi.SF_LastSerialNumber);
            //// TODO: questa riga di codice carica i dati nella tabella 'ds_commander.dt_Firmware'. È possibile spostarla o rimuoverla se necessario.
            //this.firmwareTableAdapter.Fill(this.ds_Prototipi.Firmware);
            //// TODO: questa riga di codice carica i dati nella tabella 'ds_commander1.dt_FW_Clienti'. È possibile spostarla o rimuoverla se necessario.
            //this.fW_ClientiTableAdapter.Fill(this.ds_Prototipi.FW_Clienti);


            SplashDB.Close();
        }

        private void LeggiConfig()
        {
            // Lettura impostazioni
            glob_FW_folder = Properties.Settings.Default.FW_folder;
            glob_Commander_path = Properties.Settings.Default.Commander_path;
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid_prototipi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_prototipi.Columns["grid_prototipi_CommessaDefinizione"].Index)
            {
                //Memorizzo indice riga
                glob_selectedrecord = sFProgettazioneSLBindingSource.Position;

                //Controllo su tipo riga
                DataGridViewRow row = grid_prototipi.Rows[e.RowIndex];
                string Commessa = row.Cells["grid_prototipi_Commessa"].Value.ToString().Trim();
                string Kit = row.Cells["grid_prototipi_ArticoloProgettazione"].Value.ToString().Trim();
                string Item = row.Cells["grid_prototipi_Articolo"].Value.ToString().Trim();

                //Esci se non si programma    
                string tipodevice = Identifica_Tipo_Device(Item);
                if ((tipodevice != "P") && (tipodevice != "R")) return;

                string Fw = "";
                if (row.Cells["grid_prototipi_FW_loading"].Value != null)
                    row.Cells["grid_prototipi_FW_loading"].Value.ToString().Trim();

                if (row.Cells["grid_prototipi_ID"].Value != null)
                    glob_ID_device = row.Cells["grid_prototipi_ID"].Value.ToString().Trim();
                else
                    glob_ID_device = "";

                //Identifica tipo di device
                TipoDevice = Identifica_Tipo_Device(Item);

                if (TipoDevice == "P") // Palmare
                {
                    using (var form = new UC_Prototipo_ID_Palmare(Item))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            glob_Form_ID = form.CodiceID;
                            row.Cells["grid_prototipi_FW_loading"].Value = form.CodiceFW;
                            row.Cells["grid_prototipi_ID"].Value = form.CodiceID;
                            grid_prototipi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        }
                        glob_Form_ID = form.CodiceID;
                    }
                }
                else
                {
                    using (var form = new UC_Prototipo_ID_Ricevitore(Item))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            glob_Form_ID = form.CodiceID;
                            row.Cells["grid_prototipi_FW_loading"].Value = form.CodiceFW;
                            row.Cells["grid_prototipi_ID"].Value = form.CodiceID;
                            grid_prototipi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        }
                        glob_Form_ID = form.CodiceID;
                    }

                    grid_prototipi.Refresh();
                }
            }

            if (e.ColumnIndex == grid_prototipi.Columns["grid_prototipi_CommessaProgramma"].Index)
            {
                //Controllo su tipo riga
                DataGridViewRow row = grid_prototipi.Rows[e.RowIndex];
                if ((row.Cells["grid_prototipi_FW_loading"].Value == null) || (row.Cells["grid_prototipi_ID"].Value == null))
                {
                    MessageBox.Show("Impossibile proseguire! \nNon è stato definito il firmware oppure l'ID!");
                    return;
                }

                /////////////////////////////////////////
                // Puntatore su tabella FIRMWARE       //
                /////////////////////////////////////////
                DataView dv = new DataView(ds_Prototipi.Firmware);
                string filtro = "SW_Code = " + "'" + row.Cells["grid_prototipi_FW_loading"].Value.ToString() + "'" + " AND SW_Obsolete_ver = false";
                dv.RowFilter = filtro;
                foreach (DataRowView drv in dv)
                {
                    glob_FW_Key_ID = Convert.ToInt32(drv["Id"]);
                }


                /////////////////////////////////////////
                // Riempio le variabili che mi servono //
                /////////////////////////////////////////

                glob_Program_OK = true;
                glob_Commessa = row.Cells["grid_prototipi_Commessa"].Value.ToString().Trim();
                glob_Kit = row.Cells["grid_prototipi_ArticoloProgettazione"].Value.ToString().Trim();
                glob_Device = row.Cells["grid_prototipi_Articolo"].Value.ToString().Trim();
                glob_Codice_FW = row.Cells["grid_prototipi_FW_loading"].Value.ToString().Trim();
                glob_ID_Cli = Convert.ToInt32(row.Cells["grid_prototipi_CodAnagrafico"].Value);
                glob_ID_device = row.Cells["grid_prototipi_ID"].Value.ToString().Trim();
                glob_FW_Key_ID = glob_FW_Key_ID; //trovata nel passaggio precedente

                ds_Prototipi.dt_Tmp_Programma.Clear();
                ds_Prototipi.dt_TMP_Firmware.Clear();

                AggiungiRigaProg(glob_Commessa, glob_Kit, glob_Device, glob_Codice_FW, glob_FW_Key_ID, glob_ID_device);

                ProgrammaChip();
            }
        }

        private void AggiornaSN(string Commessa, string Kit, string Item, int fw_key_id, string nome_fw_full, string ID_Hw, string serial_read, string serial_write, int ID_Cli)
        {
            // Recupero Codice Firmware
            DataRow getRev = ds_Prototipi.Firmware.Rows.Find(fw_key_id);
            string Fw_Rev = getRev["SW_Revisione"].ToString();

            // Verifica se nuovo SN o già esistente
            bool newrecord = false;
            string sel = "Ser_ReadSerial = " + "'" + serial_read + "'";
            DataRow[] result = ds_Prototipi.SerialNumbers.Select(sel);
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
                serialNumbersBindingSource.EndEdit();
                serialNumbersTableAdapter.Update(this.ds_Prototipi.SerialNumbers);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Table 'SerialNumbers' - Update failed");
            }

            DataRow newrow = ds_Prototipi.SerialNumbers.NewRow();
            newrow["Ser_Device_ID_Code"] = ID_Hw;
            newrow["Ser_OfficialSerial"] = serial_write;
            newrow["Ser_ReadSerial"] = serial_read;
            newrow["Ser_SW_Code"] = glob_Codice_FW;
            newrow["Ser_Spedito"] = false;
            newrow["Ser_DateProduction"] = DateTime.Now;

            newrow["Ser_Commessa"] = Commessa;
            newrow["Ser_Kit"] = Kit;
            newrow["Ser_ID_Cli"] = ID_Cli;
            newrow["Ser_Device"] = Item;

            //riga modificata il 20/05/2021 per programmare i custom ma consentire di vedere anche gli altri firmware
            //newrow["Ser_SW_Std_Type"] = Fw_isStandard;
            newrow["Ser_SW_Std_Type"] = true;
            newrow["Ser_SW_Code_Rev"] = Fw_Rev;

            try
            {
                ds_Prototipi.SerialNumbers.Rows.Add(newrow);

                serialNumbersTableAdapter.Update(newrow);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Table 'SerialNumbers' - Update failed");
            }
        }

        private void AggiornaFwCliente(int CodAnaCli, string Fw)
        {
            // Verifica se nuovo SN o già esistente
            bool newrecord = false;
            string sel = "Cod_Nominativo = " + CodAnaCli + " AND SW_Code = '" + Fw + "'";
            DataRow[] result = ds_Prototipi.FW_Clienti.Select(sel);
            if (result.Length > 0)
            { newrecord = false; }
            else
            { newrecord = true; }

            if (newrecord)
            {
                string des_ita = "";
                string des_en = "";
                DataView dv_fw = new DataView(ds_Prototipi.Firmware);
                dv_fw.RowFilter = "SW_Code = " + "'" + Fw + "'";
                if (dv_fw != null)
                {
                    des_ita = dv_fw[0]["SW_Descrizione"].ToString();
                    des_en = dv_fw[0]["SW_Descrizione_EN"].ToString();
                }

                DataRow newrow = ds_Prototipi.FW_Clienti.NewRow();
                newrow["Cod_Nominativo"] = CodAnaCli;
                newrow["SW_Code"] = Fw;
                newrow["SW_Des1"] = des_ita;
                newrow["SW_Des2"] = des_en;

                ds_Prototipi.FW_Clienti.Rows.Add(newrow);

                fW_ClientiTableAdapter.Update(newrow);
            }
        }

        private void ProgrammaChip()
        {
            dos_box.Clear();
            ProgrammaSilicon(glob_Commessa, glob_Kit, glob_Device, glob_Codice_FW, glob_FW_Key_ID, glob_ID_device);
            CaricaArchivi();
            RiposizionaGridCommesse();
        }

        private void RiposizionaGridCommesse()
        {
            if (glob_selectedrecord != 0)
            {
                sFProgettazioneSLBindingSource.Position = glob_selectedrecord;
            }
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

        public void Program_Board(string Commessa, string Kit, string Item, int fw_key_id, string nome_fw_full, string nome_fw_boot, string nome_fw_conf, string ID_device)
        {
            //glob_ID_code = ID_Hw;

            dos_box.Clear();

            System.Media.SoundPlayer newplayer = new System.Media.SoundPlayer();
            string newsound = ".\\Windows Notify.wav";
            newplayer.SoundLocation = newsound;
            newplayer.Load();
            newplayer.Play();

            ProcessStartInfo psi = new ProcessStartInfo(@"cmd");
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;
            psi.RedirectStandardInput = true;
            string text_dos = "";

            //Check file BT RTX exists
            string checkBTfile = Properties.Settings.Default.Commander_path + @"\sistematica-dsktp-ble.exe";
            if (!File.Exists(checkBTfile))
            {
                MessageBox.Show("Non è presente il file sistematica-dsktp-ble.exe nella cartella Commander!");
                dos_box.Clear();
                dos_box.Refresh();
                text_dos = "";
                glob_Program_OK = false;
                return;
            }

            //Interrogazione interfaccia
            try
            {
                var proc = Process.Start(psi);

                // Setting "DEBUG MODE"
                proc.StandardInput.WriteLine(Properties.Settings.Default.Commander_path + @"\commander.exe adapter dbgmode OUT");

                // La riga sottostante è da verificare
                proc.StandardInput.WriteLine(Properties.Settings.Default.Commander_path + @"\commander.exe device info " + glob_device);
                proc.StandardInput.WriteLine(Properties.Settings.Default.Commander_path + @"\commander.exe --version");
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
                    return;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
            catch (Exception ex)
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
                        //lab_PartNumber.Text = linea_PN.Substring(17);
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
                        glob_ser_num_read = linea_ID.Substring(17, 16);

                        //Doppia versione per nome bluetooth
                        if (glob_ser_num_write.Count() == 4)
                        {
                            glob_ser_num_write = ConvertiID(glob_ser_num_read);
                        }
                        else
                        {
                        }
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
                        //lab_SN.Text = linea_SN.Substring(23, 9);
                        break;
                    }
                }
            }

            //Cancellazione (Versione con Tommaso)
            try
            {
                var proc = Process.Start(psi);

                string programstring = Properties.Settings.Default.Commander_path + @"\commander.exe device masserase " + glob_device;
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
                    return;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
            catch (Exception ex)
            {
            }

            //Inserimento firmware (boot_ Versione con Tommaso)
            try
            {
                var proc = Process.Start(psi);

                string programstring = Properties.Settings.Default.Commander_path + @"\commander.exe flash " + '"' + nome_fw_boot + '"' + " --address 0x0 " + glob_device;
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
                    return;
                }
                if (text_dos.Contains("ERROR: Verification failed!"))
                {
                    MessageBox.Show("La verifica ha riscontrato un problema!");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
            catch (Exception ex)
            {
            }

            //Verifica (full_ Versione con Eugeniu)
            try
            {
                var proc = Process.Start(psi);

                //string verifyprogramstring = Properties.Settings.Default.Commander_path + @"\commander.exe verify " + glob_codice_fw_fulltmppath + " " + glob_device;
                string verifyprogramstring = Properties.Settings.Default.Commander_path + @"\commander.exe verify " + '"' + nome_fw_boot + '"' + " " + glob_device;
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
                    return;
                }
                if (text_dos.Contains("ERROR: Verification failed!"))
                {
                    MessageBox.Show("La verifica ha riscontrato un problema!");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return;
                }

                if (text_dos.Contains("DONE"))
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    string sound = ".\\tada.wav";
                    player.SoundLocation = sound;
                    player.Load();
                    player.Play();
                }
                else
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    string sound = ".\\Yamaha.wav";
                    player.SoundLocation = sound;
                    player.Load();
                    player.Play();
                    glob_Program_OK = false;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
            catch (Exception ex)
            {
            }

            //Inserimento firmware (boot_ Versione con Tommaso)
            try
            {
                var proc = Process.Start(psi);

                string programstring = Properties.Settings.Default.Commander_path + @"\commander.exe flash " + '"' + nome_fw_conf + '"' + " --address 0x0 " + glob_device;
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
                    return;
                }
                if (text_dos.Contains("ERROR: Verification failed!"))
                {
                    MessageBox.Show("La verifica ha riscontrato un problema!");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
            catch (Exception ex)
            {
            }

            //Verifica (full_ Versione con Eugeniu)
            try
            {
                var proc = Process.Start(psi);

                //string verifyprogramstring = Properties.Settings.Default.Commander_path + @"\commander.exe verify " + glob_codice_fw_fulltmppath + " " + glob_device;
                string verifyprogramstring = Properties.Settings.Default.Commander_path + @"\commander.exe verify " + '"' + nome_fw_conf + '"' + " " + glob_device;
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
                    return;
                }
                if (text_dos.Contains("ERROR: Verification failed!"))
                {
                    MessageBox.Show("La verifica ha riscontrato un problema!");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return;
                }

                if (text_dos.Contains("DONE"))
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    string sound = ".\\tada.wav";
                    player.SoundLocation = sound;
                    player.Load();
                    player.Play();
                }
                else
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    string sound = ".\\Yamaha.wav";
                    player.SoundLocation = sound;
                    player.Load();
                    player.Play();
                    glob_Program_OK = false;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
            catch (Exception ex)
            {
            }

            //Scrittura ID - I parte
            try
            {
                string coppia_1 = "";
                string coppia_2 = "";

                coppia_1 = ID_device.Substring(0, 2);
                coppia_2 = ID_device.Substring(2, 2);

                var proc = Process.Start(psi);

                //string verifyprogramstring = Properties.Settings.Default.Path_URL_Commander + @"\commander.exe flash --patch 0x0fe00000:0x0068:2" + " " + device;
                string verifyprogramstring = Properties.Settings.Default.Commander_path + @"\commander.exe flash --patch 0x0fe00000:0x" + coppia_2 + coppia_1 + ":2" + " " + glob_device;

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
                    return;
                }
                if (text_dos.Contains("ERROR: Verification failed!"))
                {
                    MessageBox.Show("La verifica ha riscontrato un problema!");
                    dos_box.Clear();
                    dos_box.Refresh();
                    text_dos = "";
                    glob_Program_OK = false;
                    return;
                }

                if (text_dos.Contains("DONE"))
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    string sound = ".\\tada.wav";
                    player.SoundLocation = sound;
                    player.Load();
                    player.Play();
                }
                else
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    string sound = ".\\Yamaha.wav";
                    player.SoundLocation = sound;
                    player.Load();
                    player.Play();
                    glob_Program_OK = false;
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
            catch (Exception ex)
            {
            }

            //Scrittura ID - II  parte
            if (ID_device.Length == 16)
            {
                try
                {
                    string coppia_1 = ID_device.Substring(0, 2);
                    string coppia_2 = ID_device.Substring(2, 2);
                    string coppia_3 = ID_device.Substring(4, 2);
                    string coppia_4 = ID_device.Substring(6, 2);
                    string coppia_5 = ID_device.Substring(8, 2);
                    string coppia_6 = ID_device.Substring(10, 2);
                    string coppia_7 = ID_device.Substring(12, 2);
                    string coppia_8 = ID_device.Substring(14, 2);

                    var proc = Process.Start(psi);

                    string verifyprogramstring = "";
                    if (ID_device.Length == 16)
                    {
                        verifyprogramstring = Properties.Settings.Default.Commander_path + @"\commander.exe flash --patch 0x0FE007F0:0x" + coppia_8 + coppia_7 + coppia_6 + coppia_5 + coppia_4 + coppia_3 + ":6" + " " + glob_device;
                    }
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
                        return;
                    }
                    if (text_dos.Contains("ERROR: Verification failed!"))
                    {
                        MessageBox.Show("La verifica ha riscontrato un problema!");
                        dos_box.Clear();
                        dos_box.Refresh();
                        text_dos = "";
                        glob_Program_OK = false;
                        return;
                    }

                    if (text_dos.Contains("DONE"))
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        string sound = ".\\tada.wav";
                        player.SoundLocation = sound;
                        player.Load();
                        player.Play();
                    }
                    else
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        string sound = ".\\Yamaha.wav";
                        player.SoundLocation = sound;
                        player.Load();
                        player.Play();
                        glob_Program_OK = false;
                    }

                    dos_box.SelectionStart = dos_box.Text.Length;
                    dos_box.ScrollToCaret();
                }
                catch (Exception ex)
                {
                }

            }

            //////////////////////////////////////////////////////////////////////////
            //Aggiornamento RTC
            //////////////////////////////////////////////////////////////////////////
            if (TipoDevice == "R")
            {
                bool success = false;
                int retry = 0;

                while (!success && retry < 3)
                {
                    try
                    {
                        var proc = Process.Start(psi);

                        string verifyprogramstring = "";

                        verifyprogramstring = Properties.Settings.Default.Commander_path + @"\sistematica-dsktp-ble.exe " + ID_device;

                        proc.StandardInput.WriteLine(verifyprogramstring);
                        proc.StandardInput.WriteLine("exit");

                        text_dos = proc.StandardOutput.ReadToEnd();
                        dos_box.Text = dos_box.Text + text_dos + "\n======================================================================" + Environment.NewLine;

                        //Analizza risultati
                        int BTresult = -1;
                        if (text_dos.Contains("RESULT_0")) { BTresult = 0; }
                        if (text_dos.Contains("RESULT_1")) { BTresult = 1; }
                        if (text_dos.Contains("RESULT_2")) { BTresult = 2; }
                        if (text_dos.Contains("RESULT_3")) { BTresult = 3; }
                        if (text_dos.Contains("RESULT_4")) { BTresult = 4; }
                        if (text_dos.Contains("RESULT_5")) { BTresult = 5; }
                        if (text_dos.Contains("RESULT_6")) { BTresult = 6; }

                        //var lastLine = text_dos.Split('\n').Last();
                        switch (BTresult)
                        {
                            case 0:
                                success = true;
                                break;
                            case 1:
                                MessageBox.Show("Bluetooth non abilitato!");
                                dos_box.Clear();
                                dos_box.Refresh();
                                text_dos = "";
                                glob_Program_OK = false;
                                break;
                            case 2:
                                MessageBox.Show("Device non trovato!");
                                dos_box.Clear();
                                dos_box.Refresh();
                                text_dos = "";
                                glob_Program_OK = false;
                                break;
                            case 3:
                                MessageBox.Show("Errore di connessione!");
                                dos_box.Clear();
                                dos_box.Refresh();
                                text_dos = "";
                                glob_Program_OK = false;
                                break;
                            case 4:
                                MessageBox.Show("Errore di scrittura RTC!");
                                dos_box.Clear();
                                dos_box.Refresh();
                                text_dos = "";
                                glob_Program_OK = false;
                                break;
                            case 5:
                                MessageBox.Show("Errore nella ricerca dei servizi BT!");
                                dos_box.Clear();
                                dos_box.Refresh();
                                text_dos = "";
                                glob_Program_OK = false;
                                break;
                            case 6:
                                MessageBox.Show("Errore nella ricerca delle caratteristiche BT!");
                                dos_box.Clear();
                                dos_box.Refresh();
                                text_dos = "";
                                glob_Program_OK = false;
                                break;
                        }

                        dos_box.SelectionStart = dos_box.Text.Length;
                        dos_box.ScrollToCaret();
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

            //////////////////////////////////////////////////////////////////////////
            //Scrittura TAG
            //////////////////////////////////////////////////////////////////////////

            glob_tag_1 = string.Empty;
            glob_tag_2 = string.Empty;

            if ((TipoDevice == "P") && 
                ((glob_Device.Substring(0, 6) == "XPDEET") || (glob_Device.Substring(0, 3) == "XET")))
            {
                UC_ConfirmTAG uC_ConfirmTAG = new UC_ConfirmTAG();
                if (uC_ConfirmTAG.ShowDialog() == DialogResult.Cancel)
                    return;

                glob_tag_1 = uC_ConfirmTAG.tag_1;
                glob_tag_2 = uC_ConfirmTAG.tag_2;

                //Scrittura TAG 1
                try
                {
                    string coppia_1 = glob_tag_1.Substring(0, 2);
                    string coppia_2 = glob_tag_1.Substring(3, 2);
                    string coppia_3 = glob_tag_1.Substring(6, 2);
                    string coppia_4 = glob_tag_1.Substring(9, 2);
                    string coppia_5 = glob_tag_1.Substring(12, 2);
                    string coppia_6 = glob_tag_1.Substring(15, 2);
                    string coppia_7 = glob_tag_1.Substring(18, 2);
                    string coppia_8 = glob_tag_1.Substring(21, 2);

                    var proc = Process.Start(psi);

                    string verifyprogramstring = "";
                    if (ID_device.Length == 16)
                    {
                        verifyprogramstring = Properties.Settings.Default.Commander_path + @"\commander.exe flash --patch 0x0FE007E0:0x" +
                            coppia_8 + coppia_7 + coppia_6 + coppia_5 + coppia_4 + coppia_3 + coppia_2 + coppia_1 + ":8" + " " + glob_device;
                    }
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
                        return;
                    }
                    if (text_dos.Contains("ERROR: Verification failed!"))
                    {
                        MessageBox.Show("La verifica ha riscontrato un problema!");
                        dos_box.Clear();
                        dos_box.Refresh();
                        text_dos = "";
                        glob_Program_OK = false;
                        return;
                    }

                    if (text_dos.Contains("DONE"))
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        string sound = ".\\tada.wav";
                        player.SoundLocation = sound;
                        player.Load();
                        player.Play();
                    }
                    else
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        string sound = ".\\Yamaha.wav";
                        player.SoundLocation = sound;
                        player.Load();
                        player.Play();
                        glob_Program_OK = false;
                    }

                    dos_box.SelectionStart = dos_box.Text.Length;
                    dos_box.ScrollToCaret();
                }
                catch (Exception ex)
                {
                }

                //Scrittura TAG 2
                try
                {
                    string coppia_9 = glob_tag_2.Substring(0, 2);
                    string coppia_10 = glob_tag_2.Substring(3, 2);
                    string coppia_11 = glob_tag_2.Substring(6, 2);
                    string coppia_12 = glob_tag_2.Substring(9, 2);
                    string coppia_13 = glob_tag_2.Substring(12, 2);
                    string coppia_14 = glob_tag_2.Substring(15, 2);
                    string coppia_15 = glob_tag_2.Substring(18, 2);
                    string coppia_16 = glob_tag_2.Substring(21, 2);

                    var proc = Process.Start(psi);

                    string verifyprogramstring = "";
                    if (ID_device.Length == 16)
                    {
                        verifyprogramstring = Properties.Settings.Default.Commander_path + @"\commander.exe flash --patch 0x0FE007E8:0x" +
                            coppia_16 + coppia_15 + coppia_14 + coppia_13 + coppia_12 + coppia_11 + coppia_10 + coppia_9 + ":8" + " " + glob_device;
                    }
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
                        return;
                    }
                    if (text_dos.Contains("ERROR: Verification failed!"))
                    {
                        MessageBox.Show("La verifica ha riscontrato un problema!");
                        dos_box.Clear();
                        dos_box.Refresh();
                        text_dos = "";
                        glob_Program_OK = false;
                        return;
                    }

                    if (text_dos.Contains("DONE"))
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        string sound = ".\\tada.wav";
                        player.SoundLocation = sound;
                        player.Load();
                        player.Play();
                    }
                    else
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        string sound = ".\\Yamaha.wav";
                        player.SoundLocation = sound;
                        player.Load();
                        player.Play();
                        glob_Program_OK = false;
                    }

                    dos_box.SelectionStart = dos_box.Text.Length;
                    dos_box.ScrollToCaret();
                }
                catch (Exception ex)
                {
                }

                //Scrittura AREA DI MEMORIA per chiusura programmazione
                try
                {
                    string chiusura_1 = "11";
                    string chiusura_2 = "22";
                    string chiusura_3 = "33";
                    string chiusura_4 = "44";

                    var proc = Process.Start(psi);

                    string verifyprogramstring = "";
                    if (ID_device.Length == 16)
                    {
                        verifyprogramstring = Properties.Settings.Default.Commander_path + @"\commander.exe flash --patch 0x0FE007F8:0x" +
                            chiusura_4 + chiusura_3 + chiusura_2 + chiusura_1 + ":4" + " " + glob_device;
                    }
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
                        return;
                    }
                    if (text_dos.Contains("ERROR: Verification failed!"))
                    {
                        MessageBox.Show("La verifica ha riscontrato un problema!");
                        dos_box.Clear();
                        dos_box.Refresh();
                        text_dos = "";
                        glob_Program_OK = false;
                        return;
                    }

                    if (text_dos.Contains("DONE"))
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        string sound = ".\\tada.wav";
                        player.SoundLocation = sound;
                        player.Load();
                        player.Play();
                    }
                    else
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        string sound = ".\\Yamaha.wav";
                        player.SoundLocation = sound;
                        player.Load();
                        player.Play();
                        glob_Program_OK = false;
                    }

                    dos_box.SelectionStart = dos_box.Text.Length;
                    dos_box.ScrollToCaret();
                }
                catch (Exception ex)
                {
                }

            }
            //////////////////////////////////////////////////////////////////////////

            if (glob_Program_OK)
            {
                PrintLabel(ID_device);
            }
        }

        private void PrintLabel(string Item)
        {
            //Stampa Etichetta
            GVar.PrintMask_String = glob_ser_num_write;
            //GVar.PrintMask_WarningPic = false;
            GVar.PrintMask_Firmware = glob_Codice_FW;
            if (!GFunctions.PrintMask()) { MessageBox.Show("Riscontrato problema sulla stampante! Verificare connessione!"); }
        }

        private bool AggiungiRigaProg(string Commessa, string Kit, string Item, string cod_fw, int fw_key_id, string ID_Hw)
        {
            DataRow dr = ds_Prototipi.dt_Tmp_Programma.NewRow();
            dr["tmp_prog_commessa"] = Commessa;
            dr["tmp_prog_codart_kit"] = Kit;
            dr["tmp_prog_codart_item"] = Item;
            dr["tmp_prog_codart_fw"] = cod_fw;
            dr["tmp_fw_key_id"] = fw_key_id;
            dr["tmp_ID_Hardware"] = ID_Hw;
            ds_Prototipi.dt_Tmp_Programma.Rows.Add(dr);

            return true;
        }

        private string ConvertiID(string ID)
        {
            string id_write = "";
            id_write = glob_ID_code;
            id_write = id_write + ID.Substring(0, 6) + ID.Substring(10, 6);
            return id_write;
        }

        private string Identifica_Tipo_Device(string local_device)
        {
            TipoDevice = "";

            famProdBindingSource.MoveFirst();
            foreach (DataRowView famprodRow in famProdBindingSource)
            {
                // Verifica che ci sia un alias presente
                if (famprodRow["Fam_Alias_Progettazione"].ToString() == "")
                    continue;

                int len_alias = famprodRow["Fam_Alias_Progettazione"].ToString().Length;
                int len_dev = famprodRow["Fam_Prefix"].ToString().Length;

                if ((local_device.Substring(0, len_alias) == famprodRow["Fam_Alias_Progettazione"].ToString()) || (local_device.Substring(0, len_dev) == famprodRow["Fam_Prefix"].ToString()))
                {
                    TipoDevice = famprodRow["Fam_Tipo"].ToString();
                    break;
                }
            }

            return TipoDevice;
        }

        private void AggiornaSafetyPointRfid(string Commessa, string bt_device, string tag1, string tag2)
        {
            // Prima ricerca - pulizia per UUID 1
             string filtro = "Rfid_UUID = " + "'" + tag1 + "'";
            safetyPointRFIDBindingSource.Filter = filtro;
            foreach (DataRowView tagRow in safetyPointRFIDBindingSource)
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
                        this.safetyPointRFIDBindingSource.EndEdit();
                        this.safetyPointRFIDTableAdapter.Update(this.ds_Programmazione.SafetyPointRFID);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Table 'SafetyPointRfid' - Update failed");
                    }
                }
            }

            // Seconda ricerca - pulizia per UUID 2
            filtro = "Rfid_UUID = " + "'" + tag2 + "'";
            safetyPointRFIDBindingSource.Filter = filtro;
            foreach (DataRowView tagRow in safetyPointRFIDBindingSource)
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
                        this.safetyPointRFIDBindingSource.EndEdit();
                        this.safetyPointRFIDTableAdapter.Update(this.ds_Programmazione.SafetyPointRFID);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Table 'SafetyPointRfid' - Update failed");
                    }
                }
            }

            // Terza ricerca - pulizia per codice device
            filtro = "Rfid_Ser_OfficialSerial = " + "'" + bt_device + "'";
            safetyPointRFIDBindingSource.Filter = filtro;
            foreach (DataRowView tagRow in safetyPointRFIDBindingSource)
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
                        this.safetyPointRFIDBindingSource.EndEdit();
                        this.safetyPointRFIDTableAdapter.Update(this.ds_Programmazione.SafetyPointRFID);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Table 'SafetyPointRfid' - Update failed");
                    }
                }
            }

            //Scrittura - Tag 1
            filtro = "Rfid_UUID = " + "'" + tag1 + "'";
            safetyPointRFIDBindingSource.Filter = filtro;
            foreach (DataRowView tag1Row in safetyPointRFIDBindingSource)
            {
                tag1Row["Rfid_Ser_OfficialSerial"] = bt_device;
                string oldcontent = tag1Row["Rfid_Note"].ToString();
                oldcontent = oldcontent + " - " + Commessa + ": Palmare " + bt_device;
                tag1Row["Rfid_Note"] = oldcontent;
                try
                {
                    Validate();
                    this.safetyPointRFIDBindingSource.EndEdit();
                    this.safetyPointRFIDTableAdapter.Update(this.ds_Programmazione.SafetyPointRFID);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Table 'SafetyPointRfid' - Update failed");
                }
            }

            //Scrittura - Tag 2
            filtro = "Rfid_UUID = " + "'" + tag2 + "'";
            safetyPointRFIDBindingSource.Filter = filtro;
            foreach (DataRowView tag2Row in safetyPointRFIDBindingSource)
            {
                tag2Row["Rfid_Ser_OfficialSerial"] = bt_device;
                string oldcontent = tag2Row["Rfid_Note"].ToString();
                oldcontent = oldcontent + " - " + Commessa + ": Palmare " + bt_device;
                tag2Row["Rfid_Note"] = oldcontent;
                try
                {
                    Validate();
                    this.safetyPointRFIDBindingSource.EndEdit();
                    this.safetyPointRFIDTableAdapter.Update(this.ds_Programmazione.SafetyPointRFID);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Table 'SafetyPointRfid' - Update failed");
                }
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////
        // Routine di programmazione
        /////////////////////////////////////////////////////////////////////////////////////////

        private bool ProgrammaSilicon(string Commessa, string Kit, string Item, string cod_fw, int fw_key_id, string ID_Hw)
        {
            string nome_fw_full = "";
            string nome_fw_boot = "";
            string nome_fw_conf = "";

            nome_fw_full = glob_FW_folder + @"\" + cod_fw + @"\" + "full_" + cod_fw + ".s37";
            nome_fw_boot = glob_FW_folder + @"\" + cod_fw + @"\" + "boot_" + cod_fw + ".s37";
            nome_fw_conf = glob_FW_folder + @"\" + cod_fw + @"\" + "conf_" + cod_fw + ".s37";

            //Creazione nuovo codice Flash
            glob_ser_num_write = "";
            int LastNumber = TrovaLastProgr(ID_Hw) + 1;
            string strLastNumber = LastNumber.ToString();
            strLastNumber = strLastNumber.PadLeft(8, '0');
            string anno = Convert.ToString(DateTime.Now.Year);
            glob_ser_num_write = ID_Hw + anno + strLastNumber;
            /////////////////////////////////////////////////

            glob_Program_OK = true;
            Program_Board(glob_Commessa, glob_Kit, glob_Device, glob_FW_Key_ID, nome_fw_full, nome_fw_boot, nome_fw_conf, glob_ser_num_write);           //nuovo sistema

            if (glob_Program_OK)
            {
                AggiornaSN(glob_Commessa, glob_Kit, glob_Device, glob_FW_Key_ID, nome_fw_full, ID_Hw, glob_ser_num_read, glob_ser_num_write, glob_ID_Cli);
                AggiornaFwCliente(glob_ID_Cli, glob_Codice_FW);
                AggiornaSafetyPointRfid(glob_Commessa, glob_ser_num_write, glob_tag_1, glob_tag_2);
            }

            return true;
        }

        private void aggiornaArchiviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            CaricaArchivi();

            Cursor.Current = Cursors.Default;
        }

        private void grid_prototipi_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ((e.ColumnIndex == grid_prototipi.Columns["grid_prototipi_CommessaDefinizione"].Index) /*&& String.IsNullOrEmpty((string)e.FormattedValue)*/)
                {
                    string item = grid_prototipi.Rows[e.RowIndex].Cells["grid_prototipi_Articolo"].FormattedValue.ToString();
                    string tipo_item = Identifica_Tipo_Device(item);
                    if ((tipo_item != "P") && (tipo_item != "R"))
                    {
                        Rectangle newRect = new Rectangle(e.CellBounds.X + 1, e.CellBounds.Y + 1, e.CellBounds.Width - 4, e.CellBounds.Height - 4);
                        using (Brush gridBrush = new SolidBrush(this.grid_prototipi.GridColor), backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                        {
                            using (Pen gridLinePen = new Pen(gridBrush))
                            {
                                // Erase the cell.
                                e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                                // Draw the grid lines (only the right and bottom lines;
                                // DataGridView takes care of the others).
                                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
                                e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
                                e.CellBounds.Bottom - 1);
                                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
                                e.CellBounds.Top, e.CellBounds.Right - 1,
                                e.CellBounds.Bottom);
                                e.Handled = true;
                            }
                        }
                    }
                }
                if ((e.ColumnIndex == grid_prototipi.Columns["grid_prototipi_CommessaProgramma"].Index) /*&& String.IsNullOrEmpty((string)e.FormattedValue)*/)
                {
                    string item = grid_prototipi.Rows[e.RowIndex].Cells["grid_prototipi_Articolo"].FormattedValue.ToString();
                    string tipo_item = Identifica_Tipo_Device(item);
                    if ((tipo_item != "P") && (tipo_item != "R"))
                    {

                        Rectangle newRect = new Rectangle(e.CellBounds.X + 1, e.CellBounds.Y + 1, e.CellBounds.Width - 4, e.CellBounds.Height - 4);
                        using (Brush gridBrush = new SolidBrush(this.grid_prototipi.GridColor), backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                        {
                            using (Pen gridLinePen = new Pen(gridBrush))
                            {
                                // Erase the cell.
                                e.Graphics.FillRectangle(backColorBrush, e.CellBounds);
                                // Draw the grid lines (only the right and bottom lines;
                                // DataGridView takes care of the others).
                                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
                                e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
                                e.CellBounds.Bottom - 1);
                                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
                                e.CellBounds.Top, e.CellBounds.Right - 1,
                                e.CellBounds.Bottom);
                                e.Handled = true;
                            }
                        }
                    }
                }
            }
        }

    }
}
