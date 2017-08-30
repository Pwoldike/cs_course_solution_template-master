using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            //String fornavn = "Mikkel";
            //String efternavn = "Cronberg";

            //String samletNavn = fornavn + " " + efternavn;

            //String navnStor = samletNavn.ToUpper();

            //String navnLille = samletNavn.ToLower();

            //String del = samletNavn.Substring(7, 4);



            //Console.WriteLine(del);

            //String[] navne = samletNavn.Split(' ');

            //System.Linq.Expressions.

            //for (int i = 0; i < navne.Length; i++)
            //{
            //    Console.WriteLine(navne[i]);
            //}

            string line = " ";
            int sum = 0;
            int z = 0;
            for (int x = 1; x < 11; x++)
            {

                for (int y = 1; y < 11; y++)
                {
                    sum = x * y;
                    line = line + sum.ToString().PadLeft(4);
                    z++;
                }
                
                if (z ==10)
                {
                    Console.WriteLine(line);
                    line = " ";
                    z = 0;
                }
                

                
                
            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }


}
