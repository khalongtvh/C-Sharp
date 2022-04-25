using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class StudentsB : Students
    {
        public static string MON_TOAN = "Toán";
        public static string MON_SINH = "Sinh";
        public static string MON_HOA = "Hóa";

        public StudentsB()
        {
        }

        public StudentsB(string id, string name, string address, string priority) : base(id, name, address, priority)
        {}

        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine($"\tKhối thi B - Môn thi: {MON_TOAN}, {MON_HOA}, {MON_SINH}");
            Console.WriteLine("===============================================");

        }
    }
}
