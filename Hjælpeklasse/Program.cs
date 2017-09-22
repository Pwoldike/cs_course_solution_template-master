using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælpeklasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(4, 5));
            Console.ReadKey();
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(5));
            Console.ReadKey();
            Console.WriteLine(BeløbBeregninger.BeregnMoms(1000));
            Console.ReadKey();
        }
    }

    static class ArealBeregninger
    {
        public static double BeregnArealFirkant(double hojde, double bredde)
        {
            return hojde * bredde;
        }

        public static double BeregnArealCirkel(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }

    static class BeløbBeregninger
    {
        public static double BeregnMoms(double Beloeb)
        {
            return Beloeb * 1.25;
        }
    }
}
