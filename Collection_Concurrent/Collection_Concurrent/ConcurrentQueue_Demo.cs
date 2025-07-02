using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Concurrent
{
    internal class ConcurrentQueue_Demo
    {
        static void Main()
        {
            ConcurrentQueue<string>  queue= new ConcurrentQueue< string>();
            queue.Enqueue("Task 1");
            queue.Enqueue("Task 2");

            if(queue.TryDequeue(out string result))
            {
                Console.WriteLine("Dequeued: "+result);
            }
        }
    }
}
