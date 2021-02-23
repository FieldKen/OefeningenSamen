using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Celsius: {Math.Round((fahrenheit - 32) * 5 / 9)}");
            Console.ReadLine();
        }
    }
}
