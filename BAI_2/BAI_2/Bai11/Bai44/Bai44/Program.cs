using System;

namespace Bai44
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dùng vòng lặp lồng, viết chương trình in ra tam giác cân đặc và rỗng, tạo từ các dấu sao(*),
            //có độ cao là n nhập từ bàn phím
            int n_229 = int.Parse(Console.ReadLine());
            for (int i_229 = 0; i_229 < n_229; i_229++)
            {
                for (int j_229 = 1; j_229 <= n_229 - i_229; j_229++)
                    Console.Write("   ");
                for (int j_229 = 1; j_229 <= 2 * i_229 - 1; j_229++)
                    Console.Write(" * ");
                Console.WriteLine();
            }

            for (int i_229 = 1; i_229 <= n_229; i_229++)
            {
                for (int j_229 = 1; j_229 < 2 * n_229; j_229++)
                {
                    if (Math.Abs(n_229 - j_229) == i_229 - 1 || i_229 == n_229)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
