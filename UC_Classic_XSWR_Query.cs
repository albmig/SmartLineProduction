using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using MetroFramework.Forms;
using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

namespace SmartLineProduction
{
    public partial class UC_Classic_XSWR_Query : MetroForm
    {
        public UC_Classic_XSWR_Query()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////////////////
        /// Funzioni Personali
        ///////////////////////////////////////////////////////////////////////////////

        private void SettaForm()
        {
            switch (GVar.Form_Edit)
            {
                case true:
                    gridView_gv_FW.OptionsBehavior.Editable = true;

                    //buttons
                    link_New.Visible = false;
                    link_Edit.Visible = false;
                    link_Delete.Visible = false;
                    link_Save.Visible = true;
                    link_Abort.Visible = true;
                    link_Exit.Visible = false;

                    break;

                case false:
                    gridView_gv_FW.OptionsBehavior.Editable = false;

                    //buttons
                    link_New.Visible = false;
                    link_Edit.Visible = false;
                    link_Delete.Visible = false;
                    link_Save.Visible = false;
                    link_Abort.Visible = false;
                    link_Exit.Visible = true;

                    break;
            }
        }

        private void CaricaArchivi()
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_CL_FW_Query.Find_Device'. È possibile spostarla o rimuoverla se necessario.
            this.find_DeviceTableAdapter.Fill(this.ds_CL_FW_Query.Find_Device);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_CL_FW_Query.Find_Anno'. È possibile spostarla o rimuoverla se necessario.
            this.find_AnnoTableAdapter.Fill(this.ds_CL_FW_Query.Find_Anno);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_CL_FW_Query.TE_Excl_Customers'. È possibile spostarla o rimuoverla se necessario.
            this.tE_Excl_CustomersTableAdapter.Fill(this.ds_CL_FW_Query.TE_Excl_Customers);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_CL_FW_Query1.TE_view_XSWR_Clients_Excl'. È possibile spostarla o rimuoverla se necessario.
            this.tE_view_XSWR_Clients_ExclTableAdapter.Fill(this.ds_CL_FW_Query.TE_view_XSWR_Clients_Excl);


            // NOTA: modificato valore MaxLenght in dataset
            DataRow newDev = ds_CL_FW_Query.Find_Device.NewRow();
            newDev["TipoDevice"] = "- Select -";
            ds_CL_FW_Query.Find_Device.Rows.Add(newDev);

            DataRow newAnno = ds_CL_FW_Query.Find_Anno.NewRow();
            newAnno["AnnoOrdine"] = "- Select -";
            ds_CL_FW_Query.Find_Anno.Rows.Add(newAnno);

            int pos_dev = this.findDeviceBindingSource.Find("TipoDevice", "- Select -");
            int pos_anno = this.findAnnoBindingSource.Find("AnnoOrdine", "- Select -");
            this.findDeviceBindingSource.Position = pos_dev;
            this.findAnnoBindingSource.Position = pos_anno;
        }

        private void DiscardChanges()
        {

            //CaricaArchivi();

            //serialNumbersBindingSource.EndEdit();

            //serialNumbersBindingSource.CancelEdit();

            //gridView_gv_SN.RefreshData();

            //gv_SN.DataSource = null;

            //gv_SN.DataSource = this.serialNumbersBindingSource;

            //serialNumbersBindingSource.ResetBindings(false);

            //serialNumbersBindingSource.Position = GVar.BS_Position_01;

            //gv_SN.RefreshDataSource();

            //gv_SN.Refresh();

            //GVar.Form_Edit = false;
            //SettaForm();
        }

        private void AcceptChanges()
        {
            //this.serialNumbersBindingSource.EndEdit();
            //this.serialNumbersTableAdapter.Update(ds_local_SerialNumbers.SerialNumbers);
        }

        ///////////////////////////////////////////////////////////////////////////////
        /// Funzioni Autogenerate
        ///////////////////////////////////////////////////////////////////////////////

        private void UC_Classic_XSWR_Query_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            CaricaArchivi();

            SettaForm();

            //Crea Group Summary
            gridView_gv_FW.GroupSummary.Clear();
            GridSummaryItem summaryItemMaxOrderSum = gridView_gv_FW.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "QTA_SISTEMA", null, "(Totale = {0:###0})");

            GridColumn firstGroupColumn = gridView_gv_FW.SortInfo[0].Column;
            GroupSummarySortInfo[] groupSummaryToSort = { new GroupSummarySortInfo(summaryItemMaxOrderSum, firstGroupColumn, ColumnSortOrder.Descending) };
            gridView_gv_FW.GroupSummarySortInfo.ClearAndAddRange(groupSummaryToSort);

            //gridView_gv_FW.GroupSummarySortInfo.ClearAndAddRange(groupSummaryToSort);
        }

        private void link_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView_gv_Fw_P_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //DataRow row = gridView_gv_SN.GetDataRow(gridView_gv_SN.GetSelectedRows()[0]);
            //row["Row_Changed"] = true;
        }

        private void link_Edit_Click(object sender, EventArgs e)
        {
            //GVar.Form_Edit = true;

            //SettaForm();
        }

        private void link_Abort_Click(object sender, EventArgs e)
        {
            //DiscardChanges();

            //GVar.Form_Edit = false;
            //SettaForm();
        }

        private void link_Save_Click(object sender, EventArgs e)
        {
            //AcceptChanges();

            //GVar.Form_Edit = false;
            //SettaForm();
        }

        private void safetyPointRFIDBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //GVar.BS_Position_01 = serialNumbersBindingSource.Position;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Sistematica\Desktop\output.xlsx";
            gv_FW.ExportToXlsx(path);
        }

        private void but_filter_Click(object sender, EventArgs e)
        {
            string filtro = string.Empty;
            if (cb_Sel_Anno.Text != "- Select -")
            {
                filtro = "AnnoOrdine = " + "'" + cb_Sel_Anno.Text + "'";
                ColumnView view = gridView_gv_FW;
                view.ActiveFilter.Add(view.Columns["colAnnoOrdine"], new ColumnFilterInfo(filtro, ""));
            }

            if (cb_Sel_Device.Text != "- Select -")
            {
                filtro = "TipoDevice = " + "'" + cb_Sel_Device.Text + "'";
                ColumnView view = gridView_gv_FW;
                view.ActiveFilter.Add(view.Columns["colTipoDevice"], new ColumnFilterInfo(filtro, ""));
            }


            gv_FW.Refresh();
        }

        private void but_delete_filter_Click(object sender, EventArgs e)
        {
            ColumnView view = gridView_gv_FW;
            view.ActiveFilter.Clear();

            int pos_dev = this.findDeviceBindingSource.Find("TipoDevice", "- Select -");
            int pos_anno = this.findAnnoBindingSource.Find("AnnoOrdine", "- Select -");
            this.findDeviceBindingSource.Position = pos_dev;
            this.findAnnoBindingSource.Position = pos_anno;
        }
    }
}
