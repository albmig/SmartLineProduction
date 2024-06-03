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

        private void FiltraQuality()
        {
            if (displayform == "I")
            {
                string filtro = "";
                bool firstfilter = false;

                if (sel_ProjProdArea != "___")
                {
                    filtro = filtro + "(Qual_ProjProdArea like " + "'" + sel_ProjProdArea + "')";
                    firstfilter = true;
                }
                if (sel_Org != "___")
                {
                    if (firstfilter) { filtro = filtro + " AND "; }
                    filtro = filtro + "(Qual_Org like " + "'" + sel_Org + "')";
                    firstfilter = true;
                }
                if (sel_Type != "___")
                {
                    if (firstfilter) { filtro = filtro + " AND "; }
                    filtro = filtro + "(Qual_Type like " + "'" + sel_Type + "')";
                    firstfilter = true;
                }

                qualityBindingSource.Filter = filtro;

                CreaCodice();
            }
        }

        private void CreaCodice()
        {
            //Trova ultimo codice
            ultcodice = 0;

            DataView view = new DataView(ds_Quality_new.Quality);
            view.RowFilter = qualityBindingSource.Filter;
            int contarec = view.Count;
            if (contarec > 0)
            {
                DataTable result = view.ToTable();
                ultcodice = Convert.ToInt32(result.Compute("max(Qual_Prog)", ""));
            }

            ultcodice++;

            string codvers = "";
            string codrev = "";
            if (tb_vers.Text != "") { codvers = tb_vers.Text; } else { codvers = "__"; }
            if (tb_rev.Text != "") { codrev = tb_rev.Text; } else { codrev = "__"; }

            //,CONCAT(Quality.Qual_ProjProdArea, '-', Quality.Qual_Org, '-', Quality.Qual_Type, '-', Quality.Qual_Class, '-', FORMAT(Quality.Qual_Prog, '0000'), '-', Quality.Qual_Ver, '.', Quality.Qual_Rev) AS Codice_Quality
            string codice = sel_ProjProdArea + "-" + sel_Org + "-" + sel_Type + "-" + sel_Class + "-" + ultcodice.ToString("0000") + "-" + codvers + "." + codrev;
            lab_Codice_Edit.Text = codice;
        }

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
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Quality_new.Quality'. È possibile spostarla o rimuoverla se necessario.
            this.qualityTableAdapter.Fill(this.ds_Quality_new.Quality);
            //qualityBindingSource.MoveFirst();
        }
    }
}
