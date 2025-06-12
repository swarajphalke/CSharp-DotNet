using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Solid
    {
        public static void pattern()
        {
            int n = 5;
            int m = 5;

            //outer lopp
            for (int i = 1; i <= n; i++)
            {
                //inner loop
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
