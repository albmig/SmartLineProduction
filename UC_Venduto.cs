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
    public partial class UC_Venduto : MetroFramework.Forms.MetroForm
    {
        private string articolo;

        public UC_Venduto(string passarticolo)
        {
            InitializeComponent();
            articolo = passarticolo;
        }

        private void UC_Venduto_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.Analisi_Costi_Articolo'. È possibile spostarla o rimuoverla se necessario.
            this.analisi_Costi_ArticoloTableAdapter.Fill(this.ds_SL.Analisi_Costi_Articolo);

            this.Text = "Venduto per articolo: " + articolo;
            string filtro = "Articolo = " + "'" + articolo + "'";
            analisiCostiArticoloBindingSource.Filter = filtro;
            analisiCostiArticoloBindingSource.Sort = "Cliente asc";
        }

        private void UC_Venduto_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
