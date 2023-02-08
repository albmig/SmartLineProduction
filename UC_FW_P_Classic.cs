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
            gv_FW_P.RowTemplate.MinimumHeight = 30;

            SetFilter();
            this.CL_Palmari_BindingSource.Filter = filtroincorso;

            this.CL_Palmari_BindingSource.Sort = "FW_CL_P_SW_Versione ASC";
            this.CL_Palmari_BindingSource.ResetBindings(false);
            gv_FW_P.Refresh();

            if (displayform == "V")
            {
                panel_intestazione.Enabled = false;
                panel_dati.Enabled = false;
                panel_revisioni.Enabled = false;
                panel_funzionamento.Enabled = false;
                panel_FW_P.Enabled = true;
                pan_Menu_comandi.Enabled = true;
                pan_Menu_exit.Enabled = true;
                pan_Menu_salva.Enabled = false;

                gv_FW_P.Enabled = true;
            }

            if (displayform == "INR")
            {
                panel_intestazione.Enabled = true;
                panel_dati.Enabled = true;
                panel_revisioni.Enabled = true;
                panel_funzionamento.Enabled = true;
                tb_gv_Code.Enabled = false;
                tb_gv_Versione.Enabled = false;

                tog_CambioPag.Enabled = true;
                tog_CambioRic.Enabled = true;
                tog_MotRim.Enabled = true;
                tog_Retroill.Enabled = true;
                tog_SPAttivo.Enabled = true;
                
                pan_Menu_comandi.Enabled = false;
                pan_Menu_exit.Enabled = false;
                pan_Menu_salva.Enabled = true;

                panel_FW_P.Enabled = false;
                tb_gv_Revisione.Focus();

                gv_FW_P.Enabled = false;
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

                panel_FW_P.Enabled = false;
                tb_gv_Revisione.Focus();

                gv_FW_P.Enabled = false;
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

                tog_CambioPag.Checked = false;
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
            }
        }

        private void menu_sw_annulla_Click(object sender, EventArgs e)
        {
            CL_Palmari_BindingSource.SuspendBinding();
            this.CL_Palmari_TableAdapter.Fill(this.ds_CL_Firmware.FW_CL_Palmari);
            CL_Palmari_BindingSource.ResumeBinding();

            CL_Palmari_BindingSource.MoveFirst();

            displayform = "V";
            DB2Riga();

            gv_FW_P.Refresh();

            AbilitaForm();
        }

        private void menu_sw_salva_Click(object sender, EventArgs e)
        {
            Riga2DB();

            CL_Palmari_BindingSource.SuspendBinding();
            this.CL_Palmari_TableAdapter.Fill(this.ds_CL_Firmware.FW_CL_Palmari);
            CL_Palmari_BindingSource.ResumeBinding();

            CL_Palmari_BindingSource.MoveFirst();

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

            newrow["FW_CL_P_FwRAbbinato"] = tb_fwAbbinato.Text;
            newrow["FW_CL_P_Revisioni"] = rtb_Revisioni.Text;
            newrow["FW_CL_P_Funzionamento"] = rtb_Funzionamento.Text;

            newrow["FW_CL_P_Obsolete_ver"] = false;
            newrow["FW_CL_P_CanBus"] = false;
            newrow["FW_CL_P_NumRicevitori"] = tB_NRicevCom.Text;

            ds_CL_Firmware.FW_CL_Palmari.Rows.Add(newrow);
            CL_Palmari_TableAdapter.Update(newrow);
        }

        private void DB2Riga()
        {
            if (CL_Palmari_BindingSource.Current != null)
            {
                DataRowView myRow = (DataRowView)CL_Palmari_BindingSource.Current;

                tb_gv_Code.Text = myRow["FW_CL_P_SW_Code"].ToString();
                tb_gv_Versione.Text = myRow["FW_CL_P_SW_Versione"].ToString();
                tb_gv_Revisione.Text = myRow["FW_CL_P_SW_Revisione"].ToString();


                cb_868.Checked = false;
                cb_433.Checked = false;
                cb_915.Checked = false;
                cb_filo.Checked = false;
                cb_can.Checked = false;

                //Locate Famiglia Bindingsource
                int fam_id = (int)myRow["FW_CL_P_TipoDev"];
                int foundIndex = CL_Famiglie_BindingSource.Find("FW_CL_Fam_ID", fam_id);
                cb_Famiglia.SelectedIndex = foundIndex;
                cb_Famiglia.Refresh();

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
            }
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
                tb_gv_Code.Refresh();
            }
        }

        private void SetView()
        {
            SetFilter();
            CL_Palmari_BindingSource.Filter = filtroincorso;

            CL_Palmari_BindingSource.MoveFirst();
            if (CL_Palmari_BindingSource.Current != null)
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
            }
        }

        ////////////////////////////////////////////////////////////////////////////////
        /// Generated functions
        ////////////////////////////////////////////////////////////////////////////////

        private void uscitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_FW_P_Classic_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_CL_Firmware.FW_CL_Ricevitori'. È possibile spostarla o rimuoverla se necessario.
            this.CL_Ricevitori_TableAdapter.Fill(this.ds_CL_Firmware.FW_CL_Ricevitori);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_CL_Firmware.FW_CL_Famiglie'. È possibile spostarla o rimuoverla se necessario.
            this.CL_Famiglie_TableAdapter.Fill(this.ds_CL_Firmware.FW_CL_Famiglie);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_CL_Firmware.FW_CL_Palmari'. È possibile spostarla o rimuoverla se necessario.
            this.CL_Palmari_TableAdapter.Fill(this.ds_CL_Firmware.FW_CL_Palmari);


            GVar.formclosing = false;

            displayform = "V";

            AbilitaForm();
            radio_FW_active.Checked = true;
            radio_FW_obsoleti.Checked = false;

            CL_Palmari_BindingSource.MoveFirst();
            if (CL_Palmari_BindingSource.Current != null)
            {
                DB2Riga();
            }

        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            var sourceRow = ((DataRowView)CL_Palmari_BindingSource.Current).Row;
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

        private void menu_sw_clona_Click(object sender, EventArgs e)
        {
            displayform = "CLO";

            //Modifico valori iniziali
            var sourceRow = ((DataRowView)CL_Palmari_BindingSource.Current).Row;
            AbilitaForm();
            tb_gv_Versione.Focus();
        }

        private void tb_gv_Versione_Validating(object sender, CancelEventArgs e)
        {
            tb_gv_Versione.Text = tb_gv_Versione.Text.ToUpper();
            tb_gv_Versione.Refresh();
            string ver = tb_gv_Versione.Text.ToUpper();

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
        }

        private void radio_FW_all_Click(object sender, EventArgs e)
        {
            SetView();
        }

        private void radio_FW_Obsoleti_Click(object sender, EventArgs e)
        {
            SetView();
        }

        private void CL_Palmari_BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DB2Riga();
        }
    }
}
