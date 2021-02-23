using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Prijs van een drankje: ");
            double prijs = Convert.ToDouble(Console.ReadLine());
            Console.Write("Aantal drankjes: ");
            int aantal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Prijs zonder btw: {prijs * aantal}");
            Console.WriteLine($"Prijs met 21% btw: {(prijs * aantal * 1.21).ToString("0.00")}");
            Console.WriteLine($"Prijs met 21% btw: {Math.Round(prijs * aantal * 1.21,2)}");

            Console.ReadLine();
        }
    }
}
