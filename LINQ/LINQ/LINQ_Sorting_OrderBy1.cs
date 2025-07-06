using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_Sorting_OrderBy1
    {
        static void Main()
        {
            int[] numbers = { 7, 3, 1, 5, 2, 10, 4, 6, 8 };

            var ascending = numbers.OrderBy(n => n);
            var descending = numbers.OrderByDescending(n => n);

            Console.WriteLine("Ascending Order: ");
            foreach (var num in ascending)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nDescending Order: ");
            foreach (var num in descending)
            {
                Console.WriteLine(num);
            }
        }
    }
}
