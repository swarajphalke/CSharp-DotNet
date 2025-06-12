using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Basics1
{
    internal class SumIntegers
    {
        public static void App()
        {
           int result = CalculateSum(20, 23, 3, 2, 4, 2);
            Console.WriteLine("Sum of Integers : {0}",result);

        }

        public static int CalculateSum(params int[] numbers)
        {
            int sum = 0;

            foreach(int num in numbers)
            {
                sum = sum + num;
            }
            return sum;
        }
    }
}
