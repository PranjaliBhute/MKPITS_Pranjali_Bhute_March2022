using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharVowelOrNotUsingSwitch
{
    internal class VowelUsingSwitch
    {
        static void Main(string[] args)
        {
            char choice;
            Console.WriteLine("Enter character : ");
            choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Entered char is vowel.");
                    break;
                default:
                    Console.WriteLine("Entered char is not vowel.");
                    break;
             
            }
            Console.ReadLine();

        }
    }
}
