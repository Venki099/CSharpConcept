using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Paramarrays
    {
        public static void Arrays_Param(params int[] a)
        {
            int size;
            Console.WriteLine("Enter the size of Array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arrr = new int[size];

            for (int i = 0; i < arrr.Length; i++)
            {
                Console.WriteLine("Enter the value at {0}",i+1);
                arrr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The Elements of Array are");

            foreach (int arrayelements in arrr)
            {
                Console.WriteLine(arrayelements);
            }

        }

        public static void Main() 
        {
            Arrays_Param();

            
        }
    }
}
