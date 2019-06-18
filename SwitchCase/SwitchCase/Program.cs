using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number [0-6] : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(methodOne(x));

            Console.ReadLine();
        }

        static string methodOne(int x)
        {
            string day;

            switch (x)
            {
                case 0: day = "sunday"; break;
                case 1: day = "monday"; break;
                case 2: day = "tuesday"; break;
                case 3: day = "wednesday"; break;
                case 4: day = "thursday"; break;
                case 5: day = "friday"; break;
                case 6: day = "saturday"; break;
                default: day = "wrong entry!"; break;
            }
            return day;
        }

    }
}
