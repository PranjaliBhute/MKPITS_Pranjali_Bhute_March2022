using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayResultUsingSwitch
{
    internal class DisplayResult
    {
        static void Main(string[] args)
        {
            int s1, s2;
            char op;
            int res = 0;
            Console.WriteLine("Enter first number : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator like + - * /");
            op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+':
                    res = s1 + s2;
                    break;
                case '-':
                    res = s1 - s2;
                    break;
                case '*':
                    res = s1 * s2;
                    break;
                case '/':
                    res = s1 / s2;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;

            }
            Console.WriteLine("Result = " + res);
            Console.ReadLine();

        }
    }
}
