using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyrPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr[] dyr = new Dyr[20];   // alloker array med 20 items



            for (int i = 0; i < 20; i++)    // put et tilfældigt dyr i alle elementer
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }

            //dyr[19] = new Dyr()         // Jeg overskriver lige sidste item med et Dyr
            //{
            //    Navn = "Hugo"
            //};
            


            foreach (var item in dyr)
            {
                item.SigNoget();    // udskriv text for enten Hund eller Kat efter klasse
            }

            Console.ReadKey();

        }
    }

    public abstract class Dyr
    // public class Dyr
    {
        static System.Random rnd = new Random();
        public String Navn { get; set; }
        public abstract void SigNoget();      //abstruct metode kan ikke kaldes

        //public virtual void SigNoget()        // SigNoget er generel og bruges på klassen Dyr
        //{
        //    Console.WriteLine("Jeg er et dyr og hedder " + Navn);
        //}



        public static Dyr TilfældigtDyr()
        {
            string sti = @"X:\dyrenavne.txt";       //sti til dyrenavne
            string[] navne = System.IO.File.ReadAllLines(sti);  // Lav array med plads til alle navne i fil og indlæs dem 
            // string[] betyder uendeligt antal
            int index = rnd.Next(0, navne.Length);   // index sættes lige et tilfældigt tal mellem 0 og max antal i navne
            if (index % 2 == 0)     // divider index med 2 --> hvis lige så blev det en hund ellers en kat
            {
                return new Hund()
                {
                    Navn = navne[index]
                };
            }
            else
            {
                return new Kat
                {
                    Navn = navne[index]
                };
            }
	{

                }
            }
        }

        public class Hund : Dyr
        {
            public override void SigNoget()
            {
                Console.WriteLine("Jeg er en Hund og hedder " + Navn);
            }
        }

        public class Kat : Dyr
        {
            public override void SigNoget()
            {
                Console.WriteLine("Jeg er en Kat og hedder " + Navn);
            }
        }
    }

