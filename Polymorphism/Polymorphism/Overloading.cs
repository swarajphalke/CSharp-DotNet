using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Overloading
    {
        static void Main(String[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.Add(4,5));
            Console.WriteLine(c.Add(2.5f,2.5f));
            Console.WriteLine(c.Add("Swa","raj"));
        }
    }

    internal class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public float Add(float a , float b)
        {
            return a + b;
        }

        public string Add(string a, string b)
        {
            return a + b;
        }
    }
}
