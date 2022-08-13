using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPrimeNo1to20UsingWhileLoop
{
    internal class PrintPrimeProgram
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i < 20; i++)
            {
                for (j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    Console.WriteLine("Prime number between 1 to 20 = " + i);
                }
            }
            Console.ReadLine();

         }
        
    }
}


        
    

