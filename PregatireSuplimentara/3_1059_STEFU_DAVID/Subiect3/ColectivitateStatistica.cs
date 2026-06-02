using System;
using System.Collections.Generic;
using System.Linq;

namespace Subiect3
{
    public class ColectivitateStatistica
    {
        public List<double> Observatii { get; set; }

        public event EventHandler DateModificate;

        public ColectivitateStatistica()
        {
            Observatii = new List<double>();
        }

        public void Adauga(double x)
        {
            Observatii.Add(x);
            DateModificate?.Invoke(this, EventArgs.Empty);
        }

        public void Modifica(int index, double valoare)
        {
            if (index >= 0 && index < Observatii.Count)
            {
                Observatii[index] = valoare;
                DateModificate?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Sterge(int index)
        {
            if (index >= 0 && index < Observatii.Count)
            {
                Observatii.RemoveAt(index);
                DateModificate?.Invoke(this, EventArgs.Empty);
            }
        }

        public List<double> GetPonderi()
        {
            double suma = Observatii.Sum();

            return Observatii
                .Select(x => x / suma)
                .ToList();
        }
    }
}