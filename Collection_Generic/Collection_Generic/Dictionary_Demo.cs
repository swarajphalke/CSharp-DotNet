using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic
{
    internal class Dictionary_Demo
    {
        static void Main()
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Swaraj");
            students.Add(2, "Viraj");
            students.Add(3, "Mayuresh");

            foreach(object item in students)
                Console.WriteLine(item);

            students.Remove(2);
            Console.WriteLine("Count: "+students.Count);
        }
    }
}
