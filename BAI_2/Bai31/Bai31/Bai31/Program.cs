using System;

namespace Bai31
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình in bảng cửu chương từ 2 đến 9 ra màn hình
            for (int i = 1; i <= 10; ++i)
            {
                for (int j = 2; j <= 9; ++j)
                    Console.Write("|{0}x{1}={2}", j, i, i * j);
                Console.WriteLine();
            }
        }
    }
}
