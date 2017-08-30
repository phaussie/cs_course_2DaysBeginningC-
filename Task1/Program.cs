using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tast dit fornavn:");
            string name = Console.ReadLine();

            Console.WriteLine("Tast dit efternavn");
            string last = Console.ReadLine();

            string output = name.ToUpper(); 
            string output2 = last.ToUpper();



           // Console.Write(output);
           // Console.Write(' ');
            Console.WriteLine("Velkommen " + output + " " + output2);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
