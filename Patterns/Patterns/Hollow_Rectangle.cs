using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Hollow_Rectangle
    {
        public static void pattern()
        {
            int n = 5;
            int m = 5;

            //outer loop
            for (int i = 1; i <= n; i++)
            {
                //inner loop
                for (int j = 1; j <= m; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
