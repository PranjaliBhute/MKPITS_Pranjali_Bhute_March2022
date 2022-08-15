using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Assignment_Questions_1
{
    internal class NumEqualOrNot
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter First Number : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number : ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num1 == num2)
                {
                    Console.WriteLine("Given number are equal.");
                }
                else
                {
                    Console.WriteLine("Given number are not equal.");
                }
                Console.ReadLine();
            }
        }
    }


    

