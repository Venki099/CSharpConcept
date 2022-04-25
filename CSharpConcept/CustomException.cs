using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class VotingException:Exception
    {
        public VotingException()
        {
            Console.WriteLine("You are minor, Voting cannot be done");
        }
    }

    public class CustomException
    {
        public static void Main()
        {
            int votersage;
            try
            {

                Console.WriteLine("Enter the voters age");
                votersage = Convert.ToInt32(Console.ReadLine());
                if (votersage < 18)
                {
                    throw (new VotingException());
                }
                else
                {
                    Console.WriteLine("Eligible for voting");
                }
                
            }
            catch (VotingException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1.StackTrace);
                Console.WriteLine(ex1.Message);
            }    

            }
    }

}
