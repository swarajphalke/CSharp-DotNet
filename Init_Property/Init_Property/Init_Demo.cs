using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Init_Property
{
    internal class Init_Demo
    {
        static void Main()
        {
            var p = new Person { Name = "Swaraj" };
            //p.Name = "John";
            Console.WriteLine(p.Name);
        }
    }

    class Person
    {
        public string Name { get; init; }

    }
}
