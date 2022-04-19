using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class ifelseconcept
    {
        int a;
        int b;
        int c;
        
        
        public static void Main()
        {
            Mathematicalmanu(3, 2, 3);
            Mathematicalmanu(10, 5, 3);
        }


        public static void Mathematicalmanu(int a,int b, int c)
        {
            int sum;
            int avg;
            if(a < 10 && b < 10 && c < 10)
            {
                sum = a+ b + c;
                Console.WriteLine($"The Sum of NUmbers is {sum}");
            }
            else
            {
                avg = (a + b + c) / 3;
                Console.WriteLine($"The average of Number is {avg}");
            }
        }
    }
}
