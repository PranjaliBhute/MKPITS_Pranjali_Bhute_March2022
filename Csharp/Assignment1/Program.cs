using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionOf3Numbers
{
    internal class AdditionProgram
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter First Number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number : ");
            z = Convert.ToInt32(Console.ReadLine());
            int result;
            result = x + y + z;
            Console.WriteLine("Addition of 3 Numbers : " + result );
            Console.ReadLine();
        }
    }
}
