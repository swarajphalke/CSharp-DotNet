using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Hashtable_Demo
    {
        static void Main()
        {
            Hashtable h = new Hashtable();
            h.Add(34, "sss");
            h.Add("www", 78);
            h.Add("456.45", "aaa");
            h.Add(true, 678);
            h.Add('c', 20);

            Console.WriteLine("----------Elements in Hashtable----------");
            foreach(DictionaryEntry o in h)
            {
                Console.WriteLine(o.Key+ "   "+o.Value);
            }

            Console.WriteLine("\n----------Keys in Hashtable----------");
            foreach (object o in h.Keys)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("\n----------Values in Hashtable----------");
            foreach(object o in h.Values)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("\n----------After Removing Elements----------");
            h.Remove("www");
            foreach(object o in h.Values)
            {
                Console.WriteLine(o);
            }

        }

    }
}
