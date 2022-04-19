using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class ArthamaticOper
    {
        
        public static void Main()
        {
            double first;
            double second;
            char op;
            double result;

            Console.WriteLine("Enter the first number");
            first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            second = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Operation");

            op =(char)Console.Read();

            

            switch (op)
            {
                case 'a':
                    result = first + second;
                    Console.WriteLine($"The addition of two numbers is : {result}");
                    break;

                case 's':
                    result = first - second;
                    Console.WriteLine($"The difference of two numbers is : {result}");
                    break;

                case 'm':
                    result = first * second;
                    Console.WriteLine($"The product of two numbers is : {result}");
                    break;

                case 'd':
                    result = first / second;
                    Console.WriteLine($"The Division of two numbers is {result}");
                    break;

                case '%':
                    result = first % second;
                    Console.WriteLine($"The Mod of two numbers is {result}");
                    break;
            }
        }
    }
}
