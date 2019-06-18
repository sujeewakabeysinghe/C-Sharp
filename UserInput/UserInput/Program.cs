using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("what is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("hello "+name);

            Console.ReadLine();
        }
    }
}
