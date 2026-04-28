using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect1Persoana
{
    [Serializable]
    internal class Student : Persoana
    {
        private const string codMatricol = "SP";
        private static int nrStudenti = 0;

        private string matricol;
        private double medie;
        private List<string> materii;

        public Student(string nume , string prenume , int varsta , double medie , List<string> materii) : base(nume , prenume , varsta) 
        {
            nrStudenti++;
            matricol = codMatricol+nrStudenti;
            this.medie = medie;
            this.materii = materii;
        }

        public string Matricol => matricol;

        public double Medie
        {
            get => medie;
            set
            {
                if (value < 0 || value > 10) throw new Exception("Medie invalida");
                medie = value;
            }
        }

        public List<string> Materii => materii;

        public override string ToString()
        {
            return base.ToString() + $" | {matricol} | Medie : {medie} | Materii : {string.Join(", ", materii)}";
        }

        public static Student operator +(Student s ,  string materie)
        {
            s.materii.Add(materie);
            return s ;
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index > materii.Count) throw new Exception("Index invalid");
                return materii[index];
            }
        }
    }
}
