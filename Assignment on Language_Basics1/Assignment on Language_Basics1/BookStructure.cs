using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Basics1
{
    struct Book
    {
        public int bookId;
        public string title;
        public double price;
        public string author;
    }
    internal class BookStructure
    {

        public static void App()
        {
            Book myBook;

            Console.Write("Enter Book ID: ");
            myBook.bookId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Title: ");
            myBook.title = Console.ReadLine();

            Console.Write("Enter Price: ");
            myBook.price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Author: ");
            myBook.author = Console.ReadLine();

            Console.WriteLine("\n--- Book Details ---");
            Console.WriteLine("Book ID  : " + myBook.bookId);
            Console.WriteLine("Title    : " + myBook.title);
            Console.WriteLine("Price    : " + myBook.price);
            Console.WriteLine("Author   : " + myBook.author);

        }

    }
}
