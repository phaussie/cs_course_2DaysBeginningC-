using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumUp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] v = { 5, 1, 7, 12, 1, 5 };

            int test = 10;

            ArrayRes r = ValArray(v, ref test);

            Console.WriteLine(r.Sum);
            Console.WriteLine(r.Average.ToString("N2"));


            Console.ReadKey();
            
        }

        // array er ref baseret, så værdier rettes
        // int er stack baseret, så den rettes ikke
        // skal den rettes så skal der stå ref foran og så fungere den som om den ligger på Heap

        static ArrayRes ValArray(int[] values, ref int y)
        {
            ArrayRes result;
            result.Sum = 0;
            result.Average = 0;
            

            for (int i = 0; i < values.Length; i++)
            {
                result.Sum += values[i];
            }

            result.Average = result.Sum / values.Length;

            values[0] = 10000;

            return result;
        
        }
    }

    public struct ArrayRes {

        public int Sum;
        public decimal Average;


    }
}
