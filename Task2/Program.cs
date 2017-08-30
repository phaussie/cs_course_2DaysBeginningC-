using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 10;

            i++;

            i--;

            i += 20;

            //Console.WriteLine(i);

            double j = 12.5;

            j++;

            j--;

            j *= 2;

            //Console.WriteLine(j);

            EnumFiltyper ft = EnumFiltyper.csv;

            Console.WriteLine(ft);
            Console.WriteLine((int) ft);

            DateTime date = DateTime.Now;

            Console.WriteLine(date.ToString("yyyy.MM.dd"));

            structPerson p;

            p.id = 1;
            p.navn = "Mikkel";

            Console.WriteLine(p.navn);

            StructCard s3;

            s3.type = EnumCardType.Spades;
            s3.colour = EnumCardColour.Black;

            StructCard hk;

            hk.type = EnumCardType.Hearts;
            hk.colour = EnumCardColour.Red;

            Console.WriteLine("The s3 has the type and colour:" + s3.type + ", " + s3.colour);

            Console.WriteLine("The hk has the type and colour:" + hk.type + ", " + hk.colour);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        enum EnumFiltyper{
            csv,
            pdf,
            txt

        }

        struct structPerson{

            public int id;
        public string navn;
            
        }

        enum EnumCardType
        {
            Hearts,
            Clubs,
            Diamonds,
            Spades


        }

        enum EnumCardColour
        {
            Red,
            Black
        }


        struct StructCard
        {
            public EnumCardType type;
            public EnumCardColour colour;
        }
    }
}
