using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class _2darrayaddtion
    {
        public static void Main()
        {
            int[,] arr1 = new int[,]
            {
                {53,42,51 },
                {38,32,25 }
            };

            int[,] arr2 = new int[,]
            {
                {46,48,36 },
                {78,76,45 }
            };

            int[,] arr3 = new int[,] {};

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j
                {
                    arr3[i,j] = arr1[i,j] + arr2[i,j];  
                
            }

            foreach (int i in arr3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
