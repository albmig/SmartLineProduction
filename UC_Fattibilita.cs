using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace SmartLineProduction
{
    public partial class UC_Fattibilita : MetroFramework.Forms.MetroForm
    {
        public struct StructExpl
        {
            public int livello;
            public string art_composto;
            public string art_componente;
            public string des;
            public string des_est;
            public decimal qta_rich;
            public decimal giac_att;
            public decimal disp_imm;
            public decimal disp_fut;
            public decimal imp;
            public decimal ord;
            public decimal qta_prod;
            public bool da_espl;
            public bool existsub;
        }

        public UC_Fattibilita()
        {
            InitializeComponent();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_Fattibilita_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_Fattibile_Saldi'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Fattibile_SaldiTableAdapter.Fill(this.ds_SL.SF_Fattibile_Saldi);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_dbar'. È possibile spostarla o rimuoverla se necessario.
            this.sF_dbarTableAdapter.Fill(this.ds_SL.SF_dbar);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_Depositi'. È possibile spostarla o rimuoverla se necessario.
            this.sF_DepositiTableAdapter.Fill(this.ds_SL.SF_Depositi);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_Fattibile_Articolo'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Fattibile_ArticoloTableAdapter.Fill(this.ds_SL.SF_Fattibile_Articolo);

            PulisciForm();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            FiltraArticoli();
            tb_search.Focus();
        }

        private void FiltraArticoli()
        {
            string filtro = "";

            //Aggiungo filtro su tb_search
            if (tb_search.Text != "")
            {
                filtro = string.Format("Articolo LIKE '%{0}%'", tb_search.Text);
            }
            this.sFFattibileArticoloBindingSource.Filter = filtro;
        }

        private void PulisciForm()
        {
            tb_search.Text = "";
            tb_qta.Text = "1";
            layout_view.Visible = false;
            gv_Explode_Livello.Visible = false;

            gv_Explode.Columns["gv_Explode_QtaRich"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Explode.Columns["gv_Explode_Giac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Explode.Columns["gv_Explode_DispImm"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Explode.Columns["gv_Explode_DispFut"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Explode.Columns["gv_Explode_Imp"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Explode.Columns["gv_Explode_Ord"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Explode.Columns["gv_Explode_QtaProd"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            gv_Explode_Livello.Columns["gv_Explode_Livello_qtarich"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Explode_Livello.Columns["gv_Explode_Livello_giac"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Explode_Livello.Columns["gv_Explode_Livello_dispimm"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Explode_Livello.Columns["gv_Explode_Livello_dispfut"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Explode_Livello.Columns["gv_Explode_Livello_imp"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Explode_Livello.Columns["gv_Explode_Livello_ord"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Explode_Livello.Columns["gv_Explode_Livello_qtaprod"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void btn_Calcola_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            this.sF_Fattibile_SaldiTableAdapter.Fill(this.ds_SL.SF_Fattibile_Saldi);
            this.sF_dbarTableAdapter.Fill(this.ds_SL.SF_dbar);

            decimal qtax = Convert.ToDecimal(tb_qta.Text);

            ds_SL.dt_Tmp_Fattibile_Explode.Clear();
            layout_view.Visible = true;

            DataRowView drview = (DataRowView)sFFattibileArticoloBindingSource.Current;
            if (drview == null) { return; }

            string filtro_dbar = "ArticoloComposto = " + "'" + drview["Articolo"].ToString() + "'";
            DataRow[] drows = ds_SL.SF_dbar.Select(filtro_dbar);

            foreach (DataRow dr_dbar in drows)
            {
                var newrow = ds_SL.dt_Tmp_Fattibile_Explode.NewRow();

                newrow["ArticoloComposto"] = dr_dbar["ArticoloComposto"].ToString();
                newrow["ArticoloComponente"] = dr_dbar["ArticoloComponente"].ToString();
                newrow["Descrizione"] = dr_dbar["Des_Componente"].ToString();
                newrow["DescrizioneEstesa"] = dr_dbar["Des_Est_Componente"].ToString();
                newrow["QtaRichiesta"] = Convert.ToDecimal(dr_dbar["Quantita"].ToString()) * qtax;
                if (dr_dbar["FlEsplodiSemilav"].ToString() == "1") { newrow["DaEsplodere"] = true; } else { newrow["DaEsplodere"] = false; }

                //filtra su saldi
                string filtro_saldi = "Articolo = " + "'" + dr_dbar["ArticoloComponente"].ToString() + "'";
                //Ciclo su depositi
                string filtro_dep_saldi = "";
                foreach (DataGridViewRow deprow in gv_Depositi.Rows)
                {
                    //bool incluso = (bool)deprow.Cells["gv_Depositi_incluso"].FormattedValue;
                    bool incluso = (bool)deprow.Cells["InclusoValue"].FormattedValue;

                    if (incluso)
                    {
                        if (filtro_dep_saldi != "") { filtro_dep_saldi = filtro_dep_saldi + " OR "; }
                        filtro_dep_saldi = filtro_dep_saldi + "(Magazzino = " + "'" + deprow.Cells["gv_Depositi_codmag"].Value.ToString() + "')";
                    }
                }
                if (filtro_dep_saldi != "") { filtro_saldi = filtro_saldi + " AND  (" + filtro_dep_saldi + ")"; }

                DataView dv_saldi = new DataView(ds_SL.SF_Fattibile_Saldi);
                dv_saldi.RowFilter = filtro_saldi;

                DataTable saldi_table;
                saldi_table = dv_saldi.ToTable();

                decimal giac = 0;
                decimal dispimm = 0;
                decimal dispfut = 0;
                decimal imp = 0;
                decimal ord = 0;
                decimal prod = 0;

                if (saldi_table.Rows.Count != 0)
                {
                    giac = Convert.ToInt32(saldi_table.Compute("SUM(GiacenzaAttuale)", ""));
                    dispimm = Convert.ToInt32(saldi_table.Compute("SUM(DisponibilitaImm)", ""));
                    dispfut = Convert.ToInt32(saldi_table.Compute("SUM(DisponibilitaFutura)", ""));
                    imp = Convert.ToInt32(saldi_table.Compute("SUM(ImpegnatoClienti)", ""));
                    ord = Convert.ToInt32(saldi_table.Compute("SUM(OrdinatoFornitori)", ""));
                    prod = Convert.ToInt32(saldi_table.Compute("SUM(QtaInProduzione)", ""));
                }

                newrow["GiacenzaAttuale"] = giac;
                newrow["DisponibilitaImm"] = dispimm;
                newrow["DisponibilitaFutura"] = dispfut;
                newrow["ImpegnatoClienti"] = imp;
                newrow["OrdinatoFornitori"] = ord;
                newrow["QtaInProduzione"] = prod;

                ds_SL.dt_Tmp_Fattibile_Explode.Rows.Add(newrow);
            }

            gv_Explode.DataSource = ds_SL.dt_Tmp_Fattibile_Explode;
            layout_view.Visible = true;
            Cursor.Current = Cursors.Default;

        }

        private void dtTmpFattibileExplodeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView dr_componente = (DataRowView)dtTmpFattibileExplodeBindingSource.Current;
            if (dr_componente == null) { return; }


        }

        private void gv_Explode_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (this.gv_Explode.Columns["gv_Explode_BtnExpl"].Index == e.ColumnIndex && e.RowIndex >= 0)
            {

                if (!(bool)gv_Explode.Rows[e.RowIndex].Cells["gv_Explode_DaExpl"].Value)
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.Padding = new Padding(30, 30, 30, 30);

                    gv_Explode.Rows[e.RowIndex].Cells["gv_Explode_BtnExpl"].Style = style;
                }
            }

            if (this.gv_Explode.Columns["gv_Explode_Giac"].Index == e.ColumnIndex && e.RowIndex >= 0)
            {
                decimal rich = (decimal)gv_Explode.Rows[e.RowIndex].Cells["gv_Explode_QtaRich"].Value;
                decimal giac = (decimal)gv_Explode.Rows[e.RowIndex].Cells["gv_Explode_Giac"].Value;

                if (giac < rich)
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = Color.LightCoral;
                    gv_Explode.Rows[e.RowIndex].Cells["gv_Explode_Giac"].Style = style;
                }
                else
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = Color.LightGreen;
                    gv_Explode.Rows[e.RowIndex].Cells["gv_Explode_Giac"].Style = style;
                }
            }

            if (this.gv_Explode.Columns["gv_Explode_DispImm"].Index == e.ColumnIndex && e.RowIndex >= 0)
            {
                decimal rich = (decimal)gv_Explode.Rows[e.RowIndex].Cells["gv_Explode_QtaRich"].Value;
                decimal giac = (decimal)gv_Explode.Rows[e.RowIndex].Cells["gv_Explode_Giac"].Value;
                decimal dispimm = (decimal)gv_Explode.Rows[e.RowIndex].Cells["gv_Explode_DispImm"].Value;

                //if (rich > (giac + dispimm))
                if (rich > dispimm)
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = Color.LightCoral;
                    gv_Explode.Rows[e.RowIndex].Cells["gv_Explode_DispImm"].Style = style;
                }
                else
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = Color.LightGreen;
                    gv_Explode.Rows[e.RowIndex].Cells["gv_Explode_DispImm"].Style = style;
                }
            }

            if (this.gv_Explode.Columns["gv_Explode_DispFut"].Index == e.ColumnIndex && e.RowIndex >= 0)
            {
                decimal rich = (decimal)gv_Explode.Rows[e.RowIndex].Cells["gv_Explode_QtaRich"].Value;
                decimal giac = (decimal)gv_Explode.Rows[e.RowIndex].Cells["gv_Explode_Giac"].Value;
                decimal dispfut = (decimal)gv_Explode.Rows[e.RowIndex].Cells["gv_Explode_DispFut"].Value;

                //if (rich > (giac + dispfut))
                if (rich > dispfut)
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = Color.LightPink;
                    gv_Explode.Rows[e.RowIndex].Cells["gv_Explode_DispFut"].Style = style;
                }
                else
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = Color.LightYellow;
                    gv_Explode.Rows[e.RowIndex].Cells["gv_Explode_DispFut"].Style = style;
                }
            }

        }

        private void sFFattibileArticoloBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            layout_view.Visible = false;
        }

        private void gv_Explode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gv_Explode.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewRow row = gv_Explode.CurrentRow;
                EsplodiComponente(row);
                gv_Explode_Livello.DataSource = ds_SL.dt_Tmp_Fattibile_Explode_Componenti;
                gv_Explode_Livello.Visible = true;
            }
        }

        private void EsplodiComponente(DataGridViewRow exploderow)
        {
            ds_SL.dt_Tmp_Fattibile_Explode_Componenti.Clear();

            StructExpl newrec = new StructExpl();
            newrec.livello = 0;
            //newrec.art_composto = exploderow.Cells["gv_Explode_Composto"].Value.ToString();
            newrec.art_composto = exploderow.Cells["gv_Explode_Componente"].Value.ToString();
            newrec.art_componente = exploderow.Cells["gv_Explode_Componente"].Value.ToString();
            newrec.des = exploderow.Cells["gv_Explode_Des"].Value.ToString();
            newrec.des_est = exploderow.Cells["gv_Explode_DesEst"].Value.ToString();
            newrec.qta_rich = (decimal)exploderow.Cells["gv_Explode_QtaRich"].Value;
            newrec.da_espl = (bool)exploderow.Cells["gv_Explode_DaExpl"].Value;
            if (newrec.da_espl) { newrec.existsub = true; } else { newrec.existsub = false; }

            ScriviExplode(newrec);

            //Ciclo sulla distinta

            //foreach (DataRow row in ds_SL.dt_Tmp_Fattibile_Explode_Componenti.Rows)
            //{
            int i = 0;
            while (i < ds_SL.dt_Tmp_Fattibile_Explode_Componenti.Rows.Count)
            {
                DataRow row = ds_SL.dt_Tmp_Fattibile_Explode_Componenti.Rows[i];
                bool daespl = (bool)row["DaEsplodere"];
                if (daespl)
                {
                    int newlivello = Convert.ToInt16(row["Livello"]);
                    newlivello++;
                    string filtro_dbar = "ArticoloComposto = " + "'" + row["ArticoloComponente"].ToString() + "'";
                    DataRow[] drows = ds_SL.SF_dbar.Select(filtro_dbar);

                    foreach (DataRow dr_dbar in drows)
                    {
                        decimal qtax = (decimal)row["QtaRichiesta"];
                        StructExpl newrecdb = new StructExpl();
                        newrecdb.livello = newlivello;

                        newrecdb.art_composto = dr_dbar["ArticoloComposto"].ToString();
                        newrecdb.art_componente = dr_dbar["ArticoloComponente"].ToString();
                        newrecdb.des = dr_dbar["Des_Componente"].ToString();
                        newrecdb.des_est = dr_dbar["Des_Est_Componente"].ToString();
                        newrecdb.qta_rich = Convert.ToDecimal(dr_dbar["Quantita"].ToString()) * qtax;
                        if (dr_dbar["FlEsplodiSemilav"].ToString() == "1") { newrecdb.da_espl = true; newrecdb.existsub = true; } else { newrecdb.da_espl = false; newrecdb.existsub = false; }
                        ScriviExplode(newrecdb);
                    }
                }

                row["DaEsplodere"] = false;
                i++;
            }
        }

        private void ScriviExplode(StructExpl explrec)
        {
            var newrow = ds_SL.dt_Tmp_Fattibile_Explode_Componenti.NewRow();
            newrow["Livello"] = explrec.livello;
            newrow["ArticoloComposto"] = explrec.art_composto;
            newrow["ArticoloComponente"] = explrec.art_componente;
            newrow["Descrizione"] = explrec.des;
            newrow["DescrizioneEstesa"] = explrec.des_est;
            newrow["QtaRichiesta"] = explrec.qta_rich;
            newrow["DaEsplodere"] = explrec.da_espl;
            newrow["ExistSub"] = explrec.existsub;


            //filtra su saldi
            string filtro_saldi = "Articolo = " + "'" + explrec.art_componente + "'";
            //Ciclo su depositi
            string filtro_dep_saldi = "";
            foreach (DataGridViewRow deprow in gv_Depositi.Rows)
            {
                //bool incluso = (bool)deprow.Cells["gv_Depositi_incluso"].FormattedValue;
                bool incluso = (bool)deprow.Cells["InclusoValue"].FormattedValue;

                if (incluso)
                {
                    if (filtro_dep_saldi != "") { filtro_dep_saldi = filtro_dep_saldi + " OR "; }
                    filtro_dep_saldi = filtro_dep_saldi + "(Magazzino = " + "'" + deprow.Cells["gv_Depositi_codmag"].Value.ToString() + "')";
                }
            }
            if (filtro_dep_saldi != "") { filtro_saldi = filtro_saldi + " AND  (" + filtro_dep_saldi + ")"; }

            DataView dv_saldi = new DataView(ds_SL.SF_Fattibile_Saldi);
            dv_saldi.RowFilter = filtro_saldi;

            DataTable saldi_table;
            saldi_table = dv_saldi.ToTable();

            decimal giac = 0;
            decimal dispimm = 0;
            decimal dispfut = 0;
            decimal imp = 0;
            decimal ord = 0;
            decimal prod = 0;

            if (saldi_table.Rows.Count != 0)
            {
                giac = Convert.ToInt32(saldi_table.Compute("SUM(GiacenzaAttuale)", ""));
                dispimm = Convert.ToInt32(saldi_table.Compute("SUM(DisponibilitaImm)", ""));
                dispfut = Convert.ToInt32(saldi_table.Compute("SUM(DisponibilitaFutura)", ""));
                imp = Convert.ToInt32(saldi_table.Compute("SUM(ImpegnatoClienti)", ""));
                ord = Convert.ToInt32(saldi_table.Compute("SUM(OrdinatoFornitori)", ""));
                prod = Convert.ToInt32(saldi_table.Compute("SUM(QtaInProduzione)", ""));
            }

            newrow["GiacenzaAttuale"] = giac;
            newrow["DisponibilitaImm"] = dispimm;
            newrow["DisponibilitaFutura"] = dispfut;
            newrow["ImpegnatoClienti"] = imp;
            newrow["OrdinatoFornitori"] = ord;
            newrow["QtaInProduzione"] = prod;

            ds_SL.dt_Tmp_Fattibile_Explode_Componenti.Rows.Add(newrow);
        }

        private void gv_Explode_Livello_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (this.gv_Explode_Livello.Columns["gv_Explode_Livello_giac"].Index == e.ColumnIndex && e.RowIndex >= 0)
            {
                decimal rich = (decimal)gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_qtarich"].Value;
                decimal giac = (decimal)gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_giac"].Value;

                if (giac < rich)
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = Color.LightCoral;
                    gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_giac"].Style = style;
                }
                else
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = Color.LightGreen;
                    gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_giac"].Style = style;
                }
            }

            if (this.gv_Explode_Livello.Columns["gv_Explode_Livello_dispimm"].Index == e.ColumnIndex && e.RowIndex >= 0)
            {
                decimal rich = (decimal)gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_qtarich"].Value;
                decimal giac = (decimal)gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_giac"].Value;
                decimal dispimm = (decimal)gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_dispimm"].Value;

                //if (rich > (giac + dispimm))
                if (rich > dispimm)
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = Color.LightCoral;
                    gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_dispimm"].Style = style;
                }
                else
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = Color.LightGreen;
                    gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_dispimm"].Style = style;
                }
            }

            if (this.gv_Explode_Livello.Columns["gv_Explode_Livello_dispfut"].Index == e.ColumnIndex && e.RowIndex >= 0)
            {
                decimal rich = (decimal)gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_qtarich"].Value;
                decimal giac = (decimal)gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_giac"].Value;
                decimal dispfut = (decimal)gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_dispfut"].Value;

                //if (rich > (giac + dispfut))
                if (rich > dispfut)
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = Color.LightPink;
                    gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_dispfut"].Style = style;
                }
                else
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = Color.LightYellow;
                    gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_dispfut"].Style = style;
                }
            }

        }

        private void gv_Explode_SelectionChanged(object sender, EventArgs e)
        {
            gv_Explode_Livello.Visible = false;
        }

        private void gv_Explode_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            gv_Explode.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Regular);
        }

        private void gv_Explode_Livello_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_livello"].Value.ToString() == "0")
            {
                e.CellStyle.ForeColor = Color.DarkCyan;
            }
        }

        private void gv_Explode_Livello_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //if (this.gv_Explode_Livello.Columns["gv_Explode_Livello_subimage"].Index == e.ColumnIndex && e.RowIndex >= 0)
            //{
            //if ((bool)gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_existsub"].Value == true)
            //{
            //    gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_subimage"].Value = Properties.Resources.Esplodi;
            //}
            //else
            //{
            //    gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_subimage"].Value = Properties.Resources.EsplodiNull;
            //}
            //}
        }

        private void gv_Depositi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in gv_Depositi.Rows)
            {
                row.Cells["InclusoValue"].Value = row.Cells["gv_Depositi_incluso"].Value;
            }
        }

        private void gv_Depositi_Validating(object sender, CancelEventArgs e)
        {
            bool existonemag = false;
            foreach (DataGridViewRow row in gv_Depositi.Rows)
            {
                bool incluso = (bool)row.Cells["InclusoValue"].FormattedValue;

                if (incluso) { existonemag = true; }
            }
            if (!existonemag)
            {
                MessageBox.Show("Almeno un deposito deve essere incluso!");
                gv_Depositi.Focus();
            }
        }

        private void gv_Explode_Livello_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((bool)gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_existsub"].Value == true)
            {
                gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_subimage"].Value = Properties.Resources.Esplodi;
            }
            else
            {
                gv_Explode_Livello.Rows[e.RowIndex].Cells["gv_Explode_Livello_subimage"].Value = Properties.Resources.EsplodiNull;
            }
        }
    }
}
