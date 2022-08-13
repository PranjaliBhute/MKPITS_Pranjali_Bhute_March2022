using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindGreaterNum
{
    internal class GreaterNumber
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter first number : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)
                Console.WriteLine("n1 is greater.");
            else
                Console.WriteLine("n2 is greater");
            Console.ReadLine();
        }
    }
}
