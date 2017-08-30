using System;

namespace Module03_ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            if (System.Diagnostics.Debugger.IsAttached)
            {

                /* 
                 * Variable fra 29/8-17
                 * int i = 0;

                 i = i + 1;

                 //System.Int32 u;

                 decimal x;

                 //System.Decimal y;


                 System.DateTime dato = System.DateTime.Now;
                 System.DateTime jul = new System.DateTime(2017, 12, 24);

                 System.TimeSpan TidTilJul = jul.Subtract(dato);

                 //System.Console.WriteLine();

                 bool c;

                 //brugte variabel int, bool, decimal, DateTime

                 System.Console.Write("Press any key to continue . . . ");
                 System.Console.ReadKey();*/


                {
                    int i = 1;  //32 bit tal
                    short s = 2; //16 bit tal

                    //i = s; er ok
                    // s = i; er ikke mulig, da 32 bit ikke kan være i 16 bit

                    short k = Convert.ToInt16(i); //denne fejler og har en masse metoder indbygget
                    short l = (short)i; // denne fejler ikke, selvom i er for stor til konvertering

                  DayOfWeek friday = DayOfWeek.Friday;



                }
            }
        }
    }

    enum KønEnum
    {
        Mand =1,
        Kvinde =2
    }
}
