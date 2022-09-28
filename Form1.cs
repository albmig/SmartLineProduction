using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLineProduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_SN_CicloAttivo_Kit'. È possibile spostarla o rimuoverla se necessario.
            this.sF_SN_CicloAttivo_KitTableAdapter.Fill(this.ds_QuerySN.SF_SN_CicloAttivo_Kit);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_SN_Query'. È possibile spostarla o rimuoverla se necessario.
            this.sF_SN_QueryTableAdapter.Fill(this.ds_QuerySN.SF_SN_Query);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_SN_arsn'. È possibile spostarla o rimuoverla se necessario.
            this.sF_SN_arsnTableAdapter.Fill(this.ds_QuerySN.SF_SN_arsn);

        }
    }
}
