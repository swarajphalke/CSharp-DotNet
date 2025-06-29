using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Init_Property
{
    internal class Init_Demo1
    {
        static void Main()
        {
            Student s = new Student { Name="Swaraj", Age = 21};
            Console.WriteLine($"{s.Name} - {s.Age}");
         }
    }

    class Student
    {
        public string Name { get; init; }
        public int Age { get; init; }
    }
}
