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
    public partial class UC_ConfirmTAG : MetroFramework.Forms.MetroForm
    {
        public string tag_1 = "";
        public string tag_2 = "";
        public UC_ConfirmTAG()
        {
            InitializeComponent();
        }

        private void btn_Invia_Click(object sender, EventArgs e)
        {
            tag_1 = tb_Tag1.Text;
            tag_2 = tb_Tag2.Text;
            if (tb_Tag1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Impossibile proseguire, inserire valore TAG # 1!");
                tb_Tag1.Focus();
                return;
            }
            if (tb_Tag2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Impossibile proseguire, inserire valore TAG # 2!");
                tb_Tag2.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void UC_ConfirmTAG_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione.SafetyPointRFID'. È possibile spostarla o rimuoverla se necessario.
            this.safetyPointRFIDTableAdapter.Fill(this.ds_Programmazione.SafetyPointRFID);

            tb_Tag1.Text = string.Empty;
            tb_Tag2.Text = string.Empty;
            tb_Tag1.Focus();
        }

        private void tb_Tag1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                tag_1 = tb_Tag1.Text;
                tb_Tag2.Focus();
            }
        }

        private void tb_Tag1_Leave(object sender, EventArgs e)
        {
            string newTag1 = string.Empty;

            if (tb_Tag1.TextLength == 16)
            {
                string tempstr = tb_Tag1.Text;
                for (int i = 0; i < 16; i++)
                {
                    if (i == 2 || i == 4 || i == 6 || i == 8 || i == 10 || i == 12 || i == 14) { newTag1 = newTag1 + ":"; }
                    newTag1 = newTag1 + tempstr[i];
                }
                string to_up = newTag1.ToUpper();
                tb_Tag1.Text = to_up;
            }

            if (!VerificaTag(tb_Tag1.Text))
            {
                tb_Tag1.Text = string.Empty;
                tb_Tag1.Focus();
            }
            else
            {
                tb_Tag2.Focus();
            }
        }

        private void tb_Tag2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                tag_2 = tb_Tag2.Text;
                btn_Invia.Focus();
            }
        }

        private void tb_Tag2_Leave(object sender, EventArgs e)
        {
            string newTag2 = string.Empty;

            if (tb_Tag2.TextLength == 16)
            {
                string tempstr = tb_Tag2.Text;
                for (int i = 0; i < 16; i++)
                {
                    if (i == 2 || i == 4 || i == 6 || i == 8 || i == 10 || i == 12 || i == 14) { newTag2 = newTag2 + ":"; }
                    newTag2 = newTag2 + tempstr[i];
                }
                string to_up = newTag2.ToUpper();
                tb_Tag2.Text = to_up;
            }

            if (tb_Tag2.Text == tb_Tag1.Text)
            {
                MessageBox.Show("Cerchi di fregarmi?? Hai messo due volte lo stesso tag!");
                tb_Tag2.Text = string.Empty;
                tb_Tag2.Focus();
            }

            if (!VerificaTag(tb_Tag2.Text))
            {
                tb_Tag2.Text = string.Empty;
                tb_Tag2.Focus();
            }
            else
            {
                //Modifica del 28.02.2023 - Anzichè attendere su btn_Invia, conferma direttamente
                //btn_Invia.Focus();

                //il codice successivo è l'evento btn_Invia_Click
                tag_1 = tb_Tag1.Text;
                tag_2 = tb_Tag2.Text;
                if (tb_Tag1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Impossibile proseguire, inserire valore TAG # 1!");
                    tb_Tag1.Focus();
                    return;
                }
                if (tb_Tag2.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Impossibile proseguire, inserire valore TAG # 2!");
                    tb_Tag2.Focus();
                    return;
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private bool VerificaTag(string Tag)
        {
            int foundindex = this.safetyPointRFIDBindingSource.Find("Rfid_UUID", Tag);
            if (foundindex > -1) 
            {
                this.safetyPointRFIDBindingSource.Position = foundindex;
                DataRowView current = (DataRowView)safetyPointRFIDBindingSource.Current;
                if (Convert.ToBoolean(current["Rfid_Obsolete"])) 
                {
                    MessageBox.Show("Impossibile proseguire, il TAG è obsoleto!");
                    return false;
                }

                if (!Convert.ToBoolean(current["Rfid_Verified"]))
                {
                    MessageBox.Show("Impossibile proseguire, il TAG non è stato verificato!");
                    return false;
                }

                if (current["Rfid_Ser_SN_Prod"].ToString().Trim() != string.Empty)
                {
                    MessageBox.Show("Impossibile proseguire, il TAG è già stato associato al Serial Number n.: "+ current["Rfid_Ser_SN_Prod"].ToString().Trim());
                    return false;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        private void UC_ConfirmTAG_Validating(object sender, CancelEventArgs e)
        {
            if (tb_Tag1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Valore mancante - TAG #1");
                tb_Tag1.Focus();
            }
            if (tb_Tag2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Valore mancante - TAG #2");
                tb_Tag2.Focus();
            }
        }
    }
}
