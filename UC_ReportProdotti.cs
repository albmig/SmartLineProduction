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
    public partial class UC_ReportProdotti : MetroFramework.Forms.MetroForm
    {
        public UC_ReportProdotti()
        {
            InitializeComponent();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_ReportProdotti_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_Parco'. È possibile spostarla o rimuoverla se necessario.
            this.sF_ParcoTableAdapter.Fill(this.ds_SL.SF_Parco);

            this.group_Parco.AllowProportionalColumnSizing = true;
            this.group_Parco.TableDescriptor.Appearance.AnyRecordFieldCell.AutoSize = true;
            this.group_Parco.TableDescriptor.Appearance.AnyRecordFieldCell.WrapText = false;
        }
    }
}
