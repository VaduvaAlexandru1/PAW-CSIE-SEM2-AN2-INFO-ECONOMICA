using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2_1061 {
    internal abstract class CalculeazaAnNastere {
        public abstract int AflaAnNastere();

        public void Afiseaza() {
            Console.WriteLine("S-a apelat ceva din clasa abstracta");
        }
    }
}
