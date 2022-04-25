using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    class DivNumbers
    {
        int result = 0;
        
        public DivNumbers()
        {
            
        }
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: Divided by zero ", e.Message);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        static void Main()
        {
            DivNumbers d = new DivNumbers();
            d.division(10,0);
            Console.ReadKey();
        }
    }
}
