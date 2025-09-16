using System;

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
            Console.WriteLine("3. a szám kétszerese: " + (szam * 2));

            Console.WriteLine("adja meg az első számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.WriteLine("adja meg a második számot: ");
            int szam2 = int.Parse(Console.ReadLine());

            Console.WriteLine("4. a két szám összege: " + (szam1 + szam2) + ", a két szám különbsége: " + (szam1 - szam2));

            Console.WriteLine("4a. Összeg: " + (szam1 + szam2));

            Console.WriteLine("4b. Különbség: " + (szam1 - szam2));

            Console.WriteLine("4c. Szorzat: " + (szam1 * szam2));

            if (szam2 != 0)
            {
                Console.WriteLine("4d. Hányados: " + ((double)szam1 / szam2));
            }
            else
            {
                Console.WriteLine("4d. Nullával nem lehet osztani!");
            }

            Console.WriteLine("5. Adjon meg két egész számot:");
            Console.Write("Első szám: ");
            int egesz1 = int.Parse(Console.ReadLine());
            Console.Write("Második szám: ");
            int egesz2 = int.Parse(Console.ReadLine());

            int nagyobbik = Math.Max(egesz1, egesz2);
            Console.WriteLine("5. A nagyobbik szám: " + nagyobbik);

            Console.WriteLine("6. Adjon meg három egész számot:");
            Console.Write("Első szám: ");
            int harom1 = int.Parse(Console.ReadLine());
            Console.Write("Második szám: ");
            int harom2 = int.Parse(Console.ReadLine());
            Console.Write("Harmadik szám: ");
            int harom3 = int.Parse(Console.ReadLine());

            int legkisebb = Math.Min(Math.Min(harom1, harom2), harom3);
            Console.WriteLine("6. A legkisebb szám: " + legkisebb);

            Console.WriteLine("7. Adja meg a háromszög három oldalának hosszát:");
            Console.Write("a oldal: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b oldal: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c oldal: ");
            double c = double.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("7. A háromszög szerkeszthető!");
            }
            else
            {
                Console.WriteLine("7. A háromszög nem szerkeszthető!");
            }

            Console.WriteLine("8. Adjon meg két pozitív egész számot:");
            Console.Write("Első pozitív szám: ");
            int poz1 = int.Parse(Console.ReadLine());
            Console.Write("Második pozitív szám: ");
            int poz2 = int.Parse(Console.ReadLine());

            if (poz1 > 0 && poz2 > 0)
            {
                double szamtaniKozep = (poz1 + poz2) / 2.0;
                double mertaniKozep = Math.Sqrt(poz1 * poz2);
                Console.WriteLine("8. Számtani középérték: " + szamtaniKozep);
                Console.WriteLine("8. Mértani középérték: " + mertaniKozep);
            }
            else
            {
                Console.WriteLine("8. Mindkét számnak pozitívnak kell lennie!");
            }

            Console.WriteLine("9. Adja meg a másodfokú egyenlet együtthatóit (ax² + bx + c = 0):");
            Console.Write("a együttható: ");
            double egyA = double.Parse(Console.ReadLine());
            Console.Write("b együttható: ");
            double egyB = double.Parse(Console.ReadLine());
            Console.Write("c együttható: ");
            double egyC = double.Parse(Console.ReadLine());

            if (egyA == 0)
            {
                Console.WriteLine("9. Ez nem másodfokú egyenlet!");
            }
            else
            {
                double diszkriminans = egyB * egyB - 4 * egyA * egyC;
                if (diszkriminans >= 0)
                {
                    Console.WriteLine("9. Az egyenletnek van megoldása!");
                }
                else
                {
                    Console.WriteLine("9. Az egyenletnek nincs valós megoldása!");
                }
            }

            Console.WriteLine("10. Adja meg a másodfokú egyenlet együtthatóit a megoldáshoz:");
            Console.Write("a együttható: ");
            double megA = double.Parse(Console.ReadLine());
            Console.Write("b együttható: ");
            double megB = double.Parse(Console.ReadLine());
            Console.Write("c együttható: ");
            double megC = double.Parse(Console.ReadLine());

            if (megA == 0)
            {
                Console.WriteLine("10. Ez nem másodfokú egyenlet!");
            }
            else
            {
                double d = megB * megB - 4 * megA * megC;
                if (d > 0)
                {
                    double x1 = (-megB + Math.Sqrt(d)) / (2 * megA);
                    double x2 = (-megB - Math.Sqrt(d)) / (2 * megA);
                    Console.WriteLine("10. x1 = " + x1 + ", x2 = " + x2);
                }
                else if (d == 0)
                {
                    double x = -megB / (2 * megA);
                    Console.WriteLine("10. x = " + x + " (dupla gyök)");
                }
                else
                {
                    Console.WriteLine("10. Nincs valós megoldás!");
                }
            }

            Console.WriteLine("11. Adja meg a derékszögű háromszög két befogójának hosszát:");
            Console.Write("Első befogó: ");
            double befogo1 = double.Parse(Console.ReadLine());
            Console.Write("Második befogó: ");
            double befogo2 = double.Parse(Console.ReadLine());

            double atfogo = Math.Sqrt(befogo1 * befogo1 + befogo2 * befogo2);
            Console.WriteLine("11. Az átfogó hossza: " + atfogo);

            Console.WriteLine("12. Adja meg a téglatest három élének hosszát:");
            Console.Write("Hosszúság: ");
            double hossz = double.Parse(Console.ReadLine());
            Console.Write("Szélesség: ");
            double szel = double.Parse(Console.ReadLine());
            Console.Write("Magasság: ");
            double mag = double.Parse(Console.ReadLine());

            double felszin = 2 * (hossz * szel + hossz * mag + szel * mag);
            double terfogat = hossz * szel * mag;
            Console.WriteLine("12. Felszín: " + felszin);
            Console.WriteLine("12. Térfogat: " + terfogat);

            Console.WriteLine("13. Adja meg a kör átmérőjét:");
            Console.Write("Átmérő: ");
            double atmero = double.Parse(Console.ReadLine());

            double sugar = atmero / 2;
            double kerulet = 2 * Math.PI * sugar;
            double terulet = Math.PI * sugar * sugar;
            Console.WriteLine("13. Kerület: " + kerulet);
            Console.WriteLine("13. Terület: " + terulet);

            Console.WriteLine("14. Adja meg a körív sugarát és középponti szögét (fokban):");
            Console.Write("Sugár: ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Középponti szög (fokban): ");
            double szogFok = double.Parse(Console.ReadLine());

            double szogRadian = szogFok * Math.PI / 180; 
            double ivHossz = r * szogRadian;
            double korszeletTerulet = 0.5 * r * r * szogRadian;

            Console.WriteLine("14. Az ív hossza: " + ivHossz);
            Console.WriteLine("14. A körszelet területe: " + korszeletTerulet);


        }
    }
}