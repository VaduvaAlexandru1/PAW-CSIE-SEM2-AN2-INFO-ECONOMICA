using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubiectObservatii
{
    public partial class Form1 : Form
    {
        List<Observatie> obsGlobal = new List<Observatie>();
        List<ColectivitateStatistica> colGlobaL = new List<ColectivitateStatistica>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv.Columns.Add("col", "COLECTIVITATE");
            dgv.Columns.Add("obs", "OBSERVATIE");

        }

        private void btnAdaugaObs_Click(object sender, EventArgs e)
        {
            try
            {
                obsGlobal.Add(new Observatie(
                Double.Parse(tbObservatie.Text)
                , Convert.ToInt32(tbIdOBS.Text)
                )
             );
            }
            catch (Exception ex) {
                MessageBox.Show( ex.Message );
            }
            

            lvObservatii.Items.Add(
                new ListViewItem(
                    new string[]
                    {
                        tbIdOBS.Text,
                        tbObservatie.Text,
                    }
                )
            );

        }

        private void btnAdaugaColect_Click(object sender, EventArgs e)
        {
            try
            {
                ColectivitateStatistica col = new ColectivitateStatistica(
                obsGlobal,
                Convert.ToInt32(tbIdCol.Text)
            );
            
            
                lvObservatii.Items.Clear();
                obsGlobal.Clear();

                List<double> indici = new List<double>();
                for(int i = 1; i < col.Obs.Count; ++i) {
                    indici.Add(col.calculIndiceCuBazaFixa(col.Obs[1]));
                }

                for(int i = 0 ;i < indici.Count; ++i) {
                    dgv.Columns.Add("obs2", $"I{i + 1}");
                }
                for (int i = 0; i < col.Obs.Count; ++i)
                {
                    dgv.Columns.Add("obs2", $"I{i + 1}");
                }

                //dgv.Rows.Add(tbIdCol.Text , tbIdOBS.Text , );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fisiere text (*.txt)|*.txt";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofd.FileName)) {
                    obsGlobal.Clear();
                    lvObservatii.Items.Clear();
                    string linie;
                    while((linie = sr.ReadLine()) != null)
                    {
                        string[] tokens = linie.Split(new char[] {',' , ';' , ' '});
                        Observatie obs = new Observatie(
                            Double.Parse(tokens[1]),
                            Convert.ToInt32(tokens[0])
                        );

                        obsGlobal.Add(obs);
                        lvObservatii.Items.Add(
                            new ListViewItem(
                                new string[]
                                {
                                    tokens[0],
                                    tokens[1],
                                }
                            )
                        );

                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Fisiere text (*.txt)|*.txt";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (Observatie obs in obsGlobal)
                    {
                        string obsStr = $"{obs.Id};{obs.Val}";
                        sw.WriteLine(obsStr);
                    }

                }
            }

        }
    }
}
