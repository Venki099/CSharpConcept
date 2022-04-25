using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class jarrays
    {
        public static void Main()
        {
            int[][] jarray = new int[2][]
                    {
                new int[3]{ 20,30 ,50},
                new int[3]{ 30, 60,70 }
            };

            Console.WriteLine("Jagged Array");

            for (int i = 0; i < jarray.Length; i++)
            {
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    Console.Write(jarray[i][j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}
