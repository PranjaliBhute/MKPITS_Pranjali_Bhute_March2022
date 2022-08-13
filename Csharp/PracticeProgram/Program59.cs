using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverlodingWthDiffParaType
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public void getdata(int bookid, int price)
        {
            this.bookid = bookid;
            this.price = price;

        }
        public void getdata(int bookid, string title)
        {
            this.bookid = bookid;
            this.title = title;


        }
        public void getdata(string title, string author)
        {

            this.title = title;
            this.author = author;


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
            b.getdata(1, 1200);
            b.display();
            Console.WriteLine("-----------------book details ----------");

            Book b1 = new Book();
            b1.getdata(1, "oracle");
            b1.display();
            Console.WriteLine("-----------------book1 details ----------");

            Book b2 = new Book();
            b2.getdata("oracle", "bill");
            b2.display();
            Console.WriteLine("-----------------book2 details ----------");


            Console.ReadLine();



        }
    }
}
