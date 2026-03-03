using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2_1061 {
    internal class Persoana:CalculeazaAnNastere {
        private string nume;
        private int varsta;
        bool _areOchelari;

        //public int NumeAtribut { get; set; }

        public Persoana() {
            nume = string.Empty;
            varsta = 0;
            _areOchelari = false;
        }

        public Persoana(string nume, int varsta, bool areOchelari) {
            this.nume = nume;
            this.varsta = varsta;
            _areOchelari = areOchelari;
        }

        public string Nume {
            get {
                if (nume.Length > 0) {
                    return nume;
                }
                else { return string.Empty; }
            }
            set { nume = value; }
        }

        public int Varsta {
            get => varsta;
            //set => varsta = value;
            set {
                if (value < 0)
                    varsta = 0;
                else varsta = value;
            }
        }

        public bool AreOchelari {
            get => _areOchelari;
            set {
                _areOchelari = value;
            }
        }

        public override int AflaAnNastere() {
            return DateTime.Now.Year - varsta;
        }
    }
}
