using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class ManagerStudent
    {
        List<Students> students;

        public ManagerStudent()
        {
            this.students = new List<Students>();
        }

        public void addStudent(Students student)
        {
            try
            {
                this.students.Add(student);
                Console.WriteLine("Thêm thành công!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Thêm thất bại!");
            }
        }

        public void delStudent(string id)
        {
            try
            {
                this.students.RemoveAt(this.students.FindIndex(x => x.Id.Equals(id)));
                Console.WriteLine("Xoá thành công!");
                showInfo();
            }
            catch (Exception e)
            {
                Console.WriteLine("Xoá thất bại!");
            }

        }

        public void showInfo()
        {
            Console.WriteLine("Danh sách thí sinh:");
            this.students.ForEach(x => x.showInfo());
        }
    }
}
