using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherExOfCreateAndUsingClasses
{
     class Bank
    {
        public int accountno;
        public int balance = 1000;
        public string deposit(int amount)
        {
            balance = balance + amount;
            return "Amount deposited successfully, balance is = " + balance.ToString();

        }
        public string withdrawl(int amount)
        {
            string res = null;
            if (amount > balance)
            {
                res = "Insufficient amount , cannot withdrawl money.";
            }
            else
            {
                balance = balance - amount;
                res = "Amount withdrawl successfully, balance is = " + balance.ToString();
            }
            return res;
        }
        public string showbalance()
        {
            return "Balance amount is = " + balance.ToString();
        }

     }
}
