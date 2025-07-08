using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic
{
    internal class Queue_Demo
    {
        static void Main()
        {
            Queue<string> tasks = new Queue<string>();

            tasks.Enqueue("Open Laptop");
            tasks.Enqueue("Write Code");
            tasks.Enqueue("Submit Task");
 
            Console.WriteLine("next: "+ tasks.Peek());
            Console.WriteLine("Done: "+tasks.Dequeue());
        }
    }
}
