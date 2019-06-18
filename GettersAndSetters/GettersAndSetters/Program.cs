using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("lion", 2);
            Movie movie2 = new Movie("princess", 3);
            //movie1.Rate = 10;  setting the value
            Console.WriteLine(movie1.title);
            Console.WriteLine(movie1.Rate);

            Console.ReadLine();
        }
    }
}
