using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string eilute = "as sdfg  sdf df  0";
            char[] stringArray = eilute.ToCharArray();
            int count = paskaiciuojaTarpusEiluteje(stringArray);
            parodoGalutiniRezultata(eilute, count);
            Console.ReadLine();
        }

        private static void parodoGalutiniRezultata(string eilute, int count)
        {
            Console.WriteLine($"Jusu simboliu eilute yra: {eilute}");
            Console.WriteLine($"Eiluteje yra {count} tarpai");
        }

        public static int paskaiciuojaTarpusEiluteje(char [] stringArray)
        {
            int tarpai = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                string elementas = Convert.ToString(stringArray[i]);
                if (elementas == " ")
                {
                    tarpai++;
                }
            }
            return tarpai;
        }
    }
}
