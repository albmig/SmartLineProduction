namespace SmartLineProduction
{
    partial class UC_Schede
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Schede));
            this.panel_Schede = new MetroFramework.Controls.MetroPanel();
            this.layout_Schede = new System.Windows.Forms.TableLayoutPanel();
            this.panel_grid_Schede = new MetroFramework.Controls.MetroPanel();
            this.gv_Schede = new MetroFramework.Controls.MetroGrid();
            this.gv_Schede_Articolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Schede_SiglaCli_Kit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Schede_Famiglia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Schede_Des_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Schede_Des_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Schede_Modello = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copytoclipboard = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.copiaIlValoreNellaClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sFArticoliSchedeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_SL = new SmartLineProduction.ds_SL();
            this.panel_filter_FW = new MetroFramework.Controls.MetroPanel();
            this.radio_FW_all = new MetroFramework.Controls.MetroRadioButton();
            this.radio_FW_custom = new MetroFramework.Controls.MetroRadioButton();
            this.radio_FW_standard = new MetroFramework.Controls.MetroRadioButton();
            this.panel_filter_cli = new MetroFramework.Controls.MetroPanel();
            this.cb_Cliente = new System.Windows.Forms.ComboBox();
            this.tabSiglacliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_search = new MetroFramework.Controls.MetroPanel();
            this.tb_search = new MetroFramework.Controls.MetroTextBox();
            this.panel_des_art_Kit = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.but_implosion = new MetroFramework.Controls.MetroButton();
            this.lab_des1_articolo = new MetroFramework.Controls.MetroLabel();
            this.lab_des2_articolo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel_pdf_it = new MetroFramework.Controls.MetroPanel();
            this.Schede_pdf = new DevExpress.XtraPdfViewer.PdfViewer();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.pdfCommandBar1 = new DevExpress.XtraPdfViewer.Bars.PdfCommandBar();
            this.pdfFileSaveAsBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem();
            this.pdfFilePrintBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem();
            this.pdfFindTextBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem();
            this.pdfPreviousPageBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem();
            this.pdfNextPageBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem();
            this.pdfSetPageNumberBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem();
            this.repositoryItemPageNumberEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit();
            this.pdfZoomOutBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem();
            this.pdfZoomInBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem();
            this.pdfExactZoomListBarSubItem1 = new DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem();
            this.pdfZoom10CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem();
            this.pdfZoom25CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem();
            this.pdfZoom50CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem();
            this.pdfZoom75CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem();
            this.pdfZoom100CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem();
            this.pdfZoom125CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem();
            this.pdfZoom150CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem();
            this.pdfZoom200CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem();
            this.pdfZoom400CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem();
            this.pdfZoom500CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem();
            this.pdfSetActualSizeZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem();
            this.pdfSetPageLevelZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem();
            this.pdfSetFitWidthZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem();
            this.pdfSetFitVisibleZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pdfFileOpenBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panel_language = new MetroFramework.Controls.MetroPanel();
            this.but_pdf_eng = new System.Windows.Forms.Button();
            this.but_pdf_ita = new System.Windows.Forms.Button();
            this.layout_orizz_menu = new System.Windows.Forms.TableLayoutPanel();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.layout_tabbed_pages = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Kit = new MetroFramework.Controls.MetroButton();
            this.btn_Palmari = new MetroFramework.Controls.MetroButton();
            this.btn_Ricevitori = new MetroFramework.Controls.MetroButton();
            this.btn_Cablaggi = new MetroFramework.Controls.MetroButton();
            this.btn_FW_P = new MetroFramework.Controls.MetroButton();
            this.btn_FW_R = new MetroFramework.Controls.MetroButton();
            this.sFDistinteBasiSchedeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.famProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sF_ArticoliSchedeTableAdapter = new SmartLineProduction.ds_SLTableAdapters.SF_ArticoliSchedeTableAdapter();
            this.sF_DistinteBasi_SchedeTableAdapter = new SmartLineProduction.ds_SLTableAdapters.SF_DistinteBasi_SchedeTableAdapter();
            this.fam_ProdTableAdapter = new SmartLineProduction.ds_SLTableAdapters.Fam_ProdTableAdapter();
            this.sFArticoliToXSWRSchedeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sF_ArticoliToXSWR_SchedeTableAdapter = new SmartLineProduction.ds_SLTableAdapters.SF_ArticoliToXSWR_SchedeTableAdapter();
            this.sF_ArticoliTableAdapter = new SmartLineProduction.ds_ProgrammazioneTableAdapters.SF_ArticoliTableAdapter();
            this.tab_SiglacliTableAdapter = new SmartLineProduction.ds_SLTableAdapters.Tab_SiglacliTableAdapter();
            this.pdfBarController1 = new DevExpress.XtraPdfViewer.Bars.PdfBarController(this.components);
            this.panel_Schede.SuspendLayout();
            this.layout_Schede.SuspendLayout();
            this.panel_grid_Schede.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Schede)).BeginInit();
            this.copytoclipboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFArticoliSchedeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).BeginInit();
            this.panel_filter_FW.SuspendLayout();
            this.panel_filter_cli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabSiglacliBindingSource)).BeginInit();
            this.panel_search.SuspendLayout();
            this.panel_des_art_Kit.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_pdf_it.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit1)).BeginInit();
            this.panel_language.SuspendLayout();
            this.layout_orizz_menu.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            this.layout_tabbed_pages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sFDistinteBasiSchedeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.famProdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFArticoliToXSWRSchedeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Schede
            // 
            this.panel_Schede.Controls.Add(this.layout_Schede);
            this.panel_Schede.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Schede.HorizontalScrollbarBarColor = true;
            this.panel_Schede.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_Schede.HorizontalScrollbarSize = 10;
            this.panel_Schede.Location = new System.Drawing.Point(20, 85);
            this.panel_Schede.Name = "panel_Schede";
            this.panel_Schede.Size = new System.Drawing.Size(1160, 395);
            this.panel_Schede.TabIndex = 122;
            this.panel_Schede.VerticalScrollbarBarColor = true;
            this.panel_Schede.VerticalScrollbarHighlightOnWheel = false;
            this.panel_Schede.VerticalScrollbarSize = 10;
            // 
            // layout_Schede
            // 
            this.layout_Schede.ColumnCount = 3;
            this.layout_Schede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.layout_Schede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Schede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Schede.Controls.Add(this.panel_grid_Schede, 0, 0);
            this.layout_Schede.Controls.Add(this.panel_des_art_Kit, 1, 0);
            this.layout_Schede.Controls.Add(this.panel_pdf_it, 1, 1);
            this.layout_Schede.Controls.Add(this.panel_language, 2, 1);
            this.layout_Schede.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Schede.Location = new System.Drawing.Point(0, 0);
            this.layout_Schede.Name = "layout_Schede";
            this.layout_Schede.RowCount = 2;
            this.layout_Schede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layout_Schede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Schede.Size = new System.Drawing.Size(1160, 395);
            this.layout_Schede.TabIndex = 123;
            // 
            // panel_grid_Schede
            // 
            this.panel_grid_Schede.Controls.Add(this.gv_Schede);
            this.panel_grid_Schede.Controls.Add(this.panel_filter_FW);
            this.panel_grid_Schede.Controls.Add(this.panel_filter_cli);
            this.panel_grid_Schede.Controls.Add(this.panel_search);
            this.panel_grid_Schede.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_grid_Schede.HorizontalScrollbarBarColor = true;
            this.panel_grid_Schede.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_grid_Schede.HorizontalScrollbarSize = 10;
            this.panel_grid_Schede.Location = new System.Drawing.Point(3, 3);
            this.panel_grid_Schede.Name = "panel_grid_Schede";
            this.layout_Schede.SetRowSpan(this.panel_grid_Schede, 2);
            this.panel_grid_Schede.Size = new System.Drawing.Size(194, 389);
            this.panel_grid_Schede.TabIndex = 83;
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
            this.gv_Schede.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gv_Schede_Articolo,
            this.gv_Schede_SiglaCli_Kit,
            this.gv_Schede_Famiglia,
            this.gv_Schede_Des_1,
            this.gv_Schede_Des_2,
            this.gv_Schede_Modello});
            this.gv_Schede.ContextMenuStrip = this.copytoclipboard;
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
            this.gv_Schede.Location = new System.Drawing.Point(0, 126);
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
            this.gv_Schede.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Wheat;
            this.gv_Schede.RowTemplate.Height = 30;
            this.gv_Schede.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Schede.Size = new System.Drawing.Size(194, 263);
            this.gv_Schede.Style = MetroFramework.MetroColorStyle.Red;
            this.gv_Schede.TabIndex = 0;
            this.gv_Schede.UseStyleColors = true;
            this.gv_Schede.SelectionChanged += new System.EventHandler(this.gv_Schede_SelectionChanged);
            // 
            // gv_Schede_Articolo
            // 
            this.gv_Schede_Articolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gv_Schede_Articolo.DataPropertyName = "Articolo";
            this.gv_Schede_Articolo.HeaderText = "Kit";
            this.gv_Schede_Articolo.Name = "gv_Schede_Articolo";
            this.gv_Schede_Articolo.ReadOnly = true;
            // 
            // gv_Schede_SiglaCli_Kit
            // 
            this.gv_Schede_SiglaCli_Kit.DataPropertyName = "SiglaCli_Kit";
            this.gv_Schede_SiglaCli_Kit.HeaderText = "SiglaCli_Kit";
            this.gv_Schede_SiglaCli_Kit.Name = "gv_Schede_SiglaCli_Kit";
            this.gv_Schede_SiglaCli_Kit.ReadOnly = true;
            this.gv_Schede_SiglaCli_Kit.Visible = false;
            // 
            // gv_Schede_Famiglia
            // 
            this.gv_Schede_Famiglia.DataPropertyName = "Famiglia";
            this.gv_Schede_Famiglia.HeaderText = "Famiglia";
            this.gv_Schede_Famiglia.Name = "gv_Schede_Famiglia";
            this.gv_Schede_Famiglia.ReadOnly = true;
            this.gv_Schede_Famiglia.Visible = false;
            // 
            // gv_Schede_Des_1
            // 
            this.gv_Schede_Des_1.DataPropertyName = "Descrizione";
            this.gv_Schede_Des_1.HeaderText = "Descrizione";
            this.gv_Schede_Des_1.Name = "gv_Schede_Des_1";
            this.gv_Schede_Des_1.ReadOnly = true;
            this.gv_Schede_Des_1.Visible = false;
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
            // copytoclipboard
            // 
            this.copytoclipboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiaIlValoreNellaClipboardToolStripMenuItem});
            this.copytoclipboard.Name = "copytoclipboard";
            this.copytoclipboard.Size = new System.Drawing.Size(231, 26);
            // 
            // copiaIlValoreNellaClipboardToolStripMenuItem
            // 
            this.copiaIlValoreNellaClipboardToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.copiaIlValoreNellaClipboardToolStripMenuItem.Name = "copiaIlValoreNellaClipboardToolStripMenuItem";
            this.copiaIlValoreNellaClipboardToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.copiaIlValoreNellaClipboardToolStripMenuItem.Text = "Copia il valore nella clipboard";
            this.copiaIlValoreNellaClipboardToolStripMenuItem.Click += new System.EventHandler(this.copiaIlValoreNellaClipboardToolStripMenuItem_Click);
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
            // panel_filter_FW
            // 
            this.panel_filter_FW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel_filter_FW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_filter_FW.Controls.Add(this.radio_FW_all);
            this.panel_filter_FW.Controls.Add(this.radio_FW_custom);
            this.panel_filter_FW.Controls.Add(this.radio_FW_standard);
            this.panel_filter_FW.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_filter_FW.HorizontalScrollbarBarColor = true;
            this.panel_filter_FW.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_filter_FW.HorizontalScrollbarSize = 10;
            this.panel_filter_FW.Location = new System.Drawing.Point(0, 55);
            this.panel_filter_FW.Name = "panel_filter_FW";
            this.panel_filter_FW.Size = new System.Drawing.Size(194, 71);
            this.panel_filter_FW.TabIndex = 5;
            this.panel_filter_FW.UseCustomBackColor = true;
            this.panel_filter_FW.VerticalScrollbarBarColor = true;
            this.panel_filter_FW.VerticalScrollbarHighlightOnWheel = false;
            this.panel_filter_FW.VerticalScrollbarSize = 10;
            // 
            // radio_FW_all
            // 
            this.radio_FW_all.AutoSize = true;
            this.radio_FW_all.BackColor = System.Drawing.Color.Transparent;
            this.radio_FW_all.Location = new System.Drawing.Point(3, 5);
            this.radio_FW_all.Name = "radio_FW_all";
            this.radio_FW_all.Size = new System.Drawing.Size(73, 15);
            this.radio_FW_all.Style = MetroFramework.MetroColorStyle.Red;
            this.radio_FW_all.TabIndex = 4;
            this.radio_FW_all.Text = "Tutti i FW";
            this.radio_FW_all.UseCustomBackColor = true;
            this.radio_FW_all.UseSelectable = true;
            this.radio_FW_all.UseStyleColors = true;
            this.radio_FW_all.Click += new System.EventHandler(this.radio_FW_all_Click);
            // 
            // radio_FW_custom
            // 
            this.radio_FW_custom.AutoSize = true;
            this.radio_FW_custom.BackColor = System.Drawing.Color.Transparent;
            this.radio_FW_custom.Location = new System.Drawing.Point(3, 47);
            this.radio_FW_custom.Name = "radio_FW_custom";
            this.radio_FW_custom.Size = new System.Drawing.Size(118, 15);
            this.radio_FW_custom.Style = MetroFramework.MetroColorStyle.Red;
            this.radio_FW_custom.TabIndex = 3;
            this.radio_FW_custom.Text = "FW Personalizzato";
            this.radio_FW_custom.UseCustomBackColor = true;
            this.radio_FW_custom.UseSelectable = true;
            this.radio_FW_custom.UseStyleColors = true;
            this.radio_FW_custom.Click += new System.EventHandler(this.radio_FW_custom_Click);
            // 
            // radio_FW_standard
            // 
            this.radio_FW_standard.AutoSize = true;
            this.radio_FW_standard.BackColor = System.Drawing.Color.Transparent;
            this.radio_FW_standard.Location = new System.Drawing.Point(3, 26);
            this.radio_FW_standard.Name = "radio_FW_standard";
            this.radio_FW_standard.Size = new System.Drawing.Size(90, 15);
            this.radio_FW_standard.Style = MetroFramework.MetroColorStyle.Red;
            this.radio_FW_standard.TabIndex = 2;
            this.radio_FW_standard.Text = "FW Standard";
            this.radio_FW_standard.UseCustomBackColor = true;
            this.radio_FW_standard.UseSelectable = true;
            this.radio_FW_standard.UseStyleColors = true;
            this.radio_FW_standard.Click += new System.EventHandler(this.radio_FW_standard_Click);
            // 
            // panel_filter_cli
            // 
            this.panel_filter_cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel_filter_cli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_filter_cli.Controls.Add(this.cb_Cliente);
            this.panel_filter_cli.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_filter_cli.HorizontalScrollbarBarColor = true;
            this.panel_filter_cli.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_filter_cli.HorizontalScrollbarSize = 10;
            this.panel_filter_cli.Location = new System.Drawing.Point(0, 30);
            this.panel_filter_cli.Name = "panel_filter_cli";
            this.panel_filter_cli.Size = new System.Drawing.Size(194, 25);
            this.panel_filter_cli.TabIndex = 6;
            this.panel_filter_cli.UseCustomBackColor = true;
            this.panel_filter_cli.VerticalScrollbarBarColor = true;
            this.panel_filter_cli.VerticalScrollbarHighlightOnWheel = false;
            this.panel_filter_cli.VerticalScrollbarSize = 10;
            // 
            // cb_Cliente
            // 
            this.cb_Cliente.DataSource = this.tabSiglacliBindingSource;
            this.cb_Cliente.DisplayMember = "Tab_Des";
            this.cb_Cliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_Cliente.FormattingEnabled = true;
            this.cb_Cliente.Location = new System.Drawing.Point(0, 0);
            this.cb_Cliente.Name = "cb_Cliente";
            this.cb_Cliente.Size = new System.Drawing.Size(192, 21);
            this.cb_Cliente.TabIndex = 2;
            // 
            // tabSiglacliBindingSource
            // 
            this.tabSiglacliBindingSource.DataMember = "Tab_Siglacli";
            this.tabSiglacliBindingSource.DataSource = this.ds_SL;
            this.tabSiglacliBindingSource.Sort = "Tab_Des asc";
            this.tabSiglacliBindingSource.CurrentChanged += new System.EventHandler(this.tabSiglacliBindingSource_CurrentChanged);
            // 
            // panel_search
            // 
            this.panel_search.BackColor = System.Drawing.Color.Transparent;
            this.panel_search.Controls.Add(this.tb_search);
            this.panel_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_search.HorizontalScrollbarBarColor = true;
            this.panel_search.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_search.HorizontalScrollbarSize = 10;
            this.panel_search.Location = new System.Drawing.Point(0, 0);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(194, 30);
            this.panel_search.TabIndex = 3;
            this.panel_search.UseCustomBackColor = true;
            this.panel_search.VerticalScrollbarBarColor = true;
            this.panel_search.VerticalScrollbarHighlightOnWheel = false;
            this.panel_search.VerticalScrollbarSize = 10;
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.LightYellow;
            // 
            // 
            // 
            this.tb_search.CustomButton.Image = null;
            this.tb_search.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.tb_search.CustomButton.Name = "";
            this.tb_search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_search.CustomButton.TabIndex = 1;
            this.tb_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_search.CustomButton.UseSelectable = true;
            this.tb_search.CustomButton.Visible = false;
            this.tb_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_search.Icon = global::SmartLineProduction.Properties.Resources.Lente;
            this.tb_search.IconRight = true;
            this.tb_search.Lines = new string[] {
        "metroTextBox1"};
            this.tb_search.Location = new System.Drawing.Point(0, 0);
            this.tb_search.MaxLength = 32767;
            this.tb_search.Name = "tb_search";
            this.tb_search.PasswordChar = '\0';
            this.tb_search.PromptText = "ricerca";
            this.tb_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_search.SelectedText = "";
            this.tb_search.SelectionLength = 0;
            this.tb_search.SelectionStart = 0;
            this.tb_search.ShortcutsEnabled = true;
            this.tb_search.Size = new System.Drawing.Size(194, 23);
            this.tb_search.TabIndex = 2;
            this.tb_search.Text = "metroTextBox1";
            this.tb_search.UseCustomBackColor = true;
            this.tb_search.UseSelectable = true;
            this.tb_search.WaterMark = "ricerca";
            this.tb_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_search.TextChanged += new System.EventHandler(this.tb_grid_kit_TextChanged);
            // 
            // panel_des_art_Kit
            // 
            this.layout_Schede.SetColumnSpan(this.panel_des_art_Kit, 2);
            this.panel_des_art_Kit.Controls.Add(this.tableLayoutPanel1);
            this.panel_des_art_Kit.Controls.Add(this.lab_des1_articolo);
            this.panel_des_art_Kit.Controls.Add(this.lab_des2_articolo);
            this.panel_des_art_Kit.Controls.Add(this.metroLabel1);
            this.panel_des_art_Kit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_des_art_Kit.HorizontalScrollbarBarColor = true;
            this.panel_des_art_Kit.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_des_art_Kit.HorizontalScrollbarSize = 10;
            this.panel_des_art_Kit.Location = new System.Drawing.Point(203, 3);
            this.panel_des_art_Kit.Name = "panel_des_art_Kit";
            this.panel_des_art_Kit.Size = new System.Drawing.Size(954, 44);
            this.panel_des_art_Kit.TabIndex = 1;
            this.panel_des_art_Kit.VerticalScrollbarBarColor = true;
            this.panel_des_art_Kit.VerticalScrollbarHighlightOnWheel = false;
            this.panel_des_art_Kit.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.but_implosion, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(754, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 44);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // but_implosion
            // 
            this.but_implosion.BackColor = System.Drawing.Color.Azure;
            this.but_implosion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_implosion.Location = new System.Drawing.Point(3, 12);
            this.but_implosion.Name = "but_implosion";
            this.but_implosion.Size = new System.Drawing.Size(194, 19);
            this.but_implosion.Style = MetroFramework.MetroColorStyle.Red;
            this.but_implosion.TabIndex = 5;
            this.but_implosion.Text = "Implosione";
            this.but_implosion.UseCustomBackColor = true;
            this.but_implosion.UseSelectable = true;
            this.but_implosion.Click += new System.EventHandler(this.but_implosion_Click);
            // 
            // lab_des1_articolo
            // 
            this.lab_des1_articolo.AutoSize = true;
            this.lab_des1_articolo.Location = new System.Drawing.Point(93, 0);
            this.lab_des1_articolo.Name = "lab_des1_articolo";
            this.lab_des1_articolo.Size = new System.Drawing.Size(41, 19);
            this.lab_des1_articolo.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_des1_articolo.TabIndex = 3;
            this.lab_des1_articolo.Text = "Des_1";
            this.lab_des1_articolo.UseStyleColors = true;
            // 
            // lab_des2_articolo
            // 
            this.lab_des2_articolo.AutoSize = true;
            this.lab_des2_articolo.Location = new System.Drawing.Point(93, 19);
            this.lab_des2_articolo.Name = "lab_des2_articolo";
            this.lab_des2_articolo.Size = new System.Drawing.Size(43, 19);
            this.lab_des2_articolo.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_des2_articolo.TabIndex = 4;
            this.lab_des2_articolo.Text = "Des_2";
            this.lab_des2_articolo.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Descrizione";
            // 
            // panel_pdf_it
            // 
            this.panel_pdf_it.Controls.Add(this.Schede_pdf);
            this.panel_pdf_it.Controls.Add(this.barDockControlLeft);
            this.panel_pdf_it.Controls.Add(this.barDockControlRight);
            this.panel_pdf_it.Controls.Add(this.barDockControlBottom);
            this.panel_pdf_it.Controls.Add(this.barDockControlTop);
            this.panel_pdf_it.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_pdf_it.HorizontalScrollbarBarColor = true;
            this.panel_pdf_it.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_pdf_it.HorizontalScrollbarSize = 10;
            this.panel_pdf_it.Location = new System.Drawing.Point(203, 53);
            this.panel_pdf_it.Name = "panel_pdf_it";
            this.panel_pdf_it.Size = new System.Drawing.Size(474, 339);
            this.panel_pdf_it.TabIndex = 84;
            this.panel_pdf_it.VerticalScrollbarBarColor = true;
            this.panel_pdf_it.VerticalScrollbarHighlightOnWheel = false;
            this.panel_pdf_it.VerticalScrollbarSize = 10;
            // 
            // Schede_pdf
            // 
            this.Schede_pdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Schede_pdf.Location = new System.Drawing.Point(0, 24);
            this.Schede_pdf.MenuManager = this.barManager1;
            this.Schede_pdf.Name = "Schede_pdf";
            this.Schede_pdf.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
            this.Schede_pdf.Size = new System.Drawing.Size(474, 315);
            this.Schede_pdf.TabIndex = 2;
            this.Schede_pdf.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.PageLevel;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.pdfCommandBar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this.panel_pdf_it;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.pdfFileOpenBarItem1,
            this.pdfFileSaveAsBarItem1,
            this.pdfFilePrintBarItem1,
            this.pdfFindTextBarItem1,
            this.pdfPreviousPageBarItem1,
            this.pdfNextPageBarItem1,
            this.pdfSetPageNumberBarItem1,
            this.pdfZoomOutBarItem1,
            this.pdfZoomInBarItem1,
            this.pdfExactZoomListBarSubItem1,
            this.pdfZoom10CheckItem1,
            this.pdfZoom25CheckItem1,
            this.pdfZoom50CheckItem1,
            this.pdfZoom75CheckItem1,
            this.pdfZoom100CheckItem1,
            this.pdfZoom125CheckItem1,
            this.pdfZoom150CheckItem1,
            this.pdfZoom200CheckItem1,
            this.pdfZoom400CheckItem1,
            this.pdfZoom500CheckItem1,
            this.pdfSetActualSizeZoomModeCheckItem1,
            this.pdfSetPageLevelZoomModeCheckItem1,
            this.pdfSetFitWidthZoomModeCheckItem1,
            this.pdfSetFitVisibleZoomModeCheckItem1,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 25;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPageNumberEdit1});
            // 
            // pdfCommandBar1
            // 
            this.pdfCommandBar1.Control = this.Schede_pdf;
            this.pdfCommandBar1.DockCol = 0;
            this.pdfCommandBar1.DockRow = 0;
            this.pdfCommandBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.pdfCommandBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfFileSaveAsBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfFilePrintBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfFindTextBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfPreviousPageBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfNextPageBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetPageNumberBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoomOutBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoomInBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfExactZoomListBarSubItem1)});
            // 
            // pdfFileSaveAsBarItem1
            // 
            this.pdfFileSaveAsBarItem1.Id = 0;
            this.pdfFileSaveAsBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.pdfFileSaveAsBarItem1.Name = "pdfFileSaveAsBarItem1";
            // 
            // pdfFilePrintBarItem1
            // 
            this.pdfFilePrintBarItem1.Id = 1;
            this.pdfFilePrintBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.pdfFilePrintBarItem1.Name = "pdfFilePrintBarItem1";
            // 
            // pdfFindTextBarItem1
            // 
            this.pdfFindTextBarItem1.Id = 2;
            this.pdfFindTextBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.pdfFindTextBarItem1.Name = "pdfFindTextBarItem1";
            // 
            // pdfPreviousPageBarItem1
            // 
            this.pdfPreviousPageBarItem1.Id = 3;
            this.pdfPreviousPageBarItem1.Name = "pdfPreviousPageBarItem1";
            // 
            // pdfNextPageBarItem1
            // 
            this.pdfNextPageBarItem1.Id = 4;
            this.pdfNextPageBarItem1.Name = "pdfNextPageBarItem1";
            // 
            // pdfSetPageNumberBarItem1
            // 
            this.pdfSetPageNumberBarItem1.Edit = this.repositoryItemPageNumberEdit1;
            this.pdfSetPageNumberBarItem1.EditValue = 0;
            this.pdfSetPageNumberBarItem1.Enabled = false;
            this.pdfSetPageNumberBarItem1.Id = 5;
            this.pdfSetPageNumberBarItem1.Name = "pdfSetPageNumberBarItem1";
            // 
            // repositoryItemPageNumberEdit1
            // 
            this.repositoryItemPageNumberEdit1.AutoHeight = false;
            this.repositoryItemPageNumberEdit1.Mask.EditMask = "########;";
            this.repositoryItemPageNumberEdit1.Name = "repositoryItemPageNumberEdit1";
            this.repositoryItemPageNumberEdit1.Orientation = DevExpress.XtraEditors.PagerOrientation.Horizontal;
            // 
            // pdfZoomOutBarItem1
            // 
            this.pdfZoomOutBarItem1.Id = 6;
            this.pdfZoomOutBarItem1.Name = "pdfZoomOutBarItem1";
            // 
            // pdfZoomInBarItem1
            // 
            this.pdfZoomInBarItem1.Id = 7;
            this.pdfZoomInBarItem1.Name = "pdfZoomInBarItem1";
            // 
            // pdfExactZoomListBarSubItem1
            // 
            this.pdfExactZoomListBarSubItem1.Id = 8;
            this.pdfExactZoomListBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom10CheckItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom25CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom50CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom75CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom100CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom125CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom150CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom200CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom400CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom500CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetActualSizeZoomModeCheckItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetPageLevelZoomModeCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetFitWidthZoomModeCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetFitVisibleZoomModeCheckItem1)});
            this.pdfExactZoomListBarSubItem1.Name = "pdfExactZoomListBarSubItem1";
            this.pdfExactZoomListBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // pdfZoom10CheckItem1
            // 
            this.pdfZoom10CheckItem1.Id = 9;
            this.pdfZoom10CheckItem1.Name = "pdfZoom10CheckItem1";
            // 
            // pdfZoom25CheckItem1
            // 
            this.pdfZoom25CheckItem1.Id = 10;
            this.pdfZoom25CheckItem1.Name = "pdfZoom25CheckItem1";
            // 
            // pdfZoom50CheckItem1
            // 
            this.pdfZoom50CheckItem1.Id = 11;
            this.pdfZoom50CheckItem1.Name = "pdfZoom50CheckItem1";
            // 
            // pdfZoom75CheckItem1
            // 
            this.pdfZoom75CheckItem1.Id = 12;
            this.pdfZoom75CheckItem1.Name = "pdfZoom75CheckItem1";
            // 
            // pdfZoom100CheckItem1
            // 
            this.pdfZoom100CheckItem1.Id = 13;
            this.pdfZoom100CheckItem1.Name = "pdfZoom100CheckItem1";
            // 
            // pdfZoom125CheckItem1
            // 
            this.pdfZoom125CheckItem1.Id = 14;
            this.pdfZoom125CheckItem1.Name = "pdfZoom125CheckItem1";
            // 
            // pdfZoom150CheckItem1
            // 
            this.pdfZoom150CheckItem1.Id = 15;
            this.pdfZoom150CheckItem1.Name = "pdfZoom150CheckItem1";
            // 
            // pdfZoom200CheckItem1
            // 
            this.pdfZoom200CheckItem1.Id = 16;
            this.pdfZoom200CheckItem1.Name = "pdfZoom200CheckItem1";
            // 
            // pdfZoom400CheckItem1
            // 
            this.pdfZoom400CheckItem1.Id = 17;
            this.pdfZoom400CheckItem1.Name = "pdfZoom400CheckItem1";
            // 
            // pdfZoom500CheckItem1
            // 
            this.pdfZoom500CheckItem1.Id = 18;
            this.pdfZoom500CheckItem1.Name = "pdfZoom500CheckItem1";
            // 
            // pdfSetActualSizeZoomModeCheckItem1
            // 
            this.pdfSetActualSizeZoomModeCheckItem1.Id = 19;
            this.pdfSetActualSizeZoomModeCheckItem1.Name = "pdfSetActualSizeZoomModeCheckItem1";
            // 
            // pdfSetPageLevelZoomModeCheckItem1
            // 
            this.pdfSetPageLevelZoomModeCheckItem1.Id = 20;
            this.pdfSetPageLevelZoomModeCheckItem1.Name = "pdfSetPageLevelZoomModeCheckItem1";
            // 
            // pdfSetFitWidthZoomModeCheckItem1
            // 
            this.pdfSetFitWidthZoomModeCheckItem1.Id = 21;
            this.pdfSetFitWidthZoomModeCheckItem1.Name = "pdfSetFitWidthZoomModeCheckItem1";
            // 
            // pdfSetFitVisibleZoomModeCheckItem1
            // 
            this.pdfSetFitVisibleZoomModeCheckItem1.Id = 22;
            this.pdfSetFitVisibleZoomModeCheckItem1.Name = "pdfSetFitVisibleZoomModeCheckItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(474, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 339);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(474, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 315);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(474, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 315);
            // 
            // pdfFileOpenBarItem1
            // 
            this.pdfFileOpenBarItem1.Id = 23;
            this.pdfFileOpenBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.pdfFileOpenBarItem1.Name = "pdfFileOpenBarItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 24;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panel_language
            // 
            this.panel_language.Controls.Add(this.but_pdf_eng);
            this.panel_language.Controls.Add(this.but_pdf_ita);
            this.panel_language.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_language.HorizontalScrollbarBarColor = true;
            this.panel_language.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_language.HorizontalScrollbarSize = 10;
            this.panel_language.Location = new System.Drawing.Point(683, 53);
            this.panel_language.Name = "panel_language";
            this.panel_language.Size = new System.Drawing.Size(474, 339);
            this.panel_language.TabIndex = 85;
            this.panel_language.VerticalScrollbarBarColor = true;
            this.panel_language.VerticalScrollbarHighlightOnWheel = false;
            this.panel_language.VerticalScrollbarSize = 10;
            // 
            // but_pdf_eng
            // 
            this.but_pdf_eng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_pdf_eng.Image = global::SmartLineProduction.Properties.Resources.PDF_Flags_UK;
            this.but_pdf_eng.Location = new System.Drawing.Point(200, 20);
            this.but_pdf_eng.Name = "but_pdf_eng";
            this.but_pdf_eng.Size = new System.Drawing.Size(150, 100);
            this.but_pdf_eng.TabIndex = 5;
            this.but_pdf_eng.Text = "Visualizza PDF in Inglese";
            this.but_pdf_eng.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_pdf_eng.UseVisualStyleBackColor = true;
            this.but_pdf_eng.Click += new System.EventHandler(this.but_pdf_eng_Click);
            // 
            // but_pdf_ita
            // 
            this.but_pdf_ita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_pdf_ita.Image = global::SmartLineProduction.Properties.Resources.PDF_Flags_IT;
            this.but_pdf_ita.Location = new System.Drawing.Point(20, 20);
            this.but_pdf_ita.Name = "but_pdf_ita";
            this.but_pdf_ita.Size = new System.Drawing.Size(150, 100);
            this.but_pdf_ita.TabIndex = 4;
            this.but_pdf_ita.Text = "Visualizza PDF in Italiano";
            this.but_pdf_ita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_pdf_ita.UseVisualStyleBackColor = true;
            this.but_pdf_ita.Click += new System.EventHandler(this.but_pdf_ita_Click);
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
            this.layout_orizz_menu.Size = new System.Drawing.Size(1160, 25);
            this.layout_orizz_menu.TabIndex = 123;
            // 
            // pan_Menu_exit
            // 
            this.pan_Menu_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_Menu_exit.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_Menu_exit.Dock = System.Windows.Forms.DockStyle.None;
            this.pan_Menu_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sw_exit});
            this.pan_Menu_exit.Location = new System.Drawing.Point(1085, 0);
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
            // layout_tabbed_pages
            // 
            this.layout_tabbed_pages.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.layout_tabbed_pages.ColumnCount = 6;
            this.layout_tabbed_pages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layout_tabbed_pages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layout_tabbed_pages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layout_tabbed_pages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layout_tabbed_pages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layout_tabbed_pages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.layout_tabbed_pages.Controls.Add(this.btn_Kit, 0, 0);
            this.layout_tabbed_pages.Controls.Add(this.btn_Palmari, 1, 0);
            this.layout_tabbed_pages.Controls.Add(this.btn_Ricevitori, 2, 0);
            this.layout_tabbed_pages.Controls.Add(this.btn_Cablaggi, 3, 0);
            this.layout_tabbed_pages.Controls.Add(this.btn_FW_P, 4, 0);
            this.layout_tabbed_pages.Controls.Add(this.btn_FW_R, 5, 0);
            this.layout_tabbed_pages.Dock = System.Windows.Forms.DockStyle.Top;
            this.layout_tabbed_pages.Location = new System.Drawing.Point(20, 55);
            this.layout_tabbed_pages.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.layout_tabbed_pages.Name = "layout_tabbed_pages";
            this.layout_tabbed_pages.RowCount = 1;
            this.layout_tabbed_pages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_tabbed_pages.Size = new System.Drawing.Size(1160, 30);
            this.layout_tabbed_pages.TabIndex = 124;
            // 
            // btn_Kit
            // 
            this.btn_Kit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Kit.BackColor = System.Drawing.Color.White;
            this.btn_Kit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Kit.Location = new System.Drawing.Point(5, 5);
            this.btn_Kit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Kit.Name = "btn_Kit";
            this.btn_Kit.Size = new System.Drawing.Size(183, 20);
            this.btn_Kit.TabIndex = 6;
            this.btn_Kit.Text = "Kit";
            this.btn_Kit.UseCustomBackColor = true;
            this.btn_Kit.UseSelectable = true;
            this.btn_Kit.Click += new System.EventHandler(this.btn_Kit_Click);
            // 
            // btn_Palmari
            // 
            this.btn_Palmari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Palmari.BackColor = System.Drawing.Color.White;
            this.btn_Palmari.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Palmari.Location = new System.Drawing.Point(198, 5);
            this.btn_Palmari.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Palmari.Name = "btn_Palmari";
            this.btn_Palmari.Size = new System.Drawing.Size(183, 20);
            this.btn_Palmari.TabIndex = 7;
            this.btn_Palmari.Text = "Palmari";
            this.btn_Palmari.UseCustomBackColor = true;
            this.btn_Palmari.UseSelectable = true;
            this.btn_Palmari.Click += new System.EventHandler(this.btn_Palmari_Click);
            // 
            // btn_Ricevitori
            // 
            this.btn_Ricevitori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ricevitori.BackColor = System.Drawing.Color.White;
            this.btn_Ricevitori.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Ricevitori.Location = new System.Drawing.Point(391, 5);
            this.btn_Ricevitori.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Ricevitori.Name = "btn_Ricevitori";
            this.btn_Ricevitori.Size = new System.Drawing.Size(183, 20);
            this.btn_Ricevitori.TabIndex = 8;
            this.btn_Ricevitori.Text = "Ricevitori";
            this.btn_Ricevitori.UseCustomBackColor = true;
            this.btn_Ricevitori.UseSelectable = true;
            this.btn_Ricevitori.Click += new System.EventHandler(this.btn_Ricevitori_Click);
            // 
            // btn_Cablaggi
            // 
            this.btn_Cablaggi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cablaggi.BackColor = System.Drawing.Color.White;
            this.btn_Cablaggi.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Cablaggi.Location = new System.Drawing.Point(584, 5);
            this.btn_Cablaggi.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Cablaggi.Name = "btn_Cablaggi";
            this.btn_Cablaggi.Size = new System.Drawing.Size(183, 20);
            this.btn_Cablaggi.TabIndex = 9;
            this.btn_Cablaggi.Text = "Cablaggi";
            this.btn_Cablaggi.UseCustomBackColor = true;
            this.btn_Cablaggi.UseSelectable = true;
            this.btn_Cablaggi.Click += new System.EventHandler(this.btn_Cablaggi_Click);
            // 
            // btn_FW_P
            // 
            this.btn_FW_P.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FW_P.BackColor = System.Drawing.Color.White;
            this.btn_FW_P.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_FW_P.Location = new System.Drawing.Point(777, 5);
            this.btn_FW_P.Margin = new System.Windows.Forms.Padding(5);
            this.btn_FW_P.Name = "btn_FW_P";
            this.btn_FW_P.Size = new System.Drawing.Size(183, 20);
            this.btn_FW_P.TabIndex = 10;
            this.btn_FW_P.Text = "Firmware Palmari";
            this.btn_FW_P.UseCustomBackColor = true;
            this.btn_FW_P.UseSelectable = true;
            this.btn_FW_P.Click += new System.EventHandler(this.btn_FW_P_Click);
            // 
            // btn_FW_R
            // 
            this.btn_FW_R.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FW_R.BackColor = System.Drawing.Color.White;
            this.btn_FW_R.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_FW_R.Location = new System.Drawing.Point(970, 5);
            this.btn_FW_R.Margin = new System.Windows.Forms.Padding(5);
            this.btn_FW_R.Name = "btn_FW_R";
            this.btn_FW_R.Size = new System.Drawing.Size(185, 20);
            this.btn_FW_R.TabIndex = 11;
            this.btn_FW_R.Text = "Firmware Ricevitori";
            this.btn_FW_R.UseCustomBackColor = true;
            this.btn_FW_R.UseSelectable = true;
            this.btn_FW_R.Click += new System.EventHandler(this.btn_FW_R_Click);
            // 
            // sFDistinteBasiSchedeBindingSource
            // 
            this.sFDistinteBasiSchedeBindingSource.DataMember = "SF_DistinteBasi_Schede";
            this.sFDistinteBasiSchedeBindingSource.DataSource = this.ds_SL;
            // 
            // famProdBindingSource
            // 
            this.famProdBindingSource.DataMember = "Fam_Prod";
            this.famProdBindingSource.DataSource = this.ds_SL;
            // 
            // sF_ArticoliSchedeTableAdapter
            // 
            this.sF_ArticoliSchedeTableAdapter.ClearBeforeFill = true;
            // 
            // sF_DistinteBasi_SchedeTableAdapter
            // 
            this.sF_DistinteBasi_SchedeTableAdapter.ClearBeforeFill = true;
            // 
            // fam_ProdTableAdapter
            // 
            this.fam_ProdTableAdapter.ClearBeforeFill = true;
            // 
            // sFArticoliToXSWRSchedeBindingSource
            // 
            this.sFArticoliToXSWRSchedeBindingSource.DataMember = "SF_ArticoliToXSWR_Schede";
            this.sFArticoliToXSWRSchedeBindingSource.DataSource = this.ds_SL;
            // 
            // sF_ArticoliToXSWR_SchedeTableAdapter
            // 
            this.sF_ArticoliToXSWR_SchedeTableAdapter.ClearBeforeFill = true;
            // 
            // sF_ArticoliTableAdapter
            // 
            this.sF_ArticoliTableAdapter.ClearBeforeFill = true;
            // 
            // tab_SiglacliTableAdapter
            // 
            this.tab_SiglacliTableAdapter.ClearBeforeFill = true;
            // 
            // pdfBarController1
            // 
            this.pdfBarController1.BarItems.Add(this.pdfFileOpenBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfFileSaveAsBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfFilePrintBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfFindTextBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfPreviousPageBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfNextPageBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetPageNumberBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoomOutBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoomInBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom10CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom25CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom50CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom75CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom100CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom125CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom150CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom200CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom400CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom500CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetActualSizeZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetPageLevelZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetFitWidthZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetFitVisibleZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfExactZoomListBarSubItem1);
            this.pdfBarController1.Control = this.Schede_pdf;
            // 
            // UC_Schede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartLineProduction.Properties.Resources.PDF_Flags_IT;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1200, 500);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Schede);
            this.Controls.Add(this.layout_tabbed_pages);
            this.Controls.Add(this.layout_orizz_menu);
            this.DisplayHeader = false;
            this.Name = "UC_Schede";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UC_Schede_Load);
            this.panel_Schede.ResumeLayout(false);
            this.layout_Schede.ResumeLayout(false);
            this.panel_grid_Schede.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Schede)).EndInit();
            this.copytoclipboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sFArticoliSchedeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).EndInit();
            this.panel_filter_FW.ResumeLayout(false);
            this.panel_filter_FW.PerformLayout();
            this.panel_filter_cli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabSiglacliBindingSource)).EndInit();
            this.panel_search.ResumeLayout(false);
            this.panel_des_art_Kit.ResumeLayout(false);
            this.panel_des_art_Kit.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_pdf_it.ResumeLayout(false);
            this.panel_pdf_it.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit1)).EndInit();
            this.panel_language.ResumeLayout(false);
            this.layout_orizz_menu.ResumeLayout(false);
            this.layout_orizz_menu.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            this.layout_tabbed_pages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sFDistinteBasiSchedeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.famProdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFArticoliToXSWRSchedeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfBarController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panel_Schede;
        private System.Windows.Forms.TableLayoutPanel layout_Schede;
        private MetroFramework.Controls.MetroPanel panel_grid_Schede;
        private MetroFramework.Controls.MetroGrid gv_Schede;
        private MetroFramework.Controls.MetroPanel panel_search;
        private MetroFramework.Controls.MetroTextBox tb_search;
        private ds_SL ds_SL;
        private System.Windows.Forms.BindingSource sFArticoliSchedeBindingSource;
        private ds_SLTableAdapters.SF_ArticoliSchedeTableAdapter sF_ArticoliSchedeTableAdapter;
        private System.Windows.Forms.BindingSource sFDistinteBasiSchedeBindingSource;
        private ds_SLTableAdapters.SF_DistinteBasi_SchedeTableAdapter sF_DistinteBasi_SchedeTableAdapter;
        private System.Windows.Forms.BindingSource famProdBindingSource;
        private ds_SLTableAdapters.Fam_ProdTableAdapter fam_ProdTableAdapter;
        private System.Windows.Forms.BindingSource sFArticoliToXSWRSchedeBindingSource;
        private ds_SLTableAdapters.SF_ArticoliToXSWR_SchedeTableAdapter sF_ArticoliToXSWR_SchedeTableAdapter;
        private System.Windows.Forms.TableLayoutPanel layout_orizz_menu;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private System.Windows.Forms.TableLayoutPanel layout_tabbed_pages;
        private MetroFramework.Controls.MetroButton btn_Kit;
        private MetroFramework.Controls.MetroButton btn_Ricevitori;
        private MetroFramework.Controls.MetroButton btn_Palmari;
        private MetroFramework.Controls.MetroButton btn_Cablaggi;
        private MetroFramework.Controls.MetroButton btn_FW_P;
        private MetroFramework.Controls.MetroButton btn_FW_R;
        private MetroFramework.Controls.MetroPanel panel_filter_FW;
        private MetroFramework.Controls.MetroRadioButton radio_FW_all;
        private MetroFramework.Controls.MetroRadioButton radio_FW_custom;
        private MetroFramework.Controls.MetroRadioButton radio_FW_standard;
        private MetroFramework.Controls.MetroContextMenu copytoclipboard;
        private System.Windows.Forms.ToolStripMenuItem copiaIlValoreNellaClipboardToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel panel_des_art_Kit;
        private MetroFramework.Controls.MetroLabel lab_des1_articolo;
        private MetroFramework.Controls.MetroLabel lab_des2_articolo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private ds_ProgrammazioneTableAdapters.SF_ArticoliTableAdapter sF_ArticoliTableAdapter;
        private MetroFramework.Controls.MetroPanel panel_filter_cli;
        private System.Windows.Forms.ComboBox cb_Cliente;
        private System.Windows.Forms.BindingSource tabSiglacliBindingSource;
        private ds_SLTableAdapters.Tab_SiglacliTableAdapter tab_SiglacliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Schede_Articolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Schede_SiglaCli_Kit;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Schede_Famiglia;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Schede_Des_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Schede_Des_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Schede_Modello;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton but_implosion;
        private MetroFramework.Controls.MetroPanel panel_pdf_it;
        private DevExpress.XtraPdfViewer.PdfViewer Schede_pdf;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraPdfViewer.Bars.PdfCommandBar pdfCommandBar1;
        private DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem pdfFileSaveAsBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem pdfFilePrintBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem pdfFindTextBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem pdfPreviousPageBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem pdfNextPageBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem pdfSetPageNumberBarItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit repositoryItemPageNumberEdit1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem pdfZoomOutBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem pdfZoomInBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem pdfExactZoomListBarSubItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem pdfZoom10CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem pdfZoom25CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem pdfZoom50CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem pdfZoom75CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem pdfZoom100CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem pdfZoom125CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem pdfZoom150CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem pdfZoom200CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem pdfZoom400CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem pdfZoom500CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem pdfSetActualSizeZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem pdfSetPageLevelZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem pdfSetFitWidthZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem pdfSetFitVisibleZoomModeCheckItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem pdfFileOpenBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfBarController pdfBarController1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private MetroFramework.Controls.MetroPanel panel_language;
        private System.Windows.Forms.Button but_pdf_ita;
        private System.Windows.Forms.Button but_pdf_eng;
    }
}
