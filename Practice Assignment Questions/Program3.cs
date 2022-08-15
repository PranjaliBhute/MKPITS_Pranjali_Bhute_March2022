using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Assignment_Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("Entered number is zero.");
            }
            else if (num > 0)
            {
                Console.WriteLine("Entered number is positive.");
            }
            else
            {
                Console.WriteLine("Entered number is negative.");
            }
            Console.ReadLine();
        }
    }
}
