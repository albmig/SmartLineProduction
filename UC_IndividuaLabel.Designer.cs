namespace SmartLineProduction
{
    partial class UC_IndividuaLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_IndividuaLabel));
            this.layout_orizz_menu = new System.Windows.Forms.TableLayoutPanel();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_SN = new MetroFramework.Controls.MetroPanel();
            this.but_Print = new MetroFramework.Controls.MetroButton();
            this.but_Reset = new MetroFramework.Controls.MetroButton();
            this.lab_label_SN = new MetroFramework.Controls.MetroLabel();
            this.lab_read_ID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lab_read_FW = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lab_read_Device = new MetroFramework.Controls.MetroLabel();
            this.lab_read_SN = new MetroFramework.Controls.MetroLabel();
            this.lab_Etichetta = new MetroFramework.Controls.MetroLabel();
            this.tbx_ReadLabel_Device = new MetroFramework.Controls.MetroTextBox();
            this.ds_SL = new SmartLineProduction.ds_SL();
            this.ds_Programmazione = new SmartLineProduction.ds_Programmazione();
            this.serialNumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serialNumbersTableAdapter = new SmartLineProduction.ds_ProgrammazioneTableAdapters.SerialNumbersTableAdapter();
            this.layout_orizz_menu.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            this.panel_SN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Programmazione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumbersBindingSource)).BeginInit();
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
            this.panel_SN.Controls.Add(this.but_Print);
            this.panel_SN.Controls.Add(this.but_Reset);
            this.panel_SN.Controls.Add(this.lab_label_SN);
            this.panel_SN.Controls.Add(this.lab_read_ID);
            this.panel_SN.Controls.Add(this.metroLabel7);
            this.panel_SN.Controls.Add(this.metroLabel1);
            this.panel_SN.Controls.Add(this.metroLabel2);
            this.panel_SN.Controls.Add(this.lab_read_FW);
            this.panel_SN.Controls.Add(this.metroLabel3);
            this.panel_SN.Controls.Add(this.lab_read_Device);
            this.panel_SN.Controls.Add(this.lab_read_SN);
            this.panel_SN.Controls.Add(this.lab_Etichetta);
            this.panel_SN.Controls.Add(this.tbx_ReadLabel_Device);
            this.panel_SN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SN.HorizontalScrollbarBarColor = true;
            this.panel_SN.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_SN.HorizontalScrollbarSize = 10;
            this.panel_SN.Location = new System.Drawing.Point(20, 55);
            this.panel_SN.Name = "panel_SN";
            this.panel_SN.Size = new System.Drawing.Size(839, 351);
            this.panel_SN.TabIndex = 0;
            this.panel_SN.VerticalScrollbarBarColor = true;
            this.panel_SN.VerticalScrollbarHighlightOnWheel = false;
            this.panel_SN.VerticalScrollbarSize = 10;
            // 
            // but_Print
            // 
            this.but_Print.BackColor = System.Drawing.Color.White;
            this.but_Print.Location = new System.Drawing.Point(394, 49);
            this.but_Print.Name = "but_Print";
            this.but_Print.Size = new System.Drawing.Size(276, 23);
            this.but_Print.Style = MetroFramework.MetroColorStyle.Red;
            this.but_Print.TabIndex = 12;
            this.but_Print.Text = "Stampa Etichetta";
            this.but_Print.UseSelectable = true;
            this.but_Print.UseStyleColors = true;
            this.but_Print.Click += new System.EventHandler(this.but_Print_Click);
            // 
            // but_Reset
            // 
            this.but_Reset.BackColor = System.Drawing.Color.White;
            this.but_Reset.Location = new System.Drawing.Point(3, 303);
            this.but_Reset.Name = "but_Reset";
            this.but_Reset.Size = new System.Drawing.Size(276, 23);
            this.but_Reset.Style = MetroFramework.MetroColorStyle.Green;
            this.but_Reset.TabIndex = 1;
            this.but_Reset.Text = "Reset";
            this.but_Reset.UseSelectable = true;
            this.but_Reset.UseStyleColors = true;
            this.but_Reset.Click += new System.EventHandler(this.but_AttivaProc_Click);
            // 
            // lab_label_SN
            // 
            this.lab_label_SN.AutoSize = true;
            this.lab_label_SN.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lab_label_SN.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_label_SN.Location = new System.Drawing.Point(180, 244);
            this.lab_label_SN.Name = "lab_label_SN";
            this.lab_label_SN.Size = new System.Drawing.Size(110, 25);
            this.lab_label_SN.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_label_SN.TabIndex = 11;
            this.lab_label_SN.Text = "lab_label_SN";
            this.lab_label_SN.UseStyleColors = true;
            // 
            // lab_read_ID
            // 
            this.lab_read_ID.AutoSize = true;
            this.lab_read_ID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lab_read_ID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_read_ID.Location = new System.Drawing.Point(180, 119);
            this.lab_read_ID.Name = "lab_read_ID";
            this.lab_read_ID.Size = new System.Drawing.Size(103, 25);
            this.lab_read_ID.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_read_ID.TabIndex = 9;
            this.lab_read_ID.Text = "lab_read_ID";
            this.lab_read_ID.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(3, 244);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(80, 25);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Etichetta:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(3, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(138, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Numero di serie:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(3, 162);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Device:";
            // 
            // lab_read_FW
            // 
            this.lab_read_FW.AutoSize = true;
            this.lab_read_FW.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lab_read_FW.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_read_FW.Location = new System.Drawing.Point(180, 187);
            this.lab_read_FW.Name = "lab_read_FW";
            this.lab_read_FW.Size = new System.Drawing.Size(111, 25);
            this.lab_read_FW.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_read_FW.TabIndex = 7;
            this.lab_read_FW.Text = "lab_read_FW";
            this.lab_read_FW.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(3, 187);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(157, 25);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Firmware installato:";
            // 
            // lab_read_Device
            // 
            this.lab_read_Device.AutoSize = true;
            this.lab_read_Device.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lab_read_Device.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_read_Device.Location = new System.Drawing.Point(180, 162);
            this.lab_read_Device.Name = "lab_read_Device";
            this.lab_read_Device.Size = new System.Drawing.Size(137, 25);
            this.lab_read_Device.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_read_Device.TabIndex = 6;
            this.lab_read_Device.Text = "lab_read_Device";
            this.lab_read_Device.UseStyleColors = true;
            // 
            // lab_read_SN
            // 
            this.lab_read_SN.AutoSize = true;
            this.lab_read_SN.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lab_read_SN.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_read_SN.Location = new System.Drawing.Point(180, 94);
            this.lab_read_SN.Name = "lab_read_SN";
            this.lab_read_SN.Size = new System.Drawing.Size(108, 25);
            this.lab_read_SN.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_read_SN.TabIndex = 5;
            this.lab_read_SN.Text = "lab_read_SN";
            this.lab_read_SN.UseStyleColors = true;
            // 
            // lab_Etichetta
            // 
            this.lab_Etichetta.AutoSize = true;
            this.lab_Etichetta.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lab_Etichetta.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_Etichetta.Location = new System.Drawing.Point(3, 3);
            this.lab_Etichetta.Name = "lab_Etichetta";
            this.lab_Etichetta.Size = new System.Drawing.Size(329, 25);
            this.lab_Etichetta.TabIndex = 0;
            this.lab_Etichetta.Text = "Lettura dell\'etichetta presente sul device:";
            // 
            // tbx_ReadLabel_Device
            // 
            // 
            // 
            // 
            this.tbx_ReadLabel_Device.CustomButton.Image = null;
            this.tbx_ReadLabel_Device.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.tbx_ReadLabel_Device.CustomButton.Name = "";
            this.tbx_ReadLabel_Device.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbx_ReadLabel_Device.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_ReadLabel_Device.CustomButton.TabIndex = 1;
            this.tbx_ReadLabel_Device.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_ReadLabel_Device.CustomButton.UseSelectable = true;
            this.tbx_ReadLabel_Device.CustomButton.Visible = false;
            this.tbx_ReadLabel_Device.Lines = new string[0];
            this.tbx_ReadLabel_Device.Location = new System.Drawing.Point(3, 49);
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
            this.tbx_ReadLabel_Device.Size = new System.Drawing.Size(314, 23);
            this.tbx_ReadLabel_Device.TabIndex = 0;
            this.tbx_ReadLabel_Device.UseSelectable = true;
            this.tbx_ReadLabel_Device.WaterMark = "Lettura del QR-Code";
            this.tbx_ReadLabel_Device.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_ReadLabel_Device.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbx_ReadLabel_Device.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ReadLabel_Device_KeyPress);
            this.tbx_ReadLabel_Device.Leave += new System.EventHandler(this.tbx_ReadLabel_Device_Leave);
            // 
            // ds_SL
            // 
            this.ds_SL.DataSetName = "ds_SL";
            this.ds_SL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // UC_IndividuaLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 426);
            this.ControlBox = false;
            this.Controls.Add(this.panel_SN);
            this.Controls.Add(this.layout_orizz_menu);
            this.DisplayHeader = false;
            this.Name = "UC_IndividuaLabel";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UC_IndividuaLabel_Load);
            this.Shown += new System.EventHandler(this.UC_IndividuaLabel_Shown);
            this.layout_orizz_menu.ResumeLayout(false);
            this.layout_orizz_menu.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            this.panel_SN.ResumeLayout(false);
            this.panel_SN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Programmazione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumbersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout_orizz_menu;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private MetroFramework.Controls.MetroPanel panel_SN;
        private MetroFramework.Controls.MetroLabel lab_read_ID;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lab_read_FW;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lab_read_Device;
        private MetroFramework.Controls.MetroLabel lab_read_SN;
        private MetroFramework.Controls.MetroLabel lab_Etichetta;
        private MetroFramework.Controls.MetroTextBox tbx_ReadLabel_Device;
        private ds_SL ds_SL;
        private ds_Programmazione ds_Programmazione;
        private System.Windows.Forms.BindingSource serialNumbersBindingSource;
        private ds_ProgrammazioneTableAdapters.SerialNumbersTableAdapter serialNumbersTableAdapter;
        private MetroFramework.Controls.MetroLabel lab_label_SN;
        private MetroFramework.Controls.MetroButton but_Reset;
        private MetroFramework.Controls.MetroButton but_Print;
    }
}
