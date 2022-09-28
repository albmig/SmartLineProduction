namespace SmartLineProduction
{
    partial class UC_SyncroDS
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_CopyFile = new MetroFramework.Controls.MetroLabel();
            this.gv_Datasheet = new System.Windows.Forms.DataGridView();
            this.lab_FaseRicerca = new MetroFramework.Controls.MetroLabel();
            this.lab_FaseCopia = new MetroFramework.Controls.MetroLabel();
            this.StartTimer = new System.Windows.Forms.Timer(this.components);
            this.EndTimer = new System.Windows.Forms.Timer(this.components);
            this.ds_ClassicDS = new SmartLineProduction.ds_ClassicDS();
            this.dtClassicFilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dt_ClassicFilesTableAdapter = new SmartLineProduction.ds_ClassicDSTableAdapters.dt_ClassicFilesTableAdapter();
            this.CDS_FileCopy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CDS_SourceFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDS_SourceLastModify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDS_TargetFileExists = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CDS_TargetLastModify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Datasheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ClassicDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClassicFilesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lab_CopyFile, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gv_Datasheet, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lab_FaseRicerca, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab_FaseCopia, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 615);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // lab_CopyFile
            // 
            this.lab_CopyFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_CopyFile.AutoSize = true;
            this.lab_CopyFile.Location = new System.Drawing.Point(3, 65);
            this.lab_CopyFile.Name = "lab_CopyFile";
            this.lab_CopyFile.Size = new System.Drawing.Size(104, 19);
            this.lab_CopyFile.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_CopyFile.TabIndex = 13;
            this.lab_CopyFile.Text = "Copia del file ... ";
            this.lab_CopyFile.UseStyleColors = true;
            this.lab_CopyFile.Visible = false;
            // 
            // gv_Datasheet
            // 
            this.gv_Datasheet.AutoGenerateColumns = false;
            this.gv_Datasheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Datasheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CDS_FileCopy,
            this.CDS_SourceFilePath,
            this.CDS_SourceLastModify,
            this.CDS_TargetFileExists,
            this.CDS_TargetLastModify});
            this.gv_Datasheet.DataSource = this.dtClassicFilesBindingSource;
            this.gv_Datasheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Datasheet.Location = new System.Drawing.Point(3, 93);
            this.gv_Datasheet.Name = "gv_Datasheet";
            this.gv_Datasheet.RowHeadersVisible = false;
            this.gv_Datasheet.Size = new System.Drawing.Size(1154, 519);
            this.gv_Datasheet.TabIndex = 10;
            // 
            // lab_FaseRicerca
            // 
            this.lab_FaseRicerca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_FaseRicerca.AutoSize = true;
            this.lab_FaseRicerca.Location = new System.Drawing.Point(507, 5);
            this.lab_FaseRicerca.Name = "lab_FaseRicerca";
            this.lab_FaseRicerca.Size = new System.Drawing.Size(146, 19);
            this.lab_FaseRicerca.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_FaseRicerca.TabIndex = 11;
            this.lab_FaseRicerca.Text = "Fase di ricerca - avviata";
            this.lab_FaseRicerca.UseStyleColors = true;
            // 
            // lab_FaseCopia
            // 
            this.lab_FaseCopia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_FaseCopia.AutoSize = true;
            this.lab_FaseCopia.Location = new System.Drawing.Point(510, 35);
            this.lab_FaseCopia.Name = "lab_FaseCopia";
            this.lab_FaseCopia.Size = new System.Drawing.Size(139, 19);
            this.lab_FaseCopia.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_FaseCopia.TabIndex = 12;
            this.lab_FaseCopia.Text = "Fase di copia - avviata";
            this.lab_FaseCopia.UseStyleColors = true;
            // 
            // StartTimer
            // 
            this.StartTimer.Tick += new System.EventHandler(this.StartTimer_Tick);
            // 
            // EndTimer
            // 
            this.EndTimer.Tick += new System.EventHandler(this.EndTimer_Tick);
            // 
            // ds_ClassicDS
            // 
            this.ds_ClassicDS.DataSetName = "ds_ClassicDS";
            this.ds_ClassicDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtClassicFilesBindingSource
            // 
            this.dtClassicFilesBindingSource.DataMember = "dt_ClassicFiles";
            this.dtClassicFilesBindingSource.DataSource = this.ds_ClassicDS;
            // 
            // dt_ClassicFilesTableAdapter
            // 
            this.dt_ClassicFilesTableAdapter.ClearBeforeFill = true;
            // 
            // CDS_FileCopy
            // 
            this.CDS_FileCopy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CDS_FileCopy.DataPropertyName = "CDS_FileCopy";
            this.CDS_FileCopy.HeaderText = "CDS_FileCopy";
            this.CDS_FileCopy.Name = "CDS_FileCopy";
            this.CDS_FileCopy.Width = 81;
            // 
            // CDS_SourceFilePath
            // 
            this.CDS_SourceFilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDS_SourceFilePath.DataPropertyName = "CDS_SourceFilePath";
            this.CDS_SourceFilePath.HeaderText = "CDS_SourceFilePath";
            this.CDS_SourceFilePath.Name = "CDS_SourceFilePath";
            // 
            // CDS_SourceLastModify
            // 
            this.CDS_SourceLastModify.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CDS_SourceLastModify.DataPropertyName = "CDS_SourceLastModify";
            this.CDS_SourceLastModify.HeaderText = "CDS_SourceLastModify";
            this.CDS_SourceLastModify.Name = "CDS_SourceLastModify";
            this.CDS_SourceLastModify.Width = 145;
            // 
            // CDS_TargetFileExists
            // 
            this.CDS_TargetFileExists.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CDS_TargetFileExists.DataPropertyName = "CDS_TargetFileExists";
            this.CDS_TargetFileExists.HeaderText = "CDS_TargetFileExists";
            this.CDS_TargetFileExists.Name = "CDS_TargetFileExists";
            this.CDS_TargetFileExists.Width = 115;
            // 
            // CDS_TargetLastModify
            // 
            this.CDS_TargetLastModify.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CDS_TargetLastModify.DataPropertyName = "CDS_TargetLastModify";
            this.CDS_TargetLastModify.HeaderText = "CDS_TargetLastModify";
            this.CDS_TargetLastModify.Name = "CDS_TargetLastModify";
            this.CDS_TargetLastModify.Width = 142;
            // 
            // UC_SyncroDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1200, 695);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_SyncroDS";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Sincronizzazione Datasheet";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UC_SyncroDS_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Datasheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ClassicDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClassicFilesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView gv_Datasheet;
        private MetroFramework.Controls.MetroLabel lab_FaseRicerca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDSLastModifyDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel lab_FaseCopia;
        private MetroFramework.Controls.MetroLabel lab_CopyFile;
        private System.Windows.Forms.Timer StartTimer;
        private System.Windows.Forms.Timer EndTimer;
        private ds_ClassicDS ds_ClassicDS;
        private System.Windows.Forms.BindingSource dtClassicFilesBindingSource;
        private ds_ClassicDSTableAdapters.dt_ClassicFilesTableAdapter dt_ClassicFilesTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CDS_FileCopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDS_SourceFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDS_SourceLastModify;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CDS_TargetFileExists;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDS_TargetLastModify;
    }
}