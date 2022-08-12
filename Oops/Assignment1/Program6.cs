using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfCircle
{
    class Radius
    {
        public int a;
        public float area = 0;
        public float circ = 0;

        public void areadata()
        {
            area = 3.14f * a * a;
            Console.WriteLine("areaof circle = " + area);
        }
        public void circdata()
        {
            circ = 2 * 3.14f * a;
            Console.WriteLine("circ of circle = " + circ);
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Radius rad = new Radius();
                Console.WriteLine("Enter radius = ");
                rad.a = Convert.ToInt32(Console.ReadLine());

                rad.areadata();
                rad.circdata();

                Console.ReadLine();

            } 
        }
    }   
}
