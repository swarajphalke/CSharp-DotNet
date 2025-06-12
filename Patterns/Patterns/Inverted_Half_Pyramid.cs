using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Inverted_Half_Pyramid
    {
        public static void pattern()
        {
            int n = 5;
            //Outer Loop
            for (int i = n; i >= 1; i--)
            {
                //Inner Loop
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
