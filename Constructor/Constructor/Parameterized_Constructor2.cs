using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Parameterized_Constructor2
    {
        string title;
        string author;
        public Parameterized_Constructor2(string bookTitle, string bookAuthor)
        {
            title = bookTitle;
            author = bookAuthor;
        }

        public void putData()
        {
            Console.WriteLine("Book Title is : {0} ",title);
            Console.WriteLine("Book Author is : {0} ", author);

        }
    }
}
