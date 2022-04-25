using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class StudentsC : Students
    {
        public string MON_VAN = "Văn";
        public string MON_SU = "Sử";
        public string MON_DIA = "Địa";

        public StudentsC()
        {
        }

        public StudentsC(string id, string name, string address, string priority) : base(id, name, address, priority)
        {
        }

        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine($"\tKhối thi A - Môn thi: {MON_VAN}, {MON_SU}, {MON_DIA}");
            Console.WriteLine("===============================================");
        }
    }
}
