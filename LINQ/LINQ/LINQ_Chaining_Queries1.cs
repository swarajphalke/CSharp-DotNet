using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_Chaining_Queries1
    {
        static void Main()
        {
            int[] numbers = { 5, 2, 8, 1, 3, 4 };

            var result = numbers
                            .Where(n => n % 2 == 0)
                            .OrderBy(n => n)
                            .Select(n => n * 2);

            Console.WriteLine("Even, Sorted and Doubled Numbers: ");
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
