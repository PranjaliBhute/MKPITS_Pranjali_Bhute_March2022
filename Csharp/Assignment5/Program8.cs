using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfAccountAcptValueFromUser
{
    class Account
    {
        public int actno;
        public int balance = 1000;
        public virtual string deposit(int actno, int amount)
        {
            return "deposit method of account class";
        }
        public string showbalance()
        {
            return "balance amount : " + balance;
        }
    }

    class Current : Account
    {
        //overriding the base class deposit method
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "amount deposited successfully in current class";
        }


    }
    internal class TestBase
    {
        static void Main(string[] args)
        {
            Account act = new Current();
            Console.WriteLine("Enter account no : ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited : ");
            int amount = Convert.ToInt32(Console.ReadLine());

            String res = act.deposit(actno, amount);
            Console.WriteLine("account no is " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
            Console.ReadLine();



        }
    }
}
