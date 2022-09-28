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
//using Dymo;
using DYMO.Label.Framework;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace SmartLineProduction
{
    public partial class xxxxUC_Programmazione : MetroFramework.Forms.MetroForm
    {
        public bool glob_edit_config = false;

        public static string glob_FW_folder = "";
        public static string glob_IP_printer = "";
        public static bool glob_use_printer = false;
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
        //public string WEB_path_image = @"\\192.168.0.8\ricerca e sviluppo\Documentazione_SL\doc_SL (sinc per web)\";
        public string WEB_path_image = Properties.Settings.Default.Doc_folder;
        public string glob_tipo_progr = ""; //C-Commessa K-Kit D-Device L-Libera
        public string glob_ID_cli = "";

        public string glob_Printer_Name = "";
        public string glob_Printer_Tray = "";
        public bool glob_show_evasi = true;
        private ILabel _label;

        public xxxxUC_Programmazione()
        {
            InitializeComponent();
        }

        private void nascondiVisualizzaFirmwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tv_FW.Visible)
            {
                tv_FW.Visible = false;
            }
            else
            {
                tv_FW.Visible = true;
            }
        }

        private void UC_Programmazione_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione.SF_LastSerialNumber'. È possibile spostarla o rimuoverla se necessario.
            this.sF_LastSerialNumberTableAdapter.Fill(this.ds_Programmazione.SF_LastSerialNumber);
            //if (glob_use_printer) { SetupLabelWriterSelection(true); }
            if (glob_use_printer) { SetupLabelWriterSelection(); }

            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.Firmware'. È possibile spostarla o rimuoverla se necessario.
            this.firmwareTableAdapter.Fill(this.ds_SL.Firmware);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SerialNumbers'. È possibile spostarla o rimuoverla se necessario.
            this.serialNumbersTableAdapter.Fill(this.ds_SL.SerialNumbers);

            //tab_control_Program.SelectedTab = tab_kit;
            //tab_control_Program.SelectedTab = tab_libera;
            //tab_control_Program.SelectedTab = tab_item;
            tab_control_Program.SelectedTab = tab_commessa;

            //nascondo tabpage
            //tab_control_Program.TabPages.Remove(tab_kit);
            //tab_control_Program.TabPages.Remove(tab_item);

            // Abilita zone dello schermo
            ds_SL.dt_Tmp_Fw.Clear();
            ds_SL.dt_Tmp_Programma.Clear();
            AbilitaSchermo();
            CaricaTreeView();

            CaricaArchivi();
            cb_sceltaCliente.Refresh();
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

            if (glob_edit_config)
            {
                //Entro in fase di modifica
                tb_FW_folder.Enabled = true;
                tb_IP_Printer.Enabled = true;
                tog_Use_printer.Enabled = true;
                tb_Commander_path.Enabled = true;
                but_Edit_Config.Enabled = false;
                but_Save_Config.Enabled = true;
                but_Abort_Config.Enabled = true;
            }
            else
            {
                //Schermo inattivo
                tb_FW_folder.Enabled = false;
                tb_IP_Printer.Enabled = false;
                tog_Use_printer.Enabled = false;
                tb_Commander_path.Enabled = false;
                but_Edit_Config.Enabled = true;
                but_Save_Config.Enabled = false;
                but_Abort_Config.Enabled = false;
            }

            //Verifica pagina attiva
            if (tab_control_Program.SelectedIndex == 2) //Singolo device
            {
                SetFilterDevice();
                lab_device_desart.Text = "";
                lab_device_desestart.Text = "";
                lab_device_codfw.Text = "";
                lab_device_desfw.Text = "";
                lab_device_desestfw.Text = "";
                lab_device_ID.Text = "";
            }

            if (tab_control_Program.SelectedIndex == 3) // tab_libera
            {
                tb_Id_Hardware.Text = "";

                //Gestione tipo device - tab_libera
                if (toggle_tipo_device_Libera.Checked) // Allora è ricevitore
                {
                    lab_tipo_device_palmare.Style = MetroColorStyle.Silver;
                    lab_tipo_device_ricevitore.Style = MetroColorStyle.Red;
                    lab_tipo_device_palmare.FontWeight = MetroLabelWeight.Regular;
                    lab_tipo_device_ricevitore.FontWeight = MetroLabelWeight.Bold;
                    lab_tipo_device_palmare.Refresh();
                    lab_tipo_device_ricevitore.Refresh();
                }
                else //  Allora è palmare
                {
                    lab_tipo_device_palmare.Style = MetroColorStyle.Red;
                    lab_tipo_device_ricevitore.Style = MetroColorStyle.Silver;
                    lab_tipo_device_palmare.FontWeight = MetroLabelWeight.Bold;
                    lab_tipo_device_ricevitore.FontWeight = MetroLabelWeight.Regular;
                    lab_tipo_device_palmare.Refresh();
                    lab_tipo_device_ricevitore.Refresh();
                }

                //Gestione firmware - tab_libera
                if (toggle_tipo_firmware.Checked) // FW Custom
                {
                    lab_fw_standard.Style = MetroColorStyle.Silver;
                    lab_fw_custom.Style = MetroColorStyle.Red;
                    lab_fw_standard.FontWeight = MetroLabelWeight.Regular;
                    lab_fw_custom.FontWeight = MetroLabelWeight.Bold;
                    lab_fw_standard.Refresh();
                    lab_fw_custom.Refresh();
                }
                else //  FW Standard
                {
                    lab_fw_standard.Style = MetroColorStyle.Red;
                    lab_fw_custom.Style = MetroColorStyle.Silver;
                    lab_fw_standard.FontWeight = MetroLabelWeight.Bold;
                    lab_fw_custom.FontWeight = MetroLabelWeight.Regular;
                    lab_fw_standard.Refresh();
                    lab_fw_custom.Refresh();
                }

                string filtro_tmp_fw = "";
                if (!toggle_tipo_device_Libera.Checked) { filtro_tmp_fw = "fw_tipodev = 'P' AND "; }// Palmare
                if (toggle_tipo_device_Libera.Checked) { filtro_tmp_fw = "fw_tipodev = 'R' AND "; }// Ricevitore
                if (!toggle_tipo_firmware.Checked) { filtro_tmp_fw = filtro_tmp_fw + "fw_standcust = 'S'"; }// Standard
                if (toggle_tipo_firmware.Checked) { filtro_tmp_fw = filtro_tmp_fw + "fw_standcust = 'C'"; }// Custom
                DataView tmp_fw_view = new DataView(ds_SL.dt_Tmp_Fw);
                tmp_fw_view.RowFilter = filtro_tmp_fw;
                cb_scelta_fw.DataSource = tmp_fw_view;
                cb_scelta_fw.Refresh();

                TableLayoutColumnStyleCollection styles = this.tbl_Label_ID.ColumnStyles;

                foreach (ColumnStyle style in styles)
                {
                    if (style.SizeType == SizeType.Absolute)
                    {
                        style.SizeType = SizeType.AutoSize;
                    }
                    else if (style.SizeType == SizeType.AutoSize)
                    {
                        style.SizeType = SizeType.Percent;

                        // Set the column width to be a percentage
                        // of the TableLayoutPanel control's width.
                        style.Width = 33;
                    }
                    else
                    {
                        // Set the column width to 50 pixels.
                        style.SizeType = SizeType.Absolute;
                        style.Width = 50;
                    }
                }

            }

            if (tab_control_Program.SelectedIndex == 0) //Commessa
            {
                menu_commesse_nas.Checked = false;
                menu_commesse_vis.Checked = true;
                grid_commesse.Refresh();
            }
        }

        private void CaricaTreeView()
        {
            // Clear All Nodes if Already Exists  
            tv_FW.Nodes.Clear();
            if (glob_FW_folder != "" && Directory.Exists(glob_FW_folder))
                LoadDirectory(glob_FW_folder);
            else
                MessageBox.Show("Select Directory!!");
            tv_FW.Nodes[0].Expand();
        }

        private void CaricaArchivi()
        {
            //ds_commander.dt_Tmp_Fw.Clear();
            ds_SL.dt_Tmp_Programma.Clear();
            dg_dt_tmp_programmazione.Refresh();
            AbilitaSchermo();

            GVar.CloseSplash = false;
            Splash SplashDB = new Splash();
            SplashDB.Show();

            //Caso - Commessa
            if (tab_control_Program.SelectedTab == tab_commessa)
            {
                // TODO: questa riga di codice carica i dati nella tabella 'ds_commander.dt_Firmware'. È possibile spostarla o rimuoverla se necessario.
                this.sF_DistinteBasiTableAdapter.Fill(this.ds_SL.SF_DistinteBasi);
                // TODO: questa riga di codice carica i dati nella tabella 'ds_commander.dt_Firmware'. È possibile spostarla o rimuoverla se necessario.
                this.firmwareTableAdapter.Fill(this.ds_SL.Firmware);
                // TODO: questa riga di codice carica i dati nella tabella 'ds_commander1.SF_Articoli'. È possibile spostarla o rimuoverla se necessario.
                this.sF_ArticoliTableAdapter.Fill(this.ds_SL.SF_Articoli);
                // TODO: questa riga di codice carica i dati nella tabella 'ds_commander1.SF_ArticoliToXSWR'. È possibile spostarla o rimuoverla se necessario.
                this.sF_ArticoliToXSWRTableAdapter.Fill(this.ds_SL.SF_ArticoliToXSWR);
                // TODO: questa riga di codice carica i dati nella tabella 'ds_commander1.dt_FW_Clienti'. È possibile spostarla o rimuoverla se necessario.
                this.fW_ClientiTableAdapter.Fill(this.ds_SL.FW_Clienti);
                // TODO: questa riga di codice carica i dati nella tabella 'ds_commander1.SF_Commesse_SL'. È possibile spostarla o rimuoverla se necessario.
                this.sF_Commesse_SLTableAdapter.Fill(this.ds_SL.SF_Commesse_SL);
            }

            //Caso - Kit
            if (tab_control_Program.SelectedTab == tab_kit)
            {

            }

            //Caso - Device
            if (tab_control_Program.SelectedTab == tab_item)
            {
                // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.Fam_Prod'. È possibile spostarla o rimuoverla se necessario.
                this.fam_ProdTableAdapter.Fill(this.ds_SL.Fam_Prod);

                // TODO: questa riga di codice carica i dati nella tabella 'ds_commander.dt_Firmware'. È possibile spostarla o rimuoverla se necessario.
                this.firmwareTableAdapter.Fill(this.ds_SL.Firmware);
                // TODO: questa riga di codice carica i dati nella tabella 'ds_commander2.SF_AnagraficaClienti'. È possibile spostarla o rimuoverla se necessario.
                this.sF_AnagraficaClientiTableAdapter.Fill(this.ds_SL.SF_AnagraficaClienti);
                sFAnagraficaClientiBindingSource.Sort = "Conto ASC, RAGIONESOCIALE ASC";
                int index = sFAnagraficaClientiBindingSource.Find("CODICE_NOMINATIVO", 1);
                if (index >= 0)
                {
                    sFAnagraficaClientiBindingSource.Position = index;
                }

                // TODO: questa riga di codice carica i dati nella tabella 'ds_commander1.SF_Articoli'. È possibile spostarla o rimuoverla se necessario.
                this.sF_ArticoliTableAdapter.Fill(this.ds_SL.SF_Articoli);
                // TODO: questa riga di codice carica i dati nella tabella 'ds_commander1.SF_ItemDevice_FW_Des'. È possibile spostarla o rimuoverla se necessario.
                this.sF_ItemDevice_FW_DesTableAdapter.Fill(this.ds_SL.SF_ItemDevice_FW_Des);
                // TODO: questa riga di codice carica i dati nella tabella 'ds_commander.SF_Distinct_Item_Fam_Functions'. È possibile spostarla o rimuoverla se necessario.
                this.sF_Distinct_Item_Fam_FunctionsTableAdapter.Fill(this.ds_SL.SF_Distinct_Item_Fam_Functions);
                // TODO: questa riga di codice carica i dati nella tabella 'ds_commander1.SF_Distinct_Item_Fam_Prefix'. È possibile spostarla o rimuoverla se necessario.
                this.sF_Distinct_Item_Fam_PrefixTableAdapter.Fill(this.ds_SL.SF_Distinct_Item_Fam_Prefix);
            }

            //Caso - Programmazione libera
            if (tab_control_Program.SelectedTab == tab_libera)
            {
            }

            SplashDB.Close();
        }

        //private void SetupLabelWriterSelection(bool InitCmb)
        //{
        //    // create DYMO COM objects
        //    DymoAddInClass DymoAddIn = new DymoAddInClass();

        //    // get the objects on the label
        //    if (InitCmb)
        //    {
        //        // clear all items first
        //        LabelWriterCmb.Items.Clear();

        //        string PrtNames = DymoAddIn.GetDymoPrinters();

        //        if (PrtNames != null)
        //        {
        //            // parse the result
        //            int i = PrtNames.IndexOf('|');
        //            while (i >= 0)
        //            {
        //                LabelWriterCmb.Items.Add(PrtNames.Substring(0, i));
        //                PrtNames = PrtNames.Remove(0, i + 1);
        //                i = PrtNames.IndexOf('|');
        //            }
        //            if (PrtNames.Length > 0)
        //                LabelWriterCmb.Items.Add(PrtNames);

        //            PrtNames = DymoAddIn.GetCurrentPrinterName();
        //            if (PrtNames != null)
        //            {
        //                LabelWriterCmb.SelectedIndex = LabelWriterCmb.Items.IndexOf(PrtNames);
        //                glob_Printer_Name = LabelWriterCmb.Text;
        //            }
        //            else
        //                LabelWriterCmb.SelectedIndex = 0;
        //        }
        //    }

        //    // check if selected/current printer is a twin turbo printer
        //    TrayCmb.Enabled = DymoAddIn.IsTwinTurboPrinter(LabelWriterCmb.Text);
        //    if (TrayCmb.Enabled)
        //    {
        //        // show the current tray selection if the printer
        //        // is a twin turbo
        //        switch (DymoAddIn.GetCurrentPaperTray())
        //        {
        //            case 0: // left tray
        //                TrayCmb.SelectedIndex = 0;
        //                break;

        //            case 1: // right tray
        //                TrayCmb.SelectedIndex = 1;
        //                break;

        //            case 2: // auto switch
        //                TrayCmb.SelectedIndex = 2;
        //                break;

        //            default: // tray selection not set, so default to auto switch
        //                TrayCmb.SelectedIndex = 2;
        //                break;
        //        }
        //        //glob_Printer_Tray = TrayCmb.text;
        //    }
        //}

        private bool SetupLabelWriterSelection()
        {
            // clear all items first
            LabelWriterCmb.Items.Clear();

            foreach (IPrinter printer in Framework.GetPrinters())
                LabelWriterCmb.Items.Add(printer.Name);

            if (LabelWriterCmb.Items.Count > 0)
                LabelWriterCmb.SelectedIndex = 0;

            LabelWriterCmb.Enabled = LabelWriterCmb.Items.Count > 0;

            if (LabelWriterCmb.Items.Count>0) { return true; } else { return false; }
        }

        private void LeggiConfig()
        {
            // Lettura impostazioni
            glob_FW_folder = Properties.Settings.Default.FW_folder;
            glob_IP_printer = Properties.Settings.Default.IP_printer;
            glob_use_printer = Properties.Settings.Default.Use_printer;
            glob_Commander_path = Properties.Settings.Default.Commander_path;

            // Assegna le variabili per lo schermo
            tb_FW_folder.Text = glob_FW_folder;
            tb_IP_Printer.Text = glob_IP_printer;
            tog_Use_printer.Checked = glob_use_printer;
            tb_Commander_path.Text = glob_Commander_path;
        }

        private void SetFilterDevice()
        {
            string filter = "";

            if (cb_scelta_Famiglia.Text != "") { filter = "FamDevice = " + "'" + cb_scelta_Famiglia.Text + "'"; }
            sFDistinctItemFamFunctionsBindingSource.Filter = filter;
            sFItemDeviceFWDesBindingSource.Filter = filter;

            if (cb_scelta_Funzioni.Text != "")
            {
                if (filter != "")
                {
                    filter = filter + " AND NumFunzioni = " + "'" + cb_scelta_Funzioni.Text + "'";
                }
                else
                {
                    filter = filter + "NumFunzioni = " + "'" + cb_scelta_Funzioni.Text + "'";
                }
            }
            sFItemDeviceFWDesBindingSource.Filter = filter;
        }

        public void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            //Setting ProgressBar Maximum Value  
            TreeNode tds = tv_FW.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
        }

        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");

            // Loop through them to see files  
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;

                //Aggiungi riga
                string ext = Path.GetExtension(fi.Name);
                string name = Path.GetFileNameWithoutExtension(fi.Name);
                if ((ext == ".s37") && (name.Length >= 15))
                {
                    DataRow dr = ds_SL.dt_Tmp_Fw.NewRow();
                    dr["fw_codfw"] = name;
                    dr["fw_pathfw"] = fi.FullName;
                    dr["fw_prefix"] = name.Substring(0, 4);
                    dr["fw_tipodev"] = name.Substring(4, 1);
                    dr["fw_standcust"] = name.Substring(5, 1);
                    dr["fw_versione"] = name.Substring(6, 6);
                    dr["fw_freq"] = name.Substring(12, 1);
                    int lenname = name.Length;
                    int len = lenname - 6;
                    dr["fw_searchvers"] = name.Substring(6, len);
                    ds_SL.dt_Tmp_Fw.Rows.Add(dr);
                }
                ///////////////
            }
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories  
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                if (di.Name.Length != 15) { continue; }
                string start = di.Name.Substring(0, 5);
                if ((start != "XSWRR") && (start != "XSWRP")) { continue; }

                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;

                LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);
            }
        }

        private void sFDistinctItemFamPrefixBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            SetFilterDevice();
        }

        private void sFItemDeviceFWDesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)sFItemDeviceFWDesBindingSource.Current;

            if (drview != null)
            {
                string famdevice = drview["FamDevice"].ToString();
                string numfunz = drview["NumFunzioni"].ToString();
                if (famdevice == "XSB")
                {
                    famdevice = famdevice + numfunz;
                }
                string coddevice = drview["Articolo_Device"].ToString();

                lab_device_ID.Text = drview["Model"].ToString();
                lab_device_desart.Text = drview["Descrizione_Device"].ToString();
                lab_device_desestart.Text = drview["DescrizioneEstesa_Device"].ToString();
                lab_device_codfw.Text = drview["ArticoloFW"].ToString();
                lab_device_desfw.Text = drview["Des_FW"].ToString();
                lab_device_desestfw.Text = drview["DesEst_FW"].ToString();

                //Carica immagine scheda
                string sigla = coddevice.Substring(7, 2);
                //string path = WEB_path_image + famdevice + @"\" + coddevice + @"\" + coddevice + "_Full.png";
                string path = WEB_path_image + famdevice + @"\" + sigla + @"\" + coddevice + @"\" + coddevice + "_Full.png";

                if (!File.Exists(path))
                {
                    MessageBox.Show("Immagine non presente");
                    Device_Image.Image = null;
                }
                else
                {
                    Device_Image.Image = Image.FromFile(path);
                }

                cb_scelta_Famiglia.Refresh();
                cb_scelta_Funzioni.Refresh();
                cb_scelta_Device.Refresh();
            }
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
                    qtadaeva = Convert.ToInt32(grid_commesse.Rows[e.RowIndex].Cells["grid_commesse_QtaDaEvadere"].Value);
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
                    return;
                }
            }

            //NomiColonne
            //grid_commesse_DataConsegna
            //grid_commesse_NumRiga
            //grid_commesse_CodArticoloCommessa
            //grid_commesse_Device
            //grid_commesse_ViewDevice
            //grid_commesse_QtaDaEvadere
            //grid_commesse_CommessaSelezionata
            //grid_commesse_TipoOrdine
            //grid_commesse_CommessaLong
            //grid_commesse_CommessaShort
            //grid_commesse_DataOrdine
            //grid_commesse_NumeroOrdine
            //grid_commesse_CodAnagrafico
            //grid_commesse_RagioneSociale
            //grid_commesse_UM
            //grid_commesse_QtaOrdinata
            //grid_commesse_StatoCommessa
            //grid_commesse_TipoRiga
            //grid_commesse_IsKit
            //grid_commesse_IsSwrP
            //grid_commesse_IsSWRR
            //grid_commesse_DataFineValidita
            //grid_commesse_SwDevice

            //Setto tipo programmazione
            glob_tipo_progr = "C";

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
                        //glob_Form_ID = form.CodiceID;
                        //tb_Id_Hardware.Text = glob_Form_ID;
                    }
                    //glob_Form_ID = form.CodiceID;
                    //tb_Id_Hardware.Text = glob_Form_ID;
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
                    ds_SL.dt_Tmp_Programma.Clear();
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
                    DataRow[] result = ds_SL.FW_Clienti.Select(sel);
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
            DataRow[] result = ds_SL.FW_Clienti.Select(sel);
            if (result.Length > 0)
            { newrecord = false; }
            else
            { newrecord = true; }

            if (newrecord)
            {
                string des_ita = "";
                string des_en = "";
                DataView dv_fw = new DataView(ds_SL.Firmware);
                dv_fw.RowFilter = "SW_Code = " + "'" + Fw + "'";
                if (dv_fw != null)
                {
                    des_ita = dv_fw[0]["SW_Descrizione"].ToString();
                    des_en = dv_fw[0]["SW_Descrizione_EN"].ToString();
                }

                DataRow newrow = ds_SL.FW_Clienti.NewRow();
                newrow["Cod_Nominativo"] = CodAnaCli;
                newrow["SW_Code"] = Fw;
                newrow["SW_Des1"] = des_ita;
                newrow["SW_Des2"] = des_en;

                ds_SL.FW_Clienti.Rows.Add(newrow);

                fW_ClientiTableAdapter.Update(newrow);
            }
        }

        private void TrovaFWDeviceCommesse(string commessashort)
        {
            ds_SL.dt_TMP_Firmware.Clear();

            string filtro = "CommessaShort = " + "'" + commessashort + "'";
            //DataRow[] rows = ds_commander1.SF_Commesse_SL.Select(filtro);

            // Ricerca FW in commesse
            foreach (DataRow rows in ds_SL.SF_Commesse_SL.Select(filtro))
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
            DataRow dr = ds_SL.dt_Tmp_Programma.NewRow();
            dr["tmp_prog_commessa"] = Commessa;
            dr["tmp_prog_codart_kit"] = Kit;
            dr["tmp_prog_codart_item"] = Item;
            dr["tmp_prog_codart_fw"] = cod_fw;
            dr["tmp_fw_key_id"] = fw_key_id;
            dr["tmp_ID_Hardware"] = ID_Hw;
            ds_SL.dt_Tmp_Programma.Rows.Add(dr);

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

                bool endprint = true;
                do
                {
                    var result = MessageBox.Show("Desideri stampare nuovamente l'etichetta?", "Ristampa etichetta", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        PrintLabel(glob_codice_sistema);
                        endprint = false;
                    }
                    if (result == DialogResult.No)
                    {
                        endprint = true;
                    }

                } while (!endprint);

                CaricaArchivi();
            }
        }

        private bool ProgrammaSilicon(string Commessa, string Kit, string Item, string cod_fw, int fw_key_id, string ID_Hw)
        {
            string nome_fw_full = "";
            string nome_fw_boot = "";
            string nome_fw_conf = "";

            if (fw_key_id == 0) // Arriva da codice device
            {
                nome_fw_full = tb_FW_folder.Text + @"\" + cod_fw + @"\" + "full_" + cod_fw + ".s37";
                nome_fw_boot = tb_FW_folder.Text + @"\" + cod_fw + @"\" + "boot_" + cod_fw + ".s37";
                nome_fw_conf = tb_FW_folder.Text + @"\" + cod_fw + @"\" + "conf_" + cod_fw + ".s37";

            }
            else
            {
                DataView dv = new DataView(ds_SL.dt_Tmp_Fw);

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

            //Program_Board(Commessa, Kit, Item, fw_key_id, nome_fw_full, nome_fw_boot, nome_fw_conf, ID_Hw);
            Program_Board(Commessa, Kit, Item, fw_key_id, nome_fw_full, nome_fw_boot, nome_fw_conf, ID_Hw_longversion);

            if (glob_Program_OK)
            {
                if (glob_tipo_progr == "D")
                {
                    AggiornaSN(Commessa, Kit, Item, fw_key_id, nome_fw_full, ID_Hw, glob_ser_num_read, glob_ser_num_write, glob_ID_cli);
                    AggiornaFwCliente(cb_sceltaCliente.SelectedValue.ToString(), cod_fw);
                }

                if (glob_tipo_progr == "C")
                {
                    AggiornaSN(Commessa, Kit, Item, fw_key_id, nome_fw_full, ID_Hw, glob_ser_num_read, glob_ser_num_write, glob_ID_cli);
                    AggiornaFwCliente(glob_ID_cli, glob_codice_fw);
                }


                //AggiornaOrdini();
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
            if (!Properties.Settings.Default.Use_printer)
            {
                return;
            }

            string FileName = @"\\192.168.0.8\ricerca e sviluppo\Produzione\Etichette_2020\QR_code_DYMO.label";
            string lab = glob_ser_num_write + "\n" + "\n" + Item;
            
            _label = Framework.Open(FileName);
            _label.SetObjectText("QR_1", glob_ser_num_write);
            _label.SetObjectText("QR_2", glob_ser_num_write);
            _label.SetObjectText("QR_3", glob_ser_num_write);
            _label.SetObjectText("QR_1_text", lab);

            //IPrinter printer = Framework.GetPrinters()[LabelWriterCmb.Text];
            //IPrinter printer = Framework.GetPrinters()["DYMO LabelWriter 450 Twin Turbo"];
            IPrinter printer = Framework.GetPrinters()["DYMO LabelWriter 450"];
            if (printer is ILabelWriterPrinter)
            {
                ILabelWriterPrintParams printParams = null;
                ILabelWriterPrinter labelWriterPrinter = printer as ILabelWriterPrinter;
                if (labelWriterPrinter.IsTwinTurbo)
                {
                    printParams = new LabelWriterPrintParams();
                    printParams.RollSelection = (RollSelection)Enum.Parse(typeof(RollSelection), "Left");
                }

                _label.Print(printer, printParams);
            }
            else
                _label.Print(printer); // print with default params

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
                        glob_ser_num_write = ConvertiID(glob_ser_num_read);
                        lab_IDNumber_write.Text = glob_ser_num_write;
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

            //Inserimento firmware (full_ Versione con Eugeniu)
            //try
            //{
            //    var proc = Process.Start(psi);

            //    string programstring = Properties.Settings.Default.Commander_path + @"\commander.exe flash " + '"' + nome_fw_full + '"' + " --address 0x0 " + glob_device;
            //    //string programstring = Properties.Settings.Default.Commander_path + @"\commander.exe flash " + glob_codice_fw_fulltmppath + " --address 0x0 " + glob_device;
            //    proc.StandardInput.WriteLine(programstring);
            //    proc.StandardInput.WriteLine("exit");

            //    text_dos = proc.StandardOutput.ReadToEnd();
            //    dos_box.Text = dos_box.Text + text_dos + "\n======================================================================" + Environment.NewLine;
            //    dos_box.Refresh();

            //    if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
            //        text_dos.Contains("ERROR: Could not open J-Link connection."))
            //    {
            //        MessageBox.Show("Interfaccia non collegata correttamente!");
            //        dos_box.Clear();
            //        dos_box.Refresh();
            //        text_dos = "";
            //        glob_Program_OK = false;
            //        return;
            //    }

            //    dos_box.SelectionStart = dos_box.Text.Length;
            //    dos_box.ScrollToCaret();
            //}
            //catch (Exception ex)
            //{

            //}

            //Verifica (full_ Versione con Eugeniu)
            //try
            //{
            //    var proc = Process.Start(psi);

            //    //string verifyprogramstring = Properties.Settings.Default.Commander_path + @"\commander.exe verify " + glob_codice_fw_fulltmppath + " " + glob_device;
            //    string verifyprogramstring = Properties.Settings.Default.Commander_path + @"\commander.exe verify " + '"' + nome_fw_full + '"' + " " + glob_device;
            //    proc.StandardInput.WriteLine(verifyprogramstring);
            //    proc.StandardInput.WriteLine("exit");

            //    text_dos = proc.StandardOutput.ReadToEnd();
            //    dos_box.Text = dos_box.Text + text_dos + "\n======================================================================" + Environment.NewLine;
            //    dos_box.Refresh();

            //    if (text_dos.Contains("DONE"))
            //    {
            //        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //        string sound = ".\\tada.wav";
            //        player.SoundLocation = sound;
            //        player.Load();
            //        player.Play();
            //    }
            //    else
            //    {
            //        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //        string sound = ".\\Yamaha.wav";
            //        player.SoundLocation = sound;
            //        player.Load();
            //        player.Play();
            //        glob_Program_OK = false;
            //    }

            //    dos_box.SelectionStart = dos_box.Text.Length;
            //    dos_box.ScrollToCaret();
            //}
            //catch (Exception ex)
            //{

            //}

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
                    text_dos.Contains("ERROR: Verificiation failed!"))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente / Errore di programmazione");
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
                    text_dos.Contains("ERROR: Verificiation failed!"))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente / Errore di programmazione");
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
                    text_dos.Contains("ERROR: Verificiation failed!"))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente / Errore di programmazione");
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
                    text_dos.Contains("ERROR: Verificiation failed!"))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente / Errore di programmazione");
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

            //Scrittura ID
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

                if (glob_ID_code.Length == 4)
                {
                    coppia_1 = glob_ID_code.Substring(0, 2);
                    coppia_2 = glob_ID_code.Substring(2, 2);
                }

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

                //string verifyprogramstring = Properties.Settings.Default.Path_URL_Commander + @"\commander.exe flash --patch 0x0fe00000:0x0068:2" + " " + device;
                string verifyprogramstring = "";
                if (glob_ID_code.Length == 4)
                {
                    verifyprogramstring = Properties.Settings.Default.Commander_path + @"\commander.exe flash --patch 0x0fe00000:0x" + coppia_2 + coppia_1 + ":2" + " " + glob_device;
                }
                if (glob_ID_code.Length == 16)
                {
                    verifyprogramstring = Properties.Settings.Default.Commander_path + @"\commander.exe flash --patch 0x0fe00000:0x" + coppia_8 + coppia_7 + coppia_6 + coppia_5 + coppia_4 + coppia_3 + coppia_2 + coppia_1 + ":8" + " " + glob_device;
                }
                proc.StandardInput.WriteLine(verifyprogramstring);
                proc.StandardInput.WriteLine("exit");

                text_dos = proc.StandardOutput.ReadToEnd();
                dos_box.Text = dos_box.Text + text_dos + "\n======================================================================" + Environment.NewLine;

                if (text_dos.Contains("ERROR: Cannot connect to J-Link via USB.") ||
                    text_dos.Contains("ERROR: Could not open J-Link connection.") ||
                    text_dos.Contains("ERROR: Unspecified error during flashing.") ||
                    text_dos.Contains("ERROR: Verificiation failed!"))
                {
                    MessageBox.Show("Interfaccia non collegata correttamente / Errore di programmazione");
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

            if (glob_tipo_progr != "L")
            {
                PrintLabel(glob_codice_sistema);
            }
        }

        private void AggiornaSN(string Commessa, string Kit, string Item, int fw_key_id, string nome_fw_full, string ID_Hw, string serial_read, string serial_write, string ID_Cli)
        {
            // Recupero Codice Firmware
            DataView dv = new DataView(ds_SL.dt_Tmp_Fw);
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
                this.dt_Firmware_lookupCommesseSLTableAdapter.FillBy(this.ds_SL.dt_Firmware_lookupCommesseSL, codice_fw);
                DataRowCollection rowCol = this.ds_SL.dt_Firmware_lookupCommesseSL.Rows;
                Fw_isStandard = (bool)rowCol[0]["SW_Standard"];
                Fw_Rev = rowCol[0]["SW_Revisione"].ToString();
            }

            // Verifica se nuovo SN o già esistente
            bool newrecord = false;
            string sel = "Ser_ReadSerial = " + "'" + serial_read + "'";
            DataRow[] result = ds_SL.SerialNumbers.Select(sel);
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
                serialNumbersTableAdapter.Update(this.ds_SL.SerialNumbers);
            }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            catch (System.Exception ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
            {
                MessageBox.Show("Table 'SerialNumbers' - Update failed");
            }

            DataRow newrow = ds_SL.SerialNumbers.NewRow();
            newrow["Ser_Device_ID_Code"] = ID_Hw;
            newrow["Ser_OfficialSerial"] = serial_write;
            newrow["Ser_ReadSerial"] = serial_read;
            newrow["Ser_SW_Code"] = codice_fw;
            //newrow["Ser_SW_Code_Rev"]=
            //newrow["Ser_SW_Std_Type"]=
            //newrow["Ser_SN_prod"]=
            //newrow["Ser_Commessa"]=
            newrow["Ser_DateProduction"] = DateTime.Now;
            newrow["Ser_Spedito"] = false;

            if (glob_tipo_progr == "C") //C-Commessa K-Kit D-Device L-Libera
            {
                newrow["Ser_Commessa"] = Commessa;
                newrow["Ser_Kit"] = Kit;
                newrow["Ser_ID_Cli"] = ID_Cli;
                newrow["Ser_Device"] = Item;
                newrow["Ser_SW_Std_Type"] = Fw_isStandard;
                newrow["Ser_SW_Code_Rev"] = Fw_Rev;
            }

            if (glob_tipo_progr == "D") //C-Commessa K-Kit D-Device L-Libera
            {
                newrow["Ser_Kit"] = Item;
                newrow["Ser_ID_Cli"] = cb_sceltaCliente.SelectedValue;
                newrow["Ser_Device"] = Item;
                if (dtTmpProgrammadtFirmwareBindingSource.Current != null)
                {
                    DataRowView fw_row = (DataRowView)dtTmpProgrammadtFirmwareBindingSource.Current;
                    newrow["Ser_SW_Code_Rev"] = fw_row["SW_Revisione"];
                    newrow["Ser_SW_Std_Type"] = fw_row["SW_Standard"];
                }
                newrow["Ser_SN_prod"] = null;
            }

            if (glob_tipo_progr == "L") //C-Commessa K-Kit D-Device L-Libera
            {
                newrow["Ser_ID_Cli"] = "1";
            }


            ds_SL.SerialNumbers.Rows.Add(newrow);

            serialNumbersTableAdapter.Update(newrow);
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

        private void but_Edit_Config_Click(object sender, EventArgs e)
        {
            glob_edit_config = true;
            AbilitaSchermo();
        }

        private void but_Save_Config_Click(object sender, EventArgs e)
        {
            glob_edit_config = false;
            AbilitaSchermo();
        }

        private void but_Abort_Config_Click(object sender, EventArgs e)
        {
            glob_edit_config = false;
            AbilitaSchermo();
        }

        private void toggle_tipo_device_Libera_CheckedChanged(object sender, EventArgs e)
        {
            AbilitaSchermo();
        }

        private void toggle_tipo_firmware_CheckedChanged(object sender, EventArgs e)
        {
            AbilitaSchermo();
        }

        private void cb_scelta_fw_Click(object sender, EventArgs e)
        {
            cb_scelta_fw.Refresh();
        }

        private void cb_scelta_fw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_scelta_fw.SelectedValue != null) { but_seleziona_fw.Visible = true; } else { but_seleziona_fw.Visible = false; }
        }

        private void but_seleziona_fw_Click(object sender, EventArgs e)
        {
            glob_tipo_progr = "L";

            if (tb_Id_Hardware.Text == "")
            {
                MessageBox.Show("Id Hardware mancante!");
                tb_Id_Hardware.Focus();
            }
            else
            {
                ds_SL.dt_Tmp_Programma.Clear();

                //trova codice fw
                DataView dv = new DataView(ds_SL.dt_Tmp_Fw);
                string cod_fw = "";
                dv.RowFilter = "fw_id = " + (int)cb_scelta_fw.SelectedValue;
                if (dv.Count > 0)
                {
                    cod_fw = dv[0]["fw_codfw"].ToString();
                }


                AggiungiRigaProg(null, null, null, cod_fw, (int)cb_scelta_fw.SelectedValue, tb_Id_Hardware.Text);
            }
        }

        private void tb_Id_Hardware_ButtonClick(object sender, EventArgs e)
        {
            glob_Form_ID = "";
            if (!toggle_tipo_device_Libera.Checked) // Palmare
            {
                using (var form = new UC_ID_Palmare())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        glob_Form_ID = form.CodiceID;
                        tb_Id_Hardware.Text = glob_Form_ID;
                    }
                    glob_Form_ID = form.CodiceID;
                    tb_Id_Hardware.Text = glob_Form_ID;
                }
            }
            else
            {
                using (var form = new UC_ID_Ricevitore())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        glob_Form_ID = form.CodiceID;
                        tb_Id_Hardware.Text = glob_Form_ID;
                    }
                    glob_Form_ID = form.CodiceID;
                    tb_Id_Hardware.Text = glob_Form_ID;
                }
            }


            //UC_ID_Palmare uC_ID_Palmare = new UC_ID_Palmare();
            //uC_ID_Palmare.ShowDialog();
        }

        private void cb_scelta_Famiglia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds_SL.dt_Tmp_Programma.Clear();

            cb_scelta_Funzioni.Text = "";
            cb_scelta_Device.Text = "";
            Device_Image.Image = null;

            SetFilterDevice();
        }

        private void cb_scelta_Funzioni_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds_SL.dt_Tmp_Programma.Clear();

            cb_scelta_Device.Text = "";
            Device_Image.Image = null;

            SetFilterDevice();
        }

        private void but_seleziona_device_Click(object sender, EventArgs e)
        {
            glob_tipo_progr = "D";

            DataRowView drview = (DataRowView)sFItemDeviceFWDesBindingSource.Current;
            string famdevice = drview["FamDevice"].ToString();
            string numfunz = drview["NumFunzioni"].ToString();
            string codkit = drview["Articolo_Device"].ToString();
            string coddevice = drview["Articolo_Device"].ToString();
            string cod_fw = drview["ArticoloFW"].ToString();
            string ID_Hw = drview["Model"].ToString();

            ds_SL.dt_Tmp_Programma.Clear();

            AggiungiRigaProg(null, codkit, coddevice, cod_fw, 0, ID_Hw);
        }

        private void cb_scelta_Device_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds_SL.dt_Tmp_Programma.Clear();
        }

        private void cb_sceltaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds_SL.dt_Tmp_Programma.Clear();
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

            sFLastSerialNumberBindingSource.Filter = "Modello = " + "'" + ID_Hw + "'" + "and Anno = " + "'" + anno + "'";
            if (sFLastSerialNumberBindingSource.Count != 0)
            {
                DataRowView current = (DataRowView)sFLastSerialNumberBindingSource.Current;
                returnLastNumber = Convert.ToInt32(current["LastSerialID"]);
            }
            return returnLastNumber;
        }
    }
}
