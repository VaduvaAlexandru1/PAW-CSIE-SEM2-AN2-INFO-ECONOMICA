using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect1Persoana
{
    [Serializable]
    internal class Persoana
    {
        private string nume;
        private string prenume;
        private int varsta;

        public Persoana(string nume, string prenume, int varsta)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
        }

        public string Nume
        {
            get => nume;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Nume invalid");
                nume = value;
            }
        }

        public string Prenume
        {
            get => prenume;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Prenume invalid");
                prenume = value;
            }
        }

        public int Varsta
        {
            get => varsta;
            set
            {
                if (varsta <= 0) throw new Exception("Varsta invalida");
                varsta = value;
            }
        }

        public override string ToString()
        {
            return $"Nume : {Nume} , Prenume : {Prenume} , Varsta : {Varsta} ani";
        }
    }


}
