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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.qualityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Quality_new = new SmartLineProduction.ds_Quality_new();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQual_ProjProdArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQual_Org = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQual_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQual_Class = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQual_Prog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQual_Ver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQual_Rev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQual_Path = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQual_Richiedente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQual_DateRequest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQual_IPRequest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQual_Rev_Obsolete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodiceQual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQual_Des = new DevExpress.XtraGrid.Columns.GridColumn();
            this.treeListBand1 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListBand2 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListBand3 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.qualityTableAdapter = new SmartLineProduction.ds_Quality_newTableAdapters.QualityTableAdapter();
            this.layout_orizz_menu.SuspendLayout();
            this.pan_Menu_salva.SuspendLayout();
            this.pan_Menu_comandi.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            this.panel_fattibilita.SuspendLayout();
            this.layout_Schede.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Quality_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.layout_orizz_menu.Size = new System.Drawing.Size(960, 25);
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
            this.pan_Menu_salva.Location = new System.Drawing.Point(588, 0);
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
            this.pan_Menu_comandi.Size = new System.Drawing.Size(480, 25);
            this.pan_Menu_comandi.TabIndex = 85;
            this.pan_Menu_comandi.Text = "menuStrip1";
            // 
            // menu_new
            // 
            this.menu_new.Image = ((System.Drawing.Image)(resources.GetObject("menu_new.Image")));
            this.menu_new.Name = "menu_new";
            this.menu_new.Size = new System.Drawing.Size(111, 21);
            this.menu_new.Text = "Nuovo Codice";
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
            // 
            // pan_Menu_exit
            // 
            this.pan_Menu_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_Menu_exit.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_Menu_exit.Dock = System.Windows.Forms.DockStyle.None;
            this.pan_Menu_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sw_exit});
            this.pan_Menu_exit.Location = new System.Drawing.Point(885, 0);
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
            this.panel_fattibilita.Size = new System.Drawing.Size(960, 425);
            this.panel_fattibilita.TabIndex = 126;
            this.panel_fattibilita.VerticalScrollbarBarColor = true;
            this.panel_fattibilita.VerticalScrollbarHighlightOnWheel = false;
            this.panel_fattibilita.VerticalScrollbarSize = 10;
            // 
            // layout_Schede
            // 
            this.layout_Schede.ColumnCount = 5;
            this.layout_Schede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout_Schede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout_Schede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout_Schede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout_Schede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout_Schede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout_Schede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout_Schede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout_Schede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout_Schede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout_Schede.Controls.Add(this.gridControl1, 0, 0);
            this.layout_Schede.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Schede.Location = new System.Drawing.Point(0, 0);
            this.layout_Schede.Name = "layout_Schede";
            this.layout_Schede.RowCount = 10;
            this.layout_Schede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_Schede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_Schede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_Schede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_Schede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_Schede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_Schede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_Schede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_Schede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_Schede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_Schede.Size = new System.Drawing.Size(960, 425);
            this.layout_Schede.TabIndex = 123;
            // 
            // gridControl1
            // 
            this.layout_Schede.SetColumnSpan(this.gridControl1, 3);
            this.gridControl1.DataSource = this.qualityBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.layout_Schede.SetRowSpan(this.gridControl1, 5);
            this.gridControl1.Size = new System.Drawing.Size(570, 204);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // qualityBindingSource
            // 
            this.qualityBindingSource.DataMember = "Quality";
            this.qualityBindingSource.DataSource = this.ds_Quality_new;
            this.qualityBindingSource.Sort = "Qual_ProjProdArea asc, Qual_Org asc, Qual_Type asc, Qual_Class asc, Qual_Prog asc" +
    ", Qual_Ver asc, Qual_Rev asc";
            // 
            // ds_Quality_new
            // 
            this.ds_Quality_new.DataSetName = "ds_Quality_new";
            this.ds_Quality_new.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colQual_ProjProdArea,
            this.colQual_Org,
            this.colQual_Type,
            this.colQual_Class,
            this.colQual_Prog,
            this.colQual_Ver,
            this.colQual_Rev,
            this.colQual_Path,
            this.colQual_Richiedente,
            this.colQual_DateRequest,
            this.colQual_IPRequest,
            this.colQual_Rev_Obsolete,
            this.colcodiceQual,
            this.colQual_Des});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colQual_ProjProdArea, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colQual_ProjProdArea
            // 
            this.colQual_ProjProdArea.Caption = "Project";
            this.colQual_ProjProdArea.FieldName = "Qual_ProjProdArea";
            this.colQual_ProjProdArea.Name = "colQual_ProjProdArea";
            this.colQual_ProjProdArea.Visible = true;
            this.colQual_ProjProdArea.VisibleIndex = 1;
            // 
            // colQual_Org
            // 
            this.colQual_Org.FieldName = "Qual_Org";
            this.colQual_Org.Name = "colQual_Org";
            // 
            // colQual_Type
            // 
            this.colQual_Type.FieldName = "Qual_Type";
            this.colQual_Type.Name = "colQual_Type";
            // 
            // colQual_Class
            // 
            this.colQual_Class.FieldName = "Qual_Class";
            this.colQual_Class.Name = "colQual_Class";
            // 
            // colQual_Prog
            // 
            this.colQual_Prog.FieldName = "Qual_Prog";
            this.colQual_Prog.Name = "colQual_Prog";
            // 
            // colQual_Ver
            // 
            this.colQual_Ver.FieldName = "Qual_Ver";
            this.colQual_Ver.Name = "colQual_Ver";
            // 
            // colQual_Rev
            // 
            this.colQual_Rev.FieldName = "Qual_Rev";
            this.colQual_Rev.Name = "colQual_Rev";
            // 
            // colQual_Path
            // 
            this.colQual_Path.FieldName = "Qual_Path";
            this.colQual_Path.Name = "colQual_Path";
            // 
            // colQual_Richiedente
            // 
            this.colQual_Richiedente.FieldName = "Qual_Richiedente";
            this.colQual_Richiedente.Name = "colQual_Richiedente";
            // 
            // colQual_DateRequest
            // 
            this.colQual_DateRequest.FieldName = "Qual_DateRequest";
            this.colQual_DateRequest.Name = "colQual_DateRequest";
            // 
            // colQual_IPRequest
            // 
            this.colQual_IPRequest.FieldName = "Qual_IPRequest";
            this.colQual_IPRequest.Name = "colQual_IPRequest";
            // 
            // colQual_Rev_Obsolete
            // 
            this.colQual_Rev_Obsolete.FieldName = "Qual_Rev_Obsolete";
            this.colQual_Rev_Obsolete.Name = "colQual_Rev_Obsolete";
            // 
            // colcodiceQual
            // 
            this.colcodiceQual.Caption = "Codice Qualità";
            this.colcodiceQual.FieldName = "codiceQual";
            this.colcodiceQual.Name = "colcodiceQual";
            this.colcodiceQual.Visible = true;
            this.colcodiceQual.VisibleIndex = 0;
            this.colcodiceQual.Width = 150;
            // 
            // colQual_Des
            // 
            this.colQual_Des.Caption = "Descrizione";
            this.colQual_Des.FieldName = "Qual_Des";
            this.colQual_Des.Name = "colQual_Des";
            this.colQual_Des.Visible = true;
            this.colQual_Des.VisibleIndex = 1;
            this.colQual_Des.Width = 395;
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
            // UC_Quality_new_version
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Quality_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private ds_Quality_new ds_Quality_new;
        private System.Windows.Forms.BindingSource qualityBindingSource;
        private ds_Quality_newTableAdapters.QualityTableAdapter qualityTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colQual_ProjProdArea;
        private DevExpress.XtraGrid.Columns.GridColumn colQual_Org;
        private DevExpress.XtraGrid.Columns.GridColumn colQual_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colQual_Class;
        private DevExpress.XtraGrid.Columns.GridColumn colQual_Prog;
        private DevExpress.XtraGrid.Columns.GridColumn colQual_Ver;
        private DevExpress.XtraGrid.Columns.GridColumn colQual_Rev;
        private DevExpress.XtraGrid.Columns.GridColumn colQual_Path;
        private DevExpress.XtraGrid.Columns.GridColumn colQual_Richiedente;
        private DevExpress.XtraGrid.Columns.GridColumn colQual_DateRequest;
        private DevExpress.XtraGrid.Columns.GridColumn colQual_IPRequest;
        private DevExpress.XtraGrid.Columns.GridColumn colQual_Rev_Obsolete;
        private DevExpress.XtraGrid.Columns.GridColumn colcodiceQual;
        private DevExpress.XtraGrid.Columns.GridColumn colQual_Des;
    }
}