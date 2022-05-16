using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a_229, b_229, c_229;
            Console.WriteLine("Nhap 3 so thuc : ");
            a_229 = Double.Parse(Console.ReadLine());
            b_229 = Double.Parse(Console.ReadLine());
            c_229 = Double.Parse(Console.ReadLine());

            if (a_229 * a_229 + b_229 * b_229 == c_229 * c_229 || b_229 * b_229 + c_229 * c_229 == a_229 * a_229 || c_229 * c_229 + a_229 * a_229 == b_229 * b_229)
                Console.WriteLine("{0}, {1}, {2} la 3 canh cua tam giac vuong", a_229, b_229, c_229);
            else
                Console.WriteLine("{0}, {1}, {2} khong phai la 3 canh cua tam giac vuong", a_229, b_229, c_229);

            Console.ReadLine();
        }
    }
}
