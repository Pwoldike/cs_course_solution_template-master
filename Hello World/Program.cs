using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast navn");
            string navn = Console.ReadLine();
            navn = navn.ToUpper();
            Console.WriteLine(navn);
            navn = navn.ToLower();
            Console.WriteLine(navn);
            Console.ReadKey();

        }
    }
}
