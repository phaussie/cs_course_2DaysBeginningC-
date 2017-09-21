using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul06
{
    // Internal er default, hvis der ikke står noget
    internal partial class Person
    {
        // Default er private
        public string navn;
        public int alder;
        public bool erILive;

        // ctor (default constructor)
        public Person() : this ("", 0, true)
        {

           // navn = "";
           // erILive = false;
        }

        public Person(string navn, int alder, bool erILive)
        {
            //this
            if (alder < 0 || alder > 120)
                alder = 0;
            else 
                this.alder = alder;
            this.navn = navn;
            this.erILive = erILive;
        }

    }
}
