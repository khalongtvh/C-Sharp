using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("so luong phan tu : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            inpArr(ref a);

            outArr(a);
            
            Console.Write("phan tu lon nhat : " + maxArr(a));
            Console.ReadKey();
        }

        static int maxArr(int[] a)
        {
            int max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }
        static void inpArr(ref int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void outArr(int[] a)
        {
            Console.WriteLine("Xuat Mang : ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"a[{i}] = {a[i]}" );
            }
        }

    }
}
