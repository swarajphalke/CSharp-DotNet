using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Basics1
{
    internal class Swapping
    {
        public static void App()
        {
            int a = 10;
            int b = 2;
            swap(ref a, ref b);
        }

        public static void swap(ref int a, ref int b)
        {
            Console.WriteLine("Value of a before swapping : {0}", a);
            Console.WriteLine("Value of b before swapping : {0}", b);

            //int c = a;
            //a = b;
            //b = c;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Value of a after swapping : {0}", a);
            Console.WriteLine("Value of b after swapping : {0}", b);
        }
    }
}
