using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithParaAndReturnValue
{
    internal class SquareProgram
    {
        static int square(int num)
        {
            int square = num * num;
            return square;
        }
        static void Main(string[] args)
        {
            int num = 5;
            int res = square(num);
            Console.WriteLine("Square = " + res);
            Console.ReadLine();
        }
    }
}
