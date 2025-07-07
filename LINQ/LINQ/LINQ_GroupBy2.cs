using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_GroupBy2
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var groups = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");

            foreach (var group in groups)
            {
                Console.WriteLine(group.Key + "Numbers: ");
                foreach (var item in group)
                {
                    Console.WriteLine("  " + item);
                }
            }
        }
    }
}
