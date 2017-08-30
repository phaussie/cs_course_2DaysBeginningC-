using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
            //Test2(98);
            Test1(12);

            int res = Test3(1, 4);

            Console.WriteLine(res);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        static void Test1()
        {
            int i = 1;

            Test2(i);

        }

        static void Test2(int y)
        {
            int i = 1;

        }

        static void Test1(int y)
        {
            int i = 1;

        }

        static int Test3(int a, int b)
        {
            return a + b;
        }
    }
}
