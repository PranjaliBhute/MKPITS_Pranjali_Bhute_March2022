using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_Method_Overriding
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Animal d = new Dog();
                d.eat();
                Console.ReadLine();
        }
    }
}
