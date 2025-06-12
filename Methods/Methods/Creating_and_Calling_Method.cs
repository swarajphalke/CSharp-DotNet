using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Creating_and_Calling_Method
    {

        public static void method()
        {
            Console.Write("Enter Number : ");
            int input = Convert.ToInt32(Console.ReadLine());
            CheckEvenOdd(input);
        }
        public static void CheckEvenOdd(int number)
        {
            if (number % 2 == 0)
                Console.WriteLine($"Number {number} is Even");
            else
                Console.WriteLine($"Number {number} is Odd");
        }
    }
}
