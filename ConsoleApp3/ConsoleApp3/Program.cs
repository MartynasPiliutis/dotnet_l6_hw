using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius;
            int laipsnis;
            int result;

            prasoSuvestiSkaiciuLaipsni(out skaicius, out laipsnis);
            result = pakeliaSkaiciuLaipsnius(skaicius, laipsnis);
            Console.ReadLine();
        }

        private static int pakeliaSkaiciuLaipsnius(int skaicius, int laipsnis)
        {
            int rezultatas = Convert.ToInt32(Math.Pow(skaicius, laipsnis));
            Console.WriteLine($"{skaicius}^{laipsnis}={rezultatas}");
            return rezultatas;
        }

        private static void prasoSuvestiSkaiciuLaipsni(out int skaicius, out int laipsnis)
        {
            Console.Write("Iveskite skaiciu: ");
            skaicius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite laipsni: ");
            laipsnis = Convert.ToInt32(Console.ReadLine());
        }
    }
}
