using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTimePolymorphismExample
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating.....");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread...");
        }
    }
    internal class TestPolymorphism
    {
        static void Main(string[] args)
        {
            Animal A = new Dog();
            A.eat();
            Console.ReadLine();
        }
    }
}
