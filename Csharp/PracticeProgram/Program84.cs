using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_shape
{
    public abstract class Shape
    {
        public abstract void draw();
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
    internal class TestAbstract
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
            Console.ReadLine();
        }
    }
}
