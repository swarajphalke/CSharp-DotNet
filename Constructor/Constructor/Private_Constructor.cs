using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Private_Constructor
    {
        //A private constructor is a constructor that cannot be called from outside the class.
            //It’s mainly used to:
            // - Restrict object creation
            // - Often used in classes where all members are static (like utility or helper classes)


        // Private constructor
        private Private_Constructor()
        {
            Console.WriteLine("Private Constructor");
        }

        // Static method
        public static int Square(int num)
        {
            return num * num;
        }
    }
}
