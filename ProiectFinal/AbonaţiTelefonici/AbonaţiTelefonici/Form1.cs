using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;

namespace AbonaţiTelefonici
{
    public partial class Form1 : Form
    {
        List<Client> clienti = new List<Client>();
        List<ExtraOptiune> extraOptiuni = new List<ExtraOptiune>();
        Client clientCurent = null;
        string conn = @"Server=(localdb)\MSSQLLocalDB;Database=AbonatiDB;Trusted_Connection=True;";
        Client clientPrinat = null;
        private PrintDocument printDocument = new PrintDocument();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("Venituri pe tip abonament");
            LoadChart();
            extraOptiuni.Add(new ExtraOptiune("Roaming" , 10));
            extraOptiuni.Add(new ExtraOptiune("Internet extra" , 5));
            extraOptiuni.Add(new ExtraOptiune("TV mobil" , 8));

            clbExtraOptiuni.Items.Clear();
            foreach (var opt in extraOptiuni) { 
                clbExtraOptiuni.Items.Add(opt); 
            }

            cbAbonamente.Items.Add(new TipAbonament("Basic", 5));
            cbAbonamente.Items.Add(new TipAbonament("Standard", 8));
            cbAbonamente.Items.Add(new TipAbonament("Premium", 12));
            cbAbonamente.Items.Add(new TipAbonament("Unlimited", 15));

            LoadClienti();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNume.Text))
            {
                MessageBox.Show("Nume invalid");
                return;
            }

            if (!validareTlf(tbTelefon.Text))
            {
                MessageBox.Show("Telefon invalid");
                return;
            }

            if (cbAbonamente.SelectedItem == null)
            {
                MessageBox.Show("Selectează un abonament");
                return;
            }

            string nume = tbNume.Text;
            string Telefon = tbTelefon.Text;

            TipAbonament abonament = (TipAbonament)cbAbonamente.SelectedItem;

            List<ExtraOptiune> selectate = new List<ExtraOptiune>();

            foreach (var item in clbExtraOptiuni.CheckedItems)
            {
                selectate.Add((ExtraOptiune)item);
            }

            Client c = new Client();
            c.Nume = nume;
            c.Telefon = Telefon;
            c.TipAbonament = abonament;

            foreach (var item in selectate) {
                c.AdaugaExtraOptiune(item);
            }

            clienti.Add(c);

            ResetDgv(dgvClienti, clienti);
            //adaugare in baza de date
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Clienti (Nume, Telefon, TipAbonament) VALUES (@n, @t, @a)", con);

                cmd.Parameters.AddWithValue("@n", tbNume.Text);
                cmd.Parameters.AddWithValue("@t", tbTelefon.Text);
                cmd.Parameters.AddWithValue("@a", ((TipAbonament)cbAbonamente.SelectedItem).Nume);

                cmd.ExecuteNonQuery();
            }

        }
        private void LoadClienti()
        {
            clienti.Clear();

            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Clienti", con);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Client c = new Client();

                    c.Nume = dr["Nume"].ToString();
                    c.Telefon = dr["Telefon"].ToString();

                    string tip = dr["TipAbonament"].ToString();

                    c.TipAbonament = cbAbonamente.Items
                        .Cast<TipAbonament>()
                        .FirstOrDefault(x => x.Nume == tip)
                        ?? new TipAbonament(tip, 0); 

                    clienti.Add(c);
                }
            }

            dgvClienti.DataSource = null;
            dgvClienti.DataSource = clienti;
        }
        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvClienti.CurrentRow == null) return;

            Client c = dgvClienti.CurrentRow.DataBoundItem as Client;

            clienti.Remove(c);

            ResetDgv(dgvClienti, clienti);

            if (clientCurent == c)
            {
                ClearDetalii();
                clientCurent = null;
            }
            //stergere din baza de date
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Clienti WHERE Nume = @n AND Telefon = @t", con);

                cmd.Parameters.AddWithValue("@n", c.Nume);
                cmd.Parameters.AddWithValue("@t", c.Telefon);

                cmd.ExecuteNonQuery();
            }

            LoadClienti();
        }
        private void ClearDetalii()
        {
            tbNume2.Text = "";
            tbTelefon2.Text = "";
            tbAbonament2.Text = "";
            tbExtraCost.Text = "";
            tbTotal.Text = "";
        }

        private void ResetDgv<T>(DataGridView dgv, List<T> source)
        {
            dgv.DataSource = null;
            dgv.DataSource = source;
            LoadChart();
        }

        private bool validareTlf(string tlf)
        {
            if (string.IsNullOrWhiteSpace(tlf))
                return false;

            tlf = tlf.Trim().Replace(" ", "");

            return Regex.IsMatch(tlf, @"^(07\d{8}|\+407\d{8}|00407\d{8})$");
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dgvClienti.CurrentRow == null)
                return;

            Client c = (Client)dgvClienti.CurrentRow.DataBoundItem;

            if (!string.IsNullOrWhiteSpace(tbNume.Text))
                c.Nume = tbNume.Text;

            if (validareTlf(tbTelefon.Text))
                c.Telefon = tbTelefon.Text;
            if (cbAbonamente.SelectedItem != null)
                c.TipAbonament = (TipAbonament)cbAbonamente.SelectedItem;

            c.clearExtraOptiuni();

            foreach (var item in clbExtraOptiuni.CheckedItems)
            {
                c.AdaugaExtraOptiune((ExtraOptiune)item);
            }

            ResetDgv(dgvClienti, clienti);

            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Clienti 
              SET Nume = @n, Telefon = @t, TipAbonament = @a 
              WHERE ClientId = @id", con);

                cmd.Parameters.AddWithValue("@n", tbNume.Text);
                cmd.Parameters.AddWithValue("@t", tbTelefon.Text);
                cmd.Parameters.AddWithValue("@a", ((TipAbonament)cbAbonamente.SelectedItem).Nume);
                cmd.Parameters.AddWithValue("@id", c.Id);

                cmd.ExecuteNonQuery();
            }

            LoadClienti();
        }

        private void dgvClienti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClienti.CurrentRow == null || dgvClienti.CurrentRow.DataBoundItem == null)
                return;

            clientCurent = (Client)dgvClienti.CurrentRow.DataBoundItem;

            tbNume2.Text = clientCurent.Nume ?? "";
            tbTelefon2.Text = clientCurent.Telefon ?? "";

            tbAbonament2.Text =
                clientCurent.TipAbonament != null
                ? clientCurent.TipAbonament.Nume
                : "";

            double extraCost = clientCurent.ExtraOptiuni?.Sum(x => x.Cost) ?? 0;
            double abonCost = clientCurent.TipAbonament?.PretLunar ?? 0;

            tbExtraCost.Text = extraCost + " €";
            tbTotal.Text = clientCurent.CalculTotal() + " €";
        }

        private void txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt";
                sfd.FileName = "clienti.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        foreach (Client c in clienti)
                        {
                            string extra = string.Join(";", c.ExtraOptiuni.Select(x => x.Nume));

                            sw.WriteLine($"{c.Nume}|{c.Telefon}|{c.TipAbonament.Nume}|{extra}");
                        }
                    }
                }
            }
        }

        private void txtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text files (*.txt)|*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    clienti.Clear();

                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            var parts = line.Split('|');

                            if (parts.Length < 3)
                                continue;

                            Client c = new Client();
                            c.Nume = parts[0];
                            c.Telefon = parts[1];

                            string numeAbonament = parts[2];

                            c.TipAbonament = cbAbonamente.Items
                                .Cast<TipAbonament>()
                                .FirstOrDefault(x => x.Nume == numeAbonament);

                            if (parts.Length > 3 && !string.IsNullOrEmpty(parts[3]))
                            {
                                var extras = parts[3].Split(';');

                                foreach (var optName in extras)
                                {
                                    var opt = extraOptiuni.FirstOrDefault(x => x.Nume == optName);

                                    if (opt != null)
                                        c.AdaugaExtraOptiune(opt);
                                }
                            }

                            clienti.Add(c);
                        }
                    }

                    ResetDgv(dgvClienti, clienti);
                }
            }
        }

        private void binToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Binary files (*.bin)|*.bin";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    clienti.Clear();

                    using (BinaryReader br = new BinaryReader(File.Open(ofd.FileName, FileMode.Open)))
                    {
                        int count = br.ReadInt32();

                        for (int i = 0; i < count; i++)
                        {
                            Client c = new Client();

                            c.Nume = br.ReadString();
                            c.Telefon = br.ReadString();

                            string numeAbonament = br.ReadString();

                            c.TipAbonament = cbAbonamente.Items
                                .Cast<TipAbonament>()
                                .FirstOrDefault(x => x.Nume == numeAbonament);

                            int nrOpt = br.ReadInt32();

                            for (int j = 0; j < nrOpt; j++)
                            {
                                string numeOpt = br.ReadString();
                                double cost = br.ReadDouble();

                                var opt = extraOptiuni.FirstOrDefault(x => x.Nume == numeOpt);

                                if (opt != null)
                                    c.AdaugaExtraOptiune(opt);
                            }

                            clienti.Add(c);
                        }
                    }

                    ResetDgv(dgvClienti, clienti);
                }
            }
        }

        private void binToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Binary files (*.bin)|*.bin";
                sfd.FileName = "clienti.bin";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (BinaryWriter bw = new BinaryWriter(File.Open(sfd.FileName, FileMode.Create)))
                    {
                        bw.Write(clienti.Count);

                        foreach (Client c in clienti)
                        {
                            bw.Write(c.Nume);
                            bw.Write(c.Telefon);
                            bw.Write(c.TipAbonament.Nume);

                            bw.Write(c.ExtraOptiuni.Count);

                            foreach (var opt in c.ExtraOptiuni)
                            {
                                bw.Write(opt.Nume);
                                bw.Write(opt.Cost);
                            }
                        }
                    }
                }
            }
        }

        private void xmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "XML files (*.xml)|*.xml";
                sfd.FileName = "clienti.xml";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));

                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        serializer.Serialize(fs, clienti);
                    }
                }
            }
        }

        private void xmlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML files (*.xml)|*.xml";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));

                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                    {
                        clienti = (List<Client>)serializer.Deserialize(fs);
                    }

                    ResetDgv(dgvClienti, clienti);
                }
            }
        }

        private void LoadChart()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            chart1.Titles.Add("Venituri pe tip abonament");

            var serie = chart1.Series.Add("Venituri");
            serie.ChartType = SeriesChartType.Column;

            var grup = clienti
                .GroupBy(c => c.TipAbonament.Nume)
                .Select(g => new
                {
                    Tip = g.Key,
                    Total = g.Sum(x =>
                        x.TipAbonament.PretLunar +
                        x.ExtraOptiuni.Sum(o => o.Cost))
                });

            foreach (var item in grup)
            {
                serie.Points.AddXY(item.Tip, item.Total);
            }
        }

        private void clientCurentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvClienti.CurrentRow == null)
                return;
            if (clientCurent == null)
            {
                MessageBox.Show("Selectează un client!");
                return;
            }


            clientPrintat = (Client)dgvClienti.CurrentRow.DataBoundItem;

            printDocument.PrintPage -= PrintDocument_PrintPage;
            printDocument.PrintPage += PrintDocument_PrintPage;

            printDocument.Print();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            float y = 20;
            Font font = new Font("Arial", 12);

            e.Graphics.DrawString("RAPORT CLIENT", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 20, y);
            y += 40;

            e.Graphics.DrawString("Nume: " + clientCurent.Nume, font, Brushes.Black, 20, y); y += 25;
            e.Graphics.DrawString("Telefon: " + clientCurent.Telefon, font, Brushes.Black, 20, y); y += 25;
            e.Graphics.DrawString("Abonament: " + clientCurent.TipAbonament.Nume, font, Brushes.Black, 20, y); y += 25;

            string extra = string.Join(", ", clientCurent.ExtraOptiuni.Select(x => x.Nume));
            e.Graphics.DrawString("Extra: " + extra, font, Brushes.Black, 20, y); y += 25;

            double total = clientCurent.TipAbonament.PretLunar +
                           clientCurent.ExtraOptiuni.Sum(x => x.Cost);

            e.Graphics.DrawString("Total: " + total + " €", font, Brushes.Black, 20, y);
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                MessageBox.Show("DB conectată cu succes!");
            }
        }
    }
}
