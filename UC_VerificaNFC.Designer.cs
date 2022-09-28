namespace SmartLineProduction
{
    partial class UC_VerificaNFC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_VerificaNFC));
            this.layout_orizz_menu = new System.Windows.Forms.TableLayoutPanel();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_SN = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Qr = new MetroFramework.Controls.MetroTextBox();
            this.pic_Result = new System.Windows.Forms.PictureBox();
            this.Lab_ReadScanner = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_input = new MetroFramework.Controls.MetroPanel();
            this.tbx_ReadLabel_Device = new MetroFramework.Controls.MetroTextBox();
            this.but_Reset = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lab_ReadRfid = new MetroFramework.Controls.MetroLabel();
            this.Progress = new MetroFramework.Controls.MetroProgressBar();
            this.tb_Nfc = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtSafetyPointRFIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_SafetyPointNFC = new SmartLineProduction.ds_SafetyPointNFC();
            this.time_read = new System.Windows.Forms.Timer(this.components);
            this.time_progress = new System.Windows.Forms.Timer(this.components);
            this.dt_SafetyPointRFIDTableAdapter = new SmartLineProduction.ds_SafetyPointNFCTableAdapters.dt_SafetyPointRFIDTableAdapter();
            this.pan_newtag_Rfid = new MetroFramework.Controls.MetroPanel();
            this.pan_newtag_Scanner = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lab_newRfid = new MetroFramework.Controls.MetroLabel();
            this.layout_orizz_menu.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            this.panel_SN.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSafetyPointRFIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SafetyPointNFC)).BeginInit();
            this.pan_newtag_Rfid.SuspendLayout();
            this.pan_newtag_Scanner.SuspendLayout();
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
            // panel_SN
            // 
            this.panel_SN.Controls.Add(this.tableLayoutPanel1);
            this.panel_SN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SN.HorizontalScrollbarBarColor = true;
            this.panel_SN.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_SN.HorizontalScrollbarSize = 10;
            this.panel_SN.Location = new System.Drawing.Point(20, 55);
            this.panel_SN.Name = "panel_SN";
            this.panel_SN.Size = new System.Drawing.Size(839, 657);
            this.panel_SN.TabIndex = 0;
            this.panel_SN.VerticalScrollbarBarColor = true;
            this.panel_SN.VerticalScrollbarHighlightOnWheel = false;
            this.panel_SN.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Progress, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lab_ReadRfid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pan_newtag_Rfid, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pan_newtag_Scanner, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Lab_ReadScanner, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Qr, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_Nfc, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pic_Result, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel_input, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 657);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tb_Qr
            // 
            // 
            // 
            // 
            this.tb_Qr.CustomButton.Image = null;
            this.tb_Qr.CustomButton.Location = new System.Drawing.Point(322, 2);
            this.tb_Qr.CustomButton.Name = "";
            this.tb_Qr.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.tb_Qr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Qr.CustomButton.TabIndex = 1;
            this.tb_Qr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Qr.CustomButton.UseSelectable = true;
            this.tb_Qr.CustomButton.Visible = false;
            this.tb_Qr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Qr.Lines = new string[] {
        "tb_Qr"};
            this.tb_Qr.Location = new System.Drawing.Point(422, 399);
            this.tb_Qr.MaxLength = 32767;
            this.tb_Qr.Name = "tb_Qr";
            this.tb_Qr.PasswordChar = '\0';
            this.tb_Qr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Qr.SelectedText = "";
            this.tb_Qr.SelectionLength = 0;
            this.tb_Qr.SelectionStart = 0;
            this.tb_Qr.ShortcutsEnabled = true;
            this.tb_Qr.Size = new System.Drawing.Size(414, 94);
            this.tb_Qr.TabIndex = 11;
            this.tb_Qr.Text = "tb_Qr";
            this.tb_Qr.UseSelectable = true;
            this.tb_Qr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Qr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pic_Result
            // 
            this.pic_Result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.pic_Result, 2);
            this.pic_Result.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_Result.InitialImage")));
            this.pic_Result.Location = new System.Drawing.Point(369, 565);
            this.pic_Result.Name = "pic_Result";
            this.pic_Result.Size = new System.Drawing.Size(100, 100);
            this.pic_Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Result.TabIndex = 9;
            this.pic_Result.TabStop = false;
            // 
            // Lab_ReadScanner
            // 
            this.Lab_ReadScanner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lab_ReadScanner.AutoSize = true;
            this.Lab_ReadScanner.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Lab_ReadScanner.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Lab_ReadScanner.Location = new System.Drawing.Point(549, 328);
            this.Lab_ReadScanner.Name = "Lab_ReadScanner";
            this.Lab_ReadScanner.Size = new System.Drawing.Size(160, 25);
            this.Lab_ReadScanner.TabIndex = 7;
            this.Lab_ReadScanner.Text = "Lab_ReadScanner";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::SmartLineProduction.Properties.Resources.Lettori_Scanner;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(479, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel_input
            // 
            this.panel_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.panel_input, 2);
            this.panel_input.Controls.Add(this.tbx_ReadLabel_Device);
            this.panel_input.Controls.Add(this.but_Reset);
            this.panel_input.HorizontalScrollbarBarColor = true;
            this.panel_input.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_input.HorizontalScrollbarSize = 10;
            this.panel_input.Location = new System.Drawing.Point(219, 499);
            this.panel_input.Name = "panel_input";
            this.panel_input.Size = new System.Drawing.Size(400, 60);
            this.panel_input.TabIndex = 3;
            this.panel_input.VerticalScrollbarBarColor = true;
            this.panel_input.VerticalScrollbarHighlightOnWheel = false;
            this.panel_input.VerticalScrollbarSize = 10;
            // 
            // tbx_ReadLabel_Device
            // 
            // 
            // 
            // 
            this.tbx_ReadLabel_Device.CustomButton.Image = null;
            this.tbx_ReadLabel_Device.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.tbx_ReadLabel_Device.CustomButton.Name = "";
            this.tbx_ReadLabel_Device.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbx_ReadLabel_Device.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_ReadLabel_Device.CustomButton.TabIndex = 1;
            this.tbx_ReadLabel_Device.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_ReadLabel_Device.CustomButton.UseSelectable = true;
            this.tbx_ReadLabel_Device.CustomButton.Visible = false;
            this.tbx_ReadLabel_Device.Lines = new string[0];
            this.tbx_ReadLabel_Device.Location = new System.Drawing.Point(0, 26);
            this.tbx_ReadLabel_Device.MaxLength = 32767;
            this.tbx_ReadLabel_Device.Multiline = true;
            this.tbx_ReadLabel_Device.Name = "tbx_ReadLabel_Device";
            this.tbx_ReadLabel_Device.PasswordChar = '\0';
            this.tbx_ReadLabel_Device.PromptText = "Lettura del QR-Code o del Lettore NFC";
            this.tbx_ReadLabel_Device.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx_ReadLabel_Device.SelectedText = "";
            this.tbx_ReadLabel_Device.SelectionLength = 0;
            this.tbx_ReadLabel_Device.SelectionStart = 0;
            this.tbx_ReadLabel_Device.ShortcutsEnabled = true;
            this.tbx_ReadLabel_Device.Size = new System.Drawing.Size(276, 23);
            this.tbx_ReadLabel_Device.TabIndex = 0;
            this.tbx_ReadLabel_Device.UseSelectable = true;
            this.tbx_ReadLabel_Device.WaterMark = "Lettura del QR-Code o del Lettore NFC";
            this.tbx_ReadLabel_Device.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_ReadLabel_Device.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbx_ReadLabel_Device.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ReadLabel_Device_KeyPress);
            this.tbx_ReadLabel_Device.Leave += new System.EventHandler(this.tbx_ReadLabel_Device_Leave);
            // 
            // but_Reset
            // 
            this.but_Reset.BackColor = System.Drawing.Color.White;
            this.but_Reset.Location = new System.Drawing.Point(282, 26);
            this.but_Reset.Name = "but_Reset";
            this.but_Reset.Size = new System.Drawing.Size(105, 23);
            this.but_Reset.Style = MetroFramework.MetroColorStyle.Green;
            this.but_Reset.TabIndex = 1;
            this.but_Reset.Text = "Reset";
            this.but_Reset.UseSelectable = true;
            this.but_Reset.UseStyleColors = true;
            this.but_Reset.Click += new System.EventHandler(this.but_AttivaProc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::SmartLineProduction.Properties.Resources.Lettori_Rfid;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Lab_ReadRfid
            // 
            this.Lab_ReadRfid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lab_ReadRfid.AutoSize = true;
            this.Lab_ReadRfid.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Lab_ReadRfid.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Lab_ReadRfid.Location = new System.Drawing.Point(146, 328);
            this.Lab_ReadRfid.Name = "Lab_ReadRfid";
            this.Lab_ReadRfid.Size = new System.Drawing.Size(127, 25);
            this.Lab_ReadRfid.TabIndex = 6;
            this.Lab_ReadRfid.Text = "Lab_ReadRfid";
            // 
            // Progress
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Progress, 2);
            this.Progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Progress.Location = new System.Drawing.Point(3, 3);
            this.Progress.Maximum = 6000;
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(833, 4);
            this.Progress.Style = MetroFramework.MetroColorStyle.Silver;
            this.Progress.TabIndex = 8;
            this.Progress.UseCustomBackColor = true;
            this.Progress.Value = 3200;
            // 
            // tb_Nfc
            // 
            // 
            // 
            // 
            this.tb_Nfc.CustomButton.Image = null;
            this.tb_Nfc.CustomButton.Location = new System.Drawing.Point(321, 2);
            this.tb_Nfc.CustomButton.Name = "";
            this.tb_Nfc.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.tb_Nfc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Nfc.CustomButton.TabIndex = 1;
            this.tb_Nfc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Nfc.CustomButton.UseSelectable = true;
            this.tb_Nfc.CustomButton.Visible = false;
            this.tb_Nfc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Nfc.Lines = new string[] {
        "tb_Nfc"};
            this.tb_Nfc.Location = new System.Drawing.Point(3, 399);
            this.tb_Nfc.MaxLength = 32767;
            this.tb_Nfc.Name = "tb_Nfc";
            this.tb_Nfc.PasswordChar = '\0';
            this.tb_Nfc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Nfc.SelectedText = "";
            this.tb_Nfc.SelectionLength = 0;
            this.tb_Nfc.SelectionStart = 0;
            this.tb_Nfc.ShortcutsEnabled = true;
            this.tb_Nfc.Size = new System.Drawing.Size(413, 94);
            this.tb_Nfc.TabIndex = 10;
            this.tb_Nfc.Text = "tb_Nfc";
            this.tb_Nfc.UseSelectable = true;
            this.tb_Nfc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Nfc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.DataSource = this.dtSafetyPointRFIDBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 671);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(833, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Rfid_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Rfid_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 68;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Rfid_UUID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Rfid_UUID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 84;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Rfid_Technology";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rfid_Technology";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 113;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Rfid_Ser_SN_Prod";
            this.dataGridViewTextBoxColumn4.HeaderText = "Rfid_Ser_SN_Prod";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 122;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Rfid_Obsolete";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Rfid_Obsolete";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 80;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Rfid_Verified";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Rfid_Verified";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 73;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Rfid_Note";
            this.dataGridViewTextBoxColumn5.HeaderText = "Rfid_Note";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dtSafetyPointRFIDBindingSource
            // 
            this.dtSafetyPointRFIDBindingSource.DataMember = "dt_SafetyPointRFID";
            this.dtSafetyPointRFIDBindingSource.DataSource = this.ds_SafetyPointNFC;
            // 
            // ds_SafetyPointNFC
            // 
            this.ds_SafetyPointNFC.DataSetName = "ds_SafetyPointNFC";
            this.ds_SafetyPointNFC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // time_read
            // 
            this.time_read.Interval = 10000;
            this.time_read.Tick += new System.EventHandler(this.time_read_Tick);
            // 
            // time_progress
            // 
            this.time_progress.Enabled = true;
            this.time_progress.Tick += new System.EventHandler(this.time_progress_Tick);
            // 
            // dt_SafetyPointRFIDTableAdapter
            // 
            this.dt_SafetyPointRFIDTableAdapter.ClearBeforeFill = true;
            // 
            // pan_newtag_Rfid
            // 
            this.pan_newtag_Rfid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pan_newtag_Rfid.Controls.Add(this.lab_newRfid);
            this.pan_newtag_Rfid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_newtag_Rfid.HorizontalScrollbarBarColor = true;
            this.pan_newtag_Rfid.HorizontalScrollbarHighlightOnWheel = false;
            this.pan_newtag_Rfid.HorizontalScrollbarSize = 10;
            this.pan_newtag_Rfid.Location = new System.Drawing.Point(3, 369);
            this.pan_newtag_Rfid.Name = "pan_newtag_Rfid";
            this.pan_newtag_Rfid.Size = new System.Drawing.Size(413, 24);
            this.pan_newtag_Rfid.TabIndex = 13;
            this.pan_newtag_Rfid.UseCustomBackColor = true;
            this.pan_newtag_Rfid.VerticalScrollbarBarColor = true;
            this.pan_newtag_Rfid.VerticalScrollbarHighlightOnWheel = false;
            this.pan_newtag_Rfid.VerticalScrollbarSize = 10;
            // 
            // pan_newtag_Scanner
            // 
            this.pan_newtag_Scanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pan_newtag_Scanner.Controls.Add(this.metroLabel1);
            this.pan_newtag_Scanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_newtag_Scanner.HorizontalScrollbarBarColor = true;
            this.pan_newtag_Scanner.HorizontalScrollbarHighlightOnWheel = false;
            this.pan_newtag_Scanner.HorizontalScrollbarSize = 10;
            this.pan_newtag_Scanner.Location = new System.Drawing.Point(422, 369);
            this.pan_newtag_Scanner.Name = "pan_newtag_Scanner";
            this.pan_newtag_Scanner.Size = new System.Drawing.Size(414, 24);
            this.pan_newtag_Scanner.TabIndex = 14;
            this.pan_newtag_Scanner.UseCustomBackColor = true;
            this.pan_newtag_Scanner.VerticalScrollbarBarColor = true;
            this.pan_newtag_Scanner.VerticalScrollbarHighlightOnWheel = false;
            this.pan_newtag_Scanner.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Red;
            this.metroLabel1.Location = new System.Drawing.Point(180, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "NEW";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // lab_newRfid
            // 
            this.lab_newRfid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_newRfid.AutoSize = true;
            this.lab_newRfid.BackColor = System.Drawing.Color.Transparent;
            this.lab_newRfid.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lab_newRfid.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_newRfid.ForeColor = System.Drawing.Color.Red;
            this.lab_newRfid.Location = new System.Drawing.Point(179, 0);
            this.lab_newRfid.Name = "lab_newRfid";
            this.lab_newRfid.Size = new System.Drawing.Size(54, 25);
            this.lab_newRfid.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_newRfid.TabIndex = 8;
            this.lab_newRfid.Text = "NEW";
            this.lab_newRfid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_newRfid.UseCustomBackColor = true;
            this.lab_newRfid.UseStyleColors = true;
            // 
            // UC_VerificaNFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 732);
            this.ControlBox = false;
            this.Controls.Add(this.panel_SN);
            this.Controls.Add(this.layout_orizz_menu);
            this.DisplayHeader = false;
            this.Name = "UC_VerificaNFC";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UC_VerificaNFC_Load);
            this.Shown += new System.EventHandler(this.UC_VerificaNFC_Shown);
            this.layout_orizz_menu.ResumeLayout(false);
            this.layout_orizz_menu.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            this.panel_SN.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_input.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSafetyPointRFIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SafetyPointNFC)).EndInit();
            this.pan_newtag_Rfid.ResumeLayout(false);
            this.pan_newtag_Rfid.PerformLayout();
            this.pan_newtag_Scanner.ResumeLayout(false);
            this.pan_newtag_Scanner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout_orizz_menu;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private MetroFramework.Controls.MetroPanel panel_SN;
        private MetroFramework.Controls.MetroTextBox tbx_ReadLabel_Device;
        private MetroFramework.Controls.MetroButton but_Reset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel panel_input;
        private System.Windows.Forms.BindingSource uIEventsUniBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uIEventsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmwareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIELMultiplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valMoltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIELDescitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIELDescenDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel Lab_ReadScanner;
        private MetroFramework.Controls.MetroLabel Lab_ReadRfid;
        private MetroFramework.Controls.MetroProgressBar Progress;
        private System.Windows.Forms.Timer time_read;
        private System.Windows.Forms.Timer time_progress;
        private System.Windows.Forms.PictureBox pic_Result;
        private MetroFramework.Controls.MetroTextBox tb_Qr;
        private MetroFramework.Controls.MetroTextBox tb_Nfc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfidIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfidUUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfidTechnologyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfidSerSNProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rfidObsoleteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rfidVerifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfidNoteDataGridViewTextBoxColumn;
        private ds_SafetyPointNFC ds_SafetyPointNFC;
        private System.Windows.Forms.BindingSource dtSafetyPointRFIDBindingSource;
        private ds_SafetyPointNFCTableAdapters.dt_SafetyPointRFIDTableAdapter dt_SafetyPointRFIDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private MetroFramework.Controls.MetroPanel pan_newtag_Rfid;
        private MetroFramework.Controls.MetroLabel lab_newRfid;
        private MetroFramework.Controls.MetroPanel pan_newtag_Scanner;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
