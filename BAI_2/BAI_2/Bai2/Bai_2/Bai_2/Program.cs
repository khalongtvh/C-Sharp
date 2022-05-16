using System;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhập vào tọa độ 2 điểm A(xA, yA) và B(xB, yB). Tính khoảng cách AB.
            Console.Write("xA = ");
            Double xA_229 = Double.Parse(Console.ReadLine());
            Console.Write("yA = ");
            Double yA_229 = Double.Parse(Console.ReadLine());
            Console.Write("xB = ");
            Double xB_229 = Double.Parse(Console.ReadLine());
            Console.Write("yB = ");
            Double yB_229 = Double.Parse(Console.ReadLine());

            Double x2_229 = Math.Pow((xA_229 - xB_229), 2);
            Double y2_229 = Math.Pow((yA_229 - yB_229), 2);
            Double d_229 = Math.Sqrt(x2_229 + y2_229);
            Console.Write("Khoan Cach AB : " + d_229);
            Console.ReadKey();
        }
    }
}
