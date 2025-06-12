using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Method_Overloading
    {
        public static void method_overloadig()
        {
            display(10);
            display("Swaraj");
            display(5.2);
        }

        static void display(int num)
        {
            Console.WriteLine("Integer : " + num);
        }

        static void display(string text)
        {
            Console.WriteLine("String : " + text);
        }

        static void display(double d)
        {
            Console.WriteLine("Double : " + d);
        }


    }
}
