using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTotalPerAndGrade
{
    internal class Program
    {
        static void display(int n1, int n2, int n3)
        {
            int Total = n1 + n2 + n3;
            float per = (Total / 300.0f) * 100;
            Console.WriteLine("\nTotal = " + Total);
            Console.WriteLine("Percentage = " + per);
            if (per >= 75)
            {
                Console.WriteLine("Grade = Distinction");
            }
            else if (per >= 60 && per < 75)
            {
                Console.WriteLine("Grade = First Division");
            }
            else if (per >= 40 && per < 60)
            {
                Console.WriteLine("Grade = Second Division");
            }
            else
            {
                Console.WriteLine("Fail");
            }


        }
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Enter first subjet marks: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second subjet marks: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third subjet marks: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            display(n1, n2, n3);
            Console.ReadLine();
        }
    }
}
