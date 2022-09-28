using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace SmartLineProduction
{
    public partial class UC_ImageDevice : MetroFramework.Forms.MetroForm
    {
        public static string thisform_item = "";
        public static string thisform_WEB_path_image = "";


        public UC_ImageDevice(string item, string WEB_path_image)
        {
            thisform_item = item;
            thisform_WEB_path_image = WEB_path_image;
            InitializeComponent();
        }

        private void UC_ImageDevice_Load(object sender, EventArgs e)
        {
            UC_ImageDevice.ActiveForm.Text = thisform_item;

            string famdevice = thisform_item.Substring(0, 3);
            if (famdevice=="XSB")
            {
                famdevice = thisform_item.Substring(0, 5);
            }
            //Carica immagine scheda
            string sigla = thisform_item.Substring(7, 2);
            //string path = thisform_WEB_path_image + famdevice + @"\" + thisform_item + @"\" + thisform_item + "_Full.png";
            string path = thisform_WEB_path_image + famdevice + @"\" + sigla + @"\" + thisform_item + @"\" + thisform_item + "_Full.png";

            if (!File.Exists(path))
            {
                MessageBox.Show("Immagine non presente");
                Device_Image.Image = null;
            }
            else
            {
                Device_Image.Image = Image.FromFile(path);
            }
        }
    }
}
