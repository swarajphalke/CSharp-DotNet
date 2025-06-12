using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Method_Para_out2
    {
        public static void Out()
        {
            int total;
            int multiply;

            Calculate(3, 2, out total, out multiply);
            Console.WriteLine("Sum : " + total);
            Console.WriteLine("product : " + multiply);
        }

        static void Calculate(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }
    }
}
