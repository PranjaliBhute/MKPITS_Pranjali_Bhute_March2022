using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypeInCsharp
{
    internal class DatatypeInCsharp
    {
        static void Main(string[] args)
        {
            byte b1;
            Console.WriteLine("Enter byte : ");
            b1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Byte entered = " + b1);
            Console.ReadLine();
        }
    }
}
