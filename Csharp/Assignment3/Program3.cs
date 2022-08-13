using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNoPrgmUsingDoWhileLoop
{
    internal class PrimeNumber
    {
        static void Main(string[] args)
        {
            int num, i, flag = 0;
            Console.WriteLine("Enter number : ");
            num = Convert.ToInt32(Console.ReadLine());
            i = 1;
            do
            {
                if (num % i == 0)
                {
                    flag = flag + 1;
                }
                i++;
            } while (i <= num);
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


    

