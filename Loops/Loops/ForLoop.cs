using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class ForLoop
    {
        public static void Multiplication()
        {
            Console.Write("Enter Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Table of {0} ", num);
            for (int i = 1; i <= 10; i++)
            {
                int result = num * i;
                Console.WriteLine(result);
            }
        }
    }
}

