using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Syntax
    {
        static void Main(String[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int ans = a / b;
                Console.WriteLine(ans);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero!");
                //Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
