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
    public partial class UC_FW_R_Classic : MetroFramework.Forms.MetroForm
    {
        private string displayform = "V"; // V-View/INV-InsertNewVersion/INR-InsertNewRelease/CLO-CloneFirmware
        private string filtroincorso = "FW_CL_R_Obsolete_ver = 0";

        public UC_FW_R_Classic()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////
        /// Private functions
        ////////////////////////////////////////////////////////////////////////////////

        private void AbilitaForm()
        {
            gv_FW_R.RowTemplate.MinimumHeight = 30;

            SetFilter();
            this.CL_Ricevitori_BindingSource.Filter = filtroincorso;

            this.CL_Ricevitori_BindingSource.Sort = "FW_CL_R_SW_Versione DESC";
            this.CL_Ricevitori_BindingSource.ResetBindings(false);
            gv_FW_R.Refresh();

            radio_FW_attivi.Checked = true;
            radio_FW_obsolete.Checked = false;

            if (displayform == "V")
            {
                panel_intestazione.Enabled = false;
                panel_dati.Enabled = false;
                panel_revisioni.Enabled = false;
                panel_funzionamento.Enabled = false;
                panel_FW_R.Enabled = true;
                pan_Menu_comandi.Enabled = true;
                pan_Menu_exit.Enabled = true;
                pan_Menu_salva.Enabled = false;

                gv_FW_R.Enabled = true;
            }

            if (displayform == "INV")
            {
                panel_intestazione.Enabled = true;
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


                cb_868.Checked = true;
                tog_Pair.Checked = false;
                tog_Golden.Checked = false;
                tog_SPAttivo.Checked = false;
                tog_SPPassivo.Checked = false;
                tog_PlugConfig.Checked = false;
                tb_TimeOut.Text = "120";
                tb_ContTasti.Text = "1";
                tog_CambioPagina.Checked = false;
                tog_CambioRicevitore.Checked = false;
                tb_NumPalmari.Text = "1";
                tog_MotRim.Checked = false;
                tb_NumOutput.Text = "";
                tb_NumInpDig.Text = "";
                tb_NumInpAn.Text = "";
                tog_ProportionalOutput.Checked = false;
                tog_MasterOutput.Checked = false;
                tog_EmergencyOutput.Checked = false;
                tb_IdentifRic.Text = "";
                cb_FwAbbinato.Text = "";
                cb_Famiglia.Text = "";


                rtb_Revisioni.Text = "";
                rtb_Funzionamento.Text = "";

                pan_Menu_comandi.Enabled = false;
                pan_Menu_exit.Enabled = false;
                pan_Menu_salva.Enabled = true;

                panel_FW_R.Enabled = false;
                tb_gv_Revisione.Focus();

                gv_FW_R.Enabled = false;
            }

            if (displayform == "INR")
            {
                //heading
                panel_intestazione.Enabled = true;
                panel_dati.Enabled = true;
                panel_revisioni.Enabled = true;
                panel_funzionamento.Enabled = true;
                tb_gv_Code.Enabled = false;
                tb_gv_Versione.Enabled = false;
                panel_freq.Enabled = false;

                //prima colonna
                tog_Pair.Enabled = false;
                tog_Golden.Enabled = false;
                tog_SPAttivo.Enabled = false;
                tog_SPPassivo.Enabled = false;
                tog_PlugConfig.Enabled = false;

                //seconda colonna
                tog_CambioPagina.Enabled = false;
                tog_CambioRicevitore.Enabled = false;
                tog_MotRim.Enabled = false;
                tb_IdentifRic.Enabled = false;
                tb_NumPalmari.Enabled = false;

                //terza colonna
                tog_MasterOutput.Enabled = false;
                tog_EmergencyOutput.Enabled = false;
                tog_ProportionalOutput.Enabled = false;
                tb_NumOutput.Enabled = false;
                tb_NumInpAn.Enabled = false;
                tb_NumInpDig.Enabled = false;

                //seconda riga
                tb_ContTasti.Enabled = false;
                tb_TimeOut.Enabled = false;
                cb_FwAbbinato.Enabled = false;

                //pannelli
                panel_FW_R.Enabled = false;
                tb_gv_Revisione.Focus();

                //comandi
                pan_Menu_comandi.Enabled = false;
                pan_Menu_exit.Enabled = false;
                pan_Menu_salva.Enabled = true;

                gv_FW_R.Enabled = false;
            }

            if (displayform == "CLO")
            {
                panel_intestazione.Enabled = true;
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

                rtb_Revisioni.Text = "";
                rtb_Funzionamento.Text = "";

                pan_Menu_comandi.Enabled = false;
                pan_Menu_exit.Enabled = false;
                pan_Menu_salva.Enabled = true;

                panel_FW_R.Enabled = false;
                tb_gv_Revisione.Focus();

                gv_FW_R.Enabled = false;
            }
        }

        private void Riga2DB()
        {
            var newrow = ds_CL_Firmware.FW_CL_Ricevitori.NewRow();

            newrow["FW_CL_R_SW_Code"] = tb_gv_Code.Text;
            newrow["FW_CL_R_SW_Versione"] = tb_gv_Versione.Text;
            newrow["FW_CL_R_SW_Revisione"] = tb_gv_Revisione.Text;
            newrow["FW_CL_R_TipoDev"] = cb_Famiglia.SelectedValue;

            if (cb_868.Checked) { newrow["FW_CL_R_Freq"] = "X"; }
            if (cb_433.Checked) { newrow["FW_CL_R_Freq"] = "A"; }
            if (cb_915.Checked) { newrow["FW_CL_R_Freq"] = "B"; }
            if (cb_filo.Checked) { newrow["FW_CL_R_Freq"] = "N"; }
            if (cb_can.Checked) { newrow["FW_CL_R_Freq"] = "C"; }

            if (tog_Pair.Checked) { newrow["FW_CL_R_AutoPairing"] = true; } else { newrow["FW_CL_R_AutoPairing"] = false; }
            if (tog_Golden.Checked) { newrow["FW_CL_R_Golden"] = true; } else { newrow["FW_CL_R_Golden"] = false; }
            if (tog_SPAttivo.Checked) { newrow["FW_CL_R_SPAttivo"] = true; } else { newrow["FW_CL_R_SPAttivo"] = false; }
            if (tog_SPPassivo.Checked) { newrow["FW_CL_R_SPPassivo"] = true; } else { newrow["FW_CL_R_SPPassivo"] = false; }
            if (tog_PlugConfig.Checked) { newrow["FW_CL_R_PlugConfig"] = true; } else { newrow["FW_CL_R_PlugConfig"] = false; }
            if (tog_CambioPagina.Checked) { newrow["FW_CL_R_CambioPag"] = true; } else { newrow["FW_CL_R_CambioPag"] = false; }
            if (tog_CambioRicevitore.Checked) { newrow["FW_CL_R_CambioRic"] = true; } else { newrow["FW_CL_R_CambioRic"] = false; }
            if (tog_MotRim.Checked) { newrow["FW_CL_R_MotRim"] = true; } else { newrow["FW_CL_R_MotRim"] = false; }
            if (tog_MasterOutput.Checked) { newrow["FW_CL_R_MasterOutput"] = true; } else { newrow["FW_CL_R_MasterOutput"] = false; }
            if (tog_EmergencyOutput.Checked) { newrow["FW_CL_R_EmergencyOutput"] = true; } else { newrow["FW_CL_R_EmergencyOutput"] = false; }
            if (tog_ProportionalOutput.Checked) { newrow["FW_CL_R_ProportionalOutput"] = true; } else { newrow["FW_CL_R_ProportionalOutput"] = false; }

            newrow["FW_CL_R_IdentificazioneRic"] = Int32.Parse(tb_IdentifRic.Text);
            newrow["FW_CL_R_NumPalmari"] = Int32.Parse(tb_NumPalmari.Text);
            newrow["FW_CL_R_NumOutput"] = Int32.Parse(tb_NumOutput.Text);
            newrow["FW_CL_R_NumInputAn"] = Int32.Parse(tb_NumInpAn.Text);
            newrow["FW_CL_R_NumInputDig"] = Int32.Parse(tb_NumInpDig.Text);
            newrow["FW_CL_R_ContempTasti"] = Int32.Parse(tb_ContTasti.Text);
            newrow["FW_CL_R_TimeOut"] = Int32.Parse(tb_TimeOut.Text);

            newrow["FW_CL_R_Revisioni"] = rtb_Revisioni.Text;
            newrow["FW_CL_R_Funzionamento"] = rtb_Funzionamento.Text;

            //Campi da riempire NOT NULL
            //newrow["SW_P_Opt_RF"] = newrow["SW_R_Opt_RF"];
            //newrow["SW_P_Opt_Use_Oled"] = false;
            //newrow["SW_P_Opt_Use_EmButt"] = false;
            //newrow["SW_P_Opt_Use_Backlight"] = false;
            //newrow["SW_P_Opt_ShiftPage"] = false;
            //newrow["SW_P_Opt_Use_Accel"] = false;
            //newrow["SW_P_Opt_Use_SP"] = false;
            //newrow["SW_P_Opt_Use_Buzzer"] = false;
            //newrow["SW_P_Opt_Use_Vibracall"] = false;
            //newrow["SW_P_Opt_Use_LedTorch"] = false;
            //newrow["SW_P_Opt_MaxPairDevices"] = "1";
            //newrow["SW_P_PLD"] = false;
            //newrow["SW_P_Opt_Use_Radius"] = false;
            //////
            ///
            newrow["FW_CL_R_Obsolete_ver"] = false;

            newrow["FW_CL_R_CanBus"] = false;

            ds_CL_Firmware.FW_CL_Ricevitori.Rows.Add(newrow);
            CL_Ricevitori_TableAdapter.Update(newrow);
        }

        private void DB2Riga()
        {
            if (CL_Ricevitori_BindingSource.Current != null)
            {
                DataRowView myRow = (DataRowView)CL_Ricevitori_BindingSource.Current;

                tb_gv_Code.Text = myRow["FW_CL_R_SW_Code"].ToString();
                tb_gv_Versione.Text = myRow["FW_CL_R_SW_Versione"].ToString();
                tb_gv_Revisione.Text = myRow["FW_CL_R_SW_Revisione"].ToString();

                cb_868.Checked = false;
                cb_433.Checked = false;
                cb_915.Checked = false;
                cb_filo.Checked = false;
                cb_can.Checked = false;

                //Locate Famiglia Bindingsource
                int fam_id = (int)myRow["FW_CL_R_TipoDev"];
                int foundIndex = CL_Famiglie_BindingSource.Find("FW_CL_Fam_ID", fam_id);
                if (foundIndex > -1)
                {
                    CL_Famiglie_BindingSource.Position = foundIndex;
                    DataRowView row = (DataRowView)CL_Famiglie_BindingSource.Current;
                    cb_Famiglia.SelectedItem = row["FW_CL_Fam_Des"].ToString();
                    cb_Famiglia.Refresh();
                }

                switch (myRow["FW_CL_R_Freq"].ToString())
                {
                    case "X": cb_868.Checked = true; break;
                    case "A": cb_915.Checked = true; break;
                    case "B": cb_433.Checked = true; break;
                    case "C": cb_can.Checked = true; break;
                    case "N": cb_filo.Checked = true; break;
                    default: break;
                }

                tog_Pair.Checked = (bool)myRow["FW_CL_R_AutoPairing"];
                tog_Golden.Checked = (bool)myRow["FW_CL_R_Golden"];
                tog_SPAttivo.Checked = (bool)myRow["FW_CL_R_SPAttivo"];
                tog_SPPassivo.Checked = (bool)myRow["FW_CL_R_SPPassivo"];
                tog_PlugConfig.Checked = (bool)myRow["FW_CL_R_PlugConfig"];
                tog_CambioPagina.Checked = (bool)myRow["FW_CL_R_CambioPag"];
                tog_CambioRicevitore.Checked = (bool)myRow["FW_CL_R_CambioRic"];
                tog_MotRim.Checked = (bool)myRow["FW_CL_R_MotRim"];
                tog_MasterOutput.Checked = (bool)myRow["FW_CL_R_MasterOutput"];
                tog_EmergencyOutput.Checked = (bool)myRow["FW_CL_R_EmergencyOutput"];
                tog_ProportionalOutput.Checked = (bool)myRow["FW_CL_R_ProportionalOutput"];

                tb_IdentifRic.Text = myRow["FW_CL_R_IdentificazioneRic"].ToString();
                tb_NumPalmari.Text = myRow["FW_CL_R_NumPalmari"].ToString();
                tb_NumOutput.Text = myRow["FW_CL_R_NumOutput"].ToString();
                tb_NumInpAn.Text = myRow["FW_CL_R_NumInputAn"].ToString();
                tb_NumInpDig.Text = myRow["FW_CL_R_NumInputDig"].ToString();
                tb_ContTasti.Text = myRow["FW_CL_R_ContempTasti"].ToString();
                tb_TimeOut.Text = myRow["FW_CL_R_TimeOut"].ToString();

                rtb_Revisioni.Text = myRow["FW_CL_R_Revisioni"].ToString();
                rtb_Funzionamento.Text = myRow["FW_CL_R_Funzionamento"].ToString();
            }
        }

        private void CreaCodice()
        {
            if ((tb_gv_Versione.Text != "") && (tb_gv_Revisione.Text != ""))
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
                tb_gv_Code.Refresh();
            }
        }

        private void SetView()
        {
            SetFilter();
            CL_Ricevitori_BindingSource.Filter = filtroincorso;

            CL_Ricevitori_BindingSource.MoveFirst();
            if (CL_Ricevitori_BindingSource.Current != null)
            {
                DB2Riga();
            }

            gv_FW_R.Refresh();
        }

        private void SetFilter()
        {

            if (radio_FW_attivi.Checked)
            {
                filtroincorso = "FW_CL_R_Obsolete_ver = 0";
            }
            if (radio_FW_obsolete.Checked)
            {
                filtroincorso = "FW_CL_R_Obsolete_ver = 0 OR FW_CL_R_Obsolete_ver = 1";
            }
        }

        ////////////////////////////////////////////////////////////////////////////////
        /// Generated functions
        ////////////////////////////////////////////////////////////////////////////////

        private void uscitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_FW_R_Classic_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_CL_Firmware.FW_CL_Famiglie'. È possibile spostarla o rimuoverla se necessario.
            this.CL_Famiglie_TableAdapter.Fill(this.ds_CL_Firmware.FW_CL_Famiglie);
            //// TODO: questa riga di codice carica i dati nella tabella 'ds_CL_Firmware.FW_CL_Ricevitori'. È possibile spostarla o rimuoverla se necessario.
            this.CL_Ricevitori_TableAdapter.Fill(this.ds_CL_Firmware.FW_CL_Ricevitori);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_CL_Firmware.FW_CL_Palmari'. È possibile spostarla o rimuoverla se necessario.
            this.CL_Palmari_TableAdapter.Fill(this.ds_CL_Firmware.FW_CL_Palmari);

            GVar.formclosing = false;

            displayform = "V";

            AbilitaForm();
            radio_FW_attivi.Checked = true;
            radio_FW_obsolete.Checked = false;

            CL_Ricevitori_BindingSource.MoveFirst();
            if (CL_Ricevitori_BindingSource.Current != null)
            {
                DB2Riga();
            }
        }

        private void UC_FW_R_Classic_FormClosing(object sender, FormClosingEventArgs e)
        {
            GVar.formclosing = true;
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
            var sourceRow = ((DataRowView)CL_Ricevitori_BindingSource.Current).Row;
            int rev = Convert.ToInt32(sourceRow["FW_CL_R_SW_Revisione"].ToString());
            rev++;
            tb_gv_Revisione.Text = rev.ToString();
            tb_gv_Revisione.Refresh();

            string data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            //string line1 = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss") + " - Nuova revisione, la precedente era " + sourceRow["SW_Revisione"].ToString() + "\r\n";
            string line1 = data + " - Nuova revisione, la precedente era " + sourceRow["FW_CL_R_SW_Revisione"].ToString() + "\r\n";
            string result = new String('-', 100);
            string line2 = result + "\r\n";
            rtb_Revisioni.Text = line1 + line2 + rtb_Revisioni.Text;
            rtb_Revisioni.Refresh();
        }

        private void menu_sw_annulla_Click(object sender, EventArgs e)
        {
            CL_Ricevitori_BindingSource.SuspendBinding();
            this.CL_Ricevitori_TableAdapter.Fill(this.ds_CL_Firmware.FW_CL_Ricevitori);
            CL_Ricevitori_BindingSource.ResumeBinding();

            CL_Ricevitori_BindingSource.MoveFirst();

            displayform = "V";
            DB2Riga();

            gv_FW_R.Refresh();

            AbilitaForm();
        }

        private void menu_sw_salva_Click(object sender, EventArgs e)
        {

            int myInt = 0;
            bool isNumerical = int.TryParse(tb_NumOutput.Text, out myInt);
            if (!isNumerical)
            {
                MessageBox.Show("Si prega di compilare correttamente il Numero Output. \nNon può essere vuoto o con caratteri alfabetici!");
                tb_NumOutput.Focus();
                return;
            }

            myInt = 0;
            isNumerical = int.TryParse(tb_NumInpAn.Text, out myInt);
            if (!isNumerical)
            {
                MessageBox.Show("Si prega di compilare correttamente il Numero Input Digitali. \nNon può essere vuoto o con caratteri alfabetici!");
                tb_NumInpAn.Focus();
                return;
            }

            myInt = 0;
            isNumerical = int.TryParse(tb_NumInpDig.Text, out myInt);
            if (!isNumerical)
            {
                MessageBox.Show("Si prega di compilare correttamente il Numero Input Analogici. \nNon può essere vuoto o con caratteri alfabetici!");
                tb_NumInpDig.Focus();
                return;
            }

            myInt = 0;
            isNumerical = int.TryParse(tb_IdentifRic.Text, out myInt);
            if (!isNumerical)
            {
                MessageBox.Show("Si prega di compilare correttamente il tipo di Identificazione Ricevitore. \nNon può essere vuoto o con caratteri alfabetici!");
                tb_IdentifRic.Focus();
                return;
            }
            if (myInt > 3)
            {
                MessageBox.Show("I valori accettati  per il tipo di Identificazione sono solo 0, 1, 2 e 3. \nSi prega di controllare e correggere.");
                tb_IdentifRic.Focus();
                return;
            }

            myInt = 0;
            isNumerical = int.TryParse(tb_ContTasti.Text, out myInt);
            if (!isNumerical)
            {
                MessageBox.Show("Si prega di compilare correttamente la tipologia di Contemporaneità dei Tasti. \nNon può essere vuoto o con caratteri alfabetici!");
                tb_ContTasti.Focus();
                return;
            }
            if (myInt > 2)
            {
                MessageBox.Show("I valori accettati  per la tipologia di Contemporaneità dei Tasti sono solo 0, 1 e 2. \nSi prega di controllare e correggere.");
                tb_ContTasti.Focus();
                return;
            }


            Riga2DB();

            CL_Ricevitori_BindingSource.SuspendBinding();
            this.CL_Ricevitori_TableAdapter.Fill(this.ds_CL_Firmware.FW_CL_Ricevitori);
            CL_Ricevitori_BindingSource.ResumeBinding();

            CL_Ricevitori_BindingSource.MoveFirst();

            displayform = "V";
            DB2Riga();

            gv_FW_R.Refresh();

            AbilitaForm();
        }

        private void menu_sw_clona_Click(object sender, EventArgs e)
        {
            displayform = "CLO";

            //Modifico valori iniziali
            var sourceRow = ((DataRowView)CL_Ricevitori_BindingSource.Current).Row;
            AbilitaForm();
            tb_gv_Versione.Focus();
        }

        private void tb_gv_Versione_Validating(object sender, CancelEventArgs e)
        {
            tb_gv_Versione.Text = tb_gv_Versione.Text.ToUpper();
            tb_gv_Versione.Refresh();
            string ver = tb_gv_Versione.Text;

            if (ver.Length > 5) { MessageBox.Show("Errore di digitazione! La versione non può essere superiore a 5 caratteri!"); tb_gv_Versione.Focus(); return; }
            if (ver.Length < 5) { string padded = ver.PadLeft(5, '0'); tb_gv_Versione.Text = padded; tb_gv_Versione.Refresh(); }

            //Verifica se già presente
            if (displayform == "INV")
            {
                int contarec = (int)this.CL_Ricevitori_TableAdapter.Get_Version_Exists(tb_gv_Versione.Text);
                if (contarec != 0) { MessageBox.Show("Questa versione di firmware è già presente!"); tb_gv_Versione.Text = string.Empty; tb_gv_Versione.Focus(); return; }
            }

            CreaCodice();
        }

        private void tb_gv_Revisione_Validating(object sender, CancelEventArgs e)
        {
            string rev = tb_gv_Revisione.Text;
            if (rev.Length > 3) { MessageBox.Show("Errore di digitazione! La revisione non può essere superiore a 3 caratteri!"); tb_gv_Revisione.Focus(); return; }
            if (rev.Length < 3) { string padded = rev.PadLeft(3, '0'); tb_gv_Revisione.Text = padded; tb_gv_Revisione.Refresh(); }

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
        }

        private void radio_FW_attivi_Click(object sender, EventArgs e)
        {
            GVar.gl_tipofiltro_FW_R = "A";
            SetView();
        }

        private void radio_FW_obsolete_Click(object sender, EventArgs e)
        {
            GVar.gl_tipofiltro_FW_R = "O";
            SetView();
        }

        private void tb_IdentifRic_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(tb_IdentifRic, "Opzioni: 0-Input, 1-DipSwitch, 2-FW Specifico, 3-Attivo");
        }

        private void tb_NumPalmari_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(tb_NumPalmari, "Numero di Palmari collegati");
        }

        private void tb_ContTasti_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(tb_ContTasti, "Opzioni: 0-Nessuna, 1-Non in riga, 2-Altro");
        }

        private void CL_Ricevitori_BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DB2Riga();
        }
    }
}
