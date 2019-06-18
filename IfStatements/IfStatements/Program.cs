using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = true;
            if (isMale && isTall) //!isTall = not tall
            {
                Console.WriteLine("you are heighted male.");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("you are shorted male.");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("you are heighted female.");
            }
            else
            {
                Console.WriteLine("you are shorted female.");
            }

            Console.WriteLine("enter three numbers : ");
            int x, y, z;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("max is "+methodOne(x,y,z));

            Console.ReadLine();
        }

        static int methodOne(int x,int y,int z)
        {
            int result;
            if (x>y && x>z)
            {
                result = x;
            }
            else if (y>z)
            {
                result = y;
            }
            else
            {
                result = z;
            }
            return result;
        }

    }
}
