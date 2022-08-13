using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTableUsingDoWhileLoop
{
    internal class PrintTable
    {
        static void Main(string[] args)
        {
            int num;
            int res = 1;
            Console.WriteLine("Enter number : ");
            num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            do
            {
                res = num * i;
                Console.WriteLine("{0} * {1} = {2}", num, i, res);
                i++;

            } while (i <= 10);
            Console.ReadLine();
        }
    }
}
