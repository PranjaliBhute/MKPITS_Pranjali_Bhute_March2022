using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_program_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] num = { 1, 2, 3 };
            try
            {
                Console.WriteLine(num[1]);
                Console.WriteLine(num[3]);
            }
            catch (Exception ee)
            {
                Console.WriteLine("Catch block is executing.");
                Console.WriteLine(ee.ToString());
            }
            finally
            {
                Console.WriteLine("Finally block is executing.");
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
