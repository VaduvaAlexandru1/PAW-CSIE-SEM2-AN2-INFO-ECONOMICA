using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2_1061 {
    internal class Program {
        static void Main(string[] args) {
            Persoana p1 = new Persoana();
            Persoana p2 = new Persoana("Andrei", 21, true);
            Persoana p3 = new Persoana() {
                Nume = "Popescu Ion",
                Varsta = 22,
                AreOchelari = true
            };

            Console.WriteLine($"{p1.Nume} {p1.Varsta} {p1.AreOchelari}");
            Console.WriteLine($"{p2.Nume} {p2.Varsta} {p2.AreOchelari}");
            Console.WriteLine($"{p3.Nume} {p3.Varsta} {p3.AreOchelari}");
        
            Console.WriteLine(p3.Nume.ToUpper());
            Console.WriteLine(p3.Nume.ToLower());
            Console.WriteLine(p3.Nume.Substring(1));
            Console.WriteLine(p3.Nume.Substring(1, 3));
            Console.WriteLine(p3.Nume.Split(' ')[0][1]);

            List<Persoana> persoane = new List<Persoana> { p1, p2, p3 };

            var persoaneCuOchelari = persoane
                .Where(p => p.AreOchelari && p.Varsta > 20)
                .Select(p => p.Nume)
                .ToList();

            persoaneCuOchelari.ForEach(nume => Console.WriteLine(nume));

            foreach(string p in persoaneCuOchelari)
                Console.WriteLine(p);

            //Tema
            //instantiere 2 obiecte
            //clone
            //compareTo
            //formaFinantare
            //supraincarcari

            Student s1 = new Student("Alex", 19, false, 8);
        }
    }
}
