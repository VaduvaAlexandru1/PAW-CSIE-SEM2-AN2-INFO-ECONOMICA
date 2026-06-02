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

namespace SubiectTranzactie
{
    public partial class Form1 : Form
    {
        List<ExtrasCont> exCont = new List<ExtrasCont>();
        List<Tranzactie> tranzactiiGlobal= new List<Tranzactie>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = tbNume.Text;
                string adresa=tbAdresa.Text;
                List<Tranzactie> tranzactii = new List<Tranzactie>();
                tranzactii.Add(tranzactiiGlobal[cbTranzactii.SelectedIndex]);
                MessageBox.Show("Datele au fost introduse cu succes", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ExtrasCont ex = new ExtrasCont(nume, adresa, tranzactii);
                exCont.Add(ex);

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tranzactiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fisiere tetx (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    tranzactiiGlobal.Clear();
                    string linie;
                    while ((linie = sr.ReadLine()) != null)
                    {
                        string[] tokens = linie.Split(';');
                        //ID;IBAN;Detalii;Suma;Data
                        int idTranzactie = int.Parse(tokens[0]);
                        string IBAN = tokens[1];
                        string detalii = tokens[2];
                        double Suma = double.Parse(tokens[3]);
                        DateTime data = DateTime.Parse(tokens[4]);
                        Tranzactie tr = new Tranzactie(idTranzactie, IBAN, detalii, Suma, data);
                        cbTranzactii.Items.Add(tr);
                        tranzactiiGlobal.Add(tr);
                    }
                  
                }
            }
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(var ex in exCont)
                {
                    string tr = "";
                    foreach(var tranzactie in ex.Tranzatii)
                    {
                        tr += tranzactie.ToString();
                        tr += ", ";
                    }
                    lvTranzactii.Items.Add(new ListViewItem(new string[]
                    {
                        ex.NumeClient.ToString(),ex.Adresa.ToString(),tr
                    }));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Eroare",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvTranzactii.SelectedItems.Count == 0) return;
            ListViewItem item = lvTranzactii.SelectedItems[0];

            ExtrasCont ex = exCont.Find(x => x.NumeClient == item.SubItems[0].Text);

            string nume = item.SubItems[0].Text;
            string adresa= item.SubItems[1].Text;
            string tranzactie= item.SubItems[2].Text;
            if (!string.IsNullOrEmpty(tbNume.Text) && nume != tbNume.Text){
                nume = tbNume.Text;
            }
            if (!string.IsNullOrEmpty(tbAdresa.Text) && adresa != tbAdresa.Text)
            {
                adresa=tbAdresa.Text;
            }
            if (cbTranzactii.SelectedIndex != -1)
            {
                tranzactie=cbTranzactii.SelectedItem.ToString();
            }

            item.SubItems[0].Text = nume;
            item.SubItems[1].Text = adresa;
            item.SubItems[2].Text = tranzactie;

            ex.NumeClient = nume;
            ex.Adresa = adresa;
            ex.Tranzatii.Clear();


            
        }
    }
}
