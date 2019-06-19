using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Car
    {
        public void carStart()
        {
            Console.WriteLine("car started.");
        }
        public virtual void carStop() //if you want to overide this method anywhere, use virtual key word
        {
            Console.WriteLine("car stopped.");
        }
    }
}
