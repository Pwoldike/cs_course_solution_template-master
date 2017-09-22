using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdvidetRandomPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.sm500());
            Console.ReadKey();
            
        }
    }

    class UdvidetRandom : System.Random
    {
        public bool sm500()
        {
            return this.Next(1, 1002) < 500;
        }
    }
}
