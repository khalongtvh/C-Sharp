using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            ManagerDocument doc = new ManagerDocument();
            Newspaper book = new Newspaper("1", "1", 1, "1");
            Newspaper book1 = new Newspaper("2", "1", 1, "1");
            Newspaper book2 = new Newspaper("3", "1", 1, "1");
            Newspaper book3 = new Newspaper("4", "1", 1, "1");

            doc.addDoc(book);
            doc.addDoc(book1);
            doc.addDoc(book2);
            doc.addDoc(book3);

            //doc.searchBook("1");
            doc.showDocument();

            Console.ReadKey();
        }
    }
}
