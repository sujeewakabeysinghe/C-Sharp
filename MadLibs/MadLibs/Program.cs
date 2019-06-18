using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;
            Console.Write("enter a color : ");
            color = Console.ReadLine();
            Console.Write("enter a plura noun : ");
            pluralNoun = Console.ReadLine();
            Console.Write("enter a celebrity : ");
            celebrity = Console.ReadLine();
            Console.WriteLine("roses are "+color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("i love "+celebrity);

            Console.ReadLine();
        }
    }
}
