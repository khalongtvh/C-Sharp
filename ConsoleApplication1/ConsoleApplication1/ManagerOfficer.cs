using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ManagerOfficer
    {
        private List<Officer> officers;
        public ManagerOfficer()
        {
            this.officers = new List<Officer>();
        }
        public void addOfficer(Officer officer)
        {
            this.officers.Add(officer);
        }
        public void searchOfficerByName(String name)
        {
            foreach (var officer in officers)
            {
                if (officer.Name.Equals(name))
                {
                    Console.WriteLine(officer);
                }
            }
        }
        public void showListInforOfficer()
        {
            foreach (var officer in officers)
            {
                Console.WriteLine(officer);
                Console.WriteLine("====================================");
            }
        }
    }
}
