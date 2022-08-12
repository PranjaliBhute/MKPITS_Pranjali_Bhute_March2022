using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddNumPrgm
{
    internal class EvenOddProgram
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter number : ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Entered number is even.");
            }
            else 
            {
                Console.WriteLine("Entered number is odd.");
            }
            Console.ReadLine();
        }
    }
}
