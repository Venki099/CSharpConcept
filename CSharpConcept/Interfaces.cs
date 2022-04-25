using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public interface InterfacesPeri
    {
        void CalcPeri();
    }

    public interface InterfacesArea
    {
        void CalcArea();
    }

    public class areaPeriCalcTriangle: InterfacesPeri, InterfacesArea
    {
        void InterfacesPeri.CalcPeri()
        {
            Console.WriteLine("The perimeter of triangle");
            Console.WriteLine("Enter the side lengths");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());   
            double peritriangle = a1 + b1 + c1;
            Console.WriteLine("Perimeter Of Triangle {0}",peritriangle);
        }

        void InterfacesArea.CalcArea()
        {
            Console.WriteLine("The Area of triangle");
            Console.WriteLine("Enter base and height value");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            double areatriangle = ( a2 * b2)/2;

            Console.WriteLine("Area Of Triangle {0}",areatriangle);

        }
    }

    public class areaperiCircle: InterfacesPeri, InterfacesArea
    {
        void InterfacesPeri.CalcPeri()
        {
            Console.WriteLine("Perimeter of circle");
            Console.WriteLine("Enter the radius of Circle");
            double d1 = Convert.ToDouble(Console.ReadLine());
            double pericircle = 2 * 3.14 * d1;
            Console.WriteLine("The perimeter of circle {0}",pericircle);    
        }

        void InterfacesArea.CalcArea()
        {
            Console.WriteLine("Area of circle");
            Console.WriteLine("Enter the radius of Circle");
            double d2 = Convert.ToDouble(Console.ReadLine());
            double areacircle = (3.14 * d2 * d2) / 2;
            Console.WriteLine("The area of circle {0}", areacircle);
        }
    }

    internal class Interfaces1
    {
        public static void Main()
        {
            InterfacesPeri i1 = new areaPeriCalcTriangle();
            i1.CalcPeri();
            InterfacesArea i2 = new areaPeriCalcTriangle();
            i2.CalcArea();

            InterfacesPeri i3 = new areaperiCircle();
            i3.CalcPeri();
            InterfacesArea i4 = new areaperiCircle();
            i4.CalcArea();
        }
    }

}
