using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace SmartLineProduction
{
    public partial class UC_Quality_new_version : MetroFramework.Forms.MetroForm
    {
        private string displayform = "V"; // V-View/I-Insert/E-Edit/R-Revision
        private string sel_ProjProdArea = "";
        private string sel_Org = "";
        private string sel_Type = "";
        private string sel_Class = "";
        private string sel_User = "";

        //valori per Creazione Revisione
        string Qual_ProjProdArea = "";
        string Qual_Org = "";
        string Qual_Type = "";
        string Qual_Class = "";
        string Qual_Prog = "";
        string Qual_Ver = "";
        string Qual_Rev = "";
        string Qual_Ver_old = "";
        string Qual_Rev_old = "";
        DataRow sourceRow;
        bool VediObsolete = false;

        int Glob_RowId = 0;
        private int ultcodice = 0;

        public UC_Quality_new_version()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////
        /// Funzioni private
        ////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////
        /// Funzioni automatiche
        ////////////////////////////////////////////////////////////////////////////////////

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_Quality_new_version_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Quality_new.Quality'. È possibile spostarla o rimuoverla se necessario.
            this.qualityTableAdapter.Fill(this.ds_Quality_new.Quality);

        }
    }
}
