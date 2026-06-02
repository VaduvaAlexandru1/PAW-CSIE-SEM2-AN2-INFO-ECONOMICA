using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SubiectNr2
{
    public partial class Form1 : Form
    {
        List<Observatie> obsGlobale = new List<Observatie>();
        List<ColectieStatistica> colGlobala =  new List<ColectieStatistica>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvIndici.ColumnCount = 4;

            dgvIndici.Columns[0].Name = "Identificator";
            dgvIndici.Columns[1].Name = "Valoare Baza";
            dgvIndici.Columns[2].Name = "Valoare Curenta";
            dgvIndici.Columns[3].Name = "Valoare Indice";
        }
        //Adaugare

        private void Adauga()
        {
            Observatie obs = new Observatie(Double.Parse(tbValoareObs.Text));

            obsGlobale.Add(obs);

            ListViewItem item = new ListViewItem(new string[] { obs.ID.ToString(), tbValoareObs.Text });
            item.Tag = obs;
            lvObservatii.Items.Add(item);
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Adauga();
        }
        private void tbValoareObs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                e.Handled = true;
                e.SuppressKeyPress = true;
                Adauga();
             };
        }

        //Modifica
        private void Modifica()
        {
            if (lvObservatii.SelectedItems.Count == 0) return;
            if (tbValoareObs.Text == null) return;
            Observatie obs = lvObservatii.SelectedItems[0].Tag as Observatie;
            if (tbValoareObs.Text == obs.Valoare.ToString()) return;

            obs.Valoare = double.Parse(tbValoareObs.Text);
            lvObservatii.SelectedItems[0].SubItems[1].Text = tbValoareObs.Text;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Modifica();
        }

        //Sterge
        private void Sterge()
        {
            if (lvObservatii.SelectedItems.Count == 0) return;
            if (tbValoareObs.Text == null) return;
            Observatie obs = lvObservatii.SelectedItems[0].Tag as Observatie;
            if (tbValoareObs.Text == obs.Valoare.ToString()) return;

            obsGlobale.Remove(obs);
            lvObservatii.Items.Remove(lvObservatii.SelectedItems[0]);
        }
        private void btnSterge_Click(object sender, EventArgs e)
        {
           Sterge();
        }

        private void lvObservatii_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) Modifica();
            if (e.KeyCode == Keys.Delete) Sterge();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            obsGlobale.Clear();
            lvObservatii.Items.Clear();
            dgvIndici.Rows.Clear();
        }

        private void btnAfiseazaIndici_Click(object sender, EventArgs e)
        {
            ColectieStatistica colectie = new ColectieStatistica(obsGlobale);
            colGlobala.Add(colectie);

            foreach(Indice indice in colectie.Indici)
            {
                dgvIndici.Rows.Add($"i{indice.CurrentNr.ID}/{indice.BaseNr.ID}" , $"{indice.BaseNr.Valoare}" , $"{indice.CurrentNr.Valoare}" , $"{indice.Valoare}");
            }
        }
    }
}
