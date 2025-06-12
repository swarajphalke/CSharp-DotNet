using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Half_Pyramid_With_Numbers
    {
        public static void pattern()
        {
            Console.Write("Enter Number of Rows : ");
            int n = Convert.ToInt32(Console.ReadLine());
            //Outer Loop
            for (int i = 1; i <= n; i++)
            {
                //Inner Loop
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
