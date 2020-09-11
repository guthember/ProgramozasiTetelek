using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramozasiTetelek
{
    class Program
    {
        static int[] tomb = new int[] { 12, 7, 2, 4, 45, 99, 1, 8, 95, 50 };
        
        static void Main(string[] args)
        {
            TombKiiras();
            Osszegzes();
            Megszamolas();

            Console.ReadKey();
        }

        private static void Megszamolas()
        {
            Console.WriteLine("Megszámolás tétele");
            int darab = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 3 == 0)
                {
                    darab++;
                }
            }
            Console.WriteLine("A tömbben {0} darab 3-al osztható van.", darab);
        }

        private static void Osszegzes()
        {
            Console.WriteLine("\nÖsszegzés tétele");
            int temp = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                // temp = temp + tomb[i];
                temp += tomb[i];
            }
            Console.WriteLine("Az összeg: {0}",temp);
        }

        private static void TombKiiras()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0}, ",tomb[i]);
            }
        }
    }
}
