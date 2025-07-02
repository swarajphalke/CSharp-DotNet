using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Concurrent
{
    internal class ConcurrentBag_Demo
    {
        static void Main()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            bag.Add(100);
            bag.Add(200);
            bag.Add(300);

            if(bag.TryTake(out int value))
            {
                Console.WriteLine("Taken: "+value);
            }
        }
    }
}
