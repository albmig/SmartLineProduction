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
using System.Diagnostics;

namespace SmartLineProduction
{
    public partial class UC_Programmazione_Clona : MetroFramework.Forms.MetroForm
    {
        public static string qr_read_device = "";                               // la lettura "pura" del barcode
        public static string qr_sn = "";                                        // serial number del barcode (non ID Smartline)
        public static string qr_SistematicaSN = "";                             // serial number del barcode (non ID Smartline)
        public static string qr_ID = "";                                        // lettura del barcode, può essere codice articolo (classic) o ID Smartline (smartline)
        public static string qr_device = "";                                    // se smartline, contiene l'articolo estrapolato dall'id - se classic, contiene l'articolo letto
        public static string qr_fw = "";                                        // lettura del barcode
        public static string qr_fw_rev = "";                                        // lettura del barcode
        public static string qr_ClassicSmart = "";                              // C Classic - S Smartline
        public static string qr_LottoFornitore = "";                            // da implementare - lettura del lotto sulla scheda
        public static string qr_Commessa = "";                                  // la commessa selezionata
        public static string qr_Kit = "";                                       // il kit selezionato

        public bool glob_Program_OK = true;
        public string glob_device = "--device EFR32BG13P733F512GM48";
        public string glob_tipo_progr = ""; //C-Commessa K-Kit D-Device L-Libera
        public string glob_codice_sistema = "";
        public string glob_ID_code = "";
        public string glob_ID_cli = "";
        public string glob_ser_num_read = "";
        public string glob_ser_num_write = "";
        public static string glob_FW_folder = "";
        public static string glob_Commander_path = "";

        public int glob_LockLevel = 0;

        //Alberto 27/03/2023

        public UC_Programmazione_Clona()
        {
            InitializeComponent();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_Programmazione_Clona_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione.SerialNumbers_Obsolete'. È possibile spostarla o rimuoverla se necessario.
            this.serialNumbers_ObsoleteTableAdapter.Fill(this.ds_Programmazione.SerialNumbers_Obsolete);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione.Firmware'. È possibile spostarla o rimuoverla se necessario.
            this.firmwareTableAdapter.Fill(this.ds_Programmazione.Firmware);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione.SF_LastSerialNumber'. È possibile spostarla o rimuoverla se necessario.
            this.sF_LastSerialNumberTableAdapter.Fill(this.ds_Programmazione.SF_LastSerialNumber);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione.SerialNumbers'. È possibile spostarla o rimuoverla se necessario.
            this.serialNumbersTableAdapter.Fill(this.ds_Programmazione.SerialNumbers);

            LeggiConfig();

            SettaForm();

            this.WindowState = FormWindowState.Maximized;
            tbx_ReadLabel_Device.Focus();
        }

        private void tbx_ReadLabel_Device_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\t' || e.KeyChar == (char)13)
            {
                e.Handled = true;
                qr_read_device = tbx_ReadLabel_Device.Text;
                AnalizzaQrDevice(qr_read_device);
                but_Programma.Focus();
            }
        }

        private void tbx_ReadLabel_Device_Leave(object sender, EventArgs e)
        {
            if ((tbx_ReadLabel_Device.Text != null) && (tbx_ReadLabel_Device.Text != ""))
            {
                qr_read_device = tbx_ReadLabel_Device.Text;
                if (AnalizzaQrDevice(qr_read_device))
                {
                    but_Programma.Focus();
                }
                else
                {
                    MessageBox.Show("Errore grave! Impossibile trovare il numero di serie indicato!");

                    tbx_ReadLabel_Device.Text = string.Empty;
                    tbx_ReadLabel_Device.Focus();
                }
            }
        }

        private bool AnalizzaQrDevice(string letturabarcode)
        {
            int lungSN = letturabarcode.Length;
            if (lungSN == 16)
            {
                qr_ClassicSmart = "S";
                qr_ID = letturabarcode.Substring(0, 4);
                qr_sn = letturabarcode;

                string filtro = "Ser_OfficialSerial = " + "'" + letturabarcode + "'";
                DataView dv = ds_Programmazione.SerialNumbers.DefaultView;
                dv.RowFilter = filtro;

                if (dv.Count == 0)
                {
                    MessageBox.Show("Errore grave! Impossibile trovare il numero di serie indicato!");
                    return false;
                }
                foreach (DataRowView rowView in dv)
                {
                    qr_device = rowView["Ser_Device"].ToString();
                    qr_fw = rowView["Ser_SW_Code"].ToString();
                    qr_SistematicaSN = rowView["Ser_SN_Prod"].ToString();
                    qr_Commessa = rowView["Ser_Commessa"].ToString();
                    qr_Kit = rowView["Ser_Kit"].ToString();
                }
            }
            else
            {
                return false;
            }

            lab_read_SN.Text = qr_sn;
            lab_read_ID.Text = qr_ID;
            lab_read_Device.Text = qr_device;
            lab_read_FW.Text = qr_fw;
            lab_read_commessa.Text = qr_Commessa;

            this.Refresh();

            return true;
        }

        private void SettaForm()
        {
            //this.ActiveControl = tbx_ReadLabel_Device;

            //var myControl = this.ActiveControl.Name;

            if (this.ActiveControl == null)
            {
                tbx_ReadLabel_Device.Focus();
            }

            lab_read_SN.Text = "";
            lab_read_ID.Text = "";
            lab_read_Device.Text = "";
            lab_read_FW.Text = "";
            tbx_ReadLabel_Device.Text = "";
            lab_read_commessa.Text = "";

            tbx_ReadLabel_Device.Focus();
        }

        private void UC_Programmazione_Clona_Shown(object sender, EventArgs e)
        {
            tbx_ReadLabel_Device.Focus();
        }

        private void but_Programma_Click(object sender, EventArgs e)
        {
            int Key_fw = TrovaFirmware();
            ProgrammaSilicon(qr_Commessa, qr_Kit, qr_device, qr_fw, Key_fw, qr_ID);

            GVar.PrintMask_String = tbx_ReadLabel_Device.Text;
            GVar.PrintMask_Firmware = lab_read_FW.Text;
            //GVar.PrintMask_WarningPic = (bool)this.firmwareTableAdapter.IsCustomPic(lab_read_FW.Text);

            if (!GFunctions.PrintMask()) { MessageBox.Show("Riscontrato problema sulla stampante! Verificare connessione!"); }

            SettaForm();
        }

        private bool ProgrammaSilicon(string Commessa, string Kit, string Item, string cod_fw, int fw_key_id, string ID_Hw)
        {
            string nome_fw_full = "";
            string nome_fw_boot = "";
            string nome_fw_conf = "";

            nome_fw_full = glob_FW_folder + @"\" + cod_fw + @"\" + "full_" + cod_fw + ".s37";
            nome_fw_boot = glob_FW_folder + @"\" + cod_fw + @"\" + "boot_" + cod_fw + ".s37";
            nome_fw_conf = glob_FW_folder + @"\" + cod_fw + @"\" + "conf_" + cod_fw + ".s37";

            Program_Board(qr_Commessa, qr_Kit, qr_device, fw_key_id, nome_fw_full, nome_fw_boot, nome_fw_conf, qr_sn);           //nuovo sistema

            if (glob_Program_OK)
            {
                AggiornaSN(qr_Commessa, qr_Kit, qr_device, fw_key_id, qr_fw, ID_Hw, glob_ser_num_read, qr_read_device, glob_ID_cli);
            }

            return true;
        }

        public void Program_Board(string Commessa, string Kit, string Item, int fw_key_id, string nome_fw_full, string nome_fw_boot, string nome_fw_conf, string ID_Hw)
        {
            glob_ID_code = ID_Hw;

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

            //Download del Firmware
            //GVar.glob_codice_fw_fulltmppath = DownloadFirmware(Fw); //alberto

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
                    text_dos.Contains("ERROR: Could not open J-Link connection."))
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
                        if (ID_Hw.Count() == 4)
                        {
                            glob_ser_num_write = ConvertiID(glob_ser_num_read);
                        }
                        else
                        {
                            glob_ser_num_write = ID_Hw;
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
                    text_dos.Contains("ERROR: Could not open J-Link connection."))
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
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
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
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            {

            }

            //Verifica (full_ Versione con Eugeniu)
            try
            {
                var proc = Process.Start(psi);

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
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
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
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
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
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            {

            }

            //Scrittura ID - I parte
            try
            {
                string coppia_1 = "";
                string coppia_2 = "";

                coppia_1 = glob_ID_code.Substring(0, 2);
                coppia_2 = glob_ID_code.Substring(2, 2);

                var proc = Process.Start(psi);

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
                }

                dos_box.SelectionStart = dos_box.Text.Length;
                dos_box.ScrollToCaret();
            }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            {

            }

            //Scrittura ID - II  parte
            if (glob_ID_code.Length == 16)
            {
                try
                {
                    string coppia_1 = "";
                    string coppia_2 = "";
                    string coppia_3 = "";
                    string coppia_4 = "";
                    string coppia_5 = "";
                    string coppia_6 = "";
                    string coppia_7 = "";
                    string coppia_8 = "";

                    if (glob_ID_code.Length == 16)
                    {
                        coppia_1 = glob_ID_code.Substring(0, 2);
                        coppia_2 = glob_ID_code.Substring(2, 2);
                        coppia_3 = glob_ID_code.Substring(4, 2);
                        coppia_4 = glob_ID_code.Substring(6, 2);
                        coppia_5 = glob_ID_code.Substring(8, 2);
                        coppia_6 = glob_ID_code.Substring(10, 2);
                        coppia_7 = glob_ID_code.Substring(12, 2);
                        coppia_8 = glob_ID_code.Substring(14, 2);
                    }

                    var proc = Process.Start(psi);

                    string verifyprogramstring = "";
                    if (glob_ID_code.Length == 16)
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
        }

        private string ConvertiID(string ID)
        {
            string id_write = "";
            id_write = glob_ID_code;
            id_write = id_write + ID.Substring(0, 6) + ID.Substring(10, 6);
            return id_write;
        }

        private void LeggiConfig()
        {
            // Lettura impostazioni
            glob_FW_folder = Properties.Settings.Default.FW_folder;
            glob_Commander_path = Properties.Settings.Default.Commander_path;
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

        private int TrovaFirmware()
        {
            int key_id = 0;
            string filtro = "SW_Code = " + "'" + qr_fw + "'" + " AND NOT SW_Obsolete_ver";
            DataView dv = new DataView(ds_Programmazione.Firmware);
            dv.RowFilter = filtro;
            foreach (DataRowView drv in dv)
            {
                qr_fw_rev = drv["SW_Revisione"].ToString();
                key_id = (int)drv["Id"];
                break;
            }

            return key_id;
        }

        private void AggiornaSN(string Commessa, string Kit, string Item, int fw_key_id, string nome_fw_full, string ID_Hw, string serial_read, string serial_write, string ID_Cli)
        {
            bool newrecord = false;
            string updated_fw_revisione = "";                  //Ultima revisione aggiornata del firmware
            int record_Id = 0;                                 //Memorizzo l'id del record SerialNumbers
            string record_read_serial = "";                    //Memorizzo il SN presente sul record
            string record_fw_rev = "";                         //Memorizzo la revisione sul record

            //Lettura SerialNumber già presente
            string filtro = "Ser_OfficialSerial = " + "'" + serial_write + "'";
            DataView dv = new DataView(ds_Programmazione.SerialNumbers);
            dv.RowFilter = filtro;
            foreach (DataRowView drv in dv)
            {
                DataRow DROW_SN = (DataRow)drv.Row;

                //Confronta i dati memorizzati 

                record_read_serial = drv["Ser_ReadSerial"].ToString();
                record_fw_rev = drv["Ser_SW_Code_Rev"].ToString();
                record_Id = (int)drv["Id"];
                //Verifico se è cambiata UniqueID della scheda
                if (record_read_serial != serial_read) { newrecord = true; }

                //Verifico se è cambiata la revisione del firmware
                DataView dv_fw = new DataView(ds_Programmazione.Firmware);
                dv_fw.RowFilter = "Id = " + fw_key_id + " AND NOT SW_Obsolete_ver";
                foreach (DataRowView row in dv_fw)
                {
                    updated_fw_revisione = row["SW_Revisione"].ToString();

                    string tipodev = row["SW_TipoDevice"].ToString();
                    if (tipodev == "P") { glob_LockLevel = (int)row["SW_P_Lock"]; }
                    if (tipodev == "R") { glob_LockLevel = (int)row["SW_R_Lock"]; }

                }
                if (updated_fw_revisione != record_fw_rev)
                {
                    MessageBox.Show("Attenzione!\nIl plug radio è stato aggiornato ad una revisione più aggiornata!");
                }

                //Aggiornamento Serial Numbers
                DataRow editrow = ds_Programmazione.SerialNumbers.Rows.Find(record_Id);

                //Definisco comportamento se nuovo record

                if (newrecord)
                {
                    try
                    {
                        DataRow obsrow = ds_Programmazione.SerialNumbers_Obsolete.NewRow();
                        obsrow.BeginEdit();

                        obsrow["Ser_Kit"] = DROW_SN["Ser_Kit"];
                        obsrow["Ser_ID_Cli"] = DROW_SN["Ser_ID_Cli"];
                        obsrow["Ser_Device"] = DROW_SN["Ser_Device"];
                        obsrow["Ser_Device_ID_Code"] = DROW_SN["Ser_Device_ID_Code"];
                        obsrow["Ser_OfficialSerial"] = DROW_SN["Ser_OfficialSerial"];
                        obsrow["Ser_ReadSerial"] = DROW_SN["Ser_ReadSerial"];
                        obsrow["Ser_SW_Code"] = DROW_SN["Ser_SW_Code"];
                        obsrow["Ser_SW_Code_Rev"] = DROW_SN["Ser_SW_Code_Rev"];
                        obsrow["Ser_SW_Std_Type"] = DROW_SN["Ser_SW_Std_Type"];
                        obsrow["Ser_SN_prod"] = DROW_SN["Ser_SN_prod"];
                        obsrow["Ser_Commessa"] = DROW_SN["Ser_Commessa"];
                        obsrow["Ser_DateProduction"] = DROW_SN["Ser_DateProduction"];
                        obsrow["Ser_Spedito"] = DROW_SN["Ser_Spedito"];
                        obsrow["Ser_Data_Spedito"] = DROW_SN["Ser_Data_Spedito"];
                        obsrow["Ser_Substition_ID_ReadSerial"] = DROW_SN["Ser_Substition_ID_ReadSerial"];
                        obsrow["Ser_Note"] = DROW_SN["Ser_Note"];
                        obsrow["Ser_ObsoleteFromDate"] = DateTime.Now;
                        obsrow["Ser_LockLevel"] = DROW_SN["Ser_LockLevel"];

                        ds_Programmazione.SerialNumbers_Obsolete.Rows.Add(obsrow);

                        try
                        {
                            this.Validate();
                            this.serialNumbersObsoleteBindingSource.EndEdit();
                            this.serialNumbers_ObsoleteTableAdapter.Update(obsrow);
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("Update failed");
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Update failed");
                    }
                }

                editrow.BeginEdit();
                //Aggiorno i cambiamenti
                if (updated_fw_revisione != record_fw_rev) { editrow["Ser_SW_Code_Rev"] = updated_fw_revisione; }
                if (record_read_serial != serial_read) { editrow["Ser_ReadSerial"] = serial_read; }

                editrow["Ser_DateProduction"] = DateTime.Now;
                editrow["Ser_LockLevel"] = glob_LockLevel;


                editrow.EndEdit();

                try
                {
                    Validate();
                    serialNumbersBindingSource.EndEdit();
                    serialNumbersTableAdapter.Update(editrow);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Update failed");
                }
            }
        }

        private void tog_RistampaLabel_CheckedChanged(object sender, EventArgs e)
        {
            tbx_ReadLabel_Device.Focus();
        }
    }
}
