using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Copy_Constructor
    {
        String name;
        int age;

        // parameterized constructure
        public Copy_Constructor(string studentName, int studentAge)
        {
            name = studentName;
            age = studentAge;
        }

        //copy constructor
        public Copy_Constructor(Copy_Constructor c)
        {
            name = c.name;
            age = c.age;
        }

        public void putData()
        {
            Console.WriteLine("Student Name is : {0}",name);
            Console.WriteLine("Student Age is : {0}", age);
        }
    }
}
