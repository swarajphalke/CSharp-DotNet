using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class ArrayList_Demo
    {
        static void Main()
        {
            ArrayList arr = new ArrayList();

            arr.Add(12);
            arr.Add("Swaraj");
            arr.Add(789.90);
            arr.Add(true);
            arr.Add('c');

            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[1]);
            //Console.WriteLine(arr[2]);
            //Console.WriteLine(arr[3]);
            //Console.WriteLine(arr[4]);

            string[] s = new string[5] { "aaa", "bbb","ccc","ddd","eee" };
            arr.AddRange(s);

            arr.Insert(1, "Viraj");

            //arr.Remove(true);
            //arr.RemoveAt(0);
            //arr.RemoveRange(5, 1);

            Console.WriteLine("\nTotal elements in ArrayList: {0}", arr.Count);

            Console.WriteLine("\nFinal elements in ArrayList:");
            foreach (object o in arr)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("\nCurrent capacity of ArrayList: {0}", arr.Capacity);

        }
    }
}
