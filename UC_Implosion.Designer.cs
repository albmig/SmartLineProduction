namespace SmartLineProduction
{
    partial class UC_Implosion
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            this.copytoclipboard = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.copiaIlValoreNellaClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tview_implosion = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.sFDistinteBasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_SL = new SmartLineProduction.ds_SL();
            this.sF_DistinteBasiTableAdapter = new SmartLineProduction.ds_SLTableAdapters.SF_DistinteBasiTableAdapter();
            this.copytoclipboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tview_implosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFDistinteBasiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).BeginInit();
            this.SuspendLayout();
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SmartLineProduction.Properties.Resources.NoImplosione;
            this.pictureBox1.Location = new System.Drawing.Point(20, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 460);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tview_implosion
            // 
            this.tview_implosion.BackColor = System.Drawing.Color.White;
            treeNodeAdvStyleInfo1.CheckBoxTickThickness = 1;
            treeNodeAdvStyleInfo1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            treeNodeAdvStyleInfo1.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.tview_implosion.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.tview_implosion.BeforeTouchSize = new System.Drawing.Size(460, 460);
            this.tview_implosion.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.tview_implosion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tview_implosion.ContextMenuStrip = this.copytoclipboard;
            this.tview_implosion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tview_implosion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tview_implosion.FullRowSelect = true;
            // 
            // 
            // 
            this.tview_implosion.HelpTextControl.BaseThemeName = null;
            this.tview_implosion.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tview_implosion.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.tview_implosion.HelpTextControl.Name = "";
            this.tview_implosion.HelpTextControl.Size = new System.Drawing.Size(15, 15);
            this.tview_implosion.HelpTextControl.TabIndex = 0;
            this.tview_implosion.HelpTextControl.Visible = true;
            this.tview_implosion.HideSelection = false;
            this.tview_implosion.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.tview_implosion.ItemHeight = 25;
            this.tview_implosion.LoadOnDemand = true;
            this.tview_implosion.Location = new System.Drawing.Point(20, 60);
            this.tview_implosion.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.tview_implosion.Name = "tview_implosion";
            this.tview_implosion.SelectedNodeBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220))))));
            this.tview_implosion.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.tview_implosion.ShowFocusRect = false;
            this.tview_implosion.Size = new System.Drawing.Size(460, 460);
            this.tview_implosion.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro;
            this.tview_implosion.TabIndex = 5;
            this.tview_implosion.Text = "treeViewAdv1";
            this.tview_implosion.ThemeName = "Metro";
            this.tview_implosion.ThemeStyle.TreeNodeAdvStyle.CheckBoxTickThickness = 1;
            this.tview_implosion.ThemeStyle.TreeNodeAdvStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tview_implosion.ThemeStyle.TreeNodeAdvStyle.EnsureDefaultOptionedChild = true;
            this.tview_implosion.ThemeStyle.TreeNodeAdvStyle.IntermediateCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tview_implosion.ThemeStyle.TreeNodeAdvStyle.OptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tview_implosion.ThemeStyle.TreeNodeAdvStyle.SelectedOptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            // 
            // 
            // 
            this.tview_implosion.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.tview_implosion.ToolTipControl.BaseThemeName = null;
            this.tview_implosion.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tview_implosion.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.tview_implosion.ToolTipControl.Name = "";
            this.tview_implosion.ToolTipControl.Size = new System.Drawing.Size(15, 15);
            this.tview_implosion.ToolTipControl.TabIndex = 0;
            this.tview_implosion.ToolTipControl.Visible = true;
            this.tview_implosion.Click += new System.EventHandler(this.tview_implosion_Click);
            // 
            // sFDistinteBasiBindingSource
            // 
            this.sFDistinteBasiBindingSource.DataMember = "SF_DistinteBasi";
            this.sFDistinteBasiBindingSource.DataSource = this.ds_SL;
            this.sFDistinteBasiBindingSource.Filter = "";
            this.sFDistinteBasiBindingSource.Sort = "ArticoloComposto asc";
            // 
            // ds_SL
            // 
            this.ds_SL.DataSetName = "ds_SL";
            this.ds_SL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sF_DistinteBasiTableAdapter
            // 
            this.sF_DistinteBasiTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Implosion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 540);
            this.Controls.Add(this.tview_implosion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_Implosion";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Implosione per: ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UC_Implosion_Load);
            this.copytoclipboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tview_implosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFDistinteBasiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ds_SL ds_SL;
        private System.Windows.Forms.BindingSource sFDistinteBasiBindingSource;
        private ds_SLTableAdapters.SF_DistinteBasiTableAdapter sF_DistinteBasiTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroContextMenu copytoclipboard;
        private System.Windows.Forms.ToolStripMenuItem copiaIlValoreNellaClipboardToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv tview_implosion;
    }
}
