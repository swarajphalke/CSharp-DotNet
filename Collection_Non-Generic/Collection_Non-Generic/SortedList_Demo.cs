using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class SortedList_Demo
    {
        public static void Main()
        {
            SortedList s = new SortedList();
            s.Add(34, "sss");
            s.Add(12, "www");
            s.Add(72, "aaa");
            s.Add(05, "rrr");
            //s.Add(12, "aaa");   duplicates are not allowed in sorted list

            //s.Remove(34); //first element
            //s.RemoveAt(1); //second element

            Console.WriteLine("----------All Key Value Pairs----------");
            foreach(DictionaryEntry o in s)
            {
                Console.WriteLine(o.Key+ "   "+o.Value);
            }

            Console.WriteLine("\n----------Keys Only----------");
            foreach(object o in s.Keys)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("\n----------Values Only----------");
            foreach (object o in s.Values)
            {
                Console.WriteLine(o);
            }



        }
    }
}
