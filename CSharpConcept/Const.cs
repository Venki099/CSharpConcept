using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Const
    {
        public Const()
        {
            Console.WriteLine("This is a default Constructor");
        }

        public Const(String s, long num)
        {
            Console.WriteLine($"The customer name is : {s} and linked phone number is :{num}");
        }

        public static void Main()
        {
            Const s1 = new Const();
            Const s2 = new Const("VSG", 7877641236);
        }

    }
}
