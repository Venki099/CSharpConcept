using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public delegate void ApartmentExpences( int a);
    public class Delegates1
    {
        public void Monthlymain( int a1)
        {
            Console.WriteLine("Monthly apartment maintainence of is : {0}",1250 * a1);
        }

        public void Watermain( int a2)
        {
            Console.WriteLine("Monthly water maintainence of is : {0}",250 * a2);
        }

        public void Genmain(int a3)
        {
            Console.WriteLine("Monthly Generatir maintainence of is : {0}", 1000 * a3);
        }

        public void Security(int a4)
        {
            Console.WriteLine("Monthly Security maintainence charges of is : {0}", 1300 * a4);
        }

    }

    public class DelegatesDemo
    {
        public static void Main()
        {
            Delegates1 delegates1 = new Delegates1();
            ApartmentExpences e1 = delegates1.Monthlymain;
            e1 += delegates1.Watermain;
            e1 += delegates1.Genmain;
            e1 += delegates1.Security;

            e1(30);

            
           


        }
    }


}
