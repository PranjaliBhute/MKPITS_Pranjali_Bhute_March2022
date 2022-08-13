using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrgmOfPassByReference
{
    internal class Program
    {
        static void display(ref int num)
        {
            num++;
            Console.WriteLine("num inside method = " + num);
        }
        static void Main(string[] args)
        {
            int num = 5;
            display(ref num);
            Console.WriteLine("num inside main = " + num);
            Console.ReadLine();
        }
    }
}
