using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("sujeewa",3.6);
            Student student2 = new Student("hiruni", 3.9);
            Console.WriteLine(student1.name + " " + student1.hasFirstClass());
            Console.WriteLine(student2.name + " " + student2.hasFirstClass());

            Console.ReadLine();
        }
    }
}
