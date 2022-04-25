using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Bitwiseopr
    {
        public static void Main()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3;

            //Bitwise or
            num3 = num1 | num2;
            Console.WriteLine("OR operator"+" "+num3);

            //Bitwise and
            num3 = num1 & num2;
            Console.WriteLine("AND operator"+" "+num3);

            //Bitwise XOR
            num3 = num1 ^ num2;
            Console.WriteLine("XOR operator"+" "+num3);

            //Bitwise Complement
            int num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("XOR operator" + " " + (~num6));

            //Right & Left Shift
            int num5 = 20;
            Console.WriteLine(num5 << 1);
            Console.WriteLine(num5 << 4);
            //Bitwise Right Shift Operator
            Console.WriteLine(num5 >> 1);
            Console.WriteLine(num5 >> 2);
            Console.WriteLine(num5 >> 3);
            Console.WriteLine(num5 >> 4);





        }
    }
}
