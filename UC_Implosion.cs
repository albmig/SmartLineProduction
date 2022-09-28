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
using System.Data.SqlClient;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;

namespace SmartLineProduction
{
    public partial class UC_Implosion : MetroFramework.Forms.MetroForm
    {
        string codarticolo = "";

        public UC_Implosion()
        {
            InitializeComponent();
        }

        private void UC_Implosion_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_DistinteBasi'. È possibile spostarla o rimuoverla se necessario.
               this.sF_DistinteBasiTableAdapter.FillBy_AllComponents(this.ds_SL.SF_DistinteBasi);

            string filtro = "ArticoloComponente = " + "'" + codarticolo + "'";
            sFDistinteBasiBindingSource.RemoveFilter();
            sFDistinteBasiBindingSource.Filter = filtro;
            if (sFDistinteBasiBindingSource.Count == 0)
            {
                tview_implosion.Visible = false;
            }
            else
            {
                Implodi();
                PopulateTreeView();
            }
        }

        internal void LoadArticolo(String codart)
        {
            codarticolo = codart;
            this.Text = this.Text + codarticolo;
        }

        private void copiaIlValoreNellaClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string codart = "";
            codart = tview_implosion.SelectedValue.ToString();
            Clipboard.SetDataObject(codart);
        }

        private void Implodi()
        {
            ds_SL.dt_Tmp_Fattibile_Explode.Clear();

            int index = 1;
            int parent = 0;
            int child = 1;

            var newrow = ds_SL.dt_Tmp_Fattibile_Explode.NewRow();
            newrow["ArticoloComposto"] = codarticolo;
            newrow["ArticoloComponente"] = "";
            newrow["Indeximpl"] = index;
            newrow["ChildMember"] = child;
            newrow["ParentMember"] = parent;

            ds_SL.dt_Tmp_Fattibile_Explode.Rows.Add(newrow);

            string key = codarticolo;
            //Trova e scrivi
            for (int i = 1; i <= ds_SL.dt_Tmp_Fattibile_Explode.Count(); i++)
            {
                string filtroexpl = "Indeximpl = " + i;
                ds_SL.dt_Tmp_Fattibile_Explode.DefaultView.RowFilter = filtroexpl;
                if (ds_SL.dt_Tmp_Fattibile_Explode.DefaultView.Count > 0)
                {
                    foreach (DataRowView explView in ds_SL.dt_Tmp_Fattibile_Explode.DefaultView)
                    {
                        DataRow explrow = explView.Row;
                        key = explrow["ArticoloComposto"].ToString();
                        parent = Convert.ToInt32(explrow["ChildMember"]);
                    }
                }
                string filtro = "ArticoloComponente = " + "'" + key + "'";
                ds_SL.SF_DistinteBasi.DefaultView.RowFilter = filtro;
                if (ds_SL.SF_DistinteBasi.DefaultView.Count > 0)
                {
                    foreach (DataRowView rowView in ds_SL.SF_DistinteBasi.DefaultView)
                    {
                        DataRow row = rowView.Row;
                        var db_row = ds_SL.dt_Tmp_Fattibile_Explode.NewRow();
                        db_row["ArticoloComposto"] = row["ArticoloComposto"].ToString();
                        db_row["ArticoloComponente"] = row["ArticoloComponente"].ToString();
                        index++;
                        db_row["Indeximpl"] = index;
                        db_row["ChildMember"] = index;
                        db_row["ParentMember"] = parent;

                        ds_SL.dt_Tmp_Fattibile_Explode.Rows.Add(db_row);
                    }
                }
            }
        }

        private void PopulateTreeView()
        {
            tview_implosion.DataSource = ds_SL.dt_Tmp_Fattibile_Explode;
            tview_implosion.SelfRelationRootValue = "0";
            tview_implosion.DisplayMember = "ArticoloComposto";
            tview_implosion.ParentMember = "ParentMember";
            tview_implosion.ChildMember = "ChildMember";
            tview_implosion.ValueMember = "ArticoloComponente";
            tview_implosion.ExpandAll();
            tview_implosion.Refresh();
        }

        private void tview_implosion_Click(object sender, EventArgs e)
        {
            tview_implosion.ExpandAll();
        }
    }
}
