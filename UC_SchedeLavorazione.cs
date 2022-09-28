using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.IO;
using System.Drawing.Imaging;

namespace SmartLineProduction
{
    public partial class UC_SchedeLavorazione : MetroFramework.Forms.MetroForm
    {
        public static string qr_read_device = "";                               // la lettura "pura" del barcode
        public static string qr_sn = "";                                        // serial number del barcode (non ID Smartline)
        public static string qr_ID = "";                                        // lettura del barcode, può essere codice articolo (classic) o ID Smartline (smartline)
        public static string qr_fw = "";                                        // lettura del barcode
        public static string qr_ClassicSmart = "";                              // C Classic - S Smartline
        public static string path_classic = @"\\192.168.0.8\sistematica\AREA_PRODOTTO\CLASSICLINE\XSLV_XPCL\";
        public static string path_smartline = @"\\192.168.0.8\sistematica\AREA_PRODOTTO\SMARTLINE\XSLV\";
        public static string WEB_path_image = Properties.Settings.Default.Doc_folder;
        public static string CLASSIC_path_image = @"\\192.168.0.8\sistematica\AREA_PRODOTTO\CLASSICLINE\IMMAGINI_PRODOTTO\";
        public static string SMARTLINE_path_image = @"\\192.168.0.8\sistematica\AREA_PRODOTTO\SMARTLINE\IMMAGINI_PRODOTTO\";
        public static string filtro_special = "TipoScheda = 'LSP'";
        public static string filtro_standard = "(TipoScheda = 'LST' OR TipoScheda = 'COL')";
        public static string filtro_articolo = string.Empty;
        public static string filtroprincipale = string.Empty;

        //public static List<string> xslv_list_classic = new List<string>();
        //public static List<string> xslv_list_smartline = new List<string>();

        public UC_SchedeLavorazione()
        {
            InitializeComponent();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbx_ReadLabel_Device_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\t' || e.KeyChar == (char)13)
            {
                e.Handled = true;
                qr_read_device = tbx_ReadLabel_Device.Text;
                AnalizzaQrDevice(qr_read_device);
                but_Reset.Focus();
            }
        }

        private void tbx_ReadLabel_Device_Leave(object sender, EventArgs e)
        {
            if (tbx_ReadLabel_Device.Text == "") return;

            qr_read_device = tbx_ReadLabel_Device.Text;
            if (AnalizzaQrDevice(qr_read_device))
            {
                but_Reset.Focus();

                panel_pdf_xslv.Visible = true;
                panel_tipo_slv.Visible = true;
                panel_device.Visible = true;
                panel_result.Visible = true;

                filtro_articolo = "ArticoloComposto = " + "'" + qr_read_device + "'";

                if (tog_Slv.IsOn)
                {
                    filtroprincipale = filtro_articolo + " AND " + filtro_standard;
                }
                else
                {
                    filtroprincipale = filtro_articolo + " AND " + filtro_special;
                }

                sFDbarXSLVBindingSource.Filter = filtroprincipale;
                gv_result.Visible = true;

                if (sFDbarXSLVBindingSource.Count == 0)
                {
                    pdf_viewer_xslv.LoadDocument(@"Resources\NO_XSLV.pdf");
                }

                //Carica Immagine
                string famdevice = qr_read_device.Substring(0, 3);
                if (famdevice == "XSB")
                {
                    famdevice = qr_read_device.Substring(0, 5);
                }
                //Carica immagine scheda
                string sigla = qr_read_device.Substring(7, 2);
                string path_SL = WEB_path_image + famdevice + @"\" + sigla + @"\" + qr_read_device + @"\" + qr_read_device + "_Full.png";
                string path_CL = CLASSIC_path_image + @"\" + qr_read_device + ".jpg";
                string path_prodotto_SL = SMARTLINE_path_image + @"\" + qr_read_device + ".jpg";
                panel_device.Visible = true;

                if (File.Exists(path_SL))
                {
                    Device_Image.Image = Image.FromFile(path_SL);
                    Device_Image.Image.RotateFlip(Rotate(Image.FromFile(path_SL)));
                }
                else
                if (File.Exists(path_CL))
                {
                    Device_Image.Image = Image.FromFile(path_CL);
                    Device_Image.Image.RotateFlip(Rotate(Image.FromFile(path_CL)));

                }
                else
                if (File.Exists(path_prodotto_SL))
                {
                    Device_Image.Image = Image.FromFile(path_prodotto_SL);
                    Device_Image.Image.RotateFlip(Rotate(Image.FromFile(path_prodotto_SL)));
                }
                else
                {
                    Device_Image.Image = Properties.Resources.ImageNotPresent;
                }
            }
        }

        public static RotateFlipType Rotate(Image bmp)
        {
            const int OrientationId = 0x0112;
            PropertyItem pi = bmp.PropertyItems.Select(x => x)
                                        .FirstOrDefault(x => x.Id == OrientationId);
            if (pi == null)
                return RotateFlipType.RotateNoneFlipNone;

            byte o = pi.Value[0];

            //Orientations
            if (o == 2) //TopRight
                return RotateFlipType.RotateNoneFlipX;
            if (o == 3) //BottomRight
                return RotateFlipType.RotateNoneFlipXY;
            if (o == 4) //BottomLeft
                return RotateFlipType.RotateNoneFlipY;
            if (o == 5) //LeftTop
                return RotateFlipType.Rotate90FlipX;
            if (o == 6) //RightTop
                return RotateFlipType.Rotate90FlipNone;
            if (o == 7) //RightBottom
                return RotateFlipType.Rotate90FlipY;
            if (o == 8) //LeftBottom
                return RotateFlipType.Rotate90FlipXY;

            return RotateFlipType.RotateNoneFlipNone; //TopLeft (what the image looks by default) [or] Unknown
        }

        private bool AnalizzaQrDevice(string letturabarcode)
        {
            string[] codici = letturabarcode.Split('|');
            int conta = 1;
            foreach (var word in codici)
            {
                switch (conta)
                {
                    case 1: qr_sn = word; conta++; break;
                    case 2: qr_ID = word; conta++; break;
                    case 3: qr_fw = word; conta++; break;
                }
            }

            int lungSN = qr_sn.Length;
            if (lungSN == 16)
            {
                qr_ID = qr_sn; // aggiusto la situazione di confusione che si può creare...
                qr_sn = "";
                qr_ClassicSmart = "S";
            }
            else
            {
                qr_ClassicSmart = "C";
            }

            this.Refresh();

            return true;
        }

        private void UC_SchedeLavorazione_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_XSLV.SF_Dbar_XSLV'. È possibile spostarla o rimuoverla se necessario.
            this.sF_Dbar_XSLVTableAdapter.Fill(this.ds_XSLV.SF_Dbar_XSLV);
            SettaForm();

            this.WindowState = FormWindowState.Maximized;

            tbx_ReadLabel_Device.Focus();
        }

        private void SettaForm()
        {
            if (this.ActiveControl == null)
            {
                tbx_ReadLabel_Device.Focus();
            }
            tbx_ReadLabel_Device.Text = "";
            tbx_ReadLabel_Device.Focus();

            gv_result.Visible = false;
            panel_pdf_xslv.Visible = false;
            panel_tipo_slv.Visible = false;
            panel_device.Visible = false;
            panel_result.Visible = false;
            if (tog_Slv.IsOn) { tog_Slv.Toggle(); };
            if (tog_Slv.IsOn) { lab_tog_slv.Text = "Standard / Collaudo"; } else { lab_tog_slv.Text = "Speciali"; }

        }

        private void but_AttivaProc_Click(object sender, EventArgs e)
        {
            SettaForm();

            pdf_viewer_xslv.CloseDocument();
            panel_device.Visible = false;
        }

        private void UC_SchedeLavorazione_Shown(object sender, EventArgs e)
        {
            tbx_ReadLabel_Device.Focus();
        }

        private void sFDbarXSLVBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            string nomefile_classic = path_classic;
            string nomefile_smartline = path_smartline;

            if (sFDbarXSLVBindingSource.Current != null)
            {
                DataRowView current = (DataRowView)sFDbarXSLVBindingSource.Current;
                string nomexslv = current["ArticoloComponente"].ToString();
                //nomefile_smartline = nomefile_smartline + nomexslv;

                string[] xslv_list_classic = Directory.GetFiles(path_classic, "*.pdf");
                string[] xslv_list_smartline = Directory.GetFiles(path_smartline, "*.pdf");

                Boolean trovato_cl = false;
                Boolean trovato_sl = false;
                foreach (string nomefile_cl in xslv_list_classic)
                {
                    string nomefile_cl_wpath = Path.GetFileName(nomefile_cl);
                    if (nomefile_cl_wpath.StartsWith(nomexslv))
                    {
                        trovato_cl = true;
                        nomefile_classic = nomefile_cl;
                    }
                    if (trovato_cl) { break; }
                }

                foreach (string nomefile_sl in xslv_list_smartline)
                {
                    string nomefile_sl_wpath = Path.GetFileName(nomefile_sl);
                    if (nomefile_sl_wpath.StartsWith(nomexslv))
                    {
                        trovato_sl = true;
                        nomefile_smartline = nomefile_sl;
                    }
                    if (trovato_sl) { break; }
                }

                if (trovato_cl)
                {
                    pdf_viewer_xslv.LoadDocument(nomefile_classic);
                    panel_pdf_xslv.Visible = true;
                    panel_tipo_slv.Visible = true;
                }
                if (trovato_sl)
                {
                    pdf_viewer_xslv.LoadDocument(nomefile_smartline);
                    panel_pdf_xslv.Visible = true;
                    panel_tipo_slv.Visible = true;
                }
            }
        }

        private void tog_Slv_Toggled(object sender, EventArgs e)
        {
            if (tog_Slv.IsOn)
            {
                filtroprincipale = filtro_articolo + " AND " + filtro_standard;
                lab_tog_slv.Text = "Standard / Collaudo";
            }
            else
            {
                filtroprincipale = filtro_articolo + " AND " + filtro_special;
                lab_tog_slv.Text = "Speciali";
            }
            sFDbarXSLVBindingSource.Filter = filtroprincipale;

        }
    }
}
