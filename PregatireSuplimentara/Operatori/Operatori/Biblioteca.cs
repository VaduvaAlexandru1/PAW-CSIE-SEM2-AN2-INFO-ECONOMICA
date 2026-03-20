using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori
{
    internal class Biblioteca
    {
        public int NrCarti {  get; private set; }
        public string Nume { get; private set; }
        private List<Carte> Carti = new List<Carte>();

        public Biblioteca(string nume = null)
        {
            NrCarti = 0;
            Nume = string.IsNullOrEmpty(nume) ? "Anonim" : nume.Trim();
        }
        /// <summary>
        /// Adds a Book (Carte) to the Library (Biblioteca) and updates the number of books.
        /// </summary>
        /// <param name="b">The Library (Biblioteca) to which The Book (Carte) will be added.</param>
        /// <param name="carte">The Book (Carte) to add to the Biblioteca.</param>
        /// <returns>The Library (Biblioteca) instance with the added Book (Carte).</returns>
        public static Biblioteca operator + (Biblioteca b , Carte carte)
        {
            b.Carti.Add (carte);
            b.NrCarti++;
            return b;
        }

        /// <summary>
        /// Determines whether the Biblioteca contains any books.
        /// </summary>
        /// <param name="b">The Biblioteca instance to evaluate.</param>
        /// <returns>true if the Biblioteca contains one or more books; otherwise, false.</returns>
        public static bool operator ! (Biblioteca b)
        {
            return b.Carti.Count () > 0;
        }
        
        public Carte this[int index]
        {
            get
            {
                if (index < 0 || index > Carti.Count) throw new ArgumentOutOfRangeException ("index");
                return Carti[index];
            }
        }


        /// <summary>
        /// Returns a formatted string containing the name, number of books, stock status, and a list of books.
        /// </summary>
        /// <returns>A string representation of the object with its details and books.</returns>
        /// 
        public override string ToString()
        {
            string output = $"Nume : {Nume} , Numar carti : {NrCarti} , Stoc : {(Carti.Count == 0 ? "0" : "")}\n";


            foreach(var carte in Carti)
            {
                output += $"\t{carte}\n";
            }

            return output;
        }
    }
}
