using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAtribute
{
    static class Tool //now we cannot create object of this class cause this is static
    {
        public static void hello(string name) //without creating object[instance] we can access this like Math.sqrt(25)
        {
            Console.WriteLine("hello "+name);
        }
    }
}
