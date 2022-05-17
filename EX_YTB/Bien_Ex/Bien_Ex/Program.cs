using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bien_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //viết chương trình nhập vào 2 số a và b sau đó in ra tổng, hiệu, tích, thương của 2 số đó
            Double a = double.Parse(Console.ReadLine());
            Double b = double.Parse(Console.ReadLine());

            Console.WriteLine("tong {0} + {1} = {2}",a,b, a + b);
            Console.ReadKey();
        }
    }
}
