using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SmartLineProduction.Properties;
using System.Data.SqlTypes;
using MetroFramework;

namespace SmartLineProduction
{
    public partial class UC_Avanzamento : MetroFramework.Forms.MetroForm
    {
        string filtroclienti = "";
        string filtrocomm = "";
        string filtroarticoli = "";
        string filtrodata = "";
        string filtrofase = "";
        string filtronote = "";
        int tipoicona = 0; // 1 - Enable / 2 - Disable / 3 - KO / 4 - EnableNota / 5 - DisableNota

        public UC_Avanzamento()
        {
            InitializeComponent();
        }

        // Gestione
        private void UC_Avanzamento_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_ElencoDate_CommAperte'. È possibile spostarla o rimuoverla se necessario.
            this.sF_ElencoDate_CommAperteTableAdapter.Fill(this.ds_SL.SF_ElencoDate_CommAperte);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL3.SF_ElencoArticoli_CommAperte'. È possibile spostarla o rimuoverla se necessario.
            this.sF_ElencoArticoli_CommAperteTableAdapter.Fill(this.ds_SL.SF_ElencoArticoli_CommAperte);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL2.SF_ElencoCommesse_CommAperte'. È possibile spostarla o rimuoverla se necessario.
            this.sF_ElencoCommesse_CommAperteTableAdapter.Fill(this.ds_SL.SF_ElencoCommesse_CommAperte);
            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL1.SF_ElencoClienti_CommAperte'. È possibile spostarla o rimuoverla se necessario.
            this.sF_ElencoClienti_CommAperteTableAdapter.Fill(this.ds_SL.SF_ElencoClienti_CommAperte);
            GVar.formclosing = false;

            // TODO: questa riga di codice carica i dati nella tabella 'ds_SL.SF_CommesseAperte_CL_SL'. È possibile spostarla o rimuoverla se necessario.
            this.sF_CommesseAperte_CL_SLTableAdapter.Fill(this.ds_SL.SF_CommesseAperte_CL_SL);

            gv_Commesse.Sort(gv_Commesse_DataConsegnaSort, ListSortDirection.Ascending);

            //Add the item at the first position.
            cb_elencoClienti.SelectedIndex = -1;
            cb_elencocommesse.SelectedIndex = -1;
            cb_elencoarticoli.SelectedIndex = -1;
            cb_elencodate.SelectedIndex = -1;
            cb_fase.SelectedIndex = 0;
            cb_note.SelectedIndex = 0;

            Cursor.Current = Cursors.Default;
        }

        //Controlli
        private void gv_Commesse_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) { return; }
            if (GVar.formclosing) { return; }
            //Alignment header cell
            gv_Commesse.Columns["gv_Commesse_QtaProgrammazione"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Commesse.Columns["gv_Commesse_QtaMontaggio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Commesse.Columns["gv_Commesse_QtaCollaudoConfezionamento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv_Commesse.Columns["gv_Commesse_QtaVendita"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;


            DataGridViewCell cell = this.gv_Commesse.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewRow gridRow = gv_Commesse.Rows[e.RowIndex];

            int qtaprog = Convert.ToInt16(gridRow.Cells["gv_Commesse_QtaProgrammazione"].Value.ToString());
            int qtamont = Convert.ToInt16(gridRow.Cells["gv_Commesse_QtaMontaggio"].Value.ToString());
            int qtacollconf = Convert.ToInt16(gridRow.Cells["gv_Commesse_QtaCollaudoConfezionamento"].Value.ToString());
            //int qtasped = Convert.ToInt16(gridRow.Cells["gv_Commesse_QtaCollaudoConfezionamento"].Value.ToString());
            int qtavend = Convert.ToInt16(gridRow.Cells["gv_Commesse_QtaVendita"].Value.ToString());
            bool isAO_Programmazione = Convert.ToBoolean(gridRow.Cells["gv_Commesse_CellaProgrammazione"].Value);
            bool isAO_Montaggio = Convert.ToBoolean(gridRow.Cells["gv_Commesse_CellaMontaggio"].Value);
            bool isAO_CollaudoConfezionamento = Convert.ToBoolean(gridRow.Cells["gv_Commesse_CellaCollConf"].Value);
            bool isAO_Spedizione = Convert.ToBoolean(gridRow.Cells["gv_Commesse_CellaSpedizione"].Value);
            bool isAO_Vendita = Convert.ToBoolean(gridRow.Cells["gv_Commesse_CellaVendita"].Value);
            string nota_Programmazione = gridRow.Cells["gv_Commesse_CellaProgrammazione_Note"].Value.ToString();
            string nota_Montaggio = gridRow.Cells["gv_Commesse_CellaMontaggio_Note"].Value.ToString();
            string nota_CollaudoConfezionamento = gridRow.Cells["gv_Commesse_CellaCollConf_Note"].Value.ToString();
            string nota_Spedizione = gridRow.Cells["gv_Commesse_CellaSpedizione_Note"].Value.ToString();
            string nota_Vendita = gridRow.Cells["gv_Commesse_CellaVendita_Note"].Value.ToString();
            bool isdistintapresent = Convert.ToBoolean(gridRow.Cells["gv_Commesse_DistintaBase"].Value);

            string comm = gridRow.Cells["gv_Commesse_CommessaLong"].Value.ToString();
            if (comm == "L3/2020-0001")
            {

            }
            //Colora le colonne
            //if ((gv_Commesse.Columns[e.ColumnIndex].Name == "gv_Commesse_CellaProgrammazione") || (gv_Commesse.Columns[e.ColumnIndex].Name == "gv_Commesse_QtaProgrammazione"))
            //{ cell.Style.BackColor = Color.LightBlue; }
            //if ((gv_Commesse.Columns[e.ColumnIndex].Name == "gv_Commesse_CellaMontaggio") || (gv_Commesse.Columns[e.ColumnIndex].Name == "gv_Commesse_QtaMontaggio"))
            //{ cell.Style.BackColor = Color.LightCoral; }
            //if ((gv_Commesse.Columns[e.ColumnIndex].Name == "gv_Commesse_CellaCollConf") || (gv_Commesse.Columns[e.ColumnIndex].Name == "gv_Commesse_QtaCollaudoConfezionamento"))
            //{ cell.Style.BackColor = Color.LightGreen; }

            //Disegno cella Programmazione
            if ((gv_Commesse.Columns[e.ColumnIndex].Name == "gv_Commesse_CellaProgrammazione") && (e.Value != null))
            {
                tipoicona = 0;
                bool notapresente = (nota_Programmazione != "");// && (nota_Programmazione != null);
                cell.ToolTipText = nota_Programmazione;

                if (!isdistintapresent)
                {
                    tipoicona = 3;
                }
                else
                {
                    if (notapresente)
                    {
                        if (isAO_Programmazione) { tipoicona = 4; } else { tipoicona = 5; }
                    }
                    else
                    {
                        if (isAO_Programmazione) { tipoicona = 1; } else { tipoicona = 2; }
                    }
                }

                // Disegno Icona
                switch (tipoicona) // 1 - Enable / 2 - Disable / 3 - KO / 4 - EnableNota / 5 - DisableNota

                {
                    case 1:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Programma_Enable");
                        break;
                    case 2:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Programma_Disable");
                        break;
                    case 3:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Programma_KO");
                        break;
                    case 4:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Programma_Enable_nota");
                        break;
                    case 5:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Programma_Disable_nota");
                        break;
                }
            }

            //Disegno cella Montaggio
            if ((gv_Commesse.Columns[e.ColumnIndex].Name == "gv_Commesse_CellaMontaggio") && (e.Value != null))
            {
                tipoicona = 0;
                bool notapresente = (nota_Montaggio != "");// && (nota_Montaggio != null);
                cell.ToolTipText = nota_Montaggio;

                if (!isdistintapresent)
                {
                    tipoicona = 3;
                }
                else
                {
                    if (notapresente)
                    {
                        if (isAO_Montaggio) { tipoicona = 4; } else { tipoicona = 5; }
                    }
                    else
                    {
                        if (isAO_Montaggio) { tipoicona = 1; } else { tipoicona = 2; }
                    }
                }

                // Disegno Icona
                switch (tipoicona) // 1 - Enable / 2 - Disable / 3 - KO / 4 - EnableNota / 5 - DisableNota

                {
                    case 1:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Montaggio_Enable");
                        break;
                    case 2:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Montaggio_Disable");
                        break;
                    case 3:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Montaggio_KO");
                        break;
                    case 4:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Montaggio_Enable_nota");
                        break;
                    case 5:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Montaggio_Disable_nota");
                        break;
                }
            }

            //Disegno cella CollaudoConfezionamento
            if ((gv_Commesse.Columns[e.ColumnIndex].Name == "gv_Commesse_CellaCollConf") && (e.Value != null))
            {
                tipoicona = 0;
                bool notapresente = (nota_CollaudoConfezionamento != "");// && (nota_CollaudoConfezionamento != null);
                cell.ToolTipText = nota_CollaudoConfezionamento;


                if (notapresente)
                {
                    if (isAO_CollaudoConfezionamento) { tipoicona = 4; } else { tipoicona = 5; }
                }
                else
                {
                    if (isAO_CollaudoConfezionamento) { tipoicona = 1; } else { tipoicona = 2; }
                }

                // Disegno Icona
                switch (tipoicona) // 1 - Enable / 2 - Disable / 3 - KO / 4 - EnableNota / 5 - DisableNota

                {
                    case 1:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Pack_Enable");
                        break;
                    case 2:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Pack_Disable");
                        break;
                    case 3:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Pack_KO");
                        break;
                    case 4:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Pack_Enable_nota");
                        break;
                    case 5:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Pack_Disable_nota");
                        break;
                }
            }

            //Disegno cella Vendita
            if ((gv_Commesse.Columns[e.ColumnIndex].Name == "gv_Commesse_CellaVendita") && (e.Value != null))
            {
                tipoicona = 0;
                bool notapresente = (nota_Vendita != "");// && (nota_Vendita != null);
                cell.ToolTipText = nota_Vendita;


                if (notapresente)
                {
                    if (isAO_Vendita) { tipoicona = 4; } else { tipoicona = 5; }
                }
                else
                {
                    if (isAO_Vendita) { tipoicona = 1; } else { tipoicona = 2; }
                }

                // Disegno Icona
                switch (tipoicona) // 1 - Enable / 2 - Disable / 3 - KO / 4 - EnableNota / 5 - DisableNota

                {
                    case 1:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Doc_Enable");
                        break;
                    case 2:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Doc_Disable");
                        break;
                    case 3:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Doc_KO");
                        break;
                    case 4:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Doc_Enable_nota");
                        break;
                    case 5:
                        e.Value = Resources.ResourceManager.GetObject("Icona_AV_Doc_Disable_nota");
                        break;
                }
            }
        }

        private void gv_Commesse_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (GVar.formclosing) { return; }

            foreach (DataGridViewRow x in gv_Commesse.Rows)
            {
                x.MinimumHeight = 50;
            }
        }

        private void UC_Avanzamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            GVar.formclosing = true;
        }

        private void gv_Commesse_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //Tenere così
        }

        private void gv_Commesse_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //DataGridViewRow gridRow = gv_Commesse.Rows[e.RowIndex];

            //DataGridViewComboBoxCell comboProgramma = (DataGridViewComboBoxCell)gridRow.Cells["QtaProgramma"];

            //if (comboProgramma!= null)
            //{
            //    int qtadaev = Convert.ToInt32(gridRow.Cells["CellaQtaInevasa"].Value);
            //    comboProgramma.Items.Clear();
            //    for (int i = 0; i <= qtadaev; i++)
            //    {
            //        comboProgramma.Items.Add(i);
            //    }
            //}
        }

        private void gv_Commesse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            if (gv_Commesse.Rows[e.RowIndex].Cells["gv_Commesse_CellaMontaggio"].Value == Resources.ResourceManager.GetObject("Icona_AV_Montaggio_Enable_nota")) { }

            var senderGrid = (DataGridView)sender;
            DataGridViewRow gridRow = gv_Commesse.Rows[e.RowIndex];
            GVar.gl_commessa = gridRow.Cells["gv_Commesse_CommessaLong"].Value.ToString();
            GVar.gl_ragsoc = gridRow.Cells["gv_Commesse_RagioneSociale"].Value.ToString();
            GVar.gl_articolo = gridRow.Cells["gv_Commesse_Articolo"].Value.ToString();
            GVar.gl_qtaevadere = Convert.ToInt32(gridRow.Cells["gv_Commesse_QtaInevasa"].Value);

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == gv_Commesse.Columns["gv_Commesse_CellaProgrammazione"].Index && e.RowIndex >= 0)
                {
                    if ((int)gridRow.Cells["gv_Commesse_CellaProgrammazione"].Value == 0)
                    {
                        GVar.btn_clicked = "";
                        GVar.gl_note = gridRow.Cells["gv_Commesse_CellaProgrammazione_Note"].Value.ToString();
                        UC_AV_Programmazione uC_AV_Programmazione = new UC_AV_Programmazione();
                        uC_AV_Programmazione.Show();
                    }
                }

                if (e.ColumnIndex == gv_Commesse.Columns["gv_Commesse_CellaMontaggio"].Index && e.RowIndex >= 0)
                {
                    if ((int)gridRow.Cells["gv_Commesse_CellaMontaggio"].Value == 0)
                    {
                        GVar.gl_note = gridRow.Cells["gv_Commesse_CellaMontaggio_Note"].Value.ToString();
                        UC_AV_Montaggio uC_AV_Montaggio = new UC_AV_Montaggio();
                        uC_AV_Montaggio.Show();
                    }
                }

                if (e.ColumnIndex == gv_Commesse.Columns["gv_Commesse_CellaCollConf"].Index && e.RowIndex >= 0)
                {
                    if ((int)gridRow.Cells["gv_Commesse_CellaCollConf"].Value == 0)
                    {
                        GVar.gl_note = gridRow.Cells["gv_Commesse_CellaCollConf_Note"].Value.ToString();
                        UC_AV_CollConf uC_AV_CollConf = new UC_AV_CollConf();
                        uC_AV_CollConf.Show();
                    }
                }

                if (e.ColumnIndex == gv_Commesse.Columns["gv_Commesse_CellaSpedizione"].Index && e.RowIndex >= 0)
                {
                    if ((int)gridRow.Cells["gv_Commesse_CellaSpedizione"].Value == 0)
                    {
                        GVar.gl_note = gridRow.Cells["gv_Commesse_CellaSpedizione_Note"].Value.ToString();
                        UC_AV_Spedizioni uC_AV_Spedizioni = new UC_AV_Spedizioni();
                        uC_AV_Spedizioni.Show();
                    }
                }
                 
                if (e.ColumnIndex == gv_Commesse.Columns["gv_Commesse_CellaVendita"].Index && e.RowIndex >= 0)
                {
                    if ((int)gridRow.Cells["gv_Commesse_CellaVendita"].Value == 0)
                    {
                        GVar.gl_note = gridRow.Cells["gv_Commesse_CellaVendita_Note"].Value.ToString();
                        UC_AV_Vendite uC_AV_Vendite = new UC_AV_Vendite();
                        uC_AV_Vendite.Show();
                    }
                }
            }
        }

        private void uscitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Funzioni
        private void FiltraCommesse()
        {
            Cursor.Current = Cursors.WaitCursor;

            string filtrocommesse = "";
            if (filtroclienti != "")
            {
                filtrocommesse = filtroclienti;
            }
            if (filtrocomm != "")
            {
                filtrocommesse = filtrocomm;
            }
            if (filtroarticoli != "")
            {
                filtrocommesse = filtroarticoli;
            }
            if (filtrodata != "")
            {
                filtrocommesse = filtrodata;
            }
            if (filtrofase != "")
            {
                filtrocommesse = filtrofase;
            }
            if (filtronote != "")
            {
                filtrocommesse = filtronote;
            }

            sFCommesseAperteCLSLBindingSource.Filter = filtrocommesse;

            Cursor.Current = Cursors.Default;
        }

        // Pulsante azzera filtri
        private void btn_AzzeraFiltroClienti_Click(object sender, EventArgs e)
        {
            cb_elencoClienti.SelectedIndex = -1;
            filtroclienti = "";
            FiltraCommesse();
        }

        private void btn_AzzeraFiltroCommesse_Click(object sender, EventArgs e)
        {
            cb_elencocommesse.SelectedIndex = -1;
            filtrocomm = "";
            FiltraCommesse();
        }

        private void btn_AzzeraFiltroArticoli_Click(object sender, EventArgs e)
        {
            cb_elencoarticoli.SelectedIndex = -1;
            filtroarticoli = "";
            FiltraCommesse();
        }

        private void btn_AzzeraFiltroDate_Click(object sender, EventArgs e)
        {
            cb_elencodate.SelectedIndex = -1;
            filtrodata = "";
            FiltraCommesse();
        }

        private void btn_AzzeraFiltroFase_Click(object sender, EventArgs e)
        {
            cb_fase.SelectedIndex = 0;
            filtrofase = "";
            FiltraCommesse();
        }

        private void btn_AzzeraFiltroNote_Click(object sender, EventArgs e)
        {
            cb_note.SelectedIndex = 0;
            filtronote = "";
            FiltraCommesse();
        }

        //Selection changed
        private void cb_elencoClienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_elencoClienti.SelectedIndex >= 0)
            {
                filtroclienti = "CodAnagrafico = " + "'" + cb_elencoClienti.SelectedValue.ToString() + "'";
                FiltraCommesse();
            }
        }

        private void cb_elencocommesse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_elencocommesse.SelectedIndex >= 0)
            {
                filtrocomm = "COMMESSASHORT = " + "'" + cb_elencocommesse.SelectedValue.ToString() + "'";
                FiltraCommesse();
            }
        }

        private void cb_elencoarticoli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_elencoarticoli.SelectedIndex >= 0)
            {
                filtroarticoli = "ARTICOLO = " + "'" + cb_elencoarticoli.SelectedValue.ToString() + "'";
                FiltraCommesse();
            }
        }

        private void cb_elencodate_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((cb_elencodate.SelectedValue != null) && (cb_elencodate.SelectedIndex != -1))
            {
                string DataCompleta = cb_elencodate.SelectedValue.ToString();
                int anno = Convert.ToInt32(DataCompleta.Substring(0, 4));
                int mese = Convert.ToInt32(DataCompleta.Substring(4, 2));

                filtrodata = "MeseConsegna = " + mese + " AND AnnoConsegna = " + anno;
                FiltraCommesse();
            }
            if (cb_elencodate.SelectedIndex == -1)
            {
                filtrodata = "";
                FiltraCommesse();
            }
        }

        private void cb_fase_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_fase.SelectedIndex)
            {
                case 0:                 //Nessuna fase ancora effettuata
                    filtrofase = ""; ;
                    break;
                case 1:                 //Nessuna fase ancora effettuata
                    filtrofase = "AO_Programmazione = 0 AND " +
                                 "AO_Montaggio = 0 AND " +
                                 "AO_CollaudoConfezionamento = 0 AND " +
                                 "AO_Spedizione = 0 AND " +
                                 "AO_Vendita = 0"; ;
                    break;
                case 2:                 //Effettuata fase di programmazione
                    filtrofase = "AO_Programmazione = 1";
                    break;
                case 3:                 //Effettuata fase di Montaggio
                    filtrofase = "AO_Montaggio = 1";
                    break;
                case 4:                 //Effettuata fase di Collaudo/Confezionamento
                    filtrofase = "AO_CollaudoConfezionamento = 1";
                    break;
                case 5:                 //Effettuata fase di Spedizione
                    filtrofase = "AO_Spedizione = 1";
                    break;
                case 6:                 //Effettuata fase di Vendita
                    filtrofase = "AO_Vendita = 1";
                    break;
            }
            FiltraCommesse();
        }

        private void cb_note_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_note.SelectedIndex)
            {
                case 0:                 //Tutti
                    filtronote = "";
                    break;
                case 1:                 //Con note
                    filtronote = "AO_Programmazione_Note IS NOT NULL OR " +
                                 "AO_Montaggio_Note IS NOT NULL OR " +
                                 "AO_CollaudoConfezionamento_Note IS NOT NULL OR " +
                                 "AO_Spedizione_Note IS NOT NULL OR " +
                                 "AO_Vendita_Note IS NOT NULL";
                    break;
                case 2:                 //Senza note
                    filtronote = "AO_Programmazione_Note IS NULL AND " +
                                 "AO_Montaggio_Note IS NULL AND " +
                                 "AO_CollaudoConfezionamento_Note IS NULL AND " +
                                 "AO_Spedizione_Note IS NULL AND " +
                                 "AO_Vendita_Note IS NULL";
                    break;
            }
            FiltraCommesse();
        }

        private void cb_elencoClienti_Click(object sender, EventArgs e)
        {
            cb_elencocommesse.SelectedIndex = -1;
            cb_elencoarticoli.SelectedIndex = -1;
            cb_elencodate.SelectedIndex = -1;
            cb_fase.SelectedIndex = 0;
            cb_note.SelectedIndex = 0;
            cb_elencoClienti.Refresh();
        }

        private void cb_elencocommesse_Click(object sender, EventArgs e)
        {
            cb_elencoClienti.SelectedIndex = -1;
            cb_elencoarticoli.SelectedIndex = -1;
            cb_elencodate.SelectedIndex = -1;
            cb_fase.SelectedIndex = 0;
            cb_note.SelectedIndex = 0;
            cb_elencocommesse.Refresh();
        }

        private void cb_elencoarticoli_Click(object sender, EventArgs e)
        {
            cb_elencoClienti.SelectedIndex = -1;
            cb_elencocommesse.SelectedIndex = -1;
            cb_elencodate.SelectedIndex = -1;
            cb_fase.SelectedIndex = 0;
            cb_note.SelectedIndex = 0;
            cb_elencoarticoli.Refresh();
        }

        private void cb_elencodate_Click(object sender, EventArgs e)
        {
            cb_elencoClienti.SelectedIndex = -1;
            cb_elencocommesse.SelectedIndex = -1;
            cb_elencoarticoli.SelectedIndex = -1;
            cb_fase.SelectedIndex = 0;
            cb_note.SelectedIndex = 0;
            cb_elencodate.Refresh();
        }

        private void cb_fase_Click(object sender, EventArgs e)
        {
            cb_elencoClienti.SelectedIndex = -1;
            cb_elencocommesse.SelectedIndex = -1;
            cb_elencoarticoli.SelectedIndex = -1;
            cb_elencodate.SelectedIndex = -1;
            cb_note.SelectedIndex = 0;
            cb_fase.Refresh();
        }

        private void cb_note_Click(object sender, EventArgs e)
        {
            cb_elencoClienti.SelectedIndex = -1;
            cb_elencocommesse.SelectedIndex = -1;
            cb_elencoarticoli.SelectedIndex = -1;
            cb_elencodate.SelectedIndex = -1;
            cb_fase.SelectedIndex = 0;
            cb_note.Refresh();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            this.sF_CommesseAperte_CL_SLTableAdapter.Fill(this.ds_SL.SF_CommesseAperte_CL_SL);

            sFCommesseAperteCLSLBindingSource.ResetBindings(false);

            Cursor.Current = Cursors.Default;
        }
    }
}
