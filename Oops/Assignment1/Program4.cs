using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfCarDetails
{
    class Cardata
    {
        int carno;
        string carmodel;
        float carprice;
        float caracc;


        public void getcardata()
        {
            Console.WriteLine("Enter car number = ");
            carno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter car name = ");
            carmodel = Console.ReadLine();
            Console.WriteLine("Eenter car price = ");
            carprice = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter caracc = ");
            caracc = Convert.ToSingle(Console.ReadLine());
        }
        public void displaycardata()
        {
            Console.WriteLine("carno = " + carno);
            Console.WriteLine("carmodel = " + carmodel);
            Console.WriteLine("carprice = " + carprice);
            Console.WriteLine(" caracc = " + caracc);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cardata car = new Cardata();
            car.getcardata();
            car.displaycardata();

            Console.ReadLine();

        }
    }
}
