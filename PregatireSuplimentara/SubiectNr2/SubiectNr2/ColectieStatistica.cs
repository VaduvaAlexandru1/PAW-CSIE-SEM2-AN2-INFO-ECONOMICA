using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubiectNr2
{
    public class ColectieStatistica
    {
        private List<Observatie> obs = new List<Observatie>();
        private List<Indice> indici = new List<Indice>();

        public ColectieStatistica(List<Observatie> obs)
        {
            this.obs = obs;
            initIndici();
        }
        private void initIndici()
        {
            for (int i = 1; i < obs.Count; i++)
            {
                indici.Add(new Indice(obs[i], obs[i - 1]));
            }
        }
        public List<Observatie> Obs { get => obs; set { obs = value; initIndici(); } }
        public List<Indice> Indici { get => indici; set => indici = value; }
    }
}
