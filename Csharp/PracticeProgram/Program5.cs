using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcptNameAndPrint
{
    internal class PrintName
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Name entered = " + name);
            Console.ReadLine();
        }
    }
}
