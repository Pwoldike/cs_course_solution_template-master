using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleDag3Start
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 5, 7, 17, 6, 5, 4, 67, 76, 65, 45, 34, 125, 45, 1, 8, 58 };
            int test = 10;

            ArrayResultat res = BeregnArray(v, test);

            Console.WriteLine(res.Sum);
            Console.WriteLine(res.Gennemsnit.ToString("N2"));
            Console.WriteLine(test);

            ArrayResultat2 res2 = BeregnArray(v, ref test);

            Console.WriteLine(res.Sum);
            Console.WriteLine(res.Gennemsnit.ToString("N2"));
            Console.WriteLine(test);

            Console.ReadKey();

            
        }

        static ArrayResultat BeregnArray(int[] værdier, int y) {

            //TODO: Uden ref
            ArrayResultat resultat;
            resultat.Sum = 0;
            y = 123456;
            resultat.Gennemsnit = 0;

            for (int i = 0; i < værdier.Length; i++)
            {
                resultat.Sum += værdier[i];
            }

            resultat.Gennemsnit = resultat.Sum / værdier.Length;

            værdier[0] = 10000;

            return resultat;
        }

        static ArrayResultat2 BeregnArray(int[] værdier, ref int y)
        {

            //TODO: Med ref

            ArrayResultat2 resultat2;
            resultat2.Sum = 0;
            y = 123456;
            resultat2.Gennemsnit = 0;

            for (int i = 0; i < værdier.Length; i++)
            {
                resultat2.Sum += værdier[i];
            }

            resultat2.Gennemsnit = resultat2.Sum / værdier.Length;

            værdier[0] = 10000;

            return resultat2;
        }


    }

    public struct ArrayResultat {

        public int Sum;
        public decimal Gennemsnit;
    }

    public struct ArrayResultat2
    {

        public int Sum;
        public decimal Gennemsnit;
    }
}
