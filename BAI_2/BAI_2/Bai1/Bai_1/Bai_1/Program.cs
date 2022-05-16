using System;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhập vào diện tích S của một mặt cầu.Tính thể tích V của hình cầu này
            Console.Write("Nhap dien tich : ");
            Double S_229 = Double.Parse(Console.ReadLine());
            Double pi_229 = 3.141593;
            Double R_229 = Math.Sqrt(S_229 / (4 * pi_229));
            Double V_229 = (S_229 * R_229) / 3;
            Console.WriteLine("The tich : " +  V_229);
            Console.ReadKey();
        }
    }
}
