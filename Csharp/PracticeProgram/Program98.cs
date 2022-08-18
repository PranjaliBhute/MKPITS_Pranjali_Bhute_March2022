using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_of_ststic_keyword
{
    class Student
    {
        public static void display()
        {
            Console.WriteLine("Hello");
        }
        public void sayhi()
        {
            Console.WriteLine("Hi");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student.display();
           // Student.sayhi();
            Student S = new Student();
            S.sayhi();
            Console.ReadLine();
        }
    }
}
