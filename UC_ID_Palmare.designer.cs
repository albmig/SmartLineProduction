namespace SmartLineProduction
{
    partial class UC_ID_Palmare
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
            this.cb_famiglia = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_433 = new MetroFramework.Controls.MetroRadioButton();
            this.but_915 = new MetroFramework.Controls.MetroRadioButton();
            this.but_868 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tog_display = new MetroFramework.Controls.MetroToggle();
            this.tog_accel = new MetroFramework.Controls.MetroToggle();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tog_sp = new MetroFramework.Controls.MetroToggle();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tog_buzzer = new MetroFramework.Controls.MetroToggle();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tog_vibra = new MetroFramework.Controls.MetroToggle();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tog_torcia = new MetroFramework.Controls.MetroToggle();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tog_fungo = new MetroFramework.Controls.MetroToggle();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.but_close_UC_ID_Palmare = new MetroFramework.Controls.MetroButton();
            this.lab_ID = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_famiglia
            // 
            this.cb_famiglia.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cb_famiglia.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cb_famiglia.FormattingEnabled = true;
            this.cb_famiglia.ItemHeight = 19;
            this.cb_famiglia.Items.AddRange(new object[] {
            "Easy SL",
            "Trend SL",
            "Easy Lift"});
            this.cb_famiglia.Location = new System.Drawing.Point(104, 84);
            this.cb_famiglia.Name = "cb_famiglia";
            this.cb_famiglia.Size = new System.Drawing.Size(273, 25);
            this.cb_famiglia.TabIndex = 0;
            this.cb_famiglia.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Famiglia:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Frequenza:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_433);
            this.groupBox1.Controls.Add(this.but_915);
            this.groupBox1.Controls.Add(this.but_868);
            this.groupBox1.Location = new System.Drawing.Point(104, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 48);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // but_433
            // 
            this.but_433.AutoSize = true;
            this.but_433.Location = new System.Drawing.Point(226, 19);
            this.but_433.Name = "but_433";
            this.but_433.Size = new System.Drawing.Size(41, 15);
            this.but_433.Style = MetroFramework.MetroColorStyle.Red;
            this.but_433.TabIndex = 5;
            this.but_433.Text = "433";
            this.but_433.UseSelectable = true;
            this.but_433.CheckedChanged += new System.EventHandler(this.but_433_CheckedChanged);
            // 
            // but_915
            // 
            this.but_915.AutoSize = true;
            this.but_915.Location = new System.Drawing.Point(116, 19);
            this.but_915.Name = "but_915";
            this.but_915.Size = new System.Drawing.Size(41, 15);
            this.but_915.Style = MetroFramework.MetroColorStyle.Red;
            this.but_915.TabIndex = 4;
            this.but_915.Text = "915";
            this.but_915.UseSelectable = true;
            this.but_915.CheckedChanged += new System.EventHandler(this.but_915_CheckedChanged);
            // 
            // but_868
            // 
            this.but_868.AutoSize = true;
            this.but_868.Checked = true;
            this.but_868.Location = new System.Drawing.Point(6, 19);
            this.but_868.Name = "but_868";
            this.but_868.Size = new System.Drawing.Size(41, 15);
            this.but_868.Style = MetroFramework.MetroColorStyle.Red;
            this.but_868.TabIndex = 3;
            this.but_868.TabStop = true;
            this.but_868.Text = "868";
            this.but_868.UseSelectable = true;
            this.but_868.CheckedChanged += new System.EventHandler(this.but_868_CheckedChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(23, 178);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Display:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // tog_display
            // 
            this.tog_display.AutoSize = true;
            this.tog_display.Location = new System.Drawing.Point(124, 180);
            this.tog_display.Name = "tog_display";
            this.tog_display.Size = new System.Drawing.Size(80, 17);
            this.tog_display.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_display.TabIndex = 21;
            this.tog_display.Text = "Off";
            this.tog_display.UseSelectable = true;
            this.tog_display.CheckedChanged += new System.EventHandler(this.tog_display_CheckedChanged);
            // 
            // tog_accel
            // 
            this.tog_accel.AutoSize = true;
            this.tog_accel.Location = new System.Drawing.Point(124, 215);
            this.tog_accel.Name = "tog_accel";
            this.tog_accel.Size = new System.Drawing.Size(80, 17);
            this.tog_accel.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_accel.TabIndex = 23;
            this.tog_accel.Text = "Off";
            this.tog_accel.UseSelectable = true;
            this.tog_accel.CheckedChanged += new System.EventHandler(this.tog_accel_CheckedChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(23, 213);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Accelerometro:";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // tog_sp
            // 
            this.tog_sp.AutoSize = true;
            this.tog_sp.Location = new System.Drawing.Point(124, 250);
            this.tog_sp.Name = "tog_sp";
            this.tog_sp.Size = new System.Drawing.Size(80, 17);
            this.tog_sp.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_sp.TabIndex = 25;
            this.tog_sp.Text = "Off";
            this.tog_sp.UseSelectable = true;
            this.tog_sp.CheckedChanged += new System.EventHandler(this.tog_sp_CheckedChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(23, 248);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(84, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel5.TabIndex = 24;
            this.metroLabel5.Text = "Safety Point:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // tog_buzzer
            // 
            this.tog_buzzer.AutoSize = true;
            this.tog_buzzer.Location = new System.Drawing.Point(124, 285);
            this.tog_buzzer.Name = "tog_buzzer";
            this.tog_buzzer.Size = new System.Drawing.Size(80, 17);
            this.tog_buzzer.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_buzzer.TabIndex = 27;
            this.tog_buzzer.Text = "Off";
            this.tog_buzzer.UseSelectable = true;
            this.tog_buzzer.CheckedChanged += new System.EventHandler(this.tog_buzzer_CheckedChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(23, 283);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel6.TabIndex = 26;
            this.metroLabel6.Text = "Buzzer:";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // tog_vibra
            // 
            this.tog_vibra.AutoSize = true;
            this.tog_vibra.Location = new System.Drawing.Point(124, 320);
            this.tog_vibra.Name = "tog_vibra";
            this.tog_vibra.Size = new System.Drawing.Size(80, 17);
            this.tog_vibra.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_vibra.TabIndex = 29;
            this.tog_vibra.Text = "Off";
            this.tog_vibra.UseSelectable = true;
            this.tog_vibra.CheckedChanged += new System.EventHandler(this.tog_vibra_CheckedChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(23, 318);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(63, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel7.TabIndex = 28;
            this.metroLabel7.Text = "Vibracall:";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseStyleColors = true;
            // 
            // tog_torcia
            // 
            this.tog_torcia.AutoSize = true;
            this.tog_torcia.Location = new System.Drawing.Point(124, 355);
            this.tog_torcia.Name = "tog_torcia";
            this.tog_torcia.Size = new System.Drawing.Size(80, 17);
            this.tog_torcia.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_torcia.TabIndex = 31;
            this.tog_torcia.Text = "Off";
            this.tog_torcia.UseSelectable = true;
            this.tog_torcia.CheckedChanged += new System.EventHandler(this.tog_torcia_CheckedChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(23, 353);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(47, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel8.TabIndex = 30;
            this.metroLabel8.Text = "Torcia:";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseStyleColors = true;
            // 
            // tog_fungo
            // 
            this.tog_fungo.AutoSize = true;
            this.tog_fungo.Location = new System.Drawing.Point(124, 390);
            this.tog_fungo.Name = "tog_fungo";
            this.tog_fungo.Size = new System.Drawing.Size(80, 17);
            this.tog_fungo.Style = MetroFramework.MetroColorStyle.Red;
            this.tog_fungo.TabIndex = 33;
            this.tog_fungo.Text = "Off";
            this.tog_fungo.UseSelectable = true;
            this.tog_fungo.CheckedChanged += new System.EventHandler(this.tog_fungo_CheckedChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(23, 388);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(89, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel9.TabIndex = 32;
            this.metroLabel9.Text = "Fungo Emer.:";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseStyleColors = true;
            // 
            // but_close_UC_ID_Palmare
            // 
            this.but_close_UC_ID_Palmare.Location = new System.Drawing.Point(23, 454);
            this.but_close_UC_ID_Palmare.Name = "but_close_UC_ID_Palmare";
            this.but_close_UC_ID_Palmare.Size = new System.Drawing.Size(354, 23);
            this.but_close_UC_ID_Palmare.TabIndex = 34;
            this.but_close_UC_ID_Palmare.Text = "Conferma";
            this.but_close_UC_ID_Palmare.UseSelectable = true;
            this.but_close_UC_ID_Palmare.Click += new System.EventHandler(this.but_close_UC_ID_Palmare_Click);
            // 
            // lab_ID
            // 
            this.lab_ID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_ID.Location = new System.Drawing.Point(23, 421);
            this.lab_ID.Name = "lab_ID";
            this.lab_ID.Size = new System.Drawing.Size(354, 19);
            this.lab_ID.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_ID.TabIndex = 35;
            this.lab_ID.Text = "metroLabel10";
            this.lab_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_ID.UseStyleColors = true;
            // 
            // UC_ID_Palmare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.lab_ID);
            this.Controls.Add(this.but_close_UC_ID_Palmare);
            this.Controls.Add(this.tog_fungo);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.tog_torcia);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.tog_vibra);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.tog_buzzer);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.tog_sp);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.tog_accel);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tog_display);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cb_famiglia);
            this.Name = "UC_ID_Palmare";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Calcolo ID - Palmare";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UC_ID_Palmare_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cb_famiglia;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton but_433;
        private MetroFramework.Controls.MetroRadioButton but_915;
        private MetroFramework.Controls.MetroRadioButton but_868;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroToggle tog_display;
        private MetroFramework.Controls.MetroToggle tog_accel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroToggle tog_sp;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroToggle tog_buzzer;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroToggle tog_vibra;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroToggle tog_torcia;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroToggle tog_fungo;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton but_close_UC_ID_Palmare;
        private MetroFramework.Controls.MetroLabel lab_ID;
    }
}