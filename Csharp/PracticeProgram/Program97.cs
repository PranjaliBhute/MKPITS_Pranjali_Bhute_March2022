using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrct_class_person
{
    abstract class Person
    {
        public string name;
    }
    class Student : Person 
    {
        public int rollno;
    }
    sealed class Parttimestudent : Student 
    {
        public int hours;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person(); //error
            Parttimestudent p = new Parttimestudent();
            p.rollno = 22;
            p.name = "Saanvi";
            p.hours = 5;
            Console.WriteLine("rollno : " + p.rollno);
            Console.WriteLine("name : " + p.name);
            Console.WriteLine("hours " + p.hours);
            Console.ReadLine();


        }
    }
}
