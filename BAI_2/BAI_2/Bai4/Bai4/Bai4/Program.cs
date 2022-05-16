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
            Double xC_229 = double.Parse(Console.ReadLine());
            Console.Write("yC ");
            Double yC_229 = double.Parse(Console.ReadLine());
            Console.Write("R ");
            Double R_229 = double.Parse(Console.ReadLine());
            Console.Write("xM ");
            Double xM_229 = double.Parse(Console.ReadLine());
            Console.Write("yM ");
            Double yM_229 = double.Parse(Console.ReadLine());

            Double d_229 = R_229 - Math.Sqrt((xM_229 - xC_229) * (xM_229 - xC_229) + (yM_229 - yC_229) * (yM_229 - yC_229));
            if (d_229 > 0)
            {
                Console.WriteLine("M nam trong C()\n");
            } 
            else if (d_229 < 0)
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
