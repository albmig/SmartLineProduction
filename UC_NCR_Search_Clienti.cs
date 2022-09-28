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
    public partial class UC_NCR_Search_Clienti : MetroFramework.Forms.MetroForm
    {
        public string CodNomCliente = "";
        public int PassMastro = 0;
        public int PassConto = 0;
        public int PassSottoconto = 0;
        public string PassCF = string.Empty;

        public UC_NCR_Search_Clienti()
        {
            InitializeComponent();
        }

        private void UC_NCR_Search_Clienti_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Ncr.SF_Ncr_CliFor'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Ncr_CliForTableAdapter.Fill(this.ds_Ncr.SF_Ncr_CliFor);
            
            sFNcrCliForBindingSource.Sort = "RAGIONESOCIALE asc";

            search_txtbox.Text = "";
            group_CF.SelectedIndex = 0;
            search_txtbox.Focus();
        }

        private void but_Confirm_Click(object sender, EventArgs e)
        {
            Uscita();
        }

        private void gv_result_DoubleClick(object sender, EventArgs e)
        {
            Uscita();
        }

        private void Uscita()
        {
            DataRowView DBRow = (DataRowView)sFNcrCliForBindingSource.Current;
            PassMastro = Convert.ToInt32(DBRow["Mastro"]);
            PassConto = Convert.ToInt32(DBRow["Conto"]);
            PassSottoconto = Convert.ToInt32(DBRow["SOTTOCONTO"]);
            PassCF = Convert.ToString(DBRow["Clifor"]);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void search_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(search_txtbox.Text))
            {
                sFNcrCliForBindingSource.Filter = string.Empty;
            }
            else
            {
                sFNcrCliForBindingSource.Filter = string.Format("RAGIONESOCIALE LIKE '%{0}%'", search_txtbox.Text);
            }
        }

        private void group_CF_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = "CliFor = " + "'" + group_CF.EditValue +"'";
            sFNcrCliForBindingSource.Filter = filtro;
        }
    }
}
