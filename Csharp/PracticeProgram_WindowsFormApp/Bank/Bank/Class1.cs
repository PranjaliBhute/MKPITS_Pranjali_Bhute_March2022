using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account
    {
        public int accountno;
        public int balance = 1000;
        public abstract string deposit(int amount);
        public string withdrawl(int amount)
        {
            string res = null;
            if (balance > amount)
            {
                res = "Insuffient amount , cannot withdrawl money!";
            }
            else
            {
                balance = balance - amount;
                res = "Amount withdrawl successfully , balance is = " + balance.ToString();
            }
            return res;
        }
        public string showbalance()
        {
            return "Balance amount is = " + balance.ToString();
        }
    }
    public class Saving : Account
    {
        public override string deposit(int amount)
        {
            int interest = 300;
            balance = balance + amount + interest;
            return "Amount deposited successfully,balance is = " + balance.ToString();
        }
    }
    public class Current : Account
    {
        public override string deposit(int amount)
        {
            balance = balance + amount;
            return "Amount deposite successfully,balance is = " + balance.ToString();

        }
    }
}