using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2_1061 {
    internal class Student:Persoana , IFormaFinantare , ICloneable , IComparable{
        private const string matricolBaza = "STUD";
        private static int nrStudenti = 0;
        private string matricol;
        private double medie;
        private List<string> materii;

        public Student(string nume, int varsta, bool areOchelari, double medie)
            :base(nume, varsta, areOchelari) {
            nrStudenti++;
            matricol = matricolBaza + nrStudenti;
            this.medie = medie;
            materii = new List<string>();
        }

        public string AflaFormaFinantare()
        {
            return medie > 8 ? "Buget" : "Taxa";
        }

        public object Clone()
        {
            Student s = new Student(Nume, Varsta, AreOchelari, medie);
            return s;
        }

        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                Student s = (Student)obj;
                if(Varsta < s.Varsta) return -1;
                else if (Varsta == s.Varsta) return 0;
                else return 1;
            }

            return -2;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{Nume} ({Varsta}) {matricol} {medie}";

        }
        //s1++
        public static Student operator ++(Student s)
        {
            s.Varsta++;
            return s;
        }

        //float m = s1
        public static implicit operator float(Student s)
        {
            return (float)s.medie;
        }

        //float m = (float)s1
        //public static explicit operator float(Student s)
        //{
        //    return (float)s.medie;
        //}

        //s1 = s1 + "PAW"
        //s1 += "PAW"
        public static Student operator + (Student s , string materie)
        {
            s.materii.Add(materie);
            return s;
        }

        //s1 = s1 - "PAW"
        //s1 -= "PAW"
        public static Student operator - (Student s , string materie)
        {
            s.materii.Remove(materie);
            return s;
        }

        public static bool operator !(Student s)
        {
            return !string.IsNullOrEmpty(s.Nume);
        }

        //s1[0]
        //s1[0] = "POO"

        public string this[int index] {
            get { return materii[index]; }
            set { materii[index] = value; }
        }
        
    }
}
