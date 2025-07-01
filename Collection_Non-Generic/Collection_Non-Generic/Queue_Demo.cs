using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Queue_Demo
    {
        static void Main()
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(3443.03);
            q.Enqueue("Phalke");
            q.Enqueue(342.34);
            q.Enqueue(true);

            Console.WriteLine("top item: "+q.Peek());
            Console.WriteLine("dequeued item: " + q.Dequeue());

            foreach(object o in q)
            {
                Console.WriteLine(o);
            }
        }
    }
}
