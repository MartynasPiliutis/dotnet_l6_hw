using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciuMasyvas = new int[] { 21, 4, 56, 87, 5, 99 };
            int elementuKiekis = skaiciuMasyvas.Length;
            int suma = 0;
            suma = paskaiciuojaElementuSuma(skaiciuMasyvas, elementuKiekis, suma);
            parodoMasyvoElementus(skaiciuMasyvas);
            parodoKiekiIrSuma(elementuKiekis, suma);
            Console.ReadLine();
        }

        private static void parodoKiekiIrSuma(int elementuKiekis, int suma)
        {
            Console.WriteLine($"Skaiciu masyvo elementu kiekis yra: {elementuKiekis}");
            Console.WriteLine($"Skaiciu masyvo elementu suma yra: {suma}");
        }

        private static int paskaiciuojaElementuSuma(int[] skaiciuMasyvas, int elementuKiekis, int suma)
        {
            for (int i = 0; i < elementuKiekis; i++)
            {
                suma += skaiciuMasyvas[i];
            }

            return suma;
        }

        private static void parodoMasyvoElementus(int[] skaiciuMasyvas)
        {
            Console.Write("Skaiciu masyvas yra: ");
            for (int i = 0; i < skaiciuMasyvas.Length; i++)
            {
                Console.Write($"{skaiciuMasyvas[i]} ");
            }
            Console.WriteLine();
        }
    }
}
