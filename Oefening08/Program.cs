using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{getal} x 1 = {getal * 1}");
            Console.WriteLine($"{getal} x 2 = {getal * 2}");
            Console.WriteLine($"{getal} x 3 = {getal * 3}");
            Console.WriteLine($"{getal} x 4 = {getal * 4}");
            Console.WriteLine($"{getal} x 5 = {getal * 5}");
            Console.WriteLine($"{getal} x 6 = {getal * 6}");
            Console.WriteLine($"{getal} x 7 = {getal * 7}");
            Console.WriteLine($"{getal} x 8 = {getal * 8}");
            Console.WriteLine($"{getal} x 9 = {getal * 9}");
            Console.WriteLine($"{getal} x 10 = {getal * 10}");
            Console.ReadLine();
        }
    }
}
