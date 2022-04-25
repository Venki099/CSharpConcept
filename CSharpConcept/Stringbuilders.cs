using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Stringbuilders
    {
        public static void Main()
        {
            string s1 = "Sql";

            StringBuilder sb1 = new StringBuilder(s1);
            sb1.Insert(0, "My ");
            Console.WriteLine(sb1.ToString());

            sb1.Append(" Server");
            Console.WriteLine(sb1.ToString());

            //sb1.Remove(6, 12);
            //Console.WriteLine(sb1.ToString());

            sb1.Remove(7, 6);
            Console.WriteLine(sb1.ToString());

            sb1.Insert(2, " Micrsoft");
            Console.WriteLine(sb1.ToString());

            sb1.AppendLine("2022");
            Console.WriteLine(sb1.ToString());

            sb1.Remove(6, 7);
            Console.WriteLine(sb1.ToString());

        }
    }
}
