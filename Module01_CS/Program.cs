﻿using System;

namespace Module01_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Her er min første test");



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
