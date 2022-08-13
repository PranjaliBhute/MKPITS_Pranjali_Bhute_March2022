using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOperatorDisplayResult
{
    internal class DisplayResult
    {
        static void Main(string[] args)
        {
            int s1, s2;
            char op;
            int res = 0;
            Console.WriteLine("Enter num1 : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2 : ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator like + - * : ");
            op = Convert.ToChar(Console.ReadLine());
            if (op == '+')
                res = s1 + s2;
            else if (op == '-')
                res = s1 - s2;
            else if (op == '*')
                res = s1 * s2;
            else
                Console.WriteLine("invalid operator");

            Console.WriteLine("result = " + res);
            Console.ReadLine();


        }
    }
}
