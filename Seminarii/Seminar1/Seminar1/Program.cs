using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salut sefu");
            Console.WriteLine("NR arg : " + args.Length);
            for(int i = 0; i < args.Length; i++) 
                Console.Write(args[i] + " ");
        }
    }
}
