using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_bank_using_methods
{
    interface Bank
    {
        string deposit(int actno, int amount);
        string withdraw(int actno, int amount);
    }
    class Account
    {
        public int actno;
        public int balance = 1000;
        public string showbalance()
        {
            return "Balance is " + balance;
        }
    }
    class Saving : Account, Bank
    {

        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Deposited successfully balance is " + balance;
        }
        public string withdraw(int actno, int amount)
        {
            this.actno = actno;
            balance = balance - amount;
            return "Withdraw successfully balance is " + balance;
        }

    }
    internal class Program
        {
        static void Main(string[] args)
        {
            Saving b;
            b = new Saving();
            string str = b.deposit(1, 200);
            Console.WriteLine(str);
            str = b.withdraw(1, 100);
            Console.WriteLine(str);
            Console.WriteLine(b.showbalance());
            Console.ReadLine();


        }
     }
}
