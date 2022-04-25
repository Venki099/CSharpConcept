using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class twodmatrixadd
    {
        public static void Main()
        {
            int[,] arr1 = new int[2,2];
            Console.WriteLine("Input the elements of array1");

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Elements-{0}{1}", i, j);
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                    
                }
                
            }

            Console.WriteLine("The elements of array are");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr1[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }

            int[,] arr2 = new int[2, 2];
            Console.WriteLine("Input the elements of array2");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Elements [{0}{1}]",i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                    
                }
                
            }

            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(arr2[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("the addition of two matrix is");

            int[,] arr3 = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    
                    arr3[i, j] = arr1[i,j] + arr2[i,j];
                }
            }

            /*foreach (int a1 in arr3)
            {
                Console.Write(a1+"\t" );
            }*/

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(arr3[i, j]+"\t");
                }
                Console.WriteLine() ;
            }

        }
    }
}
