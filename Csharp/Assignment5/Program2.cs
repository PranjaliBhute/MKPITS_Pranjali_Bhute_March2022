using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_SavingOrCurrent_
{
    class Account
    {
        public int actno;
        public int balance = 1000;

        public virtual string deposit(int actno, int amount)
        {
            return "Deposit method of account class";
        }
        public string showbalance()
        {
            return "Balance amount : " + balance;
        }
    }

    class Current : Account
    {
       
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Amount deposited successfully without interest in current class";
        }
    }

    class Saving : Account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            int interest = 500;
            balance = balance + amount + interest;
            return "Amount deposited successfully with interest in saving class";
        }
    }
    internal class TestBase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account no : ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account type (saving or current) : ");
            String acttype = Console.ReadLine();


            Account act = null;
            if (acttype == "saving")
            {
                act = new Saving();
            }
            else if (acttype == "current")
            {
                act = new Current();
            }
            String res = act.deposit(actno, amount);
            Console.WriteLine("Account no is " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
            Console.ReadLine();
         }
    }
}
