using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ManagerStudent manager = new ManagerStudent();
            manager.addStudent(new StudentsA("2", "1", "1", "1"));
            manager.addStudent(new StudentsB("1", "1", "1", "1"));
            manager.addStudent(new StudentsC("3", "1", "1", "1"));

            manager.showInfo();

            Console.ReadKey();
        }
    }
}
