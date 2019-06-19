using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAtribute
{
    class Book
    {
        public string name;
        public int pages;
        public static int bookCount = 0; // in the Book class, static block tell about the class not specific object

        public Book(string Oname, int Opages)
        {
            name = Oname;
            pages = Opages;
            bookCount++;
        }

        public int getBookCount() //using this method we can access through our specific object
        {
            return bookCount;
        }
    }
}
