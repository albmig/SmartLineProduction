namespace SmartLineProduction
{
    partial class UC_NCR_Search_Articoli
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
            this.but_Confirm = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gv_result = new MetroFramework.Controls.MetroGrid();
            this.articoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFNcrArticoliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Ncr = new SmartLineProduction.ds_Ncr();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.search_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.sF_Ncr_ArticoliTableAdapter = new SmartLineProduction.ds_NcrTableAdapters.SF_Ncr_ArticoliTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFNcrArticoliBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.gv_result, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.but_Confirm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 520);
            this.tableLayoutPanel1.TabIndex = 9;
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
            this.articoloDataGridViewTextBoxColumn,
            this.descrizioneDataGridViewTextBoxColumn});
            this.gv_result.DataSource = this.sFNcrArticoliBindingSource;
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
            this.gv_result.Location = new System.Drawing.Point(3, 49);
            this.gv_result.MultiSelect = false;
            this.gv_result.Name = "gv_result";
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
            this.gv_result.Size = new System.Drawing.Size(454, 419);
            this.gv_result.Style = MetroFramework.MetroColorStyle.Red;
            this.gv_result.TabIndex = 124;
            this.gv_result.UseStyleColors = true;
            this.gv_result.DoubleClick += new System.EventHandler(this.gv_result_DoubleClick);
            // 
            // articoloDataGridViewTextBoxColumn
            // 
            this.articoloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.articoloDataGridViewTextBoxColumn.DataPropertyName = "Articolo";
            this.articoloDataGridViewTextBoxColumn.HeaderText = "Articolo";
            this.articoloDataGridViewTextBoxColumn.Name = "articoloDataGridViewTextBoxColumn";
            // 
            // descrizioneDataGridViewTextBoxColumn
            // 
            this.descrizioneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.Name = "descrizioneDataGridViewTextBoxColumn";
            // 
            // sFNcrArticoliBindingSource
            // 
            this.sFNcrArticoliBindingSource.DataMember = "SF_Ncr_Articoli";
            this.sFNcrArticoliBindingSource.DataSource = this.ds_Ncr;
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
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
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
            this.search_txtbox.CustomButton.Location = new System.Drawing.Point(383, 1);
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
            // sF_Ncr_ArticoliTableAdapter
            // 
            this.sF_Ncr_ArticoliTableAdapter.ClearBeforeFill = true;
            // 
            // UC_NCR_Search_Articoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_NCR_Search_Articoli";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Ricerca - Articoli";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UC_NCR_Search_Articoli_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFNcrArticoliBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource sFNcrArticoliBindingSource;
        private ds_NcrTableAdapters.SF_Ncr_ArticoliTableAdapter sF_Ncr_ArticoliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn articoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizioneDataGridViewTextBoxColumn;
    }
}