using System;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào ngày, tháng, năm (giả sử nhập đúng, không cần kiểm tra hợp lệ).
            //Tìm xem ngày đó là ngày thứ bao nhiêu trong năm.
            Console.Write("ngay : ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("thang : ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("nam : ");
            int year = int.Parse(Console.ReadLine());

            int s = day;
            for (int i = 1; i < month; ++i)
                switch (i)
                {
                    case 4: case 6: case 9: case 11: s += 30;
                        break;
                    case 2: s += 28 + ((year % 4 == 0 && year % 100 == 0) || year % 400 == 0 ? 1 : 0);
                        break;
                    default: s += 31;
                        break;
                }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
