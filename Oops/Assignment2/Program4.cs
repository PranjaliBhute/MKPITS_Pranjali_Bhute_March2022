using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_ParameteriseConstWith4Parameters
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
            price = 30;
            quantity = 5;
        }
        public Product(int productid, string productname, int price, int quantity)
        {
            this.productid = productid;
            this.productname = productname;
            this.price = price;
            this.quantity = quantity;
        }
        public void display()
        {
            Console.WriteLine("Enter productid = " + productid);
            Console.WriteLine("Enter productname = " + productname);
            Console.WriteLine("Enter price = " + price);
            Console.WriteLine("Enter quantity = " + quantity);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product P = new Product();
            P.display();
            Console.WriteLine("--------------Product Details-------------");
            Console.WriteLine("\n");
            Product P1 = new Product(1, "Pen", 30, 6);
            P1.display();
            Console.WriteLine("-----------------Product1 Details------------");
            Console.WriteLine("\n");
            Console.WriteLine("Enter productid = ");
            int productid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter productname = ");
            string productname = Console.ReadLine();
            Console.WriteLine("Enter price = ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity = ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Product P2 = new Product(productid, productname, price, quantity); 
            P2.display();
            Console.ReadLine();


        }
    }
}
