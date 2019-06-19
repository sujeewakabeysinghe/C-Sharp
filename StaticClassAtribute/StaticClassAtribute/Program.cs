using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAtribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("sujeewa",240);
            Book book2 = new Book("hiruni", 180);
            Console.WriteLine(book2.getBookCount());
            Book book3 = new Book("praharsha", 3240);
            Console.WriteLine(Book.bookCount); // in the Book class, static block tell about the class not specific object
            Console.WriteLine(book3.name);

            //Tool tool1 = new Tool(); --> if class also static we cannot create this object
            Tool.hello("sujeewa"); // without creating object[instance] we can access this like Math.sqrt(25)

            Console.ReadLine();
        }
    }
}
