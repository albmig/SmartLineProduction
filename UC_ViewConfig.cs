using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace SmartLineProduction
{
    public partial class UC_ViewConfig : MetroFramework.Forms.MetroForm
    {
        public static string ConfigString = string.Empty;                                 // stringa del config da passare a UC_ViewConfig

        public UC_ViewConfig()
        {
            InitializeComponent();
        }

        private void UC_ViewConfig_Load(object sender, EventArgs e)
        {
            ConfigString = UC_SL_History.ConfigString;

            label_NO_Config.Visible = false;
            SetForm();

            TraduciStringa();
        }

        private void panel_Config_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            string tiporiga = string.Empty;
            if ((e.Row >= 0) && (e.Row <= 5)) { tiporiga = "8"; }
            if ((e.Row >= 6) && (e.Row <= 17)) { tiporiga = "20"; }
            if (e.Row > 17) { tiporiga = "Altro"; }

            switch (tiporiga)
            {
                case "8":
                    using (SolidBrush brush = new SolidBrush(Color.AliceBlue))
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    break;
                case "20":
                    using (SolidBrush brush = new SolidBrush(Color.FloralWhite))
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    break;
                case "Altro":
                    using (SolidBrush brush = new SolidBrush(Color.Transparent))
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    break;
            }
        }

        private void SetForm()
        {
            lab_out_01.BackColor = Color.Transparent;
            lab_out_02.BackColor = Color.Transparent;
            lab_out_03.BackColor = Color.Transparent;
            lab_out_04.BackColor = Color.Transparent;
            lab_out_05.BackColor = Color.Transparent;
            lab_out_06.BackColor = Color.Transparent;
            lab_out_07.BackColor = Color.Transparent;
            lab_out_08.BackColor = Color.Transparent;
            lab_out_09.BackColor = Color.Transparent;
            lab_out_10.BackColor = Color.Transparent;
            lab_out_11.BackColor = Color.Transparent;
            lab_out_12.BackColor = Color.Transparent;
            lab_out_13.BackColor = Color.Transparent;
            lab_out_14.BackColor = Color.Transparent;
            lab_out_15.BackColor = Color.Transparent;
            lab_out_16.BackColor = Color.Transparent;
            lab_out_17.BackColor = Color.Transparent;
            lab_out_18.BackColor = Color.Transparent;
            lab_out_01.UseCustomBackColor = true;
            lab_out_02.UseCustomBackColor = true;
            lab_out_03.UseCustomBackColor = true;
            lab_out_04.UseCustomBackColor = true;
            lab_out_05.UseCustomBackColor = true;
            lab_out_06.UseCustomBackColor = true;
            lab_out_07.UseCustomBackColor = true;
            lab_out_08.UseCustomBackColor = true;
            lab_out_09.UseCustomBackColor = true;
            lab_out_10.UseCustomBackColor = true;
            lab_out_11.UseCustomBackColor = true;
            lab_out_12.UseCustomBackColor = true;
            lab_out_13.UseCustomBackColor = true;
            lab_out_14.UseCustomBackColor = true;
            lab_out_15.UseCustomBackColor = true;
            lab_out_16.UseCustomBackColor = true;
            lab_out_17.UseCustomBackColor = true;
            lab_out_18.UseCustomBackColor = true;

            lab_MO_01.BackColor = Color.Transparent;
            lab_MO_02.BackColor = Color.Transparent;
            lab_MO_03.BackColor = Color.Transparent;
            lab_MO_04.BackColor = Color.Transparent;
            lab_MO_05.BackColor = Color.Transparent;
            lab_MO_06.BackColor = Color.Transparent;
            lab_MO_07.BackColor = Color.Transparent;
            lab_MO_08.BackColor = Color.Transparent;
            lab_MO_09.BackColor = Color.Transparent;
            lab_MO_10.BackColor = Color.Transparent;
            lab_MO_11.BackColor = Color.Transparent;
            lab_MO_12.BackColor = Color.Transparent;
            lab_MO_13.BackColor = Color.Transparent;
            lab_MO_14.BackColor = Color.Transparent;
            lab_MO_15.BackColor = Color.Transparent;
            lab_MO_16.BackColor = Color.Transparent;
            lab_MO_17.BackColor = Color.Transparent;
            lab_MO_18.BackColor = Color.Transparent;
            lab_MO_01.UseCustomBackColor = true;
            lab_MO_02.UseCustomBackColor = true;
            lab_MO_03.UseCustomBackColor = true;
            lab_MO_04.UseCustomBackColor = true;
            lab_MO_05.UseCustomBackColor = true;
            lab_MO_06.UseCustomBackColor = true;
            lab_MO_07.UseCustomBackColor = true;
            lab_MO_08.UseCustomBackColor = true;
            lab_MO_09.UseCustomBackColor = true;
            lab_MO_10.UseCustomBackColor = true;
            lab_MO_11.UseCustomBackColor = true;
            lab_MO_12.UseCustomBackColor = true;
            lab_MO_13.UseCustomBackColor = true;
            lab_MO_14.UseCustomBackColor = true;
            lab_MO_15.UseCustomBackColor = true;
            lab_MO_16.UseCustomBackColor = true;
            lab_MO_17.UseCustomBackColor = true;
            lab_MO_18.UseCustomBackColor = true;
            lab_MO_01.Enabled = false;
            lab_MO_02.Enabled = false;
            lab_MO_03.Enabled = false;
            lab_MO_04.Enabled = false;
            lab_MO_05.Enabled = false;
            lab_MO_06.Enabled = false;
            lab_MO_07.Enabled = false;
            lab_MO_08.Enabled = false;
            lab_MO_09.Enabled = false;
            lab_MO_10.Enabled = false;
            lab_MO_11.Enabled = false;
            lab_MO_12.Enabled = false;
            lab_MO_13.Enabled = false;
            lab_MO_14.Enabled = false;
            lab_MO_15.Enabled = false;
            lab_MO_16.Enabled = false;
            lab_MO_17.Enabled = false;
            lab_MO_18.Enabled = false;

            lab_M_01.BackColor = Color.Transparent;
            lab_M_02.BackColor = Color.Transparent;
            lab_M_03.BackColor = Color.Transparent;
            lab_M_04.BackColor = Color.Transparent;
            lab_M_05.BackColor = Color.Transparent;
            lab_M_06.BackColor = Color.Transparent;
            lab_M_07.BackColor = Color.Transparent;
            lab_M_08.BackColor = Color.Transparent;
            lab_M_09.BackColor = Color.Transparent;
            lab_M_10.BackColor = Color.Transparent;
            lab_M_11.BackColor = Color.Transparent;
            lab_M_12.BackColor = Color.Transparent;
            lab_M_13.BackColor = Color.Transparent;
            lab_M_14.BackColor = Color.Transparent;
            lab_M_15.BackColor = Color.Transparent;
            lab_M_16.BackColor = Color.Transparent;
            lab_M_17.BackColor = Color.Transparent;
            lab_M_18.BackColor = Color.Transparent;
            lab_M_01.UseCustomBackColor = true;
            lab_M_02.UseCustomBackColor = true;
            lab_M_03.UseCustomBackColor = true;
            lab_M_04.UseCustomBackColor = true;
            lab_M_05.UseCustomBackColor = true;
            lab_M_06.UseCustomBackColor = true;
            lab_M_07.UseCustomBackColor = true;
            lab_M_08.UseCustomBackColor = true;
            lab_M_09.UseCustomBackColor = true;
            lab_M_10.UseCustomBackColor = true;
            lab_M_11.UseCustomBackColor = true;
            lab_M_12.UseCustomBackColor = true;
            lab_M_13.UseCustomBackColor = true;
            lab_M_14.UseCustomBackColor = true;
            lab_M_15.UseCustomBackColor = true;
            lab_M_16.UseCustomBackColor = true;
            lab_M_17.UseCustomBackColor = true;
            lab_M_18.UseCustomBackColor = true;
            lab_M_01.Enabled = false;
            lab_M_02.Enabled = false;
            lab_M_03.Enabled = false;
            lab_M_04.Enabled = false;
            lab_M_05.Enabled = false;
            lab_M_06.Enabled = false;
            lab_M_07.Enabled = false;
            lab_M_08.Enabled = false;
            lab_M_09.Enabled = false;
            lab_M_10.Enabled = false;
            lab_M_11.Enabled = false;
            lab_M_12.Enabled = false;
            lab_M_13.Enabled = false;
            lab_M_14.Enabled = false;
            lab_M_15.Enabled = false;
            lab_M_16.Enabled = false;
            lab_M_17.Enabled = false;
            lab_M_18.Enabled = false;

            lab_L_01.BackColor = Color.Transparent;
            lab_L_02.BackColor = Color.Transparent;
            lab_L_03.BackColor = Color.Transparent;
            lab_L_04.BackColor = Color.Transparent;
            lab_L_05.BackColor = Color.Transparent;
            lab_L_06.BackColor = Color.Transparent;
            lab_L_07.BackColor = Color.Transparent;
            lab_L_08.BackColor = Color.Transparent;
            lab_L_09.BackColor = Color.Transparent;
            lab_L_10.BackColor = Color.Transparent;
            lab_L_11.BackColor = Color.Transparent;
            lab_L_12.BackColor = Color.Transparent;
            lab_L_13.BackColor = Color.Transparent;
            lab_L_14.BackColor = Color.Transparent;
            lab_L_15.BackColor = Color.Transparent;
            lab_L_16.BackColor = Color.Transparent;
            lab_L_17.BackColor = Color.Transparent;
            lab_L_18.BackColor = Color.Transparent;
            lab_L_01.UseCustomBackColor = true;
            lab_L_02.UseCustomBackColor = true;
            lab_L_03.UseCustomBackColor = true;
            lab_L_04.UseCustomBackColor = true;
            lab_L_05.UseCustomBackColor = true;
            lab_L_06.UseCustomBackColor = true;
            lab_L_07.UseCustomBackColor = true;
            lab_L_08.UseCustomBackColor = true;
            lab_L_09.UseCustomBackColor = true;
            lab_L_10.UseCustomBackColor = true;
            lab_L_11.UseCustomBackColor = true;
            lab_L_12.UseCustomBackColor = true;
            lab_L_13.UseCustomBackColor = true;
            lab_L_14.UseCustomBackColor = true;
            lab_L_15.UseCustomBackColor = true;
            lab_L_16.UseCustomBackColor = true;
            lab_L_17.UseCustomBackColor = true;
            lab_L_18.UseCustomBackColor = true;
            lab_L_01.Enabled = false;
            lab_L_02.Enabled = false;
            lab_L_03.Enabled = false;
            lab_L_04.Enabled = false;
            lab_L_05.Enabled = false;
            lab_L_06.Enabled = false;
            lab_L_07.Enabled = false;
            lab_L_08.Enabled = false;
            lab_L_09.Enabled = false;
            lab_L_10.Enabled = false;
            lab_L_11.Enabled = false;
            lab_L_12.Enabled = false;
            lab_L_13.Enabled = false;
            lab_L_14.Enabled = false;
            lab_L_15.Enabled = false;
            lab_L_16.Enabled = false;
            lab_L_17.Enabled = false;
            lab_L_18.Enabled = false;

            lab_Frequency.Text = string.Empty;
            lab_TimeOut.Text = string.Empty;

            string trova_sb = UC_SL_History.Device;
            if (trova_sb.Substring(0,5) == "XSB08")
            {
                lab_out_07.Visible = false;
                lab_out_08.Visible = false;
                lab_out_09.Visible = false;
                lab_out_10.Visible = false;
                lab_out_11.Visible = false;
                lab_out_12.Visible = false;
                lab_out_13.Visible = false;
                lab_out_14.Visible = false;
                lab_out_15.Visible = false;
                lab_out_16.Visible = false;
                lab_out_17.Visible = false;
                lab_out_18.Visible = false;
                lab_MO_07.Visible = false;
                lab_MO_08.Visible = false;
                lab_MO_09.Visible = false;
                lab_MO_10.Visible = false;
                lab_MO_11.Visible = false;
                lab_MO_12.Visible = false;
                lab_MO_13.Visible = false;
                lab_MO_14.Visible = false;
                lab_MO_15.Visible = false;
                lab_MO_16.Visible = false;
                lab_MO_17.Visible = false;
                lab_MO_18.Visible = false;
                lab_M_07.Visible = false;
                lab_M_08.Visible = false;
                lab_M_09.Visible = false;
                lab_M_10.Visible = false;
                lab_M_11.Visible = false;
                lab_M_12.Visible = false;
                lab_M_13.Visible = false;
                lab_M_14.Visible = false;
                lab_M_15.Visible = false;
                lab_M_16.Visible = false;
                lab_M_17.Visible = false;
                lab_M_18.Visible = false;
                lab_L_07.Visible = false;
                lab_L_08.Visible = false;
                lab_L_09.Visible = false;
                lab_L_10.Visible = false;
                lab_L_11.Visible = false;
                lab_L_12.Visible = false;
                lab_L_13.Visible = false;
                lab_L_14.Visible = false;
                lab_L_15.Visible = false;
                lab_L_16.Visible = false;
                lab_L_17.Visible = false;
                lab_L_18.Visible = false;
            }
        }

        private void TraduciStringa()
        {
            string config_clean = string.Empty;

            int trova_len = 0;
            int trova_outs = 0;
            int trova_timeout = 0;
            int trova_frequency = 0;

            int len_outs = 0;
            int len_timeout = 0;
            int len_frequency = 0;

            string raw_outs = string.Empty;
            string raw_timeout = string.Empty;
            string raw_frequency = string.Empty;

            // Procedura di pulizia stringa config da caratteri non necessari
            config_clean = ConfigString;
            config_clean = config_clean.Replace(@"""", string.Empty);
            config_clean = config_clean.Replace(@"{", string.Empty);
            config_clean = config_clean.Replace(@"}", string.Empty);
            config_clean = config_clean.Replace(@"\", string.Empty);
            config_clean = config_clean.Replace(@",", string.Empty);
            config_clean = config_clean.Replace(@"[", string.Empty);
            config_clean = config_clean.Replace(@"]", string.Empty);

            if (ConfigString == string.Empty)
            {
                label_NO_Config.Visible = true;
                lab_out_01.Visible = false;
                lab_out_02.Visible = false;
                lab_out_03.Visible = false;
                lab_out_04.Visible = false;
                lab_out_05.Visible = false;
                lab_out_06.Visible = false;
                lab_out_07.Visible = false;
                lab_out_08.Visible = false;
                lab_out_09.Visible = false;
                lab_out_10.Visible = false;
                lab_out_11.Visible = false;
                lab_out_12.Visible = false;
                lab_out_13.Visible = false;
                lab_out_14.Visible = false;
                lab_out_15.Visible = false;
                lab_out_16.Visible = false;
                lab_out_17.Visible = false;
                lab_out_18.Visible = false;

                lab_MO_01.Visible = false;
                lab_MO_02.Visible = false;
                lab_MO_03.Visible = false;
                lab_MO_04.Visible = false;
                lab_MO_05.Visible = false;
                lab_MO_06.Visible = false;
                lab_MO_07.Visible = false;
                lab_MO_08.Visible = false;
                lab_MO_09.Visible = false;
                lab_MO_10.Visible = false;
                lab_MO_11.Visible = false;
                lab_MO_12.Visible = false;
                lab_MO_13.Visible = false;
                lab_MO_14.Visible = false;
                lab_MO_15.Visible = false;
                lab_MO_16.Visible = false;
                lab_MO_17.Visible = false;
                lab_MO_18.Visible = false;

                return;
            }

            // Primo passaggio di "spezzettamento"
            trova_len = config_clean.Length;
            trova_outs = config_clean.IndexOf("config:outs:");
            trova_timeout = config_clean.IndexOf("timeOut:");
            trova_frequency = config_clean.IndexOf("frequency:");

            len_outs = trova_timeout - trova_outs - 12;
            len_timeout = trova_frequency - trova_timeout - 8;
            len_frequency = trova_len - trova_frequency - 10;

            raw_outs = config_clean.Substring(trova_outs + 12, len_outs);
            raw_timeout = config_clean.Substring(trova_timeout + 8, len_timeout);
            raw_frequency = config_clean.Substring(trova_frequency + 10, len_frequency);

            // Analisi OUTS
            int[] out_start = new int[19];      //creo l'array di un elemento in più per "allineare" gli indici alle uscite
            bool[] out_mo = new bool[19];       //creo l'array di un elemento in più per "allineare" gli indici alle uscite
            bool[] out_l = new bool[19];        //creo l'array di un elemento in più per "allineare" gli indici alle uscite
            bool[] out_m = new bool[19];        //creo l'array di un elemento in più per "allineare" gli indici alle uscite
            string[] outs = new string[19];     //creo l'array di un elemento in più per "allineare" gli indici alle uscite

            int for_start = 0;
            int for_len = 0;

            for (int i = 1; i <= 18; i++)       //Trovo tutte le "partenze" delle occorrenze delle uscite
            {
                out_start[i] = raw_outs.IndexOf("mo:", for_start);
                for_start = out_start[i] + 1;
            }

            for (int i = 1; i <= 18; i++)       //Trovo tutte le "partenze" delle occorrenze delle uscite
            {
                int len = 0;

                if (i != 18) { len = out_start[i + 1] - out_start[i]; } else { len = raw_outs.Length - out_start[18]; }
                outs[i] = raw_outs.Substring(out_start[i], len);
                for_start = out_start[i] + 1;
            }

            for (int i = 1; i <= 18; i++)       //Analizzo le stringhe di ogni uscita
            {
                int mostart = 0;
                int lstart = 0;
                int mstart = 0;
                mostart = outs[i].IndexOf("mo:");
                lstart = outs[i].IndexOf("l:");
                mstart = outs[i].IndexOf("m:");
                int molen = lstart - mostart;
                int llen = mstart - lstart;
                int mlen = outs[i].Length - mstart;
                out_mo[i] = Convert.ToBoolean(outs[i].Substring(mostart + 3, molen - 3));
                out_l[i] = Convert.ToBoolean(outs[i].Substring(lstart + 2, llen - 2));
                out_m[i] = Convert.ToBoolean(outs[i].Substring(mstart + 2, mlen - 2));
            }

            // Analisi TimeOut
            int blocchi_timeout = 0;

            try
            {
                blocchi_timeout = Convert.ToInt32(raw_timeout);
                blocchi_timeout = blocchi_timeout * 30;
                lab_TimeOut.Text = Convert.ToString(blocchi_timeout) + " secondi";

            }
            catch (FormatException e)
            {
                lab_TimeOut.Text = "Impossibile mostrare il Time-Out!";
            }


            // Analisi Frequency
            switch (raw_frequency)
            {
                case "1":
                    lab_Frequency.Text = "868";
                    break;
                case "2":
                    lab_Frequency.Text = "915";
                    break;
                case "4":
                    lab_Frequency.Text = "433";
                    break;
                case "8":
                    lab_Frequency.Text = "2.4";
                    break;
                default:
                    lab_Frequency.Text = "Indefinibile!";
                    break;
            }

            //Visualizzo i valori
            lab_MO_01.Checked = out_mo[1];
            lab_MO_02.Checked = out_mo[2];
            lab_MO_03.Checked = out_mo[3];
            lab_MO_04.Checked = out_mo[4];
            lab_MO_05.Checked = out_mo[5];
            lab_MO_06.Checked = out_mo[6];
            lab_MO_07.Checked = out_mo[7];
            lab_MO_08.Checked = out_mo[8];
            lab_MO_09.Checked = out_mo[9];
            lab_MO_10.Checked = out_mo[10];
            lab_MO_11.Checked = out_mo[11];
            lab_MO_12.Checked = out_mo[12];
            lab_MO_13.Checked = out_mo[13];
            lab_MO_14.Checked = out_mo[14];
            lab_MO_15.Checked = out_mo[15];
            lab_MO_16.Checked = out_mo[16];
            lab_MO_17.Checked = out_mo[17];
            lab_MO_18.Checked = out_mo[18];

            lab_M_01.Checked = out_m[1];
            lab_M_02.Checked = out_m[2];
            lab_M_03.Checked = out_m[3];
            lab_M_04.Checked = out_m[4];
            lab_M_05.Checked = out_m[5];
            lab_M_06.Checked = out_m[6];
            lab_M_07.Checked = out_m[7];
            lab_M_08.Checked = out_m[8];
            lab_M_09.Checked = out_m[9];
            lab_M_10.Checked = out_m[10];
            lab_M_11.Checked = out_m[11];
            lab_M_12.Checked = out_m[12];
            lab_M_13.Checked = out_m[13];
            lab_M_14.Checked = out_m[14];
            lab_M_15.Checked = out_m[15];
            lab_M_16.Checked = out_m[16];
            lab_M_17.Checked = out_m[17];
            lab_M_18.Checked = out_m[18];

            lab_L_01.Checked = out_l[1];
            lab_L_02.Checked = out_l[2];
            lab_L_03.Checked = out_l[3];
            lab_L_04.Checked = out_l[4];
            lab_L_05.Checked = out_l[5];
            lab_L_06.Checked = out_l[6];
            lab_L_07.Checked = out_l[7];
            lab_L_08.Checked = out_l[8];
            lab_L_09.Checked = out_l[9];
            lab_L_10.Checked = out_l[10];
            lab_L_11.Checked = out_l[11];
            lab_L_12.Checked = out_l[12];
            lab_L_13.Checked = out_l[13];
            lab_L_14.Checked = out_l[14];
            lab_L_15.Checked = out_l[15];
            lab_L_16.Checked = out_l[16];
            lab_L_17.Checked = out_l[17];
            lab_L_18.Checked = out_l[18];

        }
    }
}
