using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubiectNr2
{
    public class Observatie
    {
        private readonly int id = 0;
        private static int generator = 0;
        private double valoare;

        public Observatie(double valoare)
        {
            this.valoare = valoare;
            id = generator++;
        }

        public int ID => id;

        public double Valoare { get => valoare; set => valoare = value; }
    }
}
