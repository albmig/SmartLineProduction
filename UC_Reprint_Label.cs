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
    public partial class UC_Reprint_Label : MetroFramework.Forms.MetroForm
    {
        //public string Answer { get { return cb_Correzione.Text; } }

        public UC_Reprint_Label()
        {
            InitializeComponent();
        }

        private void but_abort_UC_Reprint_Label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_close_UC_Reprint_Label_Click(object sender, EventArgs e)
        {
            GVar.Brother_Default_pos_x = Convert.ToInt32(trigger_coord_x.Value);
            GVar.Brother_Default_pos_y = Convert.ToInt32(trigger_coord_y.Value);
            this.Close();
        }

        private void UC_Reprint_Label_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ds_Programmazione.Firmware'. È possibile spostarla o rimuoverla se necessario.
            this.firmwareTableAdapter.Fill(this.ds_Programmazione.Firmware);

            GVar.PrintMask_WarningPic = (bool)this.firmwareTableAdapter.IsCustomPic(GVar.PrintMask_Firmware);

            this.Text = this.Text + " - " + Path.GetFileName(GVar.Brother_default);
            if (GVar.PrintMask_WarningPic) { pan_Warning.Visible = true; } else { pan_Warning.Visible = false; }
            lab_printstring.Text = GVar.PrintMask_String;
            trigger_coord_x.Value = GVar.Brother_Default_pos_x;
            trigger_coord_y.Value = GVar.Brother_Default_pos_y;
            double conv_old_coord_x = GVar.Brother_Default_pos_x / 12;
            double conv_old_coord_y = GVar.Brother_Default_pos_y / 12;
            lab_old_coord_x.Text = GVar.Brother_Default_pos_x.ToString() + " (" + conv_old_coord_x.ToString("#.##") + " mm.)";
            lab_old_coord_y.Text = GVar.Brother_Default_pos_y.ToString() + " (" + conv_old_coord_y.ToString("#.##") + " mm.)";
            tb_coordinate.Text = "L'etichetta viene stampata al contrario rispetto all'operatore." + "\r\n" +
                                 "Aumentando la coordinata X, l'etichetta si sposta a sinistra." + "\r\n" +
                                 "Aumentando la coordinata Y, l'etichetta si sposta in alto.";
        }

        private void Layout_Print_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == 1)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.AliceBlue), e.CellBounds);
            }
        }
    }
}
