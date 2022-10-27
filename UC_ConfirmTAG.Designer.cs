namespace SmartLineProduction
{
    partial class UC_ConfirmTAG
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
            this.tb_Tag1 = new System.Windows.Forms.MaskedTextBox();
            this.lab_Tag1 = new MetroFramework.Controls.MetroLabel();
            this.btn_Invia = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tb_Tag2 = new System.Windows.Forms.MaskedTextBox();
            this.safetyPointRFIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Programmazione = new SmartLineProduction.ds_Programmazione();
            this.safetyPointRFIDTableAdapter = new SmartLineProduction.ds_ProgrammazioneTableAdapters.SafetyPointRFIDTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Abort = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.safetyPointRFIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Programmazione)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Tag1
            // 
            this.tb_Tag1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_Tag1, 2);
            this.tb_Tag1.Location = new System.Drawing.Point(41, 27);
            this.tb_Tag1.Name = "tb_Tag1";
            this.tb_Tag1.Size = new System.Drawing.Size(177, 20);
            this.tb_Tag1.TabIndex = 0;
            this.tb_Tag1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Tag1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Tag1_KeyPress);
            this.tb_Tag1.Leave += new System.EventHandler(this.tb_Tag1_Leave);
            // 
            // lab_Tag1
            // 
            this.lab_Tag1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_Tag1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lab_Tag1, 2);
            this.lab_Tag1.Location = new System.Drawing.Point(104, 2);
            this.lab_Tag1.Name = "lab_Tag1";
            this.lab_Tag1.Size = new System.Drawing.Size(52, 19);
            this.lab_Tag1.TabIndex = 1;
            this.lab_Tag1.Text = "TAG #1:";
            // 
            // btn_Invia
            // 
            this.btn_Invia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Invia.Location = new System.Drawing.Point(3, 123);
            this.btn_Invia.Name = "btn_Invia";
            this.btn_Invia.Size = new System.Drawing.Size(124, 23);
            this.btn_Invia.TabIndex = 1;
            this.btn_Invia.Text = "Invia";
            this.btn_Invia.UseSelectable = true;
            this.btn_Invia.Click += new System.EventHandler(this.btn_Invia_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.metroLabel1, 2);
            this.metroLabel1.Location = new System.Drawing.Point(103, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "TAG #2:";
            // 
            // tb_Tag2
            // 
            this.tb_Tag2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_Tag2, 2);
            this.tb_Tag2.Location = new System.Drawing.Point(41, 75);
            this.tb_Tag2.Name = "tb_Tag2";
            this.tb_Tag2.Size = new System.Drawing.Size(177, 20);
            this.tb_Tag2.TabIndex = 2;
            this.tb_Tag2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Tag2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Tag2_KeyPress);
            this.tb_Tag2.Leave += new System.EventHandler(this.tb_Tag2_Leave);
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
            // safetyPointRFIDTableAdapter
            // 
            this.safetyPointRFIDTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lab_Tag1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Invia, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Tag2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Tag1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Abort, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 150);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btn_Abort
            // 
            this.btn_Abort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Abort.BackColor = System.Drawing.Color.Red;
            this.btn_Abort.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btn_Abort.Location = new System.Drawing.Point(133, 123);
            this.btn_Abort.Name = "btn_Abort";
            this.btn_Abort.Size = new System.Drawing.Size(124, 23);
            this.btn_Abort.TabIndex = 4;
            this.btn_Abort.Text = "NON ASSOCIARE TAG";
            this.btn_Abort.UseCustomBackColor = true;
            this.btn_Abort.UseSelectable = true;
            // 
            // UC_ConfirmTAG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DisplayHeader = false;
            this.Name = "UC_ConfirmTAG";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "UC_ConfirmTAG";
            this.Load += new System.EventHandler(this.UC_ConfirmTAG_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.UC_ConfirmTAG_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.safetyPointRFIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Programmazione)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tb_Tag1;
        private MetroFramework.Controls.MetroLabel lab_Tag1;
        private MetroFramework.Controls.MetroButton btn_Invia;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.MaskedTextBox tb_Tag2;
        private ds_Programmazione ds_Programmazione;
        private System.Windows.Forms.BindingSource safetyPointRFIDBindingSource;
        private ds_ProgrammazioneTableAdapters.SafetyPointRFIDTableAdapter safetyPointRFIDTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton btn_Abort;
    }
}