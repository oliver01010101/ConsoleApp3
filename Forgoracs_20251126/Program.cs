namespace Forgoracs_20251126
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] szoveg = File.ReadAllLines("szoveg.txt");
            string[] kod = File.ReadAllLines("kodlemez.txt");
            string szovegString = string.Join(" ", szoveg);
            Console.WriteLine(szovegString);
            Fracs fracs1 = new Fracs(kod, szovegString);
            fracs1.KiirKodlemez(); 
        }
        class Fracs
        {
            public char[,] Titkositott;
            public char[,] Kodlemez;
            public readonly string Titkositando;
            public Fracs(string[] kod, string titkositando)
            {
                this.Titkositott = new char[8, 8];
                this.Kodlemez = new char[8, 8];
                for (int i = 0; i < 8; i++)
                {
                    string[] line = kod[i].Split(' ');
                    for (int j = 0; j < 8; j++)
                    {
                        this.Kodlemez[i, j] = line[j][0];
                    }
                }
                this.Titkositando = atalakit(titkositando); 
            }
            private string atalakit(string titkositando) 
            {
                titkositando = titkositando.Replace(" ", "").Replace(",", "").Replace(".", ""); 
                if (titkositando.Length > 64)
                {
                    throw new Exception("Maximum 64 betű!");
                }
                return titkositando.PadRight(64, 'X'); 
            }
            public void KiirKodlemez() 
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write(this.Kodlemez[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}