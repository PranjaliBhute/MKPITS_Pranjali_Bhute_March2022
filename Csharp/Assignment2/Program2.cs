using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharVowelOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice;
            Console.WriteLine("Enter character : ");
            choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'a')
                Console.WriteLine("Char is vowel.");
            else if (choice == 'e')
                Console.WriteLine("Char is vowel.");
            else if (choice == 'i')
                Console.WriteLine("Char is vowel.");
            else if (choice == 'o')
                Console.WriteLine("Char is vowel.");
            else if (choice == 'u')
                Console.WriteLine("Char is vowel.");
            else
                Console.WriteLine("Char is not vowel.");
            Console.ReadLine();
        }
    }
}
