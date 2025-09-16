using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alap
{
    internal class Program
    {
        static int ReadNumber(string message, string errorMessage)
        {
            while (true)
            {
                Console.Write(message);
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(errorMessage);
                }
            }
        }

        static int LNKO(int m, int n)
        {
            int r = m % n;
            while (r != 0)
            {
                m = n;
                n = r;
                r = m % n;
            }
            return n;
        }

        static void Szorketto(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= 2;
            }
        }

        static void Main(string[] args)
        {
            while (int.TryParse(Console.ReadLine(), out int n) == false || n <= 0)
            {
                int[] a = { 5, 5, 12 };
                Szorketto(a);
                Console.WriteLine(a[0]);

                Console.WriteLine(LNKO(a[0], a[1]));
            }
        }

        static int LegNagyobbKozosOszto(int num1, int num2)
        {
            int maradek = num2 % num1;
            while (maradek != 0)
            {
                num2 = num1;
                num1 = maradek;
                maradek = num2 % num1;
            }
            return num1;
        }
    }

}


