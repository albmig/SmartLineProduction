namespace SmartLineProduction
{
    partial class UC_Venduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.analisiCostiArticoloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_SL = new SmartLineProduction.ds_SL();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colArticolo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQta_Tot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.analisi_Costi_ArticoloTableAdapter = new SmartLineProduction.ds_SLTableAdapters.Analisi_Costi_ArticoloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisiCostiArticoloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.analisiCostiArticoloBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(20, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(460, 375);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // analisiCostiArticoloBindingSource
            // 
            this.analisiCostiArticoloBindingSource.DataMember = "Analisi_Costi_Articolo";
            this.analisiCostiArticoloBindingSource.DataSource = this.ds_SL;
            this.analisiCostiArticoloBindingSource.Filter = "";
            // 
            // ds_SL
            // 
            this.ds_SL.DataSetName = "ds_SL";
            this.ds_SL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colArticolo,
            this.colCliente,
            this.colQta_Tot});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qta_Tot", null, "(Quantità venduta: SUM={0:N2})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsMenu.ShowSummaryItemMode = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colArticolo
            // 
            this.colArticolo.FieldName = "Articolo";
            this.colArticolo.Name = "colArticolo";
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 0;
            // 
            // colQta_Tot
            // 
            this.colQta_Tot.Caption = "Quantità";
            this.colQta_Tot.DisplayFormat.FormatString = "{0:n2}";
            this.colQta_Tot.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQta_Tot.FieldName = "Qta_Tot";
            this.colQta_Tot.GroupFormat.FormatString = "{0:n2}";
            this.colQta_Tot.Name = "colQta_Tot";
            this.colQta_Tot.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qta_Tot", "Totale venduto: {0:n2}")});
            this.colQta_Tot.Visible = true;
            this.colQta_Tot.VisibleIndex = 1;
            // 
            // analisi_Costi_ArticoloTableAdapter
            // 
            this.analisi_Costi_ArticoloTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Venduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(500, 455);
            this.Controls.Add(this.gridControl1);
            this.Name = "UC_Venduto";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Elenco venduto per articolo";
            this.Deactivate += new System.EventHandler(this.UC_Venduto_Deactivate);
            this.Load += new System.EventHandler(this.UC_Venduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisiCostiArticoloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ds_SL ds_SL;
        private System.Windows.Forms.BindingSource analisiCostiArticoloBindingSource;
        private ds_SLTableAdapters.Analisi_Costi_ArticoloTableAdapter analisi_Costi_ArticoloTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colArticolo;
        private DevExpress.XtraGrid.Columns.GridColumn colQta_Tot;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
    }
}