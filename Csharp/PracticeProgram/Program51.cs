using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcptValueFromTheUser
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public Book(int bookid, string title, string author, int price)
        {
            this.bookid = bookid;
            this.title = title;
           this. author = author;
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
            Console.WriteLine("Enter Bookid = ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book title = ");
            string t1 = Console.ReadLine();
            Console.WriteLine("Book author = ");
            string a1 = Console.ReadLine();
            Console.WriteLine("Enter Price = ");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Book B1 = new Book( b1, t1, a1,  p1);
            B1.display();
            Console.ReadLine();
        }
    }
}
