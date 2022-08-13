using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfPrimeNumOrNot
{
    internal class PrimeNumber
    {
        static void Main(string[] args)
        {
            int num, i, flag = 0;
            Console.WriteLine("Enter number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    flag = flag + 1;
                }

            }
            if (flag == 2)
            {
                Console.WriteLine("Entered number is prime.");
            }
            else
            {
                Console.WriteLine("Entered number is not prime.");
            }
            Console.ReadLine();
        }
    }
}
