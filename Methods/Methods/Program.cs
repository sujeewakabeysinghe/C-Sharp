using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            methodOne();
            methodTwo("sujeewa");
            methodThree("hiruni",24);

            Console.ReadLine();
        }

        static void methodOne()
        {
            Console.WriteLine("hi!");
        }

        static void methodTwo(string name)
        {
            Console.WriteLine("hi! "+name);
        }

        static void methodThree(string name, int age)
        {
            Console.WriteLine("hi! "+name+", you are "+age);
        }

    }
}
