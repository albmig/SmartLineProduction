namespace SmartLineProduction
{
    partial class UC_NCR_Search_Clienti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.but_Confirm = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.group_CF = new DevExpress.XtraEditors.RadioGroup();
            this.gv_result = new MetroFramework.Controls.MetroGrid();
            this.cliForDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOTTOCONTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODICENOMINATIVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNDIRIZZODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEROCIVICODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRAZIONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMUNEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROVINCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZIONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFNcrCliForBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Ncr = new SmartLineProduction.ds_Ncr();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.search_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.sF_Ncr_CliForTableAdapter = new SmartLineProduction.ds_NcrTableAdapters.SF_Ncr_CliForTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_CF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFNcrCliForBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Ncr)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_Confirm
            // 
            this.but_Confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but_Confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.but_Confirm.Location = new System.Drawing.Point(28, 474);
            this.but_Confirm.Name = "but_Confirm";
            this.but_Confirm.Size = new System.Drawing.Size(404, 23);
            this.but_Confirm.TabIndex = 8;
            this.but_Confirm.Text = "Conferma";
            this.but_Confirm.UseSelectable = true;
            this.but_Confirm.Click += new System.EventHandler(this.but_Confirm_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.group_CF, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gv_result, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.but_Confirm, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 520);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // group_CF
            // 
            this.group_CF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_CF.Location = new System.Drawing.Point(3, 3);
            this.group_CF.Name = "group_CF";
            this.group_CF.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Cliente"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("F", "Fornitore")});
            this.group_CF.Size = new System.Drawing.Size(454, 44);
            this.group_CF.TabIndex = 0;
            this.group_CF.SelectedIndexChanged += new System.EventHandler(this.group_CF_SelectedIndexChanged);
            // 
            // gv_result
            // 
            this.gv_result.AllowUserToAddRows = false;
            this.gv_result.AllowUserToDeleteRows = false;
            this.gv_result.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            this.gv_result.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gv_result.AutoGenerateColumns = false;
            this.gv_result.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_result.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_result.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gv_result.ColumnHeadersHeight = 40;
            this.gv_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliForDataGridViewTextBoxColumn,
            this.mastroDataGridViewTextBoxColumn,
            this.contoDataGridViewTextBoxColumn,
            this.sOTTOCONTODataGridViewTextBoxColumn,
            this.cODICENOMINATIVODataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.iNDIRIZZODataGridViewTextBoxColumn,
            this.nUMEROCIVICODataGridViewTextBoxColumn,
            this.fRAZIONEDataGridViewTextBoxColumn,
            this.cAPDataGridViewTextBoxColumn,
            this.cOMUNEDataGridViewTextBoxColumn,
            this.pROVINCIADataGridViewTextBoxColumn,
            this.nAZIONEDataGridViewTextBoxColumn});
            this.gv_result.DataSource = this.sFNcrCliForBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_result.DefaultCellStyle = dataGridViewCellStyle7;
            this.gv_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_result.EnableHeadersVisualStyles = false;
            this.gv_result.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_result.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_result.Location = new System.Drawing.Point(3, 99);
            this.gv_result.MultiSelect = false;
            this.gv_result.Name = "gv_result";
            this.gv_result.ReadOnly = true;
            this.gv_result.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_result.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gv_result.RowHeadersVisible = false;
            this.gv_result.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_result.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Wheat;
            this.gv_result.RowTemplate.Height = 30;
            this.gv_result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_result.Size = new System.Drawing.Size(454, 369);
            this.gv_result.Style = MetroFramework.MetroColorStyle.Red;
            this.gv_result.TabIndex = 124;
            this.gv_result.UseStyleColors = true;
            this.gv_result.DoubleClick += new System.EventHandler(this.gv_result_DoubleClick);
            // 
            // cliForDataGridViewTextBoxColumn
            // 
            this.cliForDataGridViewTextBoxColumn.DataPropertyName = "CliFor";
            this.cliForDataGridViewTextBoxColumn.HeaderText = "CliFor";
            this.cliForDataGridViewTextBoxColumn.Name = "cliForDataGridViewTextBoxColumn";
            this.cliForDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliForDataGridViewTextBoxColumn.Visible = false;
            // 
            // mastroDataGridViewTextBoxColumn
            // 
            this.mastroDataGridViewTextBoxColumn.DataPropertyName = "Mastro";
            this.mastroDataGridViewTextBoxColumn.HeaderText = "Mastro";
            this.mastroDataGridViewTextBoxColumn.Name = "mastroDataGridViewTextBoxColumn";
            this.mastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.mastroDataGridViewTextBoxColumn.Visible = false;
            // 
            // contoDataGridViewTextBoxColumn
            // 
            this.contoDataGridViewTextBoxColumn.DataPropertyName = "Conto";
            this.contoDataGridViewTextBoxColumn.HeaderText = "Conto";
            this.contoDataGridViewTextBoxColumn.Name = "contoDataGridViewTextBoxColumn";
            this.contoDataGridViewTextBoxColumn.ReadOnly = true;
            this.contoDataGridViewTextBoxColumn.Visible = false;
            // 
            // sOTTOCONTODataGridViewTextBoxColumn
            // 
            this.sOTTOCONTODataGridViewTextBoxColumn.DataPropertyName = "SOTTOCONTO";
            this.sOTTOCONTODataGridViewTextBoxColumn.HeaderText = "SOTTOCONTO";
            this.sOTTOCONTODataGridViewTextBoxColumn.Name = "sOTTOCONTODataGridViewTextBoxColumn";
            this.sOTTOCONTODataGridViewTextBoxColumn.ReadOnly = true;
            this.sOTTOCONTODataGridViewTextBoxColumn.Visible = false;
            // 
            // cODICENOMINATIVODataGridViewTextBoxColumn
            // 
            this.cODICENOMINATIVODataGridViewTextBoxColumn.DataPropertyName = "CODICE_NOMINATIVO";
            this.cODICENOMINATIVODataGridViewTextBoxColumn.HeaderText = "CODICE_NOMINATIVO";
            this.cODICENOMINATIVODataGridViewTextBoxColumn.Name = "cODICENOMINATIVODataGridViewTextBoxColumn";
            this.cODICENOMINATIVODataGridViewTextBoxColumn.ReadOnly = true;
            this.cODICENOMINATIVODataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RAGIONESOCIALE";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ragione Sociale";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iNDIRIZZODataGridViewTextBoxColumn
            // 
            this.iNDIRIZZODataGridViewTextBoxColumn.DataPropertyName = "INDIRIZZO";
            this.iNDIRIZZODataGridViewTextBoxColumn.HeaderText = "indirizzo";
            this.iNDIRIZZODataGridViewTextBoxColumn.Name = "iNDIRIZZODataGridViewTextBoxColumn";
            this.iNDIRIZZODataGridViewTextBoxColumn.ReadOnly = true;
            this.iNDIRIZZODataGridViewTextBoxColumn.Visible = false;
            // 
            // nUMEROCIVICODataGridViewTextBoxColumn
            // 
            this.nUMEROCIVICODataGridViewTextBoxColumn.DataPropertyName = "NUMERO_CIVICO";
            this.nUMEROCIVICODataGridViewTextBoxColumn.HeaderText = "NUMERO_CIVICO";
            this.nUMEROCIVICODataGridViewTextBoxColumn.Name = "nUMEROCIVICODataGridViewTextBoxColumn";
            this.nUMEROCIVICODataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMEROCIVICODataGridViewTextBoxColumn.Visible = false;
            // 
            // fRAZIONEDataGridViewTextBoxColumn
            // 
            this.fRAZIONEDataGridViewTextBoxColumn.DataPropertyName = "FRAZIONE";
            this.fRAZIONEDataGridViewTextBoxColumn.HeaderText = "FRAZIONE";
            this.fRAZIONEDataGridViewTextBoxColumn.Name = "fRAZIONEDataGridViewTextBoxColumn";
            this.fRAZIONEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fRAZIONEDataGridViewTextBoxColumn.Visible = false;
            // 
            // cAPDataGridViewTextBoxColumn
            // 
            this.cAPDataGridViewTextBoxColumn.DataPropertyName = "CAP";
            this.cAPDataGridViewTextBoxColumn.HeaderText = "CAP";
            this.cAPDataGridViewTextBoxColumn.Name = "cAPDataGridViewTextBoxColumn";
            this.cAPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cAPDataGridViewTextBoxColumn.Visible = false;
            // 
            // cOMUNEDataGridViewTextBoxColumn
            // 
            this.cOMUNEDataGridViewTextBoxColumn.DataPropertyName = "COMUNE";
            this.cOMUNEDataGridViewTextBoxColumn.HeaderText = "COMUNE";
            this.cOMUNEDataGridViewTextBoxColumn.Name = "cOMUNEDataGridViewTextBoxColumn";
            this.cOMUNEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMUNEDataGridViewTextBoxColumn.Visible = false;
            // 
            // pROVINCIADataGridViewTextBoxColumn
            // 
            this.pROVINCIADataGridViewTextBoxColumn.DataPropertyName = "PROVINCIA";
            this.pROVINCIADataGridViewTextBoxColumn.HeaderText = "PROVINCIA";
            this.pROVINCIADataGridViewTextBoxColumn.Name = "pROVINCIADataGridViewTextBoxColumn";
            this.pROVINCIADataGridViewTextBoxColumn.ReadOnly = true;
            this.pROVINCIADataGridViewTextBoxColumn.Visible = false;
            // 
            // nAZIONEDataGridViewTextBoxColumn
            // 
            this.nAZIONEDataGridViewTextBoxColumn.DataPropertyName = "NAZIONE";
            this.nAZIONEDataGridViewTextBoxColumn.HeaderText = "NAZIONE";
            this.nAZIONEDataGridViewTextBoxColumn.Name = "nAZIONEDataGridViewTextBoxColumn";
            this.nAZIONEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAZIONEDataGridViewTextBoxColumn.Visible = false;
            // 
            // sFNcrCliForBindingSource
            // 
            this.sFNcrCliForBindingSource.DataMember = "SF_Ncr_CliFor";
            this.sFNcrCliForBindingSource.DataSource = this.ds_Ncr;
            // 
            // ds_Ncr
            // 
            this.ds_Ncr.DataSetName = "ds_Ncr";
            this.ds_Ncr.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.search_txtbox);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 53);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(454, 40);
            this.metroPanel1.TabIndex = 125;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // search_txtbox
            // 
            // 
            // 
            // 
            this.search_txtbox.CustomButton.Image = null;
            this.search_txtbox.CustomButton.Location = new System.Drawing.Point(483, 1);
            this.search_txtbox.CustomButton.Name = "";
            this.search_txtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.search_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.search_txtbox.CustomButton.TabIndex = 1;
            this.search_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.search_txtbox.CustomButton.UseSelectable = true;
            this.search_txtbox.CustomButton.Visible = false;
            this.search_txtbox.Lines = new string[] {
        "metroTextBox1"};
            this.search_txtbox.Location = new System.Drawing.Point(46, 10);
            this.search_txtbox.MaxLength = 32767;
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.PasswordChar = '\0';
            this.search_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search_txtbox.SelectedText = "";
            this.search_txtbox.SelectionLength = 0;
            this.search_txtbox.SelectionStart = 0;
            this.search_txtbox.ShortcutsEnabled = true;
            this.search_txtbox.Size = new System.Drawing.Size(405, 23);
            this.search_txtbox.Style = MetroFramework.MetroColorStyle.Red;
            this.search_txtbox.TabIndex = 23;
            this.search_txtbox.Text = "metroTextBox1";
            this.search_txtbox.UseSelectable = true;
            this.search_txtbox.UseStyleColors = true;
            this.search_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.search_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.search_txtbox.TextChanged += new System.EventHandler(this.search_txtbox_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(0, 10);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Cerca:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // sF_Ncr_CliForTableAdapter
            // 
            this.sF_Ncr_CliForTableAdapter.ClearBeforeFill = true;
            // 
            // UC_NCR_Search_Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_NCR_Search_Clienti";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Ricerca - Clienti / Fornitori";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UC_NCR_Search_Clienti_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.group_CF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFNcrCliForBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Ncr)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton but_Confirm;
        private System.Windows.Forms.BindingSource famProdBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroGrid gv_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn uGDesGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAGIONESOCIALEDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox search_txtbox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private ds_Ncr ds_Ncr;
        private System.Windows.Forms.BindingSource sFNcrCliForBindingSource;
        private ds_NcrTableAdapters.SF_Ncr_CliForTableAdapter sF_Ncr_CliForTableAdapter;
        private DevExpress.XtraEditors.RadioGroup group_CF;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliForDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOTTOCONTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODICENOMINATIVODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNDIRIZZODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROCIVICODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRAZIONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMUNEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROVINCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZIONEDataGridViewTextBoxColumn;
    }
}