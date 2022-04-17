using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Trainee
    {
        public static void Main()
        {
            int ID;
            string TraineeName;
            string TraineeDescription;

            Console.WriteLine("Enter the Employee ID");

            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee name");
            TraineeName = Console.ReadLine();
            Console.WriteLine("Enter Employee Des");
            TraineeDescription = Console.ReadLine();

            Console.WriteLine($"The Employee Id is {ID}\n Trainee Name is {TraineeName}\n Trainee Description is {TraineeDescription}");
        }
    }
}
