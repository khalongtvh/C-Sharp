using System;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhập vào diện tích S của một mặt cầu.Tính thể tích V của hình cầu này
            Console.Write("Nhap dien tich : ");
            Double S = Double.Parse(Console.ReadLine());
            Double pi = 3.141593;
            Double R = Math.Sqrt(S / (4 * pi));
            Double V = (S * R) / 3;
            Console.WriteLine("The tich : " +  V);
            Console.ReadKey();
        }
    }
}
