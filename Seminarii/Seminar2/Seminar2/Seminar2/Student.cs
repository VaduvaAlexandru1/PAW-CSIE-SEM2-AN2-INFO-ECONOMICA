using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    internal class Student : Persoana
    {
        private const string matricolBaza = "STUD";
        private static int nrStudendi = 0;
        private string matricol;
        private double medie;
        private List<string> materii;

        public Student(string nume, int varsta , bool areOchelari ,double medie ) : base(nume , varsta , areOchelari)
        {
            nrStudendi++;
            matricol = matricolBaza + nrStudendi;
            this.medie = medie;
            materii = new List<string>();
        }
    }
}
