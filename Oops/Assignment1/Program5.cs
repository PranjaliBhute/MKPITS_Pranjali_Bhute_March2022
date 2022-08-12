using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfCalculate
{
    class Calculate
    {
        public int num1;
        public int num2;
        public int resadd = 0;
        public int ressub = 0;
        public int resmul = 0;
        public int resdiv = 0;

        public void additiondata()
        {
            resadd = num1 + num2;
            Console.WriteLine("addition = " + resadd);
        }


        public void substractiondata()
        {
            ressub = num1 - num2;
            Console.WriteLine("substraction = " + ressub);
        }

        public void multipictationdata()
        {
            resmul = num1 * num2;
            Console.WriteLine("multipication = " + resmul);

        }
        public void divisondata()
        {
            resdiv = num1 / num2;
            Console.WriteLine("divison = " + resdiv);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();

            Console.WriteLine("Enter num 1 = ");
            cal.num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter num 2 = ");
            cal.num2 = Convert.ToInt16(Console.ReadLine());


            cal.additiondata();
            cal.substractiondata();
            cal.multipictationdata();
            cal.divisondata();

            Console.ReadLine();


        }
    }
}
