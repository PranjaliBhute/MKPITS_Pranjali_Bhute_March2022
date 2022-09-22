using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnitherExWithRuntimePolymorphism
{
    abstract class Account
    {
        public int accountno;
        public int balance = 1000;
        public abstract string deposit(int amount);

        public string withdrawl(int amount)
        {
            string res = null;
            if (amount > balance)
            {
                res = "Insufficient amount , cannot withdraw money.";
            }
            else
            {
                balance = balance - amount;
                res = "Amount withdrawl successfully, balance is " + balance.ToString();
            }
            return res;
        }
        public string showbalance()
        {
            return "Balance amount is = " + balance.ToString();
        }

    }
    class Saving : Account
    {
        public override string deposit(int amount)
        {
            int interest = 500;
            balance = balance + amount + interest;
            return "Amount deposited successfully with interest , balance is = " + balance.ToString();

        }
    }
    class Current : Account
    {
        public override string deposit(int amount)
        {

            balance = balance + amount;
            return "Amount deposited successfully without interest , balance is = " + balance.ToString();

        }
    }
}