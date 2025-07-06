using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_Where_Filtering2
    {
        static void Main()
        {
            List<string> names = new List<string> { "Swaraj", "Purvesh", "Shyam", "Ravi" };

            var sname = names.Where(n => n.StartsWith("S"));

            Console.WriteLine("Name starting with S: ");
            foreach (var name in sname)
            {
                Console.WriteLine(name);
            }
        }
    }
}
