using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Debug3
    {
        public static void Main()
        {
            Console.WriteLine("Enter the value of a & b");
            int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;
            a = a / b;
            a = a / b;
            Console.Write("After swap a= " + b + " b= " + a);
        }
    }
}
