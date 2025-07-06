using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_Where_Filtering1
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            Console.Write("Even Numbers: ");

            foreach (var num in evenNumbers)
            {
                Console.Write(num + ", ");
            }
        }
    }
}
