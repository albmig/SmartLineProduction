namespace SmartLineProduction
{
    partial class UC_Programmazione_Clona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Programmazione_Clona));
            this.layout_orizz_menu = new System.Windows.Forms.TableLayoutPanel();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.sF_ParcoTableAdapter = new SmartLineProduction.ds_SLTableAdapters.SF_ParcoTableAdapter();
            this.sFParcoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_SL = new SmartLineProduction.ds_SL();
            this.lab_read_commessa = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.outputPanel = new MetroFramework.Controls.MetroPanel();
            this.dos_box = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.but_Programma = new MetroFramework.Controls.MetroButton();
            this.lab_read_ID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lab_read_FW = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lab_read_Device = new MetroFramework.Controls.MetroLabel();
            this.lab_read_SN = new MetroFramework.Controls.MetroLabel();
            this.lab_Etichetta = new MetroFramework.Controls.MetroLabel();
            this.tbx_ReadLabel_Device = new MetroFramework.Controls.MetroTextBox();
            this.ds_Programmazione = new SmartLineProduction.ds_Programmazione();
            this.serialNumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serialNumbersTableAdapter = new SmartLineProduction.ds_ProgrammazioneTableAdapters.SerialNumbersTableAdapter();
            this.sFLastSerialNumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sF_LastSerialNumberTableAdapter = new SmartLineProduction.ds_ProgrammazioneTableAdapters.SF_LastSerialNumberTableAdapter();
            this.firmwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmwareTableAdapter = new SmartLineProduction.ds_ProgrammazioneTableAdapters.FirmwareTableAdapter();
            this.serialNumbersObsoleteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serialNumbers_ObsoleteTableAdapter = new SmartLineProduction.ds_ProgrammazioneTableAdapters.SerialNumbers_ObsoleteTableAdapter();
            this.layout_Clona = new System.Windows.Forms.TableLayoutPanel();
            this.layout_orizz_menu.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFParcoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).BeginInit();
            this.outputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Programmazione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumbersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFLastSerialNumberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumbersObsoleteBindingSource)).BeginInit();
            this.layout_Clona.SuspendLayout();
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
            this.layout_orizz_menu.Size = new System.Drawing.Size(1094, 25);
            this.layout_orizz_menu.TabIndex = 120;
            // 
            // pan_Menu_exit
            // 
            this.pan_Menu_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_Menu_exit.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_Menu_exit.Dock = System.Windows.Forms.DockStyle.None;
            this.pan_Menu_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sw_exit});
            this.pan_Menu_exit.Location = new System.Drawing.Point(1019, 0);
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
            // sF_ParcoTableAdapter
            // 
            this.sF_ParcoTableAdapter.ClearBeforeFill = true;
            // 
            // sFParcoBindingSource
            // 
            this.sFParcoBindingSource.DataMember = "SF_Parco";
            // 
            // ds_SL
            // 
            this.ds_SL.DataSetName = "ds_SL";
            this.ds_SL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lab_read_commessa
            // 
            this.lab_read_commessa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_read_commessa.AutoSize = true;
            this.lab_read_commessa.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_read_commessa.Location = new System.Drawing.Point(275, 124);
            this.lab_read_commessa.Name = "lab_read_commessa";
            this.lab_read_commessa.Size = new System.Drawing.Size(130, 19);
            this.lab_read_commessa.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_read_commessa.TabIndex = 75;
            this.lab_read_commessa.Text = "lab_read_commessa";
            this.lab_read_commessa.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(3, 124);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(79, 19);
            this.metroLabel7.TabIndex = 74;
            this.metroLabel7.Text = "Commessa:";
            // 
            // outputPanel
            // 
            this.outputPanel.Controls.Add(this.dos_box);
            this.outputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPanel.HorizontalScrollbarBarColor = true;
            this.outputPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.outputPanel.HorizontalScrollbarSize = 10;
            this.outputPanel.Location = new System.Drawing.Point(550, 3);
            this.outputPanel.Name = "outputPanel";
            this.layout_Clona.SetRowSpan(this.outputPanel, 11);
            this.outputPanel.Size = new System.Drawing.Size(541, 620);
            this.outputPanel.TabIndex = 73;
            this.outputPanel.VerticalScrollbarBarColor = true;
            this.outputPanel.VerticalScrollbarHighlightOnWheel = false;
            this.outputPanel.VerticalScrollbarSize = 10;
            // 
            // dos_box
            // 
            this.dos_box.BackColor = System.Drawing.Color.White;
            this.dos_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dos_box.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dos_box.ForeColor = System.Drawing.Color.Black;
            this.dos_box.Location = new System.Drawing.Point(0, 0);
            this.dos_box.Multiline = true;
            this.dos_box.Name = "dos_box";
            this.dos_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dos_box.Size = new System.Drawing.Size(541, 620);
            this.dos_box.TabIndex = 68;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(3, 67);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(26, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "ID:";
            // 
            // but_Programma
            // 
            this.but_Programma.BackColor = System.Drawing.Color.White;
            this.layout_Clona.SetColumnSpan(this.but_Programma, 2);
            this.but_Programma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_Programma.Location = new System.Drawing.Point(3, 372);
            this.but_Programma.Name = "but_Programma";
            this.but_Programma.Size = new System.Drawing.Size(538, 23);
            this.but_Programma.Style = MetroFramework.MetroColorStyle.Green;
            this.but_Programma.TabIndex = 1;
            this.but_Programma.Text = "Programma";
            this.but_Programma.UseSelectable = true;
            this.but_Programma.UseStyleColors = true;
            this.but_Programma.Click += new System.EventHandler(this.but_Programma_Click);
            // 
            // lab_read_ID
            // 
            this.lab_read_ID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_read_ID.AutoSize = true;
            this.lab_read_ID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_read_ID.Location = new System.Drawing.Point(275, 67);
            this.lab_read_ID.Name = "lab_read_ID";
            this.lab_read_ID.Size = new System.Drawing.Size(80, 19);
            this.lab_read_ID.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_read_ID.TabIndex = 9;
            this.lab_read_ID.Text = "lab_read_ID";
            this.lab_read_ID.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 48);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Numero di serie:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(3, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Device:";
            // 
            // lab_read_FW
            // 
            this.lab_read_FW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_read_FW.AutoSize = true;
            this.lab_read_FW.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_read_FW.Location = new System.Drawing.Point(275, 105);
            this.lab_read_FW.Name = "lab_read_FW";
            this.lab_read_FW.Size = new System.Drawing.Size(86, 19);
            this.lab_read_FW.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_read_FW.TabIndex = 7;
            this.lab_read_FW.Text = "lab_read_FW";
            this.lab_read_FW.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(3, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(127, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Firmware installato:";
            // 
            // lab_read_Device
            // 
            this.lab_read_Device.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_read_Device.AutoSize = true;
            this.lab_read_Device.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_read_Device.Location = new System.Drawing.Point(275, 86);
            this.lab_read_Device.Name = "lab_read_Device";
            this.lab_read_Device.Size = new System.Drawing.Size(106, 19);
            this.lab_read_Device.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_read_Device.TabIndex = 6;
            this.lab_read_Device.Text = "lab_read_Device";
            this.lab_read_Device.UseStyleColors = true;
            // 
            // lab_read_SN
            // 
            this.lab_read_SN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_read_SN.AutoSize = true;
            this.lab_read_SN.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_read_SN.Location = new System.Drawing.Point(275, 48);
            this.lab_read_SN.Name = "lab_read_SN";
            this.lab_read_SN.Size = new System.Drawing.Size(83, 19);
            this.lab_read_SN.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_read_SN.TabIndex = 5;
            this.lab_read_SN.Text = "lab_read_SN";
            this.lab_read_SN.UseStyleColors = true;
            // 
            // lab_Etichetta
            // 
            this.lab_Etichetta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_Etichetta.AutoSize = true;
            this.layout_Clona.SetColumnSpan(this.lab_Etichetta, 2);
            this.lab_Etichetta.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_Etichetta.Location = new System.Drawing.Point(3, 0);
            this.lab_Etichetta.Name = "lab_Etichetta";
            this.lab_Etichetta.Size = new System.Drawing.Size(257, 19);
            this.lab_Etichetta.TabIndex = 0;
            this.lab_Etichetta.Text = "Lettura dell\'etichetta presente sul device:";
            // 
            // tbx_ReadLabel_Device
            // 
            this.tbx_ReadLabel_Device.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.layout_Clona.SetColumnSpan(this.tbx_ReadLabel_Device, 2);
            // 
            // 
            // 
            this.tbx_ReadLabel_Device.CustomButton.Image = null;
            this.tbx_ReadLabel_Device.CustomButton.Location = new System.Drawing.Point(516, 1);
            this.tbx_ReadLabel_Device.CustomButton.Name = "";
            this.tbx_ReadLabel_Device.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbx_ReadLabel_Device.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_ReadLabel_Device.CustomButton.TabIndex = 1;
            this.tbx_ReadLabel_Device.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_ReadLabel_Device.CustomButton.UseSelectable = true;
            this.tbx_ReadLabel_Device.CustomButton.Visible = false;
            this.tbx_ReadLabel_Device.Lines = new string[0];
            this.tbx_ReadLabel_Device.Location = new System.Drawing.Point(3, 22);
            this.tbx_ReadLabel_Device.MaxLength = 32767;
            this.tbx_ReadLabel_Device.Multiline = true;
            this.tbx_ReadLabel_Device.Name = "tbx_ReadLabel_Device";
            this.tbx_ReadLabel_Device.PasswordChar = '\0';
            this.tbx_ReadLabel_Device.PromptText = "Lettura del QR-Code";
            this.tbx_ReadLabel_Device.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx_ReadLabel_Device.SelectedText = "";
            this.tbx_ReadLabel_Device.SelectionLength = 0;
            this.tbx_ReadLabel_Device.SelectionStart = 0;
            this.tbx_ReadLabel_Device.ShortcutsEnabled = true;
            this.tbx_ReadLabel_Device.Size = new System.Drawing.Size(538, 23);
            this.tbx_ReadLabel_Device.TabIndex = 0;
            this.tbx_ReadLabel_Device.UseSelectable = true;
            this.tbx_ReadLabel_Device.WaterMark = "Lettura del QR-Code";
            this.tbx_ReadLabel_Device.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_ReadLabel_Device.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbx_ReadLabel_Device.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ReadLabel_Device_KeyPress);
            this.tbx_ReadLabel_Device.Leave += new System.EventHandler(this.tbx_ReadLabel_Device_Leave);
            // 
            // ds_Programmazione
            // 
            this.ds_Programmazione.DataSetName = "ds_Programmazione";
            this.ds_Programmazione.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serialNumbersBindingSource
            // 
            this.serialNumbersBindingSource.DataMember = "SerialNumbers";
            this.serialNumbersBindingSource.DataSource = this.ds_Programmazione;
            // 
            // serialNumbersTableAdapter
            // 
            this.serialNumbersTableAdapter.ClearBeforeFill = true;
            // 
            // sFLastSerialNumberBindingSource
            // 
            this.sFLastSerialNumberBindingSource.DataMember = "SF_LastSerialNumber";
            this.sFLastSerialNumberBindingSource.DataSource = this.ds_Programmazione;
            // 
            // sF_LastSerialNumberTableAdapter
            // 
            this.sF_LastSerialNumberTableAdapter.ClearBeforeFill = true;
            // 
            // firmwareBindingSource
            // 
            this.firmwareBindingSource.DataMember = "Firmware";
            this.firmwareBindingSource.DataSource = this.ds_Programmazione;
            // 
            // firmwareTableAdapter
            // 
            this.firmwareTableAdapter.ClearBeforeFill = true;
            // 
            // serialNumbersObsoleteBindingSource
            // 
            this.serialNumbersObsoleteBindingSource.DataMember = "SerialNumbers_Obsolete";
            this.serialNumbersObsoleteBindingSource.DataSource = this.ds_Programmazione;
            // 
            // serialNumbers_ObsoleteTableAdapter
            // 
            this.serialNumbers_ObsoleteTableAdapter.ClearBeforeFill = true;
            // 
            // layout_Clona
            // 
            this.layout_Clona.ColumnCount = 4;
            this.layout_Clona.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Clona.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Clona.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.layout_Clona.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Clona.Controls.Add(this.lab_Etichetta, 0, 0);
            this.layout_Clona.Controls.Add(this.tbx_ReadLabel_Device, 0, 1);
            this.layout_Clona.Controls.Add(this.but_Programma, 0, 8);
            this.layout_Clona.Controls.Add(this.metroLabel1, 0, 2);
            this.layout_Clona.Controls.Add(this.lab_read_SN, 1, 2);
            this.layout_Clona.Controls.Add(this.metroLabel4, 0, 3);
            this.layout_Clona.Controls.Add(this.lab_read_ID, 1, 3);
            this.layout_Clona.Controls.Add(this.metroLabel2, 0, 4);
            this.layout_Clona.Controls.Add(this.lab_read_Device, 1, 4);
            this.layout_Clona.Controls.Add(this.metroLabel3, 0, 5);
            this.layout_Clona.Controls.Add(this.lab_read_FW, 1, 5);
            this.layout_Clona.Controls.Add(this.metroLabel7, 0, 6);
            this.layout_Clona.Controls.Add(this.lab_read_commessa, 1, 6);
            this.layout_Clona.Controls.Add(this.outputPanel, 3, 0);
            this.layout_Clona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Clona.Location = new System.Drawing.Point(20, 55);
            this.layout_Clona.Name = "layout_Clona";
            this.layout_Clona.RowCount = 11;
            this.layout_Clona.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout_Clona.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout_Clona.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout_Clona.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout_Clona.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout_Clona.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout_Clona.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout_Clona.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout_Clona.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout_Clona.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout_Clona.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.layout_Clona.Size = new System.Drawing.Size(1094, 626);
            this.layout_Clona.TabIndex = 122;
            // 
            // UC_Programmazione_Clona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 701);
            this.ControlBox = false;
            this.Controls.Add(this.layout_Clona);
            this.Controls.Add(this.layout_orizz_menu);
            this.DisplayHeader = false;
            this.Name = "UC_Programmazione_Clona";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UC_Programmazione_Clona_Load);
            this.Shown += new System.EventHandler(this.UC_Programmazione_Clona_Shown);
            this.layout_orizz_menu.ResumeLayout(false);
            this.layout_orizz_menu.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFParcoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).EndInit();
            this.outputPanel.ResumeLayout(false);
            this.outputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Programmazione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumbersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFLastSerialNumberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumbersObsoleteBindingSource)).EndInit();
            this.layout_Clona.ResumeLayout(false);
            this.layout_Clona.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout_orizz_menu;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private ds_SLTableAdapters.SF_ParcoTableAdapter sF_ParcoTableAdapter;
        private System.Windows.Forms.BindingSource sFParcoBindingSource;
        private ds_SL ds_SL;
        private MetroFramework.Controls.MetroButton but_Programma;
        private MetroFramework.Controls.MetroLabel lab_read_ID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lab_read_FW;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lab_read_Device;
        private MetroFramework.Controls.MetroLabel lab_read_SN;
        private MetroFramework.Controls.MetroLabel lab_Etichetta;
        private MetroFramework.Controls.MetroTextBox tbx_ReadLabel_Device;
        private ds_Programmazione ds_Programmazione;
        private System.Windows.Forms.BindingSource serialNumbersBindingSource;
        private ds_ProgrammazioneTableAdapters.SerialNumbersTableAdapter serialNumbersTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel outputPanel;
        private System.Windows.Forms.TextBox dos_box;
        private MetroFramework.Controls.MetroLabel lab_read_commessa;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.BindingSource sFLastSerialNumberBindingSource;
        private ds_ProgrammazioneTableAdapters.SF_LastSerialNumberTableAdapter sF_LastSerialNumberTableAdapter;
        private System.Windows.Forms.BindingSource firmwareBindingSource;
        private ds_ProgrammazioneTableAdapters.FirmwareTableAdapter firmwareTableAdapter;
        private System.Windows.Forms.BindingSource serialNumbersObsoleteBindingSource;
        private ds_ProgrammazioneTableAdapters.SerialNumbers_ObsoleteTableAdapter serialNumbers_ObsoleteTableAdapter;
        private System.Windows.Forms.TableLayoutPanel layout_Clona;
    }
}
