using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubiectObservatii
{
    public class Observatie
    {
        private double val;
        private readonly int id;

        public double Val { get => val; set => val = value; }

        public int Id => id;

        public Observatie(double val, int id)
        {
            if (id < 0) throw new Exception("Id ul nu poate fi negativ");
            this.val = val;
            this.id = id;
        }
    }

}
