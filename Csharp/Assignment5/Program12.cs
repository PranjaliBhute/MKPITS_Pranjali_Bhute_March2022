using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimePolymorphismWithDataMembers
{
    class Animal
    {
        public string color = "White";
    }
    class Dog : Animal 
    {
        public string color = "Black";
    }
    internal class TestPolymorphism
    {
        static void Main(string[] args)
        {
            Animal d = new Dog();
            Console.WriteLine(d.color);
            Console.ReadLine();
        }
    }
}
