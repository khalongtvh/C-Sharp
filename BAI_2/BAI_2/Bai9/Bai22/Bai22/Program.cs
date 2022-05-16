using System;

namespace Bai22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình liệt kê, đếm và tính tổng các ước số của số nguyên dương n
            Console.Write("Nhap so nguyen duong n : ");
            int n_229 = int.Parse(Console.ReadLine());
            int count_229 = 0, sum_229 = 0 ;
            Console.Write("Uoc : ");
            for (int i_229 = 1; i_229 <= n_229; i_229++)
            {
                if(n_229 % i_229 == 0)
                {
                    Console.Write(i_229 + " ");
                    count_229++;
                    sum_229 += i_229;
                }
            }
            Console.WriteLine("\nSo uoc : {0} \nTong uoc : {1}", count_229, sum_229);
        }
    }
}
