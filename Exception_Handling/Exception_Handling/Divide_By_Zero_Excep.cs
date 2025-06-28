using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Divide_By_Zero_Excep
    {
        static void Main(String[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                double ans = a / b;
                Console.WriteLine(ans);
            }catch(DivideByZeroException e)
            {
                Console.WriteLine("Caught Exception: "+e.Message);
            }
        }
    }
}
