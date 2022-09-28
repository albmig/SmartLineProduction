using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace SmartLineProduction
{
    public partial class UC_Projects : MetroFramework.Forms.MetroForm
    {

        private string displayform = "V"; // V-View/I-Insert/E-Edit

        public UC_Projects()
        {
            InitializeComponent();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_Projects_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Proj.Projects_Attachments'. È possibile spostarla o rimuoverla se necessario.
            this.projects_AttachmentsTableAdapter.Fill(this.ds_Proj.Projects_Attachments);
            Cursor.Current = Cursors.WaitCursor;

            // TODO: questa riga di codice carica i dati nella tabella 'ds_Proj.Projects_Attachments'. È possibile spostarla o rimuoverla se necessario.
            this.projects_AttachmentsTableAdapter.Fill(this.ds_Proj.Projects_Attachments);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Proj.TabelleCodici'. È possibile spostarla o rimuoverla se necessario.
            this.tabelleCodiciTableAdapter.Fill(this.ds_Proj.TabelleCodici);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Proj.Projects_Anag'. È possibile spostarla o rimuoverla se necessario.
            this.projects_AnagTableAdapter.Fill(this.ds_Proj.Projects_Anag);

            PreparaForm();

            cb_Cliente.DataBindings.Add("SelectedValue", ds_Proj.Projects_Anag, "Proj_ID_Cliente");
        }

        private void PreparaForm()
        {
            switch (displayform)
            {
                case "V":
                    this.projects_AnagTableAdapter.Fill(this.ds_Proj.Projects_Anag);

                    projectsAnagBindingSource.ResumeBinding();
                    gv_Projects.Enabled = true;

                    pan_Menu_comandi.Enabled = true;
                    pan_Menu_salva.Enabled = false;
                    pan_Menu_exit.Enabled = true;

                    projectsAnagBindingSource.MoveFirst();
                    break;
                case "I":
                    projectsAnagBindingSource.SuspendBinding();

                    gv_Projects.Enabled = false;

                    pan_Menu_comandi.Enabled = false;
                    pan_Menu_salva.Enabled = true;
                    pan_Menu_exit.Enabled = false;

                    break;
                case "E":
                    pan_Menu_comandi.Enabled = false;
                    pan_Menu_salva.Enabled = true;
                    pan_Menu_exit.Enabled = false;

                    break;
            }
        }

        private void cb_Cliente_Leave(object sender, EventArgs e)
        {

        }

        private void gv_Attachment_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void gv_Attachment_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files =(string[])e.Data.GetData(DataFormats.FileDrop);

                OutputFileInformation(files);

            }
        }

        private void OutputFileInformation(string[] files)
        {
            foreach(string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

            }

        }
    }
}
