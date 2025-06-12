using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Basics1
{
    internal class Circle
    {
        public static void App()
        {
            double radius = 5;
            double area, perimeter;

            CalculateCircle(radius, out area, out perimeter);

            Console.WriteLine("For Radius : "+ radius);
            Console.WriteLine("Area of Circle : " + area);
            Console.WriteLine("Perimeter (Circumference) of Circle : " + perimeter);
        }

        public static void CalculateCircle(double radius, out double area, out double perimeter)
        {
            area = Math.PI * radius * radius;
            perimeter = 2 * Math.PI * radius;
        }
    }
}
