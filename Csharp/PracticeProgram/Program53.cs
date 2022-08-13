using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingAnotherMethodFromOneMethod
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public void getdata()
        {
            bookid = 1;
            title = "oracle";
            author = "james";
            price = 200;

        }
        public void getdata(int bookid)
        {
            this.bookid = bookid;
            getdata(bookid, "html");

        }
        public void getdata(int bookid, string title)
        {
            this.bookid = bookid;
            this.title = title;
            getdata(bookid, title, "amitabh");

        }
        public void getdata(int bookid, string title, string author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            getdata(bookid, title, author, 234);

        }
        public void getdata(int bookid, string title, string author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Book id = " + bookid);
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
            b.getdata(201);
            b.display();
            Console.WriteLine("-----------------book details ----------");
            Console.ReadLine();
        }
    }
}
