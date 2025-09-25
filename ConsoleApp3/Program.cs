using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Beolvasás, kiírás, eldöntés, számítások\n");
            Console.WriteLine("F 1.\n");
            F1();
            Console.WriteLine("F 2.\n");
            F2();
            Console.WriteLine("F 3.\n");
            F3();
            Console.WriteLine("F 4.\n");
            F4();
            Console.WriteLine("F 5.\n");
            F5();
            Console.WriteLine("F 6.\n");
            F6();
            Console.WriteLine("F 7.\n");
            F7();
            Console.WriteLine("F 8.\n");
            F8();
            Console.WriteLine("F 9.\n");
            F9();
            Console.WriteLine("F 10.\n");
            F10();
            Console.WriteLine("F 11.\n");
            F11();
            Console.WriteLine("F 12.\n");
            F12();
            Console.WriteLine("F 13.\n");
            F13();
            Console.WriteLine("F 14.\n");
            F14();
            Console.WriteLine("Egyszerű ciklusok\n");
            Console.WriteLine("F 15.\n");
            F15();
            Console.WriteLine("F 16.\n");
            F16();
            Console.WriteLine("F 17.\n");
            F17();
            Console.WriteLine("F 18.\n");
            F18();
            Console.WriteLine("F 19.\n");
            F19();
            Console.WriteLine("F 20.\n");
            F20();
            Console.WriteLine("F 21.\n");
            F21();
            Console.WriteLine("F 22.\n");
            F22();
            Console.WriteLine("F 23.\n");
            F23();
            Console.WriteLine("F 24.\n");
            F24();
            Console.WriteLine("F 25.\n");
            F25();
            Console.WriteLine("F 26.\n");
            F26();
            Console.WriteLine("F 27.\n");
            F27();
            Console.WriteLine("F 28.\n");
            F28();
            Console.WriteLine("F 29.\n");
            F29();
            Console.WriteLine("F 30.\n");
            F30();
            Console.WriteLine("F 31.\n");
            F31();
            Console.WriteLine("Egymásba ágyazott ciklusok:\n");
            Console.WriteLine("F 32.\n");
            F32();
            Console.WriteLine("F 33.\n");
            F33();
            Console.WriteLine("F 34.\n");
            F34();
            Console.WriteLine("F 35.\n");
            F35();
            Console.WriteLine("F 36.\n");
            F36();
            Console.WriteLine("F 37.\n");
            F37();
            Console.WriteLine("F 38.\n");
            F38();
            Console.WriteLine("F 39.\n");
            F39();
            Console.WriteLine("F 40.\n");
            F40();
            Console.WriteLine("F 41.\n");
            F41();
            */
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
        static void F1()
        {
            Console.WriteLine("Hello, world!");

        }
        static void F2()
        {
            Console.WriteLine("adja meg a nevét: ");
            string nev = Console.ReadLine();
            Console.WriteLine("2. Üdvözlöm " + nev);
        }
        static void F3()
        {
            Console.WriteLine("adjon meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine("3. a szám kétszerese: " + (szam * 2));


        }
        static void F4()
        {
            Console.WriteLine("adja meg az első számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.WriteLine("adja meg a második számot: ");
            int szam2 = int.Parse(Console.ReadLine());
            Console.WriteLine("4. a két szám összege: " + (szam1 + szam2) + ", különbsége: " + (szam1 - szam2) + ", szorzata: " + "4c. Szorzat: " + (szam1 * szam2) + ", hányadosa:" + "4d. Hányados: " + ((double)szam1 / szam2));
        }
        static void F5()
        {
            Console.WriteLine("5. Adjon meg két egész számot:");
            Console.Write("Első szám: ");
            int egesz1 = int.Parse(Console.ReadLine());
            Console.Write("Második szám: ");
            int egesz2 = int.Parse(Console.ReadLine());

            int nagyobbik = Math.Max(egesz1, egesz2);
            Console.WriteLine("5. A nagyobbik szám: " + nagyobbik);
        }
        static void F6()
        {
            Console.WriteLine("6. Adjon meg három egész számot:");
            Console.Write("Első szám: ");
            int harom1 = int.Parse(Console.ReadLine());
            Console.Write("Második szám: ");
            int harom2 = int.Parse(Console.ReadLine());
            Console.Write("Harmadik szám: ");
            int harom3 = int.Parse(Console.ReadLine());

            int legkisebb = Math.Min(Math.Min(harom1, harom2), harom3);
            Console.WriteLine("6. A legkisebb szám: " + legkisebb);
        }
        static void F7()
        {

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
        }
        static void F8()
        {
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
        }
        static void F9()
        {
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
        }
        static void F10()
        {
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
        }
        static void F11()
        {
            Console.WriteLine("11. Adja meg a derékszögű háromszög két befogójának hosszát:");
            Console.Write("Első befogó: ");
            double befogo1 = double.Parse(Console.ReadLine());
            Console.Write("Második befogó: ");
            double befogo2 = double.Parse(Console.ReadLine());

            double atfogo = Math.Sqrt(befogo1 * befogo1 + befogo2 * befogo2);
            Console.WriteLine("11. Az átfogó hossza: " + atfogo);
        }
        static void F12()
        {
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
        }
        static void F13()
        {
            Console.WriteLine("13. Adja meg a kör átmérőjét:");
            Console.Write("Átmérő: ");
            double atmero = double.Parse(Console.ReadLine());

            double sugar = atmero / 2;
            double kerulet = 2 * Math.PI * sugar;
            double terulet = Math.PI * sugar * sugar;
            Console.WriteLine("13. Kerület: " + kerulet);
            Console.WriteLine("13. Terület: " + terulet);
        }
        static void F14()
        {
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
            } while (pozitivSzam <= 0);
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
        static void F26()
        {
            int szam26 = SzamBekeres();
            bool prim = true;

            if (szam26 <= 1)
            {
                prim = false;
            }
            else
            {
                for (int i = 2; i * i <= szam26; i++)
                {
                    if (szam26 % i == 0)
                    {
                        prim = false;
                        break;
                    }
                }
            }

            if (prim)
            {
                Console.WriteLine(szam26 + " prímszám.");
            }
            else
            {
                Console.WriteLine(szam26 + " nem prímszám.");
            }
        }
        static void F27()
        {
            int szam27 = SzamBekeres();
            Console.Write("Prímszámok " + szam27 + "-ig: ");

            for (int szam = 2; szam <= szam27; szam++)
            {
                bool isPrim = true;
                for (int i = 2; i * i <= szam; i++)
                {
                    if (szam % i == 0)
                    {
                        isPrim = false;
                        break;
                    }
                }
                if (isPrim)
                {
                    Console.Write(szam + " ");
                }
            }
        }
        static void F28()
        {
            int szam28 = SzamBekeres();
            List<int> osztok = OsztokListaba(szam28);
            for (int i = 0; i < osztok.Count; i++)
            {
                bool prim = true;


                if (osztok[i] <= 1)
                {
                    prim = false;
                }
                else
                {
                    for (int j = 2; j * j <= osztok[i]; j++)
                    {
                        if (osztok[i] % j == 0)
                        {
                            prim = false;
                            break;
                        }
                    }
                }

                if (prim)
                {
                    Console.WriteLine(osztok[i]);
                }
            }
        }
        static void F29()
        {
            int szam29 = SzamBekeres();
            int eredeti29 = szam29;
            List<int> primtenyezok = new List<int>();

            for (int i = 2; i <= szam29; i++)
            {
                while (szam29 % i == 0)
                {
                    primtenyezok.Add(i);
                    szam29 /= i;
                }
            }

            Console.Write(eredeti29 + " = ");
            for (int i = 0; i < primtenyezok.Count; i++)
            {
                Console.Write(primtenyezok[i]);
                if (i < primtenyezok.Count - 1)
                {
                    Console.Write(" * ");
                }
            }
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
        static void F32()
        {
            int szam = SzamBekeres();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(j * i * szam * szam + " ");
                }
                Console.WriteLine();
            }
        }
        static void F33()
        {
            int szam = SzamBekeres();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(szam * i + szam * j + " ");
                }
                Console.WriteLine();
            }
        }
        static void F34()
        {
            int szam1 = 0;
            int szam2 = 0;
            for (int i = 1; i <= 2; i++)
            { 
                Console.WriteLine("Kérem a(z) " + i + ". számot:");
                int beolvasott = SzamBekeres();
                if (i == 1)
                    szam1 = beolvasott;
                else
                    szam2 = beolvasott;
            }

            if ((10 <= szam1 && szam1 <= 99) || (10 <= szam2 && szam2 <= 99))
            {
                double elsoszam1 = szam1 / 10;
                int masodikszam1 = szam1 % 10;
                double elsoszam2 = szam2 / 10;
                int masodikszam2 = szam2 % 10;

                Console.WriteLine(masodikszam1 * 10 + elsoszam1);

                if ((masodikszam1 * 10 + elsoszam1) * (masodikszam2 * 10 + elsoszam2) == szam1 * szam2)
                {
                    Console.WriteLine("Páros speciális szám!");
                }
                else
                {
                    Console.WriteLine("Nem páros speciális szám!");
                }
            }
            else
                {
                    Console.WriteLine("Kérem kétjegyű számot adjon meg!");
                }
        }
        static void F35()
        {
            string lowercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();
            char[,] matrix = new char[10, 3]; 
            int index = 0;

            for (int j = 0; j < matrix.GetLength(1); j++) 
            {
                for (int i = 0; i < matrix.GetLength(0); i++) 
                {
                    if (index < lowercase.Length) 
                    {
                        matrix[i, j] = lowercase[index];
                        index++;
                    }
                    else
                    {
                        matrix[i, j] = ' ';
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " " + (int)matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void F36()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("XO");
                }
                Console.WriteLine();
            }
        }
        static void F37()
        {
            int szam = SzamBekeres();
            if(szam > 0)
            {
                for (int i = 0; i <= szam; i++)
                {
                    for (int j = 1; j <= 2 * i + 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Nem megfelelő a szám");
            }
        }
        static void F38()
        {
            int szam = SzamBekeres();
            if (szam > 0)
            {
                for (int i = 0; i <= szam; i++)
                {
                    for (int j = 1; j <= szam - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= 2 * i + 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Nem megfelelő a szám");
            }
        }
        static void F39()
        {
            int szam1 = 0;
            int szam2 = 0;
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Kérem a(z) " + i + ". számot:");
                int beolvasott = SzamBekeres();
                if (i == 1)
                    szam1 = beolvasott;
                else
                    szam2 = beolvasott;
            }

            Console.WriteLine();

            for (int i = 1; i <= szam1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 1; i <= szam2; i++)
            {
                Console.Write("*");
                for (int j = 1; j < szam1 - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }

            for (int i = 1; i <= szam1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        static void F40()
        {
            int szam = SzamBekeres();
            List<int> osztok = new List<int>();

            for (int i = 0; i < szam; i++)
            {
                osztok.Clear();
                osztok = OsztokListaba(i);
                int osszeg = osztok.Sum();


                if (osszeg == 2 * i)
                {
                    Console.WriteLine(i + " ");
                }
            }
                
        }
        static void F41()
        {
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    int index = (i + j) % 26;
                    Console.Write(abc[index] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}