using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    internal class Persoana:CalculeazaAnNastere
    {
        private string nume;
        private int varsta;
        bool _areOchelari;

        public Persoana() { 
            nume = string.Empty;
            varsta = 0;
            _areOchelari = false;
        }

        public Persoana(string nume, int varsta , bool areOChelari)
        {
            this.nume = nume;
            this.varsta = varsta;
            _areOchelari = areOChelari;
        }

        public string Nume { 
            get { return nume; }
            set { nume = value; }
        }

        public int Varsta { 
            get => varsta;
            set => varsta = value;
        }

        public bool AreOchelari
        {
            get => _areOchelari;
            set => _areOchelari = value;
        }

        public override int AflaAnNastere()
        {
            return DateTime.Now.Year - varsta;
        }
    }


}
