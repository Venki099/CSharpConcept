using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Practice
    {

        public  static void Main()
        {

            var practice = new Practice();
            practice.Conditionalswitch();
        }
        public void Conditionalswitch()
        {
            int coursecode;
            Console.WriteLine("Enter the Course Code");
            coursecode = Convert.ToInt32(Console.ReadLine());
            switch (coursecode)
            {
                case 101:
                    Console.WriteLine("Java Programing");
                    break;

                case 102:
                    Console.WriteLine("C# Programing");
                    break ;

                case 103:
                    Console.WriteLine("JavaScript");
                    break;

                case 104:
                    Console.WriteLine("TypeScript");
                    break;

                default:
                    Console.WriteLine("HTML");
                    break;
            
            }
        }
    }
}
