using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactPrgmUsingDoWhileLoop
{
    internal class FactorialProgram
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("Enter number : ");
            num = Convert.ToInt32(Console.ReadLine());
            int i = num;
            do
            {
                fact = fact * i;
                i--;
            } while (i > 0);
            Console.WriteLine("Fact = " + fact);
            Console.ReadLine();
        }
    }
}
