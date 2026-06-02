using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubiectNr2
{
    public class Indice
    {
        private Observatie baseNr;
        private Observatie currentNr;
        private readonly double valoare;

        public Observatie BaseNr { get => baseNr; set { baseNr = value; CalculValoare(); } }
        public Observatie CurrentNr { get => currentNr; set { currentNr = value; CalculValoare(); } }

        public double Valoare => valoare;

        public Indice(Observatie baseNr, Observatie currentNr)
        {
            this.baseNr = baseNr;
            this.currentNr = currentNr;
            
        }

        private double CalculValoare() => currentNr.Valoare / baseNr.Valoare;
    }
}
