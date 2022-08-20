using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_program_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            Console.WriteLine("Enter number 1 : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            n = Convert.ToInt32(Console.ReadLine());

            int res = 0;
            try
            {
                res = num / n; 
            }
            catch (Exception ee)
            {
                Console.WriteLine("Catch block is executing.");
                Console.WriteLine("Cannot divide by zero. ");
            }
            finally
            {
                Console.WriteLine("Finally block is executing.");
                Console.WriteLine("res = " + res);
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
