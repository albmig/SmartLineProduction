namespace SmartLineProduction
{
    partial class UC_Programmazione_Progettazione
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Programmazione_Progettazione));
            this.commandPanel = new MetroFramework.Controls.MetroPanel();
            this.pan_tipoprogramma = new MetroFramework.Controls.MetroPanel();
            this.grid_prototipi = new MetroFramework.Controls.MetroGrid();
            this.grid_prototipi_DataRichiesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_prototipi_ArticoloProgettazione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_prototipi_Commessa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_prototipi_CodAnagrafico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_prototipi_RagSocCognome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_prototipi_Articolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_prototipi_Descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_prototipi_Qta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_prototipi_FW_loading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_prototipi_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_prototipi_CommessaDefinizione = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grid_prototipi_CommessaProgramma = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grid_prototipi_menu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.menu_commesse_vis = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_commesse_nas = new System.Windows.Forms.ToolStripMenuItem();
            this.sFProgettazioneSLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Prototipi = new SmartLineProduction.ds_Prototipi();
            this.safetyPointRFIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Programmazione = new SmartLineProduction.ds_Programmazione();
            this.outputPanel = new MetroFramework.Controls.MetroPanel();
            this.dos_box = new System.Windows.Forms.TextBox();
            this.layout_orizz_menu = new System.Windows.Forms.TableLayoutPanel();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.aggiornaArchiviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fWClientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serialNumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sF_Progettazione_SLTableAdapter = new SmartLineProduction.ds_PrototipiTableAdapters.SF_Progettazione_SLTableAdapter();
            this.serialNumbersTableAdapter = new SmartLineProduction.ds_PrototipiTableAdapters.SerialNumbersTableAdapter();
            this.sFLastSerialNumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sF_LastSerialNumberTableAdapter = new SmartLineProduction.ds_PrototipiTableAdapters.SF_LastSerialNumberTableAdapter();
            this.firmwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmwareTableAdapter = new SmartLineProduction.ds_PrototipiTableAdapters.FirmwareTableAdapter();
            this.fW_ClientiTableAdapter = new SmartLineProduction.ds_PrototipiTableAdapters.FW_ClientiTableAdapter();
            this.famProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fam_ProdTableAdapter = new SmartLineProduction.ds_PrototipiTableAdapters.Fam_ProdTableAdapter();
            this.safetyPointRFIDTableAdapter = new SmartLineProduction.ds_ProgrammazioneTableAdapters.SafetyPointRFIDTableAdapter();
            this.commandPanel.SuspendLayout();
            this.pan_tipoprogramma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_prototipi)).BeginInit();
            this.grid_prototipi_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFProgettazioneSLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Prototipi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safetyPointRFIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Programmazione)).BeginInit();
            this.outputPanel.SuspendLayout();
            this.layout_orizz_menu.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fWClientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumbersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFLastSerialNumberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.famProdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // commandPanel
            // 
            this.commandPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.commandPanel.Controls.Add(this.pan_tipoprogramma);
            this.commandPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandPanel.HorizontalScrollbarBarColor = true;
            this.commandPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.commandPanel.HorizontalScrollbarSize = 10;
            this.commandPanel.Location = new System.Drawing.Point(20, 55);
            this.commandPanel.Name = "commandPanel";
            this.commandPanel.Size = new System.Drawing.Size(946, 713);
            this.commandPanel.TabIndex = 71;
            this.commandPanel.VerticalScrollbarBarColor = true;
            this.commandPanel.VerticalScrollbarHighlightOnWheel = false;
            this.commandPanel.VerticalScrollbarSize = 10;
            // 
            // pan_tipoprogramma
            // 
            this.pan_tipoprogramma.Controls.Add(this.grid_prototipi);
            this.pan_tipoprogramma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_tipoprogramma.HorizontalScrollbarBarColor = true;
            this.pan_tipoprogramma.HorizontalScrollbarHighlightOnWheel = false;
            this.pan_tipoprogramma.HorizontalScrollbarSize = 10;
            this.pan_tipoprogramma.Location = new System.Drawing.Point(0, 0);
            this.pan_tipoprogramma.Name = "pan_tipoprogramma";
            this.pan_tipoprogramma.Size = new System.Drawing.Size(942, 709);
            this.pan_tipoprogramma.TabIndex = 6;
            this.pan_tipoprogramma.VerticalScrollbarBarColor = true;
            this.pan_tipoprogramma.VerticalScrollbarHighlightOnWheel = false;
            this.pan_tipoprogramma.VerticalScrollbarSize = 10;
            // 
            // grid_prototipi
            // 
            this.grid_prototipi.AllowUserToAddRows = false;
            this.grid_prototipi.AllowUserToDeleteRows = false;
            this.grid_prototipi.AllowUserToResizeRows = false;
            this.grid_prototipi.AutoGenerateColumns = false;
            this.grid_prototipi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_prototipi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_prototipi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_prototipi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_prototipi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_prototipi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_prototipi.ColumnHeadersHeight = 40;
            this.grid_prototipi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_prototipi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_prototipi_DataRichiesta,
            this.grid_prototipi_ArticoloProgettazione,
            this.grid_prototipi_Commessa,
            this.grid_prototipi_CodAnagrafico,
            this.grid_prototipi_RagSocCognome,
            this.grid_prototipi_Articolo,
            this.grid_prototipi_Descrizione,
            this.grid_prototipi_Qta,
            this.grid_prototipi_FW_loading,
            this.grid_prototipi_ID,
            this.grid_prototipi_CommessaDefinizione,
            this.grid_prototipi_CommessaProgramma});
            this.grid_prototipi.ContextMenuStrip = this.grid_prototipi_menu;
            this.grid_prototipi.DataSource = this.sFProgettazioneSLBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_prototipi.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_prototipi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_prototipi.EnableHeadersVisualStyles = false;
            this.grid_prototipi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_prototipi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_prototipi.Location = new System.Drawing.Point(0, 0);
            this.grid_prototipi.MultiSelect = false;
            this.grid_prototipi.Name = "grid_prototipi";
            this.grid_prototipi.ReadOnly = true;
            this.grid_prototipi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_prototipi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_prototipi.RowHeadersVisible = false;
            this.grid_prototipi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_prototipi.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Wheat;
            this.grid_prototipi.RowTemplate.Height = 25;
            this.grid_prototipi.RowTemplate.ReadOnly = true;
            this.grid_prototipi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_prototipi.Size = new System.Drawing.Size(942, 709);
            this.grid_prototipi.Style = MetroFramework.MetroColorStyle.Red;
            this.grid_prototipi.TabIndex = 2;
            this.grid_prototipi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_prototipi_CellContentClick);
            this.grid_prototipi.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grid_prototipi_CellPainting);
            // 
            // grid_prototipi_DataRichiesta
            // 
            this.grid_prototipi_DataRichiesta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.grid_prototipi_DataRichiesta.DataPropertyName = "DataRichiesta";
            this.grid_prototipi_DataRichiesta.HeaderText = "Data Richiesta";
            this.grid_prototipi_DataRichiesta.Name = "grid_prototipi_DataRichiesta";
            this.grid_prototipi_DataRichiesta.ReadOnly = true;
            this.grid_prototipi_DataRichiesta.Width = 94;
            // 
            // grid_prototipi_ArticoloProgettazione
            // 
            this.grid_prototipi_ArticoloProgettazione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grid_prototipi_ArticoloProgettazione.DataPropertyName = "ArticoloProgettazione";
            this.grid_prototipi_ArticoloProgettazione.HeaderText = "Articolo di Progetto";
            this.grid_prototipi_ArticoloProgettazione.Name = "grid_prototipi_ArticoloProgettazione";
            this.grid_prototipi_ArticoloProgettazione.ReadOnly = true;
            // 
            // grid_prototipi_Commessa
            // 
            this.grid_prototipi_Commessa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.grid_prototipi_Commessa.DataPropertyName = "Commessa";
            this.grid_prototipi_Commessa.HeaderText = "Commessa";
            this.grid_prototipi_Commessa.Name = "grid_prototipi_Commessa";
            this.grid_prototipi_Commessa.ReadOnly = true;
            this.grid_prototipi_Commessa.Width = 84;
            // 
            // grid_prototipi_CodAnagrafico
            // 
            this.grid_prototipi_CodAnagrafico.DataPropertyName = "CodAnagrafico";
            this.grid_prototipi_CodAnagrafico.HeaderText = "CodAnagrafico";
            this.grid_prototipi_CodAnagrafico.Name = "grid_prototipi_CodAnagrafico";
            this.grid_prototipi_CodAnagrafico.ReadOnly = true;
            this.grid_prototipi_CodAnagrafico.Visible = false;
            this.grid_prototipi_CodAnagrafico.Width = 107;
            // 
            // grid_prototipi_RagSocCognome
            // 
            this.grid_prototipi_RagSocCognome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grid_prototipi_RagSocCognome.DataPropertyName = "RagSocCognome";
            this.grid_prototipi_RagSocCognome.HeaderText = "Ragione Sociale";
            this.grid_prototipi_RagSocCognome.Name = "grid_prototipi_RagSocCognome";
            this.grid_prototipi_RagSocCognome.ReadOnly = true;
            // 
            // grid_prototipi_Articolo
            // 
            this.grid_prototipi_Articolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grid_prototipi_Articolo.DataPropertyName = "ArticoloComponente";
            this.grid_prototipi_Articolo.HeaderText = "Device";
            this.grid_prototipi_Articolo.Name = "grid_prototipi_Articolo";
            this.grid_prototipi_Articolo.ReadOnly = true;
            // 
            // grid_prototipi_Descrizione
            // 
            this.grid_prototipi_Descrizione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grid_prototipi_Descrizione.DataPropertyName = "Descrizione";
            this.grid_prototipi_Descrizione.HeaderText = "Descrizione";
            this.grid_prototipi_Descrizione.Name = "grid_prototipi_Descrizione";
            this.grid_prototipi_Descrizione.ReadOnly = true;
            // 
            // grid_prototipi_Qta
            // 
            this.grid_prototipi_Qta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.grid_prototipi_Qta.DataPropertyName = "QuantitaRichiesta";
            this.grid_prototipi_Qta.HeaderText = "Quantità Richiesta";
            this.grid_prototipi_Qta.Name = "grid_prototipi_Qta";
            this.grid_prototipi_Qta.ReadOnly = true;
            this.grid_prototipi_Qta.Width = 113;
            // 
            // grid_prototipi_FW_loading
            // 
            this.grid_prototipi_FW_loading.HeaderText = "FW definito";
            this.grid_prototipi_FW_loading.Name = "grid_prototipi_FW_loading";
            this.grid_prototipi_FW_loading.ReadOnly = true;
            this.grid_prototipi_FW_loading.Width = 84;
            // 
            // grid_prototipi_ID
            // 
            this.grid_prototipi_ID.HeaderText = "ID";
            this.grid_prototipi_ID.Name = "grid_prototipi_ID";
            this.grid_prototipi_ID.ReadOnly = true;
            this.grid_prototipi_ID.Width = 41;
            // 
            // grid_prototipi_CommessaDefinizione
            // 
            this.grid_prototipi_CommessaDefinizione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.grid_prototipi_CommessaDefinizione.HeaderText = "Definisci";
            this.grid_prototipi_CommessaDefinizione.Name = "grid_prototipi_CommessaDefinizione";
            this.grid_prototipi_CommessaDefinizione.ReadOnly = true;
            this.grid_prototipi_CommessaDefinizione.Text = "Definisci ->";
            this.grid_prototipi_CommessaDefinizione.UseColumnTextForButtonValue = true;
            this.grid_prototipi_CommessaDefinizione.Width = 55;
            // 
            // grid_prototipi_CommessaProgramma
            // 
            this.grid_prototipi_CommessaProgramma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.grid_prototipi_CommessaProgramma.HeaderText = "Programma";
            this.grid_prototipi_CommessaProgramma.Name = "grid_prototipi_CommessaProgramma";
            this.grid_prototipi_CommessaProgramma.ReadOnly = true;
            this.grid_prototipi_CommessaProgramma.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_prototipi_CommessaProgramma.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.grid_prototipi_CommessaProgramma.Text = "Programma  ->";
            this.grid_prototipi_CommessaProgramma.UseColumnTextForButtonValue = true;
            this.grid_prototipi_CommessaProgramma.Width = 88;
            // 
            // grid_prototipi_menu
            // 
            this.grid_prototipi_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_commesse_vis,
            this.menu_commesse_nas});
            this.grid_prototipi_menu.Name = "grid_commesse_menu";
            this.grid_prototipi_menu.Size = new System.Drawing.Size(229, 48);
            this.grid_prototipi_menu.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // menu_commesse_vis
            // 
            this.menu_commesse_vis.Name = "menu_commesse_vis";
            this.menu_commesse_vis.Size = new System.Drawing.Size(228, 22);
            this.menu_commesse_vis.Text = "Visualizza le commesse evase";
            // 
            // menu_commesse_nas
            // 
            this.menu_commesse_nas.Name = "menu_commesse_nas";
            this.menu_commesse_nas.Size = new System.Drawing.Size(228, 22);
            this.menu_commesse_nas.Text = "Nascondi le commesse evase";
            // 
            // sFProgettazioneSLBindingSource
            // 
            this.sFProgettazioneSLBindingSource.DataMember = "SF_Progettazione_SL";
            this.sFProgettazioneSLBindingSource.DataSource = this.ds_Prototipi;
            this.sFProgettazioneSLBindingSource.Filter = "";
            this.sFProgettazioneSLBindingSource.Sort = "DataRichiesta asc, ArticoloComponente desc";
            // 
            // ds_Prototipi
            // 
            this.ds_Prototipi.DataSetName = "ds_Prototipi";
            this.ds_Prototipi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // safetyPointRFIDBindingSource
            // 
            this.safetyPointRFIDBindingSource.DataMember = "SafetyPointRFID";
            this.safetyPointRFIDBindingSource.DataSource = this.ds_Programmazione;
            // 
            // ds_Programmazione
            // 
            this.ds_Programmazione.DataSetName = "ds_Programmazione";
            this.ds_Programmazione.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // outputPanel
            // 
            this.outputPanel.Controls.Add(this.dos_box);
            this.outputPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.outputPanel.HorizontalScrollbarBarColor = true;
            this.outputPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.outputPanel.HorizontalScrollbarSize = 10;
            this.outputPanel.Location = new System.Drawing.Point(966, 55);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(400, 713);
            this.outputPanel.TabIndex = 72;
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
            this.dos_box.Size = new System.Drawing.Size(400, 713);
            this.dos_box.TabIndex = 68;
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
            this.layout_orizz_menu.Controls.Add(this.pan_Menu_exit, 9, 0);
            this.layout_orizz_menu.Controls.Add(this.MainMenu, 0, 0);
            this.layout_orizz_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.layout_orizz_menu.Location = new System.Drawing.Point(20, 30);
            this.layout_orizz_menu.Name = "layout_orizz_menu";
            this.layout_orizz_menu.RowCount = 1;
            this.layout_orizz_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_orizz_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layout_orizz_menu.Size = new System.Drawing.Size(1346, 25);
            this.layout_orizz_menu.TabIndex = 124;
            // 
            // pan_Menu_exit
            // 
            this.pan_Menu_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_Menu_exit.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_Menu_exit.Dock = System.Windows.Forms.DockStyle.None;
            this.pan_Menu_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sw_exit});
            this.pan_Menu_exit.Location = new System.Drawing.Point(1271, 0);
            this.pan_Menu_exit.Name = "pan_Menu_exit";
            this.pan_Menu_exit.Size = new System.Drawing.Size(75, 24);
            this.pan_Menu_exit.TabIndex = 83;
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
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.layout_orizz_menu.SetColumnSpan(this.MainMenu, 6);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiornaArchiviToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(804, 24);
            this.MainMenu.TabIndex = 71;
            this.MainMenu.Text = "menuStrip1";
            // 
            // aggiornaArchiviToolStripMenuItem
            // 
            this.aggiornaArchiviToolStripMenuItem.Name = "aggiornaArchiviToolStripMenuItem";
            this.aggiornaArchiviToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.aggiornaArchiviToolStripMenuItem.Text = "Aggiorna Archivi";
            this.aggiornaArchiviToolStripMenuItem.Click += new System.EventHandler(this.aggiornaArchiviToolStripMenuItem_Click);
            // 
            // fWClientiBindingSource
            // 
            this.fWClientiBindingSource.DataMember = "FW_Clienti";
            this.fWClientiBindingSource.DataSource = this.ds_Prototipi;
            // 
            // serialNumbersBindingSource
            // 
            this.serialNumbersBindingSource.DataMember = "SerialNumbers";
            this.serialNumbersBindingSource.DataSource = this.ds_Prototipi;
            // 
            // sF_Progettazione_SLTableAdapter
            // 
            this.sF_Progettazione_SLTableAdapter.ClearBeforeFill = true;
            // 
            // serialNumbersTableAdapter
            // 
            this.serialNumbersTableAdapter.ClearBeforeFill = true;
            // 
            // sFLastSerialNumberBindingSource
            // 
            this.sFLastSerialNumberBindingSource.DataMember = "SF_LastSerialNumber";
            this.sFLastSerialNumberBindingSource.DataSource = this.ds_Prototipi;
            // 
            // sF_LastSerialNumberTableAdapter
            // 
            this.sF_LastSerialNumberTableAdapter.ClearBeforeFill = true;
            // 
            // firmwareBindingSource
            // 
            this.firmwareBindingSource.DataMember = "Firmware";
            this.firmwareBindingSource.DataSource = this.ds_Prototipi;
            // 
            // firmwareTableAdapter
            // 
            this.firmwareTableAdapter.ClearBeforeFill = true;
            // 
            // fW_ClientiTableAdapter
            // 
            this.fW_ClientiTableAdapter.ClearBeforeFill = true;
            // 
            // famProdBindingSource
            // 
            this.famProdBindingSource.DataMember = "Fam_Prod";
            this.famProdBindingSource.DataSource = this.ds_Prototipi;
            // 
            // fam_ProdTableAdapter
            // 
            this.fam_ProdTableAdapter.ClearBeforeFill = true;
            // 
            // safetyPointRFIDTableAdapter
            // 
            this.safetyPointRFIDTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Programmazione_Progettazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.commandPanel);
            this.Controls.Add(this.outputPanel);
            this.Controls.Add(this.layout_orizz_menu);
            this.DisplayHeader = false;
            this.Name = "UC_Programmazione_Progettazione";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UC_Programmazione_Progettazione_Load);
            this.commandPanel.ResumeLayout(false);
            this.pan_tipoprogramma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_prototipi)).EndInit();
            this.grid_prototipi_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sFProgettazioneSLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Prototipi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safetyPointRFIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Programmazione)).EndInit();
            this.outputPanel.ResumeLayout(false);
            this.outputPanel.PerformLayout();
            this.layout_orizz_menu.ResumeLayout(false);
            this.layout_orizz_menu.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fWClientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNumbersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFLastSerialNumberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.famProdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel commandPanel;
        private MetroFramework.Controls.MetroPanel pan_tipoprogramma;
        private MetroFramework.Controls.MetroGrid grid_prototipi;
        private MetroFramework.Controls.MetroPanel outputPanel;
        private System.Windows.Forms.TextBox dos_box;
        private System.Windows.Forms.TableLayoutPanel layout_orizz_menu;
        private ds_Prototipi ds_Prototipi;
        private System.Windows.Forms.BindingSource sFProgettazioneSLBindingSource;
        private ds_PrototipiTableAdapters.SF_Progettazione_SLTableAdapter sF_Progettazione_SLTableAdapter;
        private System.Windows.Forms.BindingSource serialNumbersBindingSource;
        private ds_PrototipiTableAdapters.SerialNumbersTableAdapter serialNumbersTableAdapter;
        private System.Windows.Forms.BindingSource sFLastSerialNumberBindingSource;
        private ds_PrototipiTableAdapters.SF_LastSerialNumberTableAdapter sF_LastSerialNumberTableAdapter;
        private MetroFramework.Controls.MetroContextMenu grid_prototipi_menu;
        private System.Windows.Forms.ToolStripMenuItem menu_commesse_vis;
        private System.Windows.Forms.ToolStripMenuItem menu_commesse_nas;
        private System.Windows.Forms.BindingSource firmwareBindingSource;
        private ds_PrototipiTableAdapters.FirmwareTableAdapter firmwareTableAdapter;
        private System.Windows.Forms.BindingSource fWClientiBindingSource;
        private ds_PrototipiTableAdapters.FW_ClientiTableAdapter fW_ClientiTableAdapter;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem aggiornaArchiviToolStripMenuItem;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private System.Windows.Forms.BindingSource famProdBindingSource;
        private ds_PrototipiTableAdapters.Fam_ProdTableAdapter fam_ProdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_prototipi_DataRichiesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_prototipi_ArticoloProgettazione;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_prototipi_Commessa;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_prototipi_CodAnagrafico;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_prototipi_RagSocCognome;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_prototipi_Articolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_prototipi_Descrizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_prototipi_Qta;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_prototipi_FW_loading;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_prototipi_ID;
        private System.Windows.Forms.DataGridViewButtonColumn grid_prototipi_CommessaDefinizione;
        private System.Windows.Forms.DataGridViewButtonColumn grid_prototipi_CommessaProgramma;
        private ds_Programmazione ds_Programmazione;
        private System.Windows.Forms.BindingSource safetyPointRFIDBindingSource;
        private ds_ProgrammazioneTableAdapters.SafetyPointRFIDTableAdapter safetyPointRFIDTableAdapter;
    }
}