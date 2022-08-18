using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_class_student
{
    sealed class Student
    {
        public string name;
    }
    class Parttime : Student
    { }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
