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
using System.Diagnostics.Contracts;
using System.Data.OleDb;

namespace SmartLineProduction
{
    public partial class UC_FW_R : MetroFramework.Forms.MetroForm
    {
        private string displayform = "V"; // V-View/INV-InsertNewVersion/INR-InsertNewRelease/CLO-CloneFirmware
        private string filtroincorso = "";

        private int LockLevel = 0;

        public UC_FW_R()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////
        /// Private functions
        ////////////////////////////////////////////////////////////////////////////////

        private void AbilitaForm()
        {
            SetFilter();
            this.firmwareBindingSource.Filter = filtroincorso;

            //this.firmwareBindingSource.Sort = "SW_Code Desc";
            this.firmwareBindingSource.Sort = "SW_Order Desc";
            this.firmwareBindingSource.ResetBindings(false);
            gv_FW_R.Refresh();

            radio_FW_all.Checked = true;
            radio_FW_standard.Checked = false;
            radio_FW_custom.Checked = false;

            if (displayform == "V")
            {
                panel_dati.Enabled = false;
                panel_revisioni.Enabled = false;
                panel_funzionamento.Enabled = false;
                panel_FW_R.Enabled = true;
                pan_Menu_comandi.Enabled = true;
                pan_Menu_exit.Enabled = true;
                pan_Menu_salva.Enabled = false;

                gv_FW_R.Enabled = true;
                group_Lock.Enabled = false;
            }

            if (displayform == "INR")
            {
                panel_dati.Enabled = true;
                panel_revisioni.Enabled = true;
                panel_funzionamento.Enabled = true;
                tb_gv_Code.Enabled = false;
                tb_gv_Versione.Enabled = false;
                cbox_SoftwareStandard.Enabled = false;
                tb_gv_Des1.Enabled = false;
                tb_gv_Des2.Enabled = false;
                panel_freq.Enabled = false;
                tog_Exp.Enabled = false;
                tog_Ple.Enabled = false;
                tog_TstEm.Enabled = false;
                tog_optCan.Enabled = false;
                tog_Prop.Enabled = false;
                tb_gv_TimeOut.Enabled = false;
                tb_gv_ContKeys.Enabled = false;
                tog_SameRow.Enabled = false;
                tog_SP.Enabled = false;
                tb_gv_MaxPair.Enabled = false;
                tog_ShiftPage.Enabled = false;
                tb_gv_OutputN.Enabled = false;
                tb_gv_DigInputN.Enabled = false;
                tb_gv_AnaInputN.Enabled = false;
                tog_Radius.Enabled = false;
                tog_PIC.Enabled = false;
                tog_Delay.Enabled = false;

                pan_Menu_comandi.Enabled = false;
                pan_Menu_exit.Enabled = false;
                pan_Menu_salva.Enabled = true;

                panel_FW_R.Enabled = false;
                tb_gv_Revisione.Focus();

                gv_FW_R.Enabled = false;
                group_Lock.Enabled = false;
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

                cbox_SoftwareStandard.Enabled = true;

                tb_gv_Des1.Text = "";
                tb_gv_Des2.Text = "";

                rtb_Revisioni.Text = "";
                rtb_Funzionamento.Text = "";

                pan_Menu_comandi.Enabled = false;
                pan_Menu_exit.Enabled = false;
                pan_Menu_salva.Enabled = true;

                panel_FW_R.Enabled = false;
                tb_gv_Revisione.Focus();

                gv_FW_R.Enabled = false;
                group_Lock.Enabled = true;
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

                cbox_SoftwareStandard.Enabled = true;

                tb_gv_Des1.Text = "";
                tb_gv_Des2.Text = "";

                tog_Exp.Checked = false;
                tog_Ple.Checked = false;
                tog_TstEm.Checked = false;
                tog_optCan.Checked = false;
                tog_Prop.Checked = false;
                tb_gv_TimeOut.Text = "120";
                tb_gv_ContKeys.Text = "1";
                tog_SameRow.Checked = false;
                tog_SP.Checked = false;
                tb_gv_MaxPair.Text = "1";
                tog_ShiftPage.Checked = false;
                tb_gv_OutputN.Text = "";
                tb_gv_DigInputN.Text = "";
                tb_gv_AnaInputN.Text = "";
                tog_Radius.Checked = false;
                tog_PIC.Checked = false;
                tog_Delay.Checked = false;

                rtb_Revisioni.Text = "";
                rtb_Funzionamento.Text = "";

                pan_Menu_comandi.Enabled = false;
                pan_Menu_exit.Enabled = false;
                pan_Menu_salva.Enabled = true;

                panel_FW_R.Enabled = false;
                tb_gv_Revisione.Focus();

                gv_FW_R.Enabled = false;

                LockLevel = 0;
                group_Lock.Enabled = true;
            }

            ManageLock(LockLevel);

            gv_history.DataSource = null;
            gv_history.Refresh();
        }

        private void Riga2DB()
        {
            var newrow = ds_Programmazione.Firmware.NewRow();

            newrow["SW_Code"] = tb_gv_Code.Text;
            newrow["SW_TipoDevice"] = "R";
            newrow["SW_Versione"] = tb_gv_Versione.Text;
            newrow["SW_Revisione"] = tb_gv_Revisione.Text;
            newrow["SW_Descrizione"] = tb_gv_Des1.Text;
            newrow["SW_Descrizione_EN"] = tb_gv_Des2.Text;
            if (cbox_SoftwareStandard.Checked) { newrow["SW_Standard"] = true; } else { newrow["SW_Standard"] = false; }
            if (tog_Exp.Checked) { newrow["SW_R_Opt_Plug_Exp"] = true; } else { newrow["SW_R_Opt_Plug_Exp"] = false; }
            if (tog_Ple.Checked) { newrow["SW_R_Opt_Plug_Ple"] = true; } else { newrow["SW_R_Opt_Plug_Ple"] = false; }
            if (tog_TstEm.Checked) { newrow["SW_R_Opt_Em_Keyb"] = true; } else { newrow["SW_R_Opt_Em_Keyb"] = false; }
            if (tog_optCan.Checked) { newrow["SW_R_Opt_Can"] = true; } else { newrow["SW_R_Opt_Can"] = false; }
            if (tog_Prop.Checked) { newrow["SW_R_Opt_Prop_Out"] = true; } else { newrow["SW_R_Opt_Prop_Out"] = false; }
            newrow["SW_R_Opt_TimeOut"] = tb_gv_TimeOut.Text;
            newrow["SW_R_Opt_Cont_Keys"] = Int32.Parse(tb_gv_ContKeys.Text);
            if (tog_SameRow.Checked) { newrow["SW_R_Opt_LockSameRow"] = true; } else { newrow["SW_R_Opt_LockSameRow"] = false; }
            if (tog_SP.Checked) { newrow["SW_R_Opt_Use_SP"] = true; } else { newrow["SW_R_Opt_Use_SP"] = false; }
            newrow["SW_R_Opt_MaxPairDevices"] = tb_gv_MaxPair.Text;
            if (tog_ShiftPage.Checked) { newrow["SW_R_Opt_ShiftPage"] = true; } else { newrow["SW_R_Opt_ShiftPage"] = false; }
            newrow["SW_R_Opt_Output_No"] = tb_gv_OutputN.Text;
            newrow["SW_R_Opt_Dig_Input_No"] = tb_gv_DigInputN.Text;
            newrow["SW_R_Opt_Ana_Input_No"] = tb_gv_AnaInputN.Text;
            if (tog_Radius.Checked) { newrow["SW_R_Opt_Use_Radius"] = true; } else { newrow["SW_R_Opt_Use_Radius"] = false; }
            newrow["SW_Revisioni"] = rtb_Revisioni.Text;
            newrow["SW_Funzionamento"] = rtb_Funzionamento.Text;
            if (tog_PIC.Checked) { newrow["SW_CustomPIC"] = true; } else { newrow["SW_CustomPIC"] = false; }
            if (tog_Delay.Checked) { newrow["SW_IsPublic"] = true; } else { newrow["SW_IsPublic"] = false; }


            if (cb_868.Checked) { newrow["SW_R_Opt_RF"] = "868|24"; }
            if (cb_433.Checked) { newrow["SW_R_Opt_RF"] = "433"; }
            if (cb_915.Checked) { newrow["SW_R_Opt_RF"] = "915"; }
            if (cb_filo.Checked) { newrow["SW_R_Opt_RF"] = "filo"; }
            if (cb_24.Checked) { newrow["SW_R_Opt_RF"] = "24"; }

            string famcomp = "";
            foreach (DataGridViewRow fam_row in gv_Famiglia.Rows)
            {
                bool isSelected = Convert.ToBoolean(fam_row.Cells["gv_Famiglia_Check"].EditedFormattedValue);
                if (isSelected)
                {
                    famcomp = famcomp + fam_row.Cells["gv_Famiglia_Ident"].Value.ToString();
                }
            }
            newrow["SW_FamProd"] = famcomp;

            newrow["SW_Revisioni"] = rtb_Revisioni.Text;
            newrow["SW_Funzionamento"] = rtb_Funzionamento.Text;
            newrow["SW_R_Lock"] = LockLevel;

            //Campi da riempire NOT NULL
            newrow["SW_P_Opt_RF"] = newrow["SW_R_Opt_RF"];
            newrow["SW_P_Opt_Use_Oled"] = false;
            newrow["SW_P_Opt_Use_EmButt"] = false;
            newrow["SW_P_Opt_Use_Backlight"] = false;
            newrow["SW_P_Opt_ShiftPage"] = false;
            newrow["SW_P_Opt_Use_Accel"] = false;
            newrow["SW_P_Opt_Use_SP"] = false;
            newrow["SW_P_Opt_Use_Buzzer"] = false;
            newrow["SW_P_Opt_Use_Vibracall"] = false;
            newrow["SW_P_Opt_Use_LedTorch"] = false;
            newrow["SW_P_Opt_MaxPairDevices"] = "1";
            newrow["SW_P_PLD"] = false;
            newrow["SW_P_Opt_Use_Radius"] = false;
            ////
            newrow["SW_Obsolete_ver"] = false;
            newrow["SW_P_Lock"] = 0;


            ds_Programmazione.Firmware.Rows.Add(newrow);
            firmwareTableAdapter.Update(newrow);
        }

        private void DB2Riga()
        {
            DataRowView myRow = (DataRowView)firmwareBindingSource.Current;

            tb_gv_Code.Text = myRow["SW_Code"].ToString();
            tb_gv_Versione.Text = myRow["SW_Versione"].ToString();
            tb_gv_Revisione.Text = myRow["SW_Revisione"].ToString();

            tb_gv_Des1.Text = myRow["SW_Descrizione"].ToString();
            tb_gv_Des2.Text = myRow["SW_Descrizione_EN"].ToString();
            bool standard = (bool)myRow["SW_Standard"];
            if (standard) { cbox_SoftwareStandard.Checked = true; } else { cbox_SoftwareStandard.Checked = false; }

            cb_868.Checked = false;
            cb_433.Checked = false;
            cb_915.Checked = false;
            cb_filo.Checked = false;
            cb_24.Checked = false;

            switch (myRow["SW_R_Opt_RF"].ToString())
            {
                case "868|24": cb_868.Checked = true; break;
                case "915": cb_915.Checked = true; break;
                case "433": cb_433.Checked = true; break;
                case "24": cb_24.Checked = true; break;
                case "filo": cb_filo.Checked = true; break;
                default: break;
            }
            tog_Exp.Checked = (bool)myRow["SW_R_Opt_Plug_Exp"];
            tog_Ple.Checked = (bool)myRow["SW_R_Opt_Plug_Ple"];
            tog_TstEm.Checked = (bool)myRow["SW_R_Opt_Em_Keyb"];
            tog_optCan.Checked = (bool)myRow["SW_R_Opt_Can"];
            tog_Prop.Checked = (bool)myRow["SW_R_Opt_Prop_Out"];
            tb_gv_TimeOut.Text = (string)myRow["SW_R_Opt_TimeOut"];
            tb_gv_ContKeys.Text = myRow["SW_R_Opt_Cont_Keys"].ToString();
            tog_SameRow.Checked = (bool)myRow["SW_R_Opt_LockSameRow"];
            tog_SP.Checked = (bool)myRow["SW_R_Opt_Use_SP"];
            tb_gv_MaxPair.Text = myRow["SW_R_Opt_MaxPairDevices"].ToString();
            tog_ShiftPage.Checked = (bool)myRow["SW_R_Opt_ShiftPage"];
            tb_gv_OutputN.Text = myRow["SW_R_Opt_Output_No"].ToString();
            tb_gv_DigInputN.Text = myRow["SW_R_Opt_Dig_Input_No"].ToString();
            tb_gv_AnaInputN.Text = myRow["SW_R_Opt_Ana_Input_No"].ToString();
            tog_Radius.Checked = (bool)myRow["SW_R_Opt_Use_Radius"];
            rtb_Revisioni.Text = myRow["SW_Revisioni"].ToString();
            rtb_Funzionamento.Text = myRow["SW_Funzionamento"].ToString();
            tog_PIC.Checked = (bool)myRow["SW_CustomPIC"];
            tog_Delay.Checked= (bool)myRow["SW_IsPublic"];

            LockLevel = (int)myRow["SW_R_Lock"];
            ManageLock(LockLevel);

            //Crea grid History
            string filtrohistory = "SW_TipoDevice = 'R' and SW_Obsolete_ver and SW_Code = '" + myRow["SW_Code"].ToString() + "'";
            DataView dv_R_history = new DataView(ds_Programmazione.Firmware);
            dv_R_history.RowFilter = filtrohistory;
            gv_history.DataSource = dv_R_history;
            dv_R_history.Sort = "SW_Obsolete_ver_from_date DESC";
            gv_history.Refresh();
            ///////////////////////////////////

            //Crea Grid Famiglia
            string famiglie = myRow["SW_FamProd"].ToString();
            foreach (DataGridViewRow famrow in gv_Famiglia.Rows)
            {
                string cella = famrow.Cells["gv_Famiglia_Ident"].Value.ToString(); //trova identificatore della famiglia

                DataGridViewCheckBoxCell cellcheck = (DataGridViewCheckBoxCell)famrow.Cells["gv_Famiglia_Check"];
                char identificatore = Convert.ToChar(famrow.Cells["gv_Famiglia_Ident"].Value);
                bool trovato = false;
                if (famiglie.IndexOf(identificatore) == -1) { trovato = false; } else { trovato = true; }

                if (cellcheck.Value != null)
                {
                    if (cellcheck.Value.Equals(cellcheck.FalseValue))
                    {
                        cellcheck.Value = cellcheck.TrueValue;
                    }
                    else
                    {
                        cellcheck.Value = cellcheck.FalseValue;
                    }
                }
                else
                {
                    cellcheck.Value = true;
                }


                if (trovato)
                {
                    famrow.Cells["gv_Famiglia_Check"].Value = true;
                }
                else
                {
                    famrow.Cells["gv_Famiglia_Check"].Value = false;
                }

                this.gv_Famiglia.RefreshEdit();
            }

            gv_Famiglia.ClearSelection();
            gv_history.ClearSelection();
        }

        private void CreaCodice()
        {
            if ((tb_gv_Versione.Text != "") && (tb_gv_Revisione.Text != ""))
            {
                string code = "XSWRR";

                if (cbox_SoftwareStandard.Checked) { code = code + "S"; } else { code = code + "C"; }

                code = code + tb_gv_Versione.Text.ToUpper();

                string freq = "";
                if (cb_868.Checked) { freq = "X"; }
                if (cb_915.Checked) { freq = "A"; }
                if (cb_433.Checked) { freq = "B"; }
                if (cb_filo.Checked) { freq = "N"; }
                if (cb_24.Checked) { freq = "G"; }

                code = code + freq + "_L";
                tb_gv_Code.Text = code;
                tb_gv_Code.Refresh();
            }
        }

        private void SetView()
        {
            SetFilter();
            firmwareBindingSource.Filter = filtroincorso;

            firmwareBindingSource.MoveFirst();
            if (firmwareBindingSource.Current != null)
            {
                DB2Riga();
            }

            gv_FW_R.Refresh();
        }

        private void SetFilter()
        {
            filtroincorso = "SW_TipoDevice = 'R' and not SW_Obsolete_ver";

            if (GVar.gl_tipofiltro_FW_R == "A") { filtroincorso = filtroincorso; }
            if (GVar.gl_tipofiltro_FW_R == "S") { filtroincorso = filtroincorso + " and (SW_Standard = 1)"; }
            if (GVar.gl_tipofiltro_FW_R == "C") { filtroincorso = filtroincorso + " and (SW_Standard = 0)"; }

        }

        private void ManageLock(int LockLevel)
        {
            switch (LockLevel)
            {
                case 0:
                    cb_Lock_0.Checked = true;
                    cb_Lock_1.Checked = false;
                    cb_Lock_2.Checked = false;
                    cb_Lock_3.Checked = false;
                    break;
                case 1:
                    cb_Lock_0.Checked = false;
                    cb_Lock_1.Checked = true;
                    cb_Lock_2.Checked = false;
                    cb_Lock_3.Checked = false;
                    break;
                case 2:
                    cb_Lock_0.Checked = false;
                    cb_Lock_1.Checked = false;
                    cb_Lock_2.Checked = true;
                    cb_Lock_3.Checked = false;
                    break;
                case 3:
                    cb_Lock_0.Checked = false;
                    cb_Lock_1.Checked = false;
                    cb_Lock_2.Checked = false;
                    cb_Lock_3.Checked = true;
                    break;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////
        /// Generated functions
        ////////////////////////////////////////////////////////////////////////////////

        private void uscitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_FW_R_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.Fam_Prod'. È possibile spostarla o rimuoverla se necessario.
            this.fam_ProdTableAdapter.FillBy_Famiglie_FW_R(this.ds_SL.Fam_Prod);

            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.Firmware'. È possibile spostarla o rimuoverla se necessario.
            this.firmwareTableAdapter.Fill(this.ds_Programmazione.Firmware);

            GVar.formclosing = false;

            displayform = "V";

            AbilitaForm();
            radio_FW_all.Checked = true;
            radio_FW_standard.Checked = false;
            radio_FW_custom.Checked = false;

            firmwareBindingSource.MoveFirst();
            if (firmwareBindingSource.Current != null)
            {
                DB2Riga();
            }
        }

        private void gv_FW_R_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (GVar.formclosing) { return; }

            foreach (DataGridViewRow x in gv_FW_R.Rows)
            {
                x.MinimumHeight = 30;
            }
        }

        private void UC_FW_R_FormClosing(object sender, FormClosingEventArgs e)
        {
            GVar.formclosing = true;
        }

        private void gv_history_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (GVar.formclosing) { return; }

            foreach (DataGridViewRow x in gv_history.Rows)
            {
                x.MinimumHeight = 30;
            }
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void creaRevisioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayform = "INR";
            AbilitaForm();

            //Modifico valori iniziali
            var sourceRow = ((DataRowView)firmwareBindingSource.Current).Row;
            int rev = Convert.ToInt32(sourceRow["SW_Revisione"].ToString());
            rev++;
            tb_gv_Revisione.Text = rev.ToString();
            tb_gv_Revisione.Refresh();

            string data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            //string line1 = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss") + " - Nuova revisione, la precedente era " + sourceRow["SW_Revisione"].ToString() + "\r\n";
            string line1 = data + " - Nuova revisione, la precedente era " + sourceRow["SW_Revisione"].ToString() + "\r\n";
            string result = new String('-', 100);
            string line2 = result + "\r\n";
            rtb_Revisioni.Text = line1 + line2 + rtb_Revisioni.Text;
            rtb_Revisioni.Refresh();

        }

        private void menu_sw_annulla_Click(object sender, EventArgs e)
        {
            firmwareBindingSource.SuspendBinding();
            firmwareTableAdapter.Fill(this.ds_Programmazione.Firmware);
            firmwareBindingSource.ResumeBinding();

            firmwareBindingSource.MoveFirst();

            displayform = "V";
            DB2Riga();

            gv_FW_R.Refresh();
            gv_Famiglia.Refresh();

            AbilitaForm();
        }

        private void menu_sw_salva_Click(object sender, EventArgs e) 
        {
            if (tb_gv_Des1.Text == "")
            {
                MessageBox.Show("Si prega di compilare correttamente il campo descrizione. \nNon può essere vuoto!");
                tb_gv_Des1.Focus();
                return;
            }
            if (tb_gv_Des2.Text == "")
            {
                MessageBox.Show("Si prega di compilare correttamente il campo descrizione. \nNon può essere vuoto!");
                tb_gv_Des2.Focus();
                return;
            }

            int myInt = 0;
            bool isNumerical = int.TryParse(tb_gv_OutputN.Text, out myInt);
            if (!isNumerical)
            {
                MessageBox.Show("Si prega di compilare correttamente il Numero Output. \nNon può essere vuoto o con caratteri alfabetici!");
                tb_gv_OutputN.Focus();
                return;
            }

            myInt = 0;
            isNumerical = int.TryParse(tb_gv_DigInputN.Text, out myInt);
            if (!isNumerical)
            {
                MessageBox.Show("Si prega di compilare correttamente il Numero Input Digitali. \nNon può essere vuoto o con caratteri alfabetici!");
                tb_gv_DigInputN.Focus();
                return;
            }

            myInt = 0;
            isNumerical = int.TryParse(tb_gv_AnaInputN.Text, out myInt);
            if (!isNumerical)
            {
                MessageBox.Show("Si prega di compilare correttamente il Numero Input Analogici. \nNon può essere vuoto o con caratteri alfabetici!");
                tb_gv_AnaInputN.Focus();
                return;
            }

            Riga2DB();

            firmwareBindingSource.SuspendBinding();
            firmwareTableAdapter.Fill(this.ds_Programmazione.Firmware);
            firmwareBindingSource.ResumeBinding();

            firmwareBindingSource.MoveFirst();

            displayform = "V";
            DB2Riga();

            gv_FW_R.Refresh();
            gv_Famiglia.Refresh();

            AbilitaForm();
        }

        private void firmwareBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DB2Riga();
        }

        private void menu_sw_clona_Click(object sender, EventArgs e)
        {
            displayform = "CLO";

            //Modifico valori iniziali
            var sourceRow = ((DataRowView)firmwareBindingSource.Current).Row;
            AbilitaForm();
            tb_gv_Versione.Focus();
        }

        private void tb_gv_Versione_Validating(object sender, CancelEventArgs e)
        {
            string ver = tb_gv_Versione.Text;
            if (ver.Length > 6) { MessageBox.Show("Errore di digitazione! La versione non può essere superiore a 6 caratteri!"); tb_gv_Versione.Focus(); return; }
            if (ver.Length < 6) { string padded = ver.PadLeft(6, '0'); tb_gv_Versione.Text = padded; tb_gv_Versione.Refresh(); }

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
                cb_24.Checked = false;
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
                cb_24.Checked = false;
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
                cb_24.Checked = false;
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
                cb_24.Checked = false;
            }
            CreaCodice();
        }

        private void cb_24_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_24.Checked)
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

            //Modifico valori iniziali
            var sourceRow = ((DataRowView)firmwareBindingSource.Current).Row;
            AbilitaForm();
            tb_gv_Versione.Focus();
        }

        private void radio_FW_all_Click(object sender, EventArgs e)
        {
            GVar.gl_tipofiltro_FW_R = "A";
            SetView();

        }

        private void radio_FW_standard_Click(object sender, EventArgs e)
        {
            GVar.gl_tipofiltro_FW_R = "S";
            SetView();
        }

        private void radio_FW_custom_Click(object sender, EventArgs e)
        {
            GVar.gl_tipofiltro_FW_R = "C";
            SetView();
        }

        private void cb_Lock_0_Click(object sender, EventArgs e)
        {
            ManageLock(0);
        }

        private void cb_Lock_1_Click(object sender, EventArgs e)
        {
            ManageLock(1);
        }

        private void cb_Lock_2_Click(object sender, EventArgs e)
        {
            ManageLock(2);
        }

        private void cb_Lock_3_Click(object sender, EventArgs e)
        {
            ManageLock(3);
        }
    }
}
