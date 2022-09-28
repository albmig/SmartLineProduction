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
    public partial class UC_SyncroDS : MetroFramework.Forms.MetroForm
    {
        public string PathSourceDS = @"\\192.168.0.8\ricerca e sviluppo\Documentazione\Documentazione clienti";
        public string PathTargetDS = @"\\192.168.0.8\sistematica\AREA_PRODOTTO\CLASSICLINE\DATASHEET";

        public UC_SyncroDS()
        {
            InitializeComponent();
        }

        private void GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            //ds_ClassicDS.dt_ClassicFiles.Clear();
            this.dt_ClassicFilesTableAdapter.DeleteQuery();
            gv_Datasheet.Refresh();

            var resultData = Directory.GetFiles(path, searchPattern, SearchOption.AllDirectories)
                .Select(x => new { FileName = Path.GetFileName(x), FilePath = x });
            int contarighe = 0;
            foreach (var item in resultData)
            {
                contarighe++;
                lab_FaseRicerca.Text = "Fase di ricerca - avviata " + "- N° " + contarighe.ToString() + " di " + resultData.Count().ToString();
                lab_FaseRicerca.Refresh();

                string maiuscfilename = item.FileName.ToUpper();
                string maiuscfilepath = item.FilePath.ToUpper();
                if (!maiuscfilename.Contains("KIT")) continue;
                if (maiuscfilepath.Contains("OBSOL")) continue;
                if (maiuscfilepath.Contains("BUTTAR")) continue;
                if (maiuscfilepath.Contains("OBSOL")) continue;
                if (maiuscfilepath.Contains("COSTIFICAZ")) continue;

                int lenpath = PathSourceDS.Length;
                int lenfilename = item.FilePath.Length;

                FileInfo fi_source = new FileInfo(item.FilePath);
                DateTime dtSourceUltimaModifica = fi_source.LastWriteTime;

                //DataRow newrow = ds_ClassicDS.dt_ClassicFiles.NewRow();
                var newrow = ds_ClassicDS.dt_ClassicFiles.NewRow();

                newrow["CDS_SourceFileName"] = item.FileName;
                newrow["CDS_SourceFilePath"] = item.FilePath.Substring(lenpath);
                newrow["CDS_SourceLastModify"] = dtSourceUltimaModifica;

                //Verifica se già esiste il file nel target folder
                string targetfile = PathTargetDS + @"\" + item.FileName;
                if (File.Exists(targetfile))
                {
                    newrow["CDS_TargetFileExists"] = true;

                    FileInfo fi_target = new FileInfo(targetfile);
                    DateTime dtTargetUltimaModifica = fi_target.LastWriteTime;
                    newrow["CDS_TargetLastModify"] = dtTargetUltimaModifica;

                    //Confronta files
                    if (dtSourceUltimaModifica > dtTargetUltimaModifica)
                    {
                        newrow["CDS_FileCopy"] = true;
                    }
                    else
                    {
                        newrow["CDS_FileCopy"] = false;
                    }
                }
                else
                {
                    newrow["CDS_TargetFileExists"] = false;
                    newrow["CDS_FileCopy"] = true;
                }

                ds_ClassicDS.dt_ClassicFiles.Rows.Add(newrow);
                dt_ClassicFilesTableAdapter.Update(newrow);
            }

            gv_Datasheet.Refresh();
        }

        private void CopyFiles()
        {
            DataView dv = new DataView(ds_ClassicDS.dt_ClassicFiles);
            dv.RowFilter = "CDS_FileCopy = 1";

            foreach (DataRowView sourcerow in dv)
            {
                lab_CopyFile.Visible = true;
                lab_CopyFile.Text = "Copia del file: " + sourcerow["CDS_SourceFilePath"];
                lab_CopyFile.Refresh();

                string sourcefile = PathSourceDS + sourcerow["CDS_SourceFilePath"];
                string targetfile = PathTargetDS + @"\" + sourcerow["CDS_SourceFileName"];

                try
                {
                    File.Copy(sourcefile, targetfile, true);
                }
                catch (IOException copyError)
                {
                    MessageBox.Show(copyError.Message);
                }
            }

            lab_FaseCopia.Text = "Fase di copia - TERMINATA";

            lab_CopyFile.Visible = false;
        }

        private void UC_SyncroDS_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_ClassicDS.dt_ClassicFiles'. È possibile spostarla o rimuoverla se necessario.
            this.dt_ClassicFilesTableAdapter.Fill(this.ds_ClassicDS.dt_ClassicFiles);
            SettaScreen();
            StartTimer.Enabled = true;
        }

        private void SettaScreen()
        {
            lab_FaseRicerca.Visible = false;
            lab_FaseRicerca.Text = "Fase di ricerca - avviata";
            lab_FaseCopia.Visible = false;
            gv_Datasheet.Visible = false;
        }

        private void StartSyncro()
        {
            Cursor.Current = Cursors.WaitCursor;

            Application.UseWaitCursor = true;

            //ds_ClassicDS.dt_ClassicFiles.Clear();
            this.dt_ClassicFilesTableAdapter.DeleteQuery();

            gv_Datasheet.Refresh();

            lab_FaseRicerca.Visible = true;
            lab_FaseRicerca.Text = "Fase di ricerca - avviata";
            lab_FaseRicerca.Refresh();

            GetFiles(PathSourceDS, "*.pdf", SearchOption.AllDirectories);
            gv_Datasheet.Visible = true;

            lab_FaseRicerca.Text = "Fase di ricerca - TERMINATA";
            lab_FaseRicerca.Refresh();

            lab_FaseCopia.Visible = true;
            lab_FaseCopia.Text = "Fase di copia - avviata";
            lab_FaseCopia.Refresh();

            CopyFiles();

            Cursor.Current = Cursors.Default;
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            StartTimer.Enabled = false;
            StartSyncro();
            EndTimer.Enabled = true;
        }

        private void EndTimer_Tick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            Application.UseWaitCursor = false;
            this.Close();
        }
    }
}
