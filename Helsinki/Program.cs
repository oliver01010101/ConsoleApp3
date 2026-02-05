namespace Helsinki
{
    internal class Program
    {
        class Helyezes
        {
            public int Helyezes_sorszam { get; set; }
            public int sportolokSzama { get; set; }
            public string Sportag { get; set; }
            public string Sportszam { get; set; }

            public Helyezes(string sor)
            {
                var adatok = sor.Split(new[] { ' ' });
                Helyezes_sorszam = int.Parse(adatok[0]);
                sportolokSzama = int.Parse(adatok[1]);
                Sportag = adatok[2];
                Sportszam = adatok[3];
            }
            
            public string ToString()
            {
                return $"{Helyezes_sorszam}. helyezés - {Sportag} ({Sportszam}) - {sportolokSzama} pont";
            }
        }

        static void Main()
        {
            var helyezesek = new List<Helyezes>();

            foreach (var sor in File.ReadLines("helsinki.txt"))
            {
                helyezesek.Add(new Helyezes(sor));
            }


            var pelda = helyezesek.First(h => h.Helyezes_sorszam == 3 &&
                                              h.sportolokSzama == 4 &&
                                              h.Sportag == "atletika");
            Console.WriteLine($"Példa eredmény: {pelda}\n");

            Console.WriteLine($"3. feladat:");
            Console.WriteLine($"Pontszerző helyezések száma: {helyezesek.Count}");

            int arany = helyezesek.Count(h => h.Helyezes_sorszam == 1);
            int ezust = helyezesek.Count(h => h.Helyezes_sorszam == 2);
            int bronz = helyezesek.Count(h => h.Helyezes_sorszam == 3);
            int osszes = arany + ezust + bronz;

            Console.WriteLine($"4. feladat:");
            Console.WriteLine($"   Arany: {arany}");
            Console.WriteLine($"   Ezüst: {ezust}");
            Console.WriteLine($"   Bronz: {bronz}");
            Console.WriteLine($"   Összesen: {osszes}\n");

            Console.WriteLine("5. feladat:");
            var pontTabla = new Dictionary<int, int>
        {
            {1, 7}, {2, 5}, {3, 4}, {4, 3}, {5, 2}, {6, 1}
        };

            int osszPont = 0;
            foreach (var kvp in pontTabla)
            {
                int helyezesDb = helyezesek.Count(h => h.Helyezes_sorszam == kvp.Key);
                int pontErtek = helyezesDb * kvp.Value;
                osszPont += pontErtek;
            }
            Console.WriteLine($"Olimpiai pontok száma: " + osszPont);

            var uszas = helyezesek.Where(h => h.Sportag == "uszas" && h.Helyezes_sorszam <= 3).ToList();
            var Torna = helyezesek.Where(h => h.Sportag == "torna" && h.Helyezes_sorszam <= 3).ToList();

            Console.WriteLine($"6. feladat:");

            if (uszas.Count() > Torna.Count())
            {
                Console.WriteLine($"Úszás sportágban szereztek több érmét.");
            }
            else
            {
                Console.WriteLine($"Torna sportágban szereztek több érmét.");
            }
            Console.WriteLine();

            var helsinki2 = new List<Helyezes>(helyezesek);

            for (int i = 0; i < helsinki2.Count; i++)
            {
                if (helsinki2[i].Sportag == "kajakkenu")
                {
                    helsinki2[i].Sportag = "kajak-kenu";
                }
            }

            File.WriteAllLines("helsinki2.txt",helsinki2.Select(h => $"{h.Helyezes_sorszam} {h.sportolokSzama} {h.Sportag} {h.Sportszam}"));

            Console.WriteLine("8.Feladat:");
            int legnagyobb = 0;
            int legnagyobbIndex = 0;
            for (int i = 0; i < helyezesek.Count; i++)
            {
                if (helyezesek[i].sportolokSzama > legnagyobb)
                {
                    legnagyobb = helyezesek[i].sportolokSzama;
                    legnagyobbIndex = i;
                }
            }

            Console.WriteLine($"Helyezés: {helyezesek[legnagyobbIndex].Helyezes_sorszam}\nSportág: {helyezesek[legnagyobbIndex].Sportag}\nVersenyszám: {helyezesek[legnagyobbIndex].Sportszam}\nSportolók száma: {helyezesek[legnagyobbIndex].sportolokSzama}");
        }
    }
}
