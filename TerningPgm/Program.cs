using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Skriv();
            Terning t2 = new Terning(6);
            //t2.Værdi = 2;
            t2.Skriv();

            LudoTerning t1 = new LudoTerning();
            t1.Skriv();

            Console.WriteLine("Er terning en globus : " + t1.ErGlobus());
            Console.WriteLine("Er terning en stjerne : " + t1.ErStjerne());

            Terning t3 = new LudoTerning(5);
            //t3.Værdi = 5;
            t3.Skriv();

            //Console.WriteLine("Er terning en globus : " +  t3.ErGlobus());
            //Console.WriteLine("Er terning en stjerne : " + t3.ErStjerne());



            Console.ReadKey();
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
                    return værdi;
                }
            set
                {
                if (value < 1 || value > 6)
                    value = 1;
                             
                this.værdi = value;
                }
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public virtual void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
            Console.ReadKey();
        }

        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)   //custom construktor
        {
            this.Værdi = værdi;            //this.Værdi er den offentlige værdi
        }

        static Terning()    //default construktor
        {
            rnd = new Random();
        }
    }

    public class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            return this.Værdi == 3;
        }

        public bool ErStjerne()
        {
            return this.Værdi == 5;
        }

        public override void Skriv()
        {
            Console.WriteLine("(" + this.Værdi + ")");
            Console.ReadKey();
        }

        public LudoTerning() : base()      //default construtor ligesom base
        {

        }

        public LudoTerning(int værdi) : base(værdi) //custom construktor ligesom base
        {

        }
    }

}
