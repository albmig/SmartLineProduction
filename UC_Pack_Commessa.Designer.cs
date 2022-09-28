namespace SmartLineProduction
{
    partial class UC_Pack_Commessa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Pack_Commessa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Schede = new MetroFramework.Controls.MetroPanel();
            this.layout_Pack = new System.Windows.Forms.TableLayoutPanel();
            this.panel_grid_pack = new MetroFramework.Controls.MetroPanel();
            this.gv_commessa = new MetroFramework.Controls.MetroGrid();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.tb_grid_commessa_pack = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_do_pack_kit = new MetroFramework.Controls.MetroButton();
            this.gv_pack_explo = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_Doc_EN = new MetroFramework.Controls.MetroCheckBox();
            this.cb_Doc_IT = new MetroFramework.Controls.MetroCheckBox();
            this.panel_pack_kit = new MetroFramework.Controls.MetroPanel();
            this.panel_des_art_Kit_pack = new MetroFramework.Controls.MetroPanel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.layout_orizz_menu = new System.Windows.Forms.TableLayoutPanel();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pack_Kit_pdf = new AxAcroPDFLib.AxAcroPDF();
            this.gv_commessa_commessa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_commessa_data_ordine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_commessa_dataconfcons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_commessa_numord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_commessa_codanag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_commessa_ragsoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFCommesseSLPackCommesseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_SL = new SmartLineProduction.ds_SL();
            this.ds_Programmazione = new SmartLineProduction.ds_Programmazione();
            this.sFCommesseSLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sF_Commesse_SL_Pack_CommesseTableAdapter = new SmartLineProduction.ds_SLTableAdapters.SF_Commesse_SL_Pack_CommesseTableAdapter();
            this.sF_Commesse_SLTableAdapter = new SmartLineProduction.ds_ProgrammazioneTableAdapters.SF_Commesse_SLTableAdapter();
            this.gv_pack_explo_tipoordine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_commessalong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_commessashort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_dataord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_dataconfcons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_numord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_numriga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_codanag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_ragsoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_artcommessa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_um = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_qtaord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_qta_evadere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_statocommessa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_tiporiga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_isKit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_isSWRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_isSWRR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_datafinevalid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_swdevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_qtaevasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_sercommessa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_serkit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_serDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_pack_explo_daincludere = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gv_pack_explo_Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Schede.SuspendLayout();
            this.layout_Pack.SuspendLayout();
            this.panel_grid_pack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_commessa)).BeginInit();
            this.metroPanel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_pack_explo)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_pack_kit.SuspendLayout();
            this.panel_des_art_Kit_pack.SuspendLayout();
            this.layout_orizz_menu.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pack_Kit_pdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFCommesseSLPackCommesseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFCommesseSLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Schede
            // 
            this.panel_Schede.Controls.Add(this.layout_Pack);
            this.panel_Schede.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Schede.HorizontalScrollbarBarColor = true;
            this.panel_Schede.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_Schede.HorizontalScrollbarSize = 10;
            this.panel_Schede.Location = new System.Drawing.Point(20, 55);
            this.panel_Schede.Name = "panel_Schede";
            this.panel_Schede.Size = new System.Drawing.Size(1560, 425);
            this.panel_Schede.TabIndex = 122;
            this.panel_Schede.VerticalScrollbarBarColor = true;
            this.panel_Schede.VerticalScrollbarHighlightOnWheel = false;
            this.panel_Schede.VerticalScrollbarSize = 10;
            // 
            // layout_Pack
            // 
            this.layout_Pack.ColumnCount = 2;
            this.layout_Pack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.layout_Pack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_Pack.Controls.Add(this.panel_grid_pack, 0, 0);
            this.layout_Pack.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.layout_Pack.Controls.Add(this.panel_des_art_Kit_pack, 1, 0);
            this.layout_Pack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Pack.Location = new System.Drawing.Point(0, 0);
            this.layout_Pack.Name = "layout_Pack";
            this.layout_Pack.RowCount = 2;
            this.layout_Pack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layout_Pack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pack.Size = new System.Drawing.Size(1560, 425);
            this.layout_Pack.TabIndex = 124;
            // 
            // panel_grid_pack
            // 
            this.panel_grid_pack.Controls.Add(this.gv_commessa);
            this.panel_grid_pack.Controls.Add(this.metroPanel7);
            this.panel_grid_pack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_grid_pack.HorizontalScrollbarBarColor = true;
            this.panel_grid_pack.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_grid_pack.HorizontalScrollbarSize = 10;
            this.panel_grid_pack.Location = new System.Drawing.Point(3, 3);
            this.panel_grid_pack.Name = "panel_grid_pack";
            this.layout_Pack.SetRowSpan(this.panel_grid_pack, 2);
            this.panel_grid_pack.Size = new System.Drawing.Size(144, 419);
            this.panel_grid_pack.TabIndex = 123;
            this.panel_grid_pack.VerticalScrollbarBarColor = true;
            this.panel_grid_pack.VerticalScrollbarHighlightOnWheel = false;
            this.panel_grid_pack.VerticalScrollbarSize = 10;
            // 
            // gv_commessa
            // 
            this.gv_commessa.AllowUserToAddRows = false;
            this.gv_commessa.AllowUserToDeleteRows = false;
            this.gv_commessa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.gv_commessa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_commessa.AutoGenerateColumns = false;
            this.gv_commessa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_commessa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_commessa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_commessa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_commessa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_commessa.ColumnHeadersHeight = 40;
            this.gv_commessa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gv_commessa_commessa,
            this.gv_commessa_data_ordine,
            this.gv_commessa_dataconfcons,
            this.gv_commessa_numord,
            this.gv_commessa_codanag,
            this.gv_commessa_ragsoc});
            this.gv_commessa.DataSource = this.sFCommesseSLPackCommesseBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_commessa.DefaultCellStyle = dataGridViewCellStyle3;
            this.gv_commessa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_commessa.EnableHeadersVisualStyles = false;
            this.gv_commessa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_commessa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_commessa.Location = new System.Drawing.Point(0, 30);
            this.gv_commessa.MultiSelect = false;
            this.gv_commessa.Name = "gv_commessa";
            this.gv_commessa.ReadOnly = true;
            this.gv_commessa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_commessa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_commessa.RowHeadersVisible = false;
            this.gv_commessa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_commessa.RowTemplate.Height = 30;
            this.gv_commessa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_commessa.Size = new System.Drawing.Size(144, 389);
            this.gv_commessa.Style = MetroFramework.MetroColorStyle.Red;
            this.gv_commessa.TabIndex = 0;
            this.gv_commessa.UseStyleColors = true;
            // 
            // metroPanel7
            // 
            this.metroPanel7.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel7.Controls.Add(this.tb_grid_commessa_pack);
            this.metroPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(0, 0);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(144, 30);
            this.metroPanel7.TabIndex = 3;
            this.metroPanel7.UseCustomBackColor = true;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // tb_grid_commessa_pack
            // 
            // 
            // 
            // 
            this.tb_grid_commessa_pack.CustomButton.Image = null;
            this.tb_grid_commessa_pack.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.tb_grid_commessa_pack.CustomButton.Name = "";
            this.tb_grid_commessa_pack.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_grid_commessa_pack.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_grid_commessa_pack.CustomButton.TabIndex = 1;
            this.tb_grid_commessa_pack.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_grid_commessa_pack.CustomButton.UseSelectable = true;
            this.tb_grid_commessa_pack.CustomButton.Visible = false;
            this.tb_grid_commessa_pack.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_grid_commessa_pack.Icon = global::SmartLineProduction.Properties.Resources.Lente;
            this.tb_grid_commessa_pack.IconRight = true;
            this.tb_grid_commessa_pack.Lines = new string[] {
        "metroTextBox1"};
            this.tb_grid_commessa_pack.Location = new System.Drawing.Point(0, 0);
            this.tb_grid_commessa_pack.MaxLength = 32767;
            this.tb_grid_commessa_pack.Name = "tb_grid_commessa_pack";
            this.tb_grid_commessa_pack.PasswordChar = '\0';
            this.tb_grid_commessa_pack.PromptText = "ricerca";
            this.tb_grid_commessa_pack.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_grid_commessa_pack.SelectedText = "";
            this.tb_grid_commessa_pack.SelectionLength = 0;
            this.tb_grid_commessa_pack.SelectionStart = 0;
            this.tb_grid_commessa_pack.ShortcutsEnabled = true;
            this.tb_grid_commessa_pack.Size = new System.Drawing.Size(144, 23);
            this.tb_grid_commessa_pack.TabIndex = 2;
            this.tb_grid_commessa_pack.Text = "metroTextBox1";
            this.tb_grid_commessa_pack.UseSelectable = true;
            this.tb_grid_commessa_pack.WaterMark = "ricerca";
            this.tb_grid_commessa_pack.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_grid_commessa_pack.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_grid_commessa_pack.TextChanged += new System.EventHandler(this.tb_grid_commessa_pack_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_do_pack_kit, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.gv_pack_explo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel_pack_kit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(153, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1404, 369);
            this.tableLayoutPanel2.TabIndex = 122;
            // 
            // btn_do_pack_kit
            // 
            this.btn_do_pack_kit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_do_pack_kit.BackColor = System.Drawing.Color.Moccasin;
            this.btn_do_pack_kit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_do_pack_kit.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_do_pack_kit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_do_pack_kit.Location = new System.Drawing.Point(201, 341);
            this.btn_do_pack_kit.Name = "btn_do_pack_kit";
            this.btn_do_pack_kit.Size = new System.Drawing.Size(300, 25);
            this.btn_do_pack_kit.TabIndex = 3;
            this.btn_do_pack_kit.Text = "Procedi alla raccolta dei documenti";
            this.btn_do_pack_kit.UseCustomBackColor = true;
            this.btn_do_pack_kit.UseSelectable = true;
            this.btn_do_pack_kit.Click += new System.EventHandler(this.btn_do_pack_kit_Click);
            // 
            // gv_pack_explo
            // 
            this.gv_pack_explo.AllowUserToAddRows = false;
            this.gv_pack_explo.AllowUserToDeleteRows = false;
            this.gv_pack_explo.AllowUserToResizeRows = false;
            this.gv_pack_explo.AutoGenerateColumns = false;
            this.gv_pack_explo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_pack_explo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_pack_explo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_pack_explo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_pack_explo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gv_pack_explo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_pack_explo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gv_pack_explo_tipoordine,
            this.gv_pack_explo_commessalong,
            this.gv_pack_explo_commessashort,
            this.gv_pack_explo_dataord,
            this.gv_pack_explo_dataconfcons,
            this.gv_pack_explo_numord,
            this.gv_pack_explo_numriga,
            this.gv_pack_explo_codanag,
            this.gv_pack_explo_ragsoc,
            this.gv_pack_explo_artcommessa,
            this.gv_pack_explo_um,
            this.gv_pack_explo_qtaord,
            this.gv_pack_explo_qta_evadere,
            this.gv_pack_explo_statocommessa,
            this.gv_pack_explo_tiporiga,
            this.gv_pack_explo_isKit,
            this.gv_pack_explo_isSWRP,
            this.gv_pack_explo_isSWRR,
            this.gv_pack_explo_datafinevalid,
            this.gv_pack_explo_device,
            this.gv_pack_explo_swdevice,
            this.gv_pack_explo_qtaevasa,
            this.gv_pack_explo_sercommessa,
            this.gv_pack_explo_serkit,
            this.gv_pack_explo_serDevice,
            this.gv_pack_explo_daincludere,
            this.gv_pack_explo_Path});
            this.gv_pack_explo.DataSource = this.sFCommesseSLBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_pack_explo.DefaultCellStyle = dataGridViewCellStyle8;
            this.gv_pack_explo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_pack_explo.EnableHeadersVisualStyles = false;
            this.gv_pack_explo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_pack_explo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_pack_explo.Location = new System.Drawing.Point(3, 73);
            this.gv_pack_explo.Name = "gv_pack_explo";
            this.gv_pack_explo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_pack_explo.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gv_pack_explo.RowHeadersVisible = false;
            this.gv_pack_explo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_pack_explo.RowTemplate.Height = 40;
            this.gv_pack_explo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_pack_explo.Size = new System.Drawing.Size(696, 262);
            this.gv_pack_explo.Style = MetroFramework.MetroColorStyle.Red;
            this.gv_pack_explo.TabIndex = 2;
            this.gv_pack_explo.UseStyleColors = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(696, 64);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cb_Doc_EN);
            this.groupBox1.Controls.Add(this.cb_Doc_IT);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 64);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lingua della documentazione";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SmartLineProduction.Properties.Resources.gb;
            this.pictureBox2.Location = new System.Drawing.Point(196, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartLineProduction.Properties.Resources.it;
            this.pictureBox1.Location = new System.Drawing.Point(196, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cb_Doc_EN
            // 
            this.cb_Doc_EN.AutoSize = true;
            this.cb_Doc_EN.Location = new System.Drawing.Point(6, 40);
            this.cb_Doc_EN.Name = "cb_Doc_EN";
            this.cb_Doc_EN.Size = new System.Drawing.Size(173, 15);
            this.cb_Doc_EN.Style = MetroFramework.MetroColorStyle.Red;
            this.cb_Doc_EN.TabIndex = 4;
            this.cb_Doc_EN.Text = "Documentazione in INGLESE";
            this.cb_Doc_EN.UseSelectable = true;
            this.cb_Doc_EN.UseStyleColors = true;
            this.cb_Doc_EN.Click += new System.EventHandler(this.cb_Doc_EN_Click);
            // 
            // cb_Doc_IT
            // 
            this.cb_Doc_IT.AutoSize = true;
            this.cb_Doc_IT.Location = new System.Drawing.Point(6, 19);
            this.cb_Doc_IT.Name = "cb_Doc_IT";
            this.cb_Doc_IT.Size = new System.Drawing.Size(180, 15);
            this.cb_Doc_IT.Style = MetroFramework.MetroColorStyle.Red;
            this.cb_Doc_IT.TabIndex = 3;
            this.cb_Doc_IT.Text = "Documentazione in ITALIANO";
            this.cb_Doc_IT.UseSelectable = true;
            this.cb_Doc_IT.UseStyleColors = true;
            this.cb_Doc_IT.Click += new System.EventHandler(this.cb_Doc_IT_Click);
            // 
            // panel_pack_kit
            // 
            this.panel_pack_kit.Controls.Add(this.pack_Kit_pdf);
            this.panel_pack_kit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_pack_kit.HorizontalScrollbarBarColor = true;
            this.panel_pack_kit.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_pack_kit.HorizontalScrollbarSize = 10;
            this.panel_pack_kit.Location = new System.Drawing.Point(705, 3);
            this.panel_pack_kit.Name = "panel_pack_kit";
            this.tableLayoutPanel2.SetRowSpan(this.panel_pack_kit, 2);
            this.panel_pack_kit.Size = new System.Drawing.Size(696, 332);
            this.panel_pack_kit.TabIndex = 6;
            this.panel_pack_kit.VerticalScrollbarBarColor = true;
            this.panel_pack_kit.VerticalScrollbarHighlightOnWheel = false;
            this.panel_pack_kit.VerticalScrollbarSize = 10;
            // 
            // panel_des_art_Kit_pack
            // 
            this.panel_des_art_Kit_pack.Controls.Add(this.metroLabel17);
            this.panel_des_art_Kit_pack.Controls.Add(this.metroLabel19);
            this.panel_des_art_Kit_pack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_des_art_Kit_pack.HorizontalScrollbarBarColor = true;
            this.panel_des_art_Kit_pack.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_des_art_Kit_pack.HorizontalScrollbarSize = 10;
            this.panel_des_art_Kit_pack.Location = new System.Drawing.Point(153, 3);
            this.panel_des_art_Kit_pack.Name = "panel_des_art_Kit_pack";
            this.panel_des_art_Kit_pack.Size = new System.Drawing.Size(1404, 44);
            this.panel_des_art_Kit_pack.TabIndex = 124;
            this.panel_des_art_Kit_pack.VerticalScrollbarBarColor = true;
            this.panel_des_art_Kit_pack.VerticalScrollbarHighlightOnWheel = false;
            this.panel_des_art_Kit_pack.VerticalScrollbarSize = 10;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sFCommesseSLPackCommesseBindingSource, "Ragione_Sociale", true));
            this.metroLabel17.Location = new System.Drawing.Point(3, 19);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(98, 19);
            this.metroLabel17.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel17.TabIndex = 3;
            this.metroLabel17.Text = "RagioneSociale";
            this.metroLabel17.UseStyleColors = true;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(3, 0);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(102, 19);
            this.metroLabel19.TabIndex = 2;
            this.metroLabel19.Text = "Ragione Sociale";
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
            this.layout_orizz_menu.Size = new System.Drawing.Size(1560, 25);
            this.layout_orizz_menu.TabIndex = 123;
            // 
            // pan_Menu_exit
            // 
            this.pan_Menu_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_Menu_exit.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_Menu_exit.Dock = System.Windows.Forms.DockStyle.None;
            this.pan_Menu_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sw_exit});
            this.pan_Menu_exit.Location = new System.Drawing.Point(1485, 0);
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
            // pack_Kit_pdf
            // 
            this.pack_Kit_pdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pack_Kit_pdf.Enabled = true;
            this.pack_Kit_pdf.Location = new System.Drawing.Point(0, 0);
            this.pack_Kit_pdf.Name = "pack_Kit_pdf";
            this.pack_Kit_pdf.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pack_Kit_pdf.OcxState")));
            this.pack_Kit_pdf.Size = new System.Drawing.Size(696, 332);
            this.pack_Kit_pdf.TabIndex = 2;
            // 
            // gv_commessa_commessa
            // 
            this.gv_commessa_commessa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gv_commessa_commessa.DataPropertyName = "CommessaShort";
            this.gv_commessa_commessa.HeaderText = "Commessa";
            this.gv_commessa_commessa.Name = "gv_commessa_commessa";
            this.gv_commessa_commessa.ReadOnly = true;
            // 
            // gv_commessa_data_ordine
            // 
            this.gv_commessa_data_ordine.DataPropertyName = "Data_Ordine";
            this.gv_commessa_data_ordine.HeaderText = "Data_Ordine";
            this.gv_commessa_data_ordine.Name = "gv_commessa_data_ordine";
            this.gv_commessa_data_ordine.ReadOnly = true;
            this.gv_commessa_data_ordine.Visible = false;
            // 
            // gv_commessa_dataconfcons
            // 
            this.gv_commessa_dataconfcons.DataPropertyName = "Data_Conferma_Consegna";
            this.gv_commessa_dataconfcons.HeaderText = "Data_Conferma_Consegna";
            this.gv_commessa_dataconfcons.Name = "gv_commessa_dataconfcons";
            this.gv_commessa_dataconfcons.ReadOnly = true;
            this.gv_commessa_dataconfcons.Visible = false;
            // 
            // gv_commessa_numord
            // 
            this.gv_commessa_numord.DataPropertyName = "Numero_Ordine";
            this.gv_commessa_numord.HeaderText = "Numero_Ordine";
            this.gv_commessa_numord.Name = "gv_commessa_numord";
            this.gv_commessa_numord.ReadOnly = true;
            this.gv_commessa_numord.Visible = false;
            // 
            // gv_commessa_codanag
            // 
            this.gv_commessa_codanag.DataPropertyName = "CodAnagrafico";
            this.gv_commessa_codanag.HeaderText = "CodAnagrafico";
            this.gv_commessa_codanag.Name = "gv_commessa_codanag";
            this.gv_commessa_codanag.ReadOnly = true;
            this.gv_commessa_codanag.Visible = false;
            // 
            // gv_commessa_ragsoc
            // 
            this.gv_commessa_ragsoc.DataPropertyName = "Ragione_Sociale";
            this.gv_commessa_ragsoc.HeaderText = "Ragione_Sociale";
            this.gv_commessa_ragsoc.Name = "gv_commessa_ragsoc";
            this.gv_commessa_ragsoc.ReadOnly = true;
            this.gv_commessa_ragsoc.Visible = false;
            // 
            // sFCommesseSLPackCommesseBindingSource
            // 
            this.sFCommesseSLPackCommesseBindingSource.DataMember = "SF_Commesse_SL_Pack_Commesse";
            this.sFCommesseSLPackCommesseBindingSource.DataSource = this.ds_SL;
            this.sFCommesseSLPackCommesseBindingSource.CurrentChanged += new System.EventHandler(this.sFCommesseSLPackCommesseBindingSource_CurrentChanged);
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
            // sFCommesseSLBindingSource
            // 
            this.sFCommesseSLBindingSource.DataMember = "SF_Commesse_SL";
            this.sFCommesseSLBindingSource.DataSource = this.ds_Programmazione;
            // 
            // sF_Commesse_SL_Pack_CommesseTableAdapter
            // 
            this.sF_Commesse_SL_Pack_CommesseTableAdapter.ClearBeforeFill = true;
            // 
            // sF_Commesse_SLTableAdapter
            // 
            this.sF_Commesse_SLTableAdapter.ClearBeforeFill = true;
            // 
            // gv_pack_explo_tipoordine
            // 
            this.gv_pack_explo_tipoordine.DataPropertyName = "TipoOrdine";
            this.gv_pack_explo_tipoordine.HeaderText = "TipoOrdine";
            this.gv_pack_explo_tipoordine.Name = "gv_pack_explo_tipoordine";
            this.gv_pack_explo_tipoordine.Visible = false;
            // 
            // gv_pack_explo_commessalong
            // 
            this.gv_pack_explo_commessalong.DataPropertyName = "CommessaLong";
            this.gv_pack_explo_commessalong.HeaderText = "CommessaLong";
            this.gv_pack_explo_commessalong.Name = "gv_pack_explo_commessalong";
            this.gv_pack_explo_commessalong.Visible = false;
            // 
            // gv_pack_explo_commessashort
            // 
            this.gv_pack_explo_commessashort.DataPropertyName = "CommessaShort";
            this.gv_pack_explo_commessashort.HeaderText = "CommessaShort";
            this.gv_pack_explo_commessashort.Name = "gv_pack_explo_commessashort";
            this.gv_pack_explo_commessashort.Visible = false;
            // 
            // gv_pack_explo_dataord
            // 
            this.gv_pack_explo_dataord.DataPropertyName = "Data_Ordine";
            this.gv_pack_explo_dataord.HeaderText = "Data_Ordine";
            this.gv_pack_explo_dataord.Name = "gv_pack_explo_dataord";
            this.gv_pack_explo_dataord.Visible = false;
            // 
            // gv_pack_explo_dataconfcons
            // 
            this.gv_pack_explo_dataconfcons.DataPropertyName = "Data_Conferma_Consegna";
            this.gv_pack_explo_dataconfcons.HeaderText = "Data_Conferma_Consegna";
            this.gv_pack_explo_dataconfcons.Name = "gv_pack_explo_dataconfcons";
            this.gv_pack_explo_dataconfcons.Visible = false;
            // 
            // gv_pack_explo_numord
            // 
            this.gv_pack_explo_numord.DataPropertyName = "Numero_Ordine";
            this.gv_pack_explo_numord.HeaderText = "Numero_Ordine";
            this.gv_pack_explo_numord.Name = "gv_pack_explo_numord";
            this.gv_pack_explo_numord.Visible = false;
            // 
            // gv_pack_explo_numriga
            // 
            this.gv_pack_explo_numriga.DataPropertyName = "Numero_Riga";
            this.gv_pack_explo_numriga.HeaderText = "Numero_Riga";
            this.gv_pack_explo_numriga.Name = "gv_pack_explo_numriga";
            this.gv_pack_explo_numriga.Visible = false;
            // 
            // gv_pack_explo_codanag
            // 
            this.gv_pack_explo_codanag.DataPropertyName = "CodAnagrafico";
            this.gv_pack_explo_codanag.HeaderText = "CodAnagrafico";
            this.gv_pack_explo_codanag.Name = "gv_pack_explo_codanag";
            this.gv_pack_explo_codanag.Visible = false;
            // 
            // gv_pack_explo_ragsoc
            // 
            this.gv_pack_explo_ragsoc.DataPropertyName = "Ragione_Sociale";
            this.gv_pack_explo_ragsoc.HeaderText = "Ragione_Sociale";
            this.gv_pack_explo_ragsoc.Name = "gv_pack_explo_ragsoc";
            this.gv_pack_explo_ragsoc.Visible = false;
            // 
            // gv_pack_explo_artcommessa
            // 
            this.gv_pack_explo_artcommessa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gv_pack_explo_artcommessa.DataPropertyName = "Art_Commessa";
            this.gv_pack_explo_artcommessa.HeaderText = "Articolo Commessa";
            this.gv_pack_explo_artcommessa.Name = "gv_pack_explo_artcommessa";
            this.gv_pack_explo_artcommessa.Width = 116;
            // 
            // gv_pack_explo_um
            // 
            this.gv_pack_explo_um.DataPropertyName = "UM";
            this.gv_pack_explo_um.HeaderText = "UM";
            this.gv_pack_explo_um.Name = "gv_pack_explo_um";
            this.gv_pack_explo_um.Visible = false;
            // 
            // gv_pack_explo_qtaord
            // 
            this.gv_pack_explo_qtaord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gv_pack_explo_qtaord.DataPropertyName = "Qta_Ordinata";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N0";
            this.gv_pack_explo_qtaord.DefaultCellStyle = dataGridViewCellStyle6;
            this.gv_pack_explo_qtaord.HeaderText = "Qta Ordinata";
            this.gv_pack_explo_qtaord.Name = "gv_pack_explo_qtaord";
            this.gv_pack_explo_qtaord.Width = 89;
            // 
            // gv_pack_explo_qta_evadere
            // 
            this.gv_pack_explo_qta_evadere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gv_pack_explo_qta_evadere.DataPropertyName = "Qta_da_Evadere";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "N0";
            this.gv_pack_explo_qta_evadere.DefaultCellStyle = dataGridViewCellStyle7;
            this.gv_pack_explo_qta_evadere.HeaderText = "Q.tà da evadere";
            this.gv_pack_explo_qta_evadere.Name = "gv_pack_explo_qta_evadere";
            this.gv_pack_explo_qta_evadere.Width = 101;
            // 
            // gv_pack_explo_statocommessa
            // 
            this.gv_pack_explo_statocommessa.DataPropertyName = "StatoCommessa";
            this.gv_pack_explo_statocommessa.HeaderText = "StatoCommessa";
            this.gv_pack_explo_statocommessa.Name = "gv_pack_explo_statocommessa";
            this.gv_pack_explo_statocommessa.Visible = false;
            // 
            // gv_pack_explo_tiporiga
            // 
            this.gv_pack_explo_tiporiga.DataPropertyName = "TipoRiga";
            this.gv_pack_explo_tiporiga.HeaderText = "TipoRiga";
            this.gv_pack_explo_tiporiga.Name = "gv_pack_explo_tiporiga";
            this.gv_pack_explo_tiporiga.Visible = false;
            // 
            // gv_pack_explo_isKit
            // 
            this.gv_pack_explo_isKit.DataPropertyName = "Is_Kit";
            this.gv_pack_explo_isKit.HeaderText = "Is_Kit";
            this.gv_pack_explo_isKit.Name = "gv_pack_explo_isKit";
            this.gv_pack_explo_isKit.Visible = false;
            // 
            // gv_pack_explo_isSWRP
            // 
            this.gv_pack_explo_isSWRP.DataPropertyName = "Is_SWR_P";
            this.gv_pack_explo_isSWRP.HeaderText = "Is_SWR_P";
            this.gv_pack_explo_isSWRP.Name = "gv_pack_explo_isSWRP";
            this.gv_pack_explo_isSWRP.Visible = false;
            // 
            // gv_pack_explo_isSWRR
            // 
            this.gv_pack_explo_isSWRR.DataPropertyName = "Is_SWR_R";
            this.gv_pack_explo_isSWRR.HeaderText = "Is_SWR_R";
            this.gv_pack_explo_isSWRR.Name = "gv_pack_explo_isSWRR";
            this.gv_pack_explo_isSWRR.Visible = false;
            // 
            // gv_pack_explo_datafinevalid
            // 
            this.gv_pack_explo_datafinevalid.DataPropertyName = "DataFineValidita";
            this.gv_pack_explo_datafinevalid.HeaderText = "DataFineValidita";
            this.gv_pack_explo_datafinevalid.Name = "gv_pack_explo_datafinevalid";
            this.gv_pack_explo_datafinevalid.Visible = false;
            // 
            // gv_pack_explo_device
            // 
            this.gv_pack_explo_device.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gv_pack_explo_device.DataPropertyName = "Device";
            this.gv_pack_explo_device.HeaderText = "Device";
            this.gv_pack_explo_device.Name = "gv_pack_explo_device";
            this.gv_pack_explo_device.Width = 63;
            // 
            // gv_pack_explo_swdevice
            // 
            this.gv_pack_explo_swdevice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gv_pack_explo_swdevice.DataPropertyName = "SW_Device";
            this.gv_pack_explo_swdevice.HeaderText = "FW Device";
            this.gv_pack_explo_swdevice.Name = "gv_pack_explo_swdevice";
            // 
            // gv_pack_explo_qtaevasa
            // 
            this.gv_pack_explo_qtaevasa.DataPropertyName = "Qta_Evasa";
            this.gv_pack_explo_qtaevasa.HeaderText = "Qta_Evasa";
            this.gv_pack_explo_qtaevasa.Name = "gv_pack_explo_qtaevasa";
            this.gv_pack_explo_qtaevasa.ReadOnly = true;
            this.gv_pack_explo_qtaevasa.Visible = false;
            // 
            // gv_pack_explo_sercommessa
            // 
            this.gv_pack_explo_sercommessa.DataPropertyName = "Ser_Commessa";
            this.gv_pack_explo_sercommessa.HeaderText = "Ser_Commessa";
            this.gv_pack_explo_sercommessa.Name = "gv_pack_explo_sercommessa";
            this.gv_pack_explo_sercommessa.Visible = false;
            // 
            // gv_pack_explo_serkit
            // 
            this.gv_pack_explo_serkit.DataPropertyName = "Ser_Kit";
            this.gv_pack_explo_serkit.HeaderText = "Ser_Kit";
            this.gv_pack_explo_serkit.Name = "gv_pack_explo_serkit";
            this.gv_pack_explo_serkit.Visible = false;
            // 
            // gv_pack_explo_serDevice
            // 
            this.gv_pack_explo_serDevice.DataPropertyName = "Ser_Device";
            this.gv_pack_explo_serDevice.HeaderText = "Ser_Device";
            this.gv_pack_explo_serDevice.Name = "gv_pack_explo_serDevice";
            this.gv_pack_explo_serDevice.Visible = false;
            // 
            // gv_pack_explo_daincludere
            // 
            this.gv_pack_explo_daincludere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gv_pack_explo_daincludere.HeaderText = "Incluso nel pack";
            this.gv_pack_explo_daincludere.Name = "gv_pack_explo_daincludere";
            // 
            // gv_pack_explo_Path
            // 
            this.gv_pack_explo_Path.HeaderText = "path";
            this.gv_pack_explo_Path.Name = "gv_pack_explo_Path";
            this.gv_pack_explo_Path.Visible = false;
            // 
            // UC_Pack_Commessa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 500);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Schede);
            this.Controls.Add(this.layout_orizz_menu);
            this.DisplayHeader = false;
            this.Name = "UC_Pack_Commessa";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UC_Pack_Commessa_Load);
            this.panel_Schede.ResumeLayout(false);
            this.layout_Pack.ResumeLayout(false);
            this.panel_grid_pack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_commessa)).EndInit();
            this.metroPanel7.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_pack_explo)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_pack_kit.ResumeLayout(false);
            this.panel_des_art_Kit_pack.ResumeLayout(false);
            this.panel_des_art_Kit_pack.PerformLayout();
            this.layout_orizz_menu.ResumeLayout(false);
            this.layout_orizz_menu.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pack_Kit_pdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFCommesseSLPackCommesseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFCommesseSLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panel_Schede;
        private System.Windows.Forms.TableLayoutPanel layout_Pack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ds_SL ds_SL;
        private ds_Programmazione ds_Programmazione;
        private MetroFramework.Controls.MetroPanel panel_grid_pack;
        private MetroFramework.Controls.MetroGrid gv_commessa;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private MetroFramework.Controls.MetroTextBox tb_grid_commessa_pack;
        private MetroFramework.Controls.MetroPanel panel_des_art_Kit_pack;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroGrid gv_pack_explo;
        private MetroFramework.Controls.MetroButton btn_do_pack_kit;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroCheckBox cb_Doc_EN;
        private MetroFramework.Controls.MetroCheckBox cb_Doc_IT;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroPanel panel_pack_kit;
        private AxAcroPDFLib.AxAcroPDF pack_Kit_pdf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel layout_orizz_menu;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private System.Windows.Forms.BindingSource sFCommesseSLPackCommesseBindingSource;
        private ds_SLTableAdapters.SF_Commesse_SL_Pack_CommesseTableAdapter sF_Commesse_SL_Pack_CommesseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_commessa_commessa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_commessa_data_ordine;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_commessa_dataconfcons;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_commessa_numord;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_commessa_codanag;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_commessa_ragsoc;
        private System.Windows.Forms.BindingSource sFCommesseSLBindingSource;
        private ds_ProgrammazioneTableAdapters.SF_Commesse_SLTableAdapter sF_Commesse_SLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_tipoordine;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_commessalong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_commessashort;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_dataord;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_dataconfcons;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_numord;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_numriga;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_codanag;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_ragsoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_artcommessa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_um;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_qtaord;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_qta_evadere;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_statocommessa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_tiporiga;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_isKit;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_isSWRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_isSWRR;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_datafinevalid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_device;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_swdevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_qtaevasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_sercommessa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_serkit;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_serDevice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gv_pack_explo_daincludere;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_pack_explo_Path;
    }
}
