using System;

namespace Bai31
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình in bảng cửu chương từ 2 đến 9 ra màn hình
            for (int i_229 = 1; i_229 <= 10; ++i_229)
            {
                for (int j_229 = 2; j_229 <= 9; ++j_229)
                    Console.Write("|{0}x{1}={2}", j_229, i_229, i_229 * j_229);
                Console.WriteLine();
            }
        }
    }
}
