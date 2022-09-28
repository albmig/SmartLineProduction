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
            ((System.ComponentModel.ISupportInitialize)(this.safetyPointRFIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Programmazione)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Tag1
            // 
            this.tb_Tag1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Tag1.Location = new System.Drawing.Point(62, 53);
            this.tb_Tag1.Name = "tb_Tag1";
            this.tb_Tag1.Size = new System.Drawing.Size(177, 20);
            this.tb_Tag1.TabIndex = 0;
            this.tb_Tag1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Tag1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Tag1_KeyPress);
            this.tb_Tag1.Leave += new System.EventHandler(this.tb_Tag1_Leave);
            // 
            // lab_Tag1
            // 
            this.lab_Tag1.AutoSize = true;
            this.lab_Tag1.Location = new System.Drawing.Point(124, 31);
            this.lab_Tag1.Name = "lab_Tag1";
            this.lab_Tag1.Size = new System.Drawing.Size(52, 19);
            this.lab_Tag1.TabIndex = 1;
            this.lab_Tag1.Text = "TAG #1:";
            // 
            // btn_Invia
            // 
            this.btn_Invia.Location = new System.Drawing.Point(113, 155);
            this.btn_Invia.Name = "btn_Invia";
            this.btn_Invia.Size = new System.Drawing.Size(75, 23);
            this.btn_Invia.TabIndex = 1;
            this.btn_Invia.Text = "Invia";
            this.btn_Invia.UseSelectable = true;
            this.btn_Invia.Click += new System.EventHandler(this.btn_Invia_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(124, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "TAG #2:";
            // 
            // tb_Tag2
            // 
            this.tb_Tag2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Tag2.Location = new System.Drawing.Point(62, 109);
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
            // UC_ConfirmTAG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tb_Tag2);
            this.Controls.Add(this.btn_Invia);
            this.Controls.Add(this.lab_Tag1);
            this.Controls.Add(this.tb_Tag1);
            this.DisplayHeader = false;
            this.Name = "UC_ConfirmTAG";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "UC_ConfirmTAG";
            this.Load += new System.EventHandler(this.UC_ConfirmTAG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.safetyPointRFIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Programmazione)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}