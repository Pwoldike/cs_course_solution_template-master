using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {

            Int32 heltal = 10;

            heltal++;
            heltal--;

            heltal += 20;

            Console.WriteLine(heltal);

            double kommatal = 12.5;

            kommatal++;
            kommatal--;
            kommatal *=2;

            Console.WriteLine(kommatal);

            FilTyper ft = FilTyper.csv;

            Console.WriteLine(ft);

            DateTime dato = DateTime.Now;

            Console.WriteLine(dato.ToString("ddMMyy"));
            Console.WriteLine(dato.ToString("dMy"));


            Console.WriteLine(dato.ToLongDateString());

            Person p;

            p.id = 1;
            p.navn = "Mikkel";

            Console.WriteLine(p.navn);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    enum FilTyper
    {
        csv,
        pdf,
        txt
    }
    struct Person
    {
        public int id;
        public string navn;
    }
}
