using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithParaNoReturntype
{
    internal class Program
    {
        static void square(int num)
        {
            int square = num * num;
            Console.WriteLine("Square = " + square);
        }

        static void Main(string[] args)
        {
            int num = 5;
            square(num);
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
