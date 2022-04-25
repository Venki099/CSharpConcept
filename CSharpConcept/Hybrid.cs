using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    
    public class Transport
    {
        public  void TypesOFtrans()
        {
           Console.WriteLine("The Types of Transport Land\n Air\n Water");
        }
    }

        public class TwoWheeler:Transport
        {
            public  void TypesOfTwoWheeler()
            {
                Console.WriteLine("Moped,Bike,SportsBike are some of the classifications of two wheeler");            
            }
        }

    public class fourWheeler : Transport
    {
        public  void TypesOfFourWheeler()
        {
            Console.WriteLine("Sedan,CUV,SUV,Hatchback,Crossover");
        }
    }

    public class transporter: TwoWheeler 
    {
        public  void Noofpeopleuse()
        {
            Console.WriteLine("Max 2 can easily travel comfortabely");
        }
    }

    public class Brands : TwoWheeler
    {
        public  void TypeofBrand()
        {
            Console.WriteLine("Hero,TVS,BAJAJ,Jawa,Royal Enfield,KTM are some the popular two wheeler brands");
        }
    }


    public class HybriInhris
    {
        public static void Main()
        {
            TwoWheeler t1 = new TwoWheeler();
            t1.TypesOfTwoWheeler();
            t1.TypesOFtrans();

            fourWheeler f1 = new fourWheeler();
            f1.TypesOfFourWheeler();
            f1.TypesOFtrans();


        }
    }


}
