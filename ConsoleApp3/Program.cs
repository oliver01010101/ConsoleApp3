using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
             
            */
            
            Console.WriteLine("F 15.");
            F15();
            Console.WriteLine();
            Console.WriteLine("F 16.");
            F16();
            Console.WriteLine();
            Console.WriteLine("F 17.");
            F17();
            Console.WriteLine();
            Console.WriteLine("F 18.");
            F18();
            Console.WriteLine();
            Console.WriteLine("F 19.");
            F19();
            Console.WriteLine();
            Console.WriteLine("F 20.");
            F20();
            Console.WriteLine();
            Console.WriteLine("F 21.");
            F21();
            Console.WriteLine();
            Console.WriteLine("F 22.");
            F22();
            Console.WriteLine();
            Console.WriteLine("F 23.");
            F23();
            Console.WriteLine();
            Console.WriteLine("F 24.");
            F24();
            Console.WriteLine();
            Console.WriteLine("F 25.");
            F25();
            Console.WriteLine();
            Console.WriteLine("F 26.");

            Console.WriteLine();
            Console.WriteLine("F 27.");

            Console.WriteLine();
            Console.WriteLine("F 28.");

            Console.WriteLine();
            Console.WriteLine("F 29.");
 
            Console.WriteLine();
            Console.WriteLine("F 30.");
            F30();
            Console.WriteLine();
            Console.WriteLine("F 31.");
            F31();
        }

        public static int SzamBekeres()
        {
            Console.Write("Adj meg egy számot: ");
            try
            {
                int szam = int.Parse(Console.ReadLine() ?? "0");
                return szam;
            }
            catch
            {
                return 0;
            }
        }

        public static void SzamKiiras(int szam)
        {
            Console.WriteLine("A megadott szám: " + szam);
        }

        public static List<int> OsztokListaba(int szam)
        {
            List<int> osztok = new List<int>();
            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    osztok.Add(i);
                }
            }
            return osztok;
        }
        static void F15()
        {
            int szam15 = SzamBekeres();
            for (int i = 1; i <= szam15; i++)
            {
                Console.Write(i + " ");
            }
        }
        static void F16()
        {
            int szam16 = SzamBekeres();
            for (int i = 1; i <= szam16; i++)
            {
                Console.WriteLine(i + " ");
            }
        }
        static void F17()
        {
            int szam17 = SzamBekeres();
            List<int> osztok17 = OsztokListaba(szam17);
            foreach (int oszto in osztok17)
            {
                Console.Write(oszto + " ");
            }
        }
        static void F18()
        {
            int szam18 = SzamBekeres();
            List<int> osztok18 = OsztokListaba(szam18);
            int osszeg18 = osztok18.Sum();
            SzamKiiras(osszeg18);
        }
        static void F19()
        {
            int szam19 = SzamBekeres();
            List<int> osztok19 = OsztokListaba(szam19);
            int osszeg19 = osztok19.Sum();
            if (osszeg19 == 2 * szam19)
            {
                Console.WriteLine("A szám tökéletes szám.");
            }
            else
            {
                Console.WriteLine("A szám nem tökéletes szám.");
            }
        }
        static void F20()
        {
            Console.Write("Hatványalap: ");
            int alap = SzamBekeres();
            Console.Write("Kitevő: ");
            int kitevo = SzamBekeres();

            int hatvanyErtek = 1;
            for (int i = 0; i < kitevo; i++)
            {
                hatvanyErtek *= alap;
            }
            Console.WriteLine("Hatványérték: " + hatvanyErtek);
        }
        static void F21()
        {
            int pozitivSzam;
            do
            {
                pozitivSzam = SzamBekeres();
                if (pozitivSzam <= 0)
                {
                    Console.WriteLine("Kérek pozitív számot!");
                }
        } while (pozitivSzam <= 0) ;
        Console.WriteLine("Pozitív szám beolvasva: " + pozitivSzam);
        }
        static void F22()
        {
            Console.WriteLine("Addig olvas be számokat, amíg kisebbek mint 10. Írja ki ezek után a beolvasott számok összegét!");
            int osszeg22 = 0;
            int szam22;
            do
            {
                szam22 = SzamBekeres();
                if (szam22 < 10)
                {
                    osszeg22 += szam22;
                }
            } while (szam22 < 10);
            Console.WriteLine("A beolvasott számok összege: " + osszeg22);
        }
        static void F23()
        {
            int szam23 = SzamBekeres();
            int eredeti = szam23;
            Console.WriteLine(eredeti + " = " + szam23);

            while (szam23 % 2 == 0)
            {
                szam23 /= 2;
                Console.WriteLine(eredeti + " = 2*" + szam23);
            }

            if (szam23 == 1)
            {
                Console.WriteLine("A szám egyszer sem osztható kettővel.");
            }
            else
            {
                Console.WriteLine(szam23 + " = " + szam23);
            }
        }
        static void F24()
        {
            string input24;
            do
            {
                Console.Write("Írj be egy szót: ");
                input24 = Console.ReadLine() ?? "";
                if (input24 != "alma")
                {
                    Console.WriteLine("Nem 'alma' szót írtál! Próbáld újra.");
                }
            } while (input24 != "alma");
            Console.WriteLine("Az alma gyümölcs");
        }
        static void F25()
        {
            int szam = SzamBekeres();
            int eredeti = szam;
            int db = 0;
            while (szam > 3) { szam = szam - 3; db++; }
            Console.WriteLine($"{eredeti} = {db} * 3 + {szam}");
        }
        
        static void F30()
        {
            Console.Write("Első szám: ");
            int a = SzamBekeres();
            Console.Write("Második szám: ");
            int b = SzamBekeres();

            int eredeti_a = a;
            int eredeti_b = b;

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            Console.WriteLine("A " + eredeti_a + " és " + eredeti_b + " legnagyobb közös osztója: " + a);

        }
        static void F31()
        {
            Console.Write("Első szám: ");
            int szam1_31 = SzamBekeres();
            Console.Write("Második szám: ");
            int szam2_31 = SzamBekeres();

            int eredeti_a31 = szam1_31;
            int eredeti_b31 = szam2_31;

            int a31 = szam1_31;
            int b31 = szam2_31;
            while (b31 != 0)
            {
                int temp = b31;
                b31 = a31 % b31;
                a31 = temp;
            }

            int lnko = (eredeti_a31 * eredeti_b31) / a31;
            Console.WriteLine("A " + eredeti_a31 + " és " + eredeti_b31 + " legkisebb közös többszöröse: " + lnko);
        }
    }
}