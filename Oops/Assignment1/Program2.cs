using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfCustomerDetailsUsingMethods
{
    class Customer
    {
        int custno;
        string custname;
        string custaddress;
        long custtelno;

        public void getcustomerdata()
        {
            Console.WriteLine("Enter customer number = ");
            custno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer name = ");
            custname = Console.ReadLine();
            Console.WriteLine("Enter customer address = ");
            custaddress = Console.ReadLine();
            Console.WriteLine("Enter customer telephone number = ");
            custtelno = Convert.ToInt64(Console.ReadLine());

        }
        public void displaycustomerdata()
        {
            Console.WriteLine("custno = " + custno);
            Console.WriteLine("custname = " + custname);
            Console.WriteLine("custaddress = " + custaddress);
            Console.WriteLine("custtelno = " + custtelno);


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.getcustomerdata();
            cust.displaycustomerdata();

            Console.ReadLine();
        }

    }
}

