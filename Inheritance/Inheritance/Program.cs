using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(); //super class
            car1.carStart();
            car1.carStop();

            SportCar sportCar1 = new SportCar(); //sub class  
            sportCar1.onTurbo();
            sportCar1.carStop(); //overrided method

            Console.ReadLine();
        }
    }
}
