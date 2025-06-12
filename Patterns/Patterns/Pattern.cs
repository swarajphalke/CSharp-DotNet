using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Pattern
    {
        public static void pattern()
        {
            int n = 9;
            int m = 9;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if ((j == m / 3 || j == m - 2) || (i == n / 3 || i == n - 2) || (i == 1 && j == 1) || (i == n && j == m) || (j == m && i == 1) || (j == 1 && i == n) || (i == j && (j == 2 || j == m - 1)) || (i == 2 && j == m - 1) || (i == n - 1 && j == 2))
                    {
                        Console.Write("*" + " ");
                    }
                    else
                    {
                        Console.Write(" " + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
