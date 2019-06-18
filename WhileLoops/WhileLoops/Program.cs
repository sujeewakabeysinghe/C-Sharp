using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            while (num1<=5)
            {
                Console.WriteLine(num1);
                num1++;
            }
            Console.WriteLine("\n");
            int num2 = 6;
            do
            {
                Console.WriteLine(num2);
                num2++;
            } while (num2 <= 5);

            Console.ReadLine();
        }
    }
}
