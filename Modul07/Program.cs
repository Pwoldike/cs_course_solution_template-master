using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul07
{
    class Program
    {
        static void Main(string[] args)
        {

            TerningMedMetoder t = new TerningMedMetoder();
            t.SetVærdi(10);
            Console.WriteLine(t.GetVærdi());

            Terning t2 = new Terning();
            t2.Værdi = 5;
            Console.WriteLine(t2.Værdi);

            //t2.Snyd = true;
            Console.WriteLine(t2.Snyd);
        }
    }
    internal class Person
    {
        public string Navn { get; set; } = " ";
        public int Alder { get; set; }
    }
}
