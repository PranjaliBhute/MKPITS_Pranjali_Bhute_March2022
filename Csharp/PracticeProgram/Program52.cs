using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public Book()
            {
            bookid = 1;
            title = "Oracle";
            author = "james";
            price = 200;
            }
        public void display()
        {
            Console.WriteLine("Bookid = " + bookid);
            Console.WriteLine("Book title = " + title);
            Console.WriteLine("Book author = " + author);
            Console.WriteLine("Price = " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.display();
            Console.ReadLine();
        }
    }
}
