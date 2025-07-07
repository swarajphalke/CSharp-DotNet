using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_Aggregate_Functions2
    {
        static void Main()
        {
            List<string> names = new List<string> { "Swaraj", "Mayuresh", "Manikanth", "Om", "Manav" };

            int mCount = names.Count(name => name.StartsWith("M"));

            Console.WriteLine("Number of names starting with 'M': " + mCount);
        }
    }
}
