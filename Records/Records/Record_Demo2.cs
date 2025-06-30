using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record
{
    public record Book(string Title, string Author, double Price);
    internal class Record_Demo2
    {
        static void Main()
        {
            var v1 = new Book("The Alchemist", "Swaraj Phalke", 340.55);
            var v2 = new Book("The Alchemist", "Swaraj Phalke", 340.55);
            var v3 = new Book("Wings of Fire", "A.P.J. Abdul Kalam", 400.34);

            Console.WriteLine(v1);

            Console.WriteLine(v1==v2);
            Console.WriteLine(v1==v3);
        }
    }
}
