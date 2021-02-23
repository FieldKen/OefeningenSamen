using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal 1: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Getal 2: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Als je {getal1} deelt door {getal2} dan is de rest {getal1 % getal2}.");
            Console.ReadLine();
        }
    }
}
