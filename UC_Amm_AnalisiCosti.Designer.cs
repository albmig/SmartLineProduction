namespace SmartLineProduction
{
    partial class UC_Amm_AnalisiCosti
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Amm_AnalisiCosti));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ds_SL = new SmartLineProduction.ds_SL();
            this.layout_orizz_menu = new System.Windows.Forms.TableLayoutPanel();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gv_Venduto = new MetroFramework.Controls.MetroGrid();
            this.gv_Venduto_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Venduto_Articolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Venduto_QtaTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Venduto_Prezzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Venduto_TotRicavi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Venduto_TotCosti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Venduto_CostoMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Venduto_CostoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Venduto_CostoMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Venduto_CostoLav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totFatturatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Venduto_Margine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analisiCostiVendutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tree_Distinta = new DevExpress.XtraTreeList.TreeList();
            this.colArticoloComposto = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colArticoloComponente = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btn_visVenduto = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colQuantita1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCosto_Materia_Prima1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCosto_Uomo1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCosto_Lav_Est1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colArticoloIniziale1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCalc_Costo_Tot_Unitario = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCalc_Costo_Tot_Totale = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.analisiCostiVendutoSFExplDistintaSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analisiCostiDistinteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colQuantita = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFlEsplodiSemilav = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCosto_Materia_Prima = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCosto_Uomo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCosto_Lav_Est = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCosto_Unit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCosto_Tot = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTipoProduzione = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLvl_DB = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNum_Art = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNum_Exp = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colArticoloIniziale = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colElaborato = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListBand1 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.analisi_Costi_VendutoTableAdapter = new SmartLineProduction.ds_SLTableAdapters.Analisi_Costi_VendutoTableAdapter();
            this.layout_filter = new System.Windows.Forms.TableLayoutPanel();
            this.btn_AzzeraFiltroArticoli = new MetroFramework.Controls.MetroButton();
            this.cb_elencoarticoli = new System.Windows.Forms.ComboBox();
            this.aCVClienteArticoloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cb_elencoClienti = new System.Windows.Forms.ComboBox();
            this.aCVClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_Totali = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_tot_costi = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lab_tot_diff = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lab_tot_uomo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lab_tot_mp = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lab_tot_lav = new MetroFramework.Controls.MetroLabel();
            this.lab_tot_ricavi = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btn_AzzeraFiltroClienti = new MetroFramework.Controls.MetroButton();
            this.aCV_Cliente = new SmartLineProduction.ds_SLTableAdapters.ACV_Cliente();
            this.aCV_ClienteArticolo = new SmartLineProduction.ds_SLTableAdapters.ACV_ClienteArticolo();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qta_Tot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo_Materiali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo_Manodopera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo_Lav_Est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo_Produzione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Margine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sF_Expl_Distinta_SaleTableAdapter = new SmartLineProduction.ds_SLTableAdapters.SF_Expl_Distinta_SaleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).BeginInit();
            this.layout_orizz_menu.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Venduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisiCostiVendutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_Distinta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_visVenduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisiCostiVendutoSFExplDistintaSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisiCostiDistinteBindingSource)).BeginInit();
            this.toolStripContainer1.SuspendLayout();
            this.layout_filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCVClienteArticoloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCVClienteBindingSource)).BeginInit();
            this.panel_Totali.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ds_SL
            // 
            this.ds_SL.DataSetName = "ds_SL";
            this.ds_SL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.layout_orizz_menu.Controls.Add(this.pan_Menu_exit, 10, 0);
            this.layout_orizz_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.layout_orizz_menu.Location = new System.Drawing.Point(20, 30);
            this.layout_orizz_menu.Name = "layout_orizz_menu";
            this.layout_orizz_menu.RowCount = 1;
            this.layout_orizz_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_orizz_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layout_orizz_menu.Size = new System.Drawing.Size(839, 25);
            this.layout_orizz_menu.TabIndex = 120;
            // 
            // pan_Menu_exit
            // 
            this.pan_Menu_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_Menu_exit.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_Menu_exit.Dock = System.Windows.Forms.DockStyle.None;
            this.pan_Menu_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sw_exit});
            this.pan_Menu_exit.Location = new System.Drawing.Point(764, 0);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gv_Venduto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tree_Distinta, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 155);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 613);
            this.tableLayoutPanel1.TabIndex = 121;
            // 
            // gv_Venduto
            // 
            this.gv_Venduto.AllowUserToAddRows = false;
            this.gv_Venduto.AllowUserToDeleteRows = false;
            this.gv_Venduto.AllowUserToResizeRows = false;
            this.gv_Venduto.AutoGenerateColumns = false;
            this.gv_Venduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Venduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Venduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Venduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Venduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Venduto.ColumnHeadersHeight = 40;
            this.gv_Venduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gv_Venduto_Cliente,
            this.gv_Venduto_Articolo,
            this.gv_Venduto_QtaTot,
            this.gv_Venduto_Prezzo,
            this.gv_Venduto_TotRicavi,
            this.gv_Venduto_TotCosti,
            this.gv_Venduto_CostoMat,
            this.gv_Venduto_CostoProd,
            this.gv_Venduto_CostoMan,
            this.gv_Venduto_CostoLav,
            this.margineDataGridViewTextBoxColumn,
            this.totFatturatoDataGridViewTextBoxColumn,
            this.gv_Venduto_Margine});
            this.gv_Venduto.DataSource = this.analisiCostiVendutoBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Venduto.DefaultCellStyle = dataGridViewCellStyle11;
            this.gv_Venduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Venduto.EnableHeadersVisualStyles = false;
            this.gv_Venduto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Venduto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Venduto.Location = new System.Drawing.Point(3, 3);
            this.gv_Venduto.MultiSelect = false;
            this.gv_Venduto.Name = "gv_Venduto";
            this.gv_Venduto.ReadOnly = true;
            this.gv_Venduto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Venduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gv_Venduto.RowHeadersVisible = false;
            this.gv_Venduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Venduto.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Wheat;
            this.gv_Venduto.RowTemplate.Height = 30;
            this.gv_Venduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Venduto.Size = new System.Drawing.Size(833, 239);
            this.gv_Venduto.Style = MetroFramework.MetroColorStyle.Red;
            this.gv_Venduto.TabIndex = 2;
            this.gv_Venduto.UseStyleColors = true;
            this.gv_Venduto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gv_Venduto_CellFormatting);
            this.gv_Venduto.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gv_Venduto_DataBindingComplete);
            this.gv_Venduto.SelectionChanged += new System.EventHandler(this.gv_Venduto_SelectionChanged);
            this.gv_Venduto.Enter += new System.EventHandler(this.gv_Venduto_Enter);
            // 
            // gv_Venduto_Cliente
            // 
            this.gv_Venduto_Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gv_Venduto_Cliente.DataPropertyName = "Cliente";
            this.gv_Venduto_Cliente.HeaderText = "Cliente";
            this.gv_Venduto_Cliente.Name = "gv_Venduto_Cliente";
            this.gv_Venduto_Cliente.ReadOnly = true;
            // 
            // gv_Venduto_Articolo
            // 
            this.gv_Venduto_Articolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gv_Venduto_Articolo.DataPropertyName = "Articolo";
            this.gv_Venduto_Articolo.HeaderText = "Articolo";
            this.gv_Venduto_Articolo.Name = "gv_Venduto_Articolo";
            this.gv_Venduto_Articolo.ReadOnly = true;
            this.gv_Venduto_Articolo.Width = 70;
            // 
            // gv_Venduto_QtaTot
            // 
            this.gv_Venduto_QtaTot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gv_Venduto_QtaTot.DataPropertyName = "Qta_Tot";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.gv_Venduto_QtaTot.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Venduto_QtaTot.HeaderText = "Q.tà Venduto";
            this.gv_Venduto_QtaTot.Name = "gv_Venduto_QtaTot";
            this.gv_Venduto_QtaTot.ReadOnly = true;
            this.gv_Venduto_QtaTot.Width = 90;
            // 
            // gv_Venduto_Prezzo
            // 
            this.gv_Venduto_Prezzo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gv_Venduto_Prezzo.DataPropertyName = "Prezzo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.gv_Venduto_Prezzo.DefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Venduto_Prezzo.HeaderText = "Prezzo Vendita";
            this.gv_Venduto_Prezzo.Name = "gv_Venduto_Prezzo";
            this.gv_Venduto_Prezzo.ReadOnly = true;
            this.gv_Venduto_Prezzo.Width = 96;
            // 
            // gv_Venduto_TotRicavi
            // 
            this.gv_Venduto_TotRicavi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gv_Venduto_TotRicavi.DataPropertyName = "Tot_Ricavi";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.gv_Venduto_TotRicavi.DefaultCellStyle = dataGridViewCellStyle4;
            this.gv_Venduto_TotRicavi.HeaderText = "Totale Ricavo";
            this.gv_Venduto_TotRicavi.Name = "gv_Venduto_TotRicavi";
            this.gv_Venduto_TotRicavi.ReadOnly = true;
            this.gv_Venduto_TotRicavi.Width = 89;
            // 
            // gv_Venduto_TotCosti
            // 
            this.gv_Venduto_TotCosti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gv_Venduto_TotCosti.DataPropertyName = "Tot_Costi";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.gv_Venduto_TotCosti.DefaultCellStyle = dataGridViewCellStyle5;
            this.gv_Venduto_TotCosti.HeaderText = "Totale Costo";
            this.gv_Venduto_TotCosti.Name = "gv_Venduto_TotCosti";
            this.gv_Venduto_TotCosti.ReadOnly = true;
            this.gv_Venduto_TotCosti.Width = 86;
            // 
            // gv_Venduto_CostoMat
            // 
            this.gv_Venduto_CostoMat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gv_Venduto_CostoMat.DataPropertyName = "Costo_Materiali";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.gv_Venduto_CostoMat.DefaultCellStyle = dataGridViewCellStyle6;
            this.gv_Venduto_CostoMat.HeaderText = "Costo dei materiali";
            this.gv_Venduto_CostoMat.Name = "gv_Venduto_CostoMat";
            this.gv_Venduto_CostoMat.ReadOnly = true;
            this.gv_Venduto_CostoMat.Width = 115;
            // 
            // gv_Venduto_CostoProd
            // 
            this.gv_Venduto_CostoProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gv_Venduto_CostoProd.DataPropertyName = "Costo_Produzione";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.gv_Venduto_CostoProd.DefaultCellStyle = dataGridViewCellStyle7;
            this.gv_Venduto_CostoProd.HeaderText = "Costo di produzione";
            this.gv_Venduto_CostoProd.Name = "gv_Venduto_CostoProd";
            this.gv_Venduto_CostoProd.ReadOnly = true;
            this.gv_Venduto_CostoProd.Visible = false;
            this.gv_Venduto_CostoProd.Width = 124;
            // 
            // gv_Venduto_CostoMan
            // 
            this.gv_Venduto_CostoMan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gv_Venduto_CostoMan.DataPropertyName = "Costo_Manodopera";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.gv_Venduto_CostoMan.DefaultCellStyle = dataGridViewCellStyle8;
            this.gv_Venduto_CostoMan.HeaderText = "Costo della manodopera";
            this.gv_Venduto_CostoMan.Name = "gv_Venduto_CostoMan";
            this.gv_Venduto_CostoMan.ReadOnly = true;
            this.gv_Venduto_CostoMan.Width = 143;
            // 
            // gv_Venduto_CostoLav
            // 
            this.gv_Venduto_CostoLav.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gv_Venduto_CostoLav.DataPropertyName = "Costo_Lav_Est";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.gv_Venduto_CostoLav.DefaultCellStyle = dataGridViewCellStyle9;
            this.gv_Venduto_CostoLav.HeaderText = "Costo Lav. Esterne";
            this.gv_Venduto_CostoLav.Name = "gv_Venduto_CostoLav";
            this.gv_Venduto_CostoLav.ReadOnly = true;
            this.gv_Venduto_CostoLav.Width = 112;
            // 
            // margineDataGridViewTextBoxColumn
            // 
            this.margineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.margineDataGridViewTextBoxColumn.DataPropertyName = "Margine";
            this.margineDataGridViewTextBoxColumn.HeaderText = "Margine";
            this.margineDataGridViewTextBoxColumn.Name = "margineDataGridViewTextBoxColumn";
            this.margineDataGridViewTextBoxColumn.ReadOnly = true;
            this.margineDataGridViewTextBoxColumn.Visible = false;
            this.margineDataGridViewTextBoxColumn.Width = 73;
            // 
            // totFatturatoDataGridViewTextBoxColumn
            // 
            this.totFatturatoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.totFatturatoDataGridViewTextBoxColumn.DataPropertyName = "Tot_Fatturato";
            this.totFatturatoDataGridViewTextBoxColumn.HeaderText = "Tot_Fatturato";
            this.totFatturatoDataGridViewTextBoxColumn.Name = "totFatturatoDataGridViewTextBoxColumn";
            this.totFatturatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.totFatturatoDataGridViewTextBoxColumn.Visible = false;
            this.totFatturatoDataGridViewTextBoxColumn.Width = 99;
            // 
            // gv_Venduto_Margine
            // 
            this.gv_Venduto_Margine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gv_Venduto_Margine.DataPropertyName = "Margine_Perc";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "P";
            dataGridViewCellStyle10.NullValue = null;
            this.gv_Venduto_Margine.DefaultCellStyle = dataGridViewCellStyle10;
            this.gv_Venduto_Margine.HeaderText = "Margine";
            this.gv_Venduto_Margine.Name = "gv_Venduto_Margine";
            this.gv_Venduto_Margine.ReadOnly = true;
            this.gv_Venduto_Margine.Width = 73;
            // 
            // analisiCostiVendutoBindingSource
            // 
            this.analisiCostiVendutoBindingSource.DataMember = "Analisi_Costi_Venduto";
            this.analisiCostiVendutoBindingSource.DataSource = this.ds_SL;
            this.analisiCostiVendutoBindingSource.Sort = "Cliente asc, Articolo asc";
            this.analisiCostiVendutoBindingSource.CurrentChanged += new System.EventHandler(this.analisiCostiVendutoBindingSource_CurrentChanged);
            // 
            // tree_Distinta
            // 
            this.tree_Distinta.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colArticoloComposto,
            this.colArticoloComponente,
            this.colQuantita1,
            this.colCosto_Materia_Prima1,
            this.colCosto_Uomo1,
            this.colCosto_Lav_Est1,
            this.colArticoloIniziale1,
            this.colCalc_Costo_Tot_Unitario,
            this.colCalc_Costo_Tot_Totale});
            this.tree_Distinta.DataSource = this.analisiCostiVendutoSFExplDistintaSaleBindingSource;
            this.tree_Distinta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_Distinta.KeyFieldName = "id_figlio";
            this.tree_Distinta.Location = new System.Drawing.Point(3, 248);
            this.tree_Distinta.Name = "tree_Distinta";
            this.tree_Distinta.ParentFieldName = "id_padre";
            this.tree_Distinta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_visVenduto});
            this.tree_Distinta.RootValue = "--LABEL--";
            this.tree_Distinta.Size = new System.Drawing.Size(833, 362);
            this.tree_Distinta.TabIndex = 3;
            this.tree_Distinta.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tree_Distinta_FocusedNodeChanged);
            // 
            // colArticoloComposto
            // 
            this.colArticoloComposto.FieldName = "ArticoloComposto";
            this.colArticoloComposto.Name = "colArticoloComposto";
            // 
            // colArticoloComponente
            // 
            this.colArticoloComponente.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colArticoloComponente.AppearanceHeader.Options.UseFont = true;
            this.colArticoloComponente.Caption = "Articolo";
            this.colArticoloComponente.ColumnEdit = this.btn_visVenduto;
            this.colArticoloComponente.FieldName = "ArticoloComponente";
            this.colArticoloComponente.Name = "colArticoloComponente";
            this.colArticoloComponente.Visible = true;
            this.colArticoloComponente.VisibleIndex = 0;
            // 
            // btn_visVenduto
            // 
            this.btn_visVenduto.AutoHeight = false;
            this.btn_visVenduto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.btn_visVenduto.Name = "btn_visVenduto";
            this.btn_visVenduto.Click += new System.EventHandler(this.btn_visVenduto_Click);
            // 
            // colQuantita1
            // 
            this.colQuantita1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colQuantita1.AppearanceHeader.Options.UseFont = true;
            this.colQuantita1.Caption = "Quantità";
            this.colQuantita1.FieldName = "Quantita";
            this.colQuantita1.Format.FormatString = "{0:N2}";
            this.colQuantita1.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantita1.Name = "colQuantita1";
            this.colQuantita1.Visible = true;
            this.colQuantita1.VisibleIndex = 1;
            // 
            // colCosto_Materia_Prima1
            // 
            this.colCosto_Materia_Prima1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colCosto_Materia_Prima1.AppearanceHeader.Options.UseFont = true;
            this.colCosto_Materia_Prima1.Caption = "Costo della mat. prima";
            this.colCosto_Materia_Prima1.FieldName = "Costo_Materia_Prima";
            this.colCosto_Materia_Prima1.Format.FormatString = "{0:c2}";
            this.colCosto_Materia_Prima1.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCosto_Materia_Prima1.Name = "colCosto_Materia_Prima1";
            this.colCosto_Materia_Prima1.Visible = true;
            this.colCosto_Materia_Prima1.VisibleIndex = 2;
            // 
            // colCosto_Uomo1
            // 
            this.colCosto_Uomo1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colCosto_Uomo1.AppearanceHeader.Options.UseFont = true;
            this.colCosto_Uomo1.Caption = "Costo della manodopera";
            this.colCosto_Uomo1.FieldName = "Costo_Uomo";
            this.colCosto_Uomo1.Format.FormatString = "{0:c2}";
            this.colCosto_Uomo1.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCosto_Uomo1.Name = "colCosto_Uomo1";
            this.colCosto_Uomo1.Visible = true;
            this.colCosto_Uomo1.VisibleIndex = 3;
            // 
            // colCosto_Lav_Est1
            // 
            this.colCosto_Lav_Est1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colCosto_Lav_Est1.AppearanceHeader.Options.UseFont = true;
            this.colCosto_Lav_Est1.Caption = "Costo delle lav. esterne";
            this.colCosto_Lav_Est1.FieldName = "Costo_Lav_Est";
            this.colCosto_Lav_Est1.Format.FormatString = "{0:c2}";
            this.colCosto_Lav_Est1.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCosto_Lav_Est1.Name = "colCosto_Lav_Est1";
            this.colCosto_Lav_Est1.Visible = true;
            this.colCosto_Lav_Est1.VisibleIndex = 4;
            // 
            // colArticoloIniziale1
            // 
            this.colArticoloIniziale1.FieldName = "ArticoloIniziale";
            this.colArticoloIniziale1.Name = "colArticoloIniziale1";
            // 
            // colCalc_Costo_Tot_Unitario
            // 
            this.colCalc_Costo_Tot_Unitario.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colCalc_Costo_Tot_Unitario.AppearanceHeader.Options.UseFont = true;
            this.colCalc_Costo_Tot_Unitario.Caption = "Costo Totale - Unitario";
            this.colCalc_Costo_Tot_Unitario.FieldName = "Calc_Costo_Tot_Unitario";
            this.colCalc_Costo_Tot_Unitario.Format.FormatString = "{0:c2}";
            this.colCalc_Costo_Tot_Unitario.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCalc_Costo_Tot_Unitario.Name = "colCalc_Costo_Tot_Unitario";
            this.colCalc_Costo_Tot_Unitario.Visible = true;
            this.colCalc_Costo_Tot_Unitario.VisibleIndex = 5;
            // 
            // colCalc_Costo_Tot_Totale
            // 
            this.colCalc_Costo_Tot_Totale.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colCalc_Costo_Tot_Totale.AppearanceCell.Options.UseBackColor = true;
            this.colCalc_Costo_Tot_Totale.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colCalc_Costo_Tot_Totale.AppearanceHeader.Options.UseFont = true;
            this.colCalc_Costo_Tot_Totale.Caption = "Costo Totale - Complessivo";
            this.colCalc_Costo_Tot_Totale.FieldName = "Calc_Costo_Tot_Totale";
            this.colCalc_Costo_Tot_Totale.Format.FormatString = "{0:c2}";
            this.colCalc_Costo_Tot_Totale.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCalc_Costo_Tot_Totale.Name = "colCalc_Costo_Tot_Totale";
            this.colCalc_Costo_Tot_Totale.Visible = true;
            this.colCalc_Costo_Tot_Totale.VisibleIndex = 6;
            // 
            // analisiCostiVendutoSFExplDistintaSaleBindingSource
            // 
            this.analisiCostiVendutoSFExplDistintaSaleBindingSource.DataMember = "Analisi_Costi_Venduto_SF_Expl_Distinta_Sale";
            this.analisiCostiVendutoSFExplDistintaSaleBindingSource.DataSource = this.analisiCostiVendutoBindingSource;
            // 
            // colQuantita
            // 
            this.colQuantita.FieldName = "Quantita";
            this.colQuantita.Name = "colQuantita";
            this.colQuantita.Visible = true;
            this.colQuantita.VisibleIndex = 0;
            // 
            // colFlEsplodiSemilav
            // 
            this.colFlEsplodiSemilav.FieldName = "FlEsplodiSemilav";
            this.colFlEsplodiSemilav.Name = "colFlEsplodiSemilav";
            this.colFlEsplodiSemilav.Visible = true;
            this.colFlEsplodiSemilav.VisibleIndex = 1;
            // 
            // colCosto_Materia_Prima
            // 
            this.colCosto_Materia_Prima.FieldName = "Costo_Materia_Prima";
            this.colCosto_Materia_Prima.Name = "colCosto_Materia_Prima";
            this.colCosto_Materia_Prima.Visible = true;
            this.colCosto_Materia_Prima.VisibleIndex = 2;
            // 
            // colCosto_Uomo
            // 
            this.colCosto_Uomo.FieldName = "Costo_Uomo";
            this.colCosto_Uomo.Name = "colCosto_Uomo";
            this.colCosto_Uomo.Visible = true;
            this.colCosto_Uomo.VisibleIndex = 3;
            // 
            // colCosto_Lav_Est
            // 
            this.colCosto_Lav_Est.FieldName = "Costo_Lav_Est";
            this.colCosto_Lav_Est.Name = "colCosto_Lav_Est";
            this.colCosto_Lav_Est.Visible = true;
            this.colCosto_Lav_Est.VisibleIndex = 4;
            // 
            // colCosto_Unit
            // 
            this.colCosto_Unit.FieldName = "Costo_Unit";
            this.colCosto_Unit.Name = "colCosto_Unit";
            this.colCosto_Unit.Visible = true;
            this.colCosto_Unit.VisibleIndex = 5;
            // 
            // colCosto_Tot
            // 
            this.colCosto_Tot.FieldName = "Costo_Tot";
            this.colCosto_Tot.Name = "colCosto_Tot";
            this.colCosto_Tot.Visible = true;
            this.colCosto_Tot.VisibleIndex = 6;
            // 
            // colTipoProduzione
            // 
            this.colTipoProduzione.FieldName = "TipoProduzione";
            this.colTipoProduzione.Name = "colTipoProduzione";
            this.colTipoProduzione.Visible = true;
            this.colTipoProduzione.VisibleIndex = 7;
            // 
            // colLvl_DB
            // 
            this.colLvl_DB.FieldName = "Lvl_DB";
            this.colLvl_DB.Name = "colLvl_DB";
            this.colLvl_DB.Visible = true;
            this.colLvl_DB.VisibleIndex = 8;
            // 
            // colNum_Art
            // 
            this.colNum_Art.FieldName = "Num_Art";
            this.colNum_Art.Name = "colNum_Art";
            this.colNum_Art.Visible = true;
            this.colNum_Art.VisibleIndex = 9;
            // 
            // colNum_Exp
            // 
            this.colNum_Exp.FieldName = "Num_Exp";
            this.colNum_Exp.Name = "colNum_Exp";
            this.colNum_Exp.Visible = true;
            this.colNum_Exp.VisibleIndex = 10;
            // 
            // colArticoloIniziale
            // 
            this.colArticoloIniziale.FieldName = "ArticoloIniziale";
            this.colArticoloIniziale.Name = "colArticoloIniziale";
            this.colArticoloIniziale.Visible = true;
            this.colArticoloIniziale.VisibleIndex = 11;
            // 
            // colElaborato
            // 
            this.colElaborato.FieldName = "Elaborato";
            this.colElaborato.Name = "colElaborato";
            this.colElaborato.Visible = true;
            this.colElaborato.VisibleIndex = 12;
            // 
            // treeListBand1
            // 
            this.treeListBand1.Caption = "treeListBand1";
            this.treeListBand1.Name = "treeListBand1";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 0;
            // 
            // analisi_Costi_VendutoTableAdapter
            // 
            this.analisi_Costi_VendutoTableAdapter.ClearBeforeFill = true;
            // 
            // layout_filter
            // 
            this.layout_filter.ColumnCount = 10;
            this.layout_filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_filter.Controls.Add(this.btn_AzzeraFiltroArticoli, 2, 3);
            this.layout_filter.Controls.Add(this.cb_elencoarticoli, 2, 2);
            this.layout_filter.Controls.Add(this.metroLabel3, 2, 1);
            this.layout_filter.Controls.Add(this.metroLabel1, 0, 1);
            this.layout_filter.Controls.Add(this.cb_elencoClienti, 0, 2);
            this.layout_filter.Controls.Add(this.panel_Totali, 4, 0);
            this.layout_filter.Controls.Add(this.btn_AzzeraFiltroClienti, 0, 3);
            this.layout_filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.layout_filter.Location = new System.Drawing.Point(20, 55);
            this.layout_filter.Name = "layout_filter";
            this.layout_filter.RowCount = 4;
            this.layout_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layout_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layout_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layout_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layout_filter.Size = new System.Drawing.Size(839, 100);
            this.layout_filter.TabIndex = 128;
            // 
            // btn_AzzeraFiltroArticoli
            // 
            this.btn_AzzeraFiltroArticoli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layout_filter.SetColumnSpan(this.btn_AzzeraFiltroArticoli, 2);
            this.btn_AzzeraFiltroArticoli.Location = new System.Drawing.Point(214, 78);
            this.btn_AzzeraFiltroArticoli.Name = "btn_AzzeraFiltroArticoli";
            this.btn_AzzeraFiltroArticoli.Size = new System.Drawing.Size(70, 19);
            this.btn_AzzeraFiltroArticoli.TabIndex = 42;
            this.btn_AzzeraFiltroArticoli.Text = "Tutti";
            this.btn_AzzeraFiltroArticoli.UseSelectable = true;
            this.btn_AzzeraFiltroArticoli.Click += new System.EventHandler(this.btn_AzzeraFiltroArticoli_Click);
            // 
            // cb_elencoarticoli
            // 
            this.layout_filter.SetColumnSpan(this.cb_elencoarticoli, 2);
            this.cb_elencoarticoli.DataSource = this.aCVClienteArticoloBindingSource;
            this.cb_elencoarticoli.DisplayMember = "Articolo";
            this.cb_elencoarticoli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_elencoarticoli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_elencoarticoli.FormattingEnabled = true;
            this.cb_elencoarticoli.Location = new System.Drawing.Point(169, 53);
            this.cb_elencoarticoli.Name = "cb_elencoarticoli";
            this.cb_elencoarticoli.Size = new System.Drawing.Size(160, 23);
            this.cb_elencoarticoli.TabIndex = 32;
            this.cb_elencoarticoli.SelectedIndexChanged += new System.EventHandler(this.cb_elencoarticoli_SelectedIndexChanged);
            // 
            // aCVClienteArticoloBindingSource
            // 
            this.aCVClienteArticoloBindingSource.DataMember = "ACV_ClienteArticolo";
            this.aCVClienteArticoloBindingSource.DataSource = this.ds_SL;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.layout_filter.SetColumnSpan(this.metroLabel3, 2);
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(169, 28);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(160, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Articolo";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.layout_filter.SetColumnSpan(this.metroLabel1, 2);
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(160, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "Cliente";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseStyleColors = true;
            // 
            // cb_elencoClienti
            // 
            this.layout_filter.SetColumnSpan(this.cb_elencoClienti, 2);
            this.cb_elencoClienti.DataSource = this.aCVClienteBindingSource;
            this.cb_elencoClienti.DisplayMember = "Cliente";
            this.cb_elencoClienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_elencoClienti.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_elencoClienti.FormattingEnabled = true;
            this.cb_elencoClienti.Location = new System.Drawing.Point(3, 53);
            this.cb_elencoClienti.Name = "cb_elencoClienti";
            this.cb_elencoClienti.Size = new System.Drawing.Size(160, 23);
            this.cb_elencoClienti.TabIndex = 27;
            this.cb_elencoClienti.SelectedIndexChanged += new System.EventHandler(this.cb_elencoClienti_SelectedIndexChanged);
            // 
            // aCVClienteBindingSource
            // 
            this.aCVClienteBindingSource.DataMember = "ACV_Cliente";
            this.aCVClienteBindingSource.DataSource = this.ds_SL;
            // 
            // panel_Totali
            // 
            this.layout_filter.SetColumnSpan(this.panel_Totali, 6);
            this.panel_Totali.Controls.Add(this.tableLayoutPanel2);
            this.panel_Totali.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Totali.HorizontalScrollbarBarColor = true;
            this.panel_Totali.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_Totali.HorizontalScrollbarSize = 10;
            this.panel_Totali.Location = new System.Drawing.Point(335, 3);
            this.panel_Totali.Name = "panel_Totali";
            this.layout_filter.SetRowSpan(this.panel_Totali, 3);
            this.panel_Totali.Size = new System.Drawing.Size(501, 69);
            this.panel_Totali.TabIndex = 40;
            this.panel_Totali.VerticalScrollbarBarColor = true;
            this.panel_Totali.VerticalScrollbarHighlightOnWheel = false;
            this.panel_Totali.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lab_tot_costi, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel5, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel2, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.lab_tot_diff, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel7, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lab_tot_uomo, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lab_tot_mp, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lab_tot_lav, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lab_tot_ricavi, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel4, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(501, 69);
            this.tableLayoutPanel2.TabIndex = 40;
            // 
            // lab_tot_costi
            // 
            this.lab_tot_costi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_tot_costi.AutoSize = true;
            this.lab_tot_costi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_tot_costi.Location = new System.Drawing.Point(418, 25);
            this.lab_tot_costi.Name = "lab_tot_costi";
            this.lab_tot_costi.Size = new System.Drawing.Size(80, 19);
            this.lab_tot_costi.Style = MetroFramework.MetroColorStyle.Black;
            this.lab_tot_costi.TabIndex = 37;
            this.lab_tot_costi.Text = "Totale Costi:";
            this.lab_tot_costi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lab_tot_costi.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(335, 25);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(77, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "Totale Costi:";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(335, 48);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 38;
            this.metroLabel2.Text = "Utile/Perdita:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel2.UseStyleColors = true;
            // 
            // lab_tot_diff
            // 
            this.lab_tot_diff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_tot_diff.AutoSize = true;
            this.lab_tot_diff.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_tot_diff.Location = new System.Drawing.Point(418, 48);
            this.lab_tot_diff.Name = "lab_tot_diff";
            this.lab_tot_diff.Size = new System.Drawing.Size(80, 19);
            this.lab_tot_diff.Style = MetroFramework.MetroColorStyle.Black;
            this.lab_tot_diff.TabIndex = 39;
            this.lab_tot_diff.Text = "lab_tot_diff";
            this.lab_tot_diff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lab_tot_diff.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(86, 25);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(77, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroLabel7.TabIndex = 41;
            this.metroLabel7.Text = "Manodopera:";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel7.UseStyleColors = true;
            // 
            // lab_tot_uomo
            // 
            this.lab_tot_uomo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_tot_uomo.AutoSize = true;
            this.lab_tot_uomo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_tot_uomo.Location = new System.Drawing.Point(169, 25);
            this.lab_tot_uomo.Name = "lab_tot_uomo";
            this.lab_tot_uomo.Size = new System.Drawing.Size(77, 19);
            this.lab_tot_uomo.Style = MetroFramework.MetroColorStyle.Black;
            this.lab_tot_uomo.TabIndex = 44;
            this.lab_tot_uomo.Text = "Totale Fatturato:";
            this.lab_tot_uomo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lab_tot_uomo.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(86, 2);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroLabel6.TabIndex = 40;
            this.metroLabel6.Text = "Materia Prima:";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel6.UseStyleColors = true;
            // 
            // lab_tot_mp
            // 
            this.lab_tot_mp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_tot_mp.AutoSize = true;
            this.lab_tot_mp.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_tot_mp.Location = new System.Drawing.Point(169, 2);
            this.lab_tot_mp.Name = "lab_tot_mp";
            this.lab_tot_mp.Size = new System.Drawing.Size(77, 19);
            this.lab_tot_mp.Style = MetroFramework.MetroColorStyle.Black;
            this.lab_tot_mp.TabIndex = 43;
            this.lab_tot_mp.Text = "Totale Fatturato:";
            this.lab_tot_mp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lab_tot_mp.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(86, 48);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(77, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroLabel8.TabIndex = 42;
            this.metroLabel8.Text = "Lav. Esterne:";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel8.UseStyleColors = true;
            // 
            // lab_tot_lav
            // 
            this.lab_tot_lav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_tot_lav.AutoSize = true;
            this.lab_tot_lav.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_tot_lav.Location = new System.Drawing.Point(169, 48);
            this.lab_tot_lav.Name = "lab_tot_lav";
            this.lab_tot_lav.Size = new System.Drawing.Size(77, 19);
            this.lab_tot_lav.Style = MetroFramework.MetroColorStyle.Black;
            this.lab_tot_lav.TabIndex = 45;
            this.lab_tot_lav.Text = "Totale Fatturato:";
            this.lab_tot_lav.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lab_tot_lav.UseStyleColors = true;
            // 
            // lab_tot_ricavi
            // 
            this.lab_tot_ricavi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_tot_ricavi.AutoSize = true;
            this.lab_tot_ricavi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_tot_ricavi.Location = new System.Drawing.Point(418, 2);
            this.lab_tot_ricavi.Name = "lab_tot_ricavi";
            this.lab_tot_ricavi.Size = new System.Drawing.Size(80, 19);
            this.lab_tot_ricavi.Style = MetroFramework.MetroColorStyle.Black;
            this.lab_tot_ricavi.TabIndex = 34;
            this.lab_tot_ricavi.Text = "Totale Fatturato:";
            this.lab_tot_ricavi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lab_tot_ricavi.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(335, 2);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel4.TabIndex = 35;
            this.metroLabel4.Text = "Totale Fatturato:";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel4.UseStyleColors = true;
            // 
            // btn_AzzeraFiltroClienti
            // 
            this.btn_AzzeraFiltroClienti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layout_filter.SetColumnSpan(this.btn_AzzeraFiltroClienti, 2);
            this.btn_AzzeraFiltroClienti.Location = new System.Drawing.Point(48, 78);
            this.btn_AzzeraFiltroClienti.Name = "btn_AzzeraFiltroClienti";
            this.btn_AzzeraFiltroClienti.Size = new System.Drawing.Size(70, 19);
            this.btn_AzzeraFiltroClienti.TabIndex = 41;
            this.btn_AzzeraFiltroClienti.Text = "Tutti";
            this.btn_AzzeraFiltroClienti.UseSelectable = true;
            this.btn_AzzeraFiltroClienti.Click += new System.EventHandler(this.btn_AzzeraFiltroClienti_Click);
            // 
            // aCV_Cliente
            // 
            this.aCV_Cliente.ClearBeforeFill = true;
            // 
            // aCV_ClienteArticolo
            // 
            this.aCV_ClienteArticolo.ClearBeforeFill = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Articolo";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Qta_Tot
            // 
            this.Qta_Tot.DataPropertyName = "Qta_Tot";
            this.Qta_Tot.HeaderText = "Qta_Tot";
            this.Qta_Tot.Name = "Qta_Tot";
            // 
            // Prezzo
            // 
            this.Prezzo.DataPropertyName = "Prezzo";
            this.Prezzo.HeaderText = "Prezzo";
            this.Prezzo.Name = "Prezzo";
            // 
            // Costo_Materiali
            // 
            this.Costo_Materiali.DataPropertyName = "Costo_Materiali";
            this.Costo_Materiali.HeaderText = "Costo_Materiali";
            this.Costo_Materiali.Name = "Costo_Materiali";
            // 
            // Costo_Manodopera
            // 
            this.Costo_Manodopera.DataPropertyName = "Costo_Manodopera";
            this.Costo_Manodopera.HeaderText = "Costo_Manodopera";
            this.Costo_Manodopera.Name = "Costo_Manodopera";
            // 
            // Costo_Lav_Est
            // 
            this.Costo_Lav_Est.DataPropertyName = "Costo_Lav_Est";
            this.Costo_Lav_Est.HeaderText = "Costo_Lav_Est";
            this.Costo_Lav_Est.Name = "Costo_Lav_Est";
            // 
            // Costo_Produzione
            // 
            this.Costo_Produzione.DataPropertyName = "Costo_Produzione";
            this.Costo_Produzione.HeaderText = "Costo_Produzione";
            this.Costo_Produzione.Name = "Costo_Produzione";
            // 
            // Margine
            // 
            this.Margine.DataPropertyName = "Margine";
            this.Margine.HeaderText = "Margine";
            this.Margine.Name = "Margine";
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // sF_Expl_Distinta_SaleTableAdapter
            // 
            this.sF_Expl_Distinta_SaleTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Amm_AnalisiCosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 788);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.layout_filter);
            this.Controls.Add(this.layout_orizz_menu);
            this.DisplayHeader = false;
            this.Name = "UC_Amm_AnalisiCosti";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UC_Amm_AnalisiCosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).EndInit();
            this.layout_orizz_menu.ResumeLayout(false);
            this.layout_orizz_menu.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Venduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisiCostiVendutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_Distinta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_visVenduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisiCostiVendutoSFExplDistintaSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisiCostiDistinteBindingSource)).EndInit();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.layout_filter.ResumeLayout(false);
            this.layout_filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCVClienteArticoloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCVClienteBindingSource)).EndInit();
            this.panel_Totali.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout_orizz_menu;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private ds_SL ds_SL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand1;
        private System.Windows.Forms.BindingSource analisiCostiDistinteBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colQuantita;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFlEsplodiSemilav;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCosto_Materia_Prima;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCosto_Uomo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCosto_Lav_Est;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCosto_Unit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCosto_Tot;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTipoProduzione;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLvl_DB;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNum_Art;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNum_Exp;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colArticoloIniziale;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colElaborato;
        private System.Windows.Forms.BindingSource analisiCostiVendutoBindingSource;
        private ds_SLTableAdapters.Analisi_Costi_VendutoTableAdapter analisi_Costi_VendutoTableAdapter;
        private MetroFramework.Controls.MetroGrid gv_Venduto;
        private System.Windows.Forms.TableLayoutPanel layout_filter;
        private System.Windows.Forms.ComboBox cb_elencoarticoli;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox cb_elencoClienti;
        private System.Windows.Forms.BindingSource aCVClienteBindingSource;
        private ds_SLTableAdapters.ACV_Cliente aCV_Cliente;
        private System.Windows.Forms.BindingSource aCVClienteArticoloBindingSource;
        private ds_SLTableAdapters.ACV_ClienteArticolo aCV_ClienteArticolo;
        private MetroFramework.Controls.MetroLabel lab_tot_ricavi;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lab_tot_costi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qta_Tot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo_Materiali;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo_Manodopera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo_Lav_Est;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo_Produzione;
        private System.Windows.Forms.DataGridViewTextBoxColumn Margine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lab_tot_diff;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Venduto_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Venduto_Articolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Venduto_QtaTot;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Venduto_Prezzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Venduto_TotRicavi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Venduto_TotCosti;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Venduto_CostoMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Venduto_CostoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Venduto_CostoMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Venduto_CostoLav;
        private System.Windows.Forms.DataGridViewTextBoxColumn margineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totFatturatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Venduto_Margine;
        private DevExpress.XtraTreeList.TreeList tree_Distinta;
        private System.Windows.Forms.BindingSource analisiCostiVendutoSFExplDistintaSaleBindingSource;
        private ds_SLTableAdapters.SF_Expl_Distinta_SaleTableAdapter sF_Expl_Distinta_SaleTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colArticoloComposto;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colArticoloComponente;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colQuantita1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCosto_Materia_Prima1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCosto_Uomo1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCosto_Lav_Est1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colArticoloIniziale1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCalc_Costo_Tot_Unitario;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCalc_Costo_Tot_Totale;
        private MetroFramework.Controls.MetroPanel panel_Totali;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lab_tot_mp;
        private MetroFramework.Controls.MetroLabel lab_tot_uomo;
        private MetroFramework.Controls.MetroLabel lab_tot_lav;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_visVenduto;
        private MetroFramework.Controls.MetroButton btn_AzzeraFiltroClienti;
        private MetroFramework.Controls.MetroButton btn_AzzeraFiltroArticoli;
    }
}
