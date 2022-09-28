namespace SmartLineProduction
{
    partial class UC_ReportProdotti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ReportProdotti));
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor3 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor4 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor5 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor6 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor7 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor8 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor9 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            this.layout_orizz_menu = new System.Windows.Forms.TableLayoutPanel();
            this.pan_Menu_exit = new System.Windows.Forms.MenuStrip();
            this.menu_sw_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ds_SL = new SmartLineProduction.ds_SL();
            this.sFParcoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sF_ParcoTableAdapter = new SmartLineProduction.ds_SLTableAdapters.SF_ParcoTableAdapter();
            this.group_Parco = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.layout_orizz_menu.SuspendLayout();
            this.pan_Menu_exit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFParcoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_Parco)).BeginInit();
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
            // ds_SL
            // 
            this.ds_SL.DataSetName = "ds_SL";
            this.ds_SL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sFParcoBindingSource
            // 
            this.sFParcoBindingSource.DataMember = "SF_Parco";
            this.sFParcoBindingSource.DataSource = this.ds_SL;
            // 
            // sF_ParcoTableAdapter
            // 
            this.sF_ParcoTableAdapter.ClearBeforeFill = true;
            // 
            // group_Parco
            // 
            this.group_Parco.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.group_Parco.BackColor = System.Drawing.SystemColors.Window;
            this.group_Parco.CausesValidation = false;
            this.group_Parco.DataMember = null;
            this.group_Parco.DataSource = this.sFParcoBindingSource;
            this.group_Parco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_Parco.EnableAutoSize = true;
            this.group_Parco.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_Parco.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.group_Parco.Location = new System.Drawing.Point(20, 55);
            this.group_Parco.Name = "group_Parco";
            this.group_Parco.NestedTableGroupOptions.ShowGroupHeader = true;
            this.group_Parco.NestedTableGroupOptions.ShowGroupPreview = true;
            this.group_Parco.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.group_Parco.ShowGroupDropArea = true;
            this.group_Parco.ShowRowHeaders = false;
            this.group_Parco.Size = new System.Drawing.Size(839, 351);
            this.group_Parco.TabIndex = 123;
            this.group_Parco.TableDescriptor.AllowEdit = false;
            this.group_Parco.TableDescriptor.AllowNew = false;
            this.group_Parco.TableDescriptor.AllowRemove = false;
            gridColumnDescriptor1.HeaderText = "Kit";
            gridColumnDescriptor1.MappingName = "Ser_Kit";
            gridColumnDescriptor1.Name = "Ser_Kit";
            gridColumnDescriptor2.HeaderText = "Device";
            gridColumnDescriptor2.MappingName = "Ser_Device";
            gridColumnDescriptor3.HeaderText = "Ragione Sociale";
            gridColumnDescriptor3.MappingName = "RAGIONESOCIALE";
            gridColumnDescriptor4.HeaderText = "Official ID";
            gridColumnDescriptor4.MappingName = "Ser_OfficialSerial";
            gridColumnDescriptor5.HeaderText = "FW di battesimo";
            gridColumnDescriptor5.MappingName = "Ser_SW_Code";
            gridColumnDescriptor6.AllowDropDownCell = false;
            gridColumnDescriptor6.HeaderText = "FW Standard";
            gridColumnDescriptor6.MappingName = "Ser_SW_Std_Type";
            gridColumnDescriptor7.HeaderText = "Serial Number";
            gridColumnDescriptor7.MappingName = "Ser_SN_prod";
            gridColumnDescriptor8.HeaderText = "Commessa";
            gridColumnDescriptor8.MappingName = "Ser_Commessa";
            gridColumnDescriptor9.HeaderText = "Data di creazione";
            gridColumnDescriptor9.MappingName = "Ser_Data_Spedito";
            this.group_Parco.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            gridColumnDescriptor1,
            gridColumnDescriptor2,
            gridColumnDescriptor3,
            gridColumnDescriptor4,
            gridColumnDescriptor5,
            gridColumnDescriptor6,
            gridColumnDescriptor7,
            gridColumnDescriptor8,
            gridColumnDescriptor9});
            this.group_Parco.TableDescriptor.Name = "Parco Prodotti";
            this.group_Parco.TableDescriptor.SortedColumns.AddRange(new Syncfusion.Grouping.SortColumnDescriptor[] {
            new Syncfusion.Grouping.SortColumnDescriptor("Ser_Kit", System.ComponentModel.ListSortDirection.Ascending)});
            this.group_Parco.TableDescriptor.TableOptions.CaptionRowHeight = 29;
            this.group_Parco.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.group_Parco.TableDescriptor.TableOptions.RecordRowHeight = 25;
            this.group_Parco.TableOptions.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.group_Parco.TableOptions.SelectionTextColor = System.Drawing.SystemColors.HighlightText;
            this.group_Parco.Text = "gridGroupingControl1";
            this.group_Parco.UseRightToLeftCompatibleTextBox = true;
            this.group_Parco.VersionInfo = "18.2460.0.44";
            // 
            // UC_ReportProdotti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 426);
            this.ControlBox = false;
            this.Controls.Add(this.group_Parco);
            this.Controls.Add(this.layout_orizz_menu);
            this.DisplayHeader = false;
            this.Name = "UC_ReportProdotti";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UC_ReportProdotti_Load);
            this.layout_orizz_menu.ResumeLayout(false);
            this.layout_orizz_menu.PerformLayout();
            this.pan_Menu_exit.ResumeLayout(false);
            this.pan_Menu_exit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFParcoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_Parco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout_orizz_menu;
        private System.Windows.Forms.MenuStrip pan_Menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_sw_exit;
        private ds_SL ds_SL;
        private System.Windows.Forms.BindingSource sFParcoBindingSource;
        private ds_SLTableAdapters.SF_ParcoTableAdapter sF_ParcoTableAdapter;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl group_Parco;
    }
}
