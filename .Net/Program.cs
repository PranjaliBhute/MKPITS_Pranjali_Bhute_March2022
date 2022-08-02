using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfRectangle
{
    internal class AreaOfRectangle
    {
        static void Main(string[] args)
        {
            int l, w;
            Console.WriteLine("Enter length : ");
           l= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width : ");
           w= Convert.ToInt32(Console.ReadLine());
            int a;
            a = l * w;
            Console.WriteLine("Area of Rectangle = " + a);
            Console.ReadLine();
        }
    }
}
