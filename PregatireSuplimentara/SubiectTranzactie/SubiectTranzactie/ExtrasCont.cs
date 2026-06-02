using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubiectTranzactie
{
    internal class ExtrasCont
    {
        private string numeClient;
        private string adresa;
        private List<Tranzactie> tranzatii;

        public ExtrasCont(string numeClient, string adresa, List<Tranzactie> tranzatii)
        {
            this.numeClient = numeClient;
            this.adresa = adresa;
            this.tranzatii = tranzatii;
        }

        public string NumeClient { get => numeClient; set => numeClient = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        internal List<Tranzactie> Tranzatii { get => tranzatii; set => tranzatii = value; }

        public Tranzactie this[int index]
        {
            get
            {
                if(index<0||index>Tranzatii.Count) throw new Exception("it's too big for me, said darius");
                return tranzatii[index];
            }
            set
            {
                if (index < 0 || index > Tranzatii.Count) throw new Exception("it's too big for me, said darius");
                tranzatii[index]=value;
            }
        }
    }
}
