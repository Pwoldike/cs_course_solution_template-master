using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] mySalary = { 15555, 25123, 5000, 1000, 18000, 25000, 850000 };


            // Pas på med afrunding

            Double sum = 0;
            Double gns = 0;

            for (int i = 0; i < mySalary.Length; i++)
            {
                Console.WriteLine(mySalary[i]);
                sum += mySalary[i];
            }

            gns = sum / mySalary.Length;
            Console.WriteLine("Average : " + gns.ToString("N2"));

            System.Array.Sort(mySalary);

            for (int i = 0; i < mySalary.Length; i++)
            {
                Console.WriteLine(mySalary[i]);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
