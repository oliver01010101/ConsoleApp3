using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Versenyzo
{
    public string Nev { get; set; }
    public int Rajtszam { get; set; }
    public string Kategoria { get; set; }
    public string Versenyido { get; set; }
    public int TavSzazalek { get; set; }

    public Versenyzo(string nev, int rajtszam, string kategoria, string versenyido, int tavSzazalek)
    {
        Nev = nev;
        Rajtszam = rajtszam;
        Kategoria = kategoria;
        Versenyido = versenyido;
        TavSzazalek = tavSzazalek;
    }

    public TimeSpan VersenyidoTimeSpan()
    {
        string[] reszek = Versenyido.Split(':');
        int ora = int.Parse(reszek[0]);
        int perc = int.Parse(reszek[1]);
        int masodperc = int.Parse(reszek[2]);
        return new TimeSpan(ora, perc, masodperc);
    }
}

class Program
{
    static void Main()
    {
        List<Versenyzo> versenyzok = new List<Versenyzo>();

        string[] sorok = File.ReadAllLines("ub2017egyeni.txt");

        for (int i = 1; i < sorok.Length; i++)
        {
            string[] darabok = sorok[i].Split(';');
            string nev = darabok[0];
            int rajtszam = int.Parse(darabok[1]);
            string kategoria = darabok[2];
            string versenyido = darabok[3];
            int tavSzazalek = int.Parse(darabok[4]);

            Versenyzo v = new Versenyzo(nev, rajtszam, kategoria, versenyido, tavSzazalek);
            versenyzok.Add(v);
        }

        f3(versenyzok);
        f4(versenyzok);
        f5(versenyzok);

        f7(versenyzok);
        f8(versenyzok);
    }
    static void f3(List<Versenyzo> versenyzok)
    {
        int teljesTavotTeljesitettek = 0;

        foreach (Versenyzo v in versenyzok)
        {
            if (v.TavSzazalek == 100)
            {
                teljesTavotTeljesitettek++;
            }
        }

        Console.WriteLine($"3. feladat: Egyéni indulók: {teljesTavotTeljesitettek} fő");
    }

    static void f4(List<Versenyzo> versenyzok)
    {
        int egyeniNoiDb = 0;

        foreach (Versenyzo v in versenyzok)
        {
            if (v.Kategoria == "Noi" && v.TavSzazalek == 100)
            {
                egyeniNoiDb++;
            }
        }

        Console.WriteLine($"4. feladat: Célba érő női sportolók: " + egyeniNoiDb);
    }

    static void f5(List<Versenyzo> versenyzok)
    {
        Console.Write("5. feladat: Kérem a sportoló nevét: ");
        string keresettNev = Console.ReadLine();
        bool talalt = false;
        Versenyzo talaltVersenyzo = null;
        foreach (Versenyzo v in versenyzok)
        {
            if (v.Nev == keresettNev)
            {
                talalt = true;
                talaltVersenyzo = v;
                break;
            }
        }
        if (talalt)
        {
            Console.WriteLine($"Indult egyéniben a sportoló? {(talaltVersenyzo.Kategoria == "egyeni" ? "Nem" : "Igen")}");
            Console.WriteLine($"Teljesítette a teljes távot? {(talaltVersenyzo.TavSzazalek == 100 ? "Igen" : "Nem")}");
        }
        else
        {
            Console.WriteLine($"A keresett nevű sportoló ({keresettNev}) nem indult a versenyen.");
        }
    }

    static void f7(List<Versenyzo> versenyzok)
    {
        List<Versenyzo> teljesVersenyzok = new List<Versenyzo>();

        foreach (Versenyzo v in versenyzok)
        {
            if (v.TavSzazalek == 100)
            {
                teljesVersenyzok.Add(v);
            }
        }

        if (teljesVersenyzok.Count > 0)
        {
            double osszOra = 0;
            foreach (Versenyzo v in teljesVersenyzok)
            {
                osszOra += v.VersenyidoTimeSpan().TotalHours;
            }

            double atlagOra = osszOra / teljesVersenyzok.Count;
            Console.WriteLine($"7. Feladat: Átlagos idő: {atlagOra} óra");
        }
    }

    static void f8(List<Versenyzo> versenyzok)
    {
        Console.WriteLine("8. feladat: A verseny győztesei:");

        Versenyzo leggyorsabbNoi = null;
        foreach (Versenyzo v in versenyzok)
        {
            if (v.Kategoria == "Noi" && v.TavSzazalek == 100)
            {
                if (leggyorsabbNoi == null || v.VersenyidoTimeSpan() < leggyorsabbNoi.VersenyidoTimeSpan())
                {
                    leggyorsabbNoi = v;
                }
            }
        }

        Versenyzo leggyorsabbFerfi = null;
        foreach (Versenyzo v in versenyzok)
        {
            if (v.Kategoria == "Ferfi" && v.TavSzazalek == 100)
            {
                if (leggyorsabbFerfi == null || v.VersenyidoTimeSpan() < leggyorsabbFerfi.VersenyidoTimeSpan())
                {
                    leggyorsabbFerfi = v;
                }
            }
        }

        if (leggyorsabbNoi != null)
        {
            Console.WriteLine($"Nők: {leggyorsabbNoi.Nev} ({leggyorsabbNoi.Rajtszam}.) - {leggyorsabbNoi.Versenyido}");
        }

        if (leggyorsabbFerfi != null)
        {
            Console.WriteLine($"Férfiak: {leggyorsabbFerfi.Nev} ({leggyorsabbFerfi.Rajtszam}.) - {leggyorsabbFerfi.Versenyido}");
        }
    }
}