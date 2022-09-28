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
    public partial class UC_Password : MetroFramework.Forms.MetroForm
    {
        public string password = "";
        public UC_Password()
        {
            InitializeComponent();
        }

        private void btn_Invia_Click(object sender, EventArgs e)
        {
            password = tb_password.Text;

            this.DialogResult = DialogResult.OK;
        }

        private void tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                password = tb_password.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
