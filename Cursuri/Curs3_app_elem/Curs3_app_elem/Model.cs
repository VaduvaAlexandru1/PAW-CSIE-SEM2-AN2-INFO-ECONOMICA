using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3_app_elem
{
    class Element
    {
        public event Action<Element> Ev_Modificare_Valoare;
        int vel;
        public Element() { vel = 0; }
        public int Valoare
        {
            get => vel;
            set
            {
                if (vel != value)
                {
                    vel = value;
                    if(Ev_Modificare_Valoare!=null)
                        Ev_Modificare_Valoare(this);
                }
            }
        }

        public int Patrat => this.vel * this.vel;
    }
}
