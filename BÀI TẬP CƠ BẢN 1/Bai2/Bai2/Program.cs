using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_229;
            bool isSuccess_229;
            Console.Write("Nhap vao mot so nguyen(0-9) : ");
            string str_229 = Console.ReadLine();
            isSuccess_229 = int.TryParse(str_229, out n_229);
            if (isSuccess_229)
            {
                if (n_229 == 0)
                    Console.WriteLine("khong");
                else if (n_229 == 1)
                    Console.WriteLine("mot");
                else if (n_229 == 2)
                    Console.WriteLine("hai");
                else if (n_229 == 3)
                    Console.WriteLine("ba");
                else if (n_229 == 4)
                    Console.WriteLine("bon");
                else if (n_229 == 5)
                    Console.WriteLine("nam");
                else if (n_229 == 6)
                    Console.WriteLine("sau");
                else if (n_229 == 7)
                    Console.WriteLine("bay");
                else if (n_229 == 8)
                    Console.WriteLine("tam");
                else if (n_229 == 9)
                    Console.WriteLine("chin");
                else
                    Console.WriteLine("khong the doc so");
            }
            else
            {
                Console.WriteLine(str_229 + " Khong phai so nguyen!");
            }
            
            Console.ReadLine();
        }
    }
}
