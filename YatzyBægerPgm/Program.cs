using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatzyBægerPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }

    public class YatzyBæger
    {
        private Terning[] terninger;    //privat array

        public YatzyBæger()
        {
            terninger = new Terning[5];
            for (int i = 0; i < 5; i++)
            {
                terninger[i] = new Terning();
            }

        }

        public void Ryst()
        {

        }

    }

    public class Terning
    {
        private static System.Random rnd;

        private int værdi;

        public int Værdi
        {
            get
            {
                Console.WriteLine("Terning aflæses som " + this.værdi);
                return this.værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                {
                    value = 1;

                }
                Console.WriteLine("Terning tildeles værdi " + value);
                this.værdi = value;

            }
        }

        public void Ryst()    //void betyder at der ikke resturneres vædier
        {
            this.Værdi = rnd.Next(1, 7);
        }


        public Terning()
        {
            this.Ryst();
        }

        public void Skriv()     //void - ingen værdier retur
        {
            Console.WriteLine("[" + this.Værdi + "]");
            Console.ReadKey();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }


        static Terning()
        {
            rnd = new Random();
        }
    }
}
