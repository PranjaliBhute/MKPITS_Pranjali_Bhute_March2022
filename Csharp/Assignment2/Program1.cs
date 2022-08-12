using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt3NumFindGreaterNum
{
    internal class GreaterNumber
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Enter first number : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number : ");
            n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("n1 is greater.");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("n2 is greater.");
            }
            else
            {
                Console.WriteLine("n3 is greater.");
            }
            Console.ReadLine();
        }
    }
}
