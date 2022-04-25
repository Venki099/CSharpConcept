using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
   public abstract class Electricty_Bill
    {
        protected double no_of_units;
        protected double basicamount;

        public abstract void Get_num_of_unit_basicamount();

        public void BillValue(double unitprice)
        {
            Console.WriteLine("Total Electricty Bill is:{0}",(unitprice*no_of_units)+basicamount);
        }
    }

    public class Units: Electricty_Bill
    {
        public override void Get_num_of_unit_basicamount()
        {
            Console.WriteLine("Enter the number of Units");
            no_of_units = Convert.ToDouble(Console.ReadLine());
            basicamount = 365;
        }

    }

    public class Abstrractions
    {
        public static void Main()
        {
            Electricty_Bill calc;
            calc = new Units();
            calc.Get_num_of_unit_basicamount();
            calc.BillValue(5.55);
        }
    }

}
