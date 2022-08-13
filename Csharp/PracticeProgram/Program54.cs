using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstWthNoParaAndAnotherConstWth4Para
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public Book()
        {
            Console.WriteLine("Constructor with no parameter called");
            bookid = 123;
            title = "vb .net";
            author = "Roshan Kumar";
            price = 250;
        }
        public Book(int bookid, string title, string author, int price)
        {
            Console.WriteLine("Constructor with parameter called");
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Bookid = " + bookid);
            Console.WriteLine("Book title = " + title);
            Console.WriteLine("Book author = " + author);
            Console.WriteLine("Price = " + price);
            Console.WriteLine("\n");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.display();
            Book b2 = new Book(11, "Oraclei", "James", 400);
            b2.display();
            Console.ReadLine();
        }
    }
}
