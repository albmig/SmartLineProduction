using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace SmartLineProduction
{
    public static class GVar
    {
        public static bool CloseSplash = false;
        public static bool formclosing = false;

        public static bool Form_Edit = false;
        public static int BS_Position_01 = 0;

        public static string gl_commessa = "";
        public static string gl_ragsoc = "";
        public static string gl_articolo = "";
        public static string gl_note = "";
        public static int gl_qtaevadere = 0;

        public static string gl_tipofiltro_FW_P = "";
        public static string gl_tipofiltro_FW_R = "";

        public static string btn_clicked = ""; // passaggio - abort

        public static string Brother_SL_addr = @"\\192.168.0.8\TJ-4120TN_SL";
        public static string Brother_Antiman_addr = @"\\192.168.0.8\TJ-4120TN_Antiman";
        public static string Brother_default = Brother_Antiman_addr;

        public static int Brother_Antiman_pos_x = 0;
        public static int Brother_Antiman_pos_y = 0;
        public static int Brother_SL_pos_x = 0;
        public static int Brother_SL_pos_y = 0;
        public static int Brother_Default_pos_x = 0;
        public static int Brother_Default_pos_y = 0;

        public static string PrintMask_String;
        public static bool PrintMask_WarningPic;
        public static string PrintMask_Firmware;

    }
}
