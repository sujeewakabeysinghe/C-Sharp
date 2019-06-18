using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine(5 + 6);
            Console.WriteLine(5 - 6);
            Console.WriteLine(5 * 6);
            Console.WriteLine(13 / 6);
            Console.WriteLine(6 % 5);
            Console.WriteLine(4 + 2 * 3);
            Console.WriteLine(5 / 2);
            Console.WriteLine(5.0 / 2);
            Console.WriteLine(5 / 2.0);
            Console.WriteLine(num);
            num++;
            Console.WriteLine(num);
            Console.WriteLine(Math.Abs(-50));
            Console.WriteLine(Math.Pow(2,3));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(20, 19));
            Console.WriteLine(Math.Round(20.56,1));
            
            Console.ReadLine();
        }
    }
}
