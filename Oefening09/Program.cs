using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Af te leggen afstand in km: ");
            int afstand = Convert.ToInt32(Console.ReadLine());
            Console.Write("Snelheid in km/h: ");
            int snelheid = Convert.ToInt32(Console.ReadLine());

            int aantalUur = afstand / snelheid;

            //Extra
            int aantalMin = Convert.ToInt32((Convert.ToDouble(afstand) / snelheid * 60) % 60);

            Console.WriteLine($"De vrachtwagen moet nog { aantalUur } uur {aantalMin} min rijden.");
            Console.ReadLine();
        }
    }
}
