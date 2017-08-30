using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    string value = (i * j).ToString();

                    if (i*j>30)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;


                        if (i * j > 50)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }

                        Console.Write(value.PadLeft(5));
                    }

                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        if (i * j > 15)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                        Console.Write(value.PadLeft(5));
                    }
                }
                
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i < 21; i+=2)
            {
                for (int j = 1; j < 10; j++)
                {
                    string tal = (j * i).ToString();

                    Console.Write(tal.PadRight(5));
                }

                Console.WriteLine();
            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
