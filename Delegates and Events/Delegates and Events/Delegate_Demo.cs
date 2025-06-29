using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Events
{
    internal class Delegate_Demo
    {
        public delegate string mydel1(string s);
        public delegate void mydel2(int a, int b);

        public static string greetings(string s)
        {
            return "Welcome " + s;
        }

        public static void add(int a, int b)
        {
            Console.WriteLine("Addition of two no is: " + (a + b));
        }

        static void Main(String[] args)
        {
            mydel1 d1 = new mydel1(greetings);
            mydel2 d2 = new mydel2(add);

           string s = d1.Invoke("Swaraj");
            Console.WriteLine(s);
            d2.Invoke(2, 6);
        }
    }
}
