using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_Element_Operators
    {
        static void Main()
        {
            List<string> names = new List<string>();

            var firstO = names.First(n => n.StartsWith("O"));

            var firstZ = names.FirstOrDefault(n => n.StartsWith("Z"));

            var onlySwaraj = names.Single(n => n == "Swaraj");

            var onlyRavi = names.SingleOrDefault(n => n == "Ravi");

            var lastO = names.Last(n => n.StartsWith("O"));


            Console.WriteLine("First starting with 'O': " + firstO);
            Console.WriteLine("First starting with 'Z' (or default): " + (firstZ ?? "Not found"));
            Console.WriteLine("Single match 'Swaraj': " + onlySwaraj);
            Console.WriteLine("Single match 'Ravi' (or default): " + (onlyRavi ?? "Not found"));
            Console.WriteLine("Last starting with 'O': " + lastO);
        }
    }
}
