using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic
{
    internal class HashSet_Demo
    {
        static void Main()
        {
            HashSet<int> numbers = new HashSet<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(10);    // Duplicate, will not be added

            foreach (int i in numbers)
                Console.WriteLine(i);
        }
    }
}
