using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class ACME
    {
        public static void pattern()
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                int num = i * 10;
                for (int j = 1; j <= i; j++)
                {
                    if (i == 1 && j == 1)
                    {
                        Console.Write("*," + " ");
                    }
                    else if (i % 2 == 0 || j == 1)
                    {
                        Console.Write(num + "," + " ");
                    }
                    else
                    {
                        Console.Write("*," + " ");
                    }
                    num += 5;


                }
                Console.WriteLine();
            }
        }
    }
}
