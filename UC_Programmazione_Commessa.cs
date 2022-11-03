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
    public partial class UC_Programmazione_Commessa : MetroFramework.Forms.MetroForm
    {
        public static string glob_FW_folder = "";

        public static string glob_Commander_path = "";
        public string glob_device = "--device EFR32BG13P733F512GM48";
        //public string glob_device = "--device EFR32MG12P332F1024GL125";
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

        public bool glob_show_evasi = true;
        public int glob_selectedrecord = 0;

        public string glob_tag_1 = string.Empty;
        public string glob_tag_2 = string.Empty;

        public UC_Programmazione_Commessa()
        {
            InitializeComponent();
        }

        private void UC_Programmazione_Commessa_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione.SafetyPointRFID'. È possibile spostarla o rimuoverla se necessario.
            this.safetyPointRFIDTableAdapter.Fill(this.ds_Programmazione.SafetyPointRFID);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.Firmware'. È possibile spostarla o rimuoverla se necessario.
            this.firmwareTableAdapter.Fill(this.ds_Programmazione.Firmware);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SerialNumbers'. È possibile spostarla o rimuoverla se necessario.
            this.serialNumbersTableAdapter.Fill(this.ds_Programmazione.SerialNumbers);

            // Abilita zone dello schermo
            ds_Programmazione.dt_Tmp_Fw.Clear();
            ds_Programmazione.dt_Tmp_Programma.Clear();
            AbilitaSchermo();

            CaricaArchivi();
        }

        /// <summary>
        /// Routines generiche
        /// </summary>
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

        private void CaricaArchivi()
        {
            //ds_commander.dt_Tmp_Fw.Clear();
            ds_Programmazione.dt_Tmp_Programma.Clear();
            dg_dt_tmp_programmazione.Refresh();
            AbilitaSchermo();

            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione.SF_LastSerialNumber'. È possibile spostarla o rimuoverla se necessario.
            this.sF_LastSerialNumberTableAdapter.Fill(this.ds_Programmazione.SF_LastSerialNumber);

            // TODO: questa riga di codice carica i dati nella tabella 'ds_commander.dt_Firmware'. È possibile spostarla o rimuoverla se necessario.
            this.sF_DistinteBasiTableAdapter.Fill(this.ds_SL.SF_DistinteBasi);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_commander.dt_Firmware'. È possibile spostarla o rimuoverla se necessario.
            this.firmwareTableAdapter.Fill(this.ds_Programmazione.Firmware);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_commander1.SF_Articoli'. È possibile spostarla o rimuoverla se necessario.
            this.sF_ArticoliTableAdapter.Fill(this.ds_Programmazione.SF_Articoli);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_commander1.SF_ArticoliToXSWR'. È possibile spostarla o rimuoverla se necessario.
            this.sF_ArticoliToXSWRTableAdapter.Fill(this.ds_Programmazione.SF_ArticoliToXSWR);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_commander1.dt_FW_Clienti'. È possibile spostarla o rimuoverla se necessario.
            this.fW_ClientiTableAdapter.Fill(this.ds_Programmazione.FW_Clienti);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_commander1.SF_Commesse_SL'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Commesse_SLTableAdapter.Fill(this.ds_Programmazione.SF_Commesse_SL);

            SplashDB.Close();
        }

        private void LeggiConfig()
        {
            // Lettura impostazioni
            glob_FW_folder = Properties.Settings.Default.FW_folder;
            glob_Commander_path = Properties.Settings.Default.Commander_path;
        }

        private void grid_commesse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
            glob_selectedrecord = sFCommesseSLBindingSource.Position;

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
                    ds_Programmazione.dt_Tmp_Programma.Clear();
                    ds_SL.dt_TMP_Firmware.Clear();

                    //Ricerca di tutti i device e di tutti i software
                    TrovaFWDeviceCommesse(CommessaShort);
                    TrovaFWDeviceKit(Kit, CommessaLong, CommessaShort, Convert.ToInt32(glob_ID_cli), Kit);

                    //Controllo oggetto per capire che FW mettere
                    ds_SL.dt_TMP_Firmware.DefaultView.Sort = "Livello_FW desc, Cod_FW asc";
                    string tipodevice = Item.Substring(5, 1);
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
                    AggiungiRigaProg(CommessaLong, Kit, Item, Fw, 0, ID);
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
                    DataRow[] result = ds_Programmazione.FW_Clienti.Select(sel);
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

        private void AggiornaFwCliente(string CodAnaCli, string Fw)
        {
            // Verifica se nuovo SN o già esistente
            bool newrecord = false;
            //string sel = "Cod_Nominativo = " + "'" + CodAnaCli + "' AND SW_Code = '" + Fw + "'";
            string sel = "Cod_Nominativo = " + CodAnaCli + " AND SW_Code = '" + Fw + "'";
            DataRow[] result = ds_Programmazione.FW_Clienti.Select(sel);
            if (result.Length > 0)
            { newrecord = false; }
            else
            { newrecord = true; }

            if (newrecord)
            {
                string des_ita = "";
                string des_en = "";
                DataView dv_fw = new DataView(ds_Programmazione.Firmware);
                dv_fw.RowFilter = "SW_Code = " + "'" + Fw + "'";
                if (dv_fw != null)
                {
                    des_ita = dv_fw[0]["SW_Descrizione"].ToString();
                    des_en = dv_fw[0]["SW_Descrizione_EN"].ToString();
                }

                DataRow newrow = ds_Programmazione.FW_Clienti.NewRow();
                newrow["Cod_Nominativo"] = CodAnaCli;
                newrow["SW_Code"] = Fw;
                newrow["SW_Des1"] = des_ita;
                newrow["SW_Des2"] = des_en;

                ds_Programmazione.FW_Clienti.Rows.Add(newrow);

                fW_ClientiTableAdapter.Update(newrow);
            }
        }

        private void TrovaFWDeviceCommesse(string commessashort)
        {
            ds_SL.dt_TMP_Firmware.Clear();

            string filtro = "CommessaShort = " + "'" + commessashort + "'";
            //DataRow[] rows = ds_commander1.SF_Commesse_SL.Select(filtro);

            // Ricerca FW in commesse
            foreach (DataRow rows in ds_Programmazione.SF_Commesse_SL.Select(filtro))
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
            string filtro = "ArticoloComposto = " + "'" + kit + "'" + " AND DataFineValidita = '' AND ArticoloComponente like 'XSWR%'";

            // Ricerca FW in commesse
            foreach (DataRow rows in ds_SL.SF_DistinteBasi.Select(filtro))
            {
                string componente = rows["ArticoloComponente"].ToString().Trim();

                bool isswrP = false;
                bool isswrR = false;

                if (componente.StartsWith("XSWRP")) { isswrP = true; }
                if (componente.StartsWith("XSWRR")) { isswrR = true; }

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

        private bool AggiungiRigaProg(string Commessa, string Kit, string Item, string cod_fw, int fw_key_id, string ID_Hw)
        {
            DataRow dr = ds_Programmazione.dt_Tmp_Programma.NewRow();
            dr["tmp_prog_commessa"] = Commessa;
            dr["tmp_prog_codart_kit"] = Kit;
            dr["tmp_prog_codart_item"] = Item;
            dr["tmp_prog_codart_fw"] = cod_fw;
            dr["tmp_fw_key_id"] = fw_key_id;
            dr["tmp_ID_Hardware"] = ID_Hw;
            ds_Programmazione.dt_Tmp_Programma.Rows.Add(dr);

            return true;
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
            sFCommesseSLBindingSource.Filter = filter;
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

                int Key_Id = Int16.Parse(row.Cells["dg_dt_tmp_progr_FwKeyId"].Value.ToString());
                string ID_Hw = row.Cells["dg_dt_tmp_progr_ID_Hardware"].Value.ToString();
                glob_ID_newcode = ID_Hw;
                ProgrammaSilicon(Commessa, Kit, Item, Fw, Key_Id, ID_Hw);
                CaricaArchivi();
                RiposizionaGridCommesse();
            }

            grid_commesse.Enabled = true;
        }

        private bool ProgrammaSilicon(string Commessa, string Kit, string Item, string cod_fw, int fw_key_id, string ID_Hw)
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
                DataView dv = new DataView(ds_Programmazione.dt_Tmp_Fw);

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

            //Creazione nuovo codice Flash
            string ID_Hw_longversion = "";
            int LastNumber = TrovaLastProgr(ID_Hw) + 1;
            string strLastNumber = LastNumber.ToString();
            strLastNumber = strLastNumber.PadLeft(8, '0');
            string anno = Convert.ToString(DateTime.Now.Year);
            ID_Hw_longversion = ID_Hw + anno + strLastNumber;
            /////////////////////////////////////////////////

            //Program_Board(Commessa, Kit, Item, fw_key_id, nome_fw_full, nome_fw_boot, nome_fw_conf, ID_Hw);                         //vecchio sistema
            glob_Program_OK = true;
            Program_Board(Commessa, Kit, Item, fw_key_id, nome_fw_full, nome_fw_boot, nome_fw_conf, ID_Hw_longversion);           //nuovo sistema

            if (glob_Program_OK)
            {
                if (glob_tipo_progr == "C")
                {
                    AggiornaSN(Commessa, Kit, Item, fw_key_id, nome_fw_full, ID_Hw, glob_ser_num_read, glob_ser_num_write, glob_ID_cli);
                    AggiornaFwCliente(glob_ID_cli, glob_codice_fw);
                    AggiornaSafetyPointRfid(Commessa, glob_ser_num_write, glob_tag_1, glob_tag_2);
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

        public void Program_Board(string Commessa, string Kit, string Item, int fw_key_id, string nome_fw_full, string nome_fw_boot, string nome_fw_conf, string ID_Hw)
        {
            glob_ID_code = ID_Hw;

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

                        //Doppia versione per nome bluetooth
                        if (ID_Hw.Count() == 4)
                        {
                            glob_ser_num_write = ConvertiID(glob_ser_num_read);
                            lab_IDNumber_write.Text = glob_ser_num_write;
                        }
                        else
                        {
                            glob_ser_num_write = ID_Hw;
                            lab_IDNumber_write.Text = glob_ser_num_write;
                        }
                        //ser_num_write = GVar.glob_result_id[0].ToString() + GVar.glob_result_id[1].ToString() + GVar.glob_result_id[2].ToString() + GVar.glob_result_id[3].ToString() +
                        //                lab_IDNumber.Text.Substring(0, 6) + lab_IDNumber.Text.Substring(10, 6);
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
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
                catch (Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
                {

                }

            }


            //////////////////////////////////////////////////////////////////////////
            //Aggiornamento RTC
            //////////////////////////////////////////////////////////////////////////

            string TipoDevice = Item.Substring(5, 1);
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

                        verifyprogramstring = Properties.Settings.Default.Commander_path + @"\sistematica-dsktp-ble.exe " + ID_Hw;

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

            if ((TipoDevice == "P") && (Item.Substring(0, 3) == "XET"))
            {
                UC_ConfirmTAG uC_ConfirmTAG = new UC_ConfirmTAG();
                DialogResult diag = uC_ConfirmTAG.ShowDialog();

                if (diag == DialogResult.Abort)
                {
                    uC_ConfirmTAG.tag_1 = "11:11:11:11:11:11:11";
                    uC_ConfirmTAG.tag_2 = "22:22:22:22:22:22:22";
                }

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
                    if (ID_Hw.Length == 16)
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
                    if (ID_Hw.Length == 16)
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
                    if (ID_Hw.Length == 16)
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

            if (glob_tipo_progr != "L")
            {
                if (glob_Program_OK)
                {
                    PrintLabel(glob_ID_code);
                }
            }
        }

        private void AggiornaSN(string Commessa, string Kit, string Item, int fw_key_id, string nome_fw_full, string ID_Hw, string serial_read, string serial_write, string ID_Cli)
        {
            // Recupero Codice Firmware
            DataView dv = new DataView(ds_Programmazione.dt_Tmp_Fw);
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

                //DataView dv_firmware = new DataView(dt_Firmware_lookupCommesseSLTableAdapter);
                this.dt_Firmware_lookupCommesseSLTableAdapter.FillBy(this.ds_Programmazione.dt_Firmware_lookupCommesseSL, codice_fw);
                DataRowCollection rowCol = this.ds_Programmazione.dt_Firmware_lookupCommesseSL.Rows;
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
            DataRow[] result = ds_Programmazione.SerialNumbers.Select(sel);
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
                serialNumbersTableAdapter.Update(this.ds_Programmazione.SerialNumbers);
            }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            catch (System.Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            {
                MessageBox.Show("Table 'SerialNumbers' - Update failed");
            }

            DataRow newrow = ds_Programmazione.SerialNumbers.NewRow();
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
                ds_Programmazione.SerialNumbers.Rows.Add(newrow);
                serialNumbersTableAdapter.Update(newrow);
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

        private void RiposizionaGridCommesse()
        {
            if (glob_selectedrecord!=0)
            {
                 sFCommesseSLBindingSource.Position = glob_selectedrecord;
            }
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

    }
}
