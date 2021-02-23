using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening06
{
    class Program
    {
        static void Main(string[] args)
        {
            int prijsVolwassenen = 35;
            int prijsTieners = 25;
            int prijsKinderen = 20;

            Console.WriteLine("Welkom in Kenland! Tofste pretpark van de Benelux!");
            Console.Write("Aantal volwassenen: ");
            int aantalVolwassenen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aantal tieners: ");
            int aantalTieners = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aantal kinderen: ");
            int aantalKinderen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Prijs per volwassene: {prijsVolwassenen} euro");
            Console.WriteLine($"Prijs per tiener: {prijsTieners} euro");
            Console.WriteLine($"Prijs per kind: {prijsKinderen} euro");

            Console.WriteLine();
            Console.WriteLine($"Totaal: {prijsVolwassenen*aantalVolwassenen+prijsTieners*aantalTieners+prijsKinderen*aantalKinderen} euro");
            Console.ReadLine();
        }
    }
}
