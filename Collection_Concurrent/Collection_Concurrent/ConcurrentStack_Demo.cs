using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Concurrent
{
    internal class ConcurrentStack_Demo
    {
        static void Main()
        {
            ConcurrentStack<string> stack = new ConcurrentStack<string>();
            stack.Push("Step 1");
            stack.Push("Step 2");

            if(stack.TryPop(out string result))
            {
                Console.WriteLine("Popped: "+result);
            }
        }
    }
}
