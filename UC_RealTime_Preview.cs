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
using System.IO;

namespace SmartLineProduction
{
    public partial class UC_RealTime_Preview : MetroFramework.Forms.MetroForm
    {
        public DataTable dt_vista;

        public UC_RealTime_Preview(DataTable dt_preview)
        {
            InitializeComponent();
            dt_vista = dt_preview;
        }

        private void UC_RealTime_Preview_Load(object sender, EventArgs e)
        {
            gv_Preview.DataSource = dt_vista;
        }

        private void gv_Preview_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (this.gv_Preview.Columns["TmpIcon"].Index == e.ColumnIndex && e.RowIndex >= 0)
            {
                string filepath = @"\\192.168.0.8\sistematica\AREA_FIRMWARE\SmartLine\Compilati\RT_Icons\";
                filepath = filepath + gv_Preview.Rows[e.RowIndex].Cells["tmpCol1"].Value;

                if (File.Exists(filepath))
                {
                    Image img;
                    img = Image.FromFile(filepath);
                    gv_Preview.Rows[e.RowIndex].Cells["TmpIcon"].Value = img;
                }
                else
                {
                    Image imgnull = new Bitmap(1, 1);
                    gv_Preview.Rows[e.RowIndex].Cells["TmpIcon"].Value = imgnull;
                }
            }
        }

        private void gv_Preview_VisibleChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void UC_RealTime_Preview_Shown(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
