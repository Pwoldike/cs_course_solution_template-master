using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Person u = new Person("Lars","Pedersen", 1965);

            Console.WriteLine(u.forNavn + " " + u.efterNavn + " Fødselsår : " + u.fødselsÅr );

            //string Fu = u.FuldtNavn();

            //Console.WriteLine(Fu);
            Console.WriteLine(u.FuldtNavn());

            //int alder = u.BeregnAlder();

            //Console.WriteLine(alder);
            Console.WriteLine(u.BeregnAlder());

            Person r = new Person();

            Console.WriteLine(r.FuldtNavn());

            Console.WriteLine(r.BeregnAlder());
            
            Console.ReadKey();

        }
    }
}
