using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Swastik
    {
        public static void pattern()
        {
            int n = 20;
            int m = 20;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (i == n / 2 || j == n / 2 || (i == 1 && j > n / 2) || (i == n && j < n / 2) || (i > n / 2 && j == m) || (i < n / 2 && j == 1) || (i == n / 4 && j == n / 4) || (i == n / 4 && j == 3 * n / 4) || (j == n / 4 && i == 3 * n / 4) || (j == 3 * n / 4 && i == 3 * n / 4))
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
