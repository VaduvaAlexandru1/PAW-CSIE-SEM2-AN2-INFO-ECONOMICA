using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubiectDardalaPoligon
{
    internal class Punct
    {
        private double x;
        private double y;

        public Punct(double x, double y)
        {
            if (x < 0 || y < 0) throw new Exception("Sugi pula darius");
            this.x = x;
            this.y = y;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public override string ToString()
        {
            return $"Punctul X: {x}, Punctul Y: {y}";
        }
    }
    
}
