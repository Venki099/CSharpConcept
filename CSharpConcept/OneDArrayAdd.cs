using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class OneDArrayAdd
    {
        public static void Main()
        {
            int size;
            int sum = 0;
            Console.WriteLine("Enter the size of array");
            size = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[size];

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Enter the value in {0}",(i+1));
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The Elements of array are");
            foreach (int arrelem in arr1)
            {
                Console.WriteLine( arrelem);
            }

            foreach (int arrelems in arr1)
            {
                sum += arrelems;
            }


            Console.WriteLine($"The sum of array is :{sum}");

           
        }
    }
}
