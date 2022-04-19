using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Constoverloading
    {
        public Constoverloading(int s)
        {
            Console.WriteLine($"The customer id is : {s}");
        }

        public Constoverloading(int a, string b)
        {
            Console.WriteLine($"The Customer id is : {a} and Customer name is : {b}");
        }

        public Constoverloading(String c ,long d)
        {
            Console.WriteLine($"The customer name is : {c} and linked phone number is : {d}");
        }

        public static void Main()
        {
            Constoverloading c = new Constoverloading(23);
            Constoverloading c1 = new Constoverloading(120, "VSG");
            Constoverloading c2 = new Constoverloading("MSY",7877245884);

        }

    }

    
}
