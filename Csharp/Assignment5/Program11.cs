using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimePolymorphismExample2
{
    public class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing....");
        }
    }
    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing rectangle....");
        }
    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing circle....");
        }
    }

    internal class TestPolymorphism
    {
        static void Main(string[] args)
        {
            Shape S;
            S = new Shape();
            S.draw();
            S = new Rectangle();
            S.draw();
            S = new Circle();
            S.draw();
            Console.ReadLine();
        }
    }
}
