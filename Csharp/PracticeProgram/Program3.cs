using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptRedius
{
    internal class DisplayAreaAndCirc
    {
        static void Main(string[] args)
        {
            int radius;
            Console.WriteLine("Enter Radius : ");
            radius = Convert.ToInt32(Console.ReadLine());
            float area = 3.14f * radius * radius;
            Console.WriteLine("Area = " + area);
            float circ = 2 * 3.14f * radius;
            Console.WriteLine("Circ = " + circ);
            Console.ReadLine();

        }
    }
}
