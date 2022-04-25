using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Debug8 { 
    
        delegate int NumberChanger(int n);
    

    
        
            static int num = 1;
        public static int AddNum(int p)
            {
                num += p;
                return num;
            }
        public static int MultNum(int q)
        {
            num *= q;
           return num;
        }
                public static int getNum()
                {
                    return num;
                }
                static void Main(string[] args)
                {
                    //create delegate instances
                    NumberChanger nc1 = new NumberChanger(AddNum);
                    NumberChanger nc2 = new NumberChanger(MultNum);

                    //calling the methods using the delegate objects
                    nc1(25);
                    nc2(4);
                    Console.WriteLine("Value of Num: {0}", getNum());
                    Console.WriteLine("Value of Num: {0}", getNum());
                    Console.ReadKey();
                }
            }
        }

