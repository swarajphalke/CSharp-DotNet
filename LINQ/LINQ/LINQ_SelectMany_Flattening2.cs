using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_SelectMany_Flattening2
    {
        static void Main()
        {
            List<string[]> teams = new List<string[]>
            {
                new string[] {"Swaraj","Viraj"},
                new string[] {"Mayuresh","Aditya"}
            };

            var result = teams.SelectMany(team => team);

            Console.WriteLine("Using SelectMany:");
            foreach (var member in result)
            {
                Console.WriteLine(member);
            }
        }
    }
}
