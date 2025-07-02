using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic
{
    internal class Stack_Demo
    {
        static void Main()
        {
            Stack<string> plates = new Stack<string>();
            plates.Push("Plate 1");
            plates.Push("Plate 2");
            plates.Push("Plate 3");
            plates.Push("Plate 4");

            foreach(string s in plates)
                Console.WriteLine(s);

            Console.WriteLine("\nTop Plate: "+plates.Peek());
            Console.WriteLine("Removed: " + plates.Pop());
        }
    }
}
