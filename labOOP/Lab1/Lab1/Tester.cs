using System;

namespace Lab1
{
    class Tester
    {
        static void Main(string[] args)
        {
            Student[] DSSV;
            int n;
            Console.Write("so luong sinh vien : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("==============Nhap Danh Sach Sinh Vien==============");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new Student();

            }
        }
    }
}
