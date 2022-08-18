using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_static_constructor
{
    public class Account
    {
        public int id;
        public string name;
        public static float rateofInterest;
        public Account(int id, string name)
        {
            Console.WriteLine("Instance constructor is called ");
            this.id = id;
            this.name = name;
        }
        static Account()
        {
            Console.WriteLine("Static constructor is called ");
            rateofInterest = 9.5f;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + rateofInterest);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(1, "Saanvi");
            Account a2 = new Account(2, "Pranjali");
            a1.display();
            a2.display();
            Console.ReadLine();

        }
    }
}
