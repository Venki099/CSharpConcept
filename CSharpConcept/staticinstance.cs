using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class staticinstance
    {
        public static void isStatic()
        {
            Console.WriteLine("This is Static Method");
            int[] arrr = new int[] {2,4,6,8,10};
            foreach (int num in arrr)
            {
                Console.Write(num+"\t");
                
            }
            Console.WriteLine($"The size of Array arrr is :{arrr.Length} ");
        }


        public void isInstance()
        {
            Console.WriteLine("This is Instance Method");          
           int[] random_numbers = { 77, 33, 56, 12, 7, 2, 5, 1 };

            Console.WriteLine(random_numbers.Min());
            Console.WriteLine(random_numbers.Max());
            Console.WriteLine(random_numbers.Average());
            Console.WriteLine(random_numbers.Count());
        }

        public static void Main()
        {
            isStatic();

            staticinstance s1 = new staticinstance();
            s1.isInstance();
        }
    }
}
