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
        static void Beolvasas()
        {
            StreamReader sr = new StreamReader("adatok.dat");
            
            while (!sr.EndOfStream)
            {
                string[] atmeneti;
                int[] adat = new int[1000];
                for (int i = 0; i < adat.Length; i++)
                {
                    adat[i] = Convert.ToInt32(atmeneti[i]);
                }
            }
        }

        static void Maximumertek()
        {

        }

        static void Main(string[] args)
        {
            Beolvasas();
            Maximumertek();

            Console.ReadKey();
        }
    }
}
