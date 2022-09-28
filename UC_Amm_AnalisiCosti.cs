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
    public partial class UC_Amm_AnalisiCosti : MetroFramework.Forms.MetroForm
    {
        string filtroclienti = "";
        string filtroarticoli = "";
        string filtrocosti = "";
        decimal tot_costi = 0;
        decimal tot_ricavi = 0;
        decimal tot_diff = 0;
        decimal tot_mp = 0;
        decimal tot_uomo = 0;
        decimal tot_lav = 0;
        string selectednodearticolo="";

        public UC_Amm_AnalisiCosti()
        {
            InitializeComponent();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_Amm_AnalisiCosti_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_Expl_Distinta_Sale'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Expl_Distinta_SaleTableAdapter.Fill(this.ds_SL.SF_Expl_Distinta_Sale);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_Expl_Distinta_Sale'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Expl_Distinta_SaleTableAdapter.Fill(this.ds_SL.SF_Expl_Distinta_Sale);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.ACV_ClienteArticolo'. È possibile spostarla o rimuoverla se necessario.
            this.aCV_ClienteArticolo.FillBy_ClienteArticolo(this.ds_SL.ACV_ClienteArticolo);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.ACV_Cliente'. È possibile spostarla o rimuoverla se necessario.
            this.aCV_Cliente.FillBy_Cliente(this.ds_SL.ACV_Cliente);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.Analisi_Costi_Venduto'. È possibile spostarla o rimuoverla se necessario.
            this.analisi_Costi_VendutoTableAdapter.Fill(this.ds_SL.Analisi_Costi_Venduto);

            SettingForm();

            gv_Venduto.Focus();

        }

        private void btn_AzzeraFiltroClienti_Click(object sender, EventArgs e)
        {
            cb_elencoClienti.SelectedIndex = -1;
            cb_elencoarticoli.SelectedIndex = -1;
            filtroclienti = "";
            filtroarticoli = "";
            FiltraCommesse();
        }

        private void btn_AzzeraFiltroArticoli_Click(object sender, EventArgs e)
        {
            cb_elencoarticoli.SelectedIndex = -1;
            filtroarticoli = "";
            FiltraCommesse();
        }

        private void cb_elencoClienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_elencoClienti.SelectedIndex >= 0)
            {
                filtroclienti = "Cliente = " + "'" + cb_elencoClienti.Text.ToString() + "'";
                FiltraCommesse();
                cb_elencoarticoli.SelectedIndex = -1;
            }
        }

        private void cb_elencoarticoli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_elencoarticoli.SelectedIndex >= 0)
            {
                filtroarticoli = "ARTICOLO = " + "'" + cb_elencoarticoli.Text.ToString() + "'";
                FiltraCommesse();
            }
        }

        private void gv_Venduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) { return; }
            if ((gv_Venduto.Columns[e.ColumnIndex].Name == "gv_Venduto_Margine") && (e.Value != null))
            {
                DataGridViewCell cell = this.gv_Venduto.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DataGridViewRow gridRow = gv_Venduto.Rows[e.RowIndex];
                decimal margin = Convert.ToDecimal(gridRow.Cells["gv_Venduto_Margine"].Value);
                if (margin > 0)
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                }
                if (margin < 0)
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void analisiCostiVendutoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            tree_Distinta.ExpandAll();
        }

        private void gv_Venduto_SelectionChanged(object sender, EventArgs e)
        {
            tree_Distinta.ExpandAll();
        }

        // Funzioni
        private void FiltraCommesse()
        {
            Cursor.Current = Cursors.WaitCursor;

            string filtrocosti = "";
            if (filtroclienti != "")
            {
                filtrocosti = filtroclienti;
            }
            if (filtroarticoli != "")
            {
                if (filtroclienti != "") { filtrocosti = filtrocosti + " AND " + filtroarticoli; } else { filtrocosti = filtroarticoli; }
            }

            if ((filtroclienti == "") && (filtroarticoli == "")) { filtrocosti = ""; }

            analisiCostiVendutoBindingSource.Filter = filtrocosti;
            if (filtroclienti != "")
            {
                aCVClienteArticoloBindingSource.Filter = filtroclienti;
            }

            //Eseguo le somme
            tot_ricavi = Convert.ToDecimal(ds_SL.Analisi_Costi_Venduto.Compute("SUM(Tot_Ricavi)", filtrocosti));
            tot_costi = Convert.ToDecimal(ds_SL.Analisi_Costi_Venduto.Compute("SUM(Tot_Costi)", filtrocosti));
            tot_mp = Convert.ToDecimal(ds_SL.Analisi_Costi_Venduto.Compute("SUM(Tot_Costo_Mat)", filtrocosti));
            tot_uomo = Convert.ToDecimal(ds_SL.Analisi_Costi_Venduto.Compute("SUM(Tot_Costo_Manodopera)", filtrocosti));
            tot_lav = Convert.ToDecimal(ds_SL.Analisi_Costi_Venduto.Compute("SUM(Tot_Costo_LavEst)", filtrocosti));
            tot_diff = tot_ricavi - tot_costi;
            lab_tot_costi.Text = tot_costi.ToString("C2");
            lab_tot_ricavi.Text = tot_ricavi.ToString("C2");
            lab_tot_diff.Text = tot_diff.ToString("C2");
            lab_tot_mp.Text = tot_mp.ToString("C2");
            lab_tot_uomo.Text = tot_uomo.ToString("C2");
            lab_tot_lav.Text = tot_lav.ToString("C2");

            if (tot_diff >= 0)
            {
                lab_tot_diff.Style = MetroFramework.MetroColorStyle.Green;
            }
            else
            {
                lab_tot_diff.Style = MetroFramework.MetroColorStyle.Red;
            }
            Cursor.Current = Cursors.Default;
        }

        private void SettingForm()
        {
            cb_elencoClienti.SelectedIndex = -1;
            cb_elencoarticoli.SelectedIndex = -1;
            FiltraCommesse();

            gv_Venduto.Columns["gv_Venduto_QtaTot"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Venduto.Columns["gv_Venduto_Prezzo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Venduto.Columns["gv_Venduto_TotRicavi"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Venduto.Columns["gv_Venduto_TotCosti"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Venduto.Columns["gv_Venduto_CostoMat"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Venduto.Columns["gv_Venduto_CostoProd"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Venduto.Columns["gv_Venduto_CostoMan"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Venduto.Columns["gv_Venduto_CostoLav"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Venduto.Columns["gv_Venduto_Margine"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void gv_Venduto_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tree_Distinta.ExpandAll();
            tree_Distinta.Focus();
        }

        private void gv_Venduto_Enter(object sender, EventArgs e)
        {
            tree_Distinta.ExpandAll();

        }

        private void btn_visVenduto_Click(object sender, EventArgs e)
        {
            //string passingvalue = "XBAT020000020";
            //UC_Venduto uC_Venduto = new UC_Venduto(passingvalue);
            UC_Venduto uC_Venduto = new UC_Venduto(selectednodearticolo.ToString());
            uC_Venduto.Show();
        }

        private void tree_Distinta_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            int columnID3 = tree_Distinta.Columns[1].AbsoluteIndex;
            if (tree_Distinta.FocusedNode!= null)
            {
                object selected = tree_Distinta.FocusedNode.GetValue(columnID3);
                selectednodearticolo = selected.ToString();
            }
        }
    }
}