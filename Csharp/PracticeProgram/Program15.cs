using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalAndClassVariableProgram
{
    internal class Program
    {
        static int gnum = 20;
        static void display()
        {
            int num = 5;
            Console.WriteLine("num inside method = " + num);
            Console.WriteLine("gnum inside method = " + gnum);
        }
        static void Main(string[] args)
        {
            display();
            Console.WriteLine("gnum inside main = " + gnum);
            Console.ReadLine();
        }
    }
}
