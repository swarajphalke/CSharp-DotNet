using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Method_Para_ref
    {
        public static void Ref()
        {
            int a, b, c;
            Console.Write("Enter a : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter b : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Value of a before swapping {0}", a);
            Console.WriteLine("Value of b before swapping {0}", b);

            swapping(ref a, ref b);
            Console.WriteLine();
            Console.WriteLine("Value of a before swapping {0}", a);
            Console.WriteLine("Value of a before swapping {0}", b);

        }

        public static void swapping(ref int a, ref int b)
        {
            //ref changes the global variable
            //and if we dont't use the ref parameter then the changes will be made in local variable(variable inside method)
            int c;
            c = a;
            a = b;
            b = c;

            Console.WriteLine();
            Console.WriteLine("Value of a after swapping {0}", a);
            Console.WriteLine("Value of b after swapping {0}", b);

        }
    }
}
