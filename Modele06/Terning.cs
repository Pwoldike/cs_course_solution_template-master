using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele06
{
    public class Terning
    {
        private int værdi;

        public Terning() : this(5)
        {
            
        }

        public Terning(int startVærdi)
        {
            if (startVærdi < 1 || startVærdi > 6)
            
                startVærdi = 1;
            
            this.værdi = startVærdi;
        }

        /// <summary>
        /// skriver terningens værdi ud på console
        /// </summary>
        public void Skriv()
        {
            Console.WriteLine("[" + værdi + "]");
        }

        public int HentVærdi()    // getter
        {
            return this.værdi;
        }

        public void GemVærdi(int værdi)  //setter
        {
            if (værdi < 1 || værdi > 6)

                værdi = 1;

            this.værdi = værdi;
        }

    }
}
