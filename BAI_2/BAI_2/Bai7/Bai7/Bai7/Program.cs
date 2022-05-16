using System;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào số giờ,
            //xuất ra số tương đương tính theo tuần, theo ngày và theo giờ
            Console.Write("Nhap so gio ");
            int hour_229 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} TUAN {1} NGAY {2} GIO", hour_229 / (24 * 7), (hour_229 % (24 * 7)) / 24, (hour_229 % (24 * 7)) % 24);
        }
    }
}
