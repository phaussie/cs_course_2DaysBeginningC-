using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul06
{
    class Program
    {
        static void Main(string[] args)
        {

            Person i = new Person();

            i.navn = "Mikkel";
            i.alder = 14;
            i.erILive = true;

            Console.WriteLine(i);

            //Denne peger på Heap, men har ingen værdier
            Person u = new Person();

            u.navn = "Lene";

            Console.WriteLine(u);

            // Denne er null og ligger kun på stack
            Person w;

            u = null;

            u = i;

            Console.WriteLine(i.navn);
            Console.WriteLine(u.navn);

            w = u;
            Console.WriteLine(w.navn);

            Person p = new Person("Lene", 48, true);

            Console.WriteLine();
            Console.WriteLine();

            Terning t1 = new Terning();
            Terning t2 = new Terning(6);
            Terning t3 = new Terning(60);

            t1.Skriv();
            t2.Skriv();
            t3.Skriv();

            Console.WriteLine("Værdien er " + t3.HentVærdi());




        }
    }
}
