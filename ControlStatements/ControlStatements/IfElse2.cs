using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructures
{
    internal class IfElse2
    {
        public static void EvenOdd()
        {
            Console.Write("Enter Number : ");
            int num  = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("Number {0} is Even Number", num);
            }
            else
            {
                Console.WriteLine("Number {0} is Odd Number",num);
            }
        }
    }
}
