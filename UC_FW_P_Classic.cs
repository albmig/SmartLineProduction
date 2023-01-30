using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SmartLineProduction.Properties;
using System.Data.SqlTypes;
using MetroFramework;

namespace SmartLineProduction
{
    public partial class UC_FW_P_Classic : MetroFramework.Forms.MetroForm
    {
        private string displayform = "V"; // V-View/INV-InsertNewVersion/INR-InsertNewRelease/CLO-CloneFirmware

        private string filtroincorso = "FW_CL_P_Obsolete_ver = 0";

        //private int LockLevel = 0;

        public UC_FW_P_Classic()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////
        /// Private functions
        ////////////////////////////////////////////////////////////////////////////////

        private void AbilitaForm()
        {
            SetFilter();
            this.Firmware_BindingSource.Filter = filtroincorso;

            this.Firmware_BindingSource.Sort = "FW_CL_P_SW_Versione ASC";
            this.Firmware_BindingSource.ResetBindings(false);
            gv_FW_P.Refresh();

            if (displayform == "V")
            {
                panel_dati.Enabled = false;
                panel_revisioni.Enabled = false;
                panel_funzionamento.Enabled = false;
                panel_FW_P.Enabled = true;
                pan_Menu_comandi.Enabled = true;
                pan_Menu_exit.Enabled = true;
                pan_Menu_salva.Enabled = false;

                gv_FW_P.Enabled = true;
                //group_Lock.Enabled = false;
            }

            if (displayform == "INR")
            {
                panel_dati.Enabled = true;
                panel_revisioni.Enabled = true;
                panel_funzionamento.Enabled = true;
                tb_gv_Code.Enabled = false;
                tb_gv_Versione.Enabled = false;
                //cbox_SoftwareStandard.Enabled = false;
                //tb_gv_Des1.Enabled = false;
                //tb_gv_Des2.Enabled = false;
                //panel_freq.Enabled = false;

                tog_CambioPag.Enabled = true;
                //tog_BackLight.Enabled = false;
                //tog_EmButt.Enabled = false;
                //tog_ShiftPage.Enabled = false;
                tog_CambioRic.Enabled = true;
                tog_MotRim.Enabled = true;
                //tog_Vibracall.Enabled = false;
                //tog_Torch.Enabled = false;
                tog_Retroill.Enabled = true;
                tog_SPAttivo.Enabled = true;
                //tb_gv_MaxPair.Enabled = false;

                
                pan_Menu_comandi.Enabled = false;
                pan_Menu_exit.Enabled = false;
                pan_Menu_salva.Enabled = true;

                panel_FW_P.Enabled = false;
                tb_gv_Revisione.Focus();

                gv_FW_P.Enabled = false;
                //group_Lock.Enabled = false;
            }

            if (displayform == "CLO")
            {
                panel_dati.Enabled = true;
                panel_revisioni.Enabled = true;
                panel_funzionamento.Enabled = true;
                tb_gv_Code.Enabled = false;

                tb_gv_Code.Text = "";
                tb_gv_Code.Enabled = false;
                tb_gv_Versione.Text = "";
                tb_gv_Versione.Enabled = true;
                tb_gv_Revisione.Text = "";
                tb_gv_Revisione.Enabled = true;

                //cbox_SoftwareStandard.Enabled = true;

                //tb_gv_Des1.Text = "";
                //tb_gv_Des2.Text = "";

                rtb_Revisioni.Text = "";
                rtb_Funzionamento.Text = "";

                pan_Menu_comandi.Enabled = false;
                pan_Menu_exit.Enabled = false;
                pan_Menu_salva.Enabled = true;

                panel_FW_P.Enabled = false;
                tb_gv_Revisione.Focus();

                gv_FW_P.Enabled = false;
                //group_Lock.Enabled = true;
            }

            if (displayform == "INV")
            {
                panel_dati.Enabled = true;
                panel_revisioni.Enabled = true;
                panel_funzionamento.Enabled = true;
                tb_gv_Code.Enabled = false;

                tb_gv_Code.Text = "";
                tb_gv_Code.Enabled = false;
                tb_gv_Versione.Text = "";
                tb_gv_Versione.Enabled = true;
                tb_gv_Revisione.Text = "";
                tb_gv_Revisione.Enabled = true;

                //cbox_SoftwareStandard.Enabled = true;

                //tb_gv_Des1.Text = "";
                //tb_gv_Des2.Text = "";

                tog_CambioPag.Checked = false;
                //tog_EmButt.Checked = false;
                //tog_BackLight.Checked = false;
                //tog_ShiftPage.Checked = false;
                tog_CambioRic.Checked = false;
                tog_MotRim.Checked = false;
                tog_Vibracall.Checked = false;
                tog_Torcia.Checked = false;
                tog_Retroill.Checked = false;
                tog_SPAttivo.Checked = false;
                tog_SPAssivo.Checked = false;
                tog_IVLed.Checked = false;
                tog_Accel.Checked = false;
                tog_Buzzer.Checked = false;
                
                //tb_gv_MaxPair.Text = "1";

                rtb_Revisioni.Text = "";
                rtb_Funzionamento.Text = "";

                pan_Menu_comandi.Enabled = false;
                pan_Menu_exit.Enabled = false;
                pan_Menu_salva.Enabled = true;
                tB_NRicevCom.Text = "1";
                tb_fwAbbinato.Text = "";
                cb_868.Checked = true;
                panel_FW_P.Enabled = false;
                tb_gv_Revisione.Focus();
                cb_Famiglia.Text = "";
                gv_FW_P.Enabled = false;

                //LockLevel = 0;
                //group_Lock.Enabled = true;
            }

            

            
        }

        private void menu_sw_annulla_Click(object sender, EventArgs e)
        {
            Firmware_BindingSource.SuspendBinding();
            Firmware_TableAdapter.Fill(this.ds_CL_Firmware.FW_CL_Palmari);
            Firmware_BindingSource.ResumeBinding();

            Firmware_BindingSource.MoveFirst();

            displayform = "V";
            DB2Riga();

            gv_FW_P.Refresh();

            AbilitaForm();
        }

        private void menu_sw_salva_Click(object sender, EventArgs e)
        {
            

            Riga2DB();

            Firmware_BindingSource.SuspendBinding();
            Firmware_TableAdapter.Fill(this.ds_CL_Firmware.FW_CL_Palmari);
            Firmware_BindingSource.ResumeBinding();

            Firmware_BindingSource.MoveFirst();

            displayform = "V";
            DB2Riga();

            gv_FW_P.Refresh();

            AbilitaForm();
        }

        private void Riga2DB()
        {
            var newrow = ds_CL_Firmware.FW_CL_Palmari.NewRow();

            newrow["FW_CL_P_SW_Code"] = tb_gv_Code.Text;
            newrow["FW_CL_P_TipoDev"] = cb_Famiglia.SelectedValue;
            newrow["FW_CL_P_SW_Versione"] = tb_gv_Versione.Text;
            newrow["FW_CL_P_SW_Revisione"] = tb_gv_Revisione.Text;
            if (tog_CambioPag.Checked) { newrow["FW_CL_P_CambioPag"] = true; } else { newrow["FW_CL_P_CambioPag"] = false; }
            if (tog_CambioRic.Checked) { newrow["FW_CL_P_CambioRic"] = true; } else { newrow["FW_CL_P_CambioRic"] = false; }
            if (tog_MotRim.Checked) { newrow["FW_CL_P_MotRim"] = true; } else { newrow["FW_CL_P_MotRim"] = false; }
            if (tog_Retroill.Checked) { newrow["FW_CL_P_Retroill"] = true; } else { newrow["FW_CL_P_Retroill"] = false; }
            if (tog_SPAttivo.Checked) { newrow["FW_CL_P_SPAttivo"] = true; } else { newrow["FW_CL_P_SPAttivo"] = false; }
            if (tog_SPAssivo.Checked) { newrow["FW_CL_P_SPPassivo"] = true; } else { newrow["FW_CL_P_SPPassivo"] = false; }
            if (tog_Accel.Checked) { newrow["FW_CL_P_Accel"] = true; } else { newrow["FW_CL_P_Accel"] = false; }
            if (tog_Buzzer.Checked) { newrow["FW_CL_P_Buzzer"] = true; } else { newrow["FW_CL_P_Buzzer"] = false; }
            if (tog_Vibracall.Checked) { newrow["FW_CL_P_Vibracall"] = true; } else { newrow["FW_CL_P_Vibracall"] = false; }
            if (tog_Torcia.Checked) { newrow["FW_CL_P_Torcia"] = true; } else { newrow["FW_CL_P_Torcia"] = false; }
            if (tog_IVLed.Checked) { newrow["FW_CL_P_IVLed"] = true; } else { newrow["FW_CL_P_IVLed"] = false; }

            if (cb_868.Checked) { newrow["FW_CL_P_Freq"] = "X"; }
            if (cb_433.Checked) { newrow["FW_CL_P_Freq"] = "B"; }
            if (cb_915.Checked) { newrow["FW_CL_P_Freq"] = "A"; }
            if (cb_filo.Checked) { newrow["FW_CL_P_Freq"] = "N"; }
            if (cb_can.Checked) { newrow["FW_CL_P_Freq"] = "C"; }

            //string famcomp = "";
            //foreach (DataGridViewRow fam_row in gv_Famiglia.Rows)
            //{
            //    bool isSelected = Convert.ToBoolean(fam_row.Cells["gv_Famiglia_Check"].EditedFormattedValue);
            //    if (isSelected)
            //    {
            //        famcomp = famcomp + fam_row.Cells["gv_Famiglia_Ident"].Value.ToString();

            //        int identificatorefamiglia = Convert.ToInt32(fam_row.Cells["gv_Famiglia_Ident"].EditedFormattedValue);
            //        //Controlli su tipo famiglia // Old version - Radius
            //        if (identificatorefamiglia == 8)
            //        {
            //            if (tog_Accel.Checked) { newrow["SW_P_Opt_Use_Accel"] = false; newrow["SW_P_Opt_Use_Radius"] = true; } else { newrow["SW_P_Opt_Use_Accel"] = false; newrow["SW_P_Opt_Use_Radius"] = false; }
            //        }
            //        else
            //        {
            //            if (tog_Accel.Checked) { newrow["SW_P_Opt_Use_Accel"] = true; newrow["SW_P_Opt_Use_Radius"] = false; } else { newrow["SW_P_Opt_Use_Accel"] = false; newrow["SW_P_Opt_Use_Radius"] = false; }
            //        }
            //    }
            //}
            //newrow["SW_FamProd"] = famcomp;
            newrow["FW_CL_P_FwRAbbinato"] = tb_fwAbbinato.Text;
            newrow["FW_CL_P_Revisioni"] = rtb_Revisioni.Text;
            newrow["FW_CL_P_Funzionamento"] = rtb_Funzionamento.Text;


            //Campi da riempire NOT NULL    ////ALBERTO DA FARE

            //newrow["SW_R_Opt_RF"] = newrow["SW_P_Opt_RF"];
            //newrow["SW_R_Opt_Plug_Exp"] = false;
            //newrow["SW_R_Opt_Plug_Ple"] = false;
            //newrow["SW_R_Opt_Em_Keyb"] = false;
            //newrow["SW_R_Opt_Can"] = false;
            //newrow["SW_R_Opt_Prop_Out"] = false;
            //newrow["SW_R_Opt_TimeOut"] = false;
            //newrow["SW_R_Opt_LockSameRow"] = false;
            //newrow["SW_R_Opt_Use_SP"] = false;
            //newrow["SW_R_Opt_ShiftPage"] = false;
            newrow["FW_CL_P_Obsolete_ver"] = false;
            //newrow["FW_CL_P_Obsolete_ver_from_date"] = false;
            newrow["FW_CL_P_CanBus"] = false;
            newrow["FW_CL_P_NumRicevitori"] = tB_NRicevCom.Text;

            ds_CL_Firmware.FW_CL_Palmari.Rows.Add(newrow);
            Firmware_TableAdapter.Update(newrow);
        }

        private void DB2Riga()
        {
            DataRowView myRow = (DataRowView)Firmware_BindingSource.Current;

            tb_gv_Code.Text = myRow["FW_CL_P_SW_Code"].ToString();
            tb_gv_Versione.Text = myRow["FW_CL_P_SW_Versione"].ToString();
            tb_gv_Revisione.Text = myRow["FW_CL_P_SW_Revisione"].ToString();


            cb_868.Checked = false;
            cb_433.Checked = false;
            cb_915.Checked = false;
            cb_filo.Checked = false;
            cb_can.Checked = false;

            switch (myRow["FW_CL_P_Freq"].ToString())
            {
                case "X": cb_868.Checked = true; break;
                case "A": cb_915.Checked = true; break;
                case "B": cb_433.Checked = true; break;
                case "N": cb_filo.Checked = true; break;
                case "C": cb_can.Checked = true; break;
                default: break;
            }
            tog_CambioPag.Checked = (bool)myRow["FW_CL_P_CambioPag"];
            tog_CambioRic.Checked = (bool)myRow["FW_CL_P_CambioRic"];
            tog_MotRim.Checked = (bool)myRow["FW_CL_P_MotRim"];
            tog_Retroill.Checked = (bool)myRow["FW_CL_P_Retroill"];
            tog_SPAttivo.Checked = (bool)myRow["FW_CL_P_SPAttivo"];
            tog_SPAssivo.Checked = (bool)myRow["FW_CL_P_SPPassivo"];
            tog_Accel.Checked = (bool)myRow["FW_CL_P_Accel"];
            tog_Buzzer.Checked = (bool)myRow["FW_CL_P_Buzzer"];
            tog_Vibracall.Checked = (bool)myRow["FW_CL_P_Vibracall"];
            tog_Torcia.Checked = (bool)myRow["FW_CL_P_Torcia"];
            tog_IVLed.Checked = (bool)myRow["FW_CL_P_IVLed"];

            tB_NRicevCom.Text = myRow["FW_CL_P_NumRicevitori"].ToString();
            tb_fwAbbinato.Text = myRow["FW_CL_P_FwRAbbinato"].ToString();
            rtb_Revisioni.Text = myRow["FW_CL_P_Revisioni"].ToString();
            rtb_Funzionamento.Text = myRow["FW_CL_P_Funzionamento"].ToString();

            //LockLevel = (int)myRow["SW_P_Lock"];
            //ManageLock(LockLevel);

            //Crea grid History
            //string filtrohistory = "SW_TipoDevice = 'P' and SW_Obsolete_ver and SW_Code = '" + myRow["SW_Code"].ToString() + "'";
            //DataView dv_R_history = new DataView(ds_Programmazione.Firmware);
            //dv_R_history.RowFilter = filtrohistory;
            //gv_history.DataSource = dv_R_history;
            //dv_R_history.Sort = "SW_Obsolete_ver_from_date DESC";
            //gv_history.Refresh();
            ///////////////////////////////////

            //Crea Grid Famiglia
            //string famiglie = myRow["SW_FamProd"].ToString();
            //foreach (DataGridViewRow famrow in gv_Famiglia.Rows)
            //{

            //    string cella = famrow.Cells["gv_Famiglia_Ident"].Value.ToString(); //trova identificatore della famiglia

            //    DataGridViewCheckBoxCell cellcheck = (DataGridViewCheckBoxCell)famrow.Cells["gv_Famiglia_Check"];
            //    char identificatore = Convert.ToChar(famrow.Cells["gv_Famiglia_Ident"].Value);
            //    bool trovato = false;
            //    if (famiglie.IndexOf(identificatore) == -1) { trovato = false; } else { trovato = true; }

            //    if (cellcheck.Value != null)
            //    {
            //        if (cellcheck.Value.Equals(cellcheck.FalseValue)) { cellcheck.Value = cellcheck.TrueValue; } else { cellcheck.Value = cellcheck.FalseValue; }
            //    }
            //    else { cellcheck.Value = true; }


            //    if (trovato) { famrow.Cells["gv_Famiglia_Check"].Value = true; } else { famrow.Cells["gv_Famiglia_Check"].Value = false; }

            //    int identificatorefamiglia = Convert.ToInt32(famrow.Cells["gv_Famiglia_Ident"].Value);
            //    //Controlli su tipo famiglia // Old version - Radius
            //    if (identificatorefamiglia == 8)
            //    {
            //        tog_Accel.Checked = (bool)myRow["SW_P_Opt_Use_Radius"];
            //    }
            //    else
            //    {
            //        tog_Accel.Checked = (bool)myRow["SW_P_Opt_Use_Accel"];
            //    }

            //    this.gv_Famiglia.RefreshEdit();
            //}

        //    gv_Famiglia.ClearSelection();
        //    gv_history.ClearSelection();
        }

        private void CreaCodice()
        {
            if ((tb_gv_Versione.Text != "") && (tb_gv_Revisione.Text != "") && (tb_gv_Versione.Text != ""))
            {
                string code = "XSWR";

                

                code = code + tb_gv_Versione.Text.ToUpper() + tb_gv_Revisione.Text.ToUpper();

                string freq = "";
                if (cb_868.Checked) { freq = "X"; }
                if (cb_915.Checked) { freq = "A"; }
                if (cb_433.Checked) { freq = "B"; }
                if (cb_filo.Checked) { freq = "N"; }
                if (cb_can.Checked) { freq = "N"; }

                code = code + freq;
                tb_gv_Code.Text = code;
            }
        }

        private void SetView()
        {
            SetFilter();
            Firmware_BindingSource.Filter = filtroincorso;

            Firmware_BindingSource.MoveFirst();
            if (Firmware_BindingSource.Current != null)
            {
                DB2Riga();
            }

            gv_FW_P.Refresh();
        }

        private void SetFilter()
        {
            if (radio_FW_active.Checked) 
            {
                filtroincorso = "FW_CL_P_Obsolete_ver = 0";
            }
            if (radio_FW_obsoleti.Checked)
            {
                filtroincorso = "FW_CL_P_Obsolete_ver = 0 OR FW_CL_P_Obsolete_ver = 1";
                //filtroincorso = "FW_CL_P_Obsolete_ver = 1";
            }
        }

        //private void ManageLock(int LockLevel)
        //{
        //    switch (LockLevel)
        //    {
        //        case 0:
        //            cb_Lock_0.Checked = true;
        //            cb_Lock_1.Checked = false;
        //            cb_Lock_2.Checked = false;
        //            cb_Lock_3.Checked = false;
        //            break;
        //        case 1:
        //            cb_Lock_0.Checked = false;
        //            cb_Lock_1.Checked = true;
        //            cb_Lock_2.Checked = false;
        //            cb_Lock_3.Checked = false;
        //            break;
        //        case 2:
        //            cb_Lock_0.Checked = false;
        //            cb_Lock_1.Checked = false;
        //            cb_Lock_2.Checked = true;
        //            cb_Lock_3.Checked = false;
        //            break;
        //        case 3:
        //            cb_Lock_0.Checked = false;
        //            cb_Lock_1.Checked = false;
        //            cb_Lock_2.Checked = false;
        //            cb_Lock_3.Checked = true;
        //            break;
        //    }
        //}

        ////////////////////////////////////////////////////////////////////////////////
        /// Generated functions
        ////////////////////////////////////////////////////////////////////////////////

        private void uscitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_FW_P_Classic_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_CL_Firmware.FW_CL_Palmari'. È possibile spostarla o rimuoverla se necessario.
            this.Firmware_TableAdapter.Fill(this.ds_CL_Firmware.FW_CL_Palmari);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_CL_Firmware.FW_CL_Famiglie'. È possibile spostarla o rimuoverla se necessario.
            this.fW_CL_FamiglieTableAdapter.Fill(this.ds_CL_Firmware.FW_CL_Famiglie);

            GVar.formclosing = false;

            displayform = "V";

            //LockLevel = 0;

            AbilitaForm();
            radio_FW_active.Checked = true;
            radio_FW_obsoleti.Checked = false;
            //radio_FW_custom.Checked = false;

            Firmware_BindingSource.MoveFirst();
            if (Firmware_BindingSource.Current != null)
            {
                DB2Riga();
            }

        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gv_FW_P_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (GVar.formclosing) { return; }

            foreach (DataGridViewRow x in gv_FW_P.Rows)
            {
                x.MinimumHeight = 30;
            }
        }

        private void UC_FW_P_Classic_FormClosing(object sender, FormClosingEventArgs e)
        {
            GVar.formclosing = true;
        }

        

        private void creaRevisioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayform = "INR";
            AbilitaForm();

            //Modifico valori iniziali
            var sourceRow = ((DataRowView)Firmware_BindingSource.Current).Row;
            int rev = Convert.ToInt32(sourceRow["FW_CL_P_SW_Revisione"].ToString());
            rev++;
            tb_gv_Revisione.Text = rev.ToString();
            tb_gv_Revisione.Refresh();

            string data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            //string line1 = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss") + " - Nuova revisione, la precedente era " + sourceRow["SW_Revisione"].ToString() + "\r\n";
            string line1 = data + " - Nuova revisione, la precedente era " + sourceRow["FW_CL_P_SW_Revisione"].ToString() + "\r\n";
            string result = new String('-', 100);
            string line2 = result + "\r\n";
            rtb_Revisioni.Text = line1 + line2 + rtb_Revisioni.Text;
            rtb_Revisioni.Refresh();
        }

        private void Firmware_BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DB2Riga();
            
        }

        private void menu_sw_clona_Click(object sender, EventArgs e)
        {
            displayform = "CLO";

            //Modifico valori iniziali
            var sourceRow = ((DataRowView)Firmware_BindingSource.Current).Row;
            AbilitaForm();
            tb_gv_Versione.Focus();
        }

        private void tb_gv_Versione_Validating(object sender, CancelEventArgs e)
        {
            string ver = tb_gv_Versione.Text;
            if (ver.Length > 5) { MessageBox.Show("Errore di digitazione! La versione non può essere superiore a 5 caratteri!"); tb_gv_Versione.Focus(); return; }
            if (ver.Length < 5) { string padded = ver.PadLeft(5, '0'); tb_gv_Versione.Text = padded; tb_gv_Versione.Refresh(); }

            CreaCodice();
        }

        private void tb_gv_Revisione_Validating(object sender, CancelEventArgs e)
        {
            string rev = tb_gv_Revisione.Text;
            if (rev.Length > 3) { MessageBox.Show("Errore di digitazione! La versione non può essere superiore a 3 caratteri!"); tb_gv_Revisione.Focus(); return; }
            if (rev.Length < 3) { string padded = rev.PadLeft(3, '0'); tb_gv_Revisione.Text = padded; tb_gv_Revisione.Refresh(); }

            CreaCodice();
        }

        private void cbox_SoftwareStandard_Click(object sender, EventArgs e)
        {
            CreaCodice();
        }

        private void cb_868_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_868.Checked)
            {
                cb_915.Checked = false;
                cb_433.Checked = false;
                cb_filo.Checked = false;
                cb_can.Checked = false;
            }
            CreaCodice();
        }

        private void cb_915_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_915.Checked)
            {
                cb_868.Checked = false;
                cb_433.Checked = false;
                cb_filo.Checked = false;
                cb_can.Checked = false;
            }
            CreaCodice();
        }

        private void cb_433_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_433.Checked)
            {
                cb_868.Checked = false;
                cb_915.Checked = false;
                cb_filo.Checked = false;
                cb_can.Checked = false;
            }
            CreaCodice();
        }

        private void cb_filo_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_filo.Checked)
            {
                cb_868.Checked = false;
                cb_915.Checked = false;
                cb_433.Checked = false;
                cb_can.Checked = false;
            }
            CreaCodice();
        }

        private void cb_can_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_can.Checked)
            {
                cb_868.Checked = false;
                cb_915.Checked = false;
                cb_433.Checked = false;
                cb_filo.Checked = false;
            }
            CreaCodice();
        }

        private void menu_sw_new_Click(object sender, EventArgs e)
        {
            displayform = "INV";
            AbilitaForm();
            tb_gv_Versione.Focus();

            //if (Firmware_BindingSource.Current != null)
            //{
            //    //Modifico valori iniziali
            //    //var sourceRow = ((DataRowView)Firmware_BindingSource.Current).Row;
            //    AbilitaForm();
            //    tb_gv_Versione.Focus();
            //}
            
        }

        private void radio_FW_all_Click(object sender, EventArgs e)
        {
            SetView();
        }
        private void radio_FW_Obsoleti_Click(object sender, EventArgs e)
        {
            SetView();
        }

    }
}
