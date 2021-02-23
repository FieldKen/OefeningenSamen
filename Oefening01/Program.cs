using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening01
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal1, getal2;
            Console.Write("Getal 1: ");
            getal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Getal 2: ");
            getal2 = Convert.ToDouble(Console.ReadLine());

            double plus, min, maal, deling;
            plus = getal1 + getal2;
            min = getal1 - getal2;
            maal = getal1 * getal2;
            deling = getal1 / getal2;

            Console.WriteLine($"{getal1} + {getal2} = {plus}");
            Console.WriteLine($"{getal1} - {getal2} = {min}");
            Console.WriteLine($"{getal1} * {getal2} = {maal}");
            Console.WriteLine($"{getal1} / {getal2} = {deling.ToString("0.##")}");


            Console.WriteLine();

            Console.WriteLine($"{plus} + {min} + {maal} + {deling.ToString("0.##")} = {(plus + min + maal + deling).ToString("0.##")}");
            Console.WriteLine($"{plus} * {min} * {maal} * {deling.ToString("0.##")} = {plus * min * maal * deling}");


            Console.ReadLine();
        }
    }
}
