using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class SportCar : Car //now this has inherited from car class
    {
        public void onTurbo()
        {
            Console.WriteLine("turbo on.");
        }
         
        public override void carStop() //hence override this class we want to use override key word
        {
            Console.WriteLine("slow down and car stopped.");
        }
    }
}
