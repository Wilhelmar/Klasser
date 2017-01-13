using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {

            //Övning 1
            Console.WriteLine("Ladda upp info till oss om din bil!");

            BilInfo info = new BilInfo();

            Console.Write("Ange märke: ");
            info.Märke = Console.ReadLine();
            Console.Write("Ange modell: ");
            info.Model = Console.ReadLine();
            Console.Write("Ange Färg: ");
            info.Färg = Console.ReadLine();
            Console.Write("Ange antalet hästkrafter: ");
            info.Hästar = int.Parse(Console.ReadLine());
            Console.Write("Ange Hur många Km per bilen åker på en Liter: ");
            info.Bränsleförbrukning = int.Parse(Console.ReadLine());

        Console.Write("Du har laddat upp info om en " + info.Bilen);

            Console.ReadKey();

            //Övning 2

            NamnHanterare info2 = new NamnHanterare();

            Console.Write("Skriv in ditt förnamn: ");
            info2.Förnamn = Console.ReadLine();
            Console.WriteLine("Skriv in efternamn: ");
            info2.Efternamn = Console.ReadLine();

            Console.WriteLine(info2.Person);
        }
    }
}
