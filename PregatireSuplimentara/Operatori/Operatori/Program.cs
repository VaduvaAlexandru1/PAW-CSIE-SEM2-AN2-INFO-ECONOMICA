using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carte c = new Carte("robinson crusoe" , 250 , 60.5f , 50);
            Console.WriteLine(c);

            Biblioteca b1 = new Biblioteca();
            b1 += c;

            Console.WriteLine(b1[0]);
        }
    }
}
