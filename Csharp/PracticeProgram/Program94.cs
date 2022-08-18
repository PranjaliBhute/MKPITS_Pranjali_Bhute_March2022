using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfInterfaceBank
{
    interface Bank
    {
        string deposit(int actno, int amount);
    }
    class Saving : Bank
    {
        int actno;
        int balance = 1000;

        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Deposited successfully, balance is " + balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b;
            b = new Saving();
            String str = b.deposit(1, 200);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
