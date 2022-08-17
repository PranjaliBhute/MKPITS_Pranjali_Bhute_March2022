using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_using_withdrawl_method
{
    class Account
    {
        public long actno;
        public int balance = 25000;

        public virtual string withdrawl(long actno, int amount)
        {
            return "withdrawl method of account class";
        }
        public string showbalance()
        {
            return "Balance amount : " + balance;
        }
    }
    class Current : Account 
    {
        public override string withdrawl(long actno, int amount)
        {
            this.actno = actno;
            balance = balance - amount;
            return "Amount withdrawl successfully from current class";
        }
    }
    class Saving : Account
    {
        public override string withdrawl(long actno, int amount)
        {
            this.actno = actno;
            balance = balance - amount;
            return "Amount withdrawl successfully from saving class";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account no : ");
            long actno = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter amount to be withdrawl : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account type(saving or current) : ");
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
            string res = act.withdrawl(actno, amount);
            Console.WriteLine();
            Console.WriteLine("Account no is : " + act.actno);
            Console.WriteLine(res);
            string res1 = act.showbalance();
            Console.WriteLine(res1);
            Console.ReadLine();
        }
    }
}
