using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Nullabletype
    {
        public static void Main()
        {
            string s1 = null;
            int? i1 = null;

            int a1 = i1 ?? 20;

            Console.WriteLine(a1);

            int? a2 = 10;

            int a3 = a2 ?? 30;
            Console.WriteLine(a3);

            bool? areuMajor = null;

            if (areuMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (areuMajor == false)
            {
                Console.WriteLine("User is not Major");
            }
            else
            {
                Console.WriteLine("User did not Answer");
            }
        }
    }
}
