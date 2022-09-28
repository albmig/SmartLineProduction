namespace SmartLineProduction
{
    partial class UC_CodificaKit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CodificaKit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.layout_orizz_menu = new System.Windows.Forms.TableLayoutPanel();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_grid_Schede = new MetroFramework.Controls.MetroPanel();
            this.gv_Schede = new MetroFramework.Controls.MetroGrid();
            this.gv_Schede_Articolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Schede_Des_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Schede_Des_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Schede_Modello = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Schede_prefix3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Schede_prefix5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Schede_Famiglia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFArticoliSchedeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_SL = new SmartLineProduction.ds_SL();
            this.panel_scelta = new MetroFramework.Controls.MetroPanel();
            this.lab_cli = new MetroFramework.Controls.MetroLabel();
            this.cb_Cliente = new System.Windows.Forms.ComboBox();
            this.tabSiglacliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lab_prog = new MetroFramework.Controls.MetroLabel();
            this.cb_Prog = new System.Windows.Forms.ComboBox();
            this.tabCombokitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lab_freq = new MetroFramework.Controls.MetroLabel();
            this.cb_Freq = new System.Windows.Forms.ComboBox();
            this.tabFreqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lab_fam = new MetroFramework.Controls.MetroLabel();
            this.cb_Fam = new System.Windows.Forms.ComboBox();
            this.tabFamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lab_cbl = new MetroFramework.Controls.MetroLabel();
            this.cb_Cbl = new System.Windows.Forms.ComboBox();
            this.tabCblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lab_combohw = new MetroFramework.Controls.MetroLabel();
            this.cb_ComboHW = new System.Windows.Forms.ComboBox();
            this.tabCombohwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lab_var = new MetroFramework.Controls.MetroLabel();
            this.cb_var = new System.Windows.Forms.ComboBox();
            this.tabVarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.panel_code = new MetroFramework.Controls.MetroPanel();
            this.tb_CodiceKit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel_pdf_it = new MetroFramework.Controls.MetroPanel();
            this.Schede_pdf_it = new AxAcroPDFLib.AxAcroPDF();
            this.panel_pdf_en = new MetroFramework.Controls.MetroPanel();
            this.Schede_pdf_en = new AxAcroPDFLib.AxAcroPDF();
            this.layout_mail = new System.Windows.Forms.TableLayoutPanel();
            this.tb_mail_text = new MetroFramework.Controls.MetroTextBox();
            this.tb_mail_subject = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_send_mail = new MetroFramework.Controls.MetroButton();
            this.tab_VarTableAdapter = new SmartLineProduction.ds_SLTableAdapters.Tab_VarTableAdapter();
            this.sF_ArticoliSchedeTableAdapter = new SmartLineProduction.ds_SLTableAdapters.SF_ArticoliSchedeTableAdapter();
            this.tab_CombohwTableAdapter = new SmartLineProduction.ds_SLTableAdapters.Tab_CombohwTableAdapter();
            this.tab_CblTableAdapter = new SmartLineProduction.ds_SLTableAdapters.Tab_CblTableAdapter();
            this.tab_FamTableAdapter = new SmartLineProduction.ds_SLTableAdapters.Tab_FamTableAdapter();
            this.tab_FreqTableAdapter = new SmartLineProduction.ds_SLTableAdapters.Tab_FreqTableAdapter();
            this.tab_CombokitTableAdapter = new SmartLineProduction.ds_SLTableAdapters.Tab_CombokitTableAdapter();
            this.tab_SiglacliTableAdapter = new SmartLineProduction.ds_SLTableAdapters.Tab_SiglacliTableAdapter();
            this.layout_orizz_menu.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_grid_Schede.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Schede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFArticoliSchedeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).BeginInit();
            this.panel_scelta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabSiglacliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCombokitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFreqBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCombohwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVarBindingSource)).BeginInit();
            this.panel_code.SuspendLayout();
            this.panel_pdf_it.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Schede_pdf_it)).BeginInit();
            this.panel_pdf_en.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Schede_pdf_en)).BeginInit();
            this.layout_mail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.layout_orizz_menu.Controls.Add(this.pan_Menu_exit, 10, 0);
            this.layout_orizz_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.layout_orizz_menu.Location = new System.Drawing.Point(20, 30);
            this.layout_orizz_menu.Name = "layout_orizz_menu";
            this.layout_orizz_menu.RowCount = 1;
            this.layout_orizz_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_orizz_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layout_orizz_menu.Size = new System.Drawing.Size(960, 25);
            this.layout_orizz_menu.TabIndex = 124;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel_grid_Schede, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel_scelta, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_code, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel_pdf_it, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel_pdf_en, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.layout_mail, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 425);
            this.tableLayoutPanel1.TabIndex = 125;
            // 
            // panel_grid_Schede
            // 
            this.panel_grid_Schede.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.panel_grid_Schede, 2);
            this.panel_grid_Schede.Controls.Add(this.gv_Schede);
            this.panel_grid_Schede.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_grid_Schede.HorizontalScrollbarBarColor = true;
            this.panel_grid_Schede.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_grid_Schede.HorizontalScrollbarSize = 10;
            this.panel_grid_Schede.Location = new System.Drawing.Point(3, 247);
            this.panel_grid_Schede.Name = "panel_grid_Schede";
            this.tableLayoutPanel1.SetRowSpan(this.panel_grid_Schede, 2);
            this.panel_grid_Schede.Size = new System.Drawing.Size(453, 175);
            this.panel_grid_Schede.TabIndex = 84;
            this.panel_grid_Schede.VerticalScrollbarBarColor = true;
            this.panel_grid_Schede.VerticalScrollbarHighlightOnWheel = false;
            this.panel_grid_Schede.VerticalScrollbarSize = 10;
            // 
            // gv_Schede
            // 
            this.gv_Schede.AllowUserToAddRows = false;
            this.gv_Schede.AllowUserToDeleteRows = false;
            this.gv_Schede.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.gv_Schede.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Schede.AutoGenerateColumns = false;
            this.gv_Schede.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Schede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Schede.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Schede.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Schede.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Schede.ColumnHeadersHeight = 40;
            this.gv_Schede.ColumnHeadersVisible = false;
            this.gv_Schede.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gv_Schede_Articolo,
            this.gv_Schede_Des_1,
            this.gv_Schede_Des_2,
            this.gv_Schede_Modello,
            this.gv_Schede_prefix3,
            this.gv_Schede_prefix5,
            this.gv_Schede_Famiglia});
            this.gv_Schede.DataSource = this.sFArticoliSchedeBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Schede.DefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Schede.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Schede.EnableHeadersVisualStyles = false;
            this.gv_Schede.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Schede.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Schede.Location = new System.Drawing.Point(0, 0);
            this.gv_Schede.MultiSelect = false;
            this.gv_Schede.Name = "gv_Schede";
            this.gv_Schede.ReadOnly = true;
            this.gv_Schede.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Schede.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_Schede.RowHeadersVisible = false;
            this.gv_Schede.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Schede.RowTemplate.Height = 30;
            this.gv_Schede.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Schede.Size = new System.Drawing.Size(451, 173);
            this.gv_Schede.Style = MetroFramework.MetroColorStyle.Red;
            this.gv_Schede.TabIndex = 0;
            this.gv_Schede.UseStyleColors = true;
            this.gv_Schede.Click += new System.EventHandler(this.gv_Schede_Click);
            // 
            // gv_Schede_Articolo
            // 
            this.gv_Schede_Articolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gv_Schede_Articolo.DataPropertyName = "Articolo";
            this.gv_Schede_Articolo.HeaderText = "Kit";
            this.gv_Schede_Articolo.Name = "gv_Schede_Articolo";
            this.gv_Schede_Articolo.ReadOnly = true;
            this.gv_Schede_Articolo.Width = 5;
            // 
            // gv_Schede_Des_1
            // 
            this.gv_Schede_Des_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gv_Schede_Des_1.DataPropertyName = "Descrizione";
            this.gv_Schede_Des_1.HeaderText = "Descrizione";
            this.gv_Schede_Des_1.Name = "gv_Schede_Des_1";
            this.gv_Schede_Des_1.ReadOnly = true;
            // 
            // gv_Schede_Des_2
            // 
            this.gv_Schede_Des_2.DataPropertyName = "DescrizioneEstesa";
            this.gv_Schede_Des_2.HeaderText = "DescrizioneEstesa";
            this.gv_Schede_Des_2.Name = "gv_Schede_Des_2";
            this.gv_Schede_Des_2.ReadOnly = true;
            this.gv_Schede_Des_2.Visible = false;
            // 
            // gv_Schede_Modello
            // 
            this.gv_Schede_Modello.DataPropertyName = "Modello";
            this.gv_Schede_Modello.HeaderText = "Modello";
            this.gv_Schede_Modello.Name = "gv_Schede_Modello";
            this.gv_Schede_Modello.ReadOnly = true;
            this.gv_Schede_Modello.Visible = false;
            // 
            // gv_Schede_prefix3
            // 
            this.gv_Schede_prefix3.DataPropertyName = "Prefix_3";
            this.gv_Schede_prefix3.HeaderText = "Prefix_3";
            this.gv_Schede_prefix3.Name = "gv_Schede_prefix3";
            this.gv_Schede_prefix3.ReadOnly = true;
            this.gv_Schede_prefix3.Visible = false;
            // 
            // gv_Schede_prefix5
            // 
            this.gv_Schede_prefix5.DataPropertyName = "Prefix_5";
            this.gv_Schede_prefix5.HeaderText = "Prefix_5";
            this.gv_Schede_prefix5.Name = "gv_Schede_prefix5";
            this.gv_Schede_prefix5.ReadOnly = true;
            this.gv_Schede_prefix5.Visible = false;
            // 
            // gv_Schede_Famiglia
            // 
            this.gv_Schede_Famiglia.DataPropertyName = "Famiglia";
            this.gv_Schede_Famiglia.HeaderText = "Famiglia";
            this.gv_Schede_Famiglia.Name = "gv_Schede_Famiglia";
            this.gv_Schede_Famiglia.ReadOnly = true;
            this.gv_Schede_Famiglia.Visible = false;
            // 
            // sFArticoliSchedeBindingSource
            // 
            this.sFArticoliSchedeBindingSource.DataMember = "SF_ArticoliSchede";
            this.sFArticoliSchedeBindingSource.DataSource = this.ds_SL;
            this.sFArticoliSchedeBindingSource.CurrentChanged += new System.EventHandler(this.sFArticoliSchedeBindingSource_CurrentChanged);
            // 
            // ds_SL
            // 
            this.ds_SL.DataSetName = "ds_SL";
            this.ds_SL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel_scelta
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel_scelta, 2);
            this.panel_scelta.Controls.Add(this.lab_cli);
            this.panel_scelta.Controls.Add(this.cb_Cliente);
            this.panel_scelta.Controls.Add(this.metroLabel9);
            this.panel_scelta.Controls.Add(this.lab_prog);
            this.panel_scelta.Controls.Add(this.cb_Prog);
            this.panel_scelta.Controls.Add(this.metroLabel4);
            this.panel_scelta.Controls.Add(this.lab_freq);
            this.panel_scelta.Controls.Add(this.cb_Freq);
            this.panel_scelta.Controls.Add(this.metroLabel8);
            this.panel_scelta.Controls.Add(this.lab_fam);
            this.panel_scelta.Controls.Add(this.cb_Fam);
            this.panel_scelta.Controls.Add(this.metroLabel7);
            this.panel_scelta.Controls.Add(this.lab_cbl);
            this.panel_scelta.Controls.Add(this.cb_Cbl);
            this.panel_scelta.Controls.Add(this.metroLabel6);
            this.panel_scelta.Controls.Add(this.lab_combohw);
            this.panel_scelta.Controls.Add(this.cb_ComboHW);
            this.panel_scelta.Controls.Add(this.metroLabel5);
            this.panel_scelta.Controls.Add(this.lab_var);
            this.panel_scelta.Controls.Add(this.cb_var);
            this.panel_scelta.Controls.Add(this.metroLabel3);
            this.panel_scelta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_scelta.HorizontalScrollbarBarColor = true;
            this.panel_scelta.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_scelta.HorizontalScrollbarSize = 10;
            this.panel_scelta.Location = new System.Drawing.Point(3, 3);
            this.panel_scelta.Name = "panel_scelta";
            this.panel_scelta.Size = new System.Drawing.Size(453, 200);
            this.panel_scelta.TabIndex = 0;
            this.panel_scelta.VerticalScrollbarBarColor = true;
            this.panel_scelta.VerticalScrollbarHighlightOnWheel = false;
            this.panel_scelta.VerticalScrollbarSize = 10;
            // 
            // lab_cli
            // 
            this.lab_cli.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_cli.Location = new System.Drawing.Point(148, 7);
            this.lab_cli.Name = "lab_cli";
            this.lab_cli.Size = new System.Drawing.Size(41, 19);
            this.lab_cli.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_cli.TabIndex = 98;
            this.lab_cli.Text = "lab_cli";
            this.lab_cli.UseStyleColors = true;
            // 
            // cb_Cliente
            // 
            this.cb_Cliente.DataSource = this.tabSiglacliBindingSource;
            this.cb_Cliente.DisplayMember = "Tab_Des";
            this.cb_Cliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Cliente.FormattingEnabled = true;
            this.cb_Cliente.Location = new System.Drawing.Point(192, 7);
            this.cb_Cliente.Name = "cb_Cliente";
            this.cb_Cliente.Size = new System.Drawing.Size(250, 21);
            this.cb_Cliente.TabIndex = 0;
            // 
            // tabSiglacliBindingSource
            // 
            this.tabSiglacliBindingSource.DataMember = "Tab_Siglacli";
            this.tabSiglacliBindingSource.DataSource = this.ds_SL;
            this.tabSiglacliBindingSource.Sort = "Tab_Des ASC";
            this.tabSiglacliBindingSource.CurrentChanged += new System.EventHandler(this.tabSiglacliBindingSource_CurrentChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(0, 7);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(52, 19);
            this.metroLabel9.TabIndex = 97;
            this.metroLabel9.Text = "Cliente:";
            // 
            // lab_prog
            // 
            this.lab_prog.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_prog.Location = new System.Drawing.Point(148, 61);
            this.lab_prog.Name = "lab_prog";
            this.lab_prog.Size = new System.Drawing.Size(41, 19);
            this.lab_prog.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_prog.TabIndex = 95;
            this.lab_prog.Text = "metroLabel1";
            this.lab_prog.UseStyleColors = true;
            // 
            // cb_Prog
            // 
            this.cb_Prog.DataSource = this.tabCombokitBindingSource;
            this.cb_Prog.DisplayMember = "Tab_Des";
            this.cb_Prog.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Prog.FormattingEnabled = true;
            this.cb_Prog.Location = new System.Drawing.Point(192, 61);
            this.cb_Prog.Name = "cb_Prog";
            this.cb_Prog.Size = new System.Drawing.Size(250, 21);
            this.cb_Prog.TabIndex = 2;
            // 
            // tabCombokitBindingSource
            // 
            this.tabCombokitBindingSource.DataMember = "Tab_Combokit";
            this.tabCombokitBindingSource.DataSource = this.ds_SL;
            this.tabCombokitBindingSource.CurrentChanged += new System.EventHandler(this.tabCombokitBindingSource_CurrentChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(0, 61);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 93;
            this.metroLabel4.Text = "Progressivo:";
            // 
            // lab_freq
            // 
            this.lab_freq.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_freq.Location = new System.Drawing.Point(148, 169);
            this.lab_freq.Name = "lab_freq";
            this.lab_freq.Size = new System.Drawing.Size(41, 19);
            this.lab_freq.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_freq.TabIndex = 92;
            this.lab_freq.Text = "lab_freq";
            this.lab_freq.UseStyleColors = true;
            // 
            // cb_Freq
            // 
            this.cb_Freq.DataSource = this.tabFreqBindingSource;
            this.cb_Freq.DisplayMember = "Tab_Des";
            this.cb_Freq.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Freq.FormattingEnabled = true;
            this.cb_Freq.Location = new System.Drawing.Point(192, 169);
            this.cb_Freq.Name = "cb_Freq";
            this.cb_Freq.Size = new System.Drawing.Size(250, 21);
            this.cb_Freq.TabIndex = 6;
            // 
            // tabFreqBindingSource
            // 
            this.tabFreqBindingSource.DataMember = "Tab_Freq";
            this.tabFreqBindingSource.DataSource = this.ds_SL;
            this.tabFreqBindingSource.Sort = "Tab_Des ASC";
            this.tabFreqBindingSource.CurrentChanged += new System.EventHandler(this.tabFreqBindingSource_CurrentChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(0, 169);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(73, 19);
            this.metroLabel8.TabIndex = 90;
            this.metroLabel8.Text = "Frequenza:";
            // 
            // lab_fam
            // 
            this.lab_fam.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_fam.Location = new System.Drawing.Point(148, 142);
            this.lab_fam.Name = "lab_fam";
            this.lab_fam.Size = new System.Drawing.Size(41, 19);
            this.lab_fam.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_fam.TabIndex = 89;
            this.lab_fam.Text = "lab_fam";
            this.lab_fam.UseStyleColors = true;
            // 
            // cb_Fam
            // 
            this.cb_Fam.DataSource = this.tabFamBindingSource;
            this.cb_Fam.DisplayMember = "Tab_Des";
            this.cb_Fam.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Fam.FormattingEnabled = true;
            this.cb_Fam.Location = new System.Drawing.Point(192, 142);
            this.cb_Fam.Name = "cb_Fam";
            this.cb_Fam.Size = new System.Drawing.Size(250, 21);
            this.cb_Fam.TabIndex = 5;
            // 
            // tabFamBindingSource
            // 
            this.tabFamBindingSource.DataMember = "Tab_Fam";
            this.tabFamBindingSource.DataSource = this.ds_SL;
            this.tabFamBindingSource.Sort = "Tab_Des ASC";
            this.tabFamBindingSource.CurrentChanged += new System.EventHandler(this.tabFamBindingSource_CurrentChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(0, 142);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(61, 19);
            this.metroLabel7.TabIndex = 87;
            this.metroLabel7.Text = "Famiglia:";
            // 
            // lab_cbl
            // 
            this.lab_cbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_cbl.Location = new System.Drawing.Point(148, 115);
            this.lab_cbl.Name = "lab_cbl";
            this.lab_cbl.Size = new System.Drawing.Size(41, 19);
            this.lab_cbl.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_cbl.TabIndex = 86;
            this.lab_cbl.Text = "metroLabel4";
            this.lab_cbl.UseStyleColors = true;
            // 
            // cb_Cbl
            // 
            this.cb_Cbl.DataSource = this.tabCblBindingSource;
            this.cb_Cbl.DisplayMember = "Tab_Des";
            this.cb_Cbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Cbl.FormattingEnabled = true;
            this.cb_Cbl.Location = new System.Drawing.Point(192, 115);
            this.cb_Cbl.Name = "cb_Cbl";
            this.cb_Cbl.Size = new System.Drawing.Size(250, 21);
            this.cb_Cbl.TabIndex = 4;
            // 
            // tabCblBindingSource
            // 
            this.tabCblBindingSource.DataMember = "Tab_Cbl";
            this.tabCblBindingSource.DataSource = this.ds_SL;
            this.tabCblBindingSource.Sort = "Tab_Des ASC";
            this.tabCblBindingSource.CurrentChanged += new System.EventHandler(this.tabCblBindingSource_CurrentChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(0, 115);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(146, 19);
            this.metroLabel6.TabIndex = 84;
            this.metroLabel6.Text = "Cablaggio/Var. Custom:";
            // 
            // lab_combohw
            // 
            this.lab_combohw.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_combohw.Location = new System.Drawing.Point(148, 88);
            this.lab_combohw.Name = "lab_combohw";
            this.lab_combohw.Size = new System.Drawing.Size(41, 19);
            this.lab_combohw.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_combohw.TabIndex = 83;
            this.lab_combohw.Text = "lab_combohw";
            this.lab_combohw.UseStyleColors = true;
            // 
            // cb_ComboHW
            // 
            this.cb_ComboHW.DataSource = this.tabCombohwBindingSource;
            this.cb_ComboHW.DisplayMember = "Tab_Des";
            this.cb_ComboHW.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ComboHW.FormattingEnabled = true;
            this.cb_ComboHW.Location = new System.Drawing.Point(192, 88);
            this.cb_ComboHW.Name = "cb_ComboHW";
            this.cb_ComboHW.Size = new System.Drawing.Size(250, 21);
            this.cb_ComboHW.TabIndex = 3;
            // 
            // tabCombohwBindingSource
            // 
            this.tabCombohwBindingSource.DataMember = "Tab_Combohw";
            this.tabCombohwBindingSource.DataSource = this.ds_SL;
            this.tabCombohwBindingSource.Sort = "Tab_Des ASC";
            this.tabCombohwBindingSource.CurrentChanged += new System.EventHandler(this.tabCombohwBindingSource_CurrentChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(0, 88);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 19);
            this.metroLabel5.TabIndex = 81;
            this.metroLabel5.Text = "Combo HW:";
            // 
            // lab_var
            // 
            this.lab_var.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_var.Location = new System.Drawing.Point(148, 34);
            this.lab_var.Name = "lab_var";
            this.lab_var.Size = new System.Drawing.Size(41, 19);
            this.lab_var.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_var.TabIndex = 80;
            this.lab_var.Text = "lab_var";
            this.lab_var.UseStyleColors = true;
            // 
            // cb_var
            // 
            this.cb_var.DataSource = this.tabVarBindingSource;
            this.cb_var.DisplayMember = "Tab_Des";
            this.cb_var.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_var.FormattingEnabled = true;
            this.cb_var.Location = new System.Drawing.Point(192, 34);
            this.cb_var.Name = "cb_var";
            this.cb_var.Size = new System.Drawing.Size(250, 21);
            this.cb_var.TabIndex = 1;
            // 
            // tabVarBindingSource
            // 
            this.tabVarBindingSource.DataMember = "Tab_Var";
            this.tabVarBindingSource.DataSource = this.ds_SL;
            this.tabVarBindingSource.CurrentChanged += new System.EventHandler(this.tabVarBindingSource_CurrentChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(0, 34);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 78;
            this.metroLabel3.Text = "Variante:";
            // 
            // panel_code
            // 
            this.panel_code.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.panel_code, 2);
            this.panel_code.Controls.Add(this.tb_CodiceKit);
            this.panel_code.Controls.Add(this.metroLabel2);
            this.panel_code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_code.HorizontalScrollbarBarColor = true;
            this.panel_code.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_code.HorizontalScrollbarSize = 10;
            this.panel_code.Location = new System.Drawing.Point(3, 209);
            this.panel_code.Name = "panel_code";
            this.panel_code.Size = new System.Drawing.Size(453, 32);
            this.panel_code.TabIndex = 1;
            this.panel_code.VerticalScrollbarBarColor = true;
            this.panel_code.VerticalScrollbarHighlightOnWheel = false;
            this.panel_code.VerticalScrollbarSize = 10;
            // 
            // tb_CodiceKit
            // 
            this.tb_CodiceKit.BackColor = System.Drawing.Color.LightYellow;
            // 
            // 
            // 
            this.tb_CodiceKit.CustomButton.Image = null;
            this.tb_CodiceKit.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.tb_CodiceKit.CustomButton.Name = "";
            this.tb_CodiceKit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_CodiceKit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_CodiceKit.CustomButton.TabIndex = 1;
            this.tb_CodiceKit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_CodiceKit.CustomButton.UseSelectable = true;
            this.tb_CodiceKit.CustomButton.Visible = false;
            this.tb_CodiceKit.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_CodiceKit.ForeColor = System.Drawing.Color.Maroon;
            this.tb_CodiceKit.Lines = new string[] {
        "metroTextBox1"};
            this.tb_CodiceKit.Location = new System.Drawing.Point(192, 5);
            this.tb_CodiceKit.MaxLength = 32767;
            this.tb_CodiceKit.Name = "tb_CodiceKit";
            this.tb_CodiceKit.PasswordChar = '\0';
            this.tb_CodiceKit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_CodiceKit.SelectedText = "";
            this.tb_CodiceKit.SelectionLength = 0;
            this.tb_CodiceKit.SelectionStart = 0;
            this.tb_CodiceKit.ShortcutsEnabled = true;
            this.tb_CodiceKit.Size = new System.Drawing.Size(148, 23);
            this.tb_CodiceKit.Style = MetroFramework.MetroColorStyle.Red;
            this.tb_CodiceKit.TabIndex = 0;
            this.tb_CodiceKit.Text = "metroTextBox1";
            this.tb_CodiceKit.UseCustomBackColor = true;
            this.tb_CodiceKit.UseSelectable = true;
            this.tb_CodiceKit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_CodiceKit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(113, 8);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 75;
            this.metroLabel2.Text = "Codice Kit:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // panel_pdf_it
            // 
            this.panel_pdf_it.Controls.Add(this.Schede_pdf_it);
            this.panel_pdf_it.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_pdf_it.HorizontalScrollbarBarColor = true;
            this.panel_pdf_it.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_pdf_it.HorizontalScrollbarSize = 10;
            this.panel_pdf_it.Location = new System.Drawing.Point(462, 247);
            this.panel_pdf_it.Name = "panel_pdf_it";
            this.tableLayoutPanel1.SetRowSpan(this.panel_pdf_it, 2);
            this.panel_pdf_it.Size = new System.Drawing.Size(243, 175);
            this.panel_pdf_it.TabIndex = 85;
            this.panel_pdf_it.VerticalScrollbarBarColor = true;
            this.panel_pdf_it.VerticalScrollbarHighlightOnWheel = false;
            this.panel_pdf_it.VerticalScrollbarSize = 10;
            // 
            // Schede_pdf_it
            // 
            this.Schede_pdf_it.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Schede_pdf_it.Enabled = true;
            this.Schede_pdf_it.Location = new System.Drawing.Point(0, 0);
            this.Schede_pdf_it.Name = "Schede_pdf_it";
            this.Schede_pdf_it.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Schede_pdf_it.OcxState")));
            this.Schede_pdf_it.Size = new System.Drawing.Size(243, 175);
            this.Schede_pdf_it.TabIndex = 85;
            // 
            // panel_pdf_en
            // 
            this.panel_pdf_en.Controls.Add(this.Schede_pdf_en);
            this.panel_pdf_en.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_pdf_en.HorizontalScrollbarBarColor = true;
            this.panel_pdf_en.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_pdf_en.HorizontalScrollbarSize = 10;
            this.panel_pdf_en.Location = new System.Drawing.Point(711, 247);
            this.panel_pdf_en.Name = "panel_pdf_en";
            this.tableLayoutPanel1.SetRowSpan(this.panel_pdf_en, 2);
            this.panel_pdf_en.Size = new System.Drawing.Size(246, 175);
            this.panel_pdf_en.TabIndex = 86;
            this.panel_pdf_en.VerticalScrollbarBarColor = true;
            this.panel_pdf_en.VerticalScrollbarHighlightOnWheel = false;
            this.panel_pdf_en.VerticalScrollbarSize = 10;
            // 
            // Schede_pdf_en
            // 
            this.Schede_pdf_en.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Schede_pdf_en.Enabled = true;
            this.Schede_pdf_en.Location = new System.Drawing.Point(0, 0);
            this.Schede_pdf_en.Name = "Schede_pdf_en";
            this.Schede_pdf_en.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Schede_pdf_en.OcxState")));
            this.Schede_pdf_en.Size = new System.Drawing.Size(246, 175);
            this.Schede_pdf_en.TabIndex = 85;
            // 
            // layout_mail
            // 
            this.layout_mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.layout_mail.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.layout_mail, 2);
            this.layout_mail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_mail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_mail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_mail.Controls.Add(this.tb_mail_text, 1, 1);
            this.layout_mail.Controls.Add(this.tb_mail_subject, 1, 0);
            this.layout_mail.Controls.Add(this.metroLabel10, 0, 1);
            this.layout_mail.Controls.Add(this.metroLabel1, 0, 0);
            this.layout_mail.Controls.Add(this.pictureBox1, 2, 0);
            this.layout_mail.Controls.Add(this.btn_send_mail, 2, 2);
            this.layout_mail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_mail.Location = new System.Drawing.Point(462, 3);
            this.layout_mail.Name = "layout_mail";
            this.layout_mail.RowCount = 3;
            this.tableLayoutPanel1.SetRowSpan(this.layout_mail, 2);
            this.layout_mail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout_mail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout_mail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layout_mail.Size = new System.Drawing.Size(495, 238);
            this.layout_mail.TabIndex = 87;
            // 
            // tb_mail_text
            // 
            // 
            // 
            // 
            this.tb_mail_text.CustomButton.Image = null;
            this.tb_mail_text.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.tb_mail_text.CustomButton.Name = "";
            this.tb_mail_text.CustomButton.Size = new System.Drawing.Size(201, 201);
            this.tb_mail_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_mail_text.CustomButton.TabIndex = 1;
            this.tb_mail_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_mail_text.CustomButton.UseSelectable = true;
            this.tb_mail_text.CustomButton.Visible = false;
            this.tb_mail_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_mail_text.Lines = new string[] {
        "tb_mail_text"};
            this.tb_mail_text.Location = new System.Drawing.Point(71, 32);
            this.tb_mail_text.MaxLength = 32767;
            this.tb_mail_text.Multiline = true;
            this.tb_mail_text.Name = "tb_mail_text";
            this.tb_mail_text.PasswordChar = '\0';
            this.layout_mail.SetRowSpan(this.tb_mail_text, 2);
            this.tb_mail_text.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_mail_text.SelectedText = "";
            this.tb_mail_text.SelectionLength = 0;
            this.tb_mail_text.SelectionStart = 0;
            this.tb_mail_text.ShortcutsEnabled = true;
            this.tb_mail_text.Size = new System.Drawing.Size(340, 203);
            this.tb_mail_text.TabIndex = 103;
            this.tb_mail_text.Text = "tb_mail_text";
            this.tb_mail_text.UseSelectable = true;
            this.tb_mail_text.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_mail_text.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_mail_subject
            // 
            // 
            // 
            // 
            this.tb_mail_subject.CustomButton.Image = null;
            this.tb_mail_subject.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.tb_mail_subject.CustomButton.Name = "";
            this.tb_mail_subject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_mail_subject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_mail_subject.CustomButton.TabIndex = 1;
            this.tb_mail_subject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_mail_subject.CustomButton.UseSelectable = true;
            this.tb_mail_subject.CustomButton.Visible = false;
            this.tb_mail_subject.Lines = new string[] {
        "tb_mail_subject"};
            this.tb_mail_subject.Location = new System.Drawing.Point(71, 3);
            this.tb_mail_subject.MaxLength = 32767;
            this.tb_mail_subject.Name = "tb_mail_subject";
            this.tb_mail_subject.PasswordChar = '\0';
            this.tb_mail_subject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_mail_subject.SelectedText = "";
            this.tb_mail_subject.SelectionLength = 0;
            this.tb_mail_subject.SelectionStart = 0;
            this.tb_mail_subject.ShortcutsEnabled = true;
            this.tb_mail_subject.Size = new System.Drawing.Size(340, 23);
            this.tb_mail_subject.TabIndex = 102;
            this.tb_mail_subject.Text = "tb_mail_subject";
            this.tb_mail_subject.UseSelectable = true;
            this.tb_mail_subject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_mail_subject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel10.Location = new System.Drawing.Point(3, 29);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(41, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel10.TabIndex = 101;
            this.metroLabel10.Text = "Testo:";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 99;
            this.metroLabel1.Text = "Oggetto:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SmartLineProduction.Properties.Resources.Mail_01;
            this.pictureBox1.Location = new System.Drawing.Point(417, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.layout_mail.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(75, 65);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_send_mail
            // 
            this.btn_send_mail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_send_mail.Location = new System.Drawing.Point(417, 206);
            this.btn_send_mail.Name = "btn_send_mail";
            this.btn_send_mail.Size = new System.Drawing.Size(75, 29);
            this.btn_send_mail.TabIndex = 104;
            this.btn_send_mail.Text = "Invia";
            this.btn_send_mail.UseSelectable = true;
            this.btn_send_mail.Click += new System.EventHandler(this.btn_send_mail_Click);
            // 
            // tab_VarTableAdapter
            // 
            this.tab_VarTableAdapter.ClearBeforeFill = true;
            // 
            // sF_ArticoliSchedeTableAdapter
            // 
            this.sF_ArticoliSchedeTableAdapter.ClearBeforeFill = true;
            // 
            // tab_CombohwTableAdapter
            // 
            this.tab_CombohwTableAdapter.ClearBeforeFill = true;
            // 
            // tab_CblTableAdapter
            // 
            this.tab_CblTableAdapter.ClearBeforeFill = true;
            // 
            // tab_FamTableAdapter
            // 
            this.tab_FamTableAdapter.ClearBeforeFill = true;
            // 
            // tab_FreqTableAdapter
            // 
            this.tab_FreqTableAdapter.ClearBeforeFill = true;
            // 
            // tab_CombokitTableAdapter
            // 
            this.tab_CombokitTableAdapter.ClearBeforeFill = true;
            // 
            // tab_SiglacliTableAdapter
            // 
            this.tab_SiglacliTableAdapter.ClearBeforeFill = true;
            // 
            // UC_CodificaKit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.layout_orizz_menu);
            this.DisplayHeader = false;
            this.Name = "UC_CodificaKit";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UC_CodificaKit_Load);
            this.layout_orizz_menu.ResumeLayout(false);
            this.layout_orizz_menu.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_grid_Schede.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Schede)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFArticoliSchedeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).EndInit();
            this.panel_scelta.ResumeLayout(false);
            this.panel_scelta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabSiglacliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCombokitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFreqBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCombohwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVarBindingSource)).EndInit();
            this.panel_code.ResumeLayout(false);
            this.panel_code.PerformLayout();
            this.panel_pdf_it.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Schede_pdf_it)).EndInit();
            this.panel_pdf_en.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Schede_pdf_en)).EndInit();
            this.layout_mail.ResumeLayout(false);
            this.layout_mail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout_orizz_menu;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel panel_scelta;
        private MetroFramework.Controls.MetroPanel panel_code;
        private MetroFramework.Controls.MetroTextBox tb_CodiceKit;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private ds_SL ds_SL;
        private MetroFramework.Controls.MetroLabel lab_var;
        private System.Windows.Forms.ComboBox cb_var;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.BindingSource tabVarBindingSource;
        private ds_SLTableAdapters.Tab_VarTableAdapter tab_VarTableAdapter;
        private MetroFramework.Controls.MetroPanel panel_grid_Schede;
        private MetroFramework.Controls.MetroGrid gv_Schede;
        private System.Windows.Forms.BindingSource sFArticoliSchedeBindingSource;
        private ds_SLTableAdapters.SF_ArticoliSchedeTableAdapter sF_ArticoliSchedeTableAdapter;
        private MetroFramework.Controls.MetroLabel lab_combohw;
        private System.Windows.Forms.ComboBox cb_ComboHW;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.BindingSource tabCombohwBindingSource;
        private ds_SLTableAdapters.Tab_CombohwTableAdapter tab_CombohwTableAdapter;
        private MetroFramework.Controls.MetroLabel lab_cbl;
        private System.Windows.Forms.ComboBox cb_Cbl;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.BindingSource tabCblBindingSource;
        private ds_SLTableAdapters.Tab_CblTableAdapter tab_CblTableAdapter;
        private MetroFramework.Controls.MetroLabel lab_fam;
        private System.Windows.Forms.ComboBox cb_Fam;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.BindingSource tabFamBindingSource;
        private ds_SLTableAdapters.Tab_FamTableAdapter tab_FamTableAdapter;
        private MetroFramework.Controls.MetroLabel lab_freq;
        private System.Windows.Forms.ComboBox cb_Freq;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.BindingSource tabFreqBindingSource;
        private ds_SLTableAdapters.Tab_FreqTableAdapter tab_FreqTableAdapter;
        private MetroFramework.Controls.MetroLabel lab_prog;
        private System.Windows.Forms.ComboBox cb_Prog;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.BindingSource tabCombokitBindingSource;
        private ds_SLTableAdapters.Tab_CombokitTableAdapter tab_CombokitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Schede_Articolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Schede_Des_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Schede_Des_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Schede_Modello;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Schede_prefix3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Schede_prefix5;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Schede_Famiglia;
        private MetroFramework.Controls.MetroLabel lab_cli;
        private System.Windows.Forms.ComboBox cb_Cliente;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.BindingSource tabSiglacliBindingSource;
        private ds_SLTableAdapters.Tab_SiglacliTableAdapter tab_SiglacliTableAdapter;
        private MetroFramework.Controls.MetroPanel panel_pdf_it;
        private AxAcroPDFLib.AxAcroPDF Schede_pdf_it;
        private MetroFramework.Controls.MetroPanel panel_pdf_en;
        private AxAcroPDFLib.AxAcroPDF Schede_pdf_en;
        private System.Windows.Forms.TableLayoutPanel layout_mail;
        private MetroFramework.Controls.MetroTextBox tb_mail_text;
        private MetroFramework.Controls.MetroTextBox tb_mail_subject;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btn_send_mail;
    }
}
