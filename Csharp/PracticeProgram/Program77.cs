using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingMethodSquarePrgm
{
    internal class SquareProgram
    {
        static void square()
        { 
        int num = 5;
        int square = num * num;
        Console.WriteLine("Square = " + square);
        }
        static void Main(string[] args)
        {
            square();
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
