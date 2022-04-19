using System;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhập vào tọa độ 2 điểm A(xA, yA) và B(xB, yB). Tính khoảng cách AB.
            Console.Write("xA = ");
            Double xA = Double.Parse(Console.ReadLine());
            Console.Write("yA = ");
            Double yA = Double.Parse(Console.ReadLine());
            Console.Write("xB = ");
            Double xB = Double.Parse(Console.ReadLine());
            Console.Write("yB = ");
            Double yB = Double.Parse(Console.ReadLine());

            Double x2 = Math.Pow((xA - xB), 2);
            Double y2 = Math.Pow((yA - yB), 2);
            Double d = Math.Sqrt(x2 + y2);
            Console.Write("Khoan Cach AB : " + d);
            Console.ReadKey();
        }
    }
}
