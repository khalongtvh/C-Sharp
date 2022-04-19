using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Staff : Officer
    {
        private String task;

        public Staff()
        {
        }
        public Staff(string name, int age, string gender, string address, String task) : base(name, age, gender, address)
        {
            this.task = task;
        }

        public override string ToString()
        {
            return Name + "\n" + Age + "\n" + Gender + "\n" + Address + "\n" + Task;
        }
        public string Task
        {
            get
            {
                return task;
            }

            set
            {
                task = value;
            }
        }
    }
}
