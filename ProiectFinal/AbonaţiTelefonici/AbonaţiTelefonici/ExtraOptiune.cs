using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonaţiTelefonici
{
    public class ExtraOptiune : ICloneable
    {
        private string nume;
        private double cost;

        public ExtraOptiune() { }
        public ExtraOptiune(string nume, double cost)
        {
            this.nume = nume;
            this.cost = cost;
        }

        public string Nume
        {
            get { return nume; }
            set
            {
                if(string.IsNullOrEmpty(value)) throw new ArgumentNullException("Numele trebuie completat!");
                nume = value;
            }
        }

        public double Cost
        {
            get { return cost; }
            set
            {
                if (cost < 0) throw new Exception("Cost invalid");
                cost = value;
            }
        }

        public object Clone()
        {
            return new ExtraOptiune
            {
                Nume = this.Nume,
                Cost = this.Cost
            };
        }

        public override string ToString()
        {
            return $"{Nume} - {Cost} eur";
        }
    }
}
