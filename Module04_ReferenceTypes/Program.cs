using System;

namespace Module04_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                PersonStruct p1;
                p1.Id = 1;
                p1.ErILive = true;

                PersonStruct p2 = new PersonStruct();
                p2.Id++; //Dette kan man kun, når den er allokeret ved at bruge new
                p2.Id = 2;

                p2.ErILive = true;

                personClass p3 = new personClass();
                p3.Id = 3;

                personClass p4 = new personClass();

                p4.Id = 4;


                p3 = p4; //Kopierer referencer, ikke værdier


                int[] i;

                i = new int[5];

                int[] x = new int[5];

                x[0] = 2;
                x[1] = 5;
                x[3] = 25;

                for (int r = 0; r < x.Length; r++)
                {
                    Console.WriteLine(x[r]);
                }
            }

            { int[] i = { 5, 3, 74 };
            int[] x = { 7, 8, 1, 5, 4 };

            i = x; //i får nu en pegepind til det samme som x og det der var i i forsvinder}

                string u = null;

                u = "Mikkel";
                Console.WriteLine(u);
                Console.WriteLine(u.ToString());

                string w = u + "\t\t***\r\n" + u;

                Console.WriteLine(w);

                string stiTilFil = "c:\\temp\\txt.txt";
                string stiTilFil2 = @"c:\temp\txt.txt";

                System.Text.StringBuilder sb = new System.Text.StringBuilder(); //designet til strengmanipulation i løkker/loops

                int y = 0;

                bool f = false;

                if (y>0 && f==false)
                {

                }
                else
                {

                }

                if (System.Diagnostics.Debugger.IsAttached)
            {

                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    struct PersonStruct
    {
        public int Id;
        public bool ErILive;
    }

    class personClass
    {
        public int Id;
        public bool ErILive;
    }


}
