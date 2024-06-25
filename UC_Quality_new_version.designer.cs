namespace SmartLineProduction
{
    partial class UC_Quality_new_version
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Quality_new_version));
            this.layout_orizz_menu = new System.Windows.Forms.TableLayoutPanel();
            this.pan_Menu_salva = new System.Windows.Forms.MenuStrip();
            this.menu_sw_salva = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_div12 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_annulla = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_Menu_comandi = new System.Windows.Forms.MenuStrip();
            this.menu_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_div01 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.creaRevisioneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_fattibilita = new MetroFramework.Controls.MetroPanel();
            this.layout_Schede = new System.Windows.Forms.TableLayoutPanel();
            this.gv_Quality = new DevExpress.XtraGrid.GridControl();
            this.sFQualityViewNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Quality_new = new SmartLineProduction.ds_Quality_new();
            this.MainGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQual_Des = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodiceQual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDes_ProjProdArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDes_Company = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDes_TipoDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQual_Rev_Obsolete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.but_view_obsolete = new DevExpress.XtraEditors.SimpleButton();
            this.but_hide_obsolete = new DevExpress.XtraEditors.SimpleButton();
            this.panel_Sigle = new System.Windows.Forms.TableLayoutPanel();
            this.tb_rev = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lab_rev = new MetroFramework.Controls.MetroLabel();
            this.cb_User = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_vers = new MetroFramework.Controls.MetroTextBox();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.dtQualityClassificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab_vers = new MetroFramework.Controls.MetroLabel();
            this.lab_MyIp = new MetroFramework.Controls.MetroLabel();
            this.tb_folder = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lab_folder = new MetroFramework.Controls.MetroLabel();
            this.cb_projprodarea = new System.Windows.Forms.ComboBox();
            this.dtQualityProjProdAreaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_Des = new MetroFramework.Controls.MetroTextBox();
            this.lab_projprodarea = new MetroFramework.Controls.MetroLabel();
            this.lab_des = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lab_Codice_Edit = new MetroFramework.Controls.MetroLabel();
            this.cb_org = new System.Windows.Forms.ComboBox();
            this.dtQualityCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_codedit = new MetroFramework.Controls.MetroLabel();
            this.lab_org = new MetroFramework.Controls.MetroLabel();
            this.lab_Codice_View = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.label_codview = new MetroFramework.Controls.MetroLabel();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.dtQualityTipoDocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_desClass = new MetroFramework.Controls.MetroTextBox();
            this.lab_type = new MetroFramework.Controls.MetroLabel();
            this.lab_class = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.qualityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeListBand1 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListBand2 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListBand3 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.qualityTableAdapter = new SmartLineProduction.ds_Quality_newTableAdapters.QualityTableAdapter();
            this.usersTableAdapter = new SmartLineProduction.ds_Quality_newTableAdapters.UsersTableAdapter();
            this.dt_Quality_ProjProdAreaTableAdapter = new SmartLineProduction.ds_Quality_newTableAdapters.dt_Quality_ProjProdAreaTableAdapter();
            this.dt_Quality_CompanyTableAdapter = new SmartLineProduction.ds_Quality_newTableAdapters.dt_Quality_CompanyTableAdapter();
            this.dt_Quality_TipoDocTableAdapter = new SmartLineProduction.ds_Quality_newTableAdapters.dt_Quality_TipoDocTableAdapter();
            this.dt_Quality_ClassificationTableAdapter = new SmartLineProduction.ds_Quality_newTableAdapters.dt_Quality_ClassificationTableAdapter();
            this.cntxt_CopyToClipboard = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.copiaIlValoreNellaClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sF_QualityViewNewTableAdapter = new SmartLineProduction.ds_Quality_newTableAdapters.SF_QualityViewNewTableAdapter();
            this.layout_orizz_menu.SuspendLayout();
            this.pan_Menu_salva.SuspendLayout();
            this.pan_Menu_comandi.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            this.panel_fattibilita.SuspendLayout();
            this.layout_Schede.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Quality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFQualityViewNewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Quality_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).BeginInit();
            this.panel_Sigle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtQualityClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtQualityProjProdAreaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtQualityCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtQualityTipoDocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityBindingSource)).BeginInit();
            this.cntxt_CopyToClipboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout_orizz_menu
            // 
            this.layout_orizz_menu.BackColor = System.Drawing.Color.Gainsboro;
            this.layout_orizz_menu.ColumnCount = 10;
            this.layout_orizz_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_orizz_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_orizz_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_orizz_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_orizz_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_orizz_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_orizz_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_orizz_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_orizz_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_orizz_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_orizz_menu.Controls.Add(this.pan_Menu_salva, 6, 0);
            this.layout_orizz_menu.Controls.Add(this.pan_Menu_comandi, 0, 0);
            this.layout_orizz_menu.Controls.Add(this.pan_Menu_exit, 10, 0);
            this.layout_orizz_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.layout_orizz_menu.Location = new System.Drawing.Point(20, 30);
            this.layout_orizz_menu.Name = "layout_orizz_menu";
            this.layout_orizz_menu.RowCount = 1;
            this.layout_orizz_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_orizz_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layout_orizz_menu.Size = new System.Drawing.Size(1460, 25);
            this.layout_orizz_menu.TabIndex = 125;
            // 
            // pan_Menu_salva
            // 
            this.pan_Menu_salva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pan_Menu_salva.BackColor = System.Drawing.Color.Gainsboro;
            this.layout_orizz_menu.SetColumnSpan(this.pan_Menu_salva, 2);
            this.pan_Menu_salva.Dock = System.Windows.Forms.DockStyle.None;
            this.pan_Menu_salva.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sw_salva,
            this.menu_sw_div12,
            this.menu_sw_annulla});
            this.pan_Menu_salva.Location = new System.Drawing.Point(938, 0);
            this.pan_Menu_salva.Name = "pan_Menu_salva";
            this.pan_Menu_salva.Size = new System.Drawing.Size(168, 24);
            this.pan_Menu_salva.TabIndex = 86;
            this.pan_Menu_salva.Text = "menuStrip1";
            // 
            // menu_sw_salva
            // 
            this.menu_sw_salva.Image = ((System.Drawing.Image)(resources.GetObject("menu_sw_salva.Image")));
            this.menu_sw_salva.Name = "menu_sw_salva";
            this.menu_sw_salva.Size = new System.Drawing.Size(62, 20);
            this.menu_sw_salva.Text = "Salva";
            this.menu_sw_salva.Click += new System.EventHandler(this.menu_sw_salva_Click);
            // 
            // menu_sw_div12
            // 
            this.menu_sw_div12.Enabled = false;
            this.menu_sw_div12.Name = "menu_sw_div12";
            this.menu_sw_div12.ShowShortcutKeys = false;
            this.menu_sw_div12.Size = new System.Drawing.Size(22, 20);
            this.menu_sw_div12.Text = "|";
            // 
            // menu_sw_annulla
            // 
            this.menu_sw_annulla.Image = ((System.Drawing.Image)(resources.GetObject("menu_sw_annulla.Image")));
            this.menu_sw_annulla.Name = "menu_sw_annulla";
            this.menu_sw_annulla.Size = new System.Drawing.Size(76, 20);
            this.menu_sw_annulla.Text = "Annulla";
            this.menu_sw_annulla.Click += new System.EventHandler(this.menu_sw_annulla_Click);
            // 
            // pan_Menu_comandi
            // 
            this.pan_Menu_comandi.BackColor = System.Drawing.Color.Gainsboro;
            this.layout_orizz_menu.SetColumnSpan(this.pan_Menu_comandi, 5);
            this.pan_Menu_comandi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Menu_comandi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_new,
            this.menu_div01,
            this.menu_edit,
            this.toolStripMenuItem1,
            this.creaRevisioneToolStripMenuItem1});
            this.pan_Menu_comandi.Location = new System.Drawing.Point(0, 0);
            this.pan_Menu_comandi.Name = "pan_Menu_comandi";
            this.pan_Menu_comandi.Size = new System.Drawing.Size(730, 25);
            this.pan_Menu_comandi.TabIndex = 85;
            this.pan_Menu_comandi.Text = "menuStrip1";
            // 
            // menu_new
            // 
            this.menu_new.Image = ((System.Drawing.Image)(resources.GetObject("menu_new.Image")));
            this.menu_new.Name = "menu_new";
            this.menu_new.Size = new System.Drawing.Size(111, 21);
            this.menu_new.Text = "Nuovo Codice";
            this.menu_new.Click += new System.EventHandler(this.menu_new_Click);
            // 
            // menu_div01
            // 
            this.menu_div01.Enabled = false;
            this.menu_div01.Name = "menu_div01";
            this.menu_div01.Size = new System.Drawing.Size(22, 21);
            this.menu_div01.Text = "|";
            // 
            // menu_edit
            // 
            this.menu_edit.Image = ((System.Drawing.Image)(resources.GetObject("menu_edit.Image")));
            this.menu_edit.Name = "menu_edit";
            this.menu_edit.Size = new System.Drawing.Size(122, 21);
            this.menu_edit.Text = "Modifica Codice";
            this.menu_edit.Click += new System.EventHandler(this.menu_edit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 21);
            this.toolStripMenuItem1.Text = "|";
            // 
            // creaRevisioneToolStripMenuItem1
            // 
            this.creaRevisioneToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("creaRevisioneToolStripMenuItem1.Image")));
            this.creaRevisioneToolStripMenuItem1.Name = "creaRevisioneToolStripMenuItem1";
            this.creaRevisioneToolStripMenuItem1.Size = new System.Drawing.Size(112, 21);
            this.creaRevisioneToolStripMenuItem1.Text = "Crea Revisione";
            this.creaRevisioneToolStripMenuItem1.Click += new System.EventHandler(this.creaRevisioneToolStripMenuItem1_Click);
            // 
            // pan_Menu_exit
            // 
            this.pan_Menu_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_Menu_exit.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_Menu_exit.Dock = System.Windows.Forms.DockStyle.None;
            this.pan_Menu_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sw_exit});
            this.pan_Menu_exit.Location = new System.Drawing.Point(1385, 0);
            this.pan_Menu_exit.Name = "pan_Menu_exit";
            this.pan_Menu_exit.Size = new System.Drawing.Size(75, 24);
            this.pan_Menu_exit.TabIndex = 82;
            this.pan_Menu_exit.Text = "menuStrip1";
            // 
            // menu_sw_exit
            // 
            this.menu_sw_exit.Image = ((System.Drawing.Image)(resources.GetObject("menu_sw_exit.Image")));
            this.menu_sw_exit.Name = "menu_sw_exit";
            this.menu_sw_exit.Size = new System.Drawing.Size(67, 20);
            this.menu_sw_exit.Text = "Uscita";
            this.menu_sw_exit.Click += new System.EventHandler(this.menu_sw_exit_Click);
            // 
            // panel_fattibilita
            // 
            this.panel_fattibilita.Controls.Add(this.layout_Schede);
            this.panel_fattibilita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fattibilita.HorizontalScrollbarBarColor = true;
            this.panel_fattibilita.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_fattibilita.HorizontalScrollbarSize = 10;
            this.panel_fattibilita.Location = new System.Drawing.Point(20, 55);
            this.panel_fattibilita.Name = "panel_fattibilita";
            this.panel_fattibilita.Size = new System.Drawing.Size(1460, 595);
            this.panel_fattibilita.TabIndex = 126;
            this.panel_fattibilita.VerticalScrollbarBarColor = true;
            this.panel_fattibilita.VerticalScrollbarHighlightOnWheel = false;
            this.panel_fattibilita.VerticalScrollbarSize = 10;
            // 
            // layout_Schede
            // 
            this.layout_Schede.ColumnCount = 3;
            this.layout_Schede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layout_Schede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layout_Schede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layout_Schede.Controls.Add(this.gv_Quality, 0, 1);
            this.layout_Schede.Controls.Add(this.but_view_obsolete, 0, 0);
            this.layout_Schede.Controls.Add(this.but_hide_obsolete, 1, 0);
            this.layout_Schede.Controls.Add(this.panel_Sigle, 2, 1);
            this.layout_Schede.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Schede.Location = new System.Drawing.Point(0, 0);
            this.layout_Schede.Name = "layout_Schede";
            this.layout_Schede.RowCount = 2;
            this.layout_Schede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layout_Schede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Schede.Size = new System.Drawing.Size(1460, 595);
            this.layout_Schede.TabIndex = 123;
            // 
            // gv_Quality
            // 
            this.layout_Schede.SetColumnSpan(this.gv_Quality, 2);
            this.gv_Quality.DataSource = this.sFQualityViewNewBindingSource;
            this.gv_Quality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Quality.Location = new System.Drawing.Point(3, 33);
            this.gv_Quality.MainView = this.MainGridView;
            this.gv_Quality.Name = "gv_Quality";
            this.gv_Quality.Size = new System.Drawing.Size(870, 559);
            this.gv_Quality.TabIndex = 46;
            this.gv_Quality.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainGridView});
            // 
            // sFQualityViewNewBindingSource
            // 
            this.sFQualityViewNewBindingSource.DataMember = "SF_QualityViewNew";
            this.sFQualityViewNewBindingSource.DataSource = this.ds_Quality_new;
            this.sFQualityViewNewBindingSource.Sort = "Qual_Prog desc, Qual_Ver desc, Qual_Rev desc";
            this.sFQualityViewNewBindingSource.CurrentChanged += new System.EventHandler(this.sFQualityViewNewBindingSource_CurrentChanged);
            // 
            // ds_Quality_new
            // 
            this.ds_Quality_new.DataSetName = "ds_Quality_new";
            this.ds_Quality_new.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainGridView
            // 
            this.MainGridView.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.MainGridView.Appearance.DetailTip.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.DetailTip.Options.UseFont = true;
            this.MainGridView.Appearance.EvenRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.EvenRow.Options.UseFont = true;
            this.MainGridView.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.FilterPanel.Options.UseFont = true;
            this.MainGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.MainGridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.MainGridView.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.FooterPanel.Options.UseFont = true;
            this.MainGridView.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.GroupFooter.Options.UseFont = true;
            this.MainGridView.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.GroupPanel.Options.UseFont = true;
            this.MainGridView.Appearance.GroupRow.BackColor = System.Drawing.SystemColors.Control;
            this.MainGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.MainGridView.Appearance.GroupRow.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MainGridView.Appearance.GroupRow.Options.UseBackColor = true;
            this.MainGridView.Appearance.GroupRow.Options.UseFont = true;
            this.MainGridView.Appearance.GroupRow.Options.UseForeColor = true;
            this.MainGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.MainGridView.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.MainGridView.Appearance.HotTrackedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.HotTrackedRow.Options.UseFont = true;
            this.MainGridView.Appearance.NoSearchResults.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.NoSearchResults.Options.UseFont = true;
            this.MainGridView.Appearance.OddRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.OddRow.Options.UseFont = true;
            this.MainGridView.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.Preview.Options.UseFont = true;
            this.MainGridView.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.Row.Options.UseFont = true;
            this.MainGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.MainGridView.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.TopNewRow.Options.UseFont = true;
            this.MainGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.MainGridView.AutoFillColumn = this.colQual_Des;
            this.MainGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodiceQual,
            this.colDes_ProjProdArea,
            this.colDes_Company,
            this.colDes_TipoDoc,
            this.colQual_Des,
            this.colQual_Rev_Obsolete});
            this.MainGridView.GridControl = this.gv_Quality;
            this.MainGridView.GroupCount = 3;
            this.MainGridView.GroupFormat = "{1}";
            this.MainGridView.Name = "MainGridView";
            this.MainGridView.OptionsBehavior.Editable = false;
            this.MainGridView.OptionsBehavior.ReadOnly = true;
            this.MainGridView.OptionsCustomization.AllowSort = false;
            this.MainGridView.OptionsSelection.UseIndicatorForSelection = false;
            this.MainGridView.OptionsView.ColumnAutoWidth = false;
            this.MainGridView.OptionsView.ShowColumnHeaders = false;
            this.MainGridView.OptionsView.ShowGroupPanel = false;
            this.MainGridView.OptionsView.ShowIndicator = false;
            this.MainGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDes_ProjProdArea, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDes_Company, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDes_TipoDoc, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.MainGridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // colQual_Des
            // 
            this.colQual_Des.FieldName = "Qual_Des";
            this.colQual_Des.Name = "colQual_Des";
            this.colQual_Des.Visible = true;
            this.colQual_Des.VisibleIndex = 1;
            this.colQual_Des.Width = 157;
            // 
            // colcodiceQual
            // 
            this.colcodiceQual.FieldName = "codiceQual";
            this.colcodiceQual.MinWidth = 180;
            this.colcodiceQual.Name = "colcodiceQual";
            this.colcodiceQual.Visible = true;
            this.colcodiceQual.VisibleIndex = 0;
            this.colcodiceQual.Width = 222;
            // 
            // colDes_ProjProdArea
            // 
            this.colDes_ProjProdArea.Caption = "Project / Product / Area";
            this.colDes_ProjProdArea.FieldName = "Des_ProjProdArea";
            this.colDes_ProjProdArea.Name = "colDes_ProjProdArea";
            this.colDes_ProjProdArea.Visible = true;
            this.colDes_ProjProdArea.VisibleIndex = 0;
            this.colDes_ProjProdArea.Width = 150;
            // 
            // colDes_Company
            // 
            this.colDes_Company.FieldName = "Des_Company";
            this.colDes_Company.Name = "colDes_Company";
            this.colDes_Company.Visible = true;
            this.colDes_Company.VisibleIndex = 0;
            // 
            // colDes_TipoDoc
            // 
            this.colDes_TipoDoc.FieldName = "Des_TipoDoc";
            this.colDes_TipoDoc.Name = "colDes_TipoDoc";
            this.colDes_TipoDoc.Visible = true;
            this.colDes_TipoDoc.VisibleIndex = 0;
            // 
            // colQual_Rev_Obsolete
            // 
            this.colQual_Rev_Obsolete.FieldName = "Qual_Rev_Obsolete";
            this.colQual_Rev_Obsolete.Name = "colQual_Rev_Obsolete";
            this.colQual_Rev_Obsolete.Width = 158;
            // 
            // but_view_obsolete
            // 
            this.but_view_obsolete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.but_view_obsolete.Appearance.BorderColor = System.Drawing.Color.Red;
            this.but_view_obsolete.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_view_obsolete.Appearance.Options.UseBackColor = true;
            this.but_view_obsolete.Appearance.Options.UseBorderColor = true;
            this.but_view_obsolete.Appearance.Options.UseFont = true;
            this.but_view_obsolete.Dock = System.Windows.Forms.DockStyle.Left;
            this.but_view_obsolete.Location = new System.Drawing.Point(3, 3);
            this.but_view_obsolete.Name = "but_view_obsolete";
            this.but_view_obsolete.Size = new System.Drawing.Size(114, 24);
            this.but_view_obsolete.TabIndex = 47;
            this.but_view_obsolete.Text = "Visualizza obsoleti";
            this.but_view_obsolete.Click += new System.EventHandler(this.but_view_obsolete_Click);
            // 
            // but_hide_obsolete
            // 
            this.but_hide_obsolete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.but_hide_obsolete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.but_hide_obsolete.Appearance.BorderColor = System.Drawing.Color.Red;
            this.but_hide_obsolete.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_hide_obsolete.Appearance.Options.UseBackColor = true;
            this.but_hide_obsolete.Appearance.Options.UseBorderColor = true;
            this.but_hide_obsolete.Appearance.Options.UseFont = true;
            this.but_hide_obsolete.Location = new System.Drawing.Point(759, 3);
            this.but_hide_obsolete.Name = "but_hide_obsolete";
            this.but_hide_obsolete.Size = new System.Drawing.Size(114, 24);
            this.but_hide_obsolete.TabIndex = 48;
            this.but_hide_obsolete.Text = "Nascondi obsoleti";
            this.but_hide_obsolete.Click += new System.EventHandler(this.but_hide_obsolete_Click);
            // 
            // panel_Sigle
            // 
            this.panel_Sigle.ColumnCount = 3;
            this.panel_Sigle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_Sigle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
            this.panel_Sigle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panel_Sigle.Controls.Add(this.metroLabel2, 0, 0);
            this.panel_Sigle.Controls.Add(this.cb_User, 1, 0);
            this.panel_Sigle.Controls.Add(this.cb_class, 1, 4);
            this.panel_Sigle.Controls.Add(this.lab_MyIp, 2, 0);
            this.panel_Sigle.Controls.Add(this.metroLabel1, 0, 1);
            this.panel_Sigle.Controls.Add(this.cb_projprodarea, 1, 1);
            this.panel_Sigle.Controls.Add(this.tb_Des, 1, 9);
            this.panel_Sigle.Controls.Add(this.lab_projprodarea, 2, 1);
            this.panel_Sigle.Controls.Add(this.lab_des, 0, 9);
            this.panel_Sigle.Controls.Add(this.metroLabel3, 0, 2);
            this.panel_Sigle.Controls.Add(this.lab_Codice_Edit, 1, 8);
            this.panel_Sigle.Controls.Add(this.cb_org, 1, 2);
            this.panel_Sigle.Controls.Add(this.label_codedit, 0, 8);
            this.panel_Sigle.Controls.Add(this.lab_org, 2, 2);
            this.panel_Sigle.Controls.Add(this.metroLabel4, 0, 3);
            this.panel_Sigle.Controls.Add(this.cb_type, 1, 3);
            this.panel_Sigle.Controls.Add(this.tb_desClass, 1, 5);
            this.panel_Sigle.Controls.Add(this.lab_type, 2, 3);
            this.panel_Sigle.Controls.Add(this.lab_class, 2, 4);
            this.panel_Sigle.Controls.Add(this.metroLabel5, 0, 4);
            this.panel_Sigle.Controls.Add(this.lab_Codice_View, 1, 14);
            this.panel_Sigle.Controls.Add(this.lab_vers, 0, 10);
            this.panel_Sigle.Controls.Add(this.tb_vers, 1, 10);
            this.panel_Sigle.Controls.Add(this.lab_folder, 0, 12);
            this.panel_Sigle.Controls.Add(this.tb_folder, 1, 12);
            this.panel_Sigle.Controls.Add(this.lab_rev, 0, 11);
            this.panel_Sigle.Controls.Add(this.tb_rev, 1, 11);
            this.panel_Sigle.Controls.Add(this.label_codview, 0, 14);
            this.panel_Sigle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Sigle.Location = new System.Drawing.Point(879, 33);
            this.panel_Sigle.Name = "panel_Sigle";
            this.panel_Sigle.RowCount = 16;
            this.panel_Sigle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_Sigle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_Sigle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_Sigle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_Sigle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_Sigle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_Sigle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_Sigle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_Sigle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_Sigle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_Sigle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_Sigle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_Sigle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_Sigle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_Sigle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_Sigle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.panel_Sigle.Size = new System.Drawing.Size(578, 559);
            this.panel_Sigle.TabIndex = 53;
            // 
            // tb_rev
            // 
            this.tb_rev.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.tb_rev.CustomButton.Image = null;
            this.tb_rev.CustomButton.Location = new System.Drawing.Point(18, 2);
            this.tb_rev.CustomButton.Name = "";
            this.tb_rev.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tb_rev.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_rev.CustomButton.TabIndex = 1;
            this.tb_rev.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_rev.CustomButton.UseSelectable = true;
            this.tb_rev.CustomButton.Visible = false;
            this.tb_rev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sFQualityViewNewBindingSource, "Qual_Rev", true));
            this.tb_rev.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tb_rev.Lines = new string[] {
        "tb_rev"};
            this.tb_rev.Location = new System.Drawing.Point(169, 388);
            this.tb_rev.MaxLength = 32767;
            this.tb_rev.Name = "tb_rev";
            this.tb_rev.PasswordChar = '\0';
            this.tb_rev.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_rev.SelectedText = "";
            this.tb_rev.SelectionLength = 0;
            this.tb_rev.SelectionStart = 0;
            this.tb_rev.ShortcutsEnabled = true;
            this.tb_rev.Size = new System.Drawing.Size(46, 29);
            this.tb_rev.Style = MetroFramework.MetroColorStyle.Red;
            this.tb_rev.TabIndex = 45;
            this.tb_rev.Text = "tb_rev";
            this.tb_rev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_rev.UseSelectable = true;
            this.tb_rev.UseStyleColors = true;
            this.tb_rev.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_rev.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_rev.Leave += new System.EventHandler(this.tb_rev_Leave);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(3, 8);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Utente:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // lab_rev
            // 
            this.lab_rev.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_rev.AutoSize = true;
            this.lab_rev.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_rev.Location = new System.Drawing.Point(3, 393);
            this.lab_rev.Name = "lab_rev";
            this.lab_rev.Size = new System.Drawing.Size(73, 19);
            this.lab_rev.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_rev.TabIndex = 39;
            this.lab_rev.Text = "Revisione :";
            this.lab_rev.UseStyleColors = true;
            // 
            // cb_User
            // 
            this.cb_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_User.DataSource = this.usersBindingSource;
            this.cb_User.DisplayMember = "UTENTE";
            this.cb_User.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_User.FormattingEnabled = true;
            this.cb_User.Location = new System.Drawing.Point(169, 6);
            this.cb_User.Name = "cb_User";
            this.cb_User.Size = new System.Drawing.Size(337, 23);
            this.cb_User.TabIndex = 26;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.ds_Quality_new;
            this.usersBindingSource.CurrentChanged += new System.EventHandler(this.usersBindingSource_CurrentChanged);
            // 
            // tb_vers
            // 
            this.tb_vers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.tb_vers.CustomButton.Image = null;
            this.tb_vers.CustomButton.Location = new System.Drawing.Point(16, 2);
            this.tb_vers.CustomButton.Name = "";
            this.tb_vers.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tb_vers.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_vers.CustomButton.TabIndex = 1;
            this.tb_vers.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_vers.CustomButton.UseSelectable = true;
            this.tb_vers.CustomButton.Visible = false;
            this.tb_vers.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sFQualityViewNewBindingSource, "Qual_Ver", true));
            this.tb_vers.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tb_vers.Lines = new string[] {
        "tb_vers"};
            this.tb_vers.Location = new System.Drawing.Point(169, 353);
            this.tb_vers.MaxLength = 32767;
            this.tb_vers.Name = "tb_vers";
            this.tb_vers.PasswordChar = '\0';
            this.tb_vers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_vers.SelectedText = "";
            this.tb_vers.SelectionLength = 0;
            this.tb_vers.SelectionStart = 0;
            this.tb_vers.ShortcutsEnabled = true;
            this.tb_vers.Size = new System.Drawing.Size(44, 29);
            this.tb_vers.Style = MetroFramework.MetroColorStyle.Red;
            this.tb_vers.TabIndex = 44;
            this.tb_vers.Text = "tb_vers";
            this.tb_vers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_vers.UseSelectable = true;
            this.tb_vers.UseStyleColors = true;
            this.tb_vers.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_vers.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_vers.Leave += new System.EventHandler(this.tb_vers_Leave);
            // 
            // cb_class
            // 
            this.cb_class.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_class.DataSource = this.dtQualityClassificationBindingSource;
            this.cb_class.DisplayMember = "Qual_Des";
            this.cb_class.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Location = new System.Drawing.Point(169, 146);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(337, 23);
            this.cb_class.TabIndex = 30;
            // 
            // dtQualityClassificationBindingSource
            // 
            this.dtQualityClassificationBindingSource.DataMember = "dt_Quality_Classification";
            this.dtQualityClassificationBindingSource.DataSource = this.ds_Quality_new;
            this.dtQualityClassificationBindingSource.CurrentChanged += new System.EventHandler(this.dtQualityClassificationBindingSource_CurrentChanged);
            // 
            // lab_vers
            // 
            this.lab_vers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_vers.AutoSize = true;
            this.lab_vers.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_vers.Location = new System.Drawing.Point(3, 358);
            this.lab_vers.Name = "lab_vers";
            this.lab_vers.Size = new System.Drawing.Size(68, 19);
            this.lab_vers.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_vers.TabIndex = 38;
            this.lab_vers.Text = "Versione :";
            this.lab_vers.UseStyleColors = true;
            // 
            // lab_MyIp
            // 
            this.lab_MyIp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_MyIp.AutoSize = true;
            this.lab_MyIp.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_MyIp.Location = new System.Drawing.Point(516, 8);
            this.lab_MyIp.Name = "lab_MyIp";
            this.lab_MyIp.Size = new System.Drawing.Size(54, 19);
            this.lab_MyIp.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_MyIp.TabIndex = 20;
            this.lab_MyIp.Text = "Utente:";
            this.lab_MyIp.UseStyleColors = true;
            this.lab_MyIp.Visible = false;
            // 
            // tb_folder
            // 
            this.tb_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Sigle.SetColumnSpan(this.tb_folder, 2);
            // 
            // 
            // 
            this.tb_folder.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tb_folder.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.tb_folder.CustomButton.Location = new System.Drawing.Point(382, 1);
            this.tb_folder.CustomButton.Name = "";
            this.tb_folder.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_folder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_folder.CustomButton.TabIndex = 1;
            this.tb_folder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_folder.CustomButton.UseSelectable = true;
            this.tb_folder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sFQualityViewNewBindingSource, "Qual_Path", true));
            this.tb_folder.DisplayIcon = true;
            this.tb_folder.Lines = new string[] {
        "metroTextBox2"};
            this.tb_folder.Location = new System.Drawing.Point(169, 425);
            this.tb_folder.MaxLength = 32767;
            this.tb_folder.Name = "tb_folder";
            this.tb_folder.PasswordChar = '\0';
            this.tb_folder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_folder.SelectedText = "";
            this.tb_folder.SelectionLength = 0;
            this.tb_folder.SelectionStart = 0;
            this.tb_folder.ShortcutsEnabled = true;
            this.tb_folder.ShowButton = true;
            this.tb_folder.Size = new System.Drawing.Size(406, 25);
            this.tb_folder.Style = MetroFramework.MetroColorStyle.Red;
            this.tb_folder.TabIndex = 43;
            this.tb_folder.Text = "metroTextBox2";
            this.tb_folder.UseSelectable = true;
            this.tb_folder.UseStyleColors = true;
            this.tb_folder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_folder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_folder.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.tb_folder_ButtonClick);
            this.tb_folder.TextChanged += new System.EventHandler(this.tb_folder_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(160, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Project / Product / Area :";
            this.metroLabel1.UseStyleColors = true;
            // 
            // lab_folder
            // 
            this.lab_folder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_folder.AutoSize = true;
            this.lab_folder.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_folder.Location = new System.Drawing.Point(3, 428);
            this.lab_folder.Name = "lab_folder";
            this.lab_folder.Size = new System.Drawing.Size(148, 19);
            this.lab_folder.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_folder.TabIndex = 37;
            this.lab_folder.Text = "Cartella di riferimento :";
            this.lab_folder.UseStyleColors = true;
            // 
            // cb_projprodarea
            // 
            this.cb_projprodarea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_projprodarea.DataSource = this.dtQualityProjProdAreaBindingSource;
            this.cb_projprodarea.DisplayMember = "Qual_Des";
            this.cb_projprodarea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cb_projprodarea.FormattingEnabled = true;
            this.cb_projprodarea.Location = new System.Drawing.Point(169, 41);
            this.cb_projprodarea.Name = "cb_projprodarea";
            this.cb_projprodarea.Size = new System.Drawing.Size(337, 23);
            this.cb_projprodarea.TabIndex = 27;
            // 
            // dtQualityProjProdAreaBindingSource
            // 
            this.dtQualityProjProdAreaBindingSource.DataMember = "dt_Quality_ProjProdArea";
            this.dtQualityProjProdAreaBindingSource.DataSource = this.ds_Quality_new;
            this.dtQualityProjProdAreaBindingSource.CurrentChanged += new System.EventHandler(this.dtQualityProjProdAreaBindingSource_CurrentChanged);
            // 
            // tb_Des
            // 
            this.tb_Des.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Sigle.SetColumnSpan(this.tb_Des, 2);
            // 
            // 
            // 
            this.tb_Des.CustomButton.Image = null;
            this.tb_Des.CustomButton.Location = new System.Drawing.Point(382, 1);
            this.tb_Des.CustomButton.Name = "";
            this.tb_Des.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_Des.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Des.CustomButton.TabIndex = 1;
            this.tb_Des.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Des.CustomButton.UseSelectable = true;
            this.tb_Des.CustomButton.Visible = false;
            this.tb_Des.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sFQualityViewNewBindingSource, "Qual_Des", true));
            this.tb_Des.Lines = new string[] {
        "tb_Des"};
            this.tb_Des.Location = new System.Drawing.Point(169, 320);
            this.tb_Des.MaxLength = 32767;
            this.tb_Des.Name = "tb_Des";
            this.tb_Des.PasswordChar = '\0';
            this.tb_Des.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Des.SelectedText = "";
            this.tb_Des.SelectionLength = 0;
            this.tb_Des.SelectionStart = 0;
            this.tb_Des.ShortcutsEnabled = true;
            this.tb_Des.Size = new System.Drawing.Size(406, 25);
            this.tb_Des.Style = MetroFramework.MetroColorStyle.Red;
            this.tb_Des.TabIndex = 42;
            this.tb_Des.Text = "tb_Des";
            this.tb_Des.UseSelectable = true;
            this.tb_Des.UseStyleColors = true;
            this.tb_Des.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Des.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Des.Leave += new System.EventHandler(this.tb_Des_Leave);
            // 
            // lab_projprodarea
            // 
            this.lab_projprodarea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_projprodarea.AutoSize = true;
            this.lab_projprodarea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtQualityProjProdAreaBindingSource, "Qual_Codice", true));
            this.lab_projprodarea.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_projprodarea.Location = new System.Drawing.Point(516, 43);
            this.lab_projprodarea.Name = "lab_projprodarea";
            this.lab_projprodarea.Size = new System.Drawing.Size(54, 19);
            this.lab_projprodarea.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_projprodarea.TabIndex = 21;
            this.lab_projprodarea.Text = "Utente:";
            this.lab_projprodarea.UseStyleColors = true;
            // 
            // lab_des
            // 
            this.lab_des.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_des.AutoSize = true;
            this.lab_des.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_des.Location = new System.Drawing.Point(3, 323);
            this.lab_des.Name = "lab_des";
            this.lab_des.Size = new System.Drawing.Size(85, 19);
            this.lab_des.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_des.TabIndex = 36;
            this.lab_des.Text = "Descrizione :";
            this.lab_des.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(3, 78);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Organization :";
            this.metroLabel3.UseStyleColors = true;
            // 
            // lab_Codice_Edit
            // 
            this.lab_Codice_Edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_Codice_Edit.AutoSize = true;
            this.lab_Codice_Edit.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_Codice_Edit.Location = new System.Drawing.Point(169, 288);
            this.lab_Codice_Edit.Name = "lab_Codice_Edit";
            this.lab_Codice_Edit.Size = new System.Drawing.Size(115, 19);
            this.lab_Codice_Edit.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_Codice_Edit.TabIndex = 41;
            this.lab_Codice_Edit.Text = "Codice Qualità :";
            this.lab_Codice_Edit.UseStyleColors = true;
            // 
            // cb_org
            // 
            this.cb_org.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_org.DataSource = this.dtQualityCompanyBindingSource;
            this.cb_org.DisplayMember = "Qual_Des";
            this.cb_org.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cb_org.FormattingEnabled = true;
            this.cb_org.Location = new System.Drawing.Point(169, 76);
            this.cb_org.Name = "cb_org";
            this.cb_org.Size = new System.Drawing.Size(337, 23);
            this.cb_org.TabIndex = 28;
            // 
            // dtQualityCompanyBindingSource
            // 
            this.dtQualityCompanyBindingSource.DataMember = "dt_Quality_Company";
            this.dtQualityCompanyBindingSource.DataSource = this.ds_Quality_new;
            this.dtQualityCompanyBindingSource.CurrentChanged += new System.EventHandler(this.dtQualityCompanyBindingSource_CurrentChanged);
            // 
            // label_codedit
            // 
            this.label_codedit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_codedit.AutoSize = true;
            this.label_codedit.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label_codedit.Location = new System.Drawing.Point(3, 288);
            this.label_codedit.Name = "label_codedit";
            this.label_codedit.Size = new System.Drawing.Size(105, 19);
            this.label_codedit.Style = MetroFramework.MetroColorStyle.Red;
            this.label_codedit.TabIndex = 35;
            this.label_codedit.Text = "Codice Qualità :";
            this.label_codedit.UseStyleColors = true;
            // 
            // lab_org
            // 
            this.lab_org.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_org.AutoSize = true;
            this.lab_org.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtQualityCompanyBindingSource, "Qual_Codice", true));
            this.lab_org.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_org.Location = new System.Drawing.Point(516, 78);
            this.lab_org.Name = "lab_org";
            this.lab_org.Size = new System.Drawing.Size(54, 19);
            this.lab_org.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_org.TabIndex = 22;
            this.lab_org.Text = "Utente:";
            this.lab_org.UseStyleColors = true;
            // 
            // lab_Codice_View
            // 
            this.lab_Codice_View.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_Codice_View.AutoSize = true;
            this.lab_Codice_View.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sFQualityViewNewBindingSource, "codiceQual", true));
            this.lab_Codice_View.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_Codice_View.Location = new System.Drawing.Point(169, 498);
            this.lab_Codice_View.Name = "lab_Codice_View";
            this.lab_Codice_View.Size = new System.Drawing.Size(115, 19);
            this.lab_Codice_View.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_Codice_View.TabIndex = 40;
            this.lab_Codice_View.Text = "Codice Qualità :";
            this.lab_Codice_View.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(3, 113);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(126, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Type of document :";
            this.metroLabel4.UseStyleColors = true;
            // 
            // label_codview
            // 
            this.label_codview.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_codview.AutoSize = true;
            this.label_codview.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label_codview.Location = new System.Drawing.Point(3, 498);
            this.label_codview.Name = "label_codview";
            this.label_codview.Size = new System.Drawing.Size(105, 19);
            this.label_codview.Style = MetroFramework.MetroColorStyle.Red;
            this.label_codview.TabIndex = 34;
            this.label_codview.Text = "Codice Qualità :";
            this.label_codview.UseStyleColors = true;
            // 
            // cb_type
            // 
            this.cb_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_type.DataSource = this.dtQualityTipoDocBindingSource;
            this.cb_type.DisplayMember = "Qual_Des";
            this.cb_type.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(169, 111);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(337, 23);
            this.cb_type.TabIndex = 29;
            // 
            // dtQualityTipoDocBindingSource
            // 
            this.dtQualityTipoDocBindingSource.DataMember = "dt_Quality_TipoDoc";
            this.dtQualityTipoDocBindingSource.DataSource = this.ds_Quality_new;
            this.dtQualityTipoDocBindingSource.CurrentChanged += new System.EventHandler(this.dtQualityTipoDocBindingSource_CurrentChanged);
            // 
            // tb_desClass
            // 
            this.panel_Sigle.SetColumnSpan(this.tb_desClass, 2);
            // 
            // 
            // 
            this.tb_desClass.CustomButton.Image = null;
            this.tb_desClass.CustomButton.Location = new System.Drawing.Point(300, 2);
            this.tb_desClass.CustomButton.Name = "";
            this.tb_desClass.CustomButton.Size = new System.Drawing.Size(103, 103);
            this.tb_desClass.CustomButton.Style = MetroFramework.MetroColorStyle.Red;
            this.tb_desClass.CustomButton.TabIndex = 1;
            this.tb_desClass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_desClass.CustomButton.UseSelectable = true;
            this.tb_desClass.CustomButton.Visible = false;
            this.tb_desClass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtQualityClassificationBindingSource, "Qual_Note", true));
            this.tb_desClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_desClass.Enabled = false;
            this.tb_desClass.Lines = new string[] {
        "metroTextBox1"};
            this.tb_desClass.Location = new System.Drawing.Point(169, 178);
            this.tb_desClass.MaxLength = 32767;
            this.tb_desClass.Multiline = true;
            this.tb_desClass.Name = "tb_desClass";
            this.tb_desClass.PasswordChar = '\0';
            this.tb_desClass.ReadOnly = true;
            this.panel_Sigle.SetRowSpan(this.tb_desClass, 3);
            this.tb_desClass.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_desClass.SelectedText = "";
            this.tb_desClass.SelectionLength = 0;
            this.tb_desClass.SelectionStart = 0;
            this.tb_desClass.ShortcutsEnabled = true;
            this.tb_desClass.Size = new System.Drawing.Size(406, 99);
            this.tb_desClass.TabIndex = 25;
            this.tb_desClass.Text = "metroTextBox1";
            this.tb_desClass.UseSelectable = true;
            this.tb_desClass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_desClass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lab_type
            // 
            this.lab_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_type.AutoSize = true;
            this.lab_type.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtQualityTipoDocBindingSource, "Qual_Codice", true));
            this.lab_type.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_type.Location = new System.Drawing.Point(516, 113);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(54, 19);
            this.lab_type.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_type.TabIndex = 23;
            this.lab_type.Text = "Utente:";
            this.lab_type.UseStyleColors = true;
            // 
            // lab_class
            // 
            this.lab_class.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_class.AutoSize = true;
            this.lab_class.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dtQualityClassificationBindingSource, "Qual_Codice", true));
            this.lab_class.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_class.Location = new System.Drawing.Point(516, 148);
            this.lab_class.Name = "lab_class";
            this.lab_class.Size = new System.Drawing.Size(54, 19);
            this.lab_class.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_class.TabIndex = 24;
            this.lab_class.Text = "Utente:";
            this.lab_class.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(3, 148);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(94, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Classification :";
            this.metroLabel5.UseStyleColors = true;
            // 
            // qualityBindingSource
            // 
            this.qualityBindingSource.DataMember = "Quality";
            this.qualityBindingSource.DataSource = this.ds_Quality_new;
            this.qualityBindingSource.Sort = "Qual_ProjProdArea asc, Qual_Org asc, Qual_Type asc";
            this.qualityBindingSource.CurrentChanged += new System.EventHandler(this.qualityBindingSource_CurrentChanged);
            // 
            // treeListBand1
            // 
            this.treeListBand1.Caption = "treeListBand1";
            this.treeListBand1.Name = "treeListBand1";
            // 
            // treeListBand2
            // 
            this.treeListBand2.Caption = "treeListBand2";
            this.treeListBand2.Name = "treeListBand2";
            // 
            // treeListBand3
            // 
            this.treeListBand3.Caption = "treeListBand3";
            this.treeListBand3.Name = "treeListBand3";
            // 
            // qualityTableAdapter
            // 
            this.qualityTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // dt_Quality_ProjProdAreaTableAdapter
            // 
            this.dt_Quality_ProjProdAreaTableAdapter.ClearBeforeFill = true;
            // 
            // dt_Quality_CompanyTableAdapter
            // 
            this.dt_Quality_CompanyTableAdapter.ClearBeforeFill = true;
            // 
            // dt_Quality_TipoDocTableAdapter
            // 
            this.dt_Quality_TipoDocTableAdapter.ClearBeforeFill = true;
            // 
            // dt_Quality_ClassificationTableAdapter
            // 
            this.dt_Quality_ClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // cntxt_CopyToClipboard
            // 
            this.cntxt_CopyToClipboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiaIlValoreNellaClipboardToolStripMenuItem});
            this.cntxt_CopyToClipboard.Name = "cntxt_CopyToClipboard";
            this.cntxt_CopyToClipboard.Size = new System.Drawing.Size(231, 26);
            // 
            // copiaIlValoreNellaClipboardToolStripMenuItem
            // 
            this.copiaIlValoreNellaClipboardToolStripMenuItem.Name = "copiaIlValoreNellaClipboardToolStripMenuItem";
            this.copiaIlValoreNellaClipboardToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.copiaIlValoreNellaClipboardToolStripMenuItem.Text = "Copia il valore nella clipboard";
            this.copiaIlValoreNellaClipboardToolStripMenuItem.Click += new System.EventHandler(this.copiaIlValoreNellaClipboardToolStripMenuItem_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // sF_QualityViewNewTableAdapter
            // 
            this.sF_QualityViewNewTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Quality_new_version
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 670);
            this.ControlBox = false;
            this.Controls.Add(this.panel_fattibilita);
            this.Controls.Add(this.layout_orizz_menu);
            this.DisplayHeader = false;
            this.Name = "UC_Quality_new_version";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UC_Quality_new_version_Load);
            this.layout_orizz_menu.ResumeLayout(false);
            this.layout_orizz_menu.PerformLayout();
            this.pan_Menu_salva.ResumeLayout(false);
            this.pan_Menu_salva.PerformLayout();
            this.pan_Menu_comandi.ResumeLayout(false);
            this.pan_Menu_comandi.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            this.panel_fattibilita.ResumeLayout(false);
            this.layout_Schede.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Quality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFQualityViewNewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Quality_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).EndInit();
            this.panel_Sigle.ResumeLayout(false);
            this.panel_Sigle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtQualityClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtQualityProjProdAreaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtQualityCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtQualityTipoDocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityBindingSource)).EndInit();
            this.cntxt_CopyToClipboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout_orizz_menu;
        private MetroFramework.Controls.MetroPanel panel_fattibilita;
        private System.Windows.Forms.DataGridViewTextBoxColumn articoloCompostoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articoloComponenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Explode_Mag;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualProg1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand1;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand2;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand3;
        private System.Windows.Forms.MenuStrip pan_Menu_salva;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_salva;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_div12;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_annulla;
        private System.Windows.Forms.MenuStrip pan_Menu_comandi;
        private System.Windows.Forms.ToolStripMenuItem menu_new;
        private System.Windows.Forms.ToolStripMenuItem menu_div01;
        private System.Windows.Forms.ToolStripMenuItem menu_edit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem creaRevisioneToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private System.Windows.Forms.TableLayoutPanel layout_Schede;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lab_MyIp;
        private MetroFramework.Controls.MetroLabel lab_projprodarea;
        private MetroFramework.Controls.MetroLabel lab_org;
        private MetroFramework.Controls.MetroLabel lab_type;
        private MetroFramework.Controls.MetroLabel lab_class;
        private System.Windows.Forms.ComboBox cb_User;
        private System.Windows.Forms.ComboBox cb_projprodarea;
        private System.Windows.Forms.ComboBox cb_org;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.ComboBox cb_class;
        private MetroFramework.Controls.MetroLabel label_codview;
        private MetroFramework.Controls.MetroLabel label_codedit;
        private MetroFramework.Controls.MetroLabel lab_des;
        private MetroFramework.Controls.MetroLabel lab_folder;
        private MetroFramework.Controls.MetroLabel lab_vers;
        private MetroFramework.Controls.MetroLabel lab_rev;
        private MetroFramework.Controls.MetroLabel lab_Codice_View;
        private MetroFramework.Controls.MetroLabel lab_Codice_Edit;
        private MetroFramework.Controls.MetroTextBox tb_Des;
        private MetroFramework.Controls.MetroTextBox tb_folder;
        private MetroFramework.Controls.MetroTextBox tb_vers;
        private MetroFramework.Controls.MetroTextBox tb_rev;
        private DevExpress.XtraGrid.GridControl gv_Quality;
        private DevExpress.XtraGrid.Views.Grid.GridView MainGridView;
        private ds_Quality_new ds_Quality_new;
        private System.Windows.Forms.BindingSource qualityBindingSource;
        private ds_Quality_newTableAdapters.QualityTableAdapter qualityTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private ds_Quality_newTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource tabQuality_Project_BindingSource;
        private System.Windows.Forms.BindingSource dtQualityProjProdAreaBindingSource;
        private ds_Quality_newTableAdapters.dt_Quality_ProjProdAreaTableAdapter dt_Quality_ProjProdAreaTableAdapter;
        private System.Windows.Forms.BindingSource dtQualityCompanyBindingSource;
        private ds_Quality_newTableAdapters.dt_Quality_CompanyTableAdapter dt_Quality_CompanyTableAdapter;
        private System.Windows.Forms.BindingSource dtQualityTipoDocBindingSource;
        private ds_Quality_newTableAdapters.dt_Quality_TipoDocTableAdapter dt_Quality_TipoDocTableAdapter;
        private System.Windows.Forms.BindingSource dtQualityClassificationBindingSource;
        private ds_Quality_newTableAdapters.dt_Quality_ClassificationTableAdapter dt_Quality_ClassificationTableAdapter;
        private MetroFramework.Controls.MetroContextMenu cntxt_CopyToClipboard;
        private System.Windows.Forms.ToolStripMenuItem copiaIlValoreNellaClipboardToolStripMenuItem;
        private System.Windows.Forms.BindingSource QualityBindingSource;
        private DevExpress.XtraEditors.SimpleButton but_view_obsolete;
        private DevExpress.XtraEditors.SimpleButton but_hide_obsolete;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource sFQualityViewNewBindingSource;
        private ds_Quality_newTableAdapters.SF_QualityViewNewTableAdapter sF_QualityViewNewTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDes_ProjProdArea;
        private DevExpress.XtraGrid.Columns.GridColumn colDes_Company;
        private DevExpress.XtraGrid.Columns.GridColumn colDes_TipoDoc;
        private DevExpress.XtraGrid.Columns.GridColumn colcodiceQual;
        private DevExpress.XtraGrid.Columns.GridColumn colQual_Des;
        private DevExpress.XtraGrid.Columns.GridColumn colQual_Rev_Obsolete;
        private MetroFramework.Controls.MetroTextBox tb_desClass;
        private System.Windows.Forms.TableLayoutPanel panel_Sigle;
    }
}