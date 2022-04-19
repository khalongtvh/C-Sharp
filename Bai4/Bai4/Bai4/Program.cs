using System;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào tọa độ (xC, yC) là tâm của một đường tròn, và R
            //là bán kính của đường tròn đó.Nhập vào tọa độ(xM, yM) của điểm M.
            //Xác định điểm M nằm trong, trên hay nằm ngoài đường tròn.
            Console.Write("xC ");
            Double xC = double.Parse(Console.ReadLine());
            Console.Write("yC ");
            Double yC = double.Parse(Console.ReadLine());
            Console.Write("R ");
            Double R = double.Parse(Console.ReadLine());
            Console.Write("xM ");
            Double xM = double.Parse(Console.ReadLine());
            Console.Write("yM ");
            Double yM= double.Parse(Console.ReadLine());

            Double d = R - Math.Sqrt((xM - xC) * (xM - xC) + (yM - yC) * (yM - yC));
            if (d > 0)
            {
                Console.WriteLine("M nam trong C()\n");
            } 
            else if (d < 0)
            {
                Console.WriteLine("M nam ngoai C()\n");
            }
            else
            {
                Console.WriteLine("M nam tren C()\n");
            }
                

        }
    }
}
