using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactPrgmUsingWhileLoop
{
    internal class FactorialPrgm
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("Enter number : ");
            num = Convert.ToInt32(Console.ReadLine());
            int i = num;
            while (i > 0)
            {
                fact = fact * i;
                i--;
            }
            Console.WriteLine("Fact = " + fact);
            Console.ReadLine();
        }
    }
}
