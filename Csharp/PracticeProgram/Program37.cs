using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfCloneMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 5, 1, 2, 4 };

            int[] num1 = (int[])num.Clone();
            for (int i = 0; i < num1.Length; i++)
            {
                Console.Write(num1[i] + "\t");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
