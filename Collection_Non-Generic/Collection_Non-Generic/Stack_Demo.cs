using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Stack_Demo
    {
        static void Main()
        {
            Stack s = new Stack();

            s.Push("Swaraj");
            s.Push("Siddharth");
            s.Push("Aditya");
            s.Push("Mayuresh");
            s.Push(560.45);

            Console.WriteLine("top item: "+ s.Peek());  //just check the top item
            Console.WriteLine("popped item: "+s.Pop()); //last item removed

            foreach(object o in s)
            {
                Console.WriteLine(o);
            }
        }
    }
}
