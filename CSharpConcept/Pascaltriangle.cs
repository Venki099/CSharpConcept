using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Pascaltriangle
    {
        public static void Main()
        {
            for (int i = 0; i <= 5; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int p = 0; p <= 5; p++)
            {
                for(int k = 0; k <= 5; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int q = 5;q>=0; q--)
            {
                for(int r = 0;r<=q; r++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
