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
            int day_229 = int.Parse(Console.ReadLine());
            Console.Write("thang : ");
            int month_229 = int.Parse(Console.ReadLine());
            Console.Write("nam : ");
            int year_229 = int.Parse(Console.ReadLine());

            int s_229 = day_229;
            for (int i_229 = 1; i_229 < month_229; ++i_229)
                switch (i_229)
                {
                    case 4: case 6: case 9: case 11: s_229 += 30;
                        break;
                    case 2:
                        s_229 += 28 + ((year_229 % 4 == 0 && year_229 % 100 == 0) || year_229 % 400 == 0 ? 1 : 0);
                        break;
                    default:
                        s_229 += 31;
                        break;
                }
            Console.WriteLine(s_229);
            Console.ReadKey();
        }
    }
}
