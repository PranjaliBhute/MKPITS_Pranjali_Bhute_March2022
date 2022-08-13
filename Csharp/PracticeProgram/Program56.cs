using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOfDiffParameterType
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public void getdata(int bookid, string title, string author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void getdata(int bookid, int price, string title, string author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void getdata(string author, int bookid, int price, string title)
        {
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
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.getdata(1, "Oracle", "James", 250);
            b.display();
            Console.WriteLine("----------Book Details-----------");
            Console.WriteLine("\n");
            Book b1 = new Book();
            b1.getdata(1, 250, "Oracle", "James");
            b1.display();
            Console.WriteLine("-----------Book1 Details-------------");
            Console.WriteLine("\n");
            Book b2 = new Book();
            b2.getdata("James", 1, 250, "Oracle");
            b2.display();
            Console.WriteLine("---------Book2 Deatails-----------");
            Console.ReadLine();


        }
    }
}
