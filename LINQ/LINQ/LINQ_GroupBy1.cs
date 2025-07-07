using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_GroupBy1
    {
        static void Main()
        {
            List<string> names = new List<string>
            {
                "Swaraj","Mayuresh","Manoj","Purvesh","Sanket","Om","Rutik"
            };

            var groups = names.GroupBy(name => name[0]);

            foreach (var group in groups)
            {
                Console.WriteLine("Names starting with '" + group.Key + "':");
                foreach (var name in group)
                {
                    Console.WriteLine("  " + name);
                }
            }
        }
    }
}
