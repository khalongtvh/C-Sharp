using System;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình giải hệ phương trình 2 ẩn:
            Console.WriteLine("a1 : ");
            float a1_229 = float.Parse(Console.ReadLine());
            Console.WriteLine("b1 : ");
            float b1_229 = float.Parse(Console.ReadLine());
            Console.WriteLine("c1 : ");
            float c1_229 = float.Parse(Console.ReadLine());
            Console.WriteLine("a2 : ");
            float a2_229 = float.Parse(Console.ReadLine());
            Console.WriteLine("b2 : ");
            float b2_229 = float.Parse(Console.ReadLine());
            Console.WriteLine("c2 : ");
            float c2_229 = float.Parse(Console.ReadLine());

            float d_229 = (a1_229 * b2_229 - a2_229 * b1_229);
            float dx_229 = (c1_229 * b2_229 - c2_229 * b1_229);
            float dy_229 = (a1_229 * c2_229 - a2_229 * c1_229);
            if (d_229 == 0)
            {
                Console.WriteLine((dx_229 + dy_229 == 0) ? "He phuong trinh co vo so nghiem" : "He phuong trinh vo nghiem\n");
            }
            else
            {
                float x_229 = dx_229 / d_229;
                float y_229 = dy_229 / d_229;
                Console.WriteLine("x = {0}, y = {1}", x_229, y_229);    
            }

        }
    }
}
