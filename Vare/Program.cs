using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vare


{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = "Vare nr. 1";
            v.Pris = 100.25;

            Console.WriteLine(v.PrisMedMoms());

            Vare v2 = new Vare("Vare nr. 2", 50.85);

            Console.WriteLine(v2.PrisMedMoms());

            Console.ReadKey();
        }

        

            




    }
    public class Vare
    {
        public Vare() 
        {
            
        }
        public Vare(string navn, double pris)
        {
            this.Navn = navn;
            this.Pris = pris;
        }
        private string navn ;

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        private double pris = 0;

        public double Pris
        {
            get { return pris; }
            set { pris = value; }
        }
        public double PrisMedMoms()
        {
            return this.pris * 1.25;
        }

    }
}
