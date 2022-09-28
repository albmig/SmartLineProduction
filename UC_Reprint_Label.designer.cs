namespace SmartLineProduction
{
    partial class UC_Reprint_Label
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
            this.Layout_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.but_abort_UC_Reprint_Label = new MetroFramework.Controls.MetroButton();
            this.but_close_UC_Reprint_Label = new MetroFramework.Controls.MetroButton();
            this.Layout_Print = new System.Windows.Forms.TableLayoutPanel();
            this.lab_old_coord_y = new MetroFramework.Controls.MetroLabel();
            this.pan_Warning = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lab_printstring = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.trigger_coord_x = new System.Windows.Forms.NumericUpDown();
            this.trigger_coord_y = new System.Windows.Forms.NumericUpDown();
            this.lab_old_coord_x = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.tb_coordinate = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.ds_Programmazione = new SmartLineProduction.ds_Programmazione();
            this.firmwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmwareTableAdapter = new SmartLineProduction.ds_ProgrammazioneTableAdapters.FirmwareTableAdapter();
            this.Layout_Buttons.SuspendLayout();
            this.Layout_Print.SuspendLayout();
            this.pan_Warning.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trigger_coord_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trigger_coord_y)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Programmazione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmwareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(25, 217);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Correzione:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // Layout_Buttons
            // 
            this.Layout_Buttons.ColumnCount = 2;
            this.Layout_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_Buttons.Controls.Add(this.but_abort_UC_Reprint_Label, 0, 0);
            this.Layout_Buttons.Controls.Add(this.but_close_UC_Reprint_Label, 0, 0);
            this.Layout_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Layout_Buttons.Location = new System.Drawing.Point(20, 350);
            this.Layout_Buttons.Name = "Layout_Buttons";
            this.Layout_Buttons.RowCount = 1;
            this.Layout_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Layout_Buttons.Size = new System.Drawing.Size(430, 30);
            this.Layout_Buttons.TabIndex = 39;
            // 
            // but_abort_UC_Reprint_Label
            // 
            this.but_abort_UC_Reprint_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but_abort_UC_Reprint_Label.DialogResult = System.Windows.Forms.DialogResult.No;
            this.but_abort_UC_Reprint_Label.Location = new System.Drawing.Point(237, 5);
            this.but_abort_UC_Reprint_Label.Name = "but_abort_UC_Reprint_Label";
            this.but_abort_UC_Reprint_Label.Size = new System.Drawing.Size(170, 20);
            this.but_abort_UC_Reprint_Label.TabIndex = 39;
            this.but_abort_UC_Reprint_Label.Text = "Annulla";
            this.but_abort_UC_Reprint_Label.UseSelectable = true;
            this.but_abort_UC_Reprint_Label.Click += new System.EventHandler(this.but_abort_UC_Reprint_Label_Click);
            // 
            // but_close_UC_Reprint_Label
            // 
            this.but_close_UC_Reprint_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but_close_UC_Reprint_Label.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.but_close_UC_Reprint_Label.Location = new System.Drawing.Point(22, 5);
            this.but_close_UC_Reprint_Label.Name = "but_close_UC_Reprint_Label";
            this.but_close_UC_Reprint_Label.Size = new System.Drawing.Size(170, 20);
            this.but_close_UC_Reprint_Label.TabIndex = 3;
            this.but_close_UC_Reprint_Label.Text = "Stampa";
            this.but_close_UC_Reprint_Label.UseSelectable = true;
            this.but_close_UC_Reprint_Label.Click += new System.EventHandler(this.but_close_UC_Reprint_Label_Click);
            // 
            // Layout_Print
            // 
            this.Layout_Print.ColumnCount = 4;
            this.Layout_Print.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout_Print.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout_Print.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout_Print.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout_Print.Controls.Add(this.lab_old_coord_y, 3, 3);
            this.Layout_Print.Controls.Add(this.pan_Warning, 0, 0);
            this.Layout_Print.Controls.Add(this.metroLabel6, 2, 2);
            this.Layout_Print.Controls.Add(this.metroLabel2, 0, 1);
            this.Layout_Print.Controls.Add(this.metroLabel3, 0, 2);
            this.Layout_Print.Controls.Add(this.metroLabel4, 0, 3);
            this.Layout_Print.Controls.Add(this.lab_printstring, 1, 1);
            this.Layout_Print.Controls.Add(this.metroLabel5, 2, 3);
            this.Layout_Print.Controls.Add(this.trigger_coord_x, 1, 2);
            this.Layout_Print.Controls.Add(this.trigger_coord_y, 1, 3);
            this.Layout_Print.Controls.Add(this.lab_old_coord_x, 3, 2);
            this.Layout_Print.Controls.Add(this.metroPanel2, 0, 5);
            this.Layout_Print.Controls.Add(this.metroPanel1, 0, 4);
            this.Layout_Print.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Print.Location = new System.Drawing.Point(20, 60);
            this.Layout_Print.Name = "Layout_Print";
            this.Layout_Print.RowCount = 6;
            this.Layout_Print.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout_Print.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Layout_Print.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Layout_Print.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.Layout_Print.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Layout_Print.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.Layout_Print.Size = new System.Drawing.Size(430, 290);
            this.Layout_Print.TabIndex = 41;
            this.Layout_Print.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.Layout_Print_CellPaint);
            // 
            // lab_old_coord_y
            // 
            this.lab_old_coord_y.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_old_coord_y.AutoSize = true;
            this.lab_old_coord_y.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_old_coord_y.Location = new System.Drawing.Point(299, 171);
            this.lab_old_coord_y.Name = "lab_old_coord_y";
            this.lab_old_coord_y.Size = new System.Drawing.Size(106, 19);
            this.lab_old_coord_y.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_old_coord_y.TabIndex = 51;
            this.lab_old_coord_y.Text = "lab_old_coord_y";
            this.lab_old_coord_y.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lab_old_coord_y.UseStyleColors = true;
            // 
            // pan_Warning
            // 
            this.pan_Warning.BackColor = System.Drawing.Color.Yellow;
            this.Layout_Print.SetColumnSpan(this.pan_Warning, 4);
            this.pan_Warning.Controls.Add(this.tableLayoutPanel3);
            this.pan_Warning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Warning.HorizontalScrollbarBarColor = true;
            this.pan_Warning.HorizontalScrollbarHighlightOnWheel = false;
            this.pan_Warning.HorizontalScrollbarSize = 10;
            this.pan_Warning.Location = new System.Drawing.Point(3, 3);
            this.pan_Warning.Name = "pan_Warning";
            this.pan_Warning.Size = new System.Drawing.Size(424, 80);
            this.pan_Warning.TabIndex = 47;
            this.pan_Warning.UseCustomBackColor = true;
            this.pan_Warning.VerticalScrollbarBarColor = true;
            this.pan_Warning.VerticalScrollbarHighlightOnWheel = false;
            this.pan_Warning.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.metroLabel8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel7, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(424, 80);
            this.tableLayoutPanel3.TabIndex = 44;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(45, 47);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(334, 25);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel8.TabIndex = 43;
            this.metroLabel8.Text = "Il codice richiede la programmazione PIC";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(3, 7);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(418, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel7.TabIndex = 42;
            this.metroLabel7.Text = "Attenzione!!";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(178, 133);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(115, 19);
            this.metroLabel6.TabIndex = 45;
            this.metroLabel6.Text = "Precedentemente:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Location = new System.Drawing.Point(3, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 19);
            this.metroLabel2.TabIndex = 40;
            this.metroLabel2.Text = "Stringa di stampa:";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 133);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 42;
            this.metroLabel3.Text = "Coordinata x:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 171);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 19);
            this.metroLabel4.TabIndex = 43;
            this.metroLabel4.Text = "Coordinata y:";
            // 
            // lab_printstring
            // 
            this.lab_printstring.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_printstring.AutoSize = true;
            this.lab_printstring.BackColor = System.Drawing.Color.Transparent;
            this.Layout_Print.SetColumnSpan(this.lab_printstring, 3);
            this.lab_printstring.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_printstring.Location = new System.Drawing.Point(124, 95);
            this.lab_printstring.Name = "lab_printstring";
            this.lab_printstring.Size = new System.Drawing.Size(97, 19);
            this.lab_printstring.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_printstring.TabIndex = 41;
            this.lab_printstring.Text = "lab_printstring";
            this.lab_printstring.UseCustomBackColor = true;
            this.lab_printstring.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(178, 171);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(115, 19);
            this.metroLabel5.TabIndex = 44;
            this.metroLabel5.Text = "Precedentemente:";
            // 
            // trigger_coord_x
            // 
            this.trigger_coord_x.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trigger_coord_x.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trigger_coord_x.Location = new System.Drawing.Point(124, 130);
            this.trigger_coord_x.Maximum = new decimal(new int[] {
            284,
            0,
            0,
            0});
            this.trigger_coord_x.Name = "trigger_coord_x";
            this.trigger_coord_x.Size = new System.Drawing.Size(48, 25);
            this.trigger_coord_x.TabIndex = 48;
            this.trigger_coord_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trigger_coord_y
            // 
            this.trigger_coord_y.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trigger_coord_y.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trigger_coord_y.Location = new System.Drawing.Point(124, 168);
            this.trigger_coord_y.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.trigger_coord_y.Name = "trigger_coord_y";
            this.trigger_coord_y.Size = new System.Drawing.Size(48, 25);
            this.trigger_coord_y.TabIndex = 49;
            this.trigger_coord_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lab_old_coord_x
            // 
            this.lab_old_coord_x.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lab_old_coord_x.AutoSize = true;
            this.lab_old_coord_x.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_old_coord_x.Location = new System.Drawing.Point(299, 133);
            this.lab_old_coord_x.Name = "lab_old_coord_x";
            this.lab_old_coord_x.Size = new System.Drawing.Size(105, 19);
            this.lab_old_coord_x.Style = MetroFramework.MetroColorStyle.Red;
            this.lab_old_coord_x.TabIndex = 50;
            this.lab_old_coord_x.Text = "lab_old_coord_x";
            this.lab_old_coord_x.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lab_old_coord_x.UseStyleColors = true;
            // 
            // metroPanel2
            // 
            this.Layout_Print.SetColumnSpan(this.metroPanel2, 4);
            this.metroPanel2.Controls.Add(this.tb_coordinate);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 232);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(424, 55);
            this.metroPanel2.TabIndex = 53;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // tb_coordinate
            // 
            // 
            // 
            // 
            this.tb_coordinate.CustomButton.Image = null;
            this.tb_coordinate.CustomButton.Location = new System.Drawing.Point(370, 1);
            this.tb_coordinate.CustomButton.Name = "";
            this.tb_coordinate.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.tb_coordinate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_coordinate.CustomButton.TabIndex = 1;
            this.tb_coordinate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_coordinate.CustomButton.UseSelectable = true;
            this.tb_coordinate.CustomButton.Visible = false;
            this.tb_coordinate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_coordinate.Lines = new string[] {
        "L\'etichetta viene stampata al contrario rispetto all\'operatore. Aumentando la coo" +
            "rdinata X, l\'etichetta si sposta a sinistra. Aumentando la coordinata Y, l\'etich" +
            "etta si sposta in alto."};
            this.tb_coordinate.Location = new System.Drawing.Point(0, 0);
            this.tb_coordinate.MaxLength = 32767;
            this.tb_coordinate.Multiline = true;
            this.tb_coordinate.Name = "tb_coordinate";
            this.tb_coordinate.PasswordChar = '\0';
            this.tb_coordinate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_coordinate.SelectedText = "";
            this.tb_coordinate.SelectionLength = 0;
            this.tb_coordinate.SelectionStart = 0;
            this.tb_coordinate.ShortcutsEnabled = true;
            this.tb_coordinate.Size = new System.Drawing.Size(424, 55);
            this.tb_coordinate.Style = MetroFramework.MetroColorStyle.Green;
            this.tb_coordinate.TabIndex = 3;
            this.tb_coordinate.Text = "L\'etichetta viene stampata al contrario rispetto all\'operatore. Aumentando la coo" +
    "rdinata X, l\'etichetta si sposta a sinistra. Aumentando la coordinata Y, l\'etich" +
    "etta si sposta in alto.";
            this.tb_coordinate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_coordinate.UseSelectable = true;
            this.tb_coordinate.UseStyleColors = true;
            this.tb_coordinate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_coordinate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.Layout_Print.SetColumnSpan(this.metroPanel1, 4);
            this.metroPanel1.Controls.Add(this.metroTextBox2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 202);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(424, 24);
            this.metroPanel1.TabIndex = 52;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(402, 2);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTextBox2.Lines = new string[] {
        "12 dots = 1 mm."};
            this.metroTextBox2.Location = new System.Drawing.Point(0, 0);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(424, 24);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBox2.TabIndex = 3;
            this.metroTextBox2.Text = "12 dots = 1 mm.";
            this.metroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.UseStyleColors = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ds_Programmazione
            // 
            this.ds_Programmazione.DataSetName = "ds_Programmazione";
            this.ds_Programmazione.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmwareBindingSource
            // 
            this.firmwareBindingSource.DataMember = "Firmware";
            this.firmwareBindingSource.DataSource = this.ds_Programmazione;
            // 
            // firmwareTableAdapter
            // 
            this.firmwareTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Reprint_Label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(470, 400);
            this.ControlBox = false;
            this.Controls.Add(this.Layout_Print);
            this.Controls.Add(this.Layout_Buttons);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UC_Reprint_Label";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Stampa etichetta";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UC_Reprint_Label_Load);
            this.Layout_Buttons.ResumeLayout(false);
            this.Layout_Print.ResumeLayout(false);
            this.Layout_Print.PerformLayout();
            this.pan_Warning.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trigger_coord_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trigger_coord_y)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_Programmazione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmwareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TableLayoutPanel Layout_Buttons;
        private MetroFramework.Controls.MetroButton but_abort_UC_Reprint_Label;
        private MetroFramework.Controls.MetroButton but_close_UC_Reprint_Label;
        private System.Windows.Forms.TableLayoutPanel Layout_Print;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lab_printstring;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel pan_Warning;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.NumericUpDown trigger_coord_x;
        private System.Windows.Forms.NumericUpDown trigger_coord_y;
        private MetroFramework.Controls.MetroLabel lab_old_coord_y;
        private MetroFramework.Controls.MetroLabel lab_old_coord_x;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox tb_coordinate;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private ds_Programmazione ds_Programmazione;
        private System.Windows.Forms.BindingSource firmwareBindingSource;
        private ds_ProgrammazioneTableAdapters.FirmwareTableAdapter firmwareTableAdapter;
    }
}