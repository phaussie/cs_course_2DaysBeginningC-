using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 22000, 45000, 60000, 30000, 55000, 70000 };

            double total = 0;

            for (int i = 0; i < array.Length; i++)
            {

                total += array[i];
            }

            double average = total / array.Length;

            Console.WriteLine(average.ToString());

            double newAve = 0;

            for (int i = 0; i < array.Length; i++)
            {
                double x = array[i] / array.Length;

                newAve += x;
            }

            Console.WriteLine(newAve.ToString());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
