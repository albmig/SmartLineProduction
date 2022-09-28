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
    public partial class UC_RealTime : MetroFramework.Forms.MetroForm
    {
        List<String> IconList = new List<String>();

        private string displayform = "V"; // V-View/E-Edit

        public UC_RealTime()
        {
            InitializeComponent();
        }

        /// Funzioni
        private void LeggiIcone()
        {
            string pathicons = @"\\192.168.0.8\sistematica\AREA_FIRMWARE\SmartLine\Compilati\RT_Icons";
            string[] icons = Directory.GetFiles(pathicons, "*.png");
            int contaicone = icons.Count();
            for (int i = 0; i < contaicone; i++)
            {
                icons[i] = Path.GetFileName(icons[i]);
                IconList.Add(icons[i]);
            }
            //cb_icone.Items.AddRange(icons);
        }

        private void CreaListeIcone_Digital()
        {
            List<String> Icons_00_0 = new List<String>(IconList);
            List<String> Icons_01_0 = new List<String>(IconList);
            List<String> Icons_02_0 = new List<String>(IconList);
            List<String> Icons_03_0 = new List<String>(IconList);
            List<String> Icons_04_0 = new List<String>(IconList);
            List<String> Icons_05_0 = new List<String>(IconList);
            List<String> Icons_06_0 = new List<String>(IconList);
            List<String> Icons_07_0 = new List<String>(IconList);
            List<String> Icons_08_0 = new List<String>(IconList);
            List<String> Icons_09_0 = new List<String>(IconList);
            List<String> Icons_10_0 = new List<String>(IconList);
            List<String> Icons_11_0 = new List<String>(IconList);
            List<String> Icons_12_0 = new List<String>(IconList);
            List<String> Icons_13_0 = new List<String>(IconList);
            List<String> Icons_14_0 = new List<String>(IconList);
            List<String> Icons_15_0 = new List<String>(IconList);
            List<String> Icons_00_1 = new List<String>(IconList);
            List<String> Icons_01_1 = new List<String>(IconList);
            List<String> Icons_02_1 = new List<String>(IconList);
            List<String> Icons_03_1 = new List<String>(IconList);
            List<String> Icons_04_1 = new List<String>(IconList);
            List<String> Icons_05_1 = new List<String>(IconList);
            List<String> Icons_06_1 = new List<String>(IconList);
            List<String> Icons_07_1 = new List<String>(IconList);
            List<String> Icons_08_1 = new List<String>(IconList);
            List<String> Icons_09_1 = new List<String>(IconList);
            List<String> Icons_10_1 = new List<String>(IconList);
            List<String> Icons_11_1 = new List<String>(IconList);
            List<String> Icons_12_1 = new List<String>(IconList);
            List<String> Icons_13_1 = new List<String>(IconList);
            List<String> Icons_14_1 = new List<String>(IconList);
            List<String> Icons_15_1 = new List<String>(IconList);

            Icons_00_0.Add("");
            Icons_01_0.Add("");
            Icons_02_0.Add("");
            Icons_03_0.Add("");
            Icons_04_0.Add("");
            Icons_05_0.Add("");
            Icons_06_0.Add("");
            Icons_07_0.Add("");
            Icons_08_0.Add("");
            Icons_09_0.Add("");
            Icons_10_0.Add("");
            Icons_11_0.Add("");
            Icons_12_0.Add("");
            Icons_13_0.Add("");
            Icons_14_0.Add("");
            Icons_15_0.Add("");
            Icons_00_1.Add("");
            Icons_01_1.Add("");
            Icons_02_1.Add("");
            Icons_03_1.Add("");
            Icons_04_1.Add("");
            Icons_05_1.Add("");
            Icons_06_1.Add("");
            Icons_07_1.Add("");
            Icons_08_1.Add("");
            Icons_09_1.Add("");
            Icons_10_1.Add("");
            Icons_11_1.Add("");
            Icons_12_1.Add("");
            Icons_13_1.Add("");
            Icons_14_1.Add("");
            Icons_15_1.Add("");

            cb_00_icon_0.DataSource = Icons_00_0;
            cb_01_icon_0.DataSource = Icons_01_0;
            cb_02_icon_0.DataSource = Icons_02_0;
            cb_03_icon_0.DataSource = Icons_03_0;
            cb_04_icon_0.DataSource = Icons_04_0;
            cb_05_icon_0.DataSource = Icons_05_0;
            cb_06_icon_0.DataSource = Icons_06_0;
            cb_07_icon_0.DataSource = Icons_07_0;
            cb_08_icon_0.DataSource = Icons_08_0;
            cb_09_icon_0.DataSource = Icons_09_0;
            cb_10_icon_0.DataSource = Icons_10_0;
            cb_11_icon_0.DataSource = Icons_11_0;
            cb_12_icon_0.DataSource = Icons_12_0;
            cb_13_icon_0.DataSource = Icons_13_0;
            cb_14_icon_0.DataSource = Icons_14_0;
            cb_15_icon_0.DataSource = Icons_15_0;

            cb_00_icon_1.DataSource = Icons_00_1;
            cb_01_icon_1.DataSource = Icons_01_1;
            cb_02_icon_1.DataSource = Icons_02_1;
            cb_03_icon_1.DataSource = Icons_03_1;
            cb_04_icon_1.DataSource = Icons_04_1;
            cb_05_icon_1.DataSource = Icons_05_1;
            cb_06_icon_1.DataSource = Icons_06_1;
            cb_07_icon_1.DataSource = Icons_07_1;
            cb_08_icon_1.DataSource = Icons_08_1;
            cb_09_icon_1.DataSource = Icons_09_1;
            cb_10_icon_1.DataSource = Icons_10_1;
            cb_11_icon_1.DataSource = Icons_11_1;
            cb_12_icon_1.DataSource = Icons_12_1;
            cb_13_icon_1.DataSource = Icons_13_1;
            cb_14_icon_1.DataSource = Icons_14_1;
            cb_15_icon_1.DataSource = Icons_15_1;
        }

        private void LoadIcons()
        {
            DataRowView drview = (DataRowView)firmwareUIDigitalMessagesBindingSource.Current;

            if ((drview == null) || (drview["UI_Dg_Bit_00_Icon_0"] == null) || (drview["UI_Dg_Bit_00_Icon_0"] == "")) { cb_00_icon_0.SelectedIndex = cb_00_icon_0.Items.IndexOf(""); } else { cb_00_icon_0.SelectedIndex = cb_00_icon_0.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_00_Icon_0"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_01_Icon_0"] == null) || (drview["UI_Dg_Bit_01_Icon_0"] == "")) { cb_01_icon_0.SelectedIndex = cb_01_icon_0.Items.IndexOf(""); } else { cb_01_icon_0.SelectedIndex = cb_01_icon_0.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_01_Icon_0"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_02_Icon_0"] == null) || (drview["UI_Dg_Bit_02_Icon_0"] == "")) { cb_02_icon_0.SelectedIndex = cb_02_icon_0.Items.IndexOf(""); } else { cb_02_icon_0.SelectedIndex = cb_02_icon_0.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_02_Icon_0"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_03_Icon_0"] == null) || (drview["UI_Dg_Bit_03_Icon_0"] == "")) { cb_03_icon_0.SelectedIndex = cb_03_icon_0.Items.IndexOf(""); } else { cb_03_icon_0.SelectedIndex = cb_03_icon_0.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_03_Icon_0"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_04_Icon_0"] == null) || (drview["UI_Dg_Bit_04_Icon_0"] == "")) { cb_04_icon_0.SelectedIndex = cb_04_icon_0.Items.IndexOf(""); } else { cb_04_icon_0.SelectedIndex = cb_04_icon_0.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_04_Icon_0"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_05_Icon_0"] == null) || (drview["UI_Dg_Bit_05_Icon_0"] == "")) { cb_05_icon_0.SelectedIndex = cb_05_icon_0.Items.IndexOf(""); } else { cb_05_icon_0.SelectedIndex = cb_05_icon_0.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_05_Icon_0"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_06_Icon_0"] == null) || (drview["UI_Dg_Bit_06_Icon_0"] == "")) { cb_06_icon_0.SelectedIndex = cb_06_icon_0.Items.IndexOf(""); } else { cb_06_icon_0.SelectedIndex = cb_06_icon_0.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_06_Icon_0"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_07_Icon_0"] == null) || (drview["UI_Dg_Bit_07_Icon_0"] == "")) { cb_07_icon_0.SelectedIndex = cb_07_icon_0.Items.IndexOf(""); } else { cb_07_icon_0.SelectedIndex = cb_07_icon_0.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_07_Icon_0"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_08_Icon_0"] == null) || (drview["UI_Dg_Bit_08_Icon_0"] == "")) { cb_08_icon_0.SelectedIndex = cb_08_icon_0.Items.IndexOf(""); } else { cb_08_icon_0.SelectedIndex = cb_08_icon_0.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_08_Icon_0"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_09_Icon_0"] == null) || (drview["UI_Dg_Bit_09_Icon_0"] == "")) { cb_09_icon_0.SelectedIndex = cb_09_icon_0.Items.IndexOf(""); } else { cb_09_icon_0.SelectedIndex = cb_09_icon_0.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_09_Icon_0"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_10_Icon_0"] == null) || (drview["UI_Dg_Bit_10_Icon_0"] == "")) { cb_10_icon_0.SelectedIndex = cb_10_icon_0.Items.IndexOf(""); } else { cb_10_icon_0.SelectedIndex = cb_10_icon_0.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_10_Icon_0"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_11_Icon_0"] == null) || (drview["UI_Dg_Bit_11_Icon_0"] == "")) { cb_11_icon_0.SelectedIndex = cb_11_icon_0.Items.IndexOf(""); } else { cb_11_icon_0.SelectedIndex = cb_11_icon_0.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_11_Icon_0"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_12_Icon_0"] == null) || (drview["UI_Dg_Bit_12_Icon_0"] == "")) { cb_12_icon_0.SelectedIndex = cb_12_icon_0.Items.IndexOf(""); } else { cb_12_icon_0.SelectedIndex = cb_12_icon_0.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_12_Icon_0"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_13_Icon_0"] == null) || (drview["UI_Dg_Bit_13_Icon_0"] == "")) { cb_13_icon_0.SelectedIndex = cb_13_icon_0.Items.IndexOf(""); } else { cb_13_icon_0.SelectedIndex = cb_13_icon_0.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_13_Icon_0"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_14_Icon_0"] == null) || (drview["UI_Dg_Bit_14_Icon_0"] == "")) { cb_14_icon_0.SelectedIndex = cb_14_icon_0.Items.IndexOf(""); } else { cb_14_icon_0.SelectedIndex = cb_14_icon_0.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_14_Icon_0"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_15_Icon_0"] == null) || (drview["UI_Dg_Bit_15_Icon_0"] == "")) { cb_15_icon_0.SelectedIndex = cb_15_icon_0.Items.IndexOf(""); } else { cb_15_icon_0.SelectedIndex = cb_15_icon_0.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_15_Icon_0"])); }

            if ((drview == null) || (drview["UI_Dg_Bit_00_Icon_1"] == null) || (drview["UI_Dg_Bit_00_Icon_1"] == "")) { cb_00_icon_1.SelectedIndex = cb_00_icon_1.Items.IndexOf(""); } else { cb_00_icon_1.SelectedIndex = cb_00_icon_1.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_00_Icon_1"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_01_Icon_1"] == null) || (drview["UI_Dg_Bit_01_Icon_1"] == "")) { cb_01_icon_1.SelectedIndex = cb_01_icon_1.Items.IndexOf(""); } else { cb_01_icon_1.SelectedIndex = cb_01_icon_1.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_01_Icon_1"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_02_Icon_1"] == null) || (drview["UI_Dg_Bit_02_Icon_1"] == "")) { cb_02_icon_1.SelectedIndex = cb_02_icon_1.Items.IndexOf(""); } else { cb_02_icon_1.SelectedIndex = cb_02_icon_1.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_02_Icon_1"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_03_Icon_1"] == null) || (drview["UI_Dg_Bit_03_Icon_1"] == "")) { cb_03_icon_1.SelectedIndex = cb_03_icon_1.Items.IndexOf(""); } else { cb_03_icon_1.SelectedIndex = cb_03_icon_1.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_03_Icon_1"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_04_Icon_1"] == null) || (drview["UI_Dg_Bit_04_Icon_1"] == "")) { cb_04_icon_1.SelectedIndex = cb_04_icon_1.Items.IndexOf(""); } else { cb_04_icon_1.SelectedIndex = cb_04_icon_1.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_04_Icon_1"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_05_Icon_1"] == null) || (drview["UI_Dg_Bit_05_Icon_1"] == "")) { cb_05_icon_1.SelectedIndex = cb_05_icon_1.Items.IndexOf(""); } else { cb_05_icon_1.SelectedIndex = cb_05_icon_1.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_05_Icon_1"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_06_Icon_1"] == null) || (drview["UI_Dg_Bit_06_Icon_1"] == "")) { cb_06_icon_1.SelectedIndex = cb_06_icon_1.Items.IndexOf(""); } else { cb_06_icon_1.SelectedIndex = cb_06_icon_1.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_06_Icon_1"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_07_Icon_1"] == null) || (drview["UI_Dg_Bit_07_Icon_1"] == "")) { cb_07_icon_1.SelectedIndex = cb_07_icon_1.Items.IndexOf(""); } else { cb_07_icon_1.SelectedIndex = cb_07_icon_1.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_07_Icon_1"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_08_Icon_1"] == null) || (drview["UI_Dg_Bit_08_Icon_1"] == "")) { cb_08_icon_1.SelectedIndex = cb_08_icon_1.Items.IndexOf(""); } else { cb_08_icon_1.SelectedIndex = cb_08_icon_1.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_08_Icon_1"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_09_Icon_1"] == null) || (drview["UI_Dg_Bit_09_Icon_1"] == "")) { cb_09_icon_1.SelectedIndex = cb_09_icon_1.Items.IndexOf(""); } else { cb_09_icon_1.SelectedIndex = cb_09_icon_1.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_09_Icon_1"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_10_Icon_1"] == null) || (drview["UI_Dg_Bit_10_Icon_1"] == "")) { cb_10_icon_1.SelectedIndex = cb_10_icon_1.Items.IndexOf(""); } else { cb_10_icon_1.SelectedIndex = cb_10_icon_1.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_10_Icon_1"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_11_Icon_1"] == null) || (drview["UI_Dg_Bit_11_Icon_1"] == "")) { cb_11_icon_1.SelectedIndex = cb_11_icon_1.Items.IndexOf(""); } else { cb_11_icon_1.SelectedIndex = cb_11_icon_1.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_11_Icon_1"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_12_Icon_1"] == null) || (drview["UI_Dg_Bit_12_Icon_1"] == "")) { cb_12_icon_1.SelectedIndex = cb_12_icon_1.Items.IndexOf(""); } else { cb_12_icon_1.SelectedIndex = cb_12_icon_1.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_12_Icon_1"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_13_Icon_1"] == null) || (drview["UI_Dg_Bit_13_Icon_1"] == "")) { cb_13_icon_1.SelectedIndex = cb_13_icon_1.Items.IndexOf(""); } else { cb_13_icon_1.SelectedIndex = cb_13_icon_1.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_13_Icon_1"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_14_Icon_1"] == null) || (drview["UI_Dg_Bit_14_Icon_1"] == "")) { cb_14_icon_1.SelectedIndex = cb_14_icon_1.Items.IndexOf(""); } else { cb_14_icon_1.SelectedIndex = cb_14_icon_1.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_14_Icon_1"])); }
            if ((drview == null) || (drview["UI_Dg_Bit_15_Icon_1"] == null) || (drview["UI_Dg_Bit_15_Icon_1"] == "")) { cb_15_icon_1.SelectedIndex = cb_15_icon_1.Items.IndexOf(""); } else { cb_15_icon_1.SelectedIndex = cb_15_icon_1.Items.IndexOf(Convert.ToString(drview["UI_Dg_Bit_15_Icon_1"])); }
        }

        //////////////////////////////////////////////////////////////

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_RealTime_Load(object sender, EventArgs e)
        {
            LeggiIcone();
            CreaListeIcone_Digital();

            // TODO: questa riga di codice carica i dati nella tabella 'ds_RealTime.UI_EventLog_Messages'. È possibile spostarla o rimuoverla se necessario.
            this.uI_EventLog_MessagesTableAdapter.Fill(this.ds_RealTime.UI_EventLog_Messages);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_RealTime.UI_Digital_Messages'. È possibile spostarla o rimuoverla se necessario.
            this.uI_Digital_MessagesTableAdapter.Fill(this.ds_RealTime.UI_Digital_Messages);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_RealTime.UI_Analog_Messages'. È possibile spostarla o rimuoverla se necessario.
            this.uI_Analog_MessagesTableAdapter.Fill(this.ds_RealTime.UI_Analog_Messages);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_RealTime.Firmware'. È possibile spostarla o rimuoverla se necessario.
            this.firmwareTableAdapter.Fill(this.ds_RealTime.Firmware);
            SettaForm();
            CBUI_An_Icon_Name.DataSource = IconList;

            firmwareBindingSource.MoveFirst();

            this.WindowState = FormWindowState.Maximized;
        }

        private void SettaForm()
        {
            if (displayform == "V")
            {
                gv_AnalogMessages.Enabled = false;
                panel_digital_messages.Enabled = false;
                gv_EventLogMessages.Enabled = false;
                tabbed_pages.Enabled = true;

                menu_edit.Enabled = true;
                menu_salva.Enabled = false;
                menu_annulla.Enabled = false;
            }

            if (displayform == "E")
            {
                gv_AnalogMessages.Enabled = true;
                panel_digital_messages.Enabled = true;
                gv_EventLogMessages.Enabled = true;

                if (tabbed_pages.SelectedTabPage.Name == "tab_Analog") { gv_AnalogMessages.Focus(); }
                if (tabbed_pages.SelectedTabPage.Name == "tab_Digital") { panel_digital_messages.Focus(); }
                if (tabbed_pages.SelectedTabPage.Name == "tab_Event") { gv_EventLogMessages.Focus(); }
                menu_edit.Enabled = false;
                menu_salva.Enabled = true;
                menu_annulla.Enabled = true;
            }
        }

        private void but_Preview_Click(object sender, EventArgs e)
        {
            ds_RealTime.dt_tmp_Preview.Clear();


            DataView dv_preview = new DataView(ds_RealTime.UI_Analog_Messages);
            var item = this.cb_Fw_Code.GetItemText(this.cb_Fw_Code.SelectedItem);
            dv_preview.RowFilter = "UI_An_SW_Code = " + "'" + item.ToString() + "'";
            dv_preview.Sort = "UI_An_DisplayOrder asc, UI_An_DisplayOrder_GroupElements asc";

            bool rottura = false;
            int numorder = 0;
            foreach (DataRowView rowView in dv_preview)
            {
                DataRow row = rowView.Row;

                //Verifica rottura
                if ((int)row["UI_An_DisplayOrder"] != numorder)
                {
                    rottura = true;
                }

                if (rottura)
                {
                    DataRow rowrottura = ds_RealTime.dt_tmp_Preview.NewRow();
                    rowrottura["tmp_Col_1"] = string.Concat(Enumerable.Repeat("-", 10));
                    rowrottura["tmp_Col_2"] = string.Concat(Enumerable.Repeat("-", 30));
                    rowrottura["tmp_Col_3"] = string.Concat(Enumerable.Repeat("-", 10));
                    ds_RealTime.dt_tmp_Preview.Rows.Add(rowrottura);

                    DataRow titlerow = ds_RealTime.dt_tmp_Preview.NewRow();
                    titlerow["tmp_Col_1"] = string.Empty;
                    titlerow["tmp_Col_2"] = row["UI_An_Group"];
                    titlerow["tmp_Col_3"] = string.Empty;
                    ds_RealTime.dt_tmp_Preview.Rows.Add(titlerow);

                    DataRow detailrow = ds_RealTime.dt_tmp_Preview.NewRow();
                    detailrow["tmp_Col_1"] = row["UI_An_Icon_Name"];
                    detailrow["tmp_Col_2"] = row["UI_An_Desc"];
                    detailrow["tmp_Col_3"] = row["UI_An_Format"];
                    ds_RealTime.dt_tmp_Preview.Rows.Add(detailrow);

                    rottura = false;
                    numorder = (int)row["UI_An_DisplayOrder"];
                    continue;
                }

                // Aggiungi riga
                DataRow newrow = ds_RealTime.dt_tmp_Preview.NewRow();
                newrow["tmp_Col_1"] = row["UI_An_Icon_Name"];
                newrow["tmp_Col_2"] = row["UI_An_Desc"];
                newrow["tmp_Col_3"] = row["UI_An_Format"];
                ds_RealTime.dt_tmp_Preview.Rows.Add(newrow);

                numorder = (int)row["UI_An_DisplayOrder"];
            }

            //Chiusura
            DataRow rowclose = ds_RealTime.dt_tmp_Preview.NewRow();
            rowclose["tmp_Col_1"] = string.Concat(Enumerable.Repeat("-", 10));
            rowclose["tmp_Col_2"] = string.Concat(Enumerable.Repeat("-", 30));
            rowclose["tmp_Col_3"] = string.Concat(Enumerable.Repeat("-", 10));
            ds_RealTime.dt_tmp_Preview.Rows.Add(rowclose);

            using (var form = new UC_RealTime_Preview(ds_RealTime.dt_tmp_Preview))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                }
            }

        }

        private void firmwareUIDigitalMessagesBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            LoadIcons();
        }

        private void menu_edit_Click(object sender, EventArgs e)
        {
            displayform = "E";
            SettaForm();
        }

        private void eliminaRigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)firmwareUIEventLogMessagesBindingSource.Current;
            string DelRec = "Vuoi cancellare l'evento:\n\n" + drview["UI_EL_Desc_it"].ToString();

            DialogResult dialogResult = MessageBox.Show(DelRec, "Conferma cancellazione", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                firmwareUIEventLogMessagesBindingSource.RemoveCurrent();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
