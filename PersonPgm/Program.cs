using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "Lars";
            p.Efternavn = "Pedersen";
            Console.WriteLine(p.FuldtNavn());

            Elev e = new Elev();
            e.Fornavn = "Elev fornavn";
            e.Efternavn = "Elev efternavn";
            e.Klasselokale = "A52";
            Console.WriteLine(e.FuldtNavn());

            Instruktør i = new Instruktør();
            i.Fornavn = "Instruktør I fornavn";
            i.Efternavn = "Instruktør I efternavn";
            i.NøgleId = 100;
            Console.WriteLine(i.FuldtNavn());

            Console.ReadKey();
        }
    }
    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string FuldtNavn()
        {
            //return this.Fornavn + " " + this.Efternavn;
            return $"{ Fornavn } { Efternavn }";
        }

    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }
    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }
}
