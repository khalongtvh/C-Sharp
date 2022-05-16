using System;

namespace Bai21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap diem chuan ");
            float dc_229 = float.Parse(Console.ReadLine());

            Console.Write("Nhap diem mon 1 ");
            float d1_229 = float.Parse(Console.ReadLine());

            Console.Write("Nhap diem mon 2 ");
            float d2_229 = float.Parse(Console.ReadLine());

            Console.Write("Nhap diem mon 3 ");
            float d3_229 = float.Parse(Console.ReadLine());

            Console.Write("Nhap khu vuc (A,B,C,X) ");
            string kv_229 = Console.ReadLine().ToUpper();
            
            Console.Write("Nhap doi tuong (1, 2, 3, 0):");
            int dt_229 = int.Parse(Console.ReadLine());

            float d_229 = d1_229 + d2_229 + d3_229;
            switch (kv_229)
            {
                case "A":
                    d_229 += 2;
                    break;
                case "B":
                    d_229 += 1;
                    break;
                case "C":
                    d_229 += 0.5f;
                    break;
            }
            switch (dt_229)
            {
                case 1:
                    d_229 += 2.5f;
                    break;
                case 2:
                    d_229 += 1.5f;
                    break;
                case 3:
                    d_229 += 1;
                    break;
            }
            Console.WriteLine("{0} diem=>{1}", d_229, d_229 >= dc_229 ? "dau" :"rot");
        }
    }
}
