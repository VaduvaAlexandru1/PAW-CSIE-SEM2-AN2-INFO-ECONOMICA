using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonaţiTelefonici
{
    public class Plata : ICloneable
    {
        private double suma;
        private DateTime data;
        private bool status;

        public Plata() { }
        public Plata(double suma , DateTime data , bool status)
        {
            this.suma = suma;
            this.data = data;
            this.status = status;
        }

        public double Suma
        {
            get { return suma; }
            set
            {
                if (value < 0) throw new Exception("Suma invalida");
                suma = value;
            }
        }

        public DateTime Data
        {
            get { return data; }
            set
            {
                if (value.CompareTo(new DateTime(2026, 1, 1)) < 0) throw new Exception("Data invalida");
                data = value;
            }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public object Clone()
        {
            return new Plata
            {
                Suma = this.Suma,
                Data = this.Data
            };
        }
    }
}
