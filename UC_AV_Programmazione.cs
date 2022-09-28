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
    public partial class UC_AV_Programmazione : MetroFramework.Forms.MetroForm
    {
        public UC_AV_Programmazione()
        {
            InitializeComponent();
        }

        private void UC_Programmazione_Load(object sender, EventArgs e)
        {
            lab_ragsoc.Text = GVar.gl_ragsoc;
            lab_commessa.Text = GVar.gl_commessa;
            lab_articolo.Text = GVar.gl_articolo;
            txt_note.Text = GVar.gl_note;
            int qtadaev = GVar.gl_qtaevadere;
            for (int i = qtadaev; i >= 1; i--)
            {
                combo_qta.Items.Add(i);
            }
            combo_qta.SelectedIndex = 0;
        }

        private void pic_passaggio_Click(object sender, EventArgs e)
        {
            GVar.btn_clicked = "passaggio";
            this.Close();
        }

        private void pic_abort_Click(object sender, EventArgs e)
        {
            GVar.btn_clicked = "abort";
            this.Close();
        }
    }
}
