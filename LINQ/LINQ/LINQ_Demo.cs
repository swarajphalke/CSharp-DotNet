using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_Demo
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            foreach (object o in evenNumbers)
            {
                Console.WriteLine(o);
            }

        }
    }
}
