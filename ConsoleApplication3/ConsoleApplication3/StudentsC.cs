using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class StudentsC : Students
    {
        public static string MON_VAN = "Van";
        public static string MON_SU = "Su";
        public static string MON_DIA = "Dia";

        public StudentsC(string id, string name, string address, string priority) : base(id, name, address, priority)
        {

        }

        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine($"Văn: {MON_VAN}");
            Console.WriteLine($"Sử: {MON_SU}");
            Console.WriteLine($"Địa: {MON_DIA}");
        }
    }
}
