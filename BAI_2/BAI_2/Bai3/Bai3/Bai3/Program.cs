using System;

namespace Bai3
{
    class Program
    {
        static void swap(ref int a_229, ref int b_229 ,ref int t_229)
        {
            t_229 = a_229;
            a_229 = b_229;
            b_229 = t_229;
        }
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào ba số nguyên.
            //Hãy in ba số này ra màn hình theo thứ tự tăng dần và chỉ dùng tối đa một biến phụ

            int a_229 = int.Parse(Console.ReadLine());
            int b_229 = int.Parse(Console.ReadLine());
            int c_229 = int.Parse(Console.ReadLine());
            int t_229 = 0;

            if (a_229 > b_229) {
                swap(ref a_229, ref b_229, ref t_229);
            }

            if (a_229 > c_229) {
                swap(ref a_229, ref c_229, ref t_229);
            }

            if (b_229 > c_229) {
                swap(ref b_229, ref c_229, ref t_229);
            }

            Console.Write("{0}, {1}, {2}", a_229, b_229, c_229);
            Console.ReadKey();
        }
    }
}
