using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> nevek = new List<string>();
        List<List<int>> jatekosokSzamai = new List<List<int>>();

        string[] sorok = File.ReadAllLines("egyszamjatek.txt");

        foreach (string sor in sorok)
        {
            string[] darabok = sor.Split(' ');
            string nev = darabok[10];
            nevek.Add(nev);

            List<int> szamok = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                szamok.Add(int.Parse(darabok[i]));
            }
            jatekosokSzamai.Add(szamok);
        }

        f3(nevek);
        f4(jatekosokSzamai);
        f5(jatekosokSzamai);
        f6(jatekosokSzamai);
        int bekertFordulo = f7(jatekosokSzamai);
        f8(jatekosokSzamai, bekertFordulo);
        f9(nevek, jatekosokSzamai, bekertFordulo);
        F10();
    }
    static void f3(List<string> nevek)
    {
        Console.WriteLine("3. feladat: játékosok száma: " + nevek.Count);
    }
    static void f4(List<List<int>> jatekosokSzamai)
    {
        Console.WriteLine("4. feladat: Fordulók száma:" + jatekosokSzamai[0].Count);
    }
    static void f5(List<List<int>> jatekosokSzamai)
    {

        bool voltEgyes = false;
        for (int i = 0; i < jatekosokSzamai.Count; i++)
        {
            if (jatekosokSzamai[i][0] == 1)
            {
                voltEgyes = true;
                break;
            }
        }

        if (voltEgyes)
        {
            Console.WriteLine("5. feladat: Az elso forduloban volt egyes tipp!");
        }
        else
        {
            Console.WriteLine("5. feladat: Az elso forduloban nem volt egyes tipp!");
        }
    }
    static void f6(List<List<int>> jatekosokSzamai)
    {
        int maxTipp = 0;
        int maxForduloSorszam = 0;

        for (int fordulo = 0; fordulo < 10; fordulo++)
        {
            for (int jatekos = 0; jatekos < jatekosokSzamai.Count; jatekos++)
            {
                if (jatekosokSzamai[jatekos][fordulo] > maxTipp)
                {
                    maxTipp = jatekosokSzamai[jatekos][fordulo];
                    maxForduloSorszam = fordulo + 1;
                }
            }
        }

        Console.WriteLine("6. feladat: A legnagyobb tipp a fordulók során: " + maxForduloSorszam);
    }
    static int f7(List<List<int>> jatekosokSzamai)
    {
        int fordulokSzama = jatekosokSzamai[0].Count;
        Console.Write($"7. feladat: Kerem a fordulo szamat [1-{fordulokSzama}]: ");
        int bekertFordulo = int.Parse(Console.ReadLine());

        if (bekertFordulo < 1 || bekertFordulo > fordulokSzama)
        {
            Console.WriteLine("Hibas bemenet! Az 1. forduloval dolgozom.");
            bekertFordulo = 1;
        }
        return bekertFordulo;
    }
    static void f8(List<List<int>> jatekosokSzamai, int vizsgaltFordulo)
    {
        
        List<int> tippek = new List<int>();
        for (int i = 0; i < jatekosokSzamai.Count; i++)
        {
            tippek.Add(jatekosokSzamai[i][vizsgaltFordulo - 1]);
        }

        Dictionary<int, int> darabszam = new Dictionary<int, int>();
        foreach (int tipp in tippek)
        {
            if (darabszam.ContainsKey(tipp))
            {
                darabszam[tipp]++;
            }
            else
            {
                darabszam[tipp] = 1;
            }
        }

        int legkisebbDb = darabszam.Values.Min();

        if (legkisebbDb == 1)
        {
            List<int> nyertesSzamok = new List<int>();
            foreach (var par in darabszam)
            {
                if (par.Value == 1)
                {
                    nyertesSzamok.Add(par.Key);
                }
            }
            int nyertesTipp = nyertesSzamok.Max();
            Console.WriteLine("8. feladat: A nyertes tipp: " + nyertesTipp);
        }
        else
        {
            Console.WriteLine("8. feladat: Nem volt egyedi tipp a megadott fordulóban!");
        }
    }
    static void f9(List<string> nevek, List<List<int>> jatekosokSzamai, int bekertFordulo)
    {
        List<int> tippek = new List<int>();
        for (int i = 0; i < jatekosokSzamai.Count; i++)
        {
            tippek.Add(jatekosokSzamai[i][bekertFordulo - 1]);
        }

        Dictionary<int, int> darabszam = new Dictionary<int, int>();
        foreach (int tipp in tippek)
        {
            if (darabszam.ContainsKey(tipp))
            {
                darabszam[tipp]++;
            }
            else
            {
                darabszam[tipp] = 1;
            }
        }

        int legkisebbDb = darabszam.Values.Min();

        if (legkisebbDb == 1)
        {
            List<int> nyertesSzamok = new List<int>();
            foreach (var par in darabszam)
            {
                if (par.Value == 1)
                {
                    nyertesSzamok.Add(par.Key);
                }
            }
            int nyertesTipp = nyertesSzamok.Max();

            Console.Write("9. feladat: A megadott fordulo nyertese: ");
            for (int i = 0; i < jatekosokSzamai.Count; i++)
            {
                if (jatekosokSzamai[i][bekertFordulo - 1] == nyertesTipp)
                {
                    Console.Write(nevek[i] + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("9. feladat: Nem volt nyertes a megadott forduloban!");
        }
    }
    static void F10()
    {
    }
}