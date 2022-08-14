using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithoutParaReturntype
{
    internal class Program
    {
        static int square()
        {
            int num = 5;
            int square = num * num;
            return square;
        }
        static void Main(string[] args)
        {
            int res = square();
            Console.WriteLine("Square = " + res);
            Console.ReadLine();
        }
    }
}
