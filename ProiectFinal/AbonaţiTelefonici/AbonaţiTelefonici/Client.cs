using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonaţiTelefonici
{
    public class Client : ICloneable , IComparable
    {
        public int Id { get; set; }
        private string nume;
        private string telefon;
        private TipAbonament tipAbonament;
        private List<ExtraOptiune> extraOptiuni = new List<ExtraOptiune>();
        private List<Plata> plati = new List<Plata>();

        public Client() { }
        public Client(string nume, string telefon, TipAbonament tipAbonament, List<ExtraOptiune> extraOptiuni, List<Plata> plati)
        {
            this.nume = nume;
            this.telefon = telefon;
            this.tipAbonament = tipAbonament;
            this.ExtraOptiuni = extraOptiuni;
            this.plati = plati;
        }

        public string Nume
        {
            get { return nume; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Numele trebuie completat!");
                nume = value;
            }
        }

        public string Telefon
        {
            get { return telefon; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Numarul de telefon trebuie completat!");
                telefon = value;
            }
        }

        public TipAbonament TipAbonament { 
            get { return tipAbonament; }
            set {
                if(value == null) throw new ArgumentNullException("Abonament invalid");
                tipAbonament = value;
            }
        }

        internal List<ExtraOptiune> ExtraOptiuni { get => extraOptiuni; set => extraOptiuni = value; }

        public object Clone()
        {
            return new Client
            {
                Nume = this.Nume,
                Telefon = this.Telefon,
                TipAbonament = this.TipAbonament,

                ExtraOptiuni = this.ExtraOptiuni
                .Select(e => (ExtraOptiune)e.Clone())
                .ToList(),

                plati = this.plati
                .Select(p => (Plata)p.Clone())
                .ToList()
            };
        }

        public int CompareTo(object obj)
        {
            Client c = (Client)obj;
            return Nume.CompareTo(c.Nume);
        }

        public void AdaugaExtraOptiune(ExtraOptiune extraOptiune)
        {
            if (extraOptiune == null) throw new Exception("Optiune invalida");
            ExtraOptiuni.Add(extraOptiune);
        }

        public static Client operator +(Client c , ExtraOptiune e)
        {
            c.AdaugaExtraOptiune(e);
            return c;
        }
        public ExtraOptiune this[int index]
        {
            get { return ExtraOptiuni[index]; }
            set {  ExtraOptiuni[index] = value;}
        }
        public void clearExtraOptiuni() {
            ExtraOptiuni.Clear();
        }

    }
}
