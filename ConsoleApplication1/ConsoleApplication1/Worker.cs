using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Worker : Officer
    {
        private int level;
        public Worker()
        {
        }

        public Worker(string name, int age, string gender, string address, int level) : base(name, age, gender, address)
        {
            this.Level = level;
        }

        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }

        public override string ToString()
        {
            return Name + "\n" + Age + "\n" + Gender + "\n" + Address + "\n" + Level;
        }
    }
}
