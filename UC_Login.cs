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
    public partial class UC_Login : MetroFramework.Forms.MetroForm
    {
        public UC_Login()
        {
            InitializeComponent();
        }

        private void but_close_UC_Login_Click(object sender, EventArgs e)
        {
            if (usersBindingSource.Current != null)
            {
                DataRowView current = (DataRowView)usersBindingSource.Current;
                string pwd = current["PWD"].ToString();

                if (tb_password.Text != pwd)
                {
                    lab_wrong_pwd.Visible = true;
                    tb_password.Text = "";
                    tb_password.Focus();
                }
                else
                {
                    UC_Ncr.NCR_Id = (int)current["Id"];
                    this.Close();
                }
            }
        }

        private void UC_Login_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Ncr.Users'. È possibile spostarla o rimuoverla se necessario.
            this.usersTableAdapter.Fill(this.ds_Ncr.Users);

            SettaForm();
        }

        private void SettaForm()
        {
            lab_wrong_pwd.Visible = false;
        }

        private void tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            lab_wrong_pwd.Visible = false;
        }

        private void but_abort_UC_Login_Click(object sender, EventArgs e)
        {
            UC_Ncr.NCR_Id = 0;
            this.Close();
        }
    }
}
