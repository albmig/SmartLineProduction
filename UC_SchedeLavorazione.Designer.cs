namespace SmartLineProduction
{
    partial class UC_SchedeLavorazione
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SchedeLavorazione));
            this.panel_tipo_slv = new MetroFramework.Controls.MetroPanel();
            this.layout_filtro_XSLV = new System.Windows.Forms.TableLayoutPanel();
            this.lab_tog_slv_Std = new MetroFramework.Controls.MetroLabel();
            this.lab_tog_slv_Spec = new MetroFramework.Controls.MetroLabel();
            this.tog_Slv = new DevExpress.XtraEditors.ToggleSwitch();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.pdfCommandBar1 = new DevExpress.XtraPdfViewer.Bars.PdfCommandBar();
            this.pdf_viewer_xslv = new DevExpress.XtraPdfViewer.PdfViewer();
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
            this.pdfFileOpenBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel_pdf_xslv = new MetroFramework.Controls.MetroPanel();
            this.panel_input = new MetroFramework.Controls.MetroPanel();
            this.lab_Etichetta = new MetroFramework.Controls.MetroLabel();
            this.tbx_ReadLabel_Device = new MetroFramework.Controls.MetroTextBox();
            this.but_Reset = new MetroFramework.Controls.MetroButton();
            this.panel_device = new MetroFramework.Controls.MetroPanel();
            this.Device_Image = new System.Windows.Forms.PictureBox();
            this.panel_result = new MetroFramework.Controls.MetroPanel();
            this.gv_result = new MetroFramework.Controls.MetroGrid();
            this.ArticoloComposto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticoloComponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desCompostoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFDbarXSLVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_XSLV = new SmartLineProduction.ds_XSLV();
            this.pdfBarController1 = new DevExpress.XtraPdfViewer.Bars.PdfBarController(this.components);
            this.sF_Dbar_XSLVTableAdapter = new SmartLineProduction.ds_XSLVTableAdapters.SF_Dbar_XSLVTableAdapter();
            this.layout_general = new System.Windows.Forms.TableLayoutPanel();
            this.panel_view = new MetroFramework.Controls.MetroPanel();
            this.layout_orizz_menu = new System.Windows.Forms.TableLayoutPanel();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_tipo_slv.SuspendLayout();
            this.layout_filtro_XSLV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tog_Slv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit1)).BeginInit();
            this.panel_pdf_xslv.SuspendLayout();
            this.panel_input.SuspendLayout();
            this.panel_device.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Device_Image)).BeginInit();
            this.panel_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFDbarXSLVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_XSLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfBarController1)).BeginInit();
            this.layout_general.SuspendLayout();
            this.panel_view.SuspendLayout();
            this.layout_orizz_menu.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_tipo_slv
            // 
            this.panel_tipo_slv.Controls.Add(this.layout_filtro_XSLV);
            this.panel_tipo_slv.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_tipo_slv.HorizontalScrollbarBarColor = true;
            this.panel_tipo_slv.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_tipo_slv.HorizontalScrollbarSize = 10;
            this.panel_tipo_slv.Location = new System.Drawing.Point(0, 60);
            this.panel_tipo_slv.Name = "panel_tipo_slv";
            this.panel_tipo_slv.Size = new System.Drawing.Size(394, 26);
            this.panel_tipo_slv.TabIndex = 7;
            this.panel_tipo_slv.VerticalScrollbarBarColor = true;
            this.panel_tipo_slv.VerticalScrollbarHighlightOnWheel = false;
            this.panel_tipo_slv.VerticalScrollbarSize = 10;
            // 
            // layout_filtro_XSLV
            // 
            this.layout_filtro_XSLV.ColumnCount = 3;
            this.layout_filtro_XSLV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout_filtro_XSLV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout_filtro_XSLV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout_filtro_XSLV.Controls.Add(this.lab_tog_slv_Std, 2, 0);
            this.layout_filtro_XSLV.Controls.Add(this.lab_tog_slv_Spec, 0, 0);
            this.layout_filtro_XSLV.Controls.Add(this.tog_Slv, 1, 0);
            this.layout_filtro_XSLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_filtro_XSLV.Location = new System.Drawing.Point(0, 0);
            this.layout_filtro_XSLV.Name = "layout_filtro_XSLV";
            this.layout_filtro_XSLV.RowCount = 1;
            this.layout_filtro_XSLV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_filtro_XSLV.Size = new System.Drawing.Size(394, 26);
            this.layout_filtro_XSLV.TabIndex = 5;
            // 
            // lab_tog_slv_Std
            // 
            this.lab_tog_slv_Std.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_tog_slv_Std.AutoSize = true;
            this.lab_tog_slv_Std.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_tog_slv_Std.Location = new System.Drawing.Point(265, 3);
            this.lab_tog_slv_Std.Name = "lab_tog_slv_Std";
            this.lab_tog_slv_Std.Size = new System.Drawing.Size(126, 19);
            this.lab_tog_slv_Std.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_tog_slv_Std.TabIndex = 5;
            this.lab_tog_slv_Std.Text = "Standard / Collaudo";
            this.lab_tog_slv_Std.UseStyleColors = true;
            // 
            // lab_tog_slv_Spec
            // 
            this.lab_tog_slv_Spec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_tog_slv_Spec.AutoSize = true;
            this.lab_tog_slv_Spec.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_tog_slv_Spec.Location = new System.Drawing.Point(3, 3);
            this.lab_tog_slv_Spec.Name = "lab_tog_slv_Spec";
            this.lab_tog_slv_Spec.Size = new System.Drawing.Size(53, 19);
            this.lab_tog_slv_Spec.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_tog_slv_Spec.TabIndex = 4;
            this.lab_tog_slv_Spec.Text = "Speciali";
            this.lab_tog_slv_Spec.UseStyleColors = true;
            // 
            // tog_Slv
            // 
            this.tog_Slv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tog_Slv.AutoSizeInLayoutControl = true;
            this.tog_Slv.Location = new System.Drawing.Point(169, 4);
            this.tog_Slv.MenuManager = this.barManager1;
            this.tog_Slv.Name = "tog_Slv";
            this.tog_Slv.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tog_Slv.Properties.Appearance.Options.UseFont = true;
            this.tog_Slv.Properties.Appearance.Options.UseTextOptions = true;
            this.tog_Slv.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tog_Slv.Properties.OffText = "";
            this.tog_Slv.Properties.OnText = "";
            this.tog_Slv.Size = new System.Drawing.Size(55, 20);
            this.tog_Slv.TabIndex = 3;
            this.tog_Slv.Toggled += new System.EventHandler(this.tog_Slv_Toggled);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.pdfCommandBar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this.panel_pdf_xslv;
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
            this.pdfSetFitVisibleZoomModeCheckItem1});
            this.barManager1.MaxItemId = 24;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPageNumberEdit1});
            // 
            // pdfCommandBar1
            // 
            this.pdfCommandBar1.Control = this.pdf_viewer_xslv;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfExactZoomListBarSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfFileOpenBarItem1)});
            // 
            // pdf_viewer_xslv
            // 
            this.pdf_viewer_xslv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdf_viewer_xslv.Location = new System.Drawing.Point(0, 24);
            this.pdf_viewer_xslv.MenuManager = this.barManager1;
            this.pdf_viewer_xslv.Name = "pdf_viewer_xslv";
            this.pdf_viewer_xslv.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
            this.pdf_viewer_xslv.Size = new System.Drawing.Size(596, 931);
            this.pdf_viewer_xslv.TabIndex = 2;
            this.pdf_viewer_xslv.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.PageLevel;
            // 
            // pdfFileSaveAsBarItem1
            // 
            this.pdfFileSaveAsBarItem1.Id = 1;
            this.pdfFileSaveAsBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.pdfFileSaveAsBarItem1.Name = "pdfFileSaveAsBarItem1";
            // 
            // pdfFilePrintBarItem1
            // 
            this.pdfFilePrintBarItem1.Id = 2;
            this.pdfFilePrintBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.pdfFilePrintBarItem1.Name = "pdfFilePrintBarItem1";
            // 
            // pdfFindTextBarItem1
            // 
            this.pdfFindTextBarItem1.Id = 3;
            this.pdfFindTextBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.pdfFindTextBarItem1.Name = "pdfFindTextBarItem1";
            // 
            // pdfPreviousPageBarItem1
            // 
            this.pdfPreviousPageBarItem1.Id = 4;
            this.pdfPreviousPageBarItem1.Name = "pdfPreviousPageBarItem1";
            // 
            // pdfNextPageBarItem1
            // 
            this.pdfNextPageBarItem1.Id = 5;
            this.pdfNextPageBarItem1.Name = "pdfNextPageBarItem1";
            // 
            // pdfSetPageNumberBarItem1
            // 
            this.pdfSetPageNumberBarItem1.Edit = this.repositoryItemPageNumberEdit1;
            this.pdfSetPageNumberBarItem1.EditValue = 0;
            this.pdfSetPageNumberBarItem1.Enabled = false;
            this.pdfSetPageNumberBarItem1.Id = 6;
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
            this.pdfZoomOutBarItem1.Id = 7;
            this.pdfZoomOutBarItem1.Name = "pdfZoomOutBarItem1";
            // 
            // pdfZoomInBarItem1
            // 
            this.pdfZoomInBarItem1.Id = 8;
            this.pdfZoomInBarItem1.Name = "pdfZoomInBarItem1";
            // 
            // pdfExactZoomListBarSubItem1
            // 
            this.pdfExactZoomListBarSubItem1.Id = 9;
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
            this.pdfZoom10CheckItem1.Id = 10;
            this.pdfZoom10CheckItem1.Name = "pdfZoom10CheckItem1";
            // 
            // pdfZoom25CheckItem1
            // 
            this.pdfZoom25CheckItem1.Id = 11;
            this.pdfZoom25CheckItem1.Name = "pdfZoom25CheckItem1";
            // 
            // pdfZoom50CheckItem1
            // 
            this.pdfZoom50CheckItem1.Id = 12;
            this.pdfZoom50CheckItem1.Name = "pdfZoom50CheckItem1";
            // 
            // pdfZoom75CheckItem1
            // 
            this.pdfZoom75CheckItem1.Id = 13;
            this.pdfZoom75CheckItem1.Name = "pdfZoom75CheckItem1";
            // 
            // pdfZoom100CheckItem1
            // 
            this.pdfZoom100CheckItem1.Id = 14;
            this.pdfZoom100CheckItem1.Name = "pdfZoom100CheckItem1";
            // 
            // pdfZoom125CheckItem1
            // 
            this.pdfZoom125CheckItem1.Id = 15;
            this.pdfZoom125CheckItem1.Name = "pdfZoom125CheckItem1";
            // 
            // pdfZoom150CheckItem1
            // 
            this.pdfZoom150CheckItem1.Id = 16;
            this.pdfZoom150CheckItem1.Name = "pdfZoom150CheckItem1";
            // 
            // pdfZoom200CheckItem1
            // 
            this.pdfZoom200CheckItem1.Id = 17;
            this.pdfZoom200CheckItem1.Name = "pdfZoom200CheckItem1";
            // 
            // pdfZoom400CheckItem1
            // 
            this.pdfZoom400CheckItem1.Id = 18;
            this.pdfZoom400CheckItem1.Name = "pdfZoom400CheckItem1";
            // 
            // pdfZoom500CheckItem1
            // 
            this.pdfZoom500CheckItem1.Id = 19;
            this.pdfZoom500CheckItem1.Name = "pdfZoom500CheckItem1";
            // 
            // pdfSetActualSizeZoomModeCheckItem1
            // 
            this.pdfSetActualSizeZoomModeCheckItem1.Id = 20;
            this.pdfSetActualSizeZoomModeCheckItem1.Name = "pdfSetActualSizeZoomModeCheckItem1";
            // 
            // pdfSetPageLevelZoomModeCheckItem1
            // 
            this.pdfSetPageLevelZoomModeCheckItem1.Id = 21;
            this.pdfSetPageLevelZoomModeCheckItem1.Name = "pdfSetPageLevelZoomModeCheckItem1";
            // 
            // pdfSetFitWidthZoomModeCheckItem1
            // 
            this.pdfSetFitWidthZoomModeCheckItem1.Id = 22;
            this.pdfSetFitWidthZoomModeCheckItem1.Name = "pdfSetFitWidthZoomModeCheckItem1";
            // 
            // pdfSetFitVisibleZoomModeCheckItem1
            // 
            this.pdfSetFitVisibleZoomModeCheckItem1.Id = 23;
            this.pdfSetFitVisibleZoomModeCheckItem1.Name = "pdfSetFitVisibleZoomModeCheckItem1";
            // 
            // pdfFileOpenBarItem1
            // 
            this.pdfFileOpenBarItem1.Id = 0;
            this.pdfFileOpenBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.pdfFileOpenBarItem1.Name = "pdfFileOpenBarItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(596, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 955);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(596, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 931);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(596, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 931);
            // 
            // panel_pdf_xslv
            // 
            this.panel_pdf_xslv.Controls.Add(this.pdf_viewer_xslv);
            this.panel_pdf_xslv.Controls.Add(this.barDockControlLeft);
            this.panel_pdf_xslv.Controls.Add(this.barDockControlRight);
            this.panel_pdf_xslv.Controls.Add(this.barDockControlBottom);
            this.panel_pdf_xslv.Controls.Add(this.barDockControlTop);
            this.panel_pdf_xslv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_pdf_xslv.HorizontalScrollbarBarColor = true;
            this.panel_pdf_xslv.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_pdf_xslv.HorizontalScrollbarSize = 10;
            this.panel_pdf_xslv.Location = new System.Drawing.Point(403, 3);
            this.panel_pdf_xslv.Name = "panel_pdf_xslv";
            this.panel_pdf_xslv.Size = new System.Drawing.Size(596, 955);
            this.panel_pdf_xslv.TabIndex = 4;
            this.panel_pdf_xslv.VerticalScrollbarBarColor = true;
            this.panel_pdf_xslv.VerticalScrollbarHighlightOnWheel = false;
            this.panel_pdf_xslv.VerticalScrollbarSize = 10;
            // 
            // panel_input
            // 
            this.panel_input.Controls.Add(this.lab_Etichetta);
            this.panel_input.Controls.Add(this.tbx_ReadLabel_Device);
            this.panel_input.Controls.Add(this.but_Reset);
            this.panel_input.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_input.HorizontalScrollbarBarColor = true;
            this.panel_input.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_input.HorizontalScrollbarSize = 10;
            this.panel_input.Location = new System.Drawing.Point(0, 0);
            this.panel_input.Name = "panel_input";
            this.panel_input.Size = new System.Drawing.Size(394, 60);
            this.panel_input.TabIndex = 3;
            this.panel_input.VerticalScrollbarBarColor = true;
            this.panel_input.VerticalScrollbarHighlightOnWheel = false;
            this.panel_input.VerticalScrollbarSize = 10;
            // 
            // lab_Etichetta
            // 
            this.lab_Etichetta.AutoSize = true;
            this.lab_Etichetta.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_Etichetta.Location = new System.Drawing.Point(0, 0);
            this.lab_Etichetta.Name = "lab_Etichetta";
            this.lab_Etichetta.Size = new System.Drawing.Size(257, 19);
            this.lab_Etichetta.TabIndex = 0;
            this.lab_Etichetta.Text = "Lettura dell\'etichetta presente sul device:";
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
            this.tbx_ReadLabel_Device.PromptText = "Lettura del QR-Code";
            this.tbx_ReadLabel_Device.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbx_ReadLabel_Device.SelectedText = "";
            this.tbx_ReadLabel_Device.SelectionLength = 0;
            this.tbx_ReadLabel_Device.SelectionStart = 0;
            this.tbx_ReadLabel_Device.ShortcutsEnabled = true;
            this.tbx_ReadLabel_Device.Size = new System.Drawing.Size(276, 23);
            this.tbx_ReadLabel_Device.TabIndex = 0;
            this.tbx_ReadLabel_Device.UseSelectable = true;
            this.tbx_ReadLabel_Device.WaterMark = "Lettura del QR-Code";
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
            // panel_device
            // 
            this.panel_device.Controls.Add(this.Device_Image);
            this.panel_device.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_device.HorizontalScrollbarBarColor = true;
            this.panel_device.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_device.HorizontalScrollbarSize = 10;
            this.panel_device.Location = new System.Drawing.Point(0, 286);
            this.panel_device.Name = "panel_device";
            this.panel_device.Size = new System.Drawing.Size(394, 669);
            this.panel_device.TabIndex = 6;
            this.panel_device.VerticalScrollbarBarColor = true;
            this.panel_device.VerticalScrollbarHighlightOnWheel = false;
            this.panel_device.VerticalScrollbarSize = 10;
            // 
            // Device_Image
            // 
            this.Device_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Device_Image.ErrorImage = global::SmartLineProduction.Properties.Resources.ImageNotPresent;
            this.Device_Image.InitialImage = null;
            this.Device_Image.Location = new System.Drawing.Point(0, 0);
            this.Device_Image.Margin = new System.Windows.Forms.Padding(33);
            this.Device_Image.Name = "Device_Image";
            this.Device_Image.Size = new System.Drawing.Size(394, 669);
            this.Device_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Device_Image.TabIndex = 2;
            this.Device_Image.TabStop = false;
            // 
            // panel_result
            // 
            this.panel_result.Controls.Add(this.gv_result);
            this.panel_result.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_result.HorizontalScrollbarBarColor = true;
            this.panel_result.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_result.HorizontalScrollbarSize = 10;
            this.panel_result.Location = new System.Drawing.Point(0, 86);
            this.panel_result.Name = "panel_result";
            this.panel_result.Size = new System.Drawing.Size(394, 200);
            this.panel_result.TabIndex = 5;
            this.panel_result.VerticalScrollbarBarColor = true;
            this.panel_result.VerticalScrollbarHighlightOnWheel = false;
            this.panel_result.VerticalScrollbarSize = 10;
            // 
            // gv_result
            // 
            this.gv_result.AllowUserToAddRows = false;
            this.gv_result.AllowUserToDeleteRows = false;
            this.gv_result.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.gv_result.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_result.AutoGenerateColumns = false;
            this.gv_result.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_result.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_result.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_result.ColumnHeadersHeight = 40;
            this.gv_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArticoloComposto,
            this.ArticoloComponente,
            this.desCompostoDataGridViewTextBoxColumn});
            this.gv_result.DataSource = this.sFDbarXSLVBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_result.DefaultCellStyle = dataGridViewCellStyle3;
            this.gv_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_result.EnableHeadersVisualStyles = false;
            this.gv_result.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_result.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_result.Location = new System.Drawing.Point(0, 0);
            this.gv_result.MultiSelect = false;
            this.gv_result.Name = "gv_result";
            this.gv_result.ReadOnly = true;
            this.gv_result.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_result.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_result.RowHeadersVisible = false;
            this.gv_result.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_result.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Wheat;
            this.gv_result.RowTemplate.Height = 30;
            this.gv_result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_result.Size = new System.Drawing.Size(394, 200);
            this.gv_result.Style = MetroFramework.MetroColorStyle.Red;
            this.gv_result.TabIndex = 122;
            this.gv_result.UseStyleColors = true;
            this.gv_result.Visible = false;
            // 
            // ArticoloComposto
            // 
            this.ArticoloComposto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ArticoloComposto.DataPropertyName = "ArticoloComposto";
            this.ArticoloComposto.HeaderText = "ArticoloComposto";
            this.ArticoloComposto.Name = "ArticoloComposto";
            this.ArticoloComposto.ReadOnly = true;
            this.ArticoloComposto.Visible = false;
            this.ArticoloComposto.Width = 123;
            // 
            // ArticoloComponente
            // 
            this.ArticoloComponente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ArticoloComponente.DataPropertyName = "ArticoloComponente";
            this.ArticoloComponente.HeaderText = "Codice Scheda";
            this.ArticoloComponente.Name = "ArticoloComponente";
            this.ArticoloComponente.ReadOnly = true;
            this.ArticoloComponente.Width = 96;
            // 
            // desCompostoDataGridViewTextBoxColumn
            // 
            this.desCompostoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desCompostoDataGridViewTextBoxColumn.DataPropertyName = "Des_Composto";
            this.desCompostoDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.desCompostoDataGridViewTextBoxColumn.Name = "desCompostoDataGridViewTextBoxColumn";
            this.desCompostoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sFDbarXSLVBindingSource
            // 
            this.sFDbarXSLVBindingSource.DataMember = "SF_Dbar_XSLV";
            this.sFDbarXSLVBindingSource.DataSource = this.ds_XSLV;
            this.sFDbarXSLVBindingSource.CurrentChanged += new System.EventHandler(this.sFDbarXSLVBindingSource_CurrentChanged);
            this.sFDbarXSLVBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.sFDbarXSLVBindingSource_ListChanged);
            // 
            // ds_XSLV
            // 
            this.ds_XSLV.DataSetName = "ds_XSLV";
            this.ds_XSLV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.pdfBarController1.Control = this.pdf_viewer_xslv;
            // 
            // sF_Dbar_XSLVTableAdapter
            // 
            this.sF_Dbar_XSLVTableAdapter.ClearBeforeFill = true;
            // 
            // layout_general
            // 
            this.layout_general.ColumnCount = 2;
            this.layout_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layout_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.layout_general.Controls.Add(this.panel_pdf_xslv, 1, 0);
            this.layout_general.Controls.Add(this.panel_view, 0, 0);
            this.layout_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_general.Location = new System.Drawing.Point(20, 55);
            this.layout_general.Name = "layout_general";
            this.layout_general.RowCount = 1;
            this.layout_general.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_general.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 961F));
            this.layout_general.Size = new System.Drawing.Size(1002, 961);
            this.layout_general.TabIndex = 7;
            // 
            // panel_view
            // 
            this.panel_view.Controls.Add(this.panel_device);
            this.panel_view.Controls.Add(this.panel_result);
            this.panel_view.Controls.Add(this.panel_tipo_slv);
            this.panel_view.Controls.Add(this.panel_input);
            this.panel_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_view.HorizontalScrollbarBarColor = true;
            this.panel_view.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_view.HorizontalScrollbarSize = 10;
            this.panel_view.Location = new System.Drawing.Point(3, 3);
            this.panel_view.Name = "panel_view";
            this.panel_view.Size = new System.Drawing.Size(394, 955);
            this.panel_view.TabIndex = 5;
            this.panel_view.VerticalScrollbarBarColor = true;
            this.panel_view.VerticalScrollbarHighlightOnWheel = false;
            this.panel_view.VerticalScrollbarSize = 10;
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
            this.layout_orizz_menu.Size = new System.Drawing.Size(1002, 25);
            this.layout_orizz_menu.TabIndex = 121;
            // 
            // pan_Menu_exit
            // 
            this.pan_Menu_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_Menu_exit.BackColor = System.Drawing.Color.Gainsboro;
            this.pan_Menu_exit.Dock = System.Windows.Forms.DockStyle.None;
            this.pan_Menu_exit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_sw_exit});
            this.pan_Menu_exit.Location = new System.Drawing.Point(927, 0);
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
            // UC_SchedeLavorazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 1036);
            this.ControlBox = false;
            this.Controls.Add(this.layout_general);
            this.Controls.Add(this.layout_orizz_menu);
            this.DisplayHeader = false;
            this.Name = "UC_SchedeLavorazione";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UC_SchedeLavorazione_Load);
            this.Shown += new System.EventHandler(this.UC_SchedeLavorazione_Shown);
            this.panel_tipo_slv.ResumeLayout(false);
            this.layout_filtro_XSLV.ResumeLayout(false);
            this.layout_filtro_XSLV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tog_Slv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit1)).EndInit();
            this.panel_pdf_xslv.ResumeLayout(false);
            this.panel_pdf_xslv.PerformLayout();
            this.panel_input.ResumeLayout(false);
            this.panel_input.PerformLayout();
            this.panel_device.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Device_Image)).EndInit();
            this.panel_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFDbarXSLVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_XSLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfBarController1)).EndInit();
            this.layout_general.ResumeLayout(false);
            this.panel_view.ResumeLayout(false);
            this.layout_orizz_menu.ResumeLayout(false);
            this.layout_orizz_menu.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lab_Etichetta;
        private MetroFramework.Controls.MetroTextBox tbx_ReadLabel_Device;
        private MetroFramework.Controls.MetroButton but_Reset;
        private MetroFramework.Controls.MetroPanel panel_input;
        private MetroFramework.Controls.MetroPanel panel_pdf_xslv;
        private DevExpress.XtraPdfViewer.PdfViewer pdf_viewer_xslv;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraPdfViewer.Bars.PdfCommandBar pdfCommandBar1;
        private DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem pdfFileOpenBarItem1;
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
        private DevExpress.XtraPdfViewer.Bars.PdfBarController pdfBarController1;
        private MetroFramework.Controls.MetroPanel panel_result;
        private MetroFramework.Controls.MetroGrid gv_result;
        private ds_XSLV ds_XSLV;
        private System.Windows.Forms.BindingSource sFDbarXSLVBindingSource;
        private ds_XSLVTableAdapters.SF_Dbar_XSLVTableAdapter sF_Dbar_XSLVTableAdapter;
        private MetroFramework.Controls.MetroPanel panel_device;
        private System.Windows.Forms.PictureBox Device_Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticoloComposto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticoloComponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn desCompostoDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel panel_tipo_slv;
        private DevExpress.XtraEditors.ToggleSwitch tog_Slv;
        private System.Windows.Forms.TableLayoutPanel layout_general;
        private MetroFramework.Controls.MetroPanel panel_view;
        private System.Windows.Forms.TableLayoutPanel layout_orizz_menu;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private MetroFramework.Controls.MetroLabel lab_tog_slv_Spec;
        private System.Windows.Forms.TableLayoutPanel layout_filtro_XSLV;
        private MetroFramework.Controls.MetroLabel lab_tog_slv_Std;
    }
}
