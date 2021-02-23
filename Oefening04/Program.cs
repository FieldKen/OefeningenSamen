using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening04
{
    class Program
    {
        static void Main(string[] args)
        {
            string voornaam, achternaam, adres, postcode, hobby;
            Console.Write("Voornaam: ");
            voornaam = Console.ReadLine();
            Console.Write("Achternaam: ");
            achternaam = Console.ReadLine();
            Console.Write("Adres: ");
            adres = Console.ReadLine();
            Console.Write("Postcode: ");
            postcode = Console.ReadLine();
            Console.Write("Hobby: ");
            hobby = Console.ReadLine();

            Console.WriteLine($"Dag {voornaam} {achternaam}.\nJij woont op {adres} {postcode}. Jouw hobby's zijn {hobby}.");
            Console.ReadLine();   
        }
    }
}
