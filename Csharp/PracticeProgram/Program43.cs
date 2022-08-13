using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayUsingForEachLoop
{
    internal class StringArray
    {
        static void Main(string[] args)
        {
            string[] num = new string[3];
            num[0]= "Pranjali";
            num[1]= "Saanvi";
            num[2]= "Vaibhav";
            foreach (string i in num)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
}
