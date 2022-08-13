using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print1to10UsingWhileLoop
{
    internal class Whileloopprgm
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n <= 10)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.ReadLine();

        }
    }
}
