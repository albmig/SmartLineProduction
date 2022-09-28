namespace SmartLineProduction
{
    partial class UC_Password
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
            this.tb_password = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_Invia = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // tb_password
            // 
            this.tb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_password.Location = new System.Drawing.Point(54, 70);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(177, 20);
            this.tb_password.TabIndex = 0;
            this.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_password_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(106, 48);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Password:";
            // 
            // btn_Invia
            // 
            this.btn_Invia.Location = new System.Drawing.Point(106, 115);
            this.btn_Invia.Name = "btn_Invia";
            this.btn_Invia.Size = new System.Drawing.Size(75, 23);
            this.btn_Invia.TabIndex = 1;
            this.btn_Invia.Text = "Invia";
            this.btn_Invia.UseSelectable = true;
            this.btn_Invia.Click += new System.EventHandler(this.btn_Invia_Click);
            // 
            // UC_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Invia);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tb_password);
            this.DisplayHeader = false;
            this.Name = "UC_Password";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "UC_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tb_password;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_Invia;
    }
}