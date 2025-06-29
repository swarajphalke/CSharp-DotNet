using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Events
{
    internal class Multicast_Delegates
    {
        public delegate void mydel(int a, int b);

        public static void add(int a, int b)
        {
            Console.WriteLine("Addition is {0}",a+b);
        }

        public static void sub(int a, int b)
        {
            Console.WriteLine("Substraction is {0}",a-b);
        }

        public static void mul(int a, int b)
        {
            Console.WriteLine("Multiplication is {0}",a*b);
        }

        public static void div(int a,int b)
        {
            Console.WriteLine("Division is {0}",a/b);
        }

        public static void Main(String[] args)
        {
            mydel m1 = new mydel(add);
            m1 += sub;
            //m1 += new mydel(sub);
            m1 += new mydel(mul);
            m1 -= new mydel(div);

            m1.Invoke(2, 4);
         }
    }
}
