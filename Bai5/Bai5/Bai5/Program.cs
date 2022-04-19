using System;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình giải hệ phương trình 2 ẩn:
            Console.WriteLine("a1 : ");
            float a1 = float.Parse(Console.ReadLine());
            Console.WriteLine("b1 : ");
            float b1 = float.Parse(Console.ReadLine());
            Console.WriteLine("c1 : ");
            float c1 = float.Parse(Console.ReadLine());
            Console.WriteLine("a2 : ");
            float a2 = float.Parse(Console.ReadLine());
            Console.WriteLine("b2 : ");
            float b2 = float.Parse(Console.ReadLine());
            Console.WriteLine("c2 : ");
            float c2 = float.Parse(Console.ReadLine());

            float d = (a1 * b2 - a2 * b1);
            float dx = (c1 * b2 - c2 * b1);
            float dy = (a1 * c2 - a2 * c1);
            if (d == 0)
            {
                Console.WriteLine((dx + dy == 0) ? "He phuong trinh co vo so nghiem" : "He phuong trinh vo nghiem\n");
            }
            else
            {
                float x = dx / d;
                float y = dy / d;
                Console.WriteLine("x = {0}, y = {1}", x, y);    
            }

        }
    }
}
