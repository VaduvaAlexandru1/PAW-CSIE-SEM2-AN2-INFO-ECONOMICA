using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori
{
    internal class Carte
    {

        public string Nume {  get; private set; }
        public int NrPag {  get; private set; }

        public float Pret {  get; private set; }

        public int Stoc { get; private set; }

        public Carte() { }

        /// <summary>
        /// Initializes a new instance of the Carte class with the specified name, page count, and price, applying
        /// default values if inputs are invalid.
        /// </summary>
        /// <param name="nume">The name of the book.</param>
        /// <param name="nrPag">The number of pages in the book.</param>
        /// <param name="pret">The price of the book.</param>
        public Carte(string nume, int nrPag, float pret , int stoc)
        {
            Nume = nume.Length > 0 ? nume : "Anonim";
            NrPag = nrPag > 0 ? nrPag : 0;
            Pret = pret > 0 ? pret : 0;
            Stoc = stoc > 0 ? stoc : 0;
        }

        /// <summary>
        /// Increments the Stoc property of the Carte instance.
        /// </summary>
        /// <param name="carte">The Carte instance to increment.</param>
        /// <returns>The updated Carte instance with incremented Stoc.</returns>
        public static Carte operator ++(Carte carte)
        {
            carte.Stoc++;
            return carte;
        }

        /// <summary>
        /// Returns a string representation of the object including its title, page count, price, and stock.
        /// </summary>
        /// <returns>A formatted string containing the values of Nume, NrPag, Pret, and Stoc.</returns>
        public override string ToString()
        {
            return $"titlu : {Nume} , nr pagini : {NrPag} , pret : {Pret} , stoc : {Stoc}";
        }
    }
}
