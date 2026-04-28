using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect1Persoana
{
    public partial class Form1 : Form
    {
        List<Student> studenti = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = tbNume.Text;
                string prenume = tbPrenume.Text;
                int varsta = int.Parse(tbVarsta.Text);
                double medie = double.Parse(tbMedie.Text);

                List<string> materii = tbMaterii.Text.Split(new char[] {',' , ' '} , StringSplitOptions.RemoveEmptyEntries).ToList();

                Student s = new Student(nume , prenume , varsta , medie , materii);
                studenti.Add(s);
                MessageBox.Show("Student adaugat cu succes");

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tvStudenti.Nodes.Clear();

            foreach(Student student in studenti)
            {
                TreeNode root = new TreeNode(student.Matricol);

                root.Nodes.Add("Nume : " + student.Nume + " Prenume : " + student.Prenume);
                root.Nodes.Add("Varsta " + student.Varsta);
                root.Nodes.Add("Medie " + student.Medie);

                TreeNode matNode = new TreeNode("Materii");

                foreach(string materie in student.Materii)
                {
                    matNode.Nodes.Add(materie);
                }

                root.Nodes.Add(matNode);
                tvStudenti.Nodes.Add(root);
            }
        }

        private void binToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fisiere DAT|*.dat";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, studenti);
            }
        }

        private void binToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Fisiere DAT|*.dat";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                studenti = (List<Student>)bf.Deserialize(fs);
            }
            MessageBox.Show("Date incarcate cu succes");
        }

        private void txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Fisiere txt|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK) {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (Student s in studenti)
                    {
                        sw.WriteLine($"{s.Nume}|{s.Prenume}|{s.Varsta}|{s.Medie}|{string.Join(",", s.Materii)}");
                    }
                }
                    
            }
            MessageBox.Show("Salvat");
        }

        private void txtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fisiere TXT|*.txt";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                string linie;
                while ((linie = sr.ReadLine()) != null) { 
                    string[] seriliazed = linie.Trim().Split('|');

                    string nume = seriliazed[0];
                    string prenume = seriliazed[1];
                    int varsta = int.Parse(seriliazed[2]);
                    double medie = double.Parse(seriliazed[3]);

                    List<string> materii  = seriliazed[4].Split(',').ToList();

                    Student s = new Student(nume , prenume , varsta , medie , materii);

                    studenti.Add(s);
                }
            }

            MessageBox.Show("Import realizat");
        }
    }
}
