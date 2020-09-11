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
            Osszegzes();   //1
            Megszamolas(); //2
            Eldontes();    //3
            Kivalasztas(); //4
            Kereses();     //5

            Console.ReadKey();
        }

        private static void Kereses()
        {
            Console.WriteLine("Keresés tétele");
            int i = 0;
            while (i < tomb.Length && tomb[i] != 50)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Van benne, a {0}. indexen.", i );
            }
            else
            {
                Console.WriteLine("Nincs benne.");
            }
        }

        private static void Kivalasztas()
        {
            Console.WriteLine("Kiválasztás tétele");
            int i = 0;
            while (tomb[i] != 50)
            {
                i++;
            }

            Console.WriteLine("A {0}. indexű helyen van.", i);
        }

        private static void Eldontes()
        {
            Console.WriteLine("Eldöntés tétele");
            int i = 0;
            while (i < tomb.Length && tomb[i] != 69)
            {
                i++;
            }

            if (i < tomb.Length)
            {
                Console.WriteLine("Van 69 a tömbben.");
            }
            else
            {
                Console.WriteLine("Nincs 69 a tömbben.");
            }

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
