using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class String_Pattern
    {
        public static void pattern()
        {
            String input = "Swaraj";

            for (int i = 0; i <= input.Length - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(input[j]);
                }
                Console.WriteLine();
            }

        }
    }
}
