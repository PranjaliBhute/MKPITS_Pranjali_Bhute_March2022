using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedInternalAccessSpecifier
{
    class ProtectedTest
    {
        protected internal string name = "Saanvi";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hello" + msg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ProtectedTest PT = new ProtectedTest();
            PT.name = "Saanvi";
            Console.WriteLine(PT.name);
            Console.ReadLine();
        }
    }
}
