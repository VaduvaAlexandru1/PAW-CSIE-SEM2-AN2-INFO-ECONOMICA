using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoana p1 = new Persoana();
            Persoana p2 = new Persoana("Andrei" , 21 , false);
            Persoana p3 = new Persoana()
            {
                Nume = "Popescu Ion",
                Varsta = 22,
                AreOchelari = true
            };

            Console.WriteLine($"{p1.Nume} {p1.Varsta} {p1.AreOchelari}");
            Console.WriteLine($"{p2.Nume} {p2.Varsta} {p2.AreOchelari}");
            Console.WriteLine($"{p3.Nume} {p3.Varsta} {p3.AreOchelari}");

            Console.WriteLine(p3.Nume.ToString());

        }
    }
}
