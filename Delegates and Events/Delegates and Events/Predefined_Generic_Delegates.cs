using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Events
{
    internal class Predefined_Generic_Delegates
    {
        static void Main()
        {
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine("Sum: "+ add(10,5));

            Action<string> greet = (name) => Console.WriteLine("Hii " + name);
            greet("Swaraj");

            Predicate<string> isValid = (s) => s.Length > 5;
            Console.WriteLine("Is Hello Long: "+isValid("Hello"));
            Console.WriteLine("Is Welcome Long: "+isValid("Welcome"));
        }
    }
}
