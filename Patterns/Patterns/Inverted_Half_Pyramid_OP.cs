using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Inverted_Half_Pyramid_OP
    {
        public static void pattern()
        {
            int n = 5;

            //Outer Loop
            for (int i = 1; i <= n; i++)
            {
                //Inner Loop -> spaces
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
