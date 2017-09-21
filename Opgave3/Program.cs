using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            

           Terning[] terninger = new Terning[5];
            for (int i = 0; i < 5; i++)
            {
                terninger[i] = new Terning();
            } 
            
        }
    }

    public class Terning
    {
        private static System.Random rnd;

        private int værdi;

        public int Værdi
        {
            get
            {
                return this.værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                {
                    value = 1;
                   
                }
                this.værdi = value;

            }
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }


        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }


        static Terning()
        {
            rnd = new Random();
        }





        

    }
    public class YatzyBæger
    {

    }
}
