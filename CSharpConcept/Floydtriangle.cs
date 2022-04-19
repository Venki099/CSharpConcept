using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Floydtriangle
    {
        public static void Main()
        {
            int num = 1;
            for(int i = 0; i <= 5; i++)
            {
                for (int j =0; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;

                }
                Console.WriteLine();
            }
        }
    }
}
