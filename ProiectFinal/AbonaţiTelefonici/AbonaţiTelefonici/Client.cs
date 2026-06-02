using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonaţiTelefonici
{
    public class Client : AbonatBase, ICloneable, IComparable
    {
        public int Id { get; set; }

        private TipAbonament tipAbonament;
        private List<ExtraOptiune> extraOptiuni = new List<ExtraOptiune>();
        private List<Plata> plati = new List<Plata>();

        public Client() { }

        public Client(
            string nume,
            string telefon,
            TipAbonament tipAbonament,
            List<ExtraOptiune> extraOptiuni,
            List<Plata> plati)
        {
            this.Nume = nume;
            this.Telefon = telefon;
            this.tipAbonament = tipAbonament;
            this.ExtraOptiuni = extraOptiuni;
            this.plati = plati;
        }

        public override double CalculTotal()
        {
            double extra = ExtraOptiuni?.Sum(x => x.Cost) ?? 0;
            double abon = TipAbonament?.PretLunar ?? 0;

            return extra + abon;
        }

        public TipAbonament TipAbonament
        {
            get { return tipAbonament; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Abonament invalid");

                tipAbonament = value;
            }
        }

        internal List<ExtraOptiune> ExtraOptiuni
        {
            get => extraOptiuni;
            set => extraOptiuni = value;
        }

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
            if (extraOptiune == null)
                throw new Exception("Optiune invalida");

            ExtraOptiuni.Add(extraOptiune);
        }

        public static Client operator +(Client c, ExtraOptiune e)
        {
            c.AdaugaExtraOptiune(e);
            return c;
        }

        public ExtraOptiune this[int index]
        {
            get { return ExtraOptiuni[index]; }
            set { ExtraOptiuni[index] = value; }
        }

        public void clearExtraOptiuni()
        {
            ExtraOptiuni.Clear();
        }
    }
}