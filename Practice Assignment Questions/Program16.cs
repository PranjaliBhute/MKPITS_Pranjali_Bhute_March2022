using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Assignment_Question_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter alphabet : ");
            int ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a')
                Console.WriteLine("The alphabet is vowel.");
            else
            if (ch == 'e')
                Console.WriteLine("The alphabet is vowel.");
            else
            if (ch == 'i')
                Console.WriteLine("The alphabet is vowel.");
            else
            if (ch == 'o')
                Console.WriteLine("The alphabet is vowel.");
           else 
           if (ch == 'u')
                Console.WriteLine("The alphabet is vowel.");
           else
               Console.WriteLine("The alphabet is a consonant.");
            
               Console.ReadLine();
        }
    }
}
