namespace SmartLineProduction
{
    partial class UC_AV_Vendite
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
            this.panel_label = new MetroFramework.Controls.MetroPanel();
            this.panel_note = new MetroFramework.Controls.MetroPanel();
            this.panel_button = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lab_ragsoc = new MetroFramework.Controls.MetroLabel();
            this.lab_articolo = new MetroFramework.Controls.MetroLabel();
            this.lab_commessa = new MetroFramework.Controls.MetroLabel();
            this.combo_qta = new MetroFramework.Controls.MetroComboBox();
            this.txt_note = new MetroFramework.Controls.MetroTextBox();
            this.panel_label.SuspendLayout();
            this.panel_note.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_label
            // 
            this.panel_label.Controls.Add(this.combo_qta);
            this.panel_label.Controls.Add(this.metroLabel4);
            this.panel_label.Controls.Add(this.metroLabel3);
            this.panel_label.Controls.Add(this.metroLabel2);
            this.panel_label.Controls.Add(this.metroLabel1);
            this.panel_label.Controls.Add(this.lab_ragsoc);
            this.panel_label.Controls.Add(this.lab_articolo);
            this.panel_label.Controls.Add(this.lab_commessa);
            this.panel_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_label.HorizontalScrollbarBarColor = true;
            this.panel_label.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_label.HorizontalScrollbarSize = 10;
            this.panel_label.Location = new System.Drawing.Point(20, 60);
            this.panel_label.Name = "panel_label";
            this.panel_label.Size = new System.Drawing.Size(460, 140);
            this.panel_label.TabIndex = 13;
            this.panel_label.VerticalScrollbarBarColor = true;
            this.panel_label.VerticalScrollbarHighlightOnWheel = false;
            this.panel_label.VerticalScrollbarSize = 10;
            // 
            // panel_note
            // 
            this.panel_note.Controls.Add(this.txt_note);
            this.panel_note.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_note.HorizontalScrollbarBarColor = true;
            this.panel_note.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_note.HorizontalScrollbarSize = 10;
            this.panel_note.Location = new System.Drawing.Point(20, 200);
            this.panel_note.Name = "panel_note";
            this.panel_note.Size = new System.Drawing.Size(460, 300);
            this.panel_note.TabIndex = 15;
            this.panel_note.VerticalScrollbarBarColor = true;
            this.panel_note.VerticalScrollbarHighlightOnWheel = false;
            this.panel_note.VerticalScrollbarSize = 10;
            // 
            // panel_button
            // 
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_button.HorizontalScrollbarBarColor = true;
            this.panel_button.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_button.HorizontalScrollbarSize = 10;
            this.panel_button.Location = new System.Drawing.Point(20, 500);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(460, 30);
            this.panel_button.TabIndex = 16;
            this.panel_button.VerticalScrollbarBarColor = true;
            this.panel_button.VerticalScrollbarHighlightOnWheel = false;
            this.panel_button.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(9, 110);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(137, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Quantità da evadere:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(9, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "Articolo:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(9, 42);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Commessa:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(9, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Ragione Sociale:";
            // 
            // lab_ragsoc
            // 
            this.lab_ragsoc.AutoSize = true;
            this.lab_ragsoc.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_ragsoc.Location = new System.Drawing.Point(160, 8);
            this.lab_ragsoc.Name = "lab_ragsoc";
            this.lab_ragsoc.Size = new System.Drawing.Size(73, 19);
            this.lab_ragsoc.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_ragsoc.TabIndex = 13;
            this.lab_ragsoc.Text = "lab_ragsoc";
            this.lab_ragsoc.UseStyleColors = true;
            // 
            // lab_articolo
            // 
            this.lab_articolo.AutoSize = true;
            this.lab_articolo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_articolo.Location = new System.Drawing.Point(160, 76);
            this.lab_articolo.Name = "lab_articolo";
            this.lab_articolo.Size = new System.Drawing.Size(78, 19);
            this.lab_articolo.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_articolo.TabIndex = 15;
            this.lab_articolo.Text = "lab_articolo";
            this.lab_articolo.UseStyleColors = true;
            // 
            // lab_commessa
            // 
            this.lab_commessa.AutoSize = true;
            this.lab_commessa.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_commessa.Location = new System.Drawing.Point(160, 42);
            this.lab_commessa.Name = "lab_commessa";
            this.lab_commessa.Size = new System.Drawing.Size(97, 19);
            this.lab_commessa.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_commessa.TabIndex = 14;
            this.lab_commessa.Text = "lab_commessa";
            this.lab_commessa.UseStyleColors = true;
            // 
            // combo_qta
            // 
            this.combo_qta.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.combo_qta.FormattingEnabled = true;
            this.combo_qta.ItemHeight = 19;
            this.combo_qta.Location = new System.Drawing.Point(160, 108);
            this.combo_qta.Name = "combo_qta";
            this.combo_qta.Size = new System.Drawing.Size(108, 25);
            this.combo_qta.TabIndex = 21;
            this.combo_qta.UseSelectable = true;
            // 
            // txt_note
            // 
            // 
            // 
            // 
            this.txt_note.CustomButton.Image = null;
            this.txt_note.CustomButton.Location = new System.Drawing.Point(93, 2);
            this.txt_note.CustomButton.Name = "";
            this.txt_note.CustomButton.Size = new System.Drawing.Size(295, 295);
            this.txt_note.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_note.CustomButton.TabIndex = 1;
            this.txt_note.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_note.CustomButton.UseSelectable = true;
            this.txt_note.CustomButton.Visible = false;
            this.txt_note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_note.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_note.Lines = new string[] {
        "metroTextBox1"};
            this.txt_note.Location = new System.Drawing.Point(0, 0);
            this.txt_note.MaxLength = 32767;
            this.txt_note.Name = "txt_note";
            this.txt_note.PasswordChar = '\0';
            this.txt_note.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_note.SelectedText = "";
            this.txt_note.SelectionLength = 0;
            this.txt_note.SelectionStart = 0;
            this.txt_note.ShortcutsEnabled = true;
            this.txt_note.Size = new System.Drawing.Size(460, 300);
            this.txt_note.Style = MetroFramework.MetroColorStyle.Red;
            this.txt_note.TabIndex = 10;
            this.txt_note.Text = "metroTextBox1";
            this.txt_note.UseSelectable = true;
            this.txt_note.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_note.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UC_AV_Vendite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartLineProduction.Properties.Resources.Icona_AV_Programma_Enable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackImage = global::SmartLineProduction.Properties.Resources.Icona_AV_Programma_Enable;
            this.BackLocation = MetroFramework.Forms.BackLocation.BottomLeft;
            this.ClientSize = new System.Drawing.Size(500, 540);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.panel_note);
            this.Controls.Add(this.panel_label);
            this.Name = "UC_Vendite";
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Avanzanzamento Vendite";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UC_AV_Vendite_Load);
            this.panel_label.ResumeLayout(false);
            this.panel_label.PerformLayout();
            this.panel_note.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panel_label;
        private MetroFramework.Controls.MetroComboBox combo_qta;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lab_ragsoc;
        private MetroFramework.Controls.MetroLabel lab_articolo;
        private MetroFramework.Controls.MetroLabel lab_commessa;
        private MetroFramework.Controls.MetroPanel panel_note;
        private MetroFramework.Controls.MetroPanel panel_button;
        private MetroFramework.Controls.MetroTextBox txt_note;
    }
}