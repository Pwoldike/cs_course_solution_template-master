using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele06
{
    internal class Person //Intern
    {
        public string name;
        public int alder;
        public bool erILive;


        // ctor (default constructor)
        public Person() : this ("", 0, true)      
        {
                        
        }

        // ctor (custom constructor)
        public Person(string name, int alder, bool erILive)
        {
            // this

            if (alder < 0)
            
                alder = 0;
            
            else
             
                this.alder = alder;
            
        

            
            this.name = name;
            this.erILive = erILive;
        }
    }
    
}
