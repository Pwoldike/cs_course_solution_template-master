using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    class Person //Intern
    {
        public string forNavn;
        public string efterNavn;
        public int fødselsÅr;

        public string FuldtNavn()
        {
            return forNavn + " " + efterNavn; 
        }

        public int BeregnAlder()
        {
            int year = System.DateTime.Now.Year;
            return year - fødselsÅr; 
        }

        // ctor (default constructor)
        public Person() : this("", "",0)
        {

        }

        // ctor (custom constructor)
        public Person(string forNavn, string efterNavn, int Faar)
        {
            // this

            if (Faar < 0)

                Faar = 0;

            else

                this.fødselsÅr = Faar;




            this.forNavn = forNavn.ToUpper();
            this.efterNavn = efterNavn.ToUpper();

        }
    }
}
