using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ_SelectMany_Flattening1
    {
        static void Main()
        {
            List<string[]> teams = new List<string[]>
            {
                
                new string[] { "Swaraj","Viraj"},
                new string[] {"Mayuresh","Aditya"}
            };

            var result = teams.Select(team => team);

            Console.WriteLine("Using Select: ");
            foreach (var team in result)
            {
                Console.WriteLine("Team: ");
                foreach (var member in team)
                {
                    Console.WriteLine("  " + member);
                }
            }
        }
    }
}
