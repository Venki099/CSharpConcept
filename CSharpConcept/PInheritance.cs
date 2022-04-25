using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{

    internal class PInheritance
    {
        protected string courseName;
        protected void Message()
        {
            Console.WriteLine("Welcome to Training Institute");
        }
    }

    internal class CourseDetails1 : PInheritance
    {
        public int courseid;
        public int coursefees;

        public void GetDetails()
        {
            courseid = 100;
            courseName = "C#";
            coursefees = 1000;
        }

        protected void Display_Details()
        {
            base.Message();
            Console.WriteLine("Coure id is : {0} ", courseid);
            Console.WriteLine("Coure Name is : {0} ", courseName);
            Console.WriteLine("Coure Fees is : {0} ", coursefees);
        }
    }

    internal class check : CourseDetails1
    {
        public void call()
        {
            base.Display_Details();
        }

        
    }



    internal class inhrit
    {
        public static void Main()
        {

            check c1 = new check();
            c1.GetDetails();
            c1.call();
            

        }


    }


}
