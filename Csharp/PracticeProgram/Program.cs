using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfOut
{
    internal class Program
    {
        static void display(out int num)
        {
            num = 5;
            Console.WriteLine("num inside method = " + num);
        }
        static void Main(string[] args)
        {
            int num;
            display(out num);
            Console.WriteLine("num inside main = " + num);
            Console.ReadLine();
        }
    }
}
