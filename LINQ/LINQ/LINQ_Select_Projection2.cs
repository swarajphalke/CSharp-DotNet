using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_Select_Projection2
    {
        static void Main()
        {
            List<String> boys = new List<string> { "Swaraj", "Mayuresh", "Siddharth", "Aditya" };

            var upperCase = boys.Select(b => b.ToUpper());

            Console.WriteLine("Capitalized Names: ");
            foreach (var name in upperCase)
            {
                Console.WriteLine(name);
            }
        }


    }
}
