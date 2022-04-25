using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class CalculatorusingGenrics<T>
    {
        public T AddNum(T n1,T n2)
        {
            Console.WriteLine("The sum of two numbers");
            dynamic num1 = n1;
            dynamic num2 = n2;
            return num1 + num2;
            
                
        }

        public T SubtractNum(T n1, T n2)
        {
            Console.WriteLine("The difference of two numbers");
            dynamic num1 = n1;
            dynamic num2 = n2;
            return num1 - num2;


        }

        public T MultipliNum(T n1, T n2)
        {
            Console.WriteLine("The product of two numbers");
            dynamic num1 = n1;
            dynamic num2 = n2;
            return num1 * num2;


        }

        public T DivisionNum(T n1, T n2)
        {
            Console.WriteLine("The division of two numbers");
            dynamic num1 = n1;
            dynamic num2 = n2;
            return num1 / num2;


        }

        public T ModOF(T n1, T n2)
        {
            Console.WriteLine("The mod of two numbers");
            dynamic num1 = n1;
            dynamic num2 = n2;
            return num1 % num2;


        }
    }

    public class SimpleCalc
    {
        double n1 = 0, n2 = 0;
        public static void Main()
        {
            CalculatorusingGenrics<double> calcu = new CalculatorusingGenrics<double>();


            Console.WriteLine("Enter the first value");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second value");
            double b1 = Convert.ToDouble(Console.ReadLine());
            double sum1 =  calcu.AddNum(a1, b1);
            Console.WriteLine("Addtion of numbers is : {0}", sum1);


            Console.WriteLine("Enter the first value");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second value");
            double b2 = Convert.ToDouble(Console.ReadLine());
            double diff = calcu.SubtractNum(a2,b2);
            Console.WriteLine("Difference of two numbers is : {0}  ", diff);


            Console.WriteLine("Enter the first value");
            double a3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second value");
            double b3 = Convert.ToDouble(Console.ReadLine());
            double multi = calcu.MultipliNum(a3, b3);
            Console.WriteLine("Product of two numbers is : {0}  ", multi);

            Console.WriteLine("Enter the first value");
            double a4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second value");
            double b4 = Convert.ToDouble(Console.ReadLine());
            double div = calcu.DivisionNum(a4, b4);
            Console.WriteLine("Division of two numbers is : {0}  ", div);

            Console.WriteLine("Enter the first value");
            double a5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second value");
            double b5 = Convert.ToDouble(Console.ReadLine());
            double modu = calcu.ModOF(a5, b5);
            Console.WriteLine("Remainder of two numbers is : {0}  ", modu);
        }
    }
}
