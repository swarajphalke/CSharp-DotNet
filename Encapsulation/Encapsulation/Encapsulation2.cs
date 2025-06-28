using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

    class Encapsulation2
    {
        static void Main(string[] args)
        {
            Student1 s = new Student1();
            string name = s.Name = "Swaraj";
            int age = s.Age = 21;
            Console.WriteLine("Name of Student is {0} and his age is {1}", name, age);

            s.Name = "";
            s.Age = -5;


        }
    }
    class Student1
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty");
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value <= 120)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age must be between 1 - 120");
                }
            }
        }
    }


}
