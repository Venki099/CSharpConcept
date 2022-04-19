using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class naturalNumber
    {
        public static void addnaturalnumb()
        {
            Console.WriteLine($"Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.WriteLine($"Enter the Size");
            int size = Convert.ToInt32(Console.ReadLine());

            while(num <= size)
            {
                sum += num;
                num++;
            }

            Console.WriteLine($"The sum of natural numbers is {sum}");


        }

        public static void Main()
        {
            addnaturalnumb();
        }
    }
}
