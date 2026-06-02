using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubiectTranzactie
{
    internal class Tranzactie
    {
        private readonly int idTranzactie;
        private string constIBAN;
        private string detaliiTranzactie;
        private double suma;
        private DateTime dataTranzactie;

        public Tranzactie(int idTranzactie, string constIBAN, string detaliiTranzactie, double suma, DateTime dataTranzactie)
        {
            this.idTranzactie = idTranzactie;
            this.constIBAN = constIBAN;
            this.detaliiTranzactie = detaliiTranzactie;
            this.suma = suma;
            this.dataTranzactie = dataTranzactie;
        }

        public int IdTranzactie => idTranzactie;

        public string ConstIBAN { get => constIBAN; set => constIBAN = value; }
        public string DetaliiTranzactie { get => detaliiTranzactie; set => detaliiTranzactie = value; }
        public double Suma { get => suma; set => suma = value; }
        public DateTime DataTranzactie { get => dataTranzactie; set => dataTranzactie = value; }

        public override string ToString()
        {
            return $"{idTranzactie} {constIBAN} {detaliiTranzactie} {Suma} {dataTranzactie}";
        }
    }
}
