using Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record
{
    internal class Tuple_Demo
    {
        static void Main()
        {
            var p1 = Tuple.Create(34, "ankit", "kulkarni");
            Console.WriteLine(p1);
        }

        public static void displaytuple(Tuple<int, string, string> person)
        {
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            Console.WriteLine(person.Item3);
        }
    }
}
