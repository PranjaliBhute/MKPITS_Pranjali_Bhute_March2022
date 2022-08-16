using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfAccountClass
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
            return "Amount deposited successfully in current class";
        }
    }
    internal class TestBase
    {
        static void Main(string[] args)
        {
            Account act = new Current();
            string res = act.deposit(11, 2000);
            Console.WriteLine("Account no. is : " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
