using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


//❌ When You MUST Use Explicit Interface?
// When two interfaces have methods with the same name and signature:
//1) interface IStudent { void Speak(); }
//2) interface ICricketer { void Speak(); }
// Now we MUST use explicit interface, because both have Speak()

//📝 Key Takeaways:
//1) Use explicit implementation when method names are the same in interfaces.
//2) Must cast to the interface to access the method.
//3) It helps avoid conflicts and allows different behaviors.


namespace Interface
{
    internal class Explicit_Interface1
    {
        public static void Main(String[] args)
        {
            Person p = new Person();

            // Cast to interface to call the specific method
            ((ITeacher)p).Speak();
            ((IYoutuber)p).Speak();
        }
    }

    interface ITeacher
    {
        void Speak();   // Explains subject
    }

    interface IYoutuber
    {
        void Speak();   // Talks to audience
    }

    class Person : ITeacher, IYoutuber
    {
        // Explicit interface implementations
        void ITeacher.Speak()
        {
            Console.WriteLine("I am teaching students in a classroom.");
        }

        void IYoutuber.Speak()
        {
            Console.WriteLine("Hey everyone! Welcome to my YouTube channel.");
        }
    }
}
