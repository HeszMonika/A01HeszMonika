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
                }
            }
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

        static void Main(string[] args)
        {
            Beolvasas();
            Maximumertek();

            Console.ReadKey();
        }
    }
}
