using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubiectDardalaPoligon
{
    internal class Poligon
    {
        private List<Punct> puncte;
        private string culoare;
        private int grosime_linie;
        readonly int cod_figura;
        private string eticheta;

        internal List<Punct> Puncte { get => puncte; set => puncte = value; }
        public string Culoare { get => culoare; set => culoare = value; }
        public int Grosime_linie { get => grosime_linie; set => grosime_linie = value; }

        public int Cod_figura => cod_figura;

        public string Eticheta { get => eticheta; set => eticheta = value; }

        public Poligon(List<Punct> puncte, string culoare, int grosime_linie, int cod_figura, string eticheta)
        {
            if (grosime_linie <= 0) throw new Exception("2 3 maini pe 100");
            //if (puncte.Count < 3) throw new Exception("Poligonul trebuie sa aiba minim 3 puncte");
            this.puncte = puncte;
            this.culoare = culoare;
            this.grosime_linie = grosime_linie;
            this.cod_figura = cod_figura;
            this.eticheta = eticheta;
        }
        public double CalculPerimetru()
        {
            double perimetru = 0;
            for (int i = 0; i < puncte.Count; i++)
            {
                Punct p1 = puncte[i];
                Punct p2 = puncte[(i + 1) % puncte.Count];

                double dx = p2.X - p1.X;
                double dy = p2.Y - p1.Y;

                perimetru += Math.Sqrt(dx * dx + dy * dy);
            }

            return perimetru;
        }

        public Punct this[int index]
        {
            get
            {
                if (index < 0 || index >= puncte.Count) throw new ArgumentOutOfRangeException("Index out of bounds");
                return puncte[index];
            }
            set
            {
                if (index < 0 || index >= puncte.Count) throw new ArgumentOutOfRangeException("Index out of bounds");
                puncte[index] = value;
            }
        }

    }
}
