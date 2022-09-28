namespace SmartLineProduction
{
    partial class UC_ImageDevice
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
            this.panel_device_image = new MetroFramework.Controls.MetroPanel();
            this.Device_Image = new System.Windows.Forms.PictureBox();
            this.panel_device_image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Device_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_device_image
            // 
            this.panel_device_image.Controls.Add(this.Device_Image);
            this.panel_device_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_device_image.HorizontalScrollbarBarColor = true;
            this.panel_device_image.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_device_image.HorizontalScrollbarSize = 10;
            this.panel_device_image.Location = new System.Drawing.Point(20, 60);
            this.panel_device_image.Name = "panel_device_image";
            this.panel_device_image.Size = new System.Drawing.Size(260, 320);
            this.panel_device_image.TabIndex = 42;
            this.panel_device_image.VerticalScrollbarBarColor = true;
            this.panel_device_image.VerticalScrollbarHighlightOnWheel = false;
            this.panel_device_image.VerticalScrollbarSize = 10;
            // 
            // Device_Image
            // 
            this.Device_Image.BackColor = System.Drawing.Color.White;
            this.Device_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Device_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Device_Image.Location = new System.Drawing.Point(0, 0);
            this.Device_Image.Name = "Device_Image";
            this.Device_Image.Size = new System.Drawing.Size(260, 320);
            this.Device_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Device_Image.TabIndex = 40;
            this.Device_Image.TabStop = false;
            // 
            // UC_ImageDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.panel_device_image);
            this.Name = "UC_ImageDevice";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "UC_ImageDevice";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UC_ImageDevice_Load);
            this.panel_device_image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Device_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panel_device_image;
        private System.Windows.Forms.PictureBox Device_Image;
    }
}