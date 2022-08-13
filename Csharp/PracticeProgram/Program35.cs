using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOfArrayInitialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("num[ {0} ] = {1}", i, num[i]);
                Console.ReadLine();
            }
        }
    }
}
