using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class StudentsB : Students
    {
        public static string MON_TOAN = "Toan";
        public static string MON_SINH = "Sinh";
        public static string MON_HOA = "Hoa";
        public StudentsB(string id, string name, string address, string priority) : base(id, name, address, priority)
        {

        }
        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine($"Toán: {MON_TOAN}");
            Console.WriteLine($"Hoá: {MON_HOA}");
            Console.WriteLine($"Sinh: {MON_SINH}");
        }
    }
}
