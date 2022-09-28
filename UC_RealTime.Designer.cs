namespace SmartLineProduction
{
    partial class UC_RealTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_RealTime));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.layout_orizz_menu = new System.Windows.Forms.TableLayoutPanel();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_Menu_salva = new System.Windows.Forms.MenuStrip();
            this.menu_salva = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_div12 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_annulla = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_Menu_comandi = new System.Windows.Forms.MenuStrip();
            this.menu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemPageNumberEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.layout_menu_control = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lab_Fw_Des_En = new MetroFramework.Controls.MetroLabel();
            this.firmwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_RealTime = new SmartLineProduction.ds_RealTime();
            this.lab_Fw_Des = new MetroFramework.Controls.MetroLabel();
            this.cb_Fw_Code = new System.Windows.Forms.ComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.tabbed_pages = new DevExpress.XtraTab.XtraTabControl();
            this.tab_Analog = new DevExpress.XtraTab.XtraTabPage();
            this.gv_AnalogMessages = new MetroFramework.Controls.MetroGrid();
            this.uIAnPKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIAnSWCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIAnProgrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIAnGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIAnDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIAnDisplayOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIAnDisplayOrderGroupElementsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIAnFormatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIAnUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIAnMultiplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBUI_An_Icon_Name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.uIAnIconNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIAnMinValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIAnMaxValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIAnRefDgAlarmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIAnThresholdDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIAnObsoleteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.firmwareUIAnalogMessagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.but_Preview = new MetroFramework.Controls.MetroButton();
            this.tab_Digital = new DevExpress.XtraTab.XtraTabPage();
            this.panel_digital_messages = new MetroFramework.Controls.MetroPanel();
            this.cb_15_icon_1 = new System.Windows.Forms.ComboBox();
            this.cb_14_icon_1 = new System.Windows.Forms.ComboBox();
            this.cb_13_icon_1 = new System.Windows.Forms.ComboBox();
            this.cb_12_icon_1 = new System.Windows.Forms.ComboBox();
            this.cb_11_icon_1 = new System.Windows.Forms.ComboBox();
            this.cb_10_icon_1 = new System.Windows.Forms.ComboBox();
            this.cb_09_icon_1 = new System.Windows.Forms.ComboBox();
            this.cb_08_icon_1 = new System.Windows.Forms.ComboBox();
            this.cb_07_icon_1 = new System.Windows.Forms.ComboBox();
            this.cb_06_icon_1 = new System.Windows.Forms.ComboBox();
            this.cb_05_icon_1 = new System.Windows.Forms.ComboBox();
            this.cb_04_icon_1 = new System.Windows.Forms.ComboBox();
            this.cb_03_icon_1 = new System.Windows.Forms.ComboBox();
            this.cb_02_icon_1 = new System.Windows.Forms.ComboBox();
            this.cb_01_icon_1 = new System.Windows.Forms.ComboBox();
            this.cb_00_icon_1 = new System.Windows.Forms.ComboBox();
            this.cb_15_icon_0 = new System.Windows.Forms.ComboBox();
            this.cb_14_icon_0 = new System.Windows.Forms.ComboBox();
            this.cb_13_icon_0 = new System.Windows.Forms.ComboBox();
            this.cb_12_icon_0 = new System.Windows.Forms.ComboBox();
            this.cb_11_icon_0 = new System.Windows.Forms.ComboBox();
            this.cb_10_icon_0 = new System.Windows.Forms.ComboBox();
            this.cb_09_icon_0 = new System.Windows.Forms.ComboBox();
            this.cb_08_icon_0 = new System.Windows.Forms.ComboBox();
            this.cb_07_icon_0 = new System.Windows.Forms.ComboBox();
            this.cb_06_icon_0 = new System.Windows.Forms.ComboBox();
            this.cb_05_icon_0 = new System.Windows.Forms.ComboBox();
            this.cb_04_icon_0 = new System.Windows.Forms.ComboBox();
            this.cb_03_icon_0 = new System.Windows.Forms.ComboBox();
            this.cb_02_icon_0 = new System.Windows.Forms.ComboBox();
            this.cb_01_icon_0 = new System.Windows.Forms.ComboBox();
            this.cb_00_icon_0 = new System.Windows.Forms.ComboBox();
            this.Rif_val_15 = new MetroFramework.Controls.MetroTextBox();
            this.firmwareUIDigitalMessagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Rif_val_14 = new MetroFramework.Controls.MetroTextBox();
            this.Rif_val_13 = new MetroFramework.Controls.MetroTextBox();
            this.Rif_val_12 = new MetroFramework.Controls.MetroTextBox();
            this.Rif_val_11 = new MetroFramework.Controls.MetroTextBox();
            this.Rif_val_10 = new MetroFramework.Controls.MetroTextBox();
            this.Rif_val_09 = new MetroFramework.Controls.MetroTextBox();
            this.Rif_val_08 = new MetroFramework.Controls.MetroTextBox();
            this.Rif_val_07 = new MetroFramework.Controls.MetroTextBox();
            this.Rif_val_06 = new MetroFramework.Controls.MetroTextBox();
            this.Rif_val_05 = new MetroFramework.Controls.MetroTextBox();
            this.Rif_val_04 = new MetroFramework.Controls.MetroTextBox();
            this.Rif_val_03 = new MetroFramework.Controls.MetroTextBox();
            this.Rif_val_02 = new MetroFramework.Controls.MetroTextBox();
            this.Rif_val_01 = new MetroFramework.Controls.MetroTextBox();
            this.Rif_val_00 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox30 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox31 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox28 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox29 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox26 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox27 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox24 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox25 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox22 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox23 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox20 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox21 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox18 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox19 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox16 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox17 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox14 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox15 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox12 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox13 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox10 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox11 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox9 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox16 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox15 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox14 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox13 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox12 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox11 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox10 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox9 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox8 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox7 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox6 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox5 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tb_gv_Code = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tab_Event = new DevExpress.XtraTab.XtraTabPage();
            this.gv_EventLogMessages = new MetroFramework.Controls.MetroGrid();
            this.uIELPKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIELSWCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIELEventNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIELChannelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIELInputTypeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uIELUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIELFormatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIELMultiplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIELDescitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIELDescenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIELShowValOrDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIELObsoleteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UI_EL_Totalizza = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.firmwareUIEventLogMessagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmwareTableAdapter = new SmartLineProduction.ds_RealTimeTableAdapters.FirmwareTableAdapter();
            this.uI_Analog_MessagesTableAdapter = new SmartLineProduction.ds_RealTimeTableAdapters.UI_Analog_MessagesTableAdapter();
            this.uI_Digital_MessagesTableAdapter = new SmartLineProduction.ds_RealTimeTableAdapters.UI_Digital_MessagesTableAdapter();
            this.uI_EventLog_MessagesTableAdapter = new SmartLineProduction.ds_RealTimeTableAdapters.UI_EventLog_MessagesTableAdapter();
            this.Strip_Delete_EventLog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminaRigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layout_orizz_menu.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            this.pan_Menu_salva.SuspendLayout();
            this.pan_Menu_comandi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.layout_menu_control.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_RealTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbed_pages)).BeginInit();
            this.tabbed_pages.SuspendLayout();
            this.tab_Analog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AnalogMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmwareUIAnalogMessagesBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tab_Digital.SuspendLayout();
            this.panel_digital_messages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmwareUIDigitalMessagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab_Event.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_EventLogMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmwareUIEventLogMessagesBindingSource)).BeginInit();
            this.Strip_Delete_EventLog.SuspendLayout();
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
            this.layout_orizz_menu.Size = new System.Drawing.Size(1249, 25);
            this.layout_orizz_menu.TabIndex = 120;
            // 
            // pan_Menu_exit
            // 
            this.pan_Menu_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_Menu_exit.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_Menu_exit.Dock = System.Windows.Forms.DockStyle.None;
            this.pan_Menu_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sw_exit});
            this.pan_Menu_exit.Location = new System.Drawing.Point(1174, 0);
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
            // pan_Menu_salva
            // 
            this.pan_Menu_salva.BackColor = System.Drawing.Color.Gainsboro;
            this.layout_menu_control.SetColumnSpan(this.pan_Menu_salva, 2);
            this.pan_Menu_salva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Menu_salva.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_salva,
            this.menu_sw_div12,
            this.menu_annulla});
            this.pan_Menu_salva.Location = new System.Drawing.Point(248, 0);
            this.pan_Menu_salva.Name = "pan_Menu_salva";
            this.pan_Menu_salva.Size = new System.Drawing.Size(248, 24);
            this.pan_Menu_salva.TabIndex = 86;
            this.pan_Menu_salva.Text = "menuStrip1";
            // 
            // menu_salva
            // 
            this.menu_salva.Image = ((System.Drawing.Image)(resources.GetObject("menu_salva.Image")));
            this.menu_salva.Name = "menu_salva";
            this.menu_salva.Size = new System.Drawing.Size(62, 20);
            this.menu_salva.Text = "Salva";
            // 
            // menu_sw_div12
            // 
            this.menu_sw_div12.Enabled = false;
            this.menu_sw_div12.Name = "menu_sw_div12";
            this.menu_sw_div12.ShowShortcutKeys = false;
            this.menu_sw_div12.Size = new System.Drawing.Size(22, 20);
            this.menu_sw_div12.Text = "|";
            // 
            // menu_annulla
            // 
            this.menu_annulla.Image = ((System.Drawing.Image)(resources.GetObject("menu_annulla.Image")));
            this.menu_annulla.Name = "menu_annulla";
            this.menu_annulla.Size = new System.Drawing.Size(76, 20);
            this.menu_annulla.Text = "Annulla";
            // 
            // pan_Menu_comandi
            // 
            this.pan_Menu_comandi.BackColor = System.Drawing.Color.Gainsboro;
            this.layout_menu_control.SetColumnSpan(this.pan_Menu_comandi, 2);
            this.pan_Menu_comandi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Menu_comandi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_edit});
            this.pan_Menu_comandi.Location = new System.Drawing.Point(0, 0);
            this.pan_Menu_comandi.Name = "pan_Menu_comandi";
            this.pan_Menu_comandi.Size = new System.Drawing.Size(248, 24);
            this.pan_Menu_comandi.TabIndex = 86;
            this.pan_Menu_comandi.Text = "menuStrip1";
            // 
            // menu_edit
            // 
            this.menu_edit.Image = ((System.Drawing.Image)(resources.GetObject("menu_edit.Image")));
            this.menu_edit.Name = "menu_edit";
            this.menu_edit.Size = new System.Drawing.Size(82, 20);
            this.menu_edit.Text = "Modifica";
            this.menu_edit.Click += new System.EventHandler(this.menu_edit_Click);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 24;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPageNumberEdit1});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(20, 30);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1249, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(20, 847);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1249, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(20, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 817);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1269, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 817);
            // 
            // repositoryItemPageNumberEdit1
            // 
            this.repositoryItemPageNumberEdit1.AutoHeight = false;
            this.repositoryItemPageNumberEdit1.Mask.EditMask = "########;";
            this.repositoryItemPageNumberEdit1.Name = "repositoryItemPageNumberEdit1";
            this.repositoryItemPageNumberEdit1.Orientation = DevExpress.XtraEditors.PagerOrientation.Horizontal;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.layout_menu_control, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabbed_pages, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1249, 792);
            this.tableLayoutPanel1.TabIndex = 121;
            // 
            // layout_menu_control
            // 
            this.layout_menu_control.BackColor = System.Drawing.Color.Gainsboro;
            this.layout_menu_control.ColumnCount = 10;
            this.layout_menu_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu_control.Controls.Add(this.pan_Menu_salva, 0, 0);
            this.layout_menu_control.Controls.Add(this.pan_Menu_comandi, 0, 0);
            this.layout_menu_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.layout_menu_control.Location = new System.Drawing.Point(3, 63);
            this.layout_menu_control.Name = "layout_menu_control";
            this.layout_menu_control.RowCount = 1;
            this.layout_menu_control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_menu_control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.layout_menu_control.Size = new System.Drawing.Size(1249, 24);
            this.layout_menu_control.TabIndex = 121;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.metroPanel1.Controls.Add(this.lab_Fw_Des_En);
            this.metroPanel1.Controls.Add(this.lab_Fw_Des);
            this.metroPanel1.Controls.Add(this.cb_Fw_Code);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1249, 54);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lab_Fw_Des_En
            // 
            this.lab_Fw_Des_En.AutoSize = true;
            this.lab_Fw_Des_En.BackColor = System.Drawing.Color.Transparent;
            this.lab_Fw_Des_En.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareBindingSource, "SW_Descrizione_EN", true));
            this.lab_Fw_Des_En.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_Fw_Des_En.Location = new System.Drawing.Point(291, 29);
            this.lab_Fw_Des_En.Name = "lab_Fw_Des_En";
            this.lab_Fw_Des_En.Size = new System.Drawing.Size(100, 19);
            this.lab_Fw_Des_En.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_Fw_Des_En.TabIndex = 32;
            this.lab_Fw_Des_En.Text = "lab_Fw_Des_En";
            this.lab_Fw_Des_En.UseCustomBackColor = true;
            this.lab_Fw_Des_En.UseStyleColors = true;
            // 
            // firmwareBindingSource
            // 
            this.firmwareBindingSource.DataMember = "Firmware";
            this.firmwareBindingSource.DataSource = this.ds_RealTime;
            this.firmwareBindingSource.Sort = "SW_Versione desc";
            // 
            // ds_RealTime
            // 
            this.ds_RealTime.DataSetName = "ds_RealTime";
            this.ds_RealTime.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lab_Fw_Des
            // 
            this.lab_Fw_Des.AutoSize = true;
            this.lab_Fw_Des.BackColor = System.Drawing.Color.Transparent;
            this.lab_Fw_Des.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareBindingSource, "SW_Descrizione", true));
            this.lab_Fw_Des.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_Fw_Des.Location = new System.Drawing.Point(291, 10);
            this.lab_Fw_Des.Name = "lab_Fw_Des";
            this.lab_Fw_Des.Size = new System.Drawing.Size(79, 19);
            this.lab_Fw_Des.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_Fw_Des.TabIndex = 31;
            this.lab_Fw_Des.Text = "lab_Fw_Des";
            this.lab_Fw_Des.UseCustomBackColor = true;
            this.lab_Fw_Des.UseStyleColors = true;
            // 
            // cb_Fw_Code
            // 
            this.cb_Fw_Code.DataSource = this.firmwareBindingSource;
            this.cb_Fw_Code.DisplayMember = "SW_Code";
            this.cb_Fw_Code.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Fw_Code.FormattingEnabled = true;
            this.cb_Fw_Code.Location = new System.Drawing.Point(88, 10);
            this.cb_Fw_Code.Name = "cb_Fw_Code";
            this.cb_Fw_Code.Size = new System.Drawing.Size(197, 23);
            this.cb_Fw_Code.TabIndex = 30;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(10, 10);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(72, 19);
            this.metroLabel11.TabIndex = 28;
            this.metroLabel11.Text = "Firmware :";
            this.metroLabel11.UseCustomBackColor = true;
            // 
            // tabbed_pages
            // 
            this.tabbed_pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabbed_pages.Location = new System.Drawing.Point(3, 93);
            this.tabbed_pages.Name = "tabbed_pages";
            this.tabbed_pages.SelectedTabPage = this.tab_Analog;
            this.tabbed_pages.Size = new System.Drawing.Size(1249, 696);
            this.tabbed_pages.TabIndex = 1;
            this.tabbed_pages.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tab_Analog,
            this.tab_Digital,
            this.tab_Event});
            // 
            // tab_Analog
            // 
            this.tab_Analog.Controls.Add(this.gv_AnalogMessages);
            this.tab_Analog.Controls.Add(this.tableLayoutPanel2);
            this.tab_Analog.Name = "tab_Analog";
            this.tab_Analog.Size = new System.Drawing.Size(1247, 671);
            this.tab_Analog.Text = "Analog messages";
            // 
            // gv_AnalogMessages
            // 
            this.gv_AnalogMessages.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.gv_AnalogMessages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_AnalogMessages.AutoGenerateColumns = false;
            this.gv_AnalogMessages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_AnalogMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_AnalogMessages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_AnalogMessages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_AnalogMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_AnalogMessages.ColumnHeadersHeight = 60;
            this.gv_AnalogMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uIAnPKDataGridViewTextBoxColumn,
            this.uIAnSWCodeDataGridViewTextBoxColumn,
            this.uIAnProgrDataGridViewTextBoxColumn,
            this.uIAnGroupDataGridViewTextBoxColumn,
            this.uIAnDescDataGridViewTextBoxColumn,
            this.uIAnDisplayOrderDataGridViewTextBoxColumn,
            this.uIAnDisplayOrderGroupElementsDataGridViewTextBoxColumn,
            this.uIAnFormatDataGridViewTextBoxColumn,
            this.uIAnUMDataGridViewTextBoxColumn,
            this.uIAnMultiplierDataGridViewTextBoxColumn,
            this.CBUI_An_Icon_Name,
            this.uIAnIconNameDataGridViewTextBoxColumn,
            this.uIAnMinValueDataGridViewTextBoxColumn,
            this.uIAnMaxValueDataGridViewTextBoxColumn,
            this.uIAnRefDgAlarmDataGridViewTextBoxColumn,
            this.uIAnThresholdDesDataGridViewTextBoxColumn,
            this.uIAnObsoleteDataGridViewCheckBoxColumn});
            this.gv_AnalogMessages.DataSource = this.firmwareUIAnalogMessagesBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_AnalogMessages.DefaultCellStyle = dataGridViewCellStyle4;
            this.gv_AnalogMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_AnalogMessages.EnableHeadersVisualStyles = false;
            this.gv_AnalogMessages.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_AnalogMessages.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_AnalogMessages.Location = new System.Drawing.Point(0, 25);
            this.gv_AnalogMessages.MultiSelect = false;
            this.gv_AnalogMessages.Name = "gv_AnalogMessages";
            this.gv_AnalogMessages.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_AnalogMessages.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gv_AnalogMessages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_AnalogMessages.RowTemplate.Height = 30;
            this.gv_AnalogMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_AnalogMessages.Size = new System.Drawing.Size(1247, 646);
            this.gv_AnalogMessages.Style = MetroFramework.MetroColorStyle.Red;
            this.gv_AnalogMessages.TabIndex = 1;
            this.gv_AnalogMessages.UseStyleColors = true;
            // 
            // uIAnPKDataGridViewTextBoxColumn
            // 
            this.uIAnPKDataGridViewTextBoxColumn.DataPropertyName = "UI_An_PK";
            this.uIAnPKDataGridViewTextBoxColumn.HeaderText = "UI_An_PK";
            this.uIAnPKDataGridViewTextBoxColumn.Name = "uIAnPKDataGridViewTextBoxColumn";
            this.uIAnPKDataGridViewTextBoxColumn.ReadOnly = true;
            this.uIAnPKDataGridViewTextBoxColumn.Visible = false;
            // 
            // uIAnSWCodeDataGridViewTextBoxColumn
            // 
            this.uIAnSWCodeDataGridViewTextBoxColumn.DataPropertyName = "UI_An_SW_Code";
            this.uIAnSWCodeDataGridViewTextBoxColumn.HeaderText = "UI_An_SW_Code";
            this.uIAnSWCodeDataGridViewTextBoxColumn.Name = "uIAnSWCodeDataGridViewTextBoxColumn";
            this.uIAnSWCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // uIAnProgrDataGridViewTextBoxColumn
            // 
            this.uIAnProgrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uIAnProgrDataGridViewTextBoxColumn.DataPropertyName = "UI_An_Progr";
            this.uIAnProgrDataGridViewTextBoxColumn.HeaderText = "# Bit";
            this.uIAnProgrDataGridViewTextBoxColumn.Name = "uIAnProgrDataGridViewTextBoxColumn";
            this.uIAnProgrDataGridViewTextBoxColumn.ToolTipText = "Il #bit da interrogare";
            this.uIAnProgrDataGridViewTextBoxColumn.Width = 49;
            // 
            // uIAnGroupDataGridViewTextBoxColumn
            // 
            this.uIAnGroupDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uIAnGroupDataGridViewTextBoxColumn.DataPropertyName = "UI_An_Group";
            this.uIAnGroupDataGridViewTextBoxColumn.HeaderText = "Descrizione Gruppo (o Valore unico)";
            this.uIAnGroupDataGridViewTextBoxColumn.Name = "uIAnGroupDataGridViewTextBoxColumn";
            this.uIAnGroupDataGridViewTextBoxColumn.ToolTipText = "Titolo del box da mostrare (Gruppo se vengono mostrati più valori)";
            this.uIAnGroupDataGridViewTextBoxColumn.Width = 89;
            // 
            // uIAnDescDataGridViewTextBoxColumn
            // 
            this.uIAnDescDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uIAnDescDataGridViewTextBoxColumn.DataPropertyName = "UI_An_Desc";
            this.uIAnDescDataGridViewTextBoxColumn.HeaderText = "Descrizione Valore";
            this.uIAnDescDataGridViewTextBoxColumn.Name = "uIAnDescDataGridViewTextBoxColumn";
            this.uIAnDescDataGridViewTextBoxColumn.ToolTipText = "Descrizione del valore visualizzato (quello che appare sull\'app)";
            this.uIAnDescDataGridViewTextBoxColumn.Width = 113;
            // 
            // uIAnDisplayOrderDataGridViewTextBoxColumn
            // 
            this.uIAnDisplayOrderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.uIAnDisplayOrderDataGridViewTextBoxColumn.DataPropertyName = "UI_An_DisplayOrder";
            this.uIAnDisplayOrderDataGridViewTextBoxColumn.HeaderText = "Ordine di visualizzazione";
            this.uIAnDisplayOrderDataGridViewTextBoxColumn.Name = "uIAnDisplayOrderDataGridViewTextBoxColumn";
            this.uIAnDisplayOrderDataGridViewTextBoxColumn.ToolTipText = "Se il numero dell\'ordinamento è uguale, definisce un gruppo";
            // 
            // uIAnDisplayOrderGroupElementsDataGridViewTextBoxColumn
            // 
            this.uIAnDisplayOrderGroupElementsDataGridViewTextBoxColumn.DataPropertyName = "UI_An_DisplayOrder_GroupElements";
            this.uIAnDisplayOrderGroupElementsDataGridViewTextBoxColumn.HeaderText = "Sotto-ordine di visualizzazione (all\'interno del gruppo)";
            this.uIAnDisplayOrderGroupElementsDataGridViewTextBoxColumn.Name = "uIAnDisplayOrderGroupElementsDataGridViewTextBoxColumn";
            this.uIAnDisplayOrderGroupElementsDataGridViewTextBoxColumn.ToolTipText = "Definisce l\'ordine di visualizzazione all\'interno del gruppo";
            this.uIAnDisplayOrderGroupElementsDataGridViewTextBoxColumn.Width = 150;
            // 
            // uIAnFormatDataGridViewTextBoxColumn
            // 
            this.uIAnFormatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uIAnFormatDataGridViewTextBoxColumn.DataPropertyName = "UI_An_Format";
            this.uIAnFormatDataGridViewTextBoxColumn.HeaderText = "Formato di visualizzazione";
            this.uIAnFormatDataGridViewTextBoxColumn.Name = "uIAnFormatDataGridViewTextBoxColumn";
            this.uIAnFormatDataGridViewTextBoxColumn.Width = 150;
            // 
            // uIAnUMDataGridViewTextBoxColumn
            // 
            this.uIAnUMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uIAnUMDataGridViewTextBoxColumn.DataPropertyName = "UI_An_UM";
            this.uIAnUMDataGridViewTextBoxColumn.HeaderText = "Unità di misura";
            this.uIAnUMDataGridViewTextBoxColumn.Name = "uIAnUMDataGridViewTextBoxColumn";
            this.uIAnUMDataGridViewTextBoxColumn.ToolTipText = "Visualizza l\'unità di misura di riferimento";
            this.uIAnUMDataGridViewTextBoxColumn.Width = 68;
            // 
            // uIAnMultiplierDataGridViewTextBoxColumn
            // 
            this.uIAnMultiplierDataGridViewTextBoxColumn.DataPropertyName = "UI_An_Multiplier";
            this.uIAnMultiplierDataGridViewTextBoxColumn.HeaderText = "Moltiplicatore da utilizzare";
            this.uIAnMultiplierDataGridViewTextBoxColumn.Name = "uIAnMultiplierDataGridViewTextBoxColumn";
            // 
            // CBUI_An_Icon_Name
            // 
            this.CBUI_An_Icon_Name.DataPropertyName = "UI_An_Icon_Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CBUI_An_Icon_Name.DefaultCellStyle = dataGridViewCellStyle3;
            this.CBUI_An_Icon_Name.HeaderText = "Icona";
            this.CBUI_An_Icon_Name.Name = "CBUI_An_Icon_Name";
            // 
            // uIAnIconNameDataGridViewTextBoxColumn
            // 
            this.uIAnIconNameDataGridViewTextBoxColumn.DataPropertyName = "UI_An_Icon_Name";
            this.uIAnIconNameDataGridViewTextBoxColumn.HeaderText = "UI_An_Icon_Name";
            this.uIAnIconNameDataGridViewTextBoxColumn.Name = "uIAnIconNameDataGridViewTextBoxColumn";
            this.uIAnIconNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // uIAnMinValueDataGridViewTextBoxColumn
            // 
            this.uIAnMinValueDataGridViewTextBoxColumn.DataPropertyName = "UI_An_Min_Value";
            this.uIAnMinValueDataGridViewTextBoxColumn.HeaderText = "UI_An_Min_Value";
            this.uIAnMinValueDataGridViewTextBoxColumn.Name = "uIAnMinValueDataGridViewTextBoxColumn";
            // 
            // uIAnMaxValueDataGridViewTextBoxColumn
            // 
            this.uIAnMaxValueDataGridViewTextBoxColumn.DataPropertyName = "UI_An_Max_Value";
            this.uIAnMaxValueDataGridViewTextBoxColumn.HeaderText = "UI_An_Max_Value";
            this.uIAnMaxValueDataGridViewTextBoxColumn.Name = "uIAnMaxValueDataGridViewTextBoxColumn";
            // 
            // uIAnRefDgAlarmDataGridViewTextBoxColumn
            // 
            this.uIAnRefDgAlarmDataGridViewTextBoxColumn.DataPropertyName = "UI_An_Ref_Dg_Alarm";
            this.uIAnRefDgAlarmDataGridViewTextBoxColumn.HeaderText = "UI_An_Ref_Dg_Alarm";
            this.uIAnRefDgAlarmDataGridViewTextBoxColumn.Name = "uIAnRefDgAlarmDataGridViewTextBoxColumn";
            // 
            // uIAnThresholdDesDataGridViewTextBoxColumn
            // 
            this.uIAnThresholdDesDataGridViewTextBoxColumn.DataPropertyName = "UI_An_Threshold_Des";
            this.uIAnThresholdDesDataGridViewTextBoxColumn.HeaderText = "UI_An_Threshold_Des";
            this.uIAnThresholdDesDataGridViewTextBoxColumn.Name = "uIAnThresholdDesDataGridViewTextBoxColumn";
            // 
            // uIAnObsoleteDataGridViewCheckBoxColumn
            // 
            this.uIAnObsoleteDataGridViewCheckBoxColumn.DataPropertyName = "UI_An_Obsolete";
            this.uIAnObsoleteDataGridViewCheckBoxColumn.HeaderText = "UI_An_Obsolete";
            this.uIAnObsoleteDataGridViewCheckBoxColumn.Name = "uIAnObsoleteDataGridViewCheckBoxColumn";
            // 
            // firmwareUIAnalogMessagesBindingSource
            // 
            this.firmwareUIAnalogMessagesBindingSource.DataMember = "Firmware_UI_Analog_Messages";
            this.firmwareUIAnalogMessagesBindingSource.DataSource = this.firmwareBindingSource;
            this.firmwareUIAnalogMessagesBindingSource.Sort = "UI_An_Progr asc";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Controls.Add(this.but_Preview, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1247, 25);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // but_Preview
            // 
            this.but_Preview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_Preview.BackgroundImage")));
            this.but_Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_Preview.Location = new System.Drawing.Point(778, 3);
            this.but_Preview.Name = "but_Preview";
            this.but_Preview.Size = new System.Drawing.Size(149, 19);
            this.but_Preview.Style = MetroFramework.MetroColorStyle.Red;
            this.but_Preview.TabIndex = 0;
            this.but_Preview.Text = "Anteprima";
            this.but_Preview.UseSelectable = true;
            this.but_Preview.UseStyleColors = true;
            this.but_Preview.Click += new System.EventHandler(this.but_Preview_Click);
            // 
            // tab_Digital
            // 
            this.tab_Digital.Controls.Add(this.panel_digital_messages);
            this.tab_Digital.Name = "tab_Digital";
            this.tab_Digital.Size = new System.Drawing.Size(1247, 671);
            this.tab_Digital.Text = "Digital messages";
            // 
            // panel_digital_messages
            // 
            this.panel_digital_messages.Controls.Add(this.cb_15_icon_1);
            this.panel_digital_messages.Controls.Add(this.cb_14_icon_1);
            this.panel_digital_messages.Controls.Add(this.cb_13_icon_1);
            this.panel_digital_messages.Controls.Add(this.cb_12_icon_1);
            this.panel_digital_messages.Controls.Add(this.cb_11_icon_1);
            this.panel_digital_messages.Controls.Add(this.cb_10_icon_1);
            this.panel_digital_messages.Controls.Add(this.cb_09_icon_1);
            this.panel_digital_messages.Controls.Add(this.cb_08_icon_1);
            this.panel_digital_messages.Controls.Add(this.cb_07_icon_1);
            this.panel_digital_messages.Controls.Add(this.cb_06_icon_1);
            this.panel_digital_messages.Controls.Add(this.cb_05_icon_1);
            this.panel_digital_messages.Controls.Add(this.cb_04_icon_1);
            this.panel_digital_messages.Controls.Add(this.cb_03_icon_1);
            this.panel_digital_messages.Controls.Add(this.cb_02_icon_1);
            this.panel_digital_messages.Controls.Add(this.cb_01_icon_1);
            this.panel_digital_messages.Controls.Add(this.cb_00_icon_1);
            this.panel_digital_messages.Controls.Add(this.cb_15_icon_0);
            this.panel_digital_messages.Controls.Add(this.cb_14_icon_0);
            this.panel_digital_messages.Controls.Add(this.cb_13_icon_0);
            this.panel_digital_messages.Controls.Add(this.cb_12_icon_0);
            this.panel_digital_messages.Controls.Add(this.cb_11_icon_0);
            this.panel_digital_messages.Controls.Add(this.cb_10_icon_0);
            this.panel_digital_messages.Controls.Add(this.cb_09_icon_0);
            this.panel_digital_messages.Controls.Add(this.cb_08_icon_0);
            this.panel_digital_messages.Controls.Add(this.cb_07_icon_0);
            this.panel_digital_messages.Controls.Add(this.cb_06_icon_0);
            this.panel_digital_messages.Controls.Add(this.cb_05_icon_0);
            this.panel_digital_messages.Controls.Add(this.cb_04_icon_0);
            this.panel_digital_messages.Controls.Add(this.cb_03_icon_0);
            this.panel_digital_messages.Controls.Add(this.cb_02_icon_0);
            this.panel_digital_messages.Controls.Add(this.cb_01_icon_0);
            this.panel_digital_messages.Controls.Add(this.cb_00_icon_0);
            this.panel_digital_messages.Controls.Add(this.Rif_val_15);
            this.panel_digital_messages.Controls.Add(this.Rif_val_14);
            this.panel_digital_messages.Controls.Add(this.Rif_val_13);
            this.panel_digital_messages.Controls.Add(this.Rif_val_12);
            this.panel_digital_messages.Controls.Add(this.Rif_val_11);
            this.panel_digital_messages.Controls.Add(this.Rif_val_10);
            this.panel_digital_messages.Controls.Add(this.Rif_val_09);
            this.panel_digital_messages.Controls.Add(this.Rif_val_08);
            this.panel_digital_messages.Controls.Add(this.Rif_val_07);
            this.panel_digital_messages.Controls.Add(this.Rif_val_06);
            this.panel_digital_messages.Controls.Add(this.Rif_val_05);
            this.panel_digital_messages.Controls.Add(this.Rif_val_04);
            this.panel_digital_messages.Controls.Add(this.Rif_val_03);
            this.panel_digital_messages.Controls.Add(this.Rif_val_02);
            this.panel_digital_messages.Controls.Add(this.Rif_val_01);
            this.panel_digital_messages.Controls.Add(this.Rif_val_00);
            this.panel_digital_messages.Controls.Add(this.metroLabel24);
            this.panel_digital_messages.Controls.Add(this.pictureBox15);
            this.panel_digital_messages.Controls.Add(this.pictureBox11);
            this.panel_digital_messages.Controls.Add(this.pictureBox12);
            this.panel_digital_messages.Controls.Add(this.pictureBox13);
            this.panel_digital_messages.Controls.Add(this.pictureBox14);
            this.panel_digital_messages.Controls.Add(this.pictureBox7);
            this.panel_digital_messages.Controls.Add(this.pictureBox8);
            this.panel_digital_messages.Controls.Add(this.pictureBox9);
            this.panel_digital_messages.Controls.Add(this.pictureBox10);
            this.panel_digital_messages.Controls.Add(this.pictureBox6);
            this.panel_digital_messages.Controls.Add(this.pictureBox5);
            this.panel_digital_messages.Controls.Add(this.pictureBox4);
            this.panel_digital_messages.Controls.Add(this.pictureBox3);
            this.panel_digital_messages.Controls.Add(this.pictureBox2);
            this.panel_digital_messages.Controls.Add(this.pictureBox1);
            this.panel_digital_messages.Controls.Add(this.metroLabel23);
            this.panel_digital_messages.Controls.Add(this.metroLabel22);
            this.panel_digital_messages.Controls.Add(this.metroTextBox30);
            this.panel_digital_messages.Controls.Add(this.metroTextBox31);
            this.panel_digital_messages.Controls.Add(this.metroTextBox28);
            this.panel_digital_messages.Controls.Add(this.metroTextBox29);
            this.panel_digital_messages.Controls.Add(this.metroTextBox26);
            this.panel_digital_messages.Controls.Add(this.metroTextBox27);
            this.panel_digital_messages.Controls.Add(this.metroTextBox24);
            this.panel_digital_messages.Controls.Add(this.metroTextBox25);
            this.panel_digital_messages.Controls.Add(this.metroTextBox22);
            this.panel_digital_messages.Controls.Add(this.metroTextBox23);
            this.panel_digital_messages.Controls.Add(this.metroTextBox20);
            this.panel_digital_messages.Controls.Add(this.metroTextBox21);
            this.panel_digital_messages.Controls.Add(this.metroTextBox18);
            this.panel_digital_messages.Controls.Add(this.metroTextBox19);
            this.panel_digital_messages.Controls.Add(this.metroTextBox16);
            this.panel_digital_messages.Controls.Add(this.metroTextBox17);
            this.panel_digital_messages.Controls.Add(this.metroTextBox14);
            this.panel_digital_messages.Controls.Add(this.metroTextBox15);
            this.panel_digital_messages.Controls.Add(this.metroTextBox12);
            this.panel_digital_messages.Controls.Add(this.metroTextBox13);
            this.panel_digital_messages.Controls.Add(this.metroTextBox10);
            this.panel_digital_messages.Controls.Add(this.metroTextBox11);
            this.panel_digital_messages.Controls.Add(this.metroTextBox8);
            this.panel_digital_messages.Controls.Add(this.metroTextBox9);
            this.panel_digital_messages.Controls.Add(this.metroTextBox6);
            this.panel_digital_messages.Controls.Add(this.metroTextBox7);
            this.panel_digital_messages.Controls.Add(this.metroTextBox4);
            this.panel_digital_messages.Controls.Add(this.metroTextBox5);
            this.panel_digital_messages.Controls.Add(this.metroTextBox2);
            this.panel_digital_messages.Controls.Add(this.metroTextBox3);
            this.panel_digital_messages.Controls.Add(this.metroTextBox1);
            this.panel_digital_messages.Controls.Add(this.metroLabel21);
            this.panel_digital_messages.Controls.Add(this.metroLabel20);
            this.panel_digital_messages.Controls.Add(this.metroCheckBox16);
            this.panel_digital_messages.Controls.Add(this.metroCheckBox15);
            this.panel_digital_messages.Controls.Add(this.metroCheckBox14);
            this.panel_digital_messages.Controls.Add(this.metroCheckBox13);
            this.panel_digital_messages.Controls.Add(this.metroCheckBox12);
            this.panel_digital_messages.Controls.Add(this.metroCheckBox11);
            this.panel_digital_messages.Controls.Add(this.metroCheckBox10);
            this.panel_digital_messages.Controls.Add(this.metroCheckBox9);
            this.panel_digital_messages.Controls.Add(this.metroCheckBox8);
            this.panel_digital_messages.Controls.Add(this.metroCheckBox7);
            this.panel_digital_messages.Controls.Add(this.metroCheckBox6);
            this.panel_digital_messages.Controls.Add(this.metroCheckBox5);
            this.panel_digital_messages.Controls.Add(this.metroCheckBox4);
            this.panel_digital_messages.Controls.Add(this.metroCheckBox3);
            this.panel_digital_messages.Controls.Add(this.metroCheckBox1);
            this.panel_digital_messages.Controls.Add(this.metroCheckBox2);
            this.panel_digital_messages.Controls.Add(this.metroLabel19);
            this.panel_digital_messages.Controls.Add(this.metroLabel18);
            this.panel_digital_messages.Controls.Add(this.metroLabel17);
            this.panel_digital_messages.Controls.Add(this.metroLabel16);
            this.panel_digital_messages.Controls.Add(this.metroLabel15);
            this.panel_digital_messages.Controls.Add(this.metroLabel14);
            this.panel_digital_messages.Controls.Add(this.metroLabel13);
            this.panel_digital_messages.Controls.Add(this.metroLabel12);
            this.panel_digital_messages.Controls.Add(this.metroLabel10);
            this.panel_digital_messages.Controls.Add(this.metroLabel9);
            this.panel_digital_messages.Controls.Add(this.metroLabel8);
            this.panel_digital_messages.Controls.Add(this.metroLabel7);
            this.panel_digital_messages.Controls.Add(this.metroLabel6);
            this.panel_digital_messages.Controls.Add(this.metroLabel5);
            this.panel_digital_messages.Controls.Add(this.metroLabel4);
            this.panel_digital_messages.Controls.Add(this.metroLabel3);
            this.panel_digital_messages.Controls.Add(this.metroLabel2);
            this.panel_digital_messages.Controls.Add(this.tb_gv_Code);
            this.panel_digital_messages.Controls.Add(this.metroLabel1);
            this.panel_digital_messages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_digital_messages.HorizontalScrollbarBarColor = true;
            this.panel_digital_messages.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_digital_messages.HorizontalScrollbarSize = 10;
            this.panel_digital_messages.Location = new System.Drawing.Point(0, 0);
            this.panel_digital_messages.Name = "panel_digital_messages";
            this.panel_digital_messages.Size = new System.Drawing.Size(1247, 671);
            this.panel_digital_messages.TabIndex = 3;
            this.panel_digital_messages.VerticalScrollbarBarColor = true;
            this.panel_digital_messages.VerticalScrollbarHighlightOnWheel = false;
            this.panel_digital_messages.VerticalScrollbarSize = 10;
            // 
            // cb_15_icon_1
            // 
            this.cb_15_icon_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_15_icon_1.FormattingEnabled = true;
            this.cb_15_icon_1.Location = new System.Drawing.Point(855, 486);
            this.cb_15_icon_1.Name = "cb_15_icon_1";
            this.cb_15_icon_1.Size = new System.Drawing.Size(170, 23);
            this.cb_15_icon_1.TabIndex = 245;
            // 
            // cb_14_icon_1
            // 
            this.cb_14_icon_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_14_icon_1.FormattingEnabled = true;
            this.cb_14_icon_1.Location = new System.Drawing.Point(855, 456);
            this.cb_14_icon_1.Name = "cb_14_icon_1";
            this.cb_14_icon_1.Size = new System.Drawing.Size(170, 23);
            this.cb_14_icon_1.TabIndex = 244;
            // 
            // cb_13_icon_1
            // 
            this.cb_13_icon_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_13_icon_1.FormattingEnabled = true;
            this.cb_13_icon_1.Location = new System.Drawing.Point(855, 426);
            this.cb_13_icon_1.Name = "cb_13_icon_1";
            this.cb_13_icon_1.Size = new System.Drawing.Size(170, 23);
            this.cb_13_icon_1.TabIndex = 243;
            // 
            // cb_12_icon_1
            // 
            this.cb_12_icon_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_12_icon_1.FormattingEnabled = true;
            this.cb_12_icon_1.Location = new System.Drawing.Point(855, 396);
            this.cb_12_icon_1.Name = "cb_12_icon_1";
            this.cb_12_icon_1.Size = new System.Drawing.Size(170, 23);
            this.cb_12_icon_1.TabIndex = 242;
            // 
            // cb_11_icon_1
            // 
            this.cb_11_icon_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_11_icon_1.FormattingEnabled = true;
            this.cb_11_icon_1.Location = new System.Drawing.Point(855, 366);
            this.cb_11_icon_1.Name = "cb_11_icon_1";
            this.cb_11_icon_1.Size = new System.Drawing.Size(170, 23);
            this.cb_11_icon_1.TabIndex = 241;
            // 
            // cb_10_icon_1
            // 
            this.cb_10_icon_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_10_icon_1.FormattingEnabled = true;
            this.cb_10_icon_1.Location = new System.Drawing.Point(855, 336);
            this.cb_10_icon_1.Name = "cb_10_icon_1";
            this.cb_10_icon_1.Size = new System.Drawing.Size(170, 23);
            this.cb_10_icon_1.TabIndex = 240;
            // 
            // cb_09_icon_1
            // 
            this.cb_09_icon_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_09_icon_1.FormattingEnabled = true;
            this.cb_09_icon_1.Location = new System.Drawing.Point(855, 306);
            this.cb_09_icon_1.Name = "cb_09_icon_1";
            this.cb_09_icon_1.Size = new System.Drawing.Size(170, 23);
            this.cb_09_icon_1.TabIndex = 239;
            // 
            // cb_08_icon_1
            // 
            this.cb_08_icon_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_08_icon_1.FormattingEnabled = true;
            this.cb_08_icon_1.Location = new System.Drawing.Point(855, 276);
            this.cb_08_icon_1.Name = "cb_08_icon_1";
            this.cb_08_icon_1.Size = new System.Drawing.Size(170, 23);
            this.cb_08_icon_1.TabIndex = 238;
            // 
            // cb_07_icon_1
            // 
            this.cb_07_icon_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_07_icon_1.FormattingEnabled = true;
            this.cb_07_icon_1.Location = new System.Drawing.Point(855, 246);
            this.cb_07_icon_1.Name = "cb_07_icon_1";
            this.cb_07_icon_1.Size = new System.Drawing.Size(170, 23);
            this.cb_07_icon_1.TabIndex = 237;
            // 
            // cb_06_icon_1
            // 
            this.cb_06_icon_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_06_icon_1.FormattingEnabled = true;
            this.cb_06_icon_1.Location = new System.Drawing.Point(855, 216);
            this.cb_06_icon_1.Name = "cb_06_icon_1";
            this.cb_06_icon_1.Size = new System.Drawing.Size(170, 23);
            this.cb_06_icon_1.TabIndex = 236;
            // 
            // cb_05_icon_1
            // 
            this.cb_05_icon_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_05_icon_1.FormattingEnabled = true;
            this.cb_05_icon_1.Location = new System.Drawing.Point(855, 186);
            this.cb_05_icon_1.Name = "cb_05_icon_1";
            this.cb_05_icon_1.Size = new System.Drawing.Size(170, 23);
            this.cb_05_icon_1.TabIndex = 235;
            // 
            // cb_04_icon_1
            // 
            this.cb_04_icon_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_04_icon_1.FormattingEnabled = true;
            this.cb_04_icon_1.Location = new System.Drawing.Point(855, 156);
            this.cb_04_icon_1.Name = "cb_04_icon_1";
            this.cb_04_icon_1.Size = new System.Drawing.Size(170, 23);
            this.cb_04_icon_1.TabIndex = 234;
            // 
            // cb_03_icon_1
            // 
            this.cb_03_icon_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_03_icon_1.FormattingEnabled = true;
            this.cb_03_icon_1.Location = new System.Drawing.Point(855, 126);
            this.cb_03_icon_1.Name = "cb_03_icon_1";
            this.cb_03_icon_1.Size = new System.Drawing.Size(170, 23);
            this.cb_03_icon_1.TabIndex = 233;
            // 
            // cb_02_icon_1
            // 
            this.cb_02_icon_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_02_icon_1.FormattingEnabled = true;
            this.cb_02_icon_1.Location = new System.Drawing.Point(855, 96);
            this.cb_02_icon_1.Name = "cb_02_icon_1";
            this.cb_02_icon_1.Size = new System.Drawing.Size(170, 23);
            this.cb_02_icon_1.TabIndex = 232;
            // 
            // cb_01_icon_1
            // 
            this.cb_01_icon_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_01_icon_1.FormattingEnabled = true;
            this.cb_01_icon_1.Location = new System.Drawing.Point(855, 66);
            this.cb_01_icon_1.Name = "cb_01_icon_1";
            this.cb_01_icon_1.Size = new System.Drawing.Size(170, 23);
            this.cb_01_icon_1.TabIndex = 231;
            // 
            // cb_00_icon_1
            // 
            this.cb_00_icon_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_00_icon_1.FormattingEnabled = true;
            this.cb_00_icon_1.Location = new System.Drawing.Point(855, 36);
            this.cb_00_icon_1.Name = "cb_00_icon_1";
            this.cb_00_icon_1.Size = new System.Drawing.Size(170, 23);
            this.cb_00_icon_1.TabIndex = 230;
            // 
            // cb_15_icon_0
            // 
            this.cb_15_icon_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_15_icon_0.FormattingEnabled = true;
            this.cb_15_icon_0.Location = new System.Drawing.Point(679, 486);
            this.cb_15_icon_0.Name = "cb_15_icon_0";
            this.cb_15_icon_0.Size = new System.Drawing.Size(170, 23);
            this.cb_15_icon_0.TabIndex = 229;
            // 
            // cb_14_icon_0
            // 
            this.cb_14_icon_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_14_icon_0.FormattingEnabled = true;
            this.cb_14_icon_0.Location = new System.Drawing.Point(679, 456);
            this.cb_14_icon_0.Name = "cb_14_icon_0";
            this.cb_14_icon_0.Size = new System.Drawing.Size(170, 23);
            this.cb_14_icon_0.TabIndex = 228;
            // 
            // cb_13_icon_0
            // 
            this.cb_13_icon_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_13_icon_0.FormattingEnabled = true;
            this.cb_13_icon_0.Location = new System.Drawing.Point(679, 426);
            this.cb_13_icon_0.Name = "cb_13_icon_0";
            this.cb_13_icon_0.Size = new System.Drawing.Size(170, 23);
            this.cb_13_icon_0.TabIndex = 227;
            // 
            // cb_12_icon_0
            // 
            this.cb_12_icon_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_12_icon_0.FormattingEnabled = true;
            this.cb_12_icon_0.Location = new System.Drawing.Point(679, 396);
            this.cb_12_icon_0.Name = "cb_12_icon_0";
            this.cb_12_icon_0.Size = new System.Drawing.Size(170, 23);
            this.cb_12_icon_0.TabIndex = 226;
            // 
            // cb_11_icon_0
            // 
            this.cb_11_icon_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_11_icon_0.FormattingEnabled = true;
            this.cb_11_icon_0.Location = new System.Drawing.Point(679, 366);
            this.cb_11_icon_0.Name = "cb_11_icon_0";
            this.cb_11_icon_0.Size = new System.Drawing.Size(170, 23);
            this.cb_11_icon_0.TabIndex = 225;
            // 
            // cb_10_icon_0
            // 
            this.cb_10_icon_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_10_icon_0.FormattingEnabled = true;
            this.cb_10_icon_0.Location = new System.Drawing.Point(679, 336);
            this.cb_10_icon_0.Name = "cb_10_icon_0";
            this.cb_10_icon_0.Size = new System.Drawing.Size(170, 23);
            this.cb_10_icon_0.TabIndex = 224;
            // 
            // cb_09_icon_0
            // 
            this.cb_09_icon_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_09_icon_0.FormattingEnabled = true;
            this.cb_09_icon_0.Location = new System.Drawing.Point(679, 306);
            this.cb_09_icon_0.Name = "cb_09_icon_0";
            this.cb_09_icon_0.Size = new System.Drawing.Size(170, 23);
            this.cb_09_icon_0.TabIndex = 223;
            // 
            // cb_08_icon_0
            // 
            this.cb_08_icon_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_08_icon_0.FormattingEnabled = true;
            this.cb_08_icon_0.Location = new System.Drawing.Point(679, 276);
            this.cb_08_icon_0.Name = "cb_08_icon_0";
            this.cb_08_icon_0.Size = new System.Drawing.Size(170, 23);
            this.cb_08_icon_0.TabIndex = 222;
            // 
            // cb_07_icon_0
            // 
            this.cb_07_icon_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_07_icon_0.FormattingEnabled = true;
            this.cb_07_icon_0.Location = new System.Drawing.Point(679, 246);
            this.cb_07_icon_0.Name = "cb_07_icon_0";
            this.cb_07_icon_0.Size = new System.Drawing.Size(170, 23);
            this.cb_07_icon_0.TabIndex = 221;
            // 
            // cb_06_icon_0
            // 
            this.cb_06_icon_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_06_icon_0.FormattingEnabled = true;
            this.cb_06_icon_0.Location = new System.Drawing.Point(679, 216);
            this.cb_06_icon_0.Name = "cb_06_icon_0";
            this.cb_06_icon_0.Size = new System.Drawing.Size(170, 23);
            this.cb_06_icon_0.TabIndex = 220;
            // 
            // cb_05_icon_0
            // 
            this.cb_05_icon_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_05_icon_0.FormattingEnabled = true;
            this.cb_05_icon_0.Location = new System.Drawing.Point(679, 186);
            this.cb_05_icon_0.Name = "cb_05_icon_0";
            this.cb_05_icon_0.Size = new System.Drawing.Size(170, 23);
            this.cb_05_icon_0.TabIndex = 219;
            // 
            // cb_04_icon_0
            // 
            this.cb_04_icon_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_04_icon_0.FormattingEnabled = true;
            this.cb_04_icon_0.Location = new System.Drawing.Point(679, 156);
            this.cb_04_icon_0.Name = "cb_04_icon_0";
            this.cb_04_icon_0.Size = new System.Drawing.Size(170, 23);
            this.cb_04_icon_0.TabIndex = 218;
            // 
            // cb_03_icon_0
            // 
            this.cb_03_icon_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_03_icon_0.FormattingEnabled = true;
            this.cb_03_icon_0.Location = new System.Drawing.Point(679, 126);
            this.cb_03_icon_0.Name = "cb_03_icon_0";
            this.cb_03_icon_0.Size = new System.Drawing.Size(170, 23);
            this.cb_03_icon_0.TabIndex = 217;
            // 
            // cb_02_icon_0
            // 
            this.cb_02_icon_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_02_icon_0.FormattingEnabled = true;
            this.cb_02_icon_0.Location = new System.Drawing.Point(679, 96);
            this.cb_02_icon_0.Name = "cb_02_icon_0";
            this.cb_02_icon_0.Size = new System.Drawing.Size(170, 23);
            this.cb_02_icon_0.TabIndex = 216;
            // 
            // cb_01_icon_0
            // 
            this.cb_01_icon_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_01_icon_0.FormattingEnabled = true;
            this.cb_01_icon_0.Location = new System.Drawing.Point(679, 66);
            this.cb_01_icon_0.Name = "cb_01_icon_0";
            this.cb_01_icon_0.Size = new System.Drawing.Size(170, 23);
            this.cb_01_icon_0.TabIndex = 215;
            // 
            // cb_00_icon_0
            // 
            this.cb_00_icon_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_00_icon_0.FormattingEnabled = true;
            this.cb_00_icon_0.Location = new System.Drawing.Point(679, 36);
            this.cb_00_icon_0.Name = "cb_00_icon_0";
            this.cb_00_icon_0.Size = new System.Drawing.Size(170, 23);
            this.cb_00_icon_0.TabIndex = 214;
            // 
            // Rif_val_15
            // 
            // 
            // 
            // 
            this.Rif_val_15.CustomButton.Image = null;
            this.Rif_val_15.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Rif_val_15.CustomButton.Name = "";
            this.Rif_val_15.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rif_val_15.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rif_val_15.CustomButton.TabIndex = 1;
            this.Rif_val_15.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rif_val_15.CustomButton.UseSelectable = true;
            this.Rif_val_15.CustomButton.Visible = false;
            this.Rif_val_15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_15_Ref_An_Value", true));
            this.Rif_val_15.Lines = new string[] {
        " "};
            this.Rif_val_15.Location = new System.Drawing.Point(1069, 485);
            this.Rif_val_15.MaxLength = 32767;
            this.Rif_val_15.Name = "Rif_val_15";
            this.Rif_val_15.PasswordChar = '\0';
            this.Rif_val_15.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rif_val_15.SelectedText = "";
            this.Rif_val_15.SelectionLength = 0;
            this.Rif_val_15.SelectionStart = 0;
            this.Rif_val_15.ShortcutsEnabled = true;
            this.Rif_val_15.Size = new System.Drawing.Size(40, 23);
            this.Rif_val_15.Style = MetroFramework.MetroColorStyle.Red;
            this.Rif_val_15.TabIndex = 212;
            this.Rif_val_15.Text = " ";
            this.Rif_val_15.UseSelectable = true;
            this.Rif_val_15.UseStyleColors = true;
            this.Rif_val_15.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rif_val_15.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // firmwareUIDigitalMessagesBindingSource
            // 
            this.firmwareUIDigitalMessagesBindingSource.DataMember = "Firmware_UI_Digital_Messages";
            this.firmwareUIDigitalMessagesBindingSource.DataSource = this.firmwareBindingSource;
            this.firmwareUIDigitalMessagesBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.firmwareUIDigitalMessagesBindingSource_ListChanged);
            // 
            // Rif_val_14
            // 
            // 
            // 
            // 
            this.Rif_val_14.CustomButton.Image = null;
            this.Rif_val_14.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Rif_val_14.CustomButton.Name = "";
            this.Rif_val_14.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rif_val_14.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rif_val_14.CustomButton.TabIndex = 1;
            this.Rif_val_14.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rif_val_14.CustomButton.UseSelectable = true;
            this.Rif_val_14.CustomButton.Visible = false;
            this.Rif_val_14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_14_Ref_An_Value", true));
            this.Rif_val_14.Lines = new string[] {
        " "};
            this.Rif_val_14.Location = new System.Drawing.Point(1069, 456);
            this.Rif_val_14.MaxLength = 32767;
            this.Rif_val_14.Name = "Rif_val_14";
            this.Rif_val_14.PasswordChar = '\0';
            this.Rif_val_14.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rif_val_14.SelectedText = "";
            this.Rif_val_14.SelectionLength = 0;
            this.Rif_val_14.SelectionStart = 0;
            this.Rif_val_14.ShortcutsEnabled = true;
            this.Rif_val_14.Size = new System.Drawing.Size(40, 23);
            this.Rif_val_14.Style = MetroFramework.MetroColorStyle.Red;
            this.Rif_val_14.TabIndex = 213;
            this.Rif_val_14.Text = " ";
            this.Rif_val_14.UseSelectable = true;
            this.Rif_val_14.UseStyleColors = true;
            this.Rif_val_14.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rif_val_14.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rif_val_13
            // 
            // 
            // 
            // 
            this.Rif_val_13.CustomButton.Image = null;
            this.Rif_val_13.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Rif_val_13.CustomButton.Name = "";
            this.Rif_val_13.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rif_val_13.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rif_val_13.CustomButton.TabIndex = 1;
            this.Rif_val_13.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rif_val_13.CustomButton.UseSelectable = true;
            this.Rif_val_13.CustomButton.Visible = false;
            this.Rif_val_13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_13_Ref_An_Value", true));
            this.Rif_val_13.Lines = new string[] {
        " "};
            this.Rif_val_13.Location = new System.Drawing.Point(1069, 426);
            this.Rif_val_13.MaxLength = 32767;
            this.Rif_val_13.Name = "Rif_val_13";
            this.Rif_val_13.PasswordChar = '\0';
            this.Rif_val_13.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rif_val_13.SelectedText = "";
            this.Rif_val_13.SelectionLength = 0;
            this.Rif_val_13.SelectionStart = 0;
            this.Rif_val_13.ShortcutsEnabled = true;
            this.Rif_val_13.Size = new System.Drawing.Size(40, 23);
            this.Rif_val_13.Style = MetroFramework.MetroColorStyle.Red;
            this.Rif_val_13.TabIndex = 211;
            this.Rif_val_13.Text = " ";
            this.Rif_val_13.UseSelectable = true;
            this.Rif_val_13.UseStyleColors = true;
            this.Rif_val_13.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rif_val_13.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rif_val_12
            // 
            // 
            // 
            // 
            this.Rif_val_12.CustomButton.Image = null;
            this.Rif_val_12.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Rif_val_12.CustomButton.Name = "";
            this.Rif_val_12.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rif_val_12.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rif_val_12.CustomButton.TabIndex = 1;
            this.Rif_val_12.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rif_val_12.CustomButton.UseSelectable = true;
            this.Rif_val_12.CustomButton.Visible = false;
            this.Rif_val_12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_12_Ref_An_Value", true));
            this.Rif_val_12.Lines = new string[] {
        " "};
            this.Rif_val_12.Location = new System.Drawing.Point(1069, 396);
            this.Rif_val_12.MaxLength = 32767;
            this.Rif_val_12.Name = "Rif_val_12";
            this.Rif_val_12.PasswordChar = '\0';
            this.Rif_val_12.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rif_val_12.SelectedText = "";
            this.Rif_val_12.SelectionLength = 0;
            this.Rif_val_12.SelectionStart = 0;
            this.Rif_val_12.ShortcutsEnabled = true;
            this.Rif_val_12.Size = new System.Drawing.Size(40, 23);
            this.Rif_val_12.Style = MetroFramework.MetroColorStyle.Red;
            this.Rif_val_12.TabIndex = 210;
            this.Rif_val_12.Text = " ";
            this.Rif_val_12.UseSelectable = true;
            this.Rif_val_12.UseStyleColors = true;
            this.Rif_val_12.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rif_val_12.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rif_val_11
            // 
            // 
            // 
            // 
            this.Rif_val_11.CustomButton.Image = null;
            this.Rif_val_11.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Rif_val_11.CustomButton.Name = "";
            this.Rif_val_11.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rif_val_11.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rif_val_11.CustomButton.TabIndex = 1;
            this.Rif_val_11.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rif_val_11.CustomButton.UseSelectable = true;
            this.Rif_val_11.CustomButton.Visible = false;
            this.Rif_val_11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_11_Ref_An_Value", true));
            this.Rif_val_11.Lines = new string[] {
        " "};
            this.Rif_val_11.Location = new System.Drawing.Point(1069, 366);
            this.Rif_val_11.MaxLength = 32767;
            this.Rif_val_11.Name = "Rif_val_11";
            this.Rif_val_11.PasswordChar = '\0';
            this.Rif_val_11.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rif_val_11.SelectedText = "";
            this.Rif_val_11.SelectionLength = 0;
            this.Rif_val_11.SelectionStart = 0;
            this.Rif_val_11.ShortcutsEnabled = true;
            this.Rif_val_11.Size = new System.Drawing.Size(40, 23);
            this.Rif_val_11.Style = MetroFramework.MetroColorStyle.Red;
            this.Rif_val_11.TabIndex = 209;
            this.Rif_val_11.Text = " ";
            this.Rif_val_11.UseSelectable = true;
            this.Rif_val_11.UseStyleColors = true;
            this.Rif_val_11.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rif_val_11.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rif_val_10
            // 
            // 
            // 
            // 
            this.Rif_val_10.CustomButton.Image = null;
            this.Rif_val_10.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Rif_val_10.CustomButton.Name = "";
            this.Rif_val_10.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rif_val_10.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rif_val_10.CustomButton.TabIndex = 1;
            this.Rif_val_10.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rif_val_10.CustomButton.UseSelectable = true;
            this.Rif_val_10.CustomButton.Visible = false;
            this.Rif_val_10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_10_Ref_An_Value", true));
            this.Rif_val_10.Lines = new string[] {
        " "};
            this.Rif_val_10.Location = new System.Drawing.Point(1069, 336);
            this.Rif_val_10.MaxLength = 32767;
            this.Rif_val_10.Name = "Rif_val_10";
            this.Rif_val_10.PasswordChar = '\0';
            this.Rif_val_10.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rif_val_10.SelectedText = "";
            this.Rif_val_10.SelectionLength = 0;
            this.Rif_val_10.SelectionStart = 0;
            this.Rif_val_10.ShortcutsEnabled = true;
            this.Rif_val_10.Size = new System.Drawing.Size(40, 23);
            this.Rif_val_10.Style = MetroFramework.MetroColorStyle.Red;
            this.Rif_val_10.TabIndex = 208;
            this.Rif_val_10.Text = " ";
            this.Rif_val_10.UseSelectable = true;
            this.Rif_val_10.UseStyleColors = true;
            this.Rif_val_10.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rif_val_10.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rif_val_09
            // 
            // 
            // 
            // 
            this.Rif_val_09.CustomButton.Image = null;
            this.Rif_val_09.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Rif_val_09.CustomButton.Name = "";
            this.Rif_val_09.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rif_val_09.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rif_val_09.CustomButton.TabIndex = 1;
            this.Rif_val_09.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rif_val_09.CustomButton.UseSelectable = true;
            this.Rif_val_09.CustomButton.Visible = false;
            this.Rif_val_09.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_09_Ref_An_Value", true));
            this.Rif_val_09.Lines = new string[] {
        " "};
            this.Rif_val_09.Location = new System.Drawing.Point(1069, 306);
            this.Rif_val_09.MaxLength = 32767;
            this.Rif_val_09.Name = "Rif_val_09";
            this.Rif_val_09.PasswordChar = '\0';
            this.Rif_val_09.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rif_val_09.SelectedText = "";
            this.Rif_val_09.SelectionLength = 0;
            this.Rif_val_09.SelectionStart = 0;
            this.Rif_val_09.ShortcutsEnabled = true;
            this.Rif_val_09.Size = new System.Drawing.Size(40, 23);
            this.Rif_val_09.Style = MetroFramework.MetroColorStyle.Red;
            this.Rif_val_09.TabIndex = 207;
            this.Rif_val_09.Text = " ";
            this.Rif_val_09.UseSelectable = true;
            this.Rif_val_09.UseStyleColors = true;
            this.Rif_val_09.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rif_val_09.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rif_val_08
            // 
            // 
            // 
            // 
            this.Rif_val_08.CustomButton.Image = null;
            this.Rif_val_08.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Rif_val_08.CustomButton.Name = "";
            this.Rif_val_08.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rif_val_08.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rif_val_08.CustomButton.TabIndex = 1;
            this.Rif_val_08.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rif_val_08.CustomButton.UseSelectable = true;
            this.Rif_val_08.CustomButton.Visible = false;
            this.Rif_val_08.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_08_Ref_An_Value", true));
            this.Rif_val_08.Lines = new string[] {
        " "};
            this.Rif_val_08.Location = new System.Drawing.Point(1069, 276);
            this.Rif_val_08.MaxLength = 32767;
            this.Rif_val_08.Name = "Rif_val_08";
            this.Rif_val_08.PasswordChar = '\0';
            this.Rif_val_08.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rif_val_08.SelectedText = "";
            this.Rif_val_08.SelectionLength = 0;
            this.Rif_val_08.SelectionStart = 0;
            this.Rif_val_08.ShortcutsEnabled = true;
            this.Rif_val_08.Size = new System.Drawing.Size(40, 23);
            this.Rif_val_08.Style = MetroFramework.MetroColorStyle.Red;
            this.Rif_val_08.TabIndex = 206;
            this.Rif_val_08.Text = " ";
            this.Rif_val_08.UseSelectable = true;
            this.Rif_val_08.UseStyleColors = true;
            this.Rif_val_08.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rif_val_08.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rif_val_07
            // 
            // 
            // 
            // 
            this.Rif_val_07.CustomButton.Image = null;
            this.Rif_val_07.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Rif_val_07.CustomButton.Name = "";
            this.Rif_val_07.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rif_val_07.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rif_val_07.CustomButton.TabIndex = 1;
            this.Rif_val_07.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rif_val_07.CustomButton.UseSelectable = true;
            this.Rif_val_07.CustomButton.Visible = false;
            this.Rif_val_07.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_07_Ref_An_Value", true));
            this.Rif_val_07.Lines = new string[] {
        " "};
            this.Rif_val_07.Location = new System.Drawing.Point(1069, 246);
            this.Rif_val_07.MaxLength = 32767;
            this.Rif_val_07.Name = "Rif_val_07";
            this.Rif_val_07.PasswordChar = '\0';
            this.Rif_val_07.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rif_val_07.SelectedText = "";
            this.Rif_val_07.SelectionLength = 0;
            this.Rif_val_07.SelectionStart = 0;
            this.Rif_val_07.ShortcutsEnabled = true;
            this.Rif_val_07.Size = new System.Drawing.Size(40, 23);
            this.Rif_val_07.Style = MetroFramework.MetroColorStyle.Red;
            this.Rif_val_07.TabIndex = 205;
            this.Rif_val_07.Text = " ";
            this.Rif_val_07.UseSelectable = true;
            this.Rif_val_07.UseStyleColors = true;
            this.Rif_val_07.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rif_val_07.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rif_val_06
            // 
            // 
            // 
            // 
            this.Rif_val_06.CustomButton.Image = null;
            this.Rif_val_06.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Rif_val_06.CustomButton.Name = "";
            this.Rif_val_06.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rif_val_06.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rif_val_06.CustomButton.TabIndex = 1;
            this.Rif_val_06.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rif_val_06.CustomButton.UseSelectable = true;
            this.Rif_val_06.CustomButton.Visible = false;
            this.Rif_val_06.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_06_Ref_An_Value", true));
            this.Rif_val_06.Lines = new string[] {
        " "};
            this.Rif_val_06.Location = new System.Drawing.Point(1069, 216);
            this.Rif_val_06.MaxLength = 32767;
            this.Rif_val_06.Name = "Rif_val_06";
            this.Rif_val_06.PasswordChar = '\0';
            this.Rif_val_06.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rif_val_06.SelectedText = "";
            this.Rif_val_06.SelectionLength = 0;
            this.Rif_val_06.SelectionStart = 0;
            this.Rif_val_06.ShortcutsEnabled = true;
            this.Rif_val_06.Size = new System.Drawing.Size(40, 23);
            this.Rif_val_06.Style = MetroFramework.MetroColorStyle.Red;
            this.Rif_val_06.TabIndex = 204;
            this.Rif_val_06.Text = " ";
            this.Rif_val_06.UseSelectable = true;
            this.Rif_val_06.UseStyleColors = true;
            this.Rif_val_06.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rif_val_06.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rif_val_05
            // 
            // 
            // 
            // 
            this.Rif_val_05.CustomButton.Image = null;
            this.Rif_val_05.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Rif_val_05.CustomButton.Name = "";
            this.Rif_val_05.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rif_val_05.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rif_val_05.CustomButton.TabIndex = 1;
            this.Rif_val_05.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rif_val_05.CustomButton.UseSelectable = true;
            this.Rif_val_05.CustomButton.Visible = false;
            this.Rif_val_05.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_05_Ref_An_Value", true));
            this.Rif_val_05.Lines = new string[] {
        " "};
            this.Rif_val_05.Location = new System.Drawing.Point(1069, 186);
            this.Rif_val_05.MaxLength = 32767;
            this.Rif_val_05.Name = "Rif_val_05";
            this.Rif_val_05.PasswordChar = '\0';
            this.Rif_val_05.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rif_val_05.SelectedText = "";
            this.Rif_val_05.SelectionLength = 0;
            this.Rif_val_05.SelectionStart = 0;
            this.Rif_val_05.ShortcutsEnabled = true;
            this.Rif_val_05.Size = new System.Drawing.Size(40, 23);
            this.Rif_val_05.Style = MetroFramework.MetroColorStyle.Red;
            this.Rif_val_05.TabIndex = 203;
            this.Rif_val_05.Text = " ";
            this.Rif_val_05.UseSelectable = true;
            this.Rif_val_05.UseStyleColors = true;
            this.Rif_val_05.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rif_val_05.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rif_val_04
            // 
            // 
            // 
            // 
            this.Rif_val_04.CustomButton.Image = null;
            this.Rif_val_04.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Rif_val_04.CustomButton.Name = "";
            this.Rif_val_04.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rif_val_04.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rif_val_04.CustomButton.TabIndex = 1;
            this.Rif_val_04.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rif_val_04.CustomButton.UseSelectable = true;
            this.Rif_val_04.CustomButton.Visible = false;
            this.Rif_val_04.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_04_Ref_An_Value", true));
            this.Rif_val_04.Lines = new string[] {
        " "};
            this.Rif_val_04.Location = new System.Drawing.Point(1069, 156);
            this.Rif_val_04.MaxLength = 32767;
            this.Rif_val_04.Name = "Rif_val_04";
            this.Rif_val_04.PasswordChar = '\0';
            this.Rif_val_04.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rif_val_04.SelectedText = "";
            this.Rif_val_04.SelectionLength = 0;
            this.Rif_val_04.SelectionStart = 0;
            this.Rif_val_04.ShortcutsEnabled = true;
            this.Rif_val_04.Size = new System.Drawing.Size(40, 23);
            this.Rif_val_04.Style = MetroFramework.MetroColorStyle.Red;
            this.Rif_val_04.TabIndex = 202;
            this.Rif_val_04.Text = " ";
            this.Rif_val_04.UseSelectable = true;
            this.Rif_val_04.UseStyleColors = true;
            this.Rif_val_04.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rif_val_04.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rif_val_03
            // 
            // 
            // 
            // 
            this.Rif_val_03.CustomButton.Image = null;
            this.Rif_val_03.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Rif_val_03.CustomButton.Name = "";
            this.Rif_val_03.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rif_val_03.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rif_val_03.CustomButton.TabIndex = 1;
            this.Rif_val_03.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rif_val_03.CustomButton.UseSelectable = true;
            this.Rif_val_03.CustomButton.Visible = false;
            this.Rif_val_03.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_03_Ref_An_Value", true));
            this.Rif_val_03.Lines = new string[] {
        " "};
            this.Rif_val_03.Location = new System.Drawing.Point(1069, 126);
            this.Rif_val_03.MaxLength = 32767;
            this.Rif_val_03.Name = "Rif_val_03";
            this.Rif_val_03.PasswordChar = '\0';
            this.Rif_val_03.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rif_val_03.SelectedText = "";
            this.Rif_val_03.SelectionLength = 0;
            this.Rif_val_03.SelectionStart = 0;
            this.Rif_val_03.ShortcutsEnabled = true;
            this.Rif_val_03.Size = new System.Drawing.Size(40, 23);
            this.Rif_val_03.Style = MetroFramework.MetroColorStyle.Red;
            this.Rif_val_03.TabIndex = 201;
            this.Rif_val_03.Text = " ";
            this.Rif_val_03.UseSelectable = true;
            this.Rif_val_03.UseStyleColors = true;
            this.Rif_val_03.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rif_val_03.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rif_val_02
            // 
            // 
            // 
            // 
            this.Rif_val_02.CustomButton.Image = null;
            this.Rif_val_02.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Rif_val_02.CustomButton.Name = "";
            this.Rif_val_02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rif_val_02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rif_val_02.CustomButton.TabIndex = 1;
            this.Rif_val_02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rif_val_02.CustomButton.UseSelectable = true;
            this.Rif_val_02.CustomButton.Visible = false;
            this.Rif_val_02.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_02_Ref_An_Value", true));
            this.Rif_val_02.Lines = new string[] {
        " "};
            this.Rif_val_02.Location = new System.Drawing.Point(1069, 96);
            this.Rif_val_02.MaxLength = 32767;
            this.Rif_val_02.Name = "Rif_val_02";
            this.Rif_val_02.PasswordChar = '\0';
            this.Rif_val_02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rif_val_02.SelectedText = "";
            this.Rif_val_02.SelectionLength = 0;
            this.Rif_val_02.SelectionStart = 0;
            this.Rif_val_02.ShortcutsEnabled = true;
            this.Rif_val_02.Size = new System.Drawing.Size(40, 23);
            this.Rif_val_02.Style = MetroFramework.MetroColorStyle.Red;
            this.Rif_val_02.TabIndex = 200;
            this.Rif_val_02.Text = " ";
            this.Rif_val_02.UseSelectable = true;
            this.Rif_val_02.UseStyleColors = true;
            this.Rif_val_02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rif_val_02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rif_val_01
            // 
            // 
            // 
            // 
            this.Rif_val_01.CustomButton.Image = null;
            this.Rif_val_01.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Rif_val_01.CustomButton.Name = "";
            this.Rif_val_01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rif_val_01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rif_val_01.CustomButton.TabIndex = 1;
            this.Rif_val_01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rif_val_01.CustomButton.UseSelectable = true;
            this.Rif_val_01.CustomButton.Visible = false;
            this.Rif_val_01.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_01_Ref_An_Value", true));
            this.Rif_val_01.Lines = new string[] {
        " "};
            this.Rif_val_01.Location = new System.Drawing.Point(1069, 66);
            this.Rif_val_01.MaxLength = 32767;
            this.Rif_val_01.Name = "Rif_val_01";
            this.Rif_val_01.PasswordChar = '\0';
            this.Rif_val_01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rif_val_01.SelectedText = "";
            this.Rif_val_01.SelectionLength = 0;
            this.Rif_val_01.SelectionStart = 0;
            this.Rif_val_01.ShortcutsEnabled = true;
            this.Rif_val_01.Size = new System.Drawing.Size(40, 23);
            this.Rif_val_01.Style = MetroFramework.MetroColorStyle.Red;
            this.Rif_val_01.TabIndex = 199;
            this.Rif_val_01.Text = " ";
            this.Rif_val_01.UseSelectable = true;
            this.Rif_val_01.UseStyleColors = true;
            this.Rif_val_01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rif_val_01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rif_val_00
            // 
            // 
            // 
            // 
            this.Rif_val_00.CustomButton.Image = null;
            this.Rif_val_00.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Rif_val_00.CustomButton.Name = "";
            this.Rif_val_00.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Rif_val_00.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Rif_val_00.CustomButton.TabIndex = 1;
            this.Rif_val_00.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Rif_val_00.CustomButton.UseSelectable = true;
            this.Rif_val_00.CustomButton.Visible = false;
            this.Rif_val_00.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_00_Ref_An_Value", true));
            this.Rif_val_00.Lines = new string[] {
        " "};
            this.Rif_val_00.Location = new System.Drawing.Point(1069, 36);
            this.Rif_val_00.MaxLength = 32767;
            this.Rif_val_00.Name = "Rif_val_00";
            this.Rif_val_00.PasswordChar = '\0';
            this.Rif_val_00.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Rif_val_00.SelectedText = "";
            this.Rif_val_00.SelectionLength = 0;
            this.Rif_val_00.SelectionStart = 0;
            this.Rif_val_00.ShortcutsEnabled = true;
            this.Rif_val_00.Size = new System.Drawing.Size(40, 23);
            this.Rif_val_00.Style = MetroFramework.MetroColorStyle.Red;
            this.Rif_val_00.TabIndex = 198;
            this.Rif_val_00.Text = " ";
            this.Rif_val_00.UseSelectable = true;
            this.Rif_val_00.UseStyleColors = true;
            this.Rif_val_00.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Rif_val_00.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel24
            // 
            this.metroLabel24.Location = new System.Drawing.Point(1032, 10);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(121, 19);
            this.metroLabel24.TabIndex = 197;
            this.metroLabel24.Text = "Rif. val. Analogico";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox15.Location = new System.Drawing.Point(10, 213);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(1130, 1);
            this.pictureBox15.TabIndex = 181;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox11.Location = new System.Drawing.Point(10, 93);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(1130, 1);
            this.pictureBox11.TabIndex = 177;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox12.Location = new System.Drawing.Point(10, 123);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(1130, 1);
            this.pictureBox12.TabIndex = 176;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox13.Location = new System.Drawing.Point(10, 153);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(1130, 1);
            this.pictureBox13.TabIndex = 175;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox14.Location = new System.Drawing.Point(10, 183);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(1130, 1);
            this.pictureBox14.TabIndex = 174;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Location = new System.Drawing.Point(10, 363);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1130, 1);
            this.pictureBox7.TabIndex = 173;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Location = new System.Drawing.Point(10, 393);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1130, 1);
            this.pictureBox8.TabIndex = 172;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9.Location = new System.Drawing.Point(10, 423);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(1130, 1);
            this.pictureBox9.TabIndex = 171;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox10.Location = new System.Drawing.Point(10, 453);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(1130, 1);
            this.pictureBox10.TabIndex = 170;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(10, 483);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1130, 1);
            this.pictureBox6.TabIndex = 169;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(10, 243);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1130, 1);
            this.pictureBox5.TabIndex = 168;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(10, 273);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1130, 1);
            this.pictureBox4.TabIndex = 167;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(10, 303);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1130, 1);
            this.pictureBox3.TabIndex = 166;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(10, 333);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1130, 1);
            this.pictureBox2.TabIndex = 165;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1130, 1);
            this.pictureBox1.TabIndex = 164;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel23
            // 
            this.metroLabel23.Location = new System.Drawing.Point(852, 10);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(121, 19);
            this.metroLabel23.TabIndex = 147;
            this.metroLabel23.Text = "Icona - bit FALSE";
            // 
            // metroLabel22
            // 
            this.metroLabel22.Location = new System.Drawing.Point(679, 10);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(121, 19);
            this.metroLabel22.TabIndex = 145;
            this.metroLabel22.Text = "Icona - bit FALSE";
            // 
            // metroTextBox30
            // 
            // 
            // 
            // 
            this.metroTextBox30.CustomButton.Image = null;
            this.metroTextBox30.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox30.CustomButton.Name = "";
            this.metroTextBox30.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox30.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox30.CustomButton.TabIndex = 1;
            this.metroTextBox30.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox30.CustomButton.UseSelectable = true;
            this.metroTextBox30.CustomButton.Visible = false;
            this.metroTextBox30.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_15_Desc_1", true));
            this.metroTextBox30.Lines = new string[] {
        " "};
            this.metroTextBox30.Location = new System.Drawing.Point(420, 486);
            this.metroTextBox30.MaxLength = 32767;
            this.metroTextBox30.Name = "metroTextBox30";
            this.metroTextBox30.PasswordChar = '\0';
            this.metroTextBox30.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox30.SelectedText = "";
            this.metroTextBox30.SelectionLength = 0;
            this.metroTextBox30.SelectionStart = 0;
            this.metroTextBox30.ShortcutsEnabled = true;
            this.metroTextBox30.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox30.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox30.TabIndex = 143;
            this.metroTextBox30.Text = " ";
            this.metroTextBox30.UseSelectable = true;
            this.metroTextBox30.UseStyleColors = true;
            this.metroTextBox30.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox30.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox31
            // 
            // 
            // 
            // 
            this.metroTextBox31.CustomButton.Image = null;
            this.metroTextBox31.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox31.CustomButton.Name = "";
            this.metroTextBox31.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox31.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox31.CustomButton.TabIndex = 1;
            this.metroTextBox31.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox31.CustomButton.UseSelectable = true;
            this.metroTextBox31.CustomButton.Visible = false;
            this.metroTextBox31.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_15_Desc_0", true));
            this.metroTextBox31.Lines = new string[] {
        " "};
            this.metroTextBox31.Location = new System.Drawing.Point(160, 486);
            this.metroTextBox31.MaxLength = 32767;
            this.metroTextBox31.Name = "metroTextBox31";
            this.metroTextBox31.PasswordChar = '\0';
            this.metroTextBox31.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox31.SelectedText = "";
            this.metroTextBox31.SelectionLength = 0;
            this.metroTextBox31.SelectionStart = 0;
            this.metroTextBox31.ShortcutsEnabled = true;
            this.metroTextBox31.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox31.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox31.TabIndex = 142;
            this.metroTextBox31.Text = " ";
            this.metroTextBox31.UseSelectable = true;
            this.metroTextBox31.UseStyleColors = true;
            this.metroTextBox31.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox31.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox28
            // 
            // 
            // 
            // 
            this.metroTextBox28.CustomButton.Image = null;
            this.metroTextBox28.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox28.CustomButton.Name = "";
            this.metroTextBox28.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox28.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox28.CustomButton.TabIndex = 1;
            this.metroTextBox28.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox28.CustomButton.UseSelectable = true;
            this.metroTextBox28.CustomButton.Visible = false;
            this.metroTextBox28.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_14_Desc_1", true));
            this.metroTextBox28.Lines = new string[] {
        " "};
            this.metroTextBox28.Location = new System.Drawing.Point(420, 456);
            this.metroTextBox28.MaxLength = 32767;
            this.metroTextBox28.Name = "metroTextBox28";
            this.metroTextBox28.PasswordChar = '\0';
            this.metroTextBox28.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox28.SelectedText = "";
            this.metroTextBox28.SelectionLength = 0;
            this.metroTextBox28.SelectionStart = 0;
            this.metroTextBox28.ShortcutsEnabled = true;
            this.metroTextBox28.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox28.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox28.TabIndex = 141;
            this.metroTextBox28.Text = " ";
            this.metroTextBox28.UseSelectable = true;
            this.metroTextBox28.UseStyleColors = true;
            this.metroTextBox28.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox28.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox29
            // 
            // 
            // 
            // 
            this.metroTextBox29.CustomButton.Image = null;
            this.metroTextBox29.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox29.CustomButton.Name = "";
            this.metroTextBox29.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox29.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox29.CustomButton.TabIndex = 1;
            this.metroTextBox29.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox29.CustomButton.UseSelectable = true;
            this.metroTextBox29.CustomButton.Visible = false;
            this.metroTextBox29.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_14_Desc_0", true));
            this.metroTextBox29.Lines = new string[] {
        " "};
            this.metroTextBox29.Location = new System.Drawing.Point(160, 456);
            this.metroTextBox29.MaxLength = 32767;
            this.metroTextBox29.Name = "metroTextBox29";
            this.metroTextBox29.PasswordChar = '\0';
            this.metroTextBox29.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox29.SelectedText = "";
            this.metroTextBox29.SelectionLength = 0;
            this.metroTextBox29.SelectionStart = 0;
            this.metroTextBox29.ShortcutsEnabled = true;
            this.metroTextBox29.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox29.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox29.TabIndex = 140;
            this.metroTextBox29.Text = " ";
            this.metroTextBox29.UseSelectable = true;
            this.metroTextBox29.UseStyleColors = true;
            this.metroTextBox29.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox29.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox26
            // 
            // 
            // 
            // 
            this.metroTextBox26.CustomButton.Image = null;
            this.metroTextBox26.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox26.CustomButton.Name = "";
            this.metroTextBox26.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox26.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox26.CustomButton.TabIndex = 1;
            this.metroTextBox26.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox26.CustomButton.UseSelectable = true;
            this.metroTextBox26.CustomButton.Visible = false;
            this.metroTextBox26.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_13_Desc_1", true));
            this.metroTextBox26.Lines = new string[] {
        " "};
            this.metroTextBox26.Location = new System.Drawing.Point(420, 426);
            this.metroTextBox26.MaxLength = 32767;
            this.metroTextBox26.Name = "metroTextBox26";
            this.metroTextBox26.PasswordChar = '\0';
            this.metroTextBox26.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox26.SelectedText = "";
            this.metroTextBox26.SelectionLength = 0;
            this.metroTextBox26.SelectionStart = 0;
            this.metroTextBox26.ShortcutsEnabled = true;
            this.metroTextBox26.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox26.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox26.TabIndex = 139;
            this.metroTextBox26.Text = " ";
            this.metroTextBox26.UseSelectable = true;
            this.metroTextBox26.UseStyleColors = true;
            this.metroTextBox26.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox26.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox27
            // 
            // 
            // 
            // 
            this.metroTextBox27.CustomButton.Image = null;
            this.metroTextBox27.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox27.CustomButton.Name = "";
            this.metroTextBox27.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox27.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox27.CustomButton.TabIndex = 1;
            this.metroTextBox27.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox27.CustomButton.UseSelectable = true;
            this.metroTextBox27.CustomButton.Visible = false;
            this.metroTextBox27.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_13_Desc_0", true));
            this.metroTextBox27.Lines = new string[] {
        " "};
            this.metroTextBox27.Location = new System.Drawing.Point(160, 426);
            this.metroTextBox27.MaxLength = 32767;
            this.metroTextBox27.Name = "metroTextBox27";
            this.metroTextBox27.PasswordChar = '\0';
            this.metroTextBox27.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox27.SelectedText = "";
            this.metroTextBox27.SelectionLength = 0;
            this.metroTextBox27.SelectionStart = 0;
            this.metroTextBox27.ShortcutsEnabled = true;
            this.metroTextBox27.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox27.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox27.TabIndex = 138;
            this.metroTextBox27.Text = " ";
            this.metroTextBox27.UseSelectable = true;
            this.metroTextBox27.UseStyleColors = true;
            this.metroTextBox27.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox27.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox24
            // 
            // 
            // 
            // 
            this.metroTextBox24.CustomButton.Image = null;
            this.metroTextBox24.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox24.CustomButton.Name = "";
            this.metroTextBox24.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox24.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox24.CustomButton.TabIndex = 1;
            this.metroTextBox24.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox24.CustomButton.UseSelectable = true;
            this.metroTextBox24.CustomButton.Visible = false;
            this.metroTextBox24.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_12_Desc_1", true));
            this.metroTextBox24.Lines = new string[] {
        " "};
            this.metroTextBox24.Location = new System.Drawing.Point(420, 396);
            this.metroTextBox24.MaxLength = 32767;
            this.metroTextBox24.Name = "metroTextBox24";
            this.metroTextBox24.PasswordChar = '\0';
            this.metroTextBox24.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox24.SelectedText = "";
            this.metroTextBox24.SelectionLength = 0;
            this.metroTextBox24.SelectionStart = 0;
            this.metroTextBox24.ShortcutsEnabled = true;
            this.metroTextBox24.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox24.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox24.TabIndex = 137;
            this.metroTextBox24.Text = " ";
            this.metroTextBox24.UseSelectable = true;
            this.metroTextBox24.UseStyleColors = true;
            this.metroTextBox24.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox24.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox25
            // 
            // 
            // 
            // 
            this.metroTextBox25.CustomButton.Image = null;
            this.metroTextBox25.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox25.CustomButton.Name = "";
            this.metroTextBox25.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox25.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox25.CustomButton.TabIndex = 1;
            this.metroTextBox25.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox25.CustomButton.UseSelectable = true;
            this.metroTextBox25.CustomButton.Visible = false;
            this.metroTextBox25.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_12_Desc_0", true));
            this.metroTextBox25.Lines = new string[] {
        " "};
            this.metroTextBox25.Location = new System.Drawing.Point(160, 396);
            this.metroTextBox25.MaxLength = 32767;
            this.metroTextBox25.Name = "metroTextBox25";
            this.metroTextBox25.PasswordChar = '\0';
            this.metroTextBox25.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox25.SelectedText = "";
            this.metroTextBox25.SelectionLength = 0;
            this.metroTextBox25.SelectionStart = 0;
            this.metroTextBox25.ShortcutsEnabled = true;
            this.metroTextBox25.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox25.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox25.TabIndex = 136;
            this.metroTextBox25.Text = " ";
            this.metroTextBox25.UseSelectable = true;
            this.metroTextBox25.UseStyleColors = true;
            this.metroTextBox25.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox25.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox22
            // 
            // 
            // 
            // 
            this.metroTextBox22.CustomButton.Image = null;
            this.metroTextBox22.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox22.CustomButton.Name = "";
            this.metroTextBox22.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox22.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox22.CustomButton.TabIndex = 1;
            this.metroTextBox22.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox22.CustomButton.UseSelectable = true;
            this.metroTextBox22.CustomButton.Visible = false;
            this.metroTextBox22.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_11_Desc_1", true));
            this.metroTextBox22.Lines = new string[] {
        " "};
            this.metroTextBox22.Location = new System.Drawing.Point(420, 366);
            this.metroTextBox22.MaxLength = 32767;
            this.metroTextBox22.Name = "metroTextBox22";
            this.metroTextBox22.PasswordChar = '\0';
            this.metroTextBox22.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox22.SelectedText = "";
            this.metroTextBox22.SelectionLength = 0;
            this.metroTextBox22.SelectionStart = 0;
            this.metroTextBox22.ShortcutsEnabled = true;
            this.metroTextBox22.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox22.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox22.TabIndex = 135;
            this.metroTextBox22.Text = " ";
            this.metroTextBox22.UseSelectable = true;
            this.metroTextBox22.UseStyleColors = true;
            this.metroTextBox22.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox22.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox23
            // 
            // 
            // 
            // 
            this.metroTextBox23.CustomButton.Image = null;
            this.metroTextBox23.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox23.CustomButton.Name = "";
            this.metroTextBox23.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox23.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox23.CustomButton.TabIndex = 1;
            this.metroTextBox23.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox23.CustomButton.UseSelectable = true;
            this.metroTextBox23.CustomButton.Visible = false;
            this.metroTextBox23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_11_Desc_0", true));
            this.metroTextBox23.Lines = new string[] {
        " "};
            this.metroTextBox23.Location = new System.Drawing.Point(160, 366);
            this.metroTextBox23.MaxLength = 32767;
            this.metroTextBox23.Name = "metroTextBox23";
            this.metroTextBox23.PasswordChar = '\0';
            this.metroTextBox23.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox23.SelectedText = "";
            this.metroTextBox23.SelectionLength = 0;
            this.metroTextBox23.SelectionStart = 0;
            this.metroTextBox23.ShortcutsEnabled = true;
            this.metroTextBox23.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox23.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox23.TabIndex = 134;
            this.metroTextBox23.Text = " ";
            this.metroTextBox23.UseSelectable = true;
            this.metroTextBox23.UseStyleColors = true;
            this.metroTextBox23.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox23.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox20
            // 
            // 
            // 
            // 
            this.metroTextBox20.CustomButton.Image = null;
            this.metroTextBox20.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox20.CustomButton.Name = "";
            this.metroTextBox20.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox20.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox20.CustomButton.TabIndex = 1;
            this.metroTextBox20.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox20.CustomButton.UseSelectable = true;
            this.metroTextBox20.CustomButton.Visible = false;
            this.metroTextBox20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_10_Desc_1", true));
            this.metroTextBox20.Lines = new string[] {
        " "};
            this.metroTextBox20.Location = new System.Drawing.Point(420, 336);
            this.metroTextBox20.MaxLength = 32767;
            this.metroTextBox20.Name = "metroTextBox20";
            this.metroTextBox20.PasswordChar = '\0';
            this.metroTextBox20.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox20.SelectedText = "";
            this.metroTextBox20.SelectionLength = 0;
            this.metroTextBox20.SelectionStart = 0;
            this.metroTextBox20.ShortcutsEnabled = true;
            this.metroTextBox20.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox20.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox20.TabIndex = 133;
            this.metroTextBox20.Text = " ";
            this.metroTextBox20.UseSelectable = true;
            this.metroTextBox20.UseStyleColors = true;
            this.metroTextBox20.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox20.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox21
            // 
            // 
            // 
            // 
            this.metroTextBox21.CustomButton.Image = null;
            this.metroTextBox21.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox21.CustomButton.Name = "";
            this.metroTextBox21.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox21.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox21.CustomButton.TabIndex = 1;
            this.metroTextBox21.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox21.CustomButton.UseSelectable = true;
            this.metroTextBox21.CustomButton.Visible = false;
            this.metroTextBox21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_10_Desc_0", true));
            this.metroTextBox21.Lines = new string[] {
        " "};
            this.metroTextBox21.Location = new System.Drawing.Point(160, 336);
            this.metroTextBox21.MaxLength = 32767;
            this.metroTextBox21.Name = "metroTextBox21";
            this.metroTextBox21.PasswordChar = '\0';
            this.metroTextBox21.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox21.SelectedText = "";
            this.metroTextBox21.SelectionLength = 0;
            this.metroTextBox21.SelectionStart = 0;
            this.metroTextBox21.ShortcutsEnabled = true;
            this.metroTextBox21.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox21.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox21.TabIndex = 132;
            this.metroTextBox21.Text = " ";
            this.metroTextBox21.UseSelectable = true;
            this.metroTextBox21.UseStyleColors = true;
            this.metroTextBox21.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox21.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox18
            // 
            // 
            // 
            // 
            this.metroTextBox18.CustomButton.Image = null;
            this.metroTextBox18.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox18.CustomButton.Name = "";
            this.metroTextBox18.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox18.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox18.CustomButton.TabIndex = 1;
            this.metroTextBox18.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox18.CustomButton.UseSelectable = true;
            this.metroTextBox18.CustomButton.Visible = false;
            this.metroTextBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_09_Desc_1", true));
            this.metroTextBox18.Lines = new string[] {
        " "};
            this.metroTextBox18.Location = new System.Drawing.Point(420, 306);
            this.metroTextBox18.MaxLength = 32767;
            this.metroTextBox18.Name = "metroTextBox18";
            this.metroTextBox18.PasswordChar = '\0';
            this.metroTextBox18.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox18.SelectedText = "";
            this.metroTextBox18.SelectionLength = 0;
            this.metroTextBox18.SelectionStart = 0;
            this.metroTextBox18.ShortcutsEnabled = true;
            this.metroTextBox18.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox18.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox18.TabIndex = 131;
            this.metroTextBox18.Text = " ";
            this.metroTextBox18.UseSelectable = true;
            this.metroTextBox18.UseStyleColors = true;
            this.metroTextBox18.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox18.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox19
            // 
            // 
            // 
            // 
            this.metroTextBox19.CustomButton.Image = null;
            this.metroTextBox19.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox19.CustomButton.Name = "";
            this.metroTextBox19.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox19.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox19.CustomButton.TabIndex = 1;
            this.metroTextBox19.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox19.CustomButton.UseSelectable = true;
            this.metroTextBox19.CustomButton.Visible = false;
            this.metroTextBox19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_09_Desc_0", true));
            this.metroTextBox19.Lines = new string[] {
        " "};
            this.metroTextBox19.Location = new System.Drawing.Point(160, 306);
            this.metroTextBox19.MaxLength = 32767;
            this.metroTextBox19.Name = "metroTextBox19";
            this.metroTextBox19.PasswordChar = '\0';
            this.metroTextBox19.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox19.SelectedText = "";
            this.metroTextBox19.SelectionLength = 0;
            this.metroTextBox19.SelectionStart = 0;
            this.metroTextBox19.ShortcutsEnabled = true;
            this.metroTextBox19.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox19.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox19.TabIndex = 130;
            this.metroTextBox19.Text = " ";
            this.metroTextBox19.UseSelectable = true;
            this.metroTextBox19.UseStyleColors = true;
            this.metroTextBox19.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox19.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox16
            // 
            // 
            // 
            // 
            this.metroTextBox16.CustomButton.Image = null;
            this.metroTextBox16.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox16.CustomButton.Name = "";
            this.metroTextBox16.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox16.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox16.CustomButton.TabIndex = 1;
            this.metroTextBox16.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox16.CustomButton.UseSelectable = true;
            this.metroTextBox16.CustomButton.Visible = false;
            this.metroTextBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_08_Desc_1", true));
            this.metroTextBox16.Lines = new string[] {
        " "};
            this.metroTextBox16.Location = new System.Drawing.Point(420, 276);
            this.metroTextBox16.MaxLength = 32767;
            this.metroTextBox16.Name = "metroTextBox16";
            this.metroTextBox16.PasswordChar = '\0';
            this.metroTextBox16.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox16.SelectedText = "";
            this.metroTextBox16.SelectionLength = 0;
            this.metroTextBox16.SelectionStart = 0;
            this.metroTextBox16.ShortcutsEnabled = true;
            this.metroTextBox16.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox16.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox16.TabIndex = 129;
            this.metroTextBox16.Text = " ";
            this.metroTextBox16.UseSelectable = true;
            this.metroTextBox16.UseStyleColors = true;
            this.metroTextBox16.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox16.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox17
            // 
            // 
            // 
            // 
            this.metroTextBox17.CustomButton.Image = null;
            this.metroTextBox17.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox17.CustomButton.Name = "";
            this.metroTextBox17.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox17.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox17.CustomButton.TabIndex = 1;
            this.metroTextBox17.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox17.CustomButton.UseSelectable = true;
            this.metroTextBox17.CustomButton.Visible = false;
            this.metroTextBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_08_Desc_0", true));
            this.metroTextBox17.Lines = new string[] {
        " "};
            this.metroTextBox17.Location = new System.Drawing.Point(160, 276);
            this.metroTextBox17.MaxLength = 32767;
            this.metroTextBox17.Name = "metroTextBox17";
            this.metroTextBox17.PasswordChar = '\0';
            this.metroTextBox17.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox17.SelectedText = "";
            this.metroTextBox17.SelectionLength = 0;
            this.metroTextBox17.SelectionStart = 0;
            this.metroTextBox17.ShortcutsEnabled = true;
            this.metroTextBox17.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox17.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox17.TabIndex = 128;
            this.metroTextBox17.Text = " ";
            this.metroTextBox17.UseSelectable = true;
            this.metroTextBox17.UseStyleColors = true;
            this.metroTextBox17.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox17.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox14
            // 
            // 
            // 
            // 
            this.metroTextBox14.CustomButton.Image = null;
            this.metroTextBox14.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox14.CustomButton.Name = "";
            this.metroTextBox14.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox14.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox14.CustomButton.TabIndex = 1;
            this.metroTextBox14.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox14.CustomButton.UseSelectable = true;
            this.metroTextBox14.CustomButton.Visible = false;
            this.metroTextBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_07_Desc_1", true));
            this.metroTextBox14.Lines = new string[] {
        " "};
            this.metroTextBox14.Location = new System.Drawing.Point(420, 246);
            this.metroTextBox14.MaxLength = 32767;
            this.metroTextBox14.Name = "metroTextBox14";
            this.metroTextBox14.PasswordChar = '\0';
            this.metroTextBox14.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox14.SelectedText = "";
            this.metroTextBox14.SelectionLength = 0;
            this.metroTextBox14.SelectionStart = 0;
            this.metroTextBox14.ShortcutsEnabled = true;
            this.metroTextBox14.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox14.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox14.TabIndex = 127;
            this.metroTextBox14.Text = " ";
            this.metroTextBox14.UseSelectable = true;
            this.metroTextBox14.UseStyleColors = true;
            this.metroTextBox14.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox14.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox15
            // 
            // 
            // 
            // 
            this.metroTextBox15.CustomButton.Image = null;
            this.metroTextBox15.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox15.CustomButton.Name = "";
            this.metroTextBox15.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox15.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox15.CustomButton.TabIndex = 1;
            this.metroTextBox15.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox15.CustomButton.UseSelectable = true;
            this.metroTextBox15.CustomButton.Visible = false;
            this.metroTextBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_07_Desc_0", true));
            this.metroTextBox15.Lines = new string[] {
        " "};
            this.metroTextBox15.Location = new System.Drawing.Point(160, 246);
            this.metroTextBox15.MaxLength = 32767;
            this.metroTextBox15.Name = "metroTextBox15";
            this.metroTextBox15.PasswordChar = '\0';
            this.metroTextBox15.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox15.SelectedText = "";
            this.metroTextBox15.SelectionLength = 0;
            this.metroTextBox15.SelectionStart = 0;
            this.metroTextBox15.ShortcutsEnabled = true;
            this.metroTextBox15.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox15.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox15.TabIndex = 126;
            this.metroTextBox15.Text = " ";
            this.metroTextBox15.UseSelectable = true;
            this.metroTextBox15.UseStyleColors = true;
            this.metroTextBox15.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox15.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox12
            // 
            // 
            // 
            // 
            this.metroTextBox12.CustomButton.Image = null;
            this.metroTextBox12.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox12.CustomButton.Name = "";
            this.metroTextBox12.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox12.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox12.CustomButton.TabIndex = 1;
            this.metroTextBox12.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox12.CustomButton.UseSelectable = true;
            this.metroTextBox12.CustomButton.Visible = false;
            this.metroTextBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_06_Desc_1", true));
            this.metroTextBox12.Lines = new string[] {
        " "};
            this.metroTextBox12.Location = new System.Drawing.Point(420, 216);
            this.metroTextBox12.MaxLength = 32767;
            this.metroTextBox12.Name = "metroTextBox12";
            this.metroTextBox12.PasswordChar = '\0';
            this.metroTextBox12.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox12.SelectedText = "";
            this.metroTextBox12.SelectionLength = 0;
            this.metroTextBox12.SelectionStart = 0;
            this.metroTextBox12.ShortcutsEnabled = true;
            this.metroTextBox12.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox12.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox12.TabIndex = 125;
            this.metroTextBox12.Text = " ";
            this.metroTextBox12.UseSelectable = true;
            this.metroTextBox12.UseStyleColors = true;
            this.metroTextBox12.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox12.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox13
            // 
            // 
            // 
            // 
            this.metroTextBox13.CustomButton.Image = null;
            this.metroTextBox13.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox13.CustomButton.Name = "";
            this.metroTextBox13.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox13.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox13.CustomButton.TabIndex = 1;
            this.metroTextBox13.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox13.CustomButton.UseSelectable = true;
            this.metroTextBox13.CustomButton.Visible = false;
            this.metroTextBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_06_Desc_0", true));
            this.metroTextBox13.Lines = new string[] {
        " "};
            this.metroTextBox13.Location = new System.Drawing.Point(160, 216);
            this.metroTextBox13.MaxLength = 32767;
            this.metroTextBox13.Name = "metroTextBox13";
            this.metroTextBox13.PasswordChar = '\0';
            this.metroTextBox13.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox13.SelectedText = "";
            this.metroTextBox13.SelectionLength = 0;
            this.metroTextBox13.SelectionStart = 0;
            this.metroTextBox13.ShortcutsEnabled = true;
            this.metroTextBox13.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox13.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox13.TabIndex = 124;
            this.metroTextBox13.Text = " ";
            this.metroTextBox13.UseSelectable = true;
            this.metroTextBox13.UseStyleColors = true;
            this.metroTextBox13.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox13.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox10
            // 
            // 
            // 
            // 
            this.metroTextBox10.CustomButton.Image = null;
            this.metroTextBox10.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox10.CustomButton.Name = "";
            this.metroTextBox10.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox10.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox10.CustomButton.TabIndex = 1;
            this.metroTextBox10.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox10.CustomButton.UseSelectable = true;
            this.metroTextBox10.CustomButton.Visible = false;
            this.metroTextBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_05_Desc_1", true));
            this.metroTextBox10.Lines = new string[] {
        " "};
            this.metroTextBox10.Location = new System.Drawing.Point(420, 186);
            this.metroTextBox10.MaxLength = 32767;
            this.metroTextBox10.Name = "metroTextBox10";
            this.metroTextBox10.PasswordChar = '\0';
            this.metroTextBox10.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox10.SelectedText = "";
            this.metroTextBox10.SelectionLength = 0;
            this.metroTextBox10.SelectionStart = 0;
            this.metroTextBox10.ShortcutsEnabled = true;
            this.metroTextBox10.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox10.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox10.TabIndex = 123;
            this.metroTextBox10.Text = " ";
            this.metroTextBox10.UseSelectable = true;
            this.metroTextBox10.UseStyleColors = true;
            this.metroTextBox10.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox10.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox11
            // 
            // 
            // 
            // 
            this.metroTextBox11.CustomButton.Image = null;
            this.metroTextBox11.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox11.CustomButton.Name = "";
            this.metroTextBox11.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox11.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox11.CustomButton.TabIndex = 1;
            this.metroTextBox11.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox11.CustomButton.UseSelectable = true;
            this.metroTextBox11.CustomButton.Visible = false;
            this.metroTextBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_05_Desc_0", true));
            this.metroTextBox11.Lines = new string[] {
        " "};
            this.metroTextBox11.Location = new System.Drawing.Point(160, 186);
            this.metroTextBox11.MaxLength = 32767;
            this.metroTextBox11.Name = "metroTextBox11";
            this.metroTextBox11.PasswordChar = '\0';
            this.metroTextBox11.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox11.SelectedText = "";
            this.metroTextBox11.SelectionLength = 0;
            this.metroTextBox11.SelectionStart = 0;
            this.metroTextBox11.ShortcutsEnabled = true;
            this.metroTextBox11.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox11.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox11.TabIndex = 122;
            this.metroTextBox11.Text = " ";
            this.metroTextBox11.UseSelectable = true;
            this.metroTextBox11.UseStyleColors = true;
            this.metroTextBox11.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox11.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox8
            // 
            // 
            // 
            // 
            this.metroTextBox8.CustomButton.Image = null;
            this.metroTextBox8.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox8.CustomButton.Name = "";
            this.metroTextBox8.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox8.CustomButton.TabIndex = 1;
            this.metroTextBox8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox8.CustomButton.UseSelectable = true;
            this.metroTextBox8.CustomButton.Visible = false;
            this.metroTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_04_Desc_1", true));
            this.metroTextBox8.Lines = new string[] {
        " "};
            this.metroTextBox8.Location = new System.Drawing.Point(420, 156);
            this.metroTextBox8.MaxLength = 32767;
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.PasswordChar = '\0';
            this.metroTextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox8.SelectedText = "";
            this.metroTextBox8.SelectionLength = 0;
            this.metroTextBox8.SelectionStart = 0;
            this.metroTextBox8.ShortcutsEnabled = true;
            this.metroTextBox8.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox8.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox8.TabIndex = 121;
            this.metroTextBox8.Text = " ";
            this.metroTextBox8.UseSelectable = true;
            this.metroTextBox8.UseStyleColors = true;
            this.metroTextBox8.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox8.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox9
            // 
            // 
            // 
            // 
            this.metroTextBox9.CustomButton.Image = null;
            this.metroTextBox9.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox9.CustomButton.Name = "";
            this.metroTextBox9.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox9.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox9.CustomButton.TabIndex = 1;
            this.metroTextBox9.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox9.CustomButton.UseSelectable = true;
            this.metroTextBox9.CustomButton.Visible = false;
            this.metroTextBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_04_Desc_0", true));
            this.metroTextBox9.Lines = new string[] {
        " "};
            this.metroTextBox9.Location = new System.Drawing.Point(160, 156);
            this.metroTextBox9.MaxLength = 32767;
            this.metroTextBox9.Name = "metroTextBox9";
            this.metroTextBox9.PasswordChar = '\0';
            this.metroTextBox9.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox9.SelectedText = "";
            this.metroTextBox9.SelectionLength = 0;
            this.metroTextBox9.SelectionStart = 0;
            this.metroTextBox9.ShortcutsEnabled = true;
            this.metroTextBox9.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox9.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox9.TabIndex = 120;
            this.metroTextBox9.Text = " ";
            this.metroTextBox9.UseSelectable = true;
            this.metroTextBox9.UseStyleColors = true;
            this.metroTextBox9.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox9.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox6
            // 
            // 
            // 
            // 
            this.metroTextBox6.CustomButton.Image = null;
            this.metroTextBox6.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox6.CustomButton.Name = "";
            this.metroTextBox6.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox6.CustomButton.TabIndex = 1;
            this.metroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox6.CustomButton.UseSelectable = true;
            this.metroTextBox6.CustomButton.Visible = false;
            this.metroTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_03_Desc_1", true));
            this.metroTextBox6.Lines = new string[] {
        " "};
            this.metroTextBox6.Location = new System.Drawing.Point(420, 126);
            this.metroTextBox6.MaxLength = 32767;
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.PasswordChar = '\0';
            this.metroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox6.SelectedText = "";
            this.metroTextBox6.SelectionLength = 0;
            this.metroTextBox6.SelectionStart = 0;
            this.metroTextBox6.ShortcutsEnabled = true;
            this.metroTextBox6.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox6.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox6.TabIndex = 119;
            this.metroTextBox6.Text = " ";
            this.metroTextBox6.UseSelectable = true;
            this.metroTextBox6.UseStyleColors = true;
            this.metroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox7
            // 
            // 
            // 
            // 
            this.metroTextBox7.CustomButton.Image = null;
            this.metroTextBox7.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox7.CustomButton.Name = "";
            this.metroTextBox7.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox7.CustomButton.TabIndex = 1;
            this.metroTextBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox7.CustomButton.UseSelectable = true;
            this.metroTextBox7.CustomButton.Visible = false;
            this.metroTextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_03_Desc_0", true));
            this.metroTextBox7.Lines = new string[] {
        " "};
            this.metroTextBox7.Location = new System.Drawing.Point(160, 126);
            this.metroTextBox7.MaxLength = 32767;
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.PasswordChar = '\0';
            this.metroTextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox7.SelectedText = "";
            this.metroTextBox7.SelectionLength = 0;
            this.metroTextBox7.SelectionStart = 0;
            this.metroTextBox7.ShortcutsEnabled = true;
            this.metroTextBox7.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox7.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox7.TabIndex = 118;
            this.metroTextBox7.Text = " ";
            this.metroTextBox7.UseSelectable = true;
            this.metroTextBox7.UseStyleColors = true;
            this.metroTextBox7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox7.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_02_Desc_1", true));
            this.metroTextBox4.Lines = new string[] {
        " "};
            this.metroTextBox4.Location = new System.Drawing.Point(420, 96);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox4.TabIndex = 117;
            this.metroTextBox4.Text = " ";
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.UseStyleColors = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox5
            // 
            // 
            // 
            // 
            this.metroTextBox5.CustomButton.Image = null;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.CustomButton.Visible = false;
            this.metroTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_02_Desc_0", true));
            this.metroTextBox5.Lines = new string[] {
        " "};
            this.metroTextBox5.Location = new System.Drawing.Point(160, 96);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.ShortcutsEnabled = true;
            this.metroTextBox5.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox5.TabIndex = 116;
            this.metroTextBox5.Text = " ";
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.UseStyleColors = true;
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_01_Desc_1", true));
            this.metroTextBox2.Lines = new string[] {
        " "};
            this.metroTextBox2.Location = new System.Drawing.Point(420, 66);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox2.TabIndex = 115;
            this.metroTextBox2.Text = " ";
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.UseStyleColors = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_01_Desc_0", true));
            this.metroTextBox3.Lines = new string[] {
        " "};
            this.metroTextBox3.Location = new System.Drawing.Point(160, 66);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox3.TabIndex = 114;
            this.metroTextBox3.Text = " ";
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.UseStyleColors = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_00_Desc_1", true));
            this.metroTextBox1.Lines = new string[] {
        " "};
            this.metroTextBox1.Location = new System.Drawing.Point(420, 36);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(250, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox1.TabIndex = 113;
            this.metroTextBox1.Text = " ";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.UseStyleColors = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel21
            // 
            this.metroLabel21.Location = new System.Drawing.Point(420, 10);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(160, 19);
            this.metroLabel21.TabIndex = 112;
            this.metroLabel21.Text = "Descrizione - bit TRUE";
            // 
            // metroLabel20
            // 
            this.metroLabel20.Location = new System.Drawing.Point(160, 10);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(160, 19);
            this.metroLabel20.TabIndex = 111;
            this.metroLabel20.Text = "Descrizione - bit FALSE";
            // 
            // metroCheckBox16
            // 
            this.metroCheckBox16.AutoSize = true;
            this.metroCheckBox16.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_15_Present", true));
            this.metroCheckBox16.Location = new System.Drawing.Point(100, 490);
            this.metroCheckBox16.Name = "metroCheckBox16";
            this.metroCheckBox16.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox16.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox16.TabIndex = 110;
            this.metroCheckBox16.Text = " ";
            this.metroCheckBox16.UseSelectable = true;
            this.metroCheckBox16.UseStyleColors = true;
            // 
            // metroCheckBox15
            // 
            this.metroCheckBox15.AutoSize = true;
            this.metroCheckBox15.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_14_Present", true));
            this.metroCheckBox15.Location = new System.Drawing.Point(100, 460);
            this.metroCheckBox15.Name = "metroCheckBox15";
            this.metroCheckBox15.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox15.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox15.TabIndex = 109;
            this.metroCheckBox15.Text = " ";
            this.metroCheckBox15.UseSelectable = true;
            this.metroCheckBox15.UseStyleColors = true;
            // 
            // metroCheckBox14
            // 
            this.metroCheckBox14.AutoSize = true;
            this.metroCheckBox14.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_13_Present", true));
            this.metroCheckBox14.Location = new System.Drawing.Point(100, 430);
            this.metroCheckBox14.Name = "metroCheckBox14";
            this.metroCheckBox14.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox14.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox14.TabIndex = 108;
            this.metroCheckBox14.Text = " ";
            this.metroCheckBox14.UseSelectable = true;
            this.metroCheckBox14.UseStyleColors = true;
            // 
            // metroCheckBox13
            // 
            this.metroCheckBox13.AutoSize = true;
            this.metroCheckBox13.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_12_Present", true));
            this.metroCheckBox13.Location = new System.Drawing.Point(100, 400);
            this.metroCheckBox13.Name = "metroCheckBox13";
            this.metroCheckBox13.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox13.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox13.TabIndex = 107;
            this.metroCheckBox13.Text = " ";
            this.metroCheckBox13.UseSelectable = true;
            this.metroCheckBox13.UseStyleColors = true;
            // 
            // metroCheckBox12
            // 
            this.metroCheckBox12.AutoSize = true;
            this.metroCheckBox12.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_11_Present", true));
            this.metroCheckBox12.Location = new System.Drawing.Point(100, 370);
            this.metroCheckBox12.Name = "metroCheckBox12";
            this.metroCheckBox12.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox12.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox12.TabIndex = 106;
            this.metroCheckBox12.Text = " ";
            this.metroCheckBox12.UseSelectable = true;
            this.metroCheckBox12.UseStyleColors = true;
            // 
            // metroCheckBox11
            // 
            this.metroCheckBox11.AutoSize = true;
            this.metroCheckBox11.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_10_Present", true));
            this.metroCheckBox11.Location = new System.Drawing.Point(100, 340);
            this.metroCheckBox11.Name = "metroCheckBox11";
            this.metroCheckBox11.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox11.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox11.TabIndex = 105;
            this.metroCheckBox11.Text = " ";
            this.metroCheckBox11.UseSelectable = true;
            this.metroCheckBox11.UseStyleColors = true;
            // 
            // metroCheckBox10
            // 
            this.metroCheckBox10.AutoSize = true;
            this.metroCheckBox10.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_09_Present", true));
            this.metroCheckBox10.Location = new System.Drawing.Point(100, 310);
            this.metroCheckBox10.Name = "metroCheckBox10";
            this.metroCheckBox10.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox10.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox10.TabIndex = 104;
            this.metroCheckBox10.Text = " ";
            this.metroCheckBox10.UseSelectable = true;
            this.metroCheckBox10.UseStyleColors = true;
            // 
            // metroCheckBox9
            // 
            this.metroCheckBox9.AutoSize = true;
            this.metroCheckBox9.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_08_Present", true));
            this.metroCheckBox9.Location = new System.Drawing.Point(100, 280);
            this.metroCheckBox9.Name = "metroCheckBox9";
            this.metroCheckBox9.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox9.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox9.TabIndex = 103;
            this.metroCheckBox9.Text = " ";
            this.metroCheckBox9.UseSelectable = true;
            this.metroCheckBox9.UseStyleColors = true;
            // 
            // metroCheckBox8
            // 
            this.metroCheckBox8.AutoSize = true;
            this.metroCheckBox8.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_07_Present", true));
            this.metroCheckBox8.Location = new System.Drawing.Point(100, 250);
            this.metroCheckBox8.Name = "metroCheckBox8";
            this.metroCheckBox8.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox8.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox8.TabIndex = 102;
            this.metroCheckBox8.Text = " ";
            this.metroCheckBox8.UseSelectable = true;
            this.metroCheckBox8.UseStyleColors = true;
            // 
            // metroCheckBox7
            // 
            this.metroCheckBox7.AutoSize = true;
            this.metroCheckBox7.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_06_Present", true));
            this.metroCheckBox7.Location = new System.Drawing.Point(100, 220);
            this.metroCheckBox7.Name = "metroCheckBox7";
            this.metroCheckBox7.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox7.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox7.TabIndex = 101;
            this.metroCheckBox7.Text = " ";
            this.metroCheckBox7.UseSelectable = true;
            this.metroCheckBox7.UseStyleColors = true;
            // 
            // metroCheckBox6
            // 
            this.metroCheckBox6.AutoSize = true;
            this.metroCheckBox6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_05_Present", true));
            this.metroCheckBox6.Location = new System.Drawing.Point(100, 190);
            this.metroCheckBox6.Name = "metroCheckBox6";
            this.metroCheckBox6.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox6.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox6.TabIndex = 100;
            this.metroCheckBox6.Text = " ";
            this.metroCheckBox6.UseSelectable = true;
            this.metroCheckBox6.UseStyleColors = true;
            // 
            // metroCheckBox5
            // 
            this.metroCheckBox5.AutoSize = true;
            this.metroCheckBox5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_04_Present", true));
            this.metroCheckBox5.Location = new System.Drawing.Point(100, 160);
            this.metroCheckBox5.Name = "metroCheckBox5";
            this.metroCheckBox5.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox5.TabIndex = 99;
            this.metroCheckBox5.Text = " ";
            this.metroCheckBox5.UseSelectable = true;
            this.metroCheckBox5.UseStyleColors = true;
            // 
            // metroCheckBox4
            // 
            this.metroCheckBox4.AutoSize = true;
            this.metroCheckBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_03_Present", true));
            this.metroCheckBox4.Location = new System.Drawing.Point(100, 130);
            this.metroCheckBox4.Name = "metroCheckBox4";
            this.metroCheckBox4.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox4.TabIndex = 98;
            this.metroCheckBox4.Text = " ";
            this.metroCheckBox4.UseSelectable = true;
            this.metroCheckBox4.UseStyleColors = true;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_02_Present", true));
            this.metroCheckBox3.Location = new System.Drawing.Point(100, 100);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox3.TabIndex = 97;
            this.metroCheckBox3.Text = " ";
            this.metroCheckBox3.UseSelectable = true;
            this.metroCheckBox3.UseStyleColors = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_01_Present", true));
            this.metroCheckBox1.Location = new System.Drawing.Point(100, 70);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox1.TabIndex = 96;
            this.metroCheckBox1.Text = " ";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.UseStyleColors = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_00_Present", true));
            this.metroCheckBox2.Location = new System.Drawing.Point(100, 40);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(26, 15);
            this.metroCheckBox2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox2.TabIndex = 95;
            this.metroCheckBox2.Text = " ";
            this.metroCheckBox2.UseSelectable = true;
            this.metroCheckBox2.UseStyleColors = true;
            // 
            // metroLabel19
            // 
            this.metroLabel19.Location = new System.Drawing.Point(61, 10);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(90, 19);
            this.metroLabel19.TabIndex = 92;
            this.metroLabel19.Text = "Bit presente:";
            this.metroLabel19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel18
            // 
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel18.Location = new System.Drawing.Point(10, 490);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(30, 19);
            this.metroLabel18.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel18.TabIndex = 91;
            this.metroLabel18.Text = "15";
            this.metroLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel18.UseStyleColors = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel17.Location = new System.Drawing.Point(10, 460);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(30, 19);
            this.metroLabel17.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel17.TabIndex = 90;
            this.metroLabel17.Text = "14";
            this.metroLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel17.UseStyleColors = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(10, 430);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(30, 19);
            this.metroLabel16.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel16.TabIndex = 89;
            this.metroLabel16.Text = "13";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel16.UseStyleColors = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(10, 400);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(30, 19);
            this.metroLabel15.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel15.TabIndex = 88;
            this.metroLabel15.Text = "12";
            this.metroLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel15.UseStyleColors = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(10, 370);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(30, 19);
            this.metroLabel14.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel14.TabIndex = 87;
            this.metroLabel14.Text = "11";
            this.metroLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel14.UseStyleColors = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(10, 340);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(30, 19);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel13.TabIndex = 86;
            this.metroLabel13.Text = "10";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel13.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(10, 310);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(30, 19);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel12.TabIndex = 85;
            this.metroLabel12.Text = "9";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel12.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(10, 280);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(30, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel10.TabIndex = 84;
            this.metroLabel10.Text = "8";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(10, 250);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(30, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel9.TabIndex = 83;
            this.metroLabel9.Text = "7";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(10, 220);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(30, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel8.TabIndex = 82;
            this.metroLabel8.Text = "6";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(10, 190);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(30, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel7.TabIndex = 81;
            this.metroLabel7.Text = "5";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(10, 160);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(30, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel6.TabIndex = 80;
            this.metroLabel6.Text = "4";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(10, 130);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(30, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel5.TabIndex = 79;
            this.metroLabel5.Text = "3";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(10, 100);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(30, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel4.TabIndex = 78;
            this.metroLabel4.Text = "2";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(10, 70);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(30, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 77;
            this.metroLabel3.Text = "1";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(10, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(30, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 76;
            this.metroLabel2.Text = "0";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.UseStyleColors = true;
            // 
            // tb_gv_Code
            // 
            // 
            // 
            // 
            this.tb_gv_Code.CustomButton.Image = null;
            this.tb_gv_Code.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.tb_gv_Code.CustomButton.Name = "";
            this.tb_gv_Code.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_gv_Code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_gv_Code.CustomButton.TabIndex = 1;
            this.tb_gv_Code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_gv_Code.CustomButton.UseSelectable = true;
            this.tb_gv_Code.CustomButton.Visible = false;
            this.tb_gv_Code.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmwareUIDigitalMessagesBindingSource, "UI_Dg_Bit_00_Desc_0", true));
            this.tb_gv_Code.Lines = new string[] {
        " "};
            this.tb_gv_Code.Location = new System.Drawing.Point(160, 36);
            this.tb_gv_Code.MaxLength = 32767;
            this.tb_gv_Code.Name = "tb_gv_Code";
            this.tb_gv_Code.PasswordChar = '\0';
            this.tb_gv_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_gv_Code.SelectedText = "";
            this.tb_gv_Code.SelectionLength = 0;
            this.tb_gv_Code.SelectionStart = 0;
            this.tb_gv_Code.ShortcutsEnabled = true;
            this.tb_gv_Code.Size = new System.Drawing.Size(250, 23);
            this.tb_gv_Code.Style = MetroFramework.MetroColorStyle.Red;
            this.tb_gv_Code.TabIndex = 74;
            this.tb_gv_Code.Text = " ";
            this.tb_gv_Code.UseSelectable = true;
            this.tb_gv_Code.UseStyleColors = true;
            this.tb_gv_Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_gv_Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(10, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(30, 19);
            this.metroLabel1.TabIndex = 75;
            this.metroLabel1.Text = "Bit:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tab_Event
            // 
            this.tab_Event.Controls.Add(this.gv_EventLogMessages);
            this.tab_Event.Name = "tab_Event";
            this.tab_Event.Size = new System.Drawing.Size(1247, 671);
            this.tab_Event.Text = "Event Log messages";
            // 
            // gv_EventLogMessages
            // 
            this.gv_EventLogMessages.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            this.gv_EventLogMessages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gv_EventLogMessages.AutoGenerateColumns = false;
            this.gv_EventLogMessages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_EventLogMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_EventLogMessages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_EventLogMessages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_EventLogMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gv_EventLogMessages.ColumnHeadersHeight = 60;
            this.gv_EventLogMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uIELPKDataGridViewTextBoxColumn,
            this.uIELSWCodeDataGridViewTextBoxColumn,
            this.uIELEventNumberDataGridViewTextBoxColumn,
            this.uIELChannelDataGridViewTextBoxColumn,
            this.uIELInputTypeDataGridViewCheckBoxColumn,
            this.uIELUMDataGridViewTextBoxColumn,
            this.uIELFormatDataGridViewTextBoxColumn,
            this.uIELMultiplierDataGridViewTextBoxColumn,
            this.uIELDescitDataGridViewTextBoxColumn,
            this.uIELDescenDataGridViewTextBoxColumn,
            this.uIELShowValOrDesDataGridViewTextBoxColumn,
            this.uIELObsoleteDataGridViewCheckBoxColumn,
            this.UI_EL_Totalizza});
            this.gv_EventLogMessages.ContextMenuStrip = this.Strip_Delete_EventLog;
            this.gv_EventLogMessages.DataSource = this.firmwareUIEventLogMessagesBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_EventLogMessages.DefaultCellStyle = dataGridViewCellStyle10;
            this.gv_EventLogMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_EventLogMessages.EnableHeadersVisualStyles = false;
            this.gv_EventLogMessages.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_EventLogMessages.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_EventLogMessages.Location = new System.Drawing.Point(0, 0);
            this.gv_EventLogMessages.MultiSelect = false;
            this.gv_EventLogMessages.Name = "gv_EventLogMessages";
            this.gv_EventLogMessages.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_EventLogMessages.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gv_EventLogMessages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_EventLogMessages.RowTemplate.Height = 30;
            this.gv_EventLogMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_EventLogMessages.Size = new System.Drawing.Size(1247, 671);
            this.gv_EventLogMessages.Style = MetroFramework.MetroColorStyle.Red;
            this.gv_EventLogMessages.TabIndex = 2;
            this.gv_EventLogMessages.UseStyleColors = true;
            // 
            // uIELPKDataGridViewTextBoxColumn
            // 
            this.uIELPKDataGridViewTextBoxColumn.DataPropertyName = "UI_EL_PK";
            this.uIELPKDataGridViewTextBoxColumn.HeaderText = "UI_EL_PK";
            this.uIELPKDataGridViewTextBoxColumn.Name = "uIELPKDataGridViewTextBoxColumn";
            this.uIELPKDataGridViewTextBoxColumn.ReadOnly = true;
            this.uIELPKDataGridViewTextBoxColumn.Visible = false;
            // 
            // uIELSWCodeDataGridViewTextBoxColumn
            // 
            this.uIELSWCodeDataGridViewTextBoxColumn.DataPropertyName = "UI_EL_SW_Code";
            this.uIELSWCodeDataGridViewTextBoxColumn.HeaderText = "UI_EL_SW_Code";
            this.uIELSWCodeDataGridViewTextBoxColumn.Name = "uIELSWCodeDataGridViewTextBoxColumn";
            this.uIELSWCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // uIELEventNumberDataGridViewTextBoxColumn
            // 
            this.uIELEventNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uIELEventNumberDataGridViewTextBoxColumn.DataPropertyName = "UI_EL_EventNumber";
            this.uIELEventNumberDataGridViewTextBoxColumn.HeaderText = "# Evento";
            this.uIELEventNumberDataGridViewTextBoxColumn.Name = "uIELEventNumberDataGridViewTextBoxColumn";
            this.uIELEventNumberDataGridViewTextBoxColumn.Width = 69;
            // 
            // uIELChannelDataGridViewTextBoxColumn
            // 
            this.uIELChannelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uIELChannelDataGridViewTextBoxColumn.DataPropertyName = "UI_EL_Channel";
            this.uIELChannelDataGridViewTextBoxColumn.HeaderText = "# Canale";
            this.uIELChannelDataGridViewTextBoxColumn.Name = "uIELChannelDataGridViewTextBoxColumn";
            this.uIELChannelDataGridViewTextBoxColumn.Width = 69;
            // 
            // uIELInputTypeDataGridViewCheckBoxColumn
            // 
            this.uIELInputTypeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uIELInputTypeDataGridViewCheckBoxColumn.DataPropertyName = "UI_EL_InputType";
            this.uIELInputTypeDataGridViewCheckBoxColumn.HeaderText = "Input di tipo Digitale";
            this.uIELInputTypeDataGridViewCheckBoxColumn.Name = "uIELInputTypeDataGridViewCheckBoxColumn";
            this.uIELInputTypeDataGridViewCheckBoxColumn.Width = 71;
            // 
            // uIELUMDataGridViewTextBoxColumn
            // 
            this.uIELUMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uIELUMDataGridViewTextBoxColumn.DataPropertyName = "UI_EL_UM";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.uIELUMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.uIELUMDataGridViewTextBoxColumn.HeaderText = "Unità di misura";
            this.uIELUMDataGridViewTextBoxColumn.Name = "uIELUMDataGridViewTextBoxColumn";
            this.uIELUMDataGridViewTextBoxColumn.Width = 68;
            // 
            // uIELFormatDataGridViewTextBoxColumn
            // 
            this.uIELFormatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uIELFormatDataGridViewTextBoxColumn.DataPropertyName = "UI_EL_Format";
            this.uIELFormatDataGridViewTextBoxColumn.HeaderText = "Formato di visualizzazione";
            this.uIELFormatDataGridViewTextBoxColumn.Name = "uIELFormatDataGridViewTextBoxColumn";
            this.uIELFormatDataGridViewTextBoxColumn.Width = 150;
            // 
            // uIELMultiplierDataGridViewTextBoxColumn
            // 
            this.uIELMultiplierDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uIELMultiplierDataGridViewTextBoxColumn.DataPropertyName = "UI_EL_Multiplier";
            this.uIELMultiplierDataGridViewTextBoxColumn.HeaderText = "Moltiplicatore da utilizzare";
            this.uIELMultiplierDataGridViewTextBoxColumn.Name = "uIELMultiplierDataGridViewTextBoxColumn";
            this.uIELMultiplierDataGridViewTextBoxColumn.Width = 111;
            // 
            // uIELDescitDataGridViewTextBoxColumn
            // 
            this.uIELDescitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uIELDescitDataGridViewTextBoxColumn.DataPropertyName = "UI_EL_Desc_it";
            this.uIELDescitDataGridViewTextBoxColumn.HeaderText = "Descrizione (IT)";
            this.uIELDescitDataGridViewTextBoxColumn.Name = "uIELDescitDataGridViewTextBoxColumn";
            // 
            // uIELDescenDataGridViewTextBoxColumn
            // 
            this.uIELDescenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uIELDescenDataGridViewTextBoxColumn.DataPropertyName = "UI_EL_Desc_en";
            this.uIELDescenDataGridViewTextBoxColumn.HeaderText = "Descrizione (EN)";
            this.uIELDescenDataGridViewTextBoxColumn.Name = "uIELDescenDataGridViewTextBoxColumn";
            // 
            // uIELShowValOrDesDataGridViewTextBoxColumn
            // 
            this.uIELShowValOrDesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.uIELShowValOrDesDataGridViewTextBoxColumn.DataPropertyName = "UI_EL_ShowValOrDes";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.uIELShowValOrDesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.uIELShowValOrDesDataGridViewTextBoxColumn.HeaderText = "Visualizza \'V\'-Valore / \'D\' - Descrizione";
            this.uIELShowValOrDesDataGridViewTextBoxColumn.Name = "uIELShowValOrDesDataGridViewTextBoxColumn";
            this.uIELShowValOrDesDataGridViewTextBoxColumn.Width = 94;
            // 
            // uIELObsoleteDataGridViewCheckBoxColumn
            // 
            this.uIELObsoleteDataGridViewCheckBoxColumn.DataPropertyName = "UI_EL_Obsolete";
            this.uIELObsoleteDataGridViewCheckBoxColumn.HeaderText = "Obsoleto";
            this.uIELObsoleteDataGridViewCheckBoxColumn.Name = "uIELObsoleteDataGridViewCheckBoxColumn";
            // 
            // UI_EL_Totalizza
            // 
            this.UI_EL_Totalizza.DataPropertyName = "UI_EL_Totalizza";
            this.UI_EL_Totalizza.HeaderText = "Totalizza";
            this.UI_EL_Totalizza.Name = "UI_EL_Totalizza";
            // 
            // firmwareUIEventLogMessagesBindingSource
            // 
            this.firmwareUIEventLogMessagesBindingSource.DataMember = "Firmware_UI_EventLog_Messages";
            this.firmwareUIEventLogMessagesBindingSource.DataSource = this.firmwareBindingSource;
            this.firmwareUIEventLogMessagesBindingSource.Sort = "UI_EL_EventNumber asc,  UI_EL_Channel asc";
            // 
            // firmwareTableAdapter
            // 
            this.firmwareTableAdapter.ClearBeforeFill = true;
            // 
            // uI_Analog_MessagesTableAdapter
            // 
            this.uI_Analog_MessagesTableAdapter.ClearBeforeFill = true;
            // 
            // uI_Digital_MessagesTableAdapter
            // 
            this.uI_Digital_MessagesTableAdapter.ClearBeforeFill = true;
            // 
            // uI_EventLog_MessagesTableAdapter
            // 
            this.uI_EventLog_MessagesTableAdapter.ClearBeforeFill = true;
            // 
            // Strip_Delete_EventLog
            // 
            this.Strip_Delete_EventLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminaRigaToolStripMenuItem});
            this.Strip_Delete_EventLog.Name = "Strip_Delete_EventLog";
            this.Strip_Delete_EventLog.Size = new System.Drawing.Size(181, 48);
            // 
            // eliminaRigaToolStripMenuItem
            // 
            this.eliminaRigaToolStripMenuItem.Name = "eliminaRigaToolStripMenuItem";
            this.eliminaRigaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminaRigaToolStripMenuItem.Text = "Elimina Riga";
            this.eliminaRigaToolStripMenuItem.Click += new System.EventHandler(this.eliminaRigaToolStripMenuItem_Click);
            // 
            // UC_RealTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 867);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.layout_orizz_menu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DisplayHeader = false;
            this.Name = "UC_RealTime";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UC_RealTime_Load);
            this.layout_orizz_menu.ResumeLayout(false);
            this.layout_orizz_menu.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            this.pan_Menu_salva.ResumeLayout(false);
            this.pan_Menu_salva.PerformLayout();
            this.pan_Menu_comandi.ResumeLayout(false);
            this.pan_Menu_comandi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.layout_menu_control.ResumeLayout(false);
            this.layout_menu_control.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_RealTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbed_pages)).EndInit();
            this.tabbed_pages.ResumeLayout(false);
            this.tab_Analog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_AnalogMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmwareUIAnalogMessagesBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tab_Digital.ResumeLayout(false);
            this.panel_digital_messages.ResumeLayout(false);
            this.panel_digital_messages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmwareUIDigitalMessagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab_Event.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_EventLogMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmwareUIEventLogMessagesBindingSource)).EndInit();
            this.Strip_Delete_EventLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout_orizz_menu;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit repositoryItemPageNumberEdit1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.ComboBox cb_Fw_Code;
        private ds_RealTime ds_RealTime;
        private System.Windows.Forms.BindingSource firmwareBindingSource;
        private ds_RealTimeTableAdapters.FirmwareTableAdapter firmwareTableAdapter;
        private MetroFramework.Controls.MetroLabel lab_Fw_Des_En;
        private MetroFramework.Controls.MetroLabel lab_Fw_Des;
        private DevExpress.XtraTab.XtraTabControl tabbed_pages;
        private DevExpress.XtraTab.XtraTabPage tab_Analog;
        private DevExpress.XtraTab.XtraTabPage tab_Digital;
        private DevExpress.XtraTab.XtraTabPage tab_Event;
        private MetroFramework.Controls.MetroGrid gv_AnalogMessages;
        private System.Windows.Forms.BindingSource firmwareUIAnalogMessagesBindingSource;
        private ds_RealTimeTableAdapters.UI_Analog_MessagesTableAdapter uI_Analog_MessagesTableAdapter;
        private System.Windows.Forms.BindingSource firmwareUIDigitalMessagesBindingSource;
        private ds_RealTimeTableAdapters.UI_Digital_MessagesTableAdapter uI_Digital_MessagesTableAdapter;
        private MetroFramework.Controls.MetroGrid gv_EventLogMessages;
        private System.Windows.Forms.BindingSource firmwareUIEventLogMessagesBindingSource;
        private ds_RealTimeTableAdapters.UI_EventLog_MessagesTableAdapter uI_EventLog_MessagesTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroButton but_Preview;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIAnPKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIAnSWCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIAnProgrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIAnGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIAnDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIAnDisplayOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIAnDisplayOrderGroupElementsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIAnFormatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIAnUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIAnMultiplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CBUI_An_Icon_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIAnIconNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIAnMinValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIAnMaxValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIAnRefDgAlarmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIAnThresholdDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uIAnObsoleteDataGridViewCheckBoxColumn;
        private MetroFramework.Controls.MetroPanel panel_digital_messages;
        private MetroFramework.Controls.MetroTextBox metroTextBox30;
        private MetroFramework.Controls.MetroTextBox metroTextBox31;
        private MetroFramework.Controls.MetroTextBox metroTextBox28;
        private MetroFramework.Controls.MetroTextBox metroTextBox29;
        private MetroFramework.Controls.MetroTextBox metroTextBox26;
        private MetroFramework.Controls.MetroTextBox metroTextBox27;
        private MetroFramework.Controls.MetroTextBox metroTextBox24;
        private MetroFramework.Controls.MetroTextBox metroTextBox25;
        private MetroFramework.Controls.MetroTextBox metroTextBox22;
        private MetroFramework.Controls.MetroTextBox metroTextBox23;
        private MetroFramework.Controls.MetroTextBox metroTextBox20;
        private MetroFramework.Controls.MetroTextBox metroTextBox21;
        private MetroFramework.Controls.MetroTextBox metroTextBox18;
        private MetroFramework.Controls.MetroTextBox metroTextBox19;
        private MetroFramework.Controls.MetroTextBox metroTextBox16;
        private MetroFramework.Controls.MetroTextBox metroTextBox17;
        private MetroFramework.Controls.MetroTextBox metroTextBox14;
        private MetroFramework.Controls.MetroTextBox metroTextBox15;
        private MetroFramework.Controls.MetroTextBox metroTextBox12;
        private MetroFramework.Controls.MetroTextBox metroTextBox13;
        private MetroFramework.Controls.MetroTextBox metroTextBox10;
        private MetroFramework.Controls.MetroTextBox metroTextBox11;
        private MetroFramework.Controls.MetroTextBox metroTextBox8;
        private MetroFramework.Controls.MetroTextBox metroTextBox9;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroTextBox metroTextBox7;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox16;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox15;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox14;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox13;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox12;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox11;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox10;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox9;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox8;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox7;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox6;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox5;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tb_gv_Code;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroTextBox Rif_val_15;
        private MetroFramework.Controls.MetroTextBox Rif_val_14;
        private MetroFramework.Controls.MetroTextBox Rif_val_13;
        private MetroFramework.Controls.MetroTextBox Rif_val_12;
        private MetroFramework.Controls.MetroTextBox Rif_val_11;
        private MetroFramework.Controls.MetroTextBox Rif_val_10;
        private MetroFramework.Controls.MetroTextBox Rif_val_09;
        private MetroFramework.Controls.MetroTextBox Rif_val_08;
        private MetroFramework.Controls.MetroTextBox Rif_val_07;
        private MetroFramework.Controls.MetroTextBox Rif_val_06;
        private MetroFramework.Controls.MetroTextBox Rif_val_05;
        private MetroFramework.Controls.MetroTextBox Rif_val_04;
        private MetroFramework.Controls.MetroTextBox Rif_val_03;
        private MetroFramework.Controls.MetroTextBox Rif_val_02;
        private MetroFramework.Controls.MetroTextBox Rif_val_01;
        private MetroFramework.Controls.MetroTextBox Rif_val_00;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private System.Windows.Forms.ComboBox cb_00_icon_0;
        private System.Windows.Forms.ComboBox cb_15_icon_0;
        private System.Windows.Forms.ComboBox cb_14_icon_0;
        private System.Windows.Forms.ComboBox cb_13_icon_0;
        private System.Windows.Forms.ComboBox cb_12_icon_0;
        private System.Windows.Forms.ComboBox cb_11_icon_0;
        private System.Windows.Forms.ComboBox cb_10_icon_0;
        private System.Windows.Forms.ComboBox cb_09_icon_0;
        private System.Windows.Forms.ComboBox cb_08_icon_0;
        private System.Windows.Forms.ComboBox cb_07_icon_0;
        private System.Windows.Forms.ComboBox cb_06_icon_0;
        private System.Windows.Forms.ComboBox cb_05_icon_0;
        private System.Windows.Forms.ComboBox cb_04_icon_0;
        private System.Windows.Forms.ComboBox cb_03_icon_0;
        private System.Windows.Forms.ComboBox cb_02_icon_0;
        private System.Windows.Forms.ComboBox cb_01_icon_0;
        private System.Windows.Forms.ComboBox cb_15_icon_1;
        private System.Windows.Forms.ComboBox cb_14_icon_1;
        private System.Windows.Forms.ComboBox cb_13_icon_1;
        private System.Windows.Forms.ComboBox cb_12_icon_1;
        private System.Windows.Forms.ComboBox cb_11_icon_1;
        private System.Windows.Forms.ComboBox cb_10_icon_1;
        private System.Windows.Forms.ComboBox cb_09_icon_1;
        private System.Windows.Forms.ComboBox cb_08_icon_1;
        private System.Windows.Forms.ComboBox cb_07_icon_1;
        private System.Windows.Forms.ComboBox cb_06_icon_1;
        private System.Windows.Forms.ComboBox cb_05_icon_1;
        private System.Windows.Forms.ComboBox cb_04_icon_1;
        private System.Windows.Forms.ComboBox cb_03_icon_1;
        private System.Windows.Forms.ComboBox cb_02_icon_1;
        private System.Windows.Forms.ComboBox cb_01_icon_1;
        private System.Windows.Forms.ComboBox cb_00_icon_1;
        private System.Windows.Forms.MenuStrip pan_Menu_comandi;
        private System.Windows.Forms.ToolStripMenuItem menu_edit;
        private System.Windows.Forms.MenuStrip pan_Menu_salva;
        private System.Windows.Forms.ToolStripMenuItem menu_salva;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_div12;
        private System.Windows.Forms.ToolStripMenuItem menu_annulla;
        private System.Windows.Forms.TableLayoutPanel layout_menu_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIELPKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIELSWCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIELEventNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIELChannelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uIELInputTypeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIELUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIELFormatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIELMultiplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIELDescitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIELDescenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIELShowValOrDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uIELObsoleteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UI_EL_Totalizza;
        private System.Windows.Forms.ContextMenuStrip Strip_Delete_EventLog;
        private System.Windows.Forms.ToolStripMenuItem eliminaRigaToolStripMenuItem;
    }
}
