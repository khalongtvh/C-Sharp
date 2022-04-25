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

            while (true)
            {
                Console.Clear();
                Console.WriteLine("====================Quản lý tuyển sinh====================");
                Console.WriteLine("1. Thêm mới thí sinh.");
                Console.WriteLine("2. Hiển thị thông tin của thí sinh và khối thi của thí sinh.");
                Console.WriteLine("3. Tìm kiếm theo số báo danh.");
                Console.WriteLine("0. Thoát khỏi chương trình.");
                Console.Write("Công việc cần thực hiện: ");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        addStudent(manager);
                        break;

                    case "2":
                        manager.showInfo();
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("====================Tìm kiếm theo số báo danh====================");
                        Console.Write("Nhập số báo danh cần tìm: ");
                        string id = Console.ReadLine();
                        manager.searchById(id);
                        Console.ReadKey();
                        break;

                    case "0":
                        return;
                }
            }
        }

        private static void addStudent(ManagerStudent manager)
        {
            while (true)
            {
                Console.WriteLine("====================Thêm mới thí sinh====================");
                Console.WriteLine("1. Thí sinh khối A");
                Console.WriteLine("2. Thí sinh khối B");
                Console.WriteLine("3. Thí sinh khối C");
                Console.WriteLine("0. Quay lại");
                Console.Write("Công việc cần thực hiện: ");

                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        StudentsA studentA = new StudentsA();
                        studentA.inpInfo();
                        manager.addStudent(studentA);
                        break;

                    case "2":
                        StudentsB StudentsB = new StudentsB();
                        StudentsB.inpInfo();
                        manager.addStudent(StudentsB);
                        break;

                    case "3":
                        StudentsC StudentsC = new StudentsC();
                        StudentsC.inpInfo();
                        manager.addStudent(StudentsC);
                        break;

                    case "0":
                        return;
                }
            }
        }
    }
}
