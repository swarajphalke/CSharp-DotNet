using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_Chaining_Queries2
    {
        static void Main()
        {
            List<string> names = new List<string> { "Swaraj", "Aditya", "Purvesh", "Vinayak", "Siddharth" };

            var result = names
                            .Where(n => n.StartsWith("S"))
                            .OrderBy(n => n)
                            .Select(n => n.ToUpper());

            Console.WriteLine("Filtered, Sorted and Uppercased names: ");
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }

        }
    }
}
