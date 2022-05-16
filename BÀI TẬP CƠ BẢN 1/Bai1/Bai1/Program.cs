using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_229;
            bool isSuccess_229;
            Console.Write("Nhap so nguyen duong : ");
            string str_229 = Console.ReadLine();
            isSuccess_229 = int.TryParse(str_229, out n_229);
            if (isSuccess_229)
            {
                if(n_229 >= 0)
                {
                    Console.WriteLine("Day la so nguyen duong!");
                }
                else
                {
                    Console.WriteLine("Day la so nguyen am!");
                }
            }
            else
            {
                Console.WriteLine(str_229 + " Khong phai so nguyen");
            }

            Console.ReadKey();
        }

    }
}