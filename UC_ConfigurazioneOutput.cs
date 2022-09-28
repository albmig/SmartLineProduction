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


namespace SmartLineProduction
{
    public partial class UC_ConfigurazioneOutput : MetroFramework.Forms.MetroForm
    {
        private int valore_max_out = 0;
        private int valore_max_dig_in = 0;
        private int valore_max_an_in_010 = 0;
        private int valore_max_an_in_420 = 0;
        private int valore_max_can = 0;
        private int valore_max_prop = 0;
        private int prog_sol = 0;
        private int prog_conf = 0;

        private int ini_out = 19;
        private int ini_dig_in = 1;
        private int ini_in_010 = 0;
        private bool ini_in_420 = false;
        private bool ini_can = false;
        private bool ini_prop = false;
        private bool ini_motrim = false;

        private int used_out = 14;
        private int used_dig_in = 0;
        private int used_in_010 = 0;
        private int used_in_420 = 0;
        private int used_can = 0;
        private int used_prop = 0;
        private int used_totale_in_out = 0;

        public UC_ConfigurazioneOutput()
        {
            InitializeComponent();
        }

        //Control functions
        private void UC_ConfigurazioneOutput_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_Schede_WDesc'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Schede_WDescTableAdapter.Fill(this.ds_SL.SF_Schede_WDesc);
            ResetDati();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tog_420mA_CheckedChanged(object sender, EventArgs e)
        {
            panel_view.Visible = false;

            if (tog_420mA.Checked) { valore_max_an_in_420 = 2; } else { valore_max_an_in_420 = 0; }
        }

        private void tb_max_output_Validating(object sender, CancelEventArgs e)
        {
            panel_view.Visible = false;
            if ((tb_max_output.Text != "") && (tb_max_output.Text != null))
            {
                int maxout = Convert.ToInt32(tb_max_output.Text);
                int outxctrl = maxout / 4; // 4 è il numero max di controller x installazione
                if (maxout > 56)
                {
                    MessageBox.Show("Il massimo numero di output è 32!");
                    tb_max_output.Text = "";
                    tb_max_output.Focus();
                }
                if (outxctrl > 20)
                {
                    MessageBox.Show("Numero di output non congruente con il numero di controller!");
                    tb_max_output.Text = "";
                    tb_max_output.Focus();
                }
            }
        }

        private void tog_Can_CheckedChanged(object sender, EventArgs e)
        {
            panel_view.Visible = false;

            FiltraCombinazioni();
        }

        private void tog_Prop_CheckedChanged(object sender, EventArgs e)
        {
            panel_view.Visible = false;

            FiltraCombinazioni();
        }

        private void question_MotRim_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.question_MotRim, "Se attivata la funzione Motrice/Rimorchio, questa impegnerà un'ingresso di tipo digitale");
        }

        private void UC_ConfigurazioneOutput_Activated(object sender, EventArgs e)
        {
            panel_input.Focus();
            tb_max_output.Focus();
        }

        // Private functions
        private void ResetDati()
        {
            tb_max_output.MaxLength = 2;
            tb_max_input_dig.MaxLength = 2;
            tb_max_input_010.MaxLength = 2;

            tb_max_output.Text = ini_out.ToString();
            tb_max_input_dig.Text = ini_dig_in.ToString();
            tb_max_input_010.Text = ini_in_010.ToString();
            tog_420mA.Checked = ini_in_420;
            tog_Can.Checked = ini_can;
            tog_Prop.Checked = ini_prop;
            tog_MotRim.Checked = ini_motrim;
            panel_view.Visible = false;

            FiltraCombinazioni();
        }

        private void FiltraCombinazioni()
        {
            string filtro = "";
            filtro = filtro + "Sch_Out >= " + Convert.ToInt32(tb_max_output.Text);
            filtro = filtro + " AND ";
            filtro = filtro + "Sch_Ind_Dig >= " + Convert.ToInt32(tb_max_input_dig.Text);
            filtro = filtro + " AND ";
            filtro = filtro + "Sch_In_010V >= " + Convert.ToInt32(tb_max_input_010 .Text);
            filtro = filtro + " AND ";
            if (tog_Can.Checked) { filtro = filtro + "Sch_Can <> 0"; } else { filtro = filtro + "Sch_Can = 0"; }
            filtro = filtro + " AND ";
            if (tog_Prop.Checked) { filtro = filtro + "Sch_Prop <> 0"; } else { filtro = filtro + "Sch_Prop = 0"; }

            sFSchedeWDescBindingSource.Filter = filtro;
        }

        private void btn_ricerca_soluzioni_Click(object sender, EventArgs e)
        {
            FiltraCombinazioni();

            panel_view.Visible = true;
        }

        private void tb_max_input_dig_Validating(object sender, CancelEventArgs e)
        {
            panel_view.Visible = false;
        }

        private void tb_max_input_010_Validating(object sender, CancelEventArgs e)
        {
            panel_view.Visible = false;
        }

        private void tog_MotRim_Validating(object sender, CancelEventArgs e)
        {
            panel_view.Visible = false;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Old functions
        ////////////////////////////////////////////////////////////////////////////////////////////////////////


        //private void UC_ConfigurazioneOutput_Load(object sender, EventArgs e)
        //{
        //    ResetDati();
        //}




        //private void btn_ricerca_soluzioni_Click(object sender, EventArgs e)
        //{
        //    prog_sol = 0;
        //    prog_conf = 0;

        //    ds_SL.dt_Configuratore_Soluzioni.Clear();
        //    this.dtConfiguratoreSoluzioniBindingSource.Sort = "Conf_Combinazione asc, Conf_Codice_Board asc, Conf_Codice_Plug asc";

        //    valore_max_out = Convert.ToInt16(tb_max_output.Text);
        //    valore_max_dig_in = Convert.ToInt16(tb_max_input_dig.Text);
        //    valore_max_an_in_010 = Convert.ToInt16(tb_max_input_010.Text);
        //    if (tog_420mA.Checked) { valore_max_an_in_420 = 2; } else { valore_max_an_in_420 = 0; }

        //    for (int cicloctrl = 1; cicloctrl < 5; cicloctrl++) //ciclo per trovare al massimo 4 ctrl per soluzione
        //    {
        //        //Primo ciclo su configurazioni
        //        if (cicloctrl == 1)
        //        {
        //            LeggiConfigurazioni();
        //        }
        //        else
        //        {
        //            //LeggiSoluzioni();
        //            //LeggiConfigurazioni();
        //        }
        //    }
        //}




        //private void LeggiSoluzioni()
        //{

        //}

        //private void LeggiConfigurazioni()
        //{
        //    foreach (DataRowView ConfRow in sFSchedeCombineFullwithdesBindingSource)
        //    {
        //        bool rec_ok = false;

        //        string Sch_Codice_Board = ConfRow["Sch_Codice_Board"].ToString();
        //        string Sch_Codice_Plug = ConfRow["Sch_Codice_Plug"].ToString();
        //        int Sch_Max_Out = Convert.ToInt16(ConfRow["Sch_Max_Out"]);
        //        string Des_Art_Board = ConfRow["Des_Art_Board"].ToString();
        //        string Des_Art_Plug = ConfRow["Des_Art_Plug"].ToString();
        //        int Out = Convert.ToInt16(ConfRow["Sch_Max_Out"]);
        //        int Dig_In = Convert.ToInt16(ConfRow["Sch_Max_Dig_In"]);
        //        int An_In_010V = Convert.ToInt16(ConfRow["Sch_Max_An_In_010V"]);
        //        int An_In_420mA = Convert.ToInt16(ConfRow["Sch_Max_An_In_420mA"]); //Presente - 2 / Assente - 0
        //        int Can = Convert.ToInt16(ConfRow["Sch_Output_Can"]);
        //        int Prop = Convert.ToInt16(ConfRow["Sch_Output_Prop"]);


        //        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        //        // Calcolo input/output
        //        //
        //        // valori di partenza:
        //        // valore_max_out
        //        // valore_max_dig_in
        //        // valore_max_an_in_010
        //        // valore_max_an_in_420
        //        //
        //        // proveniente dall'input utente

        //        used_out = 0;
        //        used_dig_in = 0;
        //        used_in_010 = 0;
        //        used_in_420 = An_In_420mA;
        //        used_can = Can; //assegno le uscite definite già su scheda
        //        used_prop = Prop; //assegno le uscite definite già su scheda

        //        used_totale_in_out = 0;

        //        if (valore_max_dig_in > Dig_In) { used_dig_in = Dig_In; } else { used_dig_in = valore_max_dig_in; }
        //        if (valore_max_an_in_010 > An_In_010V) { used_in_010 = An_In_010V; } else { used_in_010 = valore_max_an_in_010; }
        //        if (An_In_420mA != 0) { used_in_420 = An_In_420mA; }

        //        if (tog_MotRim.Checked) { used_dig_in++; }
        //        used_out = Out - used_can - used_prop - used_dig_in - used_in_010 - used_in_420;
        //        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        //        //Verifico i valori
        //        bool test_out = false;
        //        //bool test_010 = false;
        //        bool test_420 = false;
        //        bool test_dig = false;
        //        bool test_can = false;
        //        bool test_prop = false;
        //        bool test_other = false;

        //        //Verifico - out
        //        if ((Sch_Max_Out >= valore_max_out) && (valore_max_out <= used_out)) { test_out = true; } else { test_out = false; }

        //        //Verifico presenza IN 4-20mA
        //        if (valore_max_an_in_420 <= An_In_420mA) { test_420 = true; } else { test_420 = false; }

        //        //Verifico - in
        //        if (Dig_In >= valore_max_dig_in) { test_dig = true; } else { test_dig = false; }

        //        //verifico CAN
        //        if ((used_can == 0) || ((used_can != 0) & (Can >= valore_max_can))) { test_can = true; } else { test_can = false; }

        //        // Verifico Proporzionale
        //        if ((used_prop == 0) || ((used_prop != 0) & (Prop >= valore_max_prop))) { test_prop = true; } else { test_prop = false; }

        //        if (used_out < 0) { test_out = false; }

        //        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        //        //Imposta esclusioni  - IMPORTANTE!!
        //        if ((Sch_Codice_Board == "XSCHSE391RBX_L") && (Sch_Codice_Plug == "XSCHSE411RAX_L")) { test_other = false; } else { test_other = true; }
        //        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        //        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        //        // verifico se tutte le condizioni ok
        //        if ((test_out) && (test_420) && (test_dig) && (test_can) && (test_prop) && (test_other)) { rec_ok = true; } else { rec_ok = false; }
        //        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        //        if (rec_ok)
        //        {
        //            DataRow newrow = ds_SL.dt_Configuratore_Soluzioni.NewRow();
        //            prog_sol++;
        //            prog_conf++;
        //            newrow["Conf_Soluzione"] = prog_sol;
        //            newrow["Conf_Soluzione_Prog"] = prog_conf;
        //            newrow["Conf_Codice_Board"] = Sch_Codice_Board;
        //            newrow["Conf_Qta_Board"] = 1;
        //            newrow["Conf_Codice_Plug"] = Sch_Codice_Plug;
        //            newrow["Conf_Qta_Plug"] = prog_sol;
        //            newrow["Conf_Des_Art_Board"] = Des_Art_Board;
        //            newrow["Conf_Des_Art_Plug"] = Des_Art_Plug;
        //            //newrow["Conf_Out"] = Out;
        //            //newrow["Conf_Dig_In"] = Dig_In;
        //            //newrow["Conf_An_In_010V"] = An_In_010V;
        //            //newrow["Conf_An_In_420mA"] = An_In_420mA;
        //            //newrow["Conf_Can"] = Can;
        //            //newrow["Conf_Prop"] = Prop;
        //            newrow["Conf_Out"] = used_out;
        //            newrow["Conf_Dig_In"] = used_dig_in;
        //            newrow["Conf_An_In_010V"] = used_in_010;
        //            newrow["Conf_An_In_420mA"] = used_in_420;
        //            newrow["Conf_Can"] = used_can;
        //            newrow["Conf_Prop"] = used_prop;
        //            if ((Sch_Codice_Plug != "") && (Sch_Codice_Plug != null)) { newrow["Conf_Combinazione"] = 2; } else { newrow["Conf_Combinazione"] = 1; }


        //            ds_SL.dt_Configuratore_Soluzioni.Rows.Add(newrow);
        //        }
        //    }
        //}

        //private void FiltraCombinazioni()
        //{
        //    string filtro = "";
        //    if (tog_Can.Checked) { filtro = "Sch_Output_Can <> 0"; } else { filtro = "Sch_Output_Can = 0"; }
        //    filtro = filtro + " AND ";
        //    if (tog_Prop.Checked) { filtro = filtro + "Sch_Output_Prop <> 0"; } else { filtro = filtro + "Sch_Output_Prop = 0"; }

        //    sFSchedeCombineFullwithdesBindingSource.Filter = filtro;
        //}

    }
}