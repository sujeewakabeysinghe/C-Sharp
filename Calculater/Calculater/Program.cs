using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = Convert.ToInt32("32");
            //Console.WriteLine(num+5);
            Console.Write("enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter an oparator: ");
            string oparator=Console.ReadLine();
            Console.Write("enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if(oparator=="+")
            {
                Console.WriteLine(num1+num2);
            }
            else if(oparator=="-")
            {
                Console.WriteLine(num1-num2);
            }
            else if(oparator=="*")
            {
                Console.WriteLine(num1*num2);
            }
            else if(oparator=="/")
            {
                Console.WriteLine(num1/num2);
            }
            else if(oparator=="%")
            {
                Console.WriteLine(num1%num2);
            }
            else
            {
                Console.WriteLine("wrong oparator!");
            }


            Console.ReadLine();
        }
    }
}
