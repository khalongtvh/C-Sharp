using System;

namespace Bai22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình liệt kê, đếm và tính tổng các ước số của số nguyên dương n
            Console.Write("Nhap so nguyen duong n : ");
            int n = int.Parse(Console.ReadLine());
            int count = 0, sum = 0 ;
            Console.Write("Uoc : ");
            for (int i = 1; i<=n; i++)
            {
                if(n % i == 0)
                {
                    Console.Write(i+" ");
                    count++;
                    sum += i;
                }
            }
            Console.WriteLine("\nSo uoc : {0} \nTong uoc : {1}",count, sum);
        }
    }
}
