using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubiectObservatii
{
    public class ColectivitateStatistica
    {
        private readonly int id;
        private List<Observatie> obs = new List<Observatie>();

        public ColectivitateStatistica(List<Observatie> obs , int id)
        {
            if (obs == null) throw new Exception("Lista de observatii nu poate sa fie nula");
            this.obs = obs;
            this.id = id;
        }

        public List<Observatie> Obs { get => obs; set => obs = value; }

        public int Id => id;

        public double calculIndiceCuBazaFixa(Observatie o)
        {
            if(o.Val == obs[0].Val) return 0;
            return o.Val / obs[0].Val;
        }
    }
}
