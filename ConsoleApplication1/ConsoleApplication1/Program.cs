using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            ManagerOfficer manager = new ManagerOfficer();
            while (true)
            {
                Console.WriteLine("Application Manager Officer");
                Console.WriteLine("Enter 1: To insert officer.");
                Console.WriteLine("Enter 2: To search officer by name.");
                Console.WriteLine("Enter 3: To show information officers.");
                Console.WriteLine("Enter 4: To exit.");
                Console.Write("Enter your choose : ");


                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter a: to insert Enginner");
                        Console.WriteLine("Enter b: to insert Worker");
                        Console.WriteLine("Enter c: to insert Staff");
                        Console.Write("Enter your choose : ");

                        string chooseInsert = Console.ReadLine();
                        switch (chooseInsert)
                        {
                            case "a":
                                Console.Write("Enter name: ");
                                string name = Console.ReadLine();

                                Console.Write("Enter age: ");
                                int age = int.Parse(Console.ReadLine());

                                Console.Write("Enter gender: ");
                                string gender = Console.ReadLine();

                                Console.Write("Enter address: ");
                                string address = Console.ReadLine();

                                Console.Write("Enter branch: ");
                                string branch = Console.ReadLine();

                                manager.addOfficer(new Engineer(name, 15, gender, address, branch));
                                manager.showListInforOfficer();
                                break;
                        }
                        break;
                }
            }
            
        }
    }
}
