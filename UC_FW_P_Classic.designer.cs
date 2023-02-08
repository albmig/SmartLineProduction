namespace SmartLineProduction
{
    partial class UC_FW_P_Classic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_FW_P_Classic));
            this.layout_dati = new System.Windows.Forms.TableLayoutPanel();
            this.panel_intestazione = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cb_Famiglia = new System.Windows.Forms.ComboBox();
            this.CL_Famiglie_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_CL_Firmware = new SmartLineProduction.ds_CL_Firmware();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tb_gv_Code = new MetroFramework.Controls.MetroTextBox();
            this.panel_freq = new MetroFramework.Controls.MetroPanel();
            this.cb_can = new MetroFramework.Controls.MetroCheckBox();
            this.cb_filo = new MetroFramework.Controls.MetroCheckBox();
            this.cb_433 = new MetroFramework.Controls.MetroCheckBox();
            this.cb_915 = new MetroFramework.Controls.MetroCheckBox();
            this.cb_868 = new MetroFramework.Controls.MetroCheckBox();
            this.tb_gv_Versione = new MetroFramework.Controls.MetroTextBox();
            this.tb_gv_Revisione = new MetroFramework.Controls.MetroTextBox();
            this.panel_dati = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel28 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.tog_CambioPag = new MetroFramework.Controls.MetroToggle();
            this.tog_CambioRic = new MetroFramework.Controls.MetroToggle();
            this.tog_MotRim = new MetroFramework.Controls.MetroToggle();
            this.tB_NRicevCom = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel31 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel30 = new MetroFramework.Controls.MetroLabel();
            this.tog_Retroill = new MetroFramework.Controls.MetroToggle();
            this.tog_SPAttivo = new MetroFramework.Controls.MetroToggle();
            this.tog_SPAssivo = new MetroFramework.Controls.MetroToggle();
            this.tog_Accel = new MetroFramework.Controls.MetroToggle();
            this.tog_Buzzer = new MetroFramework.Controls.MetroToggle();
            this.tog_Vibracall = new MetroFramework.Controls.MetroToggle();
            this.tog_Torcia = new MetroFramework.Controls.MetroToggle();
            this.tog_IVLed = new MetroFramework.Controls.MetroToggle();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tb_fwAbbinato = new MetroFramework.Controls.MetroTextBox();
            this.box_Separatore_01 = new MetroFramework.Controls.MetroPanel();
            this.box_Separatore_02 = new MetroFramework.Controls.MetroPanel();
            this.panel_revisioni = new MetroFramework.Controls.MetroPanel();
            this.rtb_Revisioni = new System.Windows.Forms.RichTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.panel_funzionamento = new MetroFramework.Controls.MetroPanel();
            this.rtb_Funzionamento = new System.Windows.Forms.RichTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.panel_FW_P = new MetroFramework.Controls.MetroPanel();
            this.gv_FW_P = new MetroFramework.Controls.MetroGrid();
            this.CL_Palmari_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_filter_FW = new MetroFramework.Controls.MetroPanel();
            this.radio_FW_active = new MetroFramework.Controls.MetroRadioButton();
            this.radio_FW_obsoleti = new MetroFramework.Controls.MetroRadioButton();
            this.layout_menu = new System.Windows.Forms.TableLayoutPanel();
            this.pan_Menu_comandi = new System.Windows.Forms.MenuStrip();
            this.menu_sw_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_div01 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_clona = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_div02 = new System.Windows.Forms.ToolStripMenuItem();
            this.creaRevisioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_Menu_salva = new System.Windows.Forms.MenuStrip();
            this.menu_sw_salva = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_div12 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sw_annulla = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.CL_Palmari_TableAdapter = new SmartLineProduction.ds_CL_FirmwareTableAdapters.FW_CL_PalmariTableAdapter();
            this.CL_Famiglie_TableAdapter = new SmartLineProduction.ds_CL_FirmwareTableAdapters.FW_CL_FamiglieTableAdapter();
            this.CL_Ricevitori_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CL_Ricevitori_TableAdapter = new SmartLineProduction.ds_CL_FirmwareTableAdapters.FW_CL_RicevitoriTableAdapter();
            this.fWCLPSWCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FW_CL_P_SW_Revisione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_dati.SuspendLayout();
            this.panel_intestazione.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CL_Famiglie_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CL_Firmware)).BeginInit();
            this.panel_freq.SuspendLayout();
            this.panel_dati.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_revisioni.SuspendLayout();
            this.panel_funzionamento.SuspendLayout();
            this.panel_FW_P.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_FW_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CL_Palmari_BindingSource)).BeginInit();
            this.panel_filter_FW.SuspendLayout();
            this.layout_menu.SuspendLayout();
            this.pan_Menu_comandi.SuspendLayout();
            this.pan_Menu_salva.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CL_Ricevitori_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layout_dati
            // 
            this.layout_dati.ColumnCount = 2;
            this.layout_dati.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_dati.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_dati.Controls.Add(this.panel_intestazione, 0, 0);
            this.layout_dati.Controls.Add(this.panel_dati, 0, 1);
            this.layout_dati.Controls.Add(this.panel_revisioni, 0, 2);
            this.layout_dati.Controls.Add(this.panel_funzionamento, 1, 2);
            this.layout_dati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_dati.Location = new System.Drawing.Point(170, 55);
            this.layout_dati.Name = "layout_dati";
            this.layout_dati.RowCount = 3;
            this.layout_dati.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.layout_dati.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_dati.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 308F));
            this.layout_dati.Size = new System.Drawing.Size(1083, 762);
            this.layout_dati.TabIndex = 79;
            // 
            // panel_intestazione
            // 
            this.layout_dati.SetColumnSpan(this.panel_intestazione, 2);
            this.panel_intestazione.Controls.Add(this.tableLayoutPanel2);
            this.panel_intestazione.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_intestazione.HorizontalScrollbarBarColor = false;
            this.panel_intestazione.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_intestazione.HorizontalScrollbarSize = 10;
            this.panel_intestazione.Location = new System.Drawing.Point(3, 3);
            this.panel_intestazione.Name = "panel_intestazione";
            this.panel_intestazione.Size = new System.Drawing.Size(1077, 74);
            this.panel_intestazione.TabIndex = 81;
            this.panel_intestazione.VerticalScrollbarBarColor = true;
            this.panel_intestazione.VerticalScrollbarHighlightOnWheel = false;
            this.panel_intestazione.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cb_Famiglia, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel3, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_gv_Code, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel_freq, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_gv_Versione, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_gv_Revisione, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1077, 74);
            this.tableLayoutPanel2.TabIndex = 134;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 19);
            this.metroLabel1.TabIndex = 73;
            this.metroLabel1.Text = "Codice Firmware";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 46);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 89;
            this.metroLabel2.Text = "Frequenza";
            // 
            // cb_Famiglia
            // 
            this.cb_Famiglia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_Famiglia.DataSource = this.CL_Famiglie_BindingSource;
            this.cb_Famiglia.DisplayMember = "FW_CL_Fam_Des";
            this.cb_Famiglia.FormattingEnabled = true;
            this.cb_Famiglia.Location = new System.Drawing.Point(719, 45);
            this.cb_Famiglia.Name = "cb_Famiglia";
            this.cb_Famiglia.Size = new System.Drawing.Size(263, 25);
            this.cb_Famiglia.TabIndex = 90;
            this.cb_Famiglia.ValueMember = "FW_CL_Fam_ID";
            // 
            // CL_Famiglie_BindingSource
            // 
            this.CL_Famiglie_BindingSource.DataMember = "FW_CL_Famiglie";
            this.CL_Famiglie_BindingSource.DataSource = this.ds_CL_Firmware;
            this.CL_Famiglie_BindingSource.Filter = "FW_CL_Fam_TipoDev = \'P\'";
            this.CL_Famiglie_BindingSource.Sort = "FW_CL_Fam_Des asc";
            // 
            // ds_CL_Firmware
            // 
            this.ds_CL_Firmware.DataSetName = "ds_CL_Firmware";
            this.ds_CL_Firmware.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(655, 46);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 91;
            this.metroLabel3.Text = "Famiglia";
            // 
            // tb_gv_Code
            // 
            this.tb_gv_Code.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.tb_gv_Code.CustomButton.Image = null;
            this.tb_gv_Code.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.tb_gv_Code.CustomButton.Name = "";
            this.tb_gv_Code.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_gv_Code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_gv_Code.CustomButton.TabIndex = 1;
            this.tb_gv_Code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_gv_Code.CustomButton.UseSelectable = true;
            this.tb_gv_Code.CustomButton.Visible = false;
            this.tb_gv_Code.Lines = new string[] {
        " "};
            this.tb_gv_Code.Location = new System.Drawing.Point(118, 7);
            this.tb_gv_Code.MaxLength = 32767;
            this.tb_gv_Code.Name = "tb_gv_Code";
            this.tb_gv_Code.PasswordChar = '\0';
            this.tb_gv_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_gv_Code.SelectedText = "";
            this.tb_gv_Code.SelectionLength = 0;
            this.tb_gv_Code.SelectionStart = 0;
            this.tb_gv_Code.ShortcutsEnabled = true;
            this.tb_gv_Code.Size = new System.Drawing.Size(173, 23);
            this.tb_gv_Code.Style = MetroFramework.MetroColorStyle.Red;
            this.tb_gv_Code.TabIndex = 0;
            this.tb_gv_Code.Text = " ";
            this.tb_gv_Code.UseSelectable = true;
            this.tb_gv_Code.UseStyleColors = true;
            this.tb_gv_Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_gv_Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel_freq
            // 
            this.panel_freq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.SetColumnSpan(this.panel_freq, 3);
            this.panel_freq.Controls.Add(this.cb_can);
            this.panel_freq.Controls.Add(this.cb_filo);
            this.panel_freq.Controls.Add(this.cb_433);
            this.panel_freq.Controls.Add(this.cb_915);
            this.panel_freq.Controls.Add(this.cb_868);
            this.panel_freq.HorizontalScrollbarBarColor = true;
            this.panel_freq.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_freq.HorizontalScrollbarSize = 10;
            this.panel_freq.Location = new System.Drawing.Point(118, 46);
            this.panel_freq.Name = "panel_freq";
            this.panel_freq.Size = new System.Drawing.Size(531, 18);
            this.panel_freq.TabIndex = 7;
            this.panel_freq.VerticalScrollbarBarColor = true;
            this.panel_freq.VerticalScrollbarHighlightOnWheel = false;
            this.panel_freq.VerticalScrollbarSize = 10;
            // 
            // cb_can
            // 
            this.cb_can.AutoSize = true;
            this.cb_can.Location = new System.Drawing.Point(293, 1);
            this.cb_can.Name = "cb_can";
            this.cb_can.Size = new System.Drawing.Size(72, 15);
            this.cb_can.Style = MetroFramework.MetroColorStyle.Red;
            this.cb_can.TabIndex = 5;
            this.cb_can.Text = "CAN-bus";
            this.cb_can.UseSelectable = true;
            this.cb_can.UseStyleColors = true;
            this.cb_can.CheckedChanged += new System.EventHandler(this.cb_can_CheckedChanged);
            // 
            // cb_filo
            // 
            this.cb_filo.AutoSize = true;
            this.cb_filo.Location = new System.Drawing.Point(219, 1);
            this.cb_filo.Name = "cb_filo";
            this.cb_filo.Size = new System.Drawing.Size(42, 15);
            this.cb_filo.Style = MetroFramework.MetroColorStyle.Red;
            this.cb_filo.TabIndex = 3;
            this.cb_filo.Text = "Filo";
            this.cb_filo.UseSelectable = true;
            this.cb_filo.UseStyleColors = true;
            this.cb_filo.CheckedChanged += new System.EventHandler(this.cb_filo_CheckedChanged);
            // 
            // cb_433
            // 
            this.cb_433.AutoSize = true;
            this.cb_433.Location = new System.Drawing.Point(146, 1);
            this.cb_433.Name = "cb_433";
            this.cb_433.Size = new System.Drawing.Size(41, 15);
            this.cb_433.Style = MetroFramework.MetroColorStyle.Red;
            this.cb_433.TabIndex = 2;
            this.cb_433.Text = "433";
            this.cb_433.UseSelectable = true;
            this.cb_433.UseStyleColors = true;
            this.cb_433.CheckedChanged += new System.EventHandler(this.cb_433_CheckedChanged);
            // 
            // cb_915
            // 
            this.cb_915.AutoSize = true;
            this.cb_915.Location = new System.Drawing.Point(73, 1);
            this.cb_915.Name = "cb_915";
            this.cb_915.Size = new System.Drawing.Size(41, 15);
            this.cb_915.Style = MetroFramework.MetroColorStyle.Red;
            this.cb_915.TabIndex = 1;
            this.cb_915.Text = "915";
            this.cb_915.UseSelectable = true;
            this.cb_915.UseStyleColors = true;
            this.cb_915.CheckedChanged += new System.EventHandler(this.cb_915_CheckedChanged);
            // 
            // cb_868
            // 
            this.cb_868.AutoSize = true;
            this.cb_868.Location = new System.Drawing.Point(0, 1);
            this.cb_868.Name = "cb_868";
            this.cb_868.Size = new System.Drawing.Size(41, 15);
            this.cb_868.Style = MetroFramework.MetroColorStyle.Red;
            this.cb_868.TabIndex = 0;
            this.cb_868.Text = "868";
            this.cb_868.UseSelectable = true;
            this.cb_868.UseStyleColors = true;
            this.cb_868.CheckedChanged += new System.EventHandler(this.cb_868_CheckedChanged);
            // 
            // tb_gv_Versione
            // 
            this.tb_gv_Versione.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // 
            // 
            this.tb_gv_Versione.CustomButton.Image = null;
            this.tb_gv_Versione.CustomButton.Location = new System.Drawing.Point(48, 1);
            this.tb_gv_Versione.CustomButton.Name = "";
            this.tb_gv_Versione.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_gv_Versione.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_gv_Versione.CustomButton.TabIndex = 1;
            this.tb_gv_Versione.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_gv_Versione.CustomButton.UseSelectable = true;
            this.tb_gv_Versione.CustomButton.Visible = false;
            this.tb_gv_Versione.Lines = new string[0];
            this.tb_gv_Versione.Location = new System.Drawing.Point(297, 7);
            this.tb_gv_Versione.MaxLength = 32767;
            this.tb_gv_Versione.Name = "tb_gv_Versione";
            this.tb_gv_Versione.PasswordChar = '\0';
            this.tb_gv_Versione.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_gv_Versione.SelectedText = "";
            this.tb_gv_Versione.SelectionLength = 0;
            this.tb_gv_Versione.SelectionStart = 0;
            this.tb_gv_Versione.ShortcutsEnabled = true;
            this.tb_gv_Versione.Size = new System.Drawing.Size(70, 23);
            this.tb_gv_Versione.Style = MetroFramework.MetroColorStyle.Red;
            this.tb_gv_Versione.TabIndex = 1;
            this.tb_gv_Versione.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_gv_Versione.UseSelectable = true;
            this.tb_gv_Versione.UseStyleColors = true;
            this.tb_gv_Versione.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_gv_Versione.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_gv_Versione.Validating += new System.ComponentModel.CancelEventHandler(this.tb_gv_Versione_Validating);
            // 
            // tb_gv_Revisione
            // 
            this.tb_gv_Revisione.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.tb_gv_Revisione.CustomButton.Image = null;
            this.tb_gv_Revisione.CustomButton.Location = new System.Drawing.Point(14, 1);
            this.tb_gv_Revisione.CustomButton.Name = "";
            this.tb_gv_Revisione.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_gv_Revisione.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_gv_Revisione.CustomButton.TabIndex = 1;
            this.tb_gv_Revisione.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_gv_Revisione.CustomButton.UseSelectable = true;
            this.tb_gv_Revisione.CustomButton.Visible = false;
            this.tb_gv_Revisione.Lines = new string[0];
            this.tb_gv_Revisione.Location = new System.Drawing.Point(373, 7);
            this.tb_gv_Revisione.MaxLength = 32767;
            this.tb_gv_Revisione.Name = "tb_gv_Revisione";
            this.tb_gv_Revisione.PasswordChar = '\0';
            this.tb_gv_Revisione.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_gv_Revisione.SelectedText = "";
            this.tb_gv_Revisione.SelectionLength = 0;
            this.tb_gv_Revisione.SelectionStart = 0;
            this.tb_gv_Revisione.ShortcutsEnabled = true;
            this.tb_gv_Revisione.Size = new System.Drawing.Size(36, 23);
            this.tb_gv_Revisione.Style = MetroFramework.MetroColorStyle.Red;
            this.tb_gv_Revisione.TabIndex = 2;
            this.tb_gv_Revisione.UseSelectable = true;
            this.tb_gv_Revisione.UseStyleColors = true;
            this.tb_gv_Revisione.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_gv_Revisione.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_gv_Revisione.Validating += new System.ComponentModel.CancelEventHandler(this.tb_gv_Revisione_Validating);
            // 
            // panel_dati
            // 
            this.layout_dati.SetColumnSpan(this.panel_dati, 2);
            this.panel_dati.Controls.Add(this.tableLayoutPanel1);
            this.panel_dati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dati.HorizontalScrollbarBarColor = true;
            this.panel_dati.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_dati.HorizontalScrollbarSize = 10;
            this.panel_dati.Location = new System.Drawing.Point(3, 86);
            this.panel_dati.Name = "panel_dati";
            this.panel_dati.Size = new System.Drawing.Size(1077, 365);
            this.panel_dati.TabIndex = 77;
            this.panel_dati.VerticalScrollbarBarColor = true;
            this.panel_dati.VerticalScrollbarHighlightOnWheel = false;
            this.panel_dati.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.metroLabel28, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tog_CambioPag, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tog_CambioRic, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tog_MotRim, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tB_NRicevCom, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel6, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel13, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel15, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel11, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel5, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel12, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel31, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel30, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.tog_Retroill, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.tog_SPAttivo, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.tog_SPAssivo, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.tog_Accel, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.tog_Buzzer, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.tog_Vibracall, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.tog_Torcia, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.tog_IVLed, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_fwAbbinato, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.box_Separatore_01, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.box_Separatore_02, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1077, 365);
            this.tableLayoutPanel1.TabIndex = 133;
            // 
            // metroLabel28
            // 
            this.metroLabel28.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel28.AutoSize = true;
            this.metroLabel28.Location = new System.Drawing.Point(764, 257);
            this.metroLabel28.Name = "metroLabel28";
            this.metroLabel28.Size = new System.Drawing.Size(0, 0);
            this.metroLabel28.TabIndex = 124;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 14);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 19);
            this.metroLabel4.TabIndex = 91;
            this.metroLabel4.Text = "Cambio Pagina";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 41);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(117, 19);
            this.metroLabel7.TabIndex = 125;
            this.metroLabel7.Text = "Cambio Ricevitore";
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(3, 68);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(119, 19);
            this.metroLabel8.TabIndex = 126;
            this.metroLabel8.Text = "Motrice/Rimorchio";
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(3, 96);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(125, 19);
            this.metroLabel10.TabIndex = 127;
            this.metroLabel10.Text = "N. Ric. Comandabili";
            // 
            // tog_CambioPag
            // 
            this.tog_CambioPag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tog_CambioPag.AutoSize = true;
            this.tog_CambioPag.Location = new System.Drawing.Point(233, 13);
            this.tog_CambioPag.Name = "tog_CambioPag";
            this.tog_CambioPag.Size = new System.Drawing.Size(80, 21);
            this.tog_CambioPag.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_CambioPag.TabIndex = 6;
            this.tog_CambioPag.Text = "Off";
            this.tog_CambioPag.UseSelectable = true;
            // 
            // tog_CambioRic
            // 
            this.tog_CambioRic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tog_CambioRic.AutoSize = true;
            this.tog_CambioRic.Location = new System.Drawing.Point(233, 40);
            this.tog_CambioRic.Name = "tog_CambioRic";
            this.tog_CambioRic.Size = new System.Drawing.Size(80, 21);
            this.tog_CambioRic.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_CambioRic.TabIndex = 10;
            this.tog_CambioRic.Text = "Off";
            this.tog_CambioRic.UseSelectable = true;
            // 
            // tog_MotRim
            // 
            this.tog_MotRim.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tog_MotRim.AutoSize = true;
            this.tog_MotRim.Location = new System.Drawing.Point(233, 67);
            this.tog_MotRim.Name = "tog_MotRim";
            this.tog_MotRim.Size = new System.Drawing.Size(80, 21);
            this.tog_MotRim.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_MotRim.TabIndex = 11;
            this.tog_MotRim.Text = "Off";
            this.tog_MotRim.UseSelectable = true;
            // 
            // tB_NRicevCom
            // 
            this.tB_NRicevCom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.tB_NRicevCom.CustomButton.Image = null;
            this.tB_NRicevCom.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.tB_NRicevCom.CustomButton.Name = "";
            this.tB_NRicevCom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tB_NRicevCom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tB_NRicevCom.CustomButton.TabIndex = 1;
            this.tB_NRicevCom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tB_NRicevCom.CustomButton.UseSelectable = true;
            this.tB_NRicevCom.CustomButton.Visible = false;
            this.tB_NRicevCom.Lines = new string[0];
            this.tB_NRicevCom.Location = new System.Drawing.Point(233, 94);
            this.tB_NRicevCom.MaxLength = 32767;
            this.tB_NRicevCom.Name = "tB_NRicevCom";
            this.tB_NRicevCom.PasswordChar = '\0';
            this.tB_NRicevCom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tB_NRicevCom.SelectedText = "";
            this.tB_NRicevCom.SelectionLength = 0;
            this.tB_NRicevCom.SelectionStart = 0;
            this.tB_NRicevCom.ShortcutsEnabled = true;
            this.tB_NRicevCom.Size = new System.Drawing.Size(98, 23);
            this.tB_NRicevCom.TabIndex = 138;
            this.tB_NRicevCom.UseSelectable = true;
            this.tB_NRicevCom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tB_NRicevCom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(443, 14);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(117, 19);
            this.metroLabel6.TabIndex = 95;
            this.metroLabel6.Text = "Retroilluminazione";
            // 
            // metroLabel13
            // 
            this.metroLabel13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(443, 41);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(115, 19);
            this.metroLabel13.TabIndex = 130;
            this.metroLabel13.Text = "Safety Point Attivo";
            // 
            // metroLabel15
            // 
            this.metroLabel15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(443, 68);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(122, 19);
            this.metroLabel15.TabIndex = 124;
            this.metroLabel15.Text = "Safety Point Passivo";
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(443, 96);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(96, 19);
            this.metroLabel11.TabIndex = 128;
            this.metroLabel11.Text = "Accelerometro";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(764, 14);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 93;
            this.metroLabel5.Text = "Buzzer";
            // 
            // metroLabel12
            // 
            this.metroLabel12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(764, 41);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(59, 19);
            this.metroLabel12.TabIndex = 129;
            this.metroLabel12.Text = "Vibracall";
            // 
            // metroLabel31
            // 
            this.metroLabel31.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel31.AutoSize = true;
            this.metroLabel31.Location = new System.Drawing.Point(764, 68);
            this.metroLabel31.Name = "metroLabel31";
            this.metroLabel31.Size = new System.Drawing.Size(43, 19);
            this.metroLabel31.TabIndex = 91;
            this.metroLabel31.Text = "Torcia";
            // 
            // metroLabel30
            // 
            this.metroLabel30.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel30.AutoSize = true;
            this.metroLabel30.Location = new System.Drawing.Point(764, 96);
            this.metroLabel30.Name = "metroLabel30";
            this.metroLabel30.Size = new System.Drawing.Size(46, 19);
            this.metroLabel30.TabIndex = 93;
            this.metroLabel30.Text = "4° Led";
            // 
            // tog_Retroill
            // 
            this.tog_Retroill.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tog_Retroill.AutoSize = true;
            this.tog_Retroill.Location = new System.Drawing.Point(673, 13);
            this.tog_Retroill.Name = "tog_Retroill";
            this.tog_Retroill.Size = new System.Drawing.Size(80, 21);
            this.tog_Retroill.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_Retroill.TabIndex = 14;
            this.tog_Retroill.Text = "Off";
            this.tog_Retroill.UseSelectable = true;
            // 
            // tog_SPAttivo
            // 
            this.tog_SPAttivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tog_SPAttivo.AutoSize = true;
            this.tog_SPAttivo.Location = new System.Drawing.Point(673, 40);
            this.tog_SPAttivo.Name = "tog_SPAttivo";
            this.tog_SPAttivo.Size = new System.Drawing.Size(80, 21);
            this.tog_SPAttivo.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_SPAttivo.TabIndex = 15;
            this.tog_SPAttivo.Text = "Off";
            this.tog_SPAttivo.UseSelectable = true;
            // 
            // tog_SPAssivo
            // 
            this.tog_SPAssivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tog_SPAssivo.AutoSize = true;
            this.tog_SPAssivo.Location = new System.Drawing.Point(673, 67);
            this.tog_SPAssivo.Name = "tog_SPAssivo";
            this.tog_SPAssivo.Size = new System.Drawing.Size(80, 21);
            this.tog_SPAssivo.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_SPAssivo.TabIndex = 131;
            this.tog_SPAssivo.Text = "Off";
            this.tog_SPAssivo.UseSelectable = true;
            // 
            // tog_Accel
            // 
            this.tog_Accel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tog_Accel.AutoSize = true;
            this.tog_Accel.Location = new System.Drawing.Point(673, 95);
            this.tog_Accel.Name = "tog_Accel";
            this.tog_Accel.Size = new System.Drawing.Size(80, 21);
            this.tog_Accel.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_Accel.TabIndex = 132;
            this.tog_Accel.Text = "Off";
            this.tog_Accel.UseSelectable = true;
            // 
            // tog_Buzzer
            // 
            this.tog_Buzzer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tog_Buzzer.AutoSize = true;
            this.tog_Buzzer.Location = new System.Drawing.Point(994, 13);
            this.tog_Buzzer.Name = "tog_Buzzer";
            this.tog_Buzzer.Size = new System.Drawing.Size(80, 21);
            this.tog_Buzzer.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_Buzzer.TabIndex = 133;
            this.tog_Buzzer.Text = "Off";
            this.tog_Buzzer.UseSelectable = true;
            // 
            // tog_Vibracall
            // 
            this.tog_Vibracall.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tog_Vibracall.AutoSize = true;
            this.tog_Vibracall.Location = new System.Drawing.Point(994, 40);
            this.tog_Vibracall.Name = "tog_Vibracall";
            this.tog_Vibracall.Size = new System.Drawing.Size(80, 21);
            this.tog_Vibracall.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_Vibracall.TabIndex = 134;
            this.tog_Vibracall.Text = "Off";
            this.tog_Vibracall.UseSelectable = true;
            // 
            // tog_Torcia
            // 
            this.tog_Torcia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tog_Torcia.AutoSize = true;
            this.tog_Torcia.Location = new System.Drawing.Point(994, 67);
            this.tog_Torcia.Name = "tog_Torcia";
            this.tog_Torcia.Size = new System.Drawing.Size(80, 21);
            this.tog_Torcia.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_Torcia.TabIndex = 135;
            this.tog_Torcia.Text = "Off";
            this.tog_Torcia.UseSelectable = true;
            // 
            // tog_IVLed
            // 
            this.tog_IVLed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tog_IVLed.AutoSize = true;
            this.tog_IVLed.Location = new System.Drawing.Point(994, 95);
            this.tog_IVLed.Name = "tog_IVLed";
            this.tog_IVLed.Size = new System.Drawing.Size(80, 21);
            this.tog_IVLed.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_IVLed.TabIndex = 136;
            this.tog_IVLed.Text = "Off";
            this.tog_IVLed.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(3, 125);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(87, 19);
            this.metroLabel9.TabIndex = 139;
            this.metroLabel9.Text = "FW Abbinato";
            // 
            // tb_fwAbbinato
            // 
            this.tb_fwAbbinato.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.tb_fwAbbinato.CustomButton.Image = null;
            this.tb_fwAbbinato.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.tb_fwAbbinato.CustomButton.Name = "";
            this.tb_fwAbbinato.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_fwAbbinato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_fwAbbinato.CustomButton.TabIndex = 1;
            this.tb_fwAbbinato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_fwAbbinato.CustomButton.UseSelectable = true;
            this.tb_fwAbbinato.CustomButton.Visible = false;
            this.tb_fwAbbinato.Lines = new string[0];
            this.tb_fwAbbinato.Location = new System.Drawing.Point(233, 123);
            this.tb_fwAbbinato.MaxLength = 32767;
            this.tb_fwAbbinato.Name = "tb_fwAbbinato";
            this.tb_fwAbbinato.PasswordChar = '\0';
            this.tb_fwAbbinato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_fwAbbinato.SelectedText = "";
            this.tb_fwAbbinato.SelectionLength = 0;
            this.tb_fwAbbinato.SelectionStart = 0;
            this.tb_fwAbbinato.ShortcutsEnabled = true;
            this.tb_fwAbbinato.Size = new System.Drawing.Size(199, 23);
            this.tb_fwAbbinato.TabIndex = 140;
            this.tb_fwAbbinato.UseSelectable = true;
            this.tb_fwAbbinato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_fwAbbinato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // box_Separatore_01
            // 
            this.box_Separatore_01.BackColor = System.Drawing.Color.Red;
            this.box_Separatore_01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_Separatore_01.HorizontalScrollbarBarColor = true;
            this.box_Separatore_01.HorizontalScrollbarHighlightOnWheel = false;
            this.box_Separatore_01.HorizontalScrollbarSize = 10;
            this.box_Separatore_01.Location = new System.Drawing.Point(438, 13);
            this.box_Separatore_01.Name = "box_Separatore_01";
            this.tableLayoutPanel1.SetRowSpan(this.box_Separatore_01, 5);
            this.box_Separatore_01.Size = new System.Drawing.Size(1, 133);
            this.box_Separatore_01.TabIndex = 141;
            this.box_Separatore_01.UseCustomBackColor = true;
            this.box_Separatore_01.VerticalScrollbarBarColor = true;
            this.box_Separatore_01.VerticalScrollbarHighlightOnWheel = false;
            this.box_Separatore_01.VerticalScrollbarSize = 10;
            // 
            // box_Separatore_02
            // 
            this.box_Separatore_02.BackColor = System.Drawing.Color.Red;
            this.box_Separatore_02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_Separatore_02.HorizontalScrollbarBarColor = true;
            this.box_Separatore_02.HorizontalScrollbarHighlightOnWheel = false;
            this.box_Separatore_02.HorizontalScrollbarSize = 10;
            this.box_Separatore_02.Location = new System.Drawing.Point(759, 13);
            this.box_Separatore_02.Name = "box_Separatore_02";
            this.tableLayoutPanel1.SetRowSpan(this.box_Separatore_02, 5);
            this.box_Separatore_02.Size = new System.Drawing.Size(1, 133);
            this.box_Separatore_02.TabIndex = 142;
            this.box_Separatore_02.UseCustomBackColor = true;
            this.box_Separatore_02.VerticalScrollbarBarColor = true;
            this.box_Separatore_02.VerticalScrollbarHighlightOnWheel = false;
            this.box_Separatore_02.VerticalScrollbarSize = 10;
            // 
            // panel_revisioni
            // 
            this.panel_revisioni.Controls.Add(this.rtb_Revisioni);
            this.panel_revisioni.Controls.Add(this.metroLabel19);
            this.panel_revisioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_revisioni.HorizontalScrollbarBarColor = true;
            this.panel_revisioni.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_revisioni.HorizontalScrollbarSize = 10;
            this.panel_revisioni.Location = new System.Drawing.Point(3, 457);
            this.panel_revisioni.Name = "panel_revisioni";
            this.panel_revisioni.Size = new System.Drawing.Size(535, 302);
            this.panel_revisioni.TabIndex = 79;
            this.panel_revisioni.VerticalScrollbarBarColor = true;
            this.panel_revisioni.VerticalScrollbarHighlightOnWheel = false;
            this.panel_revisioni.VerticalScrollbarSize = 10;
            // 
            // rtb_Revisioni
            // 
            this.rtb_Revisioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Revisioni.Location = new System.Drawing.Point(0, 19);
            this.rtb_Revisioni.Name = "rtb_Revisioni";
            this.rtb_Revisioni.Size = new System.Drawing.Size(535, 283);
            this.rtb_Revisioni.TabIndex = 0;
            this.rtb_Revisioni.Text = "";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel19.Location = new System.Drawing.Point(0, 0);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(107, 19);
            this.metroLabel19.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel19.TabIndex = 4;
            this.metroLabel19.Text = "Revision History";
            this.metroLabel19.UseStyleColors = true;
            // 
            // panel_funzionamento
            // 
            this.panel_funzionamento.Controls.Add(this.rtb_Funzionamento);
            this.panel_funzionamento.Controls.Add(this.metroLabel20);
            this.panel_funzionamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_funzionamento.HorizontalScrollbarBarColor = true;
            this.panel_funzionamento.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_funzionamento.HorizontalScrollbarSize = 10;
            this.panel_funzionamento.Location = new System.Drawing.Point(544, 457);
            this.panel_funzionamento.Name = "panel_funzionamento";
            this.panel_funzionamento.Size = new System.Drawing.Size(536, 302);
            this.panel_funzionamento.TabIndex = 80;
            this.panel_funzionamento.VerticalScrollbarBarColor = true;
            this.panel_funzionamento.VerticalScrollbarHighlightOnWheel = false;
            this.panel_funzionamento.VerticalScrollbarSize = 10;
            // 
            // rtb_Funzionamento
            // 
            this.rtb_Funzionamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Funzionamento.Location = new System.Drawing.Point(0, 19);
            this.rtb_Funzionamento.Name = "rtb_Funzionamento";
            this.rtb_Funzionamento.Size = new System.Drawing.Size(536, 283);
            this.rtb_Funzionamento.TabIndex = 0;
            this.rtb_Funzionamento.Text = "";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel20.Location = new System.Drawing.Point(0, 0);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(104, 19);
            this.metroLabel20.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel20.TabIndex = 6;
            this.metroLabel20.Text = "Funzionamento";
            this.metroLabel20.UseStyleColors = true;
            // 
            // panel_FW_P
            // 
            this.panel_FW_P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_FW_P.Controls.Add(this.gv_FW_P);
            this.panel_FW_P.Controls.Add(this.panel_filter_FW);
            this.panel_FW_P.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_FW_P.HorizontalScrollbarBarColor = true;
            this.panel_FW_P.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_FW_P.HorizontalScrollbarSize = 10;
            this.panel_FW_P.Location = new System.Drawing.Point(20, 55);
            this.panel_FW_P.Name = "panel_FW_P";
            this.panel_FW_P.Size = new System.Drawing.Size(150, 762);
            this.panel_FW_P.TabIndex = 80;
            this.panel_FW_P.VerticalScrollbarBarColor = true;
            this.panel_FW_P.VerticalScrollbarHighlightOnWheel = false;
            this.panel_FW_P.VerticalScrollbarSize = 10;
            // 
            // gv_FW_P
            // 
            this.gv_FW_P.AllowUserToAddRows = false;
            this.gv_FW_P.AllowUserToDeleteRows = false;
            this.gv_FW_P.AllowUserToOrderColumns = true;
            this.gv_FW_P.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gv_FW_P.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_FW_P.AutoGenerateColumns = false;
            this.gv_FW_P.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gv_FW_P.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_FW_P.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_FW_P.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_FW_P.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_FW_P.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_FW_P.ColumnHeadersHeight = 40;
            this.gv_FW_P.ColumnHeadersVisible = false;
            this.gv_FW_P.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fWCLPSWCodeDataGridViewTextBoxColumn,
            this.FW_CL_P_SW_Revisione});
            this.gv_FW_P.DataSource = this.CL_Palmari_BindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_FW_P.DefaultCellStyle = dataGridViewCellStyle3;
            this.gv_FW_P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_FW_P.EnableHeadersVisualStyles = false;
            this.gv_FW_P.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_FW_P.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_FW_P.Location = new System.Drawing.Point(0, 49);
            this.gv_FW_P.MultiSelect = false;
            this.gv_FW_P.Name = "gv_FW_P";
            this.gv_FW_P.ReadOnly = true;
            this.gv_FW_P.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_FW_P.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_FW_P.RowHeadersVisible = false;
            this.gv_FW_P.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_FW_P.RowTemplate.DividerHeight = 1;
            this.gv_FW_P.RowTemplate.Height = 30;
            this.gv_FW_P.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_FW_P.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_FW_P.Size = new System.Drawing.Size(148, 711);
            this.gv_FW_P.Style = MetroFramework.MetroColorStyle.Red;
            this.gv_FW_P.TabIndex = 2;
            this.gv_FW_P.UseCustomBackColor = true;
            this.gv_FW_P.UseCustomForeColor = true;
            this.gv_FW_P.UseStyleColors = true;
            // 
            // CL_Palmari_BindingSource
            // 
            this.CL_Palmari_BindingSource.DataMember = "FW_CL_Palmari";
            this.CL_Palmari_BindingSource.DataSource = this.ds_CL_Firmware;
            this.CL_Palmari_BindingSource.Sort = "FW_CL_P_SW_Versione desc";
            this.CL_Palmari_BindingSource.CurrentChanged += new System.EventHandler(this.CL_Palmari_BindingSource_CurrentChanged);
            // 
            // panel_filter_FW
            // 
            this.panel_filter_FW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel_filter_FW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_filter_FW.Controls.Add(this.radio_FW_active);
            this.panel_filter_FW.Controls.Add(this.radio_FW_obsoleti);
            this.panel_filter_FW.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_filter_FW.HorizontalScrollbarBarColor = true;
            this.panel_filter_FW.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_filter_FW.HorizontalScrollbarSize = 10;
            this.panel_filter_FW.Location = new System.Drawing.Point(0, 0);
            this.panel_filter_FW.Name = "panel_filter_FW";
            this.panel_filter_FW.Size = new System.Drawing.Size(148, 49);
            this.panel_filter_FW.TabIndex = 6;
            this.panel_filter_FW.UseCustomBackColor = true;
            this.panel_filter_FW.VerticalScrollbarBarColor = true;
            this.panel_filter_FW.VerticalScrollbarHighlightOnWheel = false;
            this.panel_filter_FW.VerticalScrollbarSize = 10;
            // 
            // radio_FW_active
            // 
            this.radio_FW_active.AutoSize = true;
            this.radio_FW_active.BackColor = System.Drawing.Color.Transparent;
            this.radio_FW_active.Location = new System.Drawing.Point(3, 5);
            this.radio_FW_active.Name = "radio_FW_active";
            this.radio_FW_active.Size = new System.Drawing.Size(71, 15);
            this.radio_FW_active.Style = MetroFramework.MetroColorStyle.Red;
            this.radio_FW_active.TabIndex = 4;
            this.radio_FW_active.Text = "FW Attivi";
            this.radio_FW_active.UseCustomBackColor = true;
            this.radio_FW_active.UseSelectable = true;
            this.radio_FW_active.UseStyleColors = true;
            this.radio_FW_active.Click += new System.EventHandler(this.radio_FW_all_Click);
            // 
            // radio_FW_obsoleti
            // 
            this.radio_FW_obsoleti.AutoSize = true;
            this.radio_FW_obsoleti.BackColor = System.Drawing.Color.Transparent;
            this.radio_FW_obsoleti.Location = new System.Drawing.Point(3, 26);
            this.radio_FW_obsoleti.Name = "radio_FW_obsoleti";
            this.radio_FW_obsoleti.Size = new System.Drawing.Size(107, 15);
            this.radio_FW_obsoleti.Style = MetroFramework.MetroColorStyle.Red;
            this.radio_FW_obsoleti.TabIndex = 2;
            this.radio_FW_obsoleti.Text = "Mostra Obsoleti";
            this.radio_FW_obsoleti.UseCustomBackColor = true;
            this.radio_FW_obsoleti.UseSelectable = true;
            this.radio_FW_obsoleti.UseStyleColors = true;
            this.radio_FW_obsoleti.Click += new System.EventHandler(this.radio_FW_Obsoleti_Click);
            // 
            // layout_menu
            // 
            this.layout_menu.BackColor = System.Drawing.Color.Gainsboro;
            this.layout_menu.ColumnCount = 10;
            this.layout_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout_menu.Controls.Add(this.pan_Menu_comandi, 0, 0);
            this.layout_menu.Controls.Add(this.pan_Menu_salva, 6, 0);
            this.layout_menu.Controls.Add(this.pan_Menu_exit, 10, 0);
            this.layout_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.layout_menu.Location = new System.Drawing.Point(20, 30);
            this.layout_menu.Name = "layout_menu";
            this.layout_menu.RowCount = 1;
            this.layout_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layout_menu.Size = new System.Drawing.Size(1233, 25);
            this.layout_menu.TabIndex = 119;
            // 
            // pan_Menu_comandi
            // 
            this.pan_Menu_comandi.BackColor = System.Drawing.Color.Gainsboro;
            this.layout_menu.SetColumnSpan(this.pan_Menu_comandi, 5);
            this.pan_Menu_comandi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Menu_comandi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sw_new,
            this.menu_sw_div01,
            this.menu_sw_clona,
            this.menu_sw_div02,
            this.creaRevisioneToolStripMenuItem});
            this.pan_Menu_comandi.Location = new System.Drawing.Point(0, 0);
            this.pan_Menu_comandi.Name = "pan_Menu_comandi";
            this.pan_Menu_comandi.Size = new System.Drawing.Size(615, 25);
            this.pan_Menu_comandi.TabIndex = 80;
            this.pan_Menu_comandi.Text = "menuStrip1";
            // 
            // menu_sw_new
            // 
            this.menu_sw_new.Image = ((System.Drawing.Image)(resources.GetObject("menu_sw_new.Image")));
            this.menu_sw_new.Name = "menu_sw_new";
            this.menu_sw_new.Size = new System.Drawing.Size(117, 21);
            this.menu_sw_new.Text = "Nuova Versione";
            this.menu_sw_new.Click += new System.EventHandler(this.menu_sw_new_Click);
            // 
            // menu_sw_div01
            // 
            this.menu_sw_div01.Enabled = false;
            this.menu_sw_div01.Name = "menu_sw_div01";
            this.menu_sw_div01.Size = new System.Drawing.Size(22, 21);
            this.menu_sw_div01.Text = "|";
            // 
            // menu_sw_clona
            // 
            this.menu_sw_clona.Image = ((System.Drawing.Image)(resources.GetObject("menu_sw_clona.Image")));
            this.menu_sw_clona.Name = "menu_sw_clona";
            this.menu_sw_clona.Size = new System.Drawing.Size(290, 21);
            this.menu_sw_clona.Text = "Nuova Versione da elemento selezionato (Clona)";
            this.menu_sw_clona.Click += new System.EventHandler(this.menu_sw_clona_Click);
            // 
            // menu_sw_div02
            // 
            this.menu_sw_div02.Enabled = false;
            this.menu_sw_div02.Name = "menu_sw_div02";
            this.menu_sw_div02.Size = new System.Drawing.Size(22, 21);
            this.menu_sw_div02.Text = "|";
            // 
            // creaRevisioneToolStripMenuItem
            // 
            this.creaRevisioneToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("creaRevisioneToolStripMenuItem.Image")));
            this.creaRevisioneToolStripMenuItem.Name = "creaRevisioneToolStripMenuItem";
            this.creaRevisioneToolStripMenuItem.Size = new System.Drawing.Size(112, 21);
            this.creaRevisioneToolStripMenuItem.Text = "Crea Revisione";
            this.creaRevisioneToolStripMenuItem.Click += new System.EventHandler(this.creaRevisioneToolStripMenuItem_Click);
            // 
            // pan_Menu_salva
            // 
            this.pan_Menu_salva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pan_Menu_salva.BackColor = System.Drawing.Color.Gainsboro;
            this.layout_menu.SetColumnSpan(this.pan_Menu_salva, 2);
            this.pan_Menu_salva.Dock = System.Windows.Forms.DockStyle.None;
            this.pan_Menu_salva.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sw_salva,
            this.menu_sw_div12,
            this.menu_sw_annulla});
            this.pan_Menu_salva.Location = new System.Drawing.Point(777, 0);
            this.pan_Menu_salva.Name = "pan_Menu_salva";
            this.pan_Menu_salva.Size = new System.Drawing.Size(168, 24);
            this.pan_Menu_salva.TabIndex = 81;
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
            // pan_Menu_exit
            // 
            this.pan_Menu_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_Menu_exit.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_Menu_exit.Dock = System.Windows.Forms.DockStyle.None;
            this.pan_Menu_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sw_exit});
            this.pan_Menu_exit.Location = new System.Drawing.Point(1158, 0);
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
            // CL_Palmari_TableAdapter
            // 
            this.CL_Palmari_TableAdapter.ClearBeforeFill = true;
            // 
            // CL_Famiglie_TableAdapter
            // 
            this.CL_Famiglie_TableAdapter.ClearBeforeFill = true;
            // 
            // CL_Ricevitori_BindingSource
            // 
            this.CL_Ricevitori_BindingSource.DataMember = "FW_CL_Ricevitori";
            this.CL_Ricevitori_BindingSource.DataSource = this.ds_CL_Firmware;
            // 
            // CL_Ricevitori_TableAdapter
            // 
            this.CL_Ricevitori_TableAdapter.ClearBeforeFill = true;
            // 
            // fWCLPSWCodeDataGridViewTextBoxColumn
            // 
            this.fWCLPSWCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fWCLPSWCodeDataGridViewTextBoxColumn.DataPropertyName = "FW_CL_P_SW_Code";
            this.fWCLPSWCodeDataGridViewTextBoxColumn.HeaderText = "FW_CL_P_SW_Code";
            this.fWCLPSWCodeDataGridViewTextBoxColumn.Name = "fWCLPSWCodeDataGridViewTextBoxColumn";
            this.fWCLPSWCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FW_CL_P_SW_Revisione
            // 
            this.FW_CL_P_SW_Revisione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FW_CL_P_SW_Revisione.DataPropertyName = "FW_CL_P_SW_Revisione";
            this.FW_CL_P_SW_Revisione.HeaderText = "FW_CL_P_SW_Revisione";
            this.FW_CL_P_SW_Revisione.Name = "FW_CL_P_SW_Revisione";
            this.FW_CL_P_SW_Revisione.ReadOnly = true;
            this.FW_CL_P_SW_Revisione.Width = 5;
            // 
            // UC_FW_P_Classic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 837);
            this.ControlBox = false;
            this.Controls.Add(this.layout_dati);
            this.Controls.Add(this.panel_FW_P);
            this.Controls.Add(this.layout_menu);
            this.DisplayHeader = false;
            this.Name = "UC_FW_P_Classic";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UC_FW_P_Classic_FormClosing);
            this.Load += new System.EventHandler(this.UC_FW_P_Classic_Load);
            this.layout_dati.ResumeLayout(false);
            this.panel_intestazione.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CL_Famiglie_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_CL_Firmware)).EndInit();
            this.panel_freq.ResumeLayout(false);
            this.panel_freq.PerformLayout();
            this.panel_dati.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel_revisioni.ResumeLayout(false);
            this.panel_revisioni.PerformLayout();
            this.panel_funzionamento.ResumeLayout(false);
            this.panel_funzionamento.PerformLayout();
            this.panel_FW_P.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_FW_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CL_Palmari_BindingSource)).EndInit();
            this.panel_filter_FW.ResumeLayout(false);
            this.panel_filter_FW.PerformLayout();
            this.layout_menu.ResumeLayout(false);
            this.layout_menu.PerformLayout();
            this.pan_Menu_comandi.ResumeLayout(false);
            this.pan_Menu_comandi.PerformLayout();
            this.pan_Menu_salva.ResumeLayout(false);
            this.pan_Menu_salva.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CL_Ricevitori_BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel layout_dati;
        private MetroFramework.Controls.MetroPanel panel_funzionamento;
        private System.Windows.Forms.RichTextBox rtb_Funzionamento;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroPanel panel_dati;
        private MetroFramework.Controls.MetroTextBox tb_gv_Code;
        private MetroFramework.Controls.MetroTextBox tb_gv_Versione;
        private MetroFramework.Controls.MetroTextBox tb_gv_Revisione;
        private MetroFramework.Controls.MetroPanel panel_freq;
        private MetroFramework.Controls.MetroCheckBox cb_filo;
        private MetroFramework.Controls.MetroCheckBox cb_433;
        private MetroFramework.Controls.MetroCheckBox cb_915;
        private MetroFramework.Controls.MetroCheckBox cb_868;
        private MetroFramework.Controls.MetroToggle tog_CambioPag;
        private MetroFramework.Controls.MetroToggle tog_CambioRic;
        private MetroFramework.Controls.MetroToggle tog_MotRim;
        private MetroFramework.Controls.MetroToggle tog_Retroill;
        private MetroFramework.Controls.MetroToggle tog_SPAttivo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel panel_revisioni;
        private System.Windows.Forms.RichTextBox rtb_Revisioni;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroPanel panel_FW_P;
        private MetroFramework.Controls.MetroGrid gv_FW_P;
        private System.Windows.Forms.TableLayoutPanel layout_menu;
        private System.Windows.Forms.MenuStrip pan_Menu_comandi;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_new;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_div01;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_clona;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_div02;
        private System.Windows.Forms.ToolStripMenuItem creaRevisioneToolStripMenuItem;
        private System.Windows.Forms.MenuStrip pan_Menu_salva;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_salva;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_div12;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_annulla;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private MetroFramework.Controls.MetroPanel panel_filter_FW;
        private MetroFramework.Controls.MetroRadioButton radio_FW_active;
        private MetroFramework.Controls.MetroRadioButton radio_FW_obsoleti;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel28;
        private MetroFramework.Controls.MetroLabel metroLabel30;
        private MetroFramework.Controls.MetroLabel metroLabel31;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel panel_intestazione;
        private MetroFramework.Controls.MetroToggle tog_IVLed;
        private MetroFramework.Controls.MetroToggle tog_Torcia;
        private MetroFramework.Controls.MetroToggle tog_Vibracall;
        private MetroFramework.Controls.MetroToggle tog_Buzzer;
        private MetroFramework.Controls.MetroToggle tog_SPAssivo;
        private MetroFramework.Controls.MetroToggle tog_Accel;
        private MetroFramework.Controls.MetroTextBox tB_NRicevCom;
        private MetroFramework.Controls.MetroCheckBox cb_can;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox cb_Famiglia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox tb_fwAbbinato;
        private MetroFramework.Controls.MetroPanel box_Separatore_01;
        private MetroFramework.Controls.MetroPanel box_Separatore_02;
        private ds_CL_Firmware ds_CL_Firmware;
        private System.Windows.Forms.BindingSource CL_Palmari_BindingSource;
        private ds_CL_FirmwareTableAdapters.FW_CL_PalmariTableAdapter CL_Palmari_TableAdapter;
        private System.Windows.Forms.BindingSource CL_Famiglie_BindingSource;
        private ds_CL_FirmwareTableAdapters.FW_CL_FamiglieTableAdapter CL_Famiglie_TableAdapter;
        private System.Windows.Forms.BindingSource CL_Ricevitori_BindingSource;
        private ds_CL_FirmwareTableAdapters.FW_CL_RicevitoriTableAdapter CL_Ricevitori_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fWCLPSWCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FW_CL_P_SW_Revisione;
    }
}