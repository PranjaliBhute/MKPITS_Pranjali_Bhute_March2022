using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number : ");
            num = Convert.ToInt32(Console.ReadLine());
            int square = num * num;
            Console.WriteLine("square= " + square);
            Console.ReadLine();
        }
    }
}
