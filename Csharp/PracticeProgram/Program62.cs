using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfStudent
{
    class Student
    {
        public int rno;
        public void getdata(int rno)
        {
            this.rno = rno;
        }
        public void display()
        {
            Console.WriteLine("rno = " + rno);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.getdata(11);
            S.display();
            Console.ReadLine();
        }
    }
}
