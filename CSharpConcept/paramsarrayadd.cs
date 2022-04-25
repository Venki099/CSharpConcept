using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class paramsarrayadd
    {
        public static void Add(params int[] listnumber)
        {
            int sum = 0;
            foreach (int a in listnumber)
            {
                sum += a;
            }
            Console.WriteLine($"The sum of natural numbers is : {sum}");
        }

        public static void Main()
        {
            Add(1,2, 3,4,5,6,7,8,9,10,11,12,13,14);

            int size;
            Console.WriteLine("The size of array is ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[size];

            //Console.WriteLine("Enter the elements into array");

            for (int i = 0; i < size; i++)
            {
                arr1[i] = i+1;
            }

            Add(arr1);
        }
    }
}
