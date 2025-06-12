using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Return_Type
    {
        public static void return_type()
        {
            int result = multiply(2, 4);
            Console.WriteLine($" Multiplication is : {result}");
        }

        static int multiply(int a, int b)
        {
            int mul = a * b;
            return mul;
        }
    }
}
