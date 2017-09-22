﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Terning t = new Terning();
            t.Skriv();
            t.Ryst();
            t.Skriv();
            t.Værdi = 7;
            t.Skriv();
            t = new Terning(6);
            t.Skriv();


           
            
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

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }


        public Terning()
        {
            this.Ryst();
        }

        public void Skriv()
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
    public class YatzyBæger
    {

    }
}
