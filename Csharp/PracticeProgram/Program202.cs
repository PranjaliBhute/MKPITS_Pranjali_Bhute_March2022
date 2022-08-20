using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_program_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 2;
            int n2 = 1;
            int res = 0;
            try
            {
                res = n1 / n2;
            }
            catch (Exception ee)  // code will execute only if run time error occurs
            {
                Console.WriteLine("Catch block is executing.");
                Console.WriteLine(ee.ToString());

            }
            finally //code will execute whehter error occurs or not
            {
                Console.WriteLine("Finally block is executing.");
                Console.WriteLine("res = " + res);
            }
            Console.WriteLine("Bye");
            Console.ReadLine();


        }
    }
}
