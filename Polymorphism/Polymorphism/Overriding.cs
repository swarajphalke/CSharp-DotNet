using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Overriding
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Dog();
            Animal a3 = new Cat();

            a1.Speak();
            a2.Speak();
            a3.Speak();
        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The Dog barks");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The Cat meows");        }
    }
}
