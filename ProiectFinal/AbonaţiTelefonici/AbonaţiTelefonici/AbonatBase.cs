using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonaţiTelefonici
{
    public abstract class AbonatBase
    {
        private string nume;
        private string telefon;

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        public abstract double CalculTotal();
    }
}
