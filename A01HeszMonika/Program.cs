using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A01HeszMonika
{
    class Program
    {
        static int[] adat = new int[1000];
        static void Beolvasas()
        {
            StreamReader sr = new StreamReader("adatok.dat");
            
            while (!sr.EndOfStream)
            {
                string[] atmeneti = sr.ReadLine().Split(';');
                for (int i = 0; i < adat.Length; i++)
                {
                    adat[i] = Convert.ToInt32(atmeneti[i]);
                    if (adat[i] % 2 != 0)
                    {
                        adat[i] = adat[i] * 2;
                    }
                }
            }
            sr.Close();
        }

        static void Maximumertek()
        {
            int max = 1;
            for (int i = 0; i < adat.Length; i++)
            {
                if (max < adat[i])
                {
                    max = adat[i];
                }
            }
            Console.WriteLine("A maximum: {0}", max);
        }

        static void Egyediek()
        {
            StreamWriter sw = new StreamWriter("egyediek.txt");
            int i = 0;
            int darab = 0;
            while (i < adat.Length && adat[i] % 5 == 0 && adat[i] % 7 == 0)
            {
                if (i < adat.Length)
                {
                    darab++;
                }
            }
            sw.WriteLine("Az 5-tel és 7-tel oszthatók száma: {0}", darab);
            sw.Close();
        }

        static void Main(string[] args)
        {
            Beolvasas();
            Maximumertek();
            Egyediek();

            Console.ReadKey();
        }
    }
}
