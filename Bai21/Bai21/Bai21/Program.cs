using System;

namespace Bai21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap diem chuan ");
            float dc = float.Parse(Console.ReadLine());

            Console.Write("Nhap diem mon 1 ");
            float d1 = float.Parse(Console.ReadLine());

            Console.Write("Nhap diem mon 2 ");
            float d2 = float.Parse(Console.ReadLine());

            Console.Write("Nhap diem mon 3 ");
            float d3 = float.Parse(Console.ReadLine());

            Console.Write("Nhap khu vuc (A,B,C,X) ");
            string kv = Console.ReadLine().ToUpper();
            
            Console.Write("Nhap doi tuong (1, 2, 3, 0):");
            int dt = int.Parse(Console.ReadLine());

            float d = d1 + d2 + d3;
            switch (kv)
            {
                case "A":
                    d += 2;
                    break;
                case "B":
                    d += 1;
                    break;
                case "C":
                    d += 0.5f;
                    break;
            }
            switch (dt)
            {
                case 1:
                    d += 2.5f;
                    break;
                case 2:
                    d += 1.5f;
                    break;
                case 3: d += 1;
                    break;
            }
            Console.WriteLine("{0} diem=>{1}",d, d>=dc ?"dau" :"rot");
        }
    }
}
