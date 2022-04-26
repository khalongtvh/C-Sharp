using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication4
{
    class Ptb2
    {
        private double a_229;
        private double b_229;
        private double c_229;

        public Ptb2()
        {
        }

        public Ptb2(double a_229, double b_229, double c_229)
        {
            this.A = a_229;
            this.B = b_229;
            this.C = c_229;
        }

        public double A { get => a_229; set => a_229 = value; }
        public double B { get => b_229; set => b_229 = value; }
        public double C { get => c_229; set => c_229 = value; }

        public void Nhap()
        {
            Console.Write("a = ");
            A = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            B = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            C = double.Parse(Console.ReadLine());
        }
        public double Delta(double a_229, double b_229, double c_229)
        {
            return b_229 * b_229 - 4 * a_229 * c_229;
        }

        public void nghiemPT()
        {
            double x1_229, x2_229;
            double d_229 = Delta(a_229, b_229, c_229);
            if (d_229 == 0)
            {
                Console.Write("Phuong trinh co mot nghiem duy nhat.\n");
                x1_229 = -b_229 / (2.0 * a_229);
                x2_229 = x1_229;
                Console.Write("Nghiem duy nhat cua phuong trinh la = {0}\n", x1_229);
            }
            else if (d_229 > 0)
            {
                Console.Write("Phuong trinh co hai nghiem thuc phan biet\n");

                x1_229 = (-b_229 + Math.Sqrt(d)) / (2.0 * a_229);
                x2_229 = (-b_229 - Math.Sqrt(d)) / (2.0 * a_229);

                Console.Write("Nghiem thu nhat: x1 = {0}\n", x1_229);
                Console.Write("Nghiem thu nhat: x2 = {0}\n", x2_229);
            }
            else
                Console.Write("Phuong trinh vo nghiem (hay khong co nghiem thuc nao)\n\n");
        }
    }
}
