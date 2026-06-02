using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Subiect3
{
    public partial class Form1 : Form
    {
        ColectivitateStatistica colectie = new ColectivitateStatistica();
        PieChartControl pie = new PieChartControl();

        public Form1()
        {
            InitializeComponent();

            pie.Location = new Point(450, 20);
            pie.Size = new Size(300, 300);

            Controls.Add(pie);

            colectie.DateModificate += Colectie_DateModificate;

            dgv.Columns.Add("Obs", "Observatie");
            dgv.Columns.Add("Pond", "Pondere");
        }

        private void Colectie_DateModificate(object sender, EventArgs e)
        {
            dgv.Rows.Clear();

            List<double> p = colectie.GetPonderi();

            for (int i = 0; i < colectie.Observatii.Count; i++)
            {
                dgv.Rows.Add(colectie.Observatii[i], p[i]);
            }

            pie.Ponderi = p;
            pie.Invalidate();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtObs.Text, out double x))
                colectie.Adauga(x);
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
                return;

            if (double.TryParse(txtObs.Text, out double x))
                colectie.Modifica(dgv.CurrentRow.Index, x);
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
                return;

            colectie.Sterge(dgv.CurrentRow.Index);
        }

        private void txtObs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdauga.PerformClick();
            }
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnSterge.PerformClick();
            }
        }
    }
}