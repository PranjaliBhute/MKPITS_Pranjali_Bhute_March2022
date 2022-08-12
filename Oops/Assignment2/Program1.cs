using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfProductDetails
{
    class Product
    {
        int productid;
        string productname;
        int price;
        int quantity;

        public Product()
        {
            productid = 1;
            productname = "Pen";
            price = 20;
            quantity = 10;
        }
        public void display()
        {
            Console.WriteLine("Productid = " + productid);
            Console.WriteLine("Productname = " + productname);
            Console.WriteLine("Price = " + price);
            Console.WriteLine("Quantity = " + quantity);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product P = new Product();
            P.display();
            Console.ReadLine();
        }
    }
}
