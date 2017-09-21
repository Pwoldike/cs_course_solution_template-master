using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele06
{
    class Program
    {
        static void Main(string[] args)
        {
            Person i = null;            // laves på STACK
            Console.WriteLine(i);
            i = new Person();
            Console.WriteLine(i);

            i.name = "Kurt";
            i.alder = 97;
            i.erILive = true;

            Person u = new Person("Leonora", 48, true);

            Person w;

            u = null;   // sletter reference til HEAP og data i HEAP slettes
            u = i;      // i = null
            Console.WriteLine(i.name);
            Console.WriteLine(u.name);
            w = u;      // w er også lige null 
            Console.WriteLine(w.name);

            w = null;

            // Console.WriteLine(w.name);  // giver exception da w = null

            Terning t1 = new Terning();
            t1.Skriv();

            Terning t2 = new Terning(6);
            t2.Skriv();

            Terning t3 = new Terning(60);
            t3.Skriv();
            //t3.værdi = 600; det må du ikke da værdi er private

            Console.WriteLine("værdien er " + t3.HentVærdi());
            t3.GemVærdi(6);
            t3.Skriv();
            t3.GemVærdi(600);
            t3.Skriv();


        }
    }    
}
