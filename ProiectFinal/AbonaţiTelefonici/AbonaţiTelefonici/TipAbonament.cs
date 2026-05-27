using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonaţiTelefonici
{
    public class TipAbonament : IComparable
    {
        private string nume;
        private double pretLunar;

        public TipAbonament() { }
        public TipAbonament(string nume, double pretLunar)
        {
            this.nume = nume;
            this.pretLunar = pretLunar;
        }
        public string Nume
        {
            get { return nume; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Numele trebuie completat!");
                nume = value;
            }
        }

        public double PretLunar
        {
            get { return pretLunar;}
            set
            {
                if (pretLunar < 0) throw new Exception("Pret invalid");
                pretLunar = value;
            }
        }

        public int CompareTo(object obj) { 
            TipAbonament t = (TipAbonament)obj;
            return pretLunar.CompareTo(t.pretLunar);
        }

        public static bool operator >(TipAbonament a, TipAbonament b) {
            return a.PretLunar > b.pretLunar;
        }

        public static bool operator <(TipAbonament a, TipAbonament b) { 
            return a.PretLunar < b.pretLunar;
        }

        public override string ToString()
        {
            return $"{Nume} - {PretLunar} €";
        }

    }
}
