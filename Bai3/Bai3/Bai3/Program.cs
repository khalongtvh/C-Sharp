using System;

namespace Bai3
{
    class Program
    {
        static void swap(ref int a, ref int b, ref int t)
        {
            t = a; 
            a = b; 
            b = t;
        }
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào ba số nguyên.
            //Hãy in ba số này ra màn hình theo thứ tự tăng dần và chỉ dùng tối đa một biến phụ

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int t = 0;

            if (a > b) {
                swap(ref a, ref b, ref t);
            }

            if (a > c) {
                swap(ref a, ref c, ref t);
            }

            if (b > c) {
                swap(ref b, ref c, ref t);
            }

            Console.Write("{0}, {1}, {2}",a,b,c);
            Console.ReadKey();
        }
    }
}
