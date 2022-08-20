using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringbuilder_used_append_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Saanvi ");
            sb.Append("Bhute");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("Bye");
            Console.ReadLine();

        }
    }
}
