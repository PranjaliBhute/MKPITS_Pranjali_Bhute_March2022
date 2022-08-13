using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptAgeAndPrint
{
    internal class CheckEligibility
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter age : ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
                Console.WriteLine("Not eligible to vote.");
            else
                Console.WriteLine("Eligible to vote.");
            Console.ReadLine();

        }
    }
}
