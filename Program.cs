using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public class BROLIB_DLL
{
    [DllImport("BROLIB.dll", EntryPoint = "about")]
    public static extern int about();

    [DllImport("BROLIB.dll", EntryPoint = "openport")]
    public static extern int openport(string printername);

    [DllImport("BROLIB.dll", EntryPoint = "barcode")]
    public static extern int barcode(string x, string y, string type,
                string height, string readable, string rotation,
                string narrow, string wide, string code);

    [DllImport("BROLIB.dll", EntryPoint = "clearbuffer")]
    public static extern int clearbuffer();

    [DllImport("BROLIB.dll", EntryPoint = "closeport")]
    public static extern int closeport();

    [DllImport("BROLIB.dll", EntryPoint = "downloadpcx")]
    public static extern int downloadpcx(string filename, string image_name);

    [DllImport("BROLIB.dll", EntryPoint = "formfeed")]
    public static extern int formfeed();

    [DllImport("BROLIB.dll", EntryPoint = "nobackfeed")]
    public static extern int nobackfeed();

    [DllImport("BROLIB.dll", EntryPoint = "printerfont")]
    public static extern int printerfont(string x, string y, string fonttype,
                    string rotation, string xmul, string ymul,
                    string text);

    [DllImport("BROLIB.dll", EntryPoint = "printlabel")]
    public static extern int printlabel(string set, string copy);

    [DllImport("BROLIB.dll", EntryPoint = "sendcommand")]
    public static extern int sendcommand(string printercommand);

    [DllImport("BROLIB.dll", EntryPoint = "setup")]
    public static extern int setup(string width, string height,
              string speed, string density,
              string sensor, string vertical,
              string offset);

    [DllImport("BROLIB.dll", EntryPoint = "windowsfont")]
    public static extern int windowsfont(int x, int y, int fontheight,
                    int rotation, int fontstyle, int fontunderline,
                    string szFaceName, string content);

}

namespace SmartLineProduction
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ***this line is added***
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }

        // ***also dllimport of that function***
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
