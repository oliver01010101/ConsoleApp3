using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] sorok = File.ReadAllLines("uzemanyag.txt");

        List<string> datumok = new List<string>();
        List<int> benzinArak = new List<int>();
        List<int> gazolajArak = new List<int>();

        foreach (string sor in sorok)
        {
            string[] darabok = sor.Split(';');
            datumok.Add(darabok[0]);
            benzinArak.Add(int.Parse(darabok[1]));
            gazolajArak.Add(int.Parse(darabok[2]));
        }

        f3(datumok);
        f4(datumok, benzinArak, gazolajArak);
        f5(datumok, benzinArak, gazolajArak);
        f6(datumok);
        f7(datumok, benzinArak, gazolajArak);
        int ev = f8();
        f9(ev);
        f10(ev);
    }

    static void f3(List<string> datumok)
    {
        Console.WriteLine("3. fealdat: változások száma: " + datumok.Count);
    }
    static void f4(List<string> datumok, List<int> benzinArak, List<int> gazolajArak)
    {
        int legkisebbKulonbseg = int.MaxValue;

        for (int i = 0; i < benzinArak.Count; i++)
        {
            int kulonbseg = Math.Abs(benzinArak[i] - gazolajArak[i]);
            if (kulonbseg < legkisebbKulonbseg)
            {
                legkisebbKulonbseg = kulonbseg;
            }
        }

        Console.WriteLine("4. feladat: A legkisebb különbség: " + legkisebbKulonbseg);
    }
    static void f5(List<string> datumok, List<int> benzinArak, List<int> gazolajArak)
    {
        int legkisebbKulonbseg = int.MaxValue;
        int hanyszorFordultElo = 0;

        for (int i = 0; i < benzinArak.Count; i++)
        {
            int kulonbseg = Math.Abs(benzinArak[i] - gazolajArak[i]);
            if (kulonbseg < legkisebbKulonbseg)
            {
                legkisebbKulonbseg = kulonbseg;
                hanyszorFordultElo = 1;
            }
            else if (kulonbseg == legkisebbKulonbseg)
            {
                hanyszorFordultElo++;
            }
        }

        Console.WriteLine("5. feladat: A legkisebb különbség előfordulása: " + hanyszorFordultElo);
    }
    static void f6(List<string> datumok)
    {
        bool voltFebruar24 = false;

        foreach (string datum in datumok)
        {
            if (datum.Contains("02.24"))
            {
                voltFebruar24 = true;
                break;
            }
        }

        if (voltFebruar24)
        {
            Console.WriteLine("6. feladat: Volt változás szökőnapon!");
        }
        else
        {
            Console.WriteLine("6. feladat: Nem volt változás szökőnapon!");
        }
    }
    static void f7(List<string> datumok, List<int> benzinArak, List<int> gazolajArak)
    {
        string[] euroFajl = new string[datumok.Count + 1];
        double euroArfolyam = 307.7;

        for (int i = 0; i < datumok.Count; i++)
        {
            double benzinEuro = benzinArak[i] / euroArfolyam;
            double gazolajEuro = gazolajArak[i] / euroArfolyam;

            euroFajl[i] = (datumok[i] + ";" + benzinEuro.ToString("F2") + ";" + gazolajEuro.ToString("F2"));    
        }
        File.WriteAllLines("euro.txt", euroFajl);
    }
    static int f8()
    {
        int ev = 0;
        while (ev < 2011 || ev > 2016)
        {
            Console.Write("8. feladat: Kérem adja meg az évszámot [2011..2016]: ");
            ev = int.Parse(Console.ReadLine());
        }
        return ev;
    }
    static void f9(int ev)
    {

    }

    static void f10(int ev)
    {

    }
}