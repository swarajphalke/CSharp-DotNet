using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Explicit_Interface2
    {
        public static void Main(String[] args)
        {
            Printer p = new Printer();
            ((IColorPrinter)p).Print();
            ((IBWPrinter)p).Print();
        }
    }

    interface IColorPrinter
    {
        void Print();
    }

    interface IBWPrinter
    {
        void Print();
    }

    class Printer : IColorPrinter, IBWPrinter
    {
        // Explicit interface methods

        void IColorPrinter.Print()
        {
            Console.WriteLine("Printing in Color...");
        }

        void IBWPrinter.Print()
        {
            Console.WriteLine("Printing in Black and White");
        }
    }
}
