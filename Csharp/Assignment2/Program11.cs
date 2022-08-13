using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrgmOfTotalAmount
{
    internal class ProductDetails
    {
        static void Main(string[] args)
        {
            string product_name;
            int product_rate, product_quantity,total_amount;
            Console.WriteLine("Enter Product_name : ");
            product_name = Console.ReadLine();
            Console.WriteLine("Enter product_rate : ");
            product_rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product_quantity : ");
            product_quantity = Convert.ToInt32(Console.ReadLine());
            total_amount = product_rate * product_quantity;
            Console.WriteLine("Total_amount = " + total_amount);
            Console.ReadLine();


        }
    }
}
