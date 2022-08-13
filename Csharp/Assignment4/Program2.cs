using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrgmOf3by3ArrayAddition
{
    internal class AddInThirdArrayProgram
    {
        static void Main(string[] args)
        {
            int[,] num1 = new int[3, 3];
            int[,] sum = new int[3, 3];
            Console.WriteLine("Enter Array Element : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num1[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.WriteLine();
            int[,] num2 = new int[3, 3];
            Console.WriteLine("Enter Array Element : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num2[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum[i, j] = num1[i, j] + num2[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sum[i, j] + "\t");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
