using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialPrgmUsingForLoop
{
    internal class ForLoopProgram
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("Enter number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = num; i > 0; i--)
            {
                fact = fact * i;

            }
            Console.WriteLine("fact = " + fact);
            Console.ReadLine();

        }
    }
}
