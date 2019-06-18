using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("enter a number : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter another number : ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1/num2);
            }
            catch(Exception e)
            {
                Console.WriteLine("error! " + e.Message);
            }
            finally
            {
                Console.WriteLine("finally what we want to do, if this happen.");
            }

            Console.WriteLine("\n\n");

            //we can catch errors individually and give solution separately

            try
            {
                Console.Write("enter a number : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter another number : ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("first catch -->"+e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("second catch -->"+e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
