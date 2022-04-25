using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    struct Customer
    {
        public Customer(int id , String det)
        {
            Console.WriteLine("The customer id is : {0} and ifsc code is : {1}",id, det);
        }

        public static void Main()
        {
            Customer customer = new Customer(1,"SNRB4567");
        }

    }
}
