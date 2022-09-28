namespace SmartLineProduction
{
    partial class UC_RealTime_Preview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gv_Preview = new MetroFramework.Controls.MetroGrid();
            this.dttmpPreviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_RealTime = new SmartLineProduction.ds_RealTime();
            this.TmpIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.tmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmpCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmpCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmpCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttmpPreviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_RealTime)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Preview
            // 
            this.gv_Preview.AllowUserToAddRows = false;
            this.gv_Preview.AllowUserToDeleteRows = false;
            this.gv_Preview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.gv_Preview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Preview.AutoGenerateColumns = false;
            this.gv_Preview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Preview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Preview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Preview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Preview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Preview.ColumnHeadersHeight = 40;
            this.gv_Preview.ColumnHeadersVisible = false;
            this.gv_Preview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TmpIcon,
            this.tmpId,
            this.tmpCol1,
            this.tmpCol2,
            this.tmpCol3});
            this.gv_Preview.DataSource = this.dttmpPreviewBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Preview.DefaultCellStyle = dataGridViewCellStyle6;
            this.gv_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Preview.EnableHeadersVisualStyles = false;
            this.gv_Preview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Preview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Preview.Location = new System.Drawing.Point(20, 60);
            this.gv_Preview.MultiSelect = false;
            this.gv_Preview.Name = "gv_Preview";
            this.gv_Preview.ReadOnly = true;
            this.gv_Preview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Preview.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gv_Preview.RowHeadersVisible = false;
            this.gv_Preview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Preview.RowTemplate.Height = 50;
            this.gv_Preview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Preview.Size = new System.Drawing.Size(410, 520);
            this.gv_Preview.Style = MetroFramework.MetroColorStyle.Red;
            this.gv_Preview.TabIndex = 33;
            this.gv_Preview.UseStyleColors = true;
            this.gv_Preview.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gv_Preview_CellPainting);
            this.gv_Preview.VisibleChanged += new System.EventHandler(this.gv_Preview_VisibleChanged);
            // 
            // dttmpPreviewBindingSource
            // 
            this.dttmpPreviewBindingSource.DataMember = "dt_tmp_Preview";
            this.dttmpPreviewBindingSource.DataSource = this.ds_RealTime;
            // 
            // ds_RealTime
            // 
            this.ds_RealTime.DataSetName = "ds_RealTime";
            this.ds_RealTime.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TmpIcon
            // 
            this.TmpIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TmpIcon.FillWeight = 20F;
            this.TmpIcon.HeaderText = "Icona";
            this.TmpIcon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.TmpIcon.Name = "TmpIcon";
            this.TmpIcon.ReadOnly = true;
            this.TmpIcon.Width = 5;
            // 
            // tmpId
            // 
            this.tmpId.DataPropertyName = "tmp_Id";
            this.tmpId.HeaderText = "tmp_Id";
            this.tmpId.Name = "tmpId";
            this.tmpId.ReadOnly = true;
            this.tmpId.Visible = false;
            // 
            // tmpCol1
            // 
            this.tmpCol1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tmpCol1.DataPropertyName = "tmp_Col_1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tmpCol1.DefaultCellStyle = dataGridViewCellStyle3;
            this.tmpCol1.HeaderText = "tmp_Col_1";
            this.tmpCol1.Name = "tmpCol1";
            this.tmpCol1.ReadOnly = true;
            this.tmpCol1.Width = 5;
            // 
            // tmpCol2
            // 
            this.tmpCol2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tmpCol2.DataPropertyName = "tmp_Col_2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tmpCol2.DefaultCellStyle = dataGridViewCellStyle4;
            this.tmpCol2.HeaderText = "tmp_Col_2";
            this.tmpCol2.Name = "tmpCol2";
            this.tmpCol2.ReadOnly = true;
            // 
            // tmpCol3
            // 
            this.tmpCol3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.tmpCol3.DataPropertyName = "tmp_Col_3";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tmpCol3.DefaultCellStyle = dataGridViewCellStyle5;
            this.tmpCol3.HeaderText = "tmp_Col_3";
            this.tmpCol3.Name = "tmpCol3";
            this.tmpCol3.ReadOnly = true;
            this.tmpCol3.Width = 5;
            // 
            // UC_RealTime_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.gv_Preview);
            this.Name = "UC_RealTime_Preview";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Real Time - Preview";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UC_RealTime_Preview_Load);
            this.Shown += new System.EventHandler(this.UC_RealTime_Preview_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttmpPreviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_RealTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroGrid gv_Preview;
        private System.Windows.Forms.BindingSource dttmpPreviewBindingSource;
        private ds_RealTime ds_RealTime;
        private System.Windows.Forms.DataGridViewImageColumn TmpIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmpCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmpCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmpCol3;
    }
}