using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Mikkel";
            string last = "Cronberg";

            string total = name + " " + last;

            string totalUpper = total.ToUpper();

            string totalLow = total.ToLower();

            string part = last.Substring(0, 4);

            string[] names = total.Split(' ');

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine(name + "\r\n\t\t" + last);

            System.IO.File.WriteAllText(@"C:\Course\test.txt", totalUpper);

            System.IO.File.WriteAllText("C:\\Course\\test2.txt", totalLow);


 
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
