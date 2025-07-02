using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic
{
    internal class List_Demo
    {
        static void Main()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Mango");
            fruits.Add("Banana");
            fruits.Add("Apple");
            fruits.Add("Grapes");

            foreach(string f in fruits)
            {
                Console.WriteLine(f);
            }

            fruits.Remove("Banana");

            Console.WriteLine("Count: "+fruits.Count);
        }
    }
}
