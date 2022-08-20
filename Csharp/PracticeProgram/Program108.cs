using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_of_zero_temperature_found
{
    class ageexception : ApplicationException
    {
        public ageexception(string message) : base(message)
        {

        }
    }
    class age
    {
        public int age1;
        public void checkage(int age1)
        {
            this.age1 = age1;
            if (age1 < 18)
            {
                throw (new ageexception("You are not eligible to vote."));
            }
            else
            {
                Console.WriteLine("You are eligible to vote.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                age a = new age();
                Console.WriteLine("Enter your age : ");
                int num = Convert.ToInt32(Console.ReadLine());
                try
                {
                    a.checkage(num);
                }
                catch (ageexception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Bye");
                Console.ReadLine();


        }
    }
}
