using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfCustomerDetails
{
    class Customer
    {
        public int custno;
        public string custname;
        public string custaddress;
        public long custtelno;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
               Customer  cust = new Customer();
                cust.custno = 1;
                cust.custname = "Pranjali";
                cust.custaddress = "Pratap nagpur";
                cust.custtelno = 7755911644;

                Console.WriteLine("custno = " + cust.custno);
                Console.WriteLine("custname = " + cust.custname);
                Console.WriteLine("custaddress = " + cust.custaddress);
                Console.WriteLine("custtelno = " + cust.custtelno);
                Console.ReadLine();

        }
    }
}
