using System;

namespace DlitheNew
{
    //Summery
    /// <summary>
    /// Inrto to C#
    /// </summary>

    public class Dl_Batch
    {
        //Functions

        public static void Main()
        {
            Console.WriteLine("Welcome to World Of C#");

            //DataType

            int a = 23;
            Console.WriteLine("The int value is:{0}", a);

            float b = 3.14f;
            double c = 38.232323;
            Console.WriteLine("The float value is:{0} and The double value is:{1}", b, c);
            Console.WriteLine("The float value is:{1} and The double value is:{0}", b, c);
            Console.WriteLine("The float value is:{1} and The double value is:{0}", c, b);

            String s = "CSharp";
            Console.WriteLine(s);
            Console.WriteLine($"The string value is :{s}");

            Char f = 'V';
            bool d = true;
            Console.WriteLine($"Boolean value is:{d} and Character value is {f}");

            double g = 35.33;

            int x = (int)g;
            Console.WriteLine($"The Integer value is:{x}");
            Console.WriteLine($"Convert integer into character " + Convert.ToChar(x));
            Console.WriteLine($"Convert int to special character" + Convert.ToChar(65));

            //Accepting Values
            int tid;
            String name;
            String Des;

            tid = Convert.ToInt32(Console.ReadLine());
        }


    }
}
