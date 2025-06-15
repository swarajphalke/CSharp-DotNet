using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Inheritance1
    {
        static void Main(String[] args)
        {
            Console.WriteLine("\n🔷 Single Inheritance : ");
            Dog d = new Dog();
            d.Eat();    // From Animal
            d.Bark();   // From Dog

            Console.WriteLine();

            Console.WriteLine("\n🔷 Multilevel Inheritance:");
            Puppy p = new Puppy();
            p.Eat();    // From Animal
            p.Bark();   // From Dog
            p.Weep();   // From Puppy


            Console.WriteLine();

            Console.WriteLine("\n🔷 Hierarchical Inheritance:");
            Cat c = new Cat();
            c.Eat();    // From Animal
            c.Meow();   // From Cat
        }
    }

    //Single Inheritance
    internal class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal can Eat...");
        }
    }

    internal class Dog:Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog can Bark...");
        }
    }

    // Multilevel Inheritance
    internal class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Puppy Weeps");
        }
    }

    // Hierarchical Inheritance
    internal class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Cat Meows");
        }
    }
}
