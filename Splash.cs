using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLineProduction
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            if (GVar.CloseSplash)
            {
                this.Close();
            }
        }
    }
}
