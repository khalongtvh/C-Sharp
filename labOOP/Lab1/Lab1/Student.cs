using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Student
    {
        private int SID;
        private string tenSV;
        private string Khoa;
        private string diemTB;

        public Student()
        {
        }

        public Student(int sID, string tenSV, string khoa, string diemTB)
        {
            SID = sID;
            this.tenSV = tenSV;
            Khoa = khoa;
            this.diemTB = diemTB;
        }

        public virtual void Show()
        {
            Console.WriteLine($"MSSV : {this.SID}");
            Console.WriteLine($"ten SV : {this.tenSV}");
            Console.WriteLine($"Khoa : {this.Khoa}");
            Console.WriteLine($"Diem trung binh : {this.diemTB}");

        }

        public int ID { get => SID; set => SID = value; }
        public string TenSV { get => tenSV; set => tenSV = value; }
        public string khoa { get => Khoa; set => Khoa = value; }
        public string DiemTB { get => diemTB; set => diemTB = value; }
    }
}
