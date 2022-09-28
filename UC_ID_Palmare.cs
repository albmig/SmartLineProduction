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

namespace SmartLineProduction
{
    public partial class UC_ID_Palmare : MetroFramework.Forms.MetroForm
    {
        public string CodiceID
        {
            get
            {
                return lab_ID.Text;
            }
        }

        StringBuilder codice_bin = new StringBuilder("000000000000", 12);
        private char fam_hex;

        public UC_ID_Palmare()
        {
            InitializeComponent();
        }

        private void UC_ID_Palmare_Load(object sender, EventArgs e)
        {
            cb_famiglia.Text = "Easy SL";
            Calcola_ID();
        }

        private void Calcola_ID()
        {

            if (but_868.Checked) { codice_bin[0] = '1'; codice_bin[1] = '0'; codice_bin[2] = '0'; };
            if (but_915.Checked) { codice_bin[0] = '0'; codice_bin[1] = '1'; codice_bin[2] = '0'; };
            if (but_433.Checked) { codice_bin[0] = '0'; codice_bin[1] = '0'; codice_bin[2] = '1'; };

            if (tog_display.Checked) { codice_bin[3] = '1'; } else { codice_bin[3] = '0'; }

            if (tog_accel.Checked) { codice_bin[4] = '1'; } else { codice_bin[4] = '0'; }

            if (tog_sp.Checked) { codice_bin[5] = '1'; } else { codice_bin[5] = '0'; }

            if (tog_buzzer.Checked) { codice_bin[6] = '1'; } else { codice_bin[6] = '0'; }

            if (tog_vibra.Checked) { codice_bin[7] = '1'; } else { codice_bin[7] = '0'; }

            if (tog_torcia.Checked) { codice_bin[8] = '1'; } else { codice_bin[8] = '0'; }

            if (tog_fungo.Checked) { codice_bin[9] = '1'; } else { codice_bin[9] = '0'; }

            codice_bin[10] = '0';
            codice_bin[11] = '0';

            int dec_val = Convert.ToInt16(codice_bin.ToString(), 2);
            string hex_val = dec_val.ToString("X"); ;

            // Aggiungo Famiglia
            if (cb_famiglia.SelectedIndex == 0) { fam_hex = '1'; } //Easy SL
            if (cb_famiglia.SelectedIndex == 1) { fam_hex = '2'; } //Trend SL
            if (cb_famiglia.SelectedIndex == 4) { fam_hex = '5'; } //Easy Lift SL
            string def_hex = fam_hex + hex_val;

            lab_ID.Text = def_hex;
        }

        private void but_868_CheckedChanged(object sender, EventArgs e)
        {
            Calcola_ID();
        }

        private void but_915_CheckedChanged(object sender, EventArgs e)
        {
            Calcola_ID();
        }

        private void but_433_CheckedChanged(object sender, EventArgs e)
        {
            Calcola_ID();
        }

        private void tog_display_CheckedChanged(object sender, EventArgs e)
        {
            Calcola_ID();
        }

        private void tog_accel_CheckedChanged(object sender, EventArgs e)
        {
            Calcola_ID();
        }

        private void tog_sp_CheckedChanged(object sender, EventArgs e)
        {
            Calcola_ID();
        }

        private void tog_buzzer_CheckedChanged(object sender, EventArgs e)
        {
            Calcola_ID();
        }

        private void tog_vibra_CheckedChanged(object sender, EventArgs e)
        {
            Calcola_ID();
        }

        private void tog_torcia_CheckedChanged(object sender, EventArgs e)
        {
            Calcola_ID();
        }

        private void tog_fungo_CheckedChanged(object sender, EventArgs e)
        {
            Calcola_ID();
        }

        private void but_close_UC_ID_Palmare_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
