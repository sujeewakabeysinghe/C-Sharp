using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.author = "sujeewa";
            book1.title = "lion";
            book1.pages = 200;

            Book book2 = new Book();
            book2.author = "hiru";
            book2.title = "princess";
            book2.pages = 275;

            Console.WriteLine(book1.author+"\n"+book1.title+"\n");
            Console.WriteLine(book2.author + "\n" + book2.title+"\n");

            Bottle bottle1 = new Bottle();
            bottle1.size = 10;
            bottle1.name = "cocacola";
            Console.WriteLine("\n"+bottle1.name + "\n" + bottle1.size);

            Console.ReadLine();
        }
    }
    class Bottle
    {
        public int size;
        public string name;
    }
}
