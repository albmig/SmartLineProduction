namespace SmartLineProduction
{
    partial class UC_Login
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cb_user = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Ncr = new SmartLineProduction.ds_Ncr();
            this.usersTableAdapter = new SmartLineProduction.ds_NcrTableAdapters.UsersTableAdapter();
            this.tb_password = new System.Windows.Forms.MaskedTextBox();
            this.lab_wrong_pwd = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.but_abort_UC_Login = new MetroFramework.Controls.MetroButton();
            this.but_close_UC_Login = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Ncr)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Utente:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Password:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // cb_user
            // 
            this.cb_user.DataSource = this.usersBindingSource;
            this.cb_user.DisplayMember = "CognomeNome";
            this.cb_user.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_user.FormattingEnabled = true;
            this.cb_user.Location = new System.Drawing.Point(104, 84);
            this.cb_user.Name = "cb_user";
            this.cb_user.Size = new System.Drawing.Size(273, 23);
            this.cb_user.TabIndex = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.ds_Ncr;
            this.usersBindingSource.Sort = "CognomeNome Asc";
            // 
            // ds_Ncr
            // 
            this.ds_Ncr.DataSetName = "ds_Ncr";
            this.ds_Ncr.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(104, 115);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(273, 20);
            this.tb_password.TabIndex = 1;
            this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_password_KeyPress);
            // 
            // lab_wrong_pwd
            // 
            this.lab_wrong_pwd.BackColor = System.Drawing.Color.Transparent;
            this.lab_wrong_pwd.Location = new System.Drawing.Point(104, 138);
            this.lab_wrong_pwd.Name = "lab_wrong_pwd";
            this.lab_wrong_pwd.Size = new System.Drawing.Size(273, 23);
            this.lab_wrong_pwd.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_wrong_pwd.TabIndex = 37;
            this.lab_wrong_pwd.Text = "La password inserita non è corretta!";
            this.lab_wrong_pwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_wrong_pwd.UseStyleColors = true;
            this.lab_wrong_pwd.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.but_abort_UC_Login, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.but_close_UC_Login, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 189);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 21);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // but_abort_UC_Login
            // 
            this.but_abort_UC_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but_abort_UC_Login.Location = new System.Drawing.Point(185, 3);
            this.but_abort_UC_Login.Name = "but_abort_UC_Login";
            this.but_abort_UC_Login.Size = new System.Drawing.Size(170, 15);
            this.but_abort_UC_Login.TabIndex = 39;
            this.but_abort_UC_Login.Text = "Abbandona";
            this.but_abort_UC_Login.UseSelectable = true;
            this.but_abort_UC_Login.Click += new System.EventHandler(this.but_abort_UC_Login_Click);
            // 
            // but_close_UC_Login
            // 
            this.but_close_UC_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but_close_UC_Login.Location = new System.Drawing.Point(5, 3);
            this.but_close_UC_Login.Name = "but_close_UC_Login";
            this.but_close_UC_Login.Size = new System.Drawing.Size(170, 15);
            this.but_close_UC_Login.TabIndex = 3;
            this.but_close_UC_Login.Text = "Conferma";
            this.but_close_UC_Login.UseSelectable = true;
            this.but_close_UC_Login.Click += new System.EventHandler(this.but_close_UC_Login_Click);
            // 
            // UC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lab_wrong_pwd);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.cb_user);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UC_Login";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Login user";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UC_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Ncr)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox cb_user;
        private ds_Ncr ds_Ncr;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private ds_NcrTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.MaskedTextBox tb_password;
        private MetroFramework.Controls.MetroLabel lab_wrong_pwd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton but_abort_UC_Login;
        private MetroFramework.Controls.MetroButton but_close_UC_Login;
    }
}