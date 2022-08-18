using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfAbstractMethod
{
    abstract class Account
    {
        public int actno;
        public int bal = 1000;
        public abstract void deposit(int amt);
        public void showbalance()
        {
            Console.WriteLine("Bal amount for account number {0} is {1} ", actno, bal);
        }
    }
    class Current : Account
    {
        public override void deposit(int amount)
        {
            bal = bal + amount;
        }
    }
    class Saving : Account
    {
        public override void deposit(int amount)
        {
            int interest = 200;
            bal = bal + amount + interest;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account no. : ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be diposited : ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter account type saving or current : ");
            string acttype = Console.ReadLine();
            Account act = null;
            if (acttype == "saving")
            {
                act = new Saving();
            }
            else if (acttype == "current")
            {
                act = new Current();
            }
            act.actno = actno;
            act.deposit(amt);
            act.showbalance();
            Console.ReadLine();

        }
    }
}
