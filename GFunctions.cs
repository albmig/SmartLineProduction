using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLineProduction
{
    class GFunctions
    {
        //public static void Provafunc()
        //{
        //    MessageBox.Show("aaa");
        //}

        public static bool LeggiConfig_SL()
        {
            int pos_x = 0;
            int pos_y = 0;
            int posdiv = 0;
            string config_text = string.Empty;

            // TJ-4120TN_SL
            config_text = Properties.Settings.Default.Settings_Brother_SL;
            posdiv = config_text.IndexOf("|");
            pos_x = Convert.ToInt32(config_text.Substring(0, posdiv));
            pos_y = Convert.ToInt32(config_text.Substring(posdiv + 1, (config_text.Length - posdiv - 1)));
            GVar.Brother_SL_pos_x = pos_x;
            GVar.Brother_SL_pos_y = pos_y;

            if (GVar.Brother_default==GVar.Brother_SL_addr)
            {
                GVar.Brother_Default_pos_x = GVar.Brother_SL_pos_x;
                GVar.Brother_Default_pos_y = GVar.Brother_SL_pos_y;
            }

            return true;
        }

        public static bool LeggiConfig_Antiman()
        {
            int pos_x = 0;
            int pos_y = 0;
            int posdiv = 0;
            string config_text = string.Empty;

            // TJ-4120TN_Antiman
            config_text = Properties.Settings.Default.Settings_Brother_Antiman;
            posdiv = config_text.IndexOf("|");
            pos_x = Convert.ToInt32(config_text.Substring(0, posdiv));
            pos_y = Convert.ToInt32(config_text.Substring(posdiv + 1, (config_text.Length - posdiv - 1)));
            GVar.Brother_Antiman_pos_x = pos_x;
            GVar.Brother_Antiman_pos_y = pos_y;

            if (GVar.Brother_default == GVar.Brother_Antiman_addr)
            {
                GVar.Brother_Default_pos_x = GVar.Brother_Antiman_pos_x;
                GVar.Brother_Default_pos_y = GVar.Brother_Antiman_pos_y;
            }

            return true;
        }

        public static bool PrintLabelBrother()
        {
            int a = BROLIB_DLL.openport(GVar.Brother_default); if (a != 1) { return false; }
            string command = string.Empty;
            command = "SIZE 23.7 mm, 8 mm";
            a = BROLIB_DLL.sendcommand(command); if (a != 1) { return false; }
            command = "DIRECTION 0,0";
            a = BROLIB_DLL.sendcommand(command); if (a != 1) { return false; }
            command = "REFERENCE 0,0";
            a = BROLIB_DLL.sendcommand(command); if (a != 1) { return false; }
            command = "OFFSET 0 mm";
            a = BROLIB_DLL.sendcommand(command); if (a != 1) { return false; }
            command = "SET REWIND OFF";
            a = BROLIB_DLL.sendcommand(command); if (a != 1) { return false; }
            command = "SET PEEL OFF";
            a = BROLIB_DLL.sendcommand(command); if (a != 1) { return false; }
            command = "SET CUTTER OFF";
            a = BROLIB_DLL.sendcommand(command); if (a != 1) { return false; }
            command = "SET PARTIAL_CUTTER OFF";
            a = BROLIB_DLL.sendcommand(command); if (a != 1) { return false; }
            command = "SET TEAR ON";
            a = BROLIB_DLL.sendcommand(command); if (a != 1) { return false; }
            command = "CLS";
            a = BROLIB_DLL.sendcommand(command); if (a != 1) { return false; }

            string testo = '"' + GVar.PrintMask_String + '"';

            command = "QRCODE " + GVar.Brother_Default_pos_x.ToString() + "," + GVar.Brother_Default_pos_y.ToString() + ",L,3,A,180,M2,S7," + testo;
            a = BROLIB_DLL.sendcommand(command); if (a != 1) { return false; }
            command = "CODEPAGE 1252";
            a = BROLIB_DLL.sendcommand(command); if (a != 1) { return false; }

            a = BROLIB_DLL.printlabel("1", "1"); if (a != 1) { return false; }
            a = BROLIB_DLL.closeport(); if (a != 1) { return false; }

            return true;
        }

        public static bool PrintMask ()
        {
            bool endprint = false;
            do
            {
                UC_Reprint_Label uC_Reprint_Label = new UC_Reprint_Label();
                var result = uC_Reprint_Label.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    PrintLabelBrother();
                    WriteConfig_Coordinate();
                    endprint = false;
                }
                else
                {
                    endprint = true;
                }
            } while (!endprint);
            return true;
        }

        public static bool WriteConfig_Coordinate()
        {
            string configsave = GVar.Brother_Default_pos_x.ToString() + "|" + GVar.Brother_Default_pos_y.ToString();

            if (GVar.Brother_default == GVar.Brother_SL_addr)
            {
                Properties.Settings.Default.Settings_Brother_SL = configsave;
            }

            if (GVar.Brother_default == GVar.Brother_Antiman_addr)
            {
                Properties.Settings.Default.Settings_Brother_Antiman = configsave;
            }
            Properties.Settings.Default.Save();

            return true;
        }
    }
}
