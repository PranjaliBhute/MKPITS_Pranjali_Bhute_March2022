using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Ex_of_Interface_Bank
{
    interface Bank
    {
        string deposit(int act, int amount);
    }
    class Account
    {
        public int actno;
        public int balance = 1000;
    }
    class Saving : Account, Bank 
    {
        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Deposited successfully , bal is " + balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b;
            b = new Saving();
            string str = b.deposit(1, 200);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
