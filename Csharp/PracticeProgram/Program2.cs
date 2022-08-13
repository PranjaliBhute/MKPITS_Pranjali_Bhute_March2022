using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptCharFromUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Console.WriteLine("Enter Character : ");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Character = " + ch);
            Console.ReadLine();
        }
    }
}
