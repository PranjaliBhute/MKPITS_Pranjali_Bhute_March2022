using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_of_outofmemoryexception_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Saanvi";
            string subject = "Mathematics";
            Console.WriteLine("Length of name = " + name.Length);
            StringBuilder sb = new StringBuilder(name.Length, name.Length);
            try
            {
                sb.Append(subject);
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
