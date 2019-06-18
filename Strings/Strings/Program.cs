using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "my name is " + "Sujeewa";

            Console.WriteLine("my name is sujeewa abeysinghe.\nmy school is kingswood college, kandy.");
            Console.WriteLine("the book \"gamperaliya\".");
            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("sujeewa")); //to know whether it is included or not
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("Sujee")); //to see the position of this and if it is not there it shows -1
            Console.WriteLine(phrase.Substring(11)); //to get the fragment of string
            Console.WriteLine(phrase.Substring(11, 5));


            Console.ReadLine();
        }
    }
}