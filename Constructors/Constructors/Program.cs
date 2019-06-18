using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book("sujeewa");
            Book book3 = new Book("princess", "hiruni", 275);
            Console.WriteLine(book3.title+"\t"+book3.author);

            Console.ReadLine();
        }
    }
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book()
        {
            Console.WriteLine("constructor1");
        }
        public Book(string name)
        {
            Console.WriteLine("constructor2 "+name);
        }
        public Book(string Otitle, string Oauthor, int Opage)
        {
            title = Otitle;
            author = Oauthor;
            pages = Opage;
        }
    }
}
