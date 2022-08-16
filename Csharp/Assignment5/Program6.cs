using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfBaseKeyword
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating.....");
        }
    }
    public class Dog : Animal 
    {
        public void eat()
        {
            base.eat();
            Console.WriteLine("Eating bread.....");
        }
    }
    internal class TestBase
    {
        static void Main(string[] args)
        {
            Dog g = new Dog();
            g.eat();
            Console.ReadLine();
        }
    }
}
