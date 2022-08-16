using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Assignment_Question_5
{
    internal class EligibleForVoteOrNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible for casting your vote.");
            }
            Console.ReadLine();
        }
    }
}
