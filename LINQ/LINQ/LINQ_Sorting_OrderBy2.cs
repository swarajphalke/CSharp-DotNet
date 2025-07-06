using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_Sorting_OrderBy2
    {
        static void Main()
        {
            List<string> names = new List<string> { "Swaraj", "Aditya", "Abhishek", "Purvesh", "Om", "Mayuresh" };

            var sortByLength = names.OrderBy(n => n.Length);

            Console.WriteLine("Names sorted by length: ");

            foreach (var sort in sortByLength)
            {
                Console.WriteLine(sort);
            }
        }
    }
}
