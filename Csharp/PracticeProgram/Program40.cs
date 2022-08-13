using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUsingSbyte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte b1;
            Console.WriteLine("Enter sbyte : ");
            b1 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Sbyte entered = " + b1);
            Console.ReadLine();

        }
    }
}
