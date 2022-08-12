using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfProductDetails
{
    class Product
    {
        int prodid;
        string prodname;
        float prodrate;
        int quantity;


        public void productdata()
        {
            Console.WriteLine("Enter product id = ");
            prodid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product name = ");
            prodname = Console.ReadLine();
            Console.WriteLine("Enter product rate = ");
            prodrate = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter quantity= ");
            quantity = Convert.ToInt32(Console.ReadLine());
        }
        public void displayorder()
        {
            Console.WriteLine("prodid = " + prodid);
            Console.WriteLine("prodname = " + prodname);
            Console.WriteLine("prodrate = " + prodrate);
            Console.WriteLine("quantity = " + quantity);

        }

    }
        internal class Program
    {
        static void Main(string[] args)
        {
           Product prod = new Product();
            prod.productdata();
            prod.displayorder();

            Console.ReadLine();

        }
    }
}
