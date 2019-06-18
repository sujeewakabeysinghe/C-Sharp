using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int cube = methodOne(num);
            Console.WriteLine("cube of "+num+" is "+cube);

            int x, y, z;
            Console.WriteLine("enter three numbers : ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            int[] nums = methodTwo(x, y, z);
            Console.WriteLine("x = "+nums[0]+"\ny = "+nums[1]+"\nz = "+nums[2]);



            Console.ReadLine();
        }

        static int methodOne(int x)
        {
            return x * x * x;
        }

        static int[] methodTwo(int x, int y, int z)
        {
            x = x + 2;
            y = y + 3;
            z = z + 4;
            int[] nums = { x, y, z };
            return nums;
        }

    }
}
