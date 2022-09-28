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
    public partial class UC_Prototipo_ID_Palmare : MetroFramework.Forms.MetroForm
    {
        public string CodiceDevice = "";
        public string CodFW = "";
        public bool IsRadius = false;

        public string CodiceID
        {
            get
            {
                return lab_ID.Text;
            }
        }

        public string CodiceFW
        {
            get
            {
                return CodFW;
            }
        }

        StringBuilder codice_bin = new StringBuilder("000000000000", 12);
        private char fam_hex;

        public UC_Prototipo_ID_Palmare(string PassedDevice)
        {
            InitializeComponent();
            this.CodiceDevice = PassedDevice;
        }

        private void UC_Prototipo_ID_Palmare_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Prototipi.Firmware_List'. È possibile spostarla o rimuoverla se necessario.
            this.firmware_ListTableAdapter.Fill(this.ds_Prototipi.Firmware_List);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Prototipi.Fam_Prod'. È possibile spostarla o rimuoverla se necessario.
            this.fam_ProdTableAdapter.Fill(this.ds_Prototipi.Fam_Prod);

            lab_Device.Text = CodiceDevice;
            FiltraFamProd();

            Calcola_ID();
        }

        private void Calcola_ID()
        {
            //Visualizzazione pannelli
            if (!IsRadius)
            {
                panel_SmartLine.Visible = true;
                panel_radius.Visible = false;
            }
            else
            {
                panel_SmartLine.Visible = false;
                panel_radius.Visible = true;
            }

            if (but_868.Checked) { codice_bin[0] = '1'; codice_bin[1] = '0'; codice_bin[2] = '0'; codice_bin[11] = '0'; };
            if (but_915.Checked) { codice_bin[0] = '0'; codice_bin[1] = '1'; codice_bin[2] = '0'; codice_bin[11] = '0'; };
            if (but_433.Checked) { codice_bin[0] = '0'; codice_bin[1] = '0'; codice_bin[2] = '1'; codice_bin[11] = '0'; };
            if (but_86824.Checked) { codice_bin[0] = '1'; codice_bin[1] = '0'; codice_bin[2] = '0'; codice_bin[11] = '1'; };
            if (but_24.Checked) { codice_bin[0] = '0'; codice_bin[1] = '0'; codice_bin[2] = '0'; codice_bin[11] = '1'; };

            if (tog_display.Checked) { codice_bin[3] = '1'; } else { codice_bin[3] = '0'; }

            if (tog_accel.Checked) { codice_bin[4] = '1'; } else { codice_bin[4] = '0'; }

            if (tog_sp.Checked) { codice_bin[5] = '1'; } else { codice_bin[5] = '0'; }

            if (tog_buzzer.Checked) { codice_bin[6] = '1'; } else { codice_bin[6] = '0'; }

            if (tog_vibra.Checked) { codice_bin[7] = '1'; } else { codice_bin[7] = '0'; }

            if (tog_torcia.Checked) { codice_bin[8] = '1'; } else { codice_bin[8] = '0'; }

            if (tog_fungo.Checked) { codice_bin[9] = '1'; } else { codice_bin[9] = '0'; }

            if (tog_PLD.Checked) { codice_bin[10] = '1'; } else { codice_bin[10] = '0'; }

            int dec_val = Convert.ToInt16(codice_bin.ToString(), 2);
            string hex_val = dec_val.ToString("X"); ;
            hex_val = hex_val.PadLeft(3, '0');

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

        private void but_close_UC_Prototipo_ID_Palmare_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FiltraFamProd()
        {
            string filtro = "";
            famProdBindingSource.MoveFirst();
            foreach (DataRowView famprodRow in famProdBindingSource)
            {
                // Verifica che ci sia un alias presente
                if (famprodRow["Fam_Alias_Progettazione"].ToString() == "")
                    continue;

                int len_alias = famprodRow["Fam_Alias_Progettazione"].ToString().Length;
                int len_dev = famprodRow["Fam_Prefix"].ToString().Length;
                if ((CodiceDevice.Substring(0, len_alias) == famprodRow["Fam_Alias_Progettazione"].ToString()) || (CodiceDevice.Substring(0, len_dev) == famprodRow["Fam_Prefix"].ToString()))
                {
                    filtro = "Id = " + famprodRow["Id"];
                    fam_hex = Convert.ToChar(famprodRow["Fam_ID_Identifier"].ToString());

                    //Definisci Radius
                    if (fam_hex == '8') { IsRadius = true; } else { IsRadius = false; }

                    lab_Famiglia.Text = famprodRow["Fam_Name"].ToString();

                    break;
                }
            }

            famProdBindingSource.Filter = filtro;
            Calcola_ID();
        }

        private void tog_PLD_CheckedChanged(object sender, EventArgs e)
        {
            Calcola_ID();
        }

        private void firmwareListBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView myRow = (DataRowView)firmwareListBindingSource.Current;

            string label_FW = "";

            CodFW = myRow["SW_Code"].ToString();
            label_FW = myRow["SW_Code"].ToString() + " - Rev. " + myRow["SW_Revisione"].ToString();
            lab_FW_versione.Text = label_FW;
        }

        private void but_433_CheckedChanged_1(object sender, EventArgs e)
        {
            Calcola_ID();
        }

        private void but_24_CheckedChanged(object sender, EventArgs e)
        {
            Calcola_ID();
        }
    }
}
