using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Students
    {
        private string id;
        private string name;
        private string address;
        private string priority;

        public Students() { }

        public Students(string id, string name, string address, string priority)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.priority = priority;
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Priority
        {
            get
            {
                return priority;
            }

            set
            {
                priority = value;
            }
        }

        public virtual void inpInfo()
        {
            Console.Write("Nhập id: ");
            Id = Console.ReadLine();
            Console.Write("Nhập tên: ");
            Name = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            Address = Console.ReadLine();
            Console.Write("Nhập độ ưu tiên: ");
            Priority = Console.ReadLine();
        }
        public virtual void showInfo()
        {
            Console.WriteLine($"\tId: {Id}");
            Console.WriteLine($"\tTên: {Name}");
            Console.WriteLine($"\tĐịa chỉ: {Address}");
            Console.WriteLine($"\tĐộ ưu tiên: {Priority}");
        }
    }
}
