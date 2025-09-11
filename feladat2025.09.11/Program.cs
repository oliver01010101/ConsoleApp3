using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            Console.WriteLine("adja meg a nevét: ");
            string nev = Console.ReadLine();
            Console.WriteLine("2. Üdvözlöm " + nev);


            Console.WriteLine("adjon meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine("3. a szám kétszerese: " + szam * 2);


            Console.WriteLine("adja meg az első száámot: ");
            int szam1 = int.Parse(Console.ReadLine());

            Console.WriteLine("adja meg a második száámot: ");
            int szam2 = int.Parse(Console.ReadLine());


            Console.WriteLine($"a két szám összege: {szam1 + szam2}, a két szám különbsége: {szam1 - szam2},");


        }
    }
}