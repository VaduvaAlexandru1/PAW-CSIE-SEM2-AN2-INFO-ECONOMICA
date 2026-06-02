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

namespace SubiectDardalaPoligon
{
    public partial class Form1 : Form
    {
        List<Punct> PuncteGlobal=new List<Punct>(); 
        List<Poligon> Poligoane = new List<Poligon>();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                double x=Double.Parse(tbPunctX.Text);
                double y = Double.Parse(tbPunctY.Text);
                Punct nou=new Punct(x,y);
                PuncteGlobal.Add(nou) ;
                lvPuncte.Items.Add(
                    new ListViewItem(new string[]
                        {
                            nou.X.ToString(),
                            nou.Y.ToString()
                        })
                );

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message,"Eroare",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string culoare = tbCuloare.Text;
                string eticheta=tbEticheta.Text;
                int grosime=Convert.ToInt32(tbGrosime.Text);
                int cod=Convert.ToInt32(tbCod.Text);
                lvPoligon.Items.Add(
                    new ListViewItem(new string[]
                        {
                            tbCuloare.Text,
                            tbEticheta.Text,
                            tbGrosime.Text,
                            tbCod.Text,
                            PuncteGlobal.Count.ToString()
                        })
                );
                Poligon p1=new Poligon(PuncteGlobal,culoare,grosime,cod , eticheta);
                Poligoane.Add(p1);
                PuncteGlobal.Clear();
                lvPuncte.Items.Clear();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd=new SaveFileDialog();
            sfd.Filter = "Fisiere text (*.bin)|*.bin";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                using (BinaryWriter bw = new BinaryWriter(fs)) 
                {
                    bw.Write(Poligoane.Count);
                    foreach(var poligon in Poligoane)
                    {
                        bw.Write(poligon.Culoare);
                        bw.Write(poligon.Eticheta);
                        bw.Write(poligon.Cod_figura);
                        bw.Write(poligon.Grosime_linie);
                        bw.Write(poligon.Puncte.Count);

                        foreach(var punct in poligon.Puncte)
                        {
                            bw.Write(punct.X);
                            bw.Write(punct.Y);
                        }
                    }
                
                }

            }

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.Filter = "Fișiere binare (*.bin)|*.bin";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    Poligoane.Clear();
                    lvPoligon.Items.Clear();
                    int nrPoligoane = br.ReadInt32();
                    for(int i = 0 ; i < nrPoligoane; i++)
                    {
                        string culoare = br.ReadString();
                        string eticheta = br.ReadString();
                        int cod = br.ReadInt32();
                        int grosime = br.ReadInt32();

                        int nrPuncte = br.ReadInt32();

                        List<Punct> listaPuncte = new List<Punct>();

                        for (int j = 0; j < nrPuncte; j++)
                        {
                            double x = br.ReadDouble();
                            double y = br.ReadDouble();
                            listaPuncte.Add(new Punct(x, y));
                        }
                        Poligon p1 = new Poligon(listaPuncte, culoare, grosime, cod, eticheta);
                        Poligoane.Add(p1);

                        lvPoligon.Items.Add(
                            new ListViewItem( new string[]
                            {
                                culoare,
                                eticheta,
                                grosime.ToString(),
                                cod.ToString(),
                                nrPuncte.ToString()
                            })
                        );
                    }
                    
                }
            }
        }

       
    }
}
