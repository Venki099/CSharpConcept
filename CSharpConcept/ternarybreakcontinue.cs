using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class ternarybreakcontinue
    {
        public static void Main()
        {
            isTernary();
        }

        public static void isTernary()
        {
            Console.WriteLine($"Enter the deposit amount");
            int damount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the fixed Amout");
            int fixedamount = Convert.ToInt32(Console.ReadLine());
            var result = damount > fixedamount ? "The interest rate is 8%" : "The interest rate is 7%";
            Console.WriteLine(result);
        }
    }
}
