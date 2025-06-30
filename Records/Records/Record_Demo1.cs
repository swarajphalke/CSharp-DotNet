using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records
{

    public record Person(string Name, int Age);
    internal class Record_Demo1
    {
        static void Main()
        {
            var p1 = new Person("Sujata", 25);
            var p2 = new Person("Sujata", 25);
            var p3 = new Person("Rahul", 30);

            Console.WriteLine(p1);

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1 == p2);
        }
    }
}
