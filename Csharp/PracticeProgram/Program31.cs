using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print1to10UsingDoWhileLoop
{
    internal class DoWhileLoopPgrm
    {
        static void Main(string[] args)
        {
            int n = 1;
            do
            {
                Console.WriteLine(n);
                n++;
            } while (n <= 10);
            Console.ReadLine();
        }
    }
}
