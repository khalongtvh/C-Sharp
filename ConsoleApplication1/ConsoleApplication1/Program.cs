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
            while_1:
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Application Manager Officer!");
                Console.WriteLine("Enter 1: To insert officer!");
                Console.WriteLine("Enter 2: To search officer by name!");
                Console.WriteLine("Enter 3: To show information officers!");
                Console.WriteLine("Enter 4: To exit!");
                Console.Write("Enter your choose : ");

                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter 1: to insert Enginner!");
                            Console.WriteLine("Enter 2: to insert Worker!");
                            Console.WriteLine("Enter 3: to insert Staff!");
                            Console.WriteLine("Enter 0: Back!");
                            Console.Write("Enter your choose : ");
                            string type = Console.ReadLine();
                            switch (type)
                            {
                                case "1":
                                    Console.Write("Enter name: ");
                                    string nameEnginner = Console.ReadLine();

                                    Console.Write("Enter age: ");
                                    int ageEnginner = int.Parse(Console.ReadLine());

                                    Console.Write("Enter gender: ");
                                    string genderEnginner = Console.ReadLine();

                                    Console.Write("Enter address: ");
                                    string addressEnginner = Console.ReadLine();

                                    Console.Write("Enter branch: ");
                                    string branchEnginner = Console.ReadLine();

                                    manager.addOfficer(new Engineer(nameEnginner, ageEnginner, genderEnginner, addressEnginner, branchEnginner));
                                    break;

                                case "2":
                                    Console.Write("Enter name: ");
                                    string nameWorker = Console.ReadLine();

                                    Console.Write("Enter age: ");
                                    int ageWorker = int.Parse(Console.ReadLine());

                                    Console.Write("Enter gender: ");
                                    string genderWorker = Console.ReadLine();

                                    Console.Write("Enter address: ");
                                    string addressWorker = Console.ReadLine();

                                    Console.Write("Enter level: ");
                                    int levelWorker = int.Parse(Console.ReadLine());

                                    manager.addOfficer(new Worker(nameWorker, ageWorker, genderWorker, addressWorker, levelWorker));
                                    manager.showListInforOfficer();
                                    break;

                                case "3":
                                    Console.Write("Enter name: ");
                                    string nameStaff = Console.ReadLine();

                                    Console.Write("Enter age: ");
                                    int ageStaff = int.Parse(Console.ReadLine());

                                    Console.Write("Enter gender: ");
                                    string genderStaff = Console.ReadLine();

                                    Console.Write("Enter address: ");
                                    string addressStaff = Console.ReadLine();

                                    Console.Write("Enter task: ");
                                    string taskStaff = Console.ReadLine();

                                    manager.addOfficer(new Staff(nameStaff, ageStaff, genderStaff, addressStaff, taskStaff));
                                    break;

                                case "0":
                                    goto while_1;

                                default:
                                    Console.Write("Invalid");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                    case "2":
                        Console.Write("Enter your to search: ");
                        string name_search = Console.ReadLine();
                        manager.searchOfficerByName(name_search);
                        break;

                    case "3":
                        manager.showListInforOfficer();
                        break;

                    case "4":
                        Console.Write("Exit!");
                        return;

                    default:
                        Console.Write("Invalid!");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
