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
    public partial class UC_NCR_Search_Articoli : MetroFramework.Forms.MetroForm
    {
        public string PassCodiceArticolo = string.Empty;

        public UC_NCR_Search_Articoli()
        {
            InitializeComponent();
        }

        private void UC_NCR_Search_Articoli_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Ncr.SF_Ncr_Articoli'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Ncr_ArticoliTableAdapter.Fill(this.ds_Ncr.SF_Ncr_Articoli);
            
            sFNcrArticoliBindingSource.Sort = "Articolo asc";

            search_txtbox.Text = "";
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
            DataRowView DBRow = (DataRowView)sFNcrArticoliBindingSource.Current;
            PassCodiceArticolo = Convert.ToString(DBRow["Articolo"]);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void search_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(search_txtbox.Text))
            {
                sFNcrArticoliBindingSource.Filter = string.Empty;
            }
            else
            {
                sFNcrArticoliBindingSource.Filter = string.Format("Articolo LIKE '%{0}%'", search_txtbox.Text);
            }
        }
    }
}
