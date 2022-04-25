using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class methosofStrings
    {
        public static void Main()
        {
            string str = "TCS ";
            string str1 = "ANgular ";
            String str2 = "React ";
            String str3 = "Javascript";
            string str4 = "Javascript";
            string str5 = "HTML";
            string str7 = "C#";
            string str9 = "Java";

            //Length
            Console.WriteLine("The length of String is : {0} ",str.Length);
            Console.WriteLine("The length of String is : {0}",str1.Length);
            //Concat
            Console.WriteLine("TCS uses following front software"+" "+ str1+","+" "+str2+","+" "+str3+".");
            Console.WriteLine(string.Concat(str1,str2,str3));
            //Compare
            bool result1 = str4.Equals(str3);
            Console.WriteLine($"The bool value is: {result1}");
            bool result2 = str4.Equals(str5);
            Console.WriteLine($"The bool value is: {result2}");
            //Escape Sequences
            Console.WriteLine("This is an \"ESCAPE SEQUENCE\" character");
            //Clone
            string str6 =(String) str5.Clone();
            Console.WriteLine(str6);
            //Compare To
            Console.WriteLine(str5.CompareTo(str4));
            Console.WriteLine(str5.CompareTo(str7));
            //CompareOrdinal
            Console.WriteLine(string.CompareOrdinal(str7, str5));
            //Contains
            Console.WriteLine(str3.Contains(str9));
            Console.WriteLine(str4.Contains(str6));



        }
    }
}
