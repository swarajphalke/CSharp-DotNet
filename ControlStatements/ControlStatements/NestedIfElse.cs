using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructures
{
    internal class NestedIfElse
    {
        public static void PosOrNeg()
        {
            Console.Write("Enter Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Number is Positive Number");
                if (num % 2 == 0)
                {
                    Console.WriteLine("Number is Even Number");
                }
                else
                {
                    Console.WriteLine("Number is Odd Number ");
                }
            }
            else
            {
                if (num < 0)
                {
                    Console.WriteLine("Number is Negative Number");
                }
                else
                {
                    Console.WriteLine("Number is Zero");
                }
            }
        }
    }
}
