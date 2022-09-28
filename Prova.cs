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
    public partial class Prova : Form
    {
        public Prova()
        {
            InitializeComponent();
        }

        private void Prova_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL_History.BS_SN_History'. È possibile spostarla o rimuoverla se necessario.
            this.bS_SN_HistoryTableAdapter.Fill(this.ds_SL_History.BS_SN_History);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL_History.Firmware'. È possibile spostarla o rimuoverla se necessario.
            this.firmwareTableAdapter.Fill(this.ds_SL_History.Firmware);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL_History.SerialNumbers'. È possibile spostarla o rimuoverla se necessario.
            this.serialNumbersTableAdapter.Fill(this.ds_SL_History.SerialNumbers);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL_History.SF_Clienti_SerialNumbers'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Clienti_SerialNumbersTableAdapter.Fill(this.ds_SL_History.SF_Clienti_SerialNumbers);
        }
    }
}
