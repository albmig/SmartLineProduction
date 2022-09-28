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
    public partial class UC_ClassicDS : MetroFramework.Forms.MetroForm
    {
        public static string qr_read_Kit = "";                               // la lettura "pura" del barcode
        public static string PathTargetDS = @"\\192.168.0.8\sistematica\AREA_PRODOTTO\CLASSICLINE\DATASHEET\";

        public UC_ClassicDS()
        {
            InitializeComponent();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbx_ReadLabel_Device_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == '\t' || e.KeyChar == (char)13)
            //{
            //    e.Handled = true;
            //    //    qr_read_device = tbx_ReadLabel_Device.Text;
            //    //    AnalizzaQrDevice(qr_read_device);
            //    //    but_Reset.Focus();
            //}
        }

        private void tbx_ReadLabel_Device_Leave(object sender, EventArgs e)
        {
            //qr_read_device = tbx_ReadLabel_Device.Text;
            //if (AnalizzaQrDevice(qr_read_device))
            //{
            //    but_Reset.Focus();

            //    string filtro = "ArticoloComposto = " + "'" + qr_read_device + "'";
            //    sFDbarXSLVBindingSource.Filter = filtro;
            //    gv_result.Visible = true;

            //    if (sFDbarXSLVBindingSource.Count == 0)
            //    {
            //        pdf_viewer_xslv.LoadDocument(@"Resources\NO_XSLV.pdf");
            //    }

            //    //Carica Immagine
            //    string famdevice = qr_read_device.Substring(0, 3);
            //    if (famdevice == "XSB")
            //    {
            //        famdevice = qr_read_device.Substring(0, 5);
            //    }
            //    //Carica immagine scheda
            //    string sigla = qr_read_device.Substring(7, 2);
            //    string path_SL = WEB_path_image + famdevice + @"\" + sigla + @"\" + qr_read_device + @"\" + qr_read_device + "_Full.png";
            //    string path_CL = CLASSIC_path_image + @"\" + qr_read_device + ".jpg";
            //    string path_prodotto_SL = SMARTLINE_path_image + @"\" + qr_read_device + ".jpg";
            //    panel_device.Visible = true;

            //    if (File.Exists(path_SL))
            //    {
            //        Device_Image.Image = Image.FromFile(path_SL);
            //        Device_Image.Image.RotateFlip(Rotate(Image.FromFile(path_SL)));
            //    }
            //    else
            //    if (File.Exists(path_CL))
            //    {
            //        Device_Image.Image = Image.FromFile(path_CL);
            //        Device_Image.Image.RotateFlip(Rotate(Image.FromFile(path_CL)));

            //    }
            //    else
            //    if (File.Exists(path_prodotto_SL))
            //    {
            //        Device_Image.Image = Image.FromFile(path_prodotto_SL);
            //        Device_Image.Image.RotateFlip(Rotate(Image.FromFile(path_prodotto_SL)));
            //    }
            //    else
            //    {
            //        Device_Image.Image = Properties.Resources.ImageNotPresent;
            //    }
            //}
        }

        private bool AnalizzaQrDevice(string letturabarcode)
        {
            return true;
            //string[] codici = letturabarcode.Split('|');
            //int conta = 1;
            //foreach (var word in codici)
            //{
            //    switch (conta)
            //    {
            //        case 1: qr_sn = word; conta++; break;
            //        case 2: qr_ID = word; conta++; break;
            //        case 3: qr_fw = word; conta++; break;
            //    }
            //}

            //int lungSN = qr_sn.Length;
            //if (lungSN == 16)
            //{
            //    qr_ID = qr_sn; // aggiusto la situazione di confusione che si può creare...
            //    qr_sn = "";
            //    qr_ClassicSmart = "S";
            //}
            //else
            //{
            //    qr_ClassicSmart = "C";
            //}

            //this.Refresh();

            //return true;
        }

        private void UC_ClassicDS_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            // TODO: questa riga di codice carica i dati nella tabella 'ds_ClassicDS.dt_ClassicFiles'. È possibile spostarla o rimuoverla se necessario.
            this.dt_ClassicFilesTableAdapter.Fill(this.ds_ClassicDS.dt_ClassicFiles);

            //StartTimer.Enabled = true;

            SettaForm();

            this.WindowState = FormWindowState.Maximized;

            tbx_ReadLabel_Device.Focus();

            Cursor.Current = Cursors.Default;
        }

        private void SettaForm()
        {
            if (this.ActiveControl == null)
            {
                tbx_ReadLabel_Device.Focus();
            }
            tbx_ReadLabel_Device.Text = "";
            tbx_ReadLabel_Device.Focus();

            //gv_result.Visible = false;
            //panel_pdf_ds.Visible = false;
            gv_result.Visible = true;
            panel_pdf_ds.Visible = true;

            panel_progress.Visible = false;
        }

        private void but_AttivaProc_Click(object sender, EventArgs e)
        {
            tbx_ReadLabel_Device.Text = "";
            pdf_viewer_ds.CloseDocument();
        }

        private void UC_ClassicDS_Shown(object sender, EventArgs e)
        {
            tbx_ReadLabel_Device.Focus();
        }

        private void aggiornaArchiviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_SyncroDS uC_SyncroDS = new UC_SyncroDS();
            uC_SyncroDS.Show();

            StartTimer.Enabled = true;
      
            Cursor.Current = Cursors.Default;
        }

        private void tbx_ReadLabel_Device_TextChanged(object sender, EventArgs e)
        {
            int len = tbx_ReadLabel_Device.Text.Length;
            string new_codice = "";
            char[] charArr = tbx_ReadLabel_Device.Text.ToCharArray();
            for (int i = len-1; i >= 0; i--)
            {
                if (charArr[i] != '\t' && charArr[i] != (char)13 && charArr[i] != '\r' && charArr[i] != '\n')
                {
                    new_codice = tbx_ReadLabel_Device.Text.Substring(0, i+1);
                    break;
                }
            }

            tbx_ReadLabel_Device.Text = new_codice;
            tbx_ReadLabel_Device.Refresh();

            //dtClassicFilesBindingSource.Filter = string.Format("[CDS_SourceFileName] LIKE '%{1}%'", "CDS_SourceFileName", tbx_ReadLabel_Device.Text);
            dtClassicFilesBindingSource.Filter = string.Format("[CDS_SourceFileName] LIKE '%{1}%'", "CDS_SourceFileName", new_codice);
        }

        private void GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            progress_Load.Visible = true;
            int contapdf = 0;
            int incrpdf = 0;
            //ds_ClassicDS.dt_ClassicFiles.Clear();

            var resultData = Directory.GetFiles(path, searchPattern, SearchOption.AllDirectories)
                .Select(x => new { FileName = Path.GetFileName(x), FilePath = x });
            
            contapdf = resultData.Count();
            progress_Load.Maximum = contapdf;
            foreach (var item in resultData)
            {
                incrpdf++;
                progress_Load.Value = incrpdf;
                progress_Load.Refresh();

                //DataRow newrow = ds_ClassicDS.dt_ClassicFiles.NewRow();
                var newrow = ds_ClassicDS.dt_ClassicFiles.NewRow();

                newrow["CDS_SourceFileName"] = item.FileName;
                newrow["CDS_SourceFilePath"] = item.FilePath;
                //newrow["CDS_SourceLastModify"] = DBNull;
                newrow["CDS_TargetFileExists"] = false;
                //newrow["CDS_TargetLastModify"] = DBNull;
                newrow["CDS_FileCopy"] = false;

                ds_ClassicDS.dt_ClassicFiles.Rows.Add(newrow);
                dt_ClassicFilesTableAdapter.Update(newrow);
            }

            progress_Load.Visible = false;

            gv_result.Refresh();
        }

        private void dtClassicFilesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (dtClassicFilesBindingSource.Current != null)
            {
                DataRowView current = (DataRowView)dtClassicFilesBindingSource.Current;
                string nomepdf = PathTargetDS + current["CDS_SourceFileName"].ToString();

                try
                {
                    pdf_viewer_ds.LoadDocument(nomepdf);
                }
                catch
                {

                }
                panel_pdf_ds.Visible = true;
            }
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            StartTimer.Enabled = false;

            Cursor.Current = Cursors.WaitCursor;
            panel_progress.Visible = true;

            //UC_SyncroDS uC_SyncroDS = new UC_SyncroDS();
            //uC_SyncroDS.Show();

            GetFiles(PathTargetDS, "*.pdf", SearchOption.TopDirectoryOnly);

            this.dt_ClassicFilesTableAdapter.Fill(this.ds_ClassicDS.dt_ClassicFiles);

            gv_result.Visible = true;

            dtClassicFilesBindingSource.MoveFirst();

            panel_progress.Visible = false;

            Cursor.Current = Cursors.Default;

        }

        private void riletturaElencoPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dt_ClassicFilesTableAdapter.DeleteQuery();

            StartTimer.Enabled = true;

        }
    }
}
