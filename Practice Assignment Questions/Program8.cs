using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Assignment_Question_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The 1st number is the greatest among three.");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The 2nd number is the greatest among three.");
            }
            else 
            {
                Console.WriteLine("The 3rd number is the greatest among three.");
            }
            Console.ReadLine();
        }
    }
}
