using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
   
    
    public abstract class Bonus_Calculation
    {
        protected double salary;
        /// <summary>.
        /// 
        /// </summary>
        public abstract void GetSalary();

        public void Calculate_Bonus (double bonus)
        {
            Console.WriteLine("Year end Bonus is {0}",salary + bonus);
        }
    }

    public class Junior:Bonus_Calculation
    {
        public override void GetSalary()
        {
            salary = 35000;
        }
    }

    public class Senior:Bonus_Calculation
    {
        public override void GetSalary()
        {
            salary = 55000;
        }
    }

    public class Abstr
    {
        public static void Main()
        {
            Bonus_Calculation calc;

            calc = new Junior();
            calc.GetSalary();
            calc.Calculate_Bonus(15000);

            //Senior

            calc = new Senior();
            calc.GetSalary();
            calc.Calculate_Bonus(25000);
        }
    }
    
}
