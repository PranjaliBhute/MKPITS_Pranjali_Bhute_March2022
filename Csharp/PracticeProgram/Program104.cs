using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_indexoutofrangeexception_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 22;
            arr[1] = 33;
            arr[2] = 44;
            try
            {
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine("arr =" + arr[i]);
                }
            }
            catch (IndexOutOfRangeException ee)
            {
                Console.WriteLine("Catch block is executing ");
                Console.WriteLine(ee.ToString());
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            finally
            {
                Console.WriteLine("Finally block is executing ");

            }

            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
