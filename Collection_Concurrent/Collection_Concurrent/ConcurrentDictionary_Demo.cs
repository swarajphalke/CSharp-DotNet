using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Concurrent
{
    internal class ConcurrentDictionary_Demo
    {
        static void Main()
        {
            ConcurrentDictionary<int, string> dict = new ConcurrentDictionary<int, string>();
            dict.TryAdd(1, "Swaraj");
            dict.TryAdd(2, "Viraj");

            dict[1] = "Updated Swaraj"; // Update value for key 1

            foreach (KeyValuePair<int,string> o in dict)
                Console.WriteLine(o.Key+":  "+o.Value);
        }
    }
}
