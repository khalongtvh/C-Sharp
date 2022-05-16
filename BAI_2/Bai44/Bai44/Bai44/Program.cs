using System;

namespace Bai44
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dùng vòng lặp lồng, viết chương trình in ra tam giác cân đặc và rỗng, tạo từ các dấu sao(*),
            //có độ cao là n nhập từ bàn phím
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write("   ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write(" * ");
                Console.WriteLine();
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < 2 * n; j++)
                {
                    if (Math.Abs(n - j) == i - 1 || i == n)
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
