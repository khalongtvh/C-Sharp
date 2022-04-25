using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class StudentsA : Students
    {
        public static string MON_TOAN = "Toán";
        public static string MON_LY = "Lý";
        public static string MON_HOA = "Hoá";

        public StudentsA() { }

        public StudentsA(string id, string name, string address, string priority) : base(id, name, address, priority)
        {

        }
        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine($"\tKhối thi A - Môn thi: {MON_TOAN}, {MON_LY}, {MON_HOA}");
            Console.WriteLine("===============================================");
        }
    }
}
