
namespace SmartLineProduction
{
    partial class UC_Classic_XSWR_Query
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Classic_XSWR_Query));
            this.gv_FW = new DevExpress.XtraGrid.GridControl();
            this.tEviewXSWRClientsExclBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_CL_FW_Query = new SmartLineProduction.ds_CL_FW_Query();
            this.gridView_gv_FW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTIPO_ORDINE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORDINE_CLIENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRIGA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSISTEMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTA_SISTEMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticoloComponente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData_Start_FW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData_End_FW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoDevice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMastroCli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapocCli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContoCli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSottocCli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRagSocCognome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnnoOrdine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel_Menu = new MetroFramework.Controls.MetroPanel();
            this.layout_voci_menu = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.link_New = new MetroFramework.Controls.MetroLink();
            this.link_Edit = new MetroFramework.Controls.MetroLink();
            this.link_Delete = new MetroFramework.Controls.MetroLink();
            this.link_Save = new MetroFramework.Controls.MetroLink();
            this.link_Abort = new MetroFramework.Controls.MetroLink();
            this.link_Exit = new MetroFramework.Controls.MetroLink();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cb_Sel_Kit = new System.Windows.Forms.ComboBox();
            this.findKitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.but_delete_filter = new System.Windows.Forms.Button();
            this.but_filter = new System.Windows.Forms.Button();
            this.but_Export = new System.Windows.Forms.Button();
            this.cb_Sel_Device = new System.Windows.Forms.ComboBox();
            this.findDeviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cb_Sel_Anno = new System.Windows.Forms.ComboBox();
            this.findAnnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.fieldSWFamProd1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.find_AnnoTableAdapter = new SmartLineProduction.ds_CL_FW_QueryTableAdapters.Find_AnnoTableAdapter();
            this.find_DeviceTableAdapter = new SmartLineProduction.ds_CL_FW_QueryTableAdapters.Find_DeviceTableAdapter();
            this.tEExclCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tE_Excl_CustomersTableAdapter = new SmartLineProduction.ds_CL_FW_QueryTableAdapters.TE_Excl_CustomersTableAdapter();
            this.tE_view_XSWR_Clients_ExclTableAdapter = new SmartLineProduction.ds_CL_FW_QueryTableAdapters.TE_view_XSWR_Clients_ExclTableAdapter();
            this.find_KitTableAdapter = new SmartLineProduction.ds_CL_FW_QueryTableAdapters.Find_KitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gv_FW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEviewXSWRClientsExclBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CL_FW_Query)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_gv_FW)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.layout_voci_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findKitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findDeviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findAnnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEExclCustomersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_FW
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gv_FW, 2);
            this.gv_FW.DataSource = this.tEviewXSWRClientsExclBindingSource;
            this.gv_FW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_FW.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.RelationName = "Level1";
            this.gv_FW.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gv_FW.Location = new System.Drawing.Point(210, 140);
            this.gv_FW.MainView = this.gridView_gv_FW;
            this.gv_FW.Margin = new System.Windows.Forms.Padding(10);
            this.gv_FW.Name = "gv_FW";
            this.tableLayoutPanel1.SetRowSpan(this.gv_FW, 2);
            this.gv_FW.Size = new System.Drawing.Size(926, 414);
            this.gv_FW.TabIndex = 2;
            this.gv_FW.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_gv_FW});
            // 
            // tEviewXSWRClientsExclBindingSource
            // 
            this.tEviewXSWRClientsExclBindingSource.DataMember = "TE_view_XSWR_Clients_Excl";
            this.tEviewXSWRClientsExclBindingSource.DataSource = this.ds_CL_FW_Query;
            // 
            // ds_CL_FW_Query
            // 
            this.ds_CL_FW_Query.DataSetName = "ds_CL_FW_Query";
            this.ds_CL_FW_Query.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView_gv_FW
            // 
            this.gridView_gv_FW.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView_gv_FW.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView_gv_FW.Appearance.GroupRow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridView_gv_FW.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.gridView_gv_FW.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridView_gv_FW.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView_gv_FW.Appearance.GroupRow.Options.UseFont = true;
            this.gridView_gv_FW.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView_gv_FW.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAnnoOrdine,
            this.colORDINE_CLIENTE,
            this.colRagSocCognome,
            this.colKIT,
            this.colSISTEMA,
            this.colArticoloComponente,
            this.colQTA_SISTEMA,
            this.colTipoDevice,
            this.colMastroCli,
            this.colCapocCli,
            this.colContoCli,
            this.colSottocCli,
            this.colTIPO_ORDINE,
            this.colRIGA,
            this.colData_Start_FW,
            this.colData_End_FW});
            this.gridView_gv_FW.GridControl = this.gv_FW;
            this.gridView_gv_FW.GroupCount = 1;
            this.gridView_gv_FW.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QTA_SISTEMA", null, "(Q.tà: {0:0.##})")});
            this.gridView_gv_FW.Name = "gridView_gv_FW";
            this.gridView_gv_FW.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_gv_FW.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.gridView_gv_FW.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded;
            this.gridView_gv_FW.OptionsMenu.ShowFooterItem = true;
            this.gridView_gv_FW.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView_gv_FW.OptionsView.ShowIndicator = false;
            this.gridView_gv_FW.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colArticoloComponente, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView_gv_FW.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_gv_Fw_P_CellValueChanged);
            // 
            // colTIPO_ORDINE
            // 
            this.colTIPO_ORDINE.FieldName = "TIPO_ORDINE";
            this.colTIPO_ORDINE.Name = "colTIPO_ORDINE";
            // 
            // colORDINE_CLIENTE
            // 
            this.colORDINE_CLIENTE.FieldName = "ORDINE_CLIENTE";
            this.colORDINE_CLIENTE.Name = "colORDINE_CLIENTE";
            this.colORDINE_CLIENTE.Visible = true;
            this.colORDINE_CLIENTE.VisibleIndex = 1;
            this.colORDINE_CLIENTE.Width = 148;
            // 
            // colRIGA
            // 
            this.colRIGA.FieldName = "RIGA";
            this.colRIGA.Name = "colRIGA";
            // 
            // colKIT
            // 
            this.colKIT.FieldName = "KIT";
            this.colKIT.Name = "colKIT";
            this.colKIT.Visible = true;
            this.colKIT.VisibleIndex = 3;
            this.colKIT.Width = 94;
            // 
            // colSISTEMA
            // 
            this.colSISTEMA.FieldName = "SISTEMA";
            this.colSISTEMA.Name = "colSISTEMA";
            this.colSISTEMA.Visible = true;
            this.colSISTEMA.VisibleIndex = 4;
            this.colSISTEMA.Width = 89;
            // 
            // colQTA_SISTEMA
            // 
            this.colQTA_SISTEMA.FieldName = "QTA_SISTEMA";
            this.colQTA_SISTEMA.Name = "colQTA_SISTEMA";
            this.colQTA_SISTEMA.Visible = true;
            this.colQTA_SISTEMA.VisibleIndex = 5;
            this.colQTA_SISTEMA.Width = 94;
            // 
            // colArticoloComponente
            // 
            this.colArticoloComponente.FieldName = "ArticoloComponente";
            this.colArticoloComponente.Name = "colArticoloComponente";
            this.colArticoloComponente.Visible = true;
            this.colArticoloComponente.VisibleIndex = 4;
            this.colArticoloComponente.Width = 100;
            // 
            // colData_Start_FW
            // 
            this.colData_Start_FW.FieldName = "Data_Start_FW";
            this.colData_Start_FW.Name = "colData_Start_FW";
            this.colData_Start_FW.Width = 50;
            // 
            // colData_End_FW
            // 
            this.colData_End_FW.FieldName = "Data_End_FW";
            this.colData_End_FW.Name = "colData_End_FW";
            this.colData_End_FW.Width = 50;
            // 
            // colTipoDevice
            // 
            this.colTipoDevice.FieldName = "TipoDevice";
            this.colTipoDevice.Name = "colTipoDevice";
            this.colTipoDevice.Visible = true;
            this.colTipoDevice.VisibleIndex = 6;
            this.colTipoDevice.Width = 51;
            // 
            // colMastroCli
            // 
            this.colMastroCli.FieldName = "MastroCli";
            this.colMastroCli.Name = "colMastroCli";
            this.colMastroCli.Width = 50;
            // 
            // colCapocCli
            // 
            this.colCapocCli.FieldName = "CapocCli";
            this.colCapocCli.Name = "colCapocCli";
            this.colCapocCli.Width = 50;
            // 
            // colContoCli
            // 
            this.colContoCli.FieldName = "ContoCli";
            this.colContoCli.Name = "colContoCli";
            this.colContoCli.Width = 50;
            // 
            // colSottocCli
            // 
            this.colSottocCli.FieldName = "SottocCli";
            this.colSottocCli.Name = "colSottocCli";
            this.colSottocCli.Width = 50;
            // 
            // colRagSocCognome
            // 
            this.colRagSocCognome.FieldName = "RagSocCognome";
            this.colRagSocCognome.Name = "colRagSocCognome";
            this.colRagSocCognome.Visible = true;
            this.colRagSocCognome.VisibleIndex = 2;
            this.colRagSocCognome.Width = 300;
            // 
            // colAnnoOrdine
            // 
            this.colAnnoOrdine.FieldName = "AnnoOrdine";
            this.colAnnoOrdine.Name = "colAnnoOrdine";
            this.colAnnoOrdine.Visible = true;
            this.colAnnoOrdine.VisibleIndex = 0;
            this.colAnnoOrdine.Width = 148;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gv_FW, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel_Menu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1146, 564);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(203, 2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(155, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 129;
            this.metroLabel1.Text = "Firmware - Orders";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // panel_Menu
            // 
            this.panel_Menu.Controls.Add(this.layout_voci_menu);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Menu.HorizontalScrollbarBarColor = true;
            this.panel_Menu.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_Menu.HorizontalScrollbarSize = 10;
            this.panel_Menu.Location = new System.Drawing.Point(3, 3);
            this.panel_Menu.Name = "panel_Menu";
            this.tableLayoutPanel1.SetRowSpan(this.panel_Menu, 4);
            this.panel_Menu.Size = new System.Drawing.Size(194, 558);
            this.panel_Menu.TabIndex = 127;
            this.panel_Menu.VerticalScrollbarBarColor = true;
            this.panel_Menu.VerticalScrollbarHighlightOnWheel = false;
            this.panel_Menu.VerticalScrollbarSize = 10;
            // 
            // layout_voci_menu
            // 
            this.layout_voci_menu.BackColor = System.Drawing.Color.Transparent;
            this.layout_voci_menu.ColumnCount = 1;
            this.layout_voci_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_voci_menu.Controls.Add(this.pictureBox1, 0, 0);
            this.layout_voci_menu.Controls.Add(this.link_New, 0, 2);
            this.layout_voci_menu.Controls.Add(this.link_Edit, 0, 3);
            this.layout_voci_menu.Controls.Add(this.link_Delete, 0, 4);
            this.layout_voci_menu.Controls.Add(this.link_Save, 0, 9);
            this.layout_voci_menu.Controls.Add(this.link_Abort, 0, 10);
            this.layout_voci_menu.Controls.Add(this.link_Exit, 0, 15);
            this.layout_voci_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_voci_menu.Location = new System.Drawing.Point(0, 0);
            this.layout_voci_menu.Name = "layout_voci_menu";
            this.layout_voci_menu.RowCount = 16;
            this.layout_voci_menu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout_voci_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layout_voci_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.layout_voci_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.layout_voci_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.layout_voci_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.layout_voci_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.layout_voci_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.layout_voci_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.layout_voci_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.layout_voci_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.layout_voci_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.layout_voci_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.layout_voci_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.layout_voci_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.layout_voci_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.layout_voci_menu.Size = new System.Drawing.Size(194, 558);
            this.layout_voci_menu.TabIndex = 126;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // link_New
            // 
            this.link_New.AutoSize = true;
            this.link_New.BackColor = System.Drawing.Color.Transparent;
            this.link_New.Dock = System.Windows.Forms.DockStyle.Fill;
            this.link_New.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.link_New.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.link_New.Location = new System.Drawing.Point(3, 109);
            this.link_New.Name = "link_New";
            this.link_New.Size = new System.Drawing.Size(188, 26);
            this.link_New.Style = MetroFramework.MetroColorStyle.Black;
            this.link_New.TabIndex = 1;
            this.link_New.Text = "Nuovo";
            this.link_New.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link_New.UseCustomBackColor = true;
            this.link_New.UseSelectable = true;
            this.link_New.UseStyleColors = true;
            this.link_New.Visible = false;
            // 
            // link_Edit
            // 
            this.link_Edit.AutoSize = true;
            this.link_Edit.BackColor = System.Drawing.Color.Transparent;
            this.link_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.link_Edit.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.link_Edit.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.link_Edit.Location = new System.Drawing.Point(3, 141);
            this.link_Edit.Name = "link_Edit";
            this.link_Edit.Size = new System.Drawing.Size(188, 26);
            this.link_Edit.Style = MetroFramework.MetroColorStyle.Black;
            this.link_Edit.TabIndex = 4;
            this.link_Edit.Text = "Modifica";
            this.link_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link_Edit.UseCustomBackColor = true;
            this.link_Edit.UseSelectable = true;
            this.link_Edit.UseStyleColors = true;
            this.link_Edit.Click += new System.EventHandler(this.link_Edit_Click);
            // 
            // link_Delete
            // 
            this.link_Delete.AutoSize = true;
            this.link_Delete.BackColor = System.Drawing.Color.Transparent;
            this.link_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.link_Delete.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.link_Delete.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.link_Delete.Location = new System.Drawing.Point(3, 173);
            this.link_Delete.Name = "link_Delete";
            this.link_Delete.Size = new System.Drawing.Size(188, 26);
            this.link_Delete.Style = MetroFramework.MetroColorStyle.Black;
            this.link_Delete.TabIndex = 5;
            this.link_Delete.Text = "Elimina";
            this.link_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link_Delete.UseCustomBackColor = true;
            this.link_Delete.UseSelectable = true;
            this.link_Delete.UseStyleColors = true;
            // 
            // link_Save
            // 
            this.link_Save.AutoSize = true;
            this.link_Save.BackColor = System.Drawing.Color.Transparent;
            this.link_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.link_Save.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.link_Save.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.link_Save.Location = new System.Drawing.Point(3, 333);
            this.link_Save.Name = "link_Save";
            this.link_Save.Size = new System.Drawing.Size(188, 26);
            this.link_Save.Style = MetroFramework.MetroColorStyle.Orange;
            this.link_Save.TabIndex = 2;
            this.link_Save.Text = "Salva";
            this.link_Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link_Save.UseCustomBackColor = true;
            this.link_Save.UseSelectable = true;
            this.link_Save.UseStyleColors = true;
            this.link_Save.Click += new System.EventHandler(this.link_Save_Click);
            // 
            // link_Abort
            // 
            this.link_Abort.AutoSize = true;
            this.link_Abort.BackColor = System.Drawing.Color.Transparent;
            this.link_Abort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.link_Abort.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.link_Abort.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.link_Abort.Location = new System.Drawing.Point(3, 365);
            this.link_Abort.Name = "link_Abort";
            this.link_Abort.Size = new System.Drawing.Size(188, 26);
            this.link_Abort.Style = MetroFramework.MetroColorStyle.Orange;
            this.link_Abort.TabIndex = 3;
            this.link_Abort.Text = "Annulla Modifiche";
            this.link_Abort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link_Abort.UseCustomBackColor = true;
            this.link_Abort.UseSelectable = true;
            this.link_Abort.UseStyleColors = true;
            this.link_Abort.Click += new System.EventHandler(this.link_Abort_Click);
            // 
            // link_Exit
            // 
            this.link_Exit.AutoSize = true;
            this.link_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.link_Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.link_Exit.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.link_Exit.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.link_Exit.Location = new System.Drawing.Point(3, 525);
            this.link_Exit.Name = "link_Exit";
            this.link_Exit.Size = new System.Drawing.Size(188, 30);
            this.link_Exit.Style = MetroFramework.MetroColorStyle.Red;
            this.link_Exit.TabIndex = 0;
            this.link_Exit.Text = "Uscita";
            this.link_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link_Exit.UseCustomBackColor = true;
            this.link_Exit.UseSelectable = true;
            this.link_Exit.UseStyleColors = true;
            this.link_Exit.Click += new System.EventHandler(this.link_Exit_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.metroPanel1, 2);
            this.metroPanel1.Controls.Add(this.cb_Sel_Kit);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.but_delete_filter);
            this.metroPanel1.Controls.Add(this.but_filter);
            this.metroPanel1.Controls.Add(this.but_Export);
            this.metroPanel1.Controls.Add(this.cb_Sel_Device);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.cb_Sel_Anno);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(203, 33);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(940, 94);
            this.metroPanel1.TabIndex = 131;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cb_Sel_Kit
            // 
            this.cb_Sel_Kit.DataSource = this.findKitBindingSource;
            this.cb_Sel_Kit.DisplayMember = "KIT";
            this.cb_Sel_Kit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Sel_Kit.FormattingEnabled = true;
            this.cb_Sel_Kit.Location = new System.Drawing.Point(93, 62);
            this.cb_Sel_Kit.Name = "cb_Sel_Kit";
            this.cb_Sel_Kit.Size = new System.Drawing.Size(128, 21);
            this.cb_Sel_Kit.TabIndex = 134;
            // 
            // findKitBindingSource
            // 
            this.findKitBindingSource.DataMember = "Find_Kit";
            this.findKitBindingSource.DataSource = this.ds_CL_FW_Query;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 62);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(26, 19);
            this.metroLabel3.TabIndex = 133;
            this.metroLabel3.Text = "Kit:";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // but_delete_filter
            // 
            this.but_delete_filter.Location = new System.Drawing.Point(432, 58);
            this.but_delete_filter.Name = "but_delete_filter";
            this.but_delete_filter.Size = new System.Drawing.Size(131, 23);
            this.but_delete_filter.TabIndex = 132;
            this.but_delete_filter.Text = "Annulla Filtro";
            this.but_delete_filter.UseVisualStyleBackColor = true;
            this.but_delete_filter.Click += new System.EventHandler(this.but_delete_filter_Click);
            // 
            // but_filter
            // 
            this.but_filter.Location = new System.Drawing.Point(295, 58);
            this.but_filter.Name = "but_filter";
            this.but_filter.Size = new System.Drawing.Size(131, 23);
            this.but_filter.TabIndex = 131;
            this.but_filter.Text = "Filtra";
            this.but_filter.UseVisualStyleBackColor = true;
            this.but_filter.Click += new System.EventHandler(this.but_filter_Click);
            // 
            // but_Export
            // 
            this.but_Export.Location = new System.Drawing.Point(777, 58);
            this.but_Export.Name = "but_Export";
            this.but_Export.Size = new System.Drawing.Size(131, 23);
            this.but_Export.TabIndex = 130;
            this.but_Export.Text = "Export to Excel file";
            this.but_Export.UseVisualStyleBackColor = true;
            this.but_Export.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_Sel_Device
            // 
            this.cb_Sel_Device.DataSource = this.findDeviceBindingSource;
            this.cb_Sel_Device.DisplayMember = "TipoDevice";
            this.cb_Sel_Device.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Sel_Device.FormattingEnabled = true;
            this.cb_Sel_Device.Location = new System.Drawing.Point(93, 35);
            this.cb_Sel_Device.Name = "cb_Sel_Device";
            this.cb_Sel_Device.Size = new System.Drawing.Size(128, 21);
            this.cb_Sel_Device.TabIndex = 95;
            // 
            // findDeviceBindingSource
            // 
            this.findDeviceBindingSource.DataMember = "Find_Device";
            this.findDeviceBindingSource.DataSource = this.ds_CL_FW_Query;
            this.findDeviceBindingSource.Sort = "TipoDevice asc";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 94;
            this.metroLabel2.Text = "Tipo Device:";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // cb_Sel_Anno
            // 
            this.cb_Sel_Anno.DataSource = this.findAnnoBindingSource;
            this.cb_Sel_Anno.DisplayMember = "AnnoOrdine";
            this.cb_Sel_Anno.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Sel_Anno.FormattingEnabled = true;
            this.cb_Sel_Anno.Location = new System.Drawing.Point(92, 8);
            this.cb_Sel_Anno.Name = "cb_Sel_Anno";
            this.cb_Sel_Anno.Size = new System.Drawing.Size(129, 21);
            this.cb_Sel_Anno.TabIndex = 93;
            // 
            // findAnnoBindingSource
            // 
            this.findAnnoBindingSource.DataMember = "Find_Anno";
            this.findAnnoBindingSource.DataSource = this.ds_CL_FW_Query;
            this.findAnnoBindingSource.Sort = "AnnoOrdine asc";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 8);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 92;
            this.metroLabel4.Text = "Anno:";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // fieldSWFamProd1
            // 
            this.fieldSWFamProd1.AreaIndex = 8;
            this.fieldSWFamProd1.Caption = "SW_Fam Prod";
            this.fieldSWFamProd1.FieldName = "SW_FamProd";
            this.fieldSWFamProd1.Name = "fieldSWFamProd1";
            // 
            // find_AnnoTableAdapter
            // 
            this.find_AnnoTableAdapter.ClearBeforeFill = true;
            // 
            // find_DeviceTableAdapter
            // 
            this.find_DeviceTableAdapter.ClearBeforeFill = true;
            // 
            // tEExclCustomersBindingSource
            // 
            this.tEExclCustomersBindingSource.DataMember = "TE_Excl_Customers";
            this.tEExclCustomersBindingSource.DataSource = this.ds_CL_FW_Query;
            // 
            // tE_Excl_CustomersTableAdapter
            // 
            this.tE_Excl_CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // tE_view_XSWR_Clients_ExclTableAdapter
            // 
            this.tE_view_XSWR_Clients_ExclTableAdapter.ClearBeforeFill = true;
            // 
            // find_KitTableAdapter
            // 
            this.find_KitTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Classic_XSWR_Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1186, 614);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DisplayHeader = false;
            this.Movable = false;
            this.Name = "UC_Classic_XSWR_Query";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Local - SmartLine Serial Numbers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UC_Classic_XSWR_Query_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_FW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEviewXSWRClientsExclBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CL_FW_Query)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_gv_FW)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel_Menu.ResumeLayout(false);
            this.layout_voci_menu.ResumeLayout(false);
            this.layout_voci_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findKitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findDeviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findAnnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEExclCustomersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSWFamProd1;
        private DevExpress.XtraGrid.GridControl gv_FW;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_gv_FW;
        private MetroFramework.Controls.MetroPanel panel_Menu;
        private System.Windows.Forms.TableLayoutPanel layout_voci_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLink link_New;
        private MetroFramework.Controls.MetroLink link_Edit;
        private MetroFramework.Controls.MetroLink link_Delete;
        private MetroFramework.Controls.MetroLink link_Save;
        private MetroFramework.Controls.MetroLink link_Abort;
        private MetroFramework.Controls.MetroLink link_Exit;
        private System.Windows.Forms.BindingSource serialNumbersSFClientiSerialNumbersBindingSource;
        //private ds_local_SerialNumbersTableAdapters.SF_Clienti_SerialNumbersTableAdapter sF_Clienti_SerialNumbersTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private ds_CL_FW_Query ds_CL_FW_Query;
        private System.Windows.Forms.Button but_Export;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox cb_Sel_Device;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox cb_Sel_Anno;
        private System.Windows.Forms.BindingSource findAnnoBindingSource;
        private ds_CL_FW_QueryTableAdapters.Find_AnnoTableAdapter find_AnnoTableAdapter;
        private System.Windows.Forms.BindingSource findDeviceBindingSource;
        private ds_CL_FW_QueryTableAdapters.Find_DeviceTableAdapter find_DeviceTableAdapter;
        private System.Windows.Forms.Button but_filter;
        private System.Windows.Forms.BindingSource tEExclCustomersBindingSource;
        private ds_CL_FW_QueryTableAdapters.TE_Excl_CustomersTableAdapter tE_Excl_CustomersTableAdapter;
        private System.Windows.Forms.BindingSource tEviewXSWRClientsExclBindingSource;
        private ds_CL_FW_QueryTableAdapters.TE_view_XSWR_Clients_ExclTableAdapter tE_view_XSWR_Clients_ExclTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTIPO_ORDINE;
        private DevExpress.XtraGrid.Columns.GridColumn colORDINE_CLIENTE;
        private DevExpress.XtraGrid.Columns.GridColumn colRIGA;
        private DevExpress.XtraGrid.Columns.GridColumn colKIT;
        private DevExpress.XtraGrid.Columns.GridColumn colSISTEMA;
        private DevExpress.XtraGrid.Columns.GridColumn colQTA_SISTEMA;
        private DevExpress.XtraGrid.Columns.GridColumn colArticoloComponente;
        private DevExpress.XtraGrid.Columns.GridColumn colData_Start_FW;
        private DevExpress.XtraGrid.Columns.GridColumn colData_End_FW;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoDevice;
        private DevExpress.XtraGrid.Columns.GridColumn colMastroCli;
        private DevExpress.XtraGrid.Columns.GridColumn colCapocCli;
        private DevExpress.XtraGrid.Columns.GridColumn colContoCli;
        private DevExpress.XtraGrid.Columns.GridColumn colSottocCli;
        private DevExpress.XtraGrid.Columns.GridColumn colRagSocCognome;
        private DevExpress.XtraGrid.Columns.GridColumn colAnnoOrdine;
        private System.Windows.Forms.Button but_delete_filter;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox cb_Sel_Kit;
        private System.Windows.Forms.BindingSource findKitBindingSource;
        private ds_CL_FW_QueryTableAdapters.Find_KitTableAdapter find_KitTableAdapter;
    }
}