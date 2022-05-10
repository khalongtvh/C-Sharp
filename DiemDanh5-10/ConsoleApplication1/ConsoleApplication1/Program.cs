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
            int[] arr = new int[10];
            arr = nhapMang(arr);
            xuatMang(arr);
            Console.WriteLine($"max : {max_Array(arr)}");
            Console.WriteLine($"min : {min_Array(arr)}");
            Console.ReadKey();
        }

        static int max_Array(int [] arr)
        {
            int max = arr[0];
            for(int i = 1; i< arr.Length; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static int min_Array(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void sapxep(int []arr)
        {
            for(int i = 0; i< arr.Length-1; i++)
            {
                for(int j = i+1; j<arr.Length; j++)
                {
                    if(arr[i]<arr[j])
                }
            }
        }
        static int[] nhapMang(int []arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        static void xuatMang (int[] arr){
            Console.WriteLine("Mang da nhap: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
        }
    }
}
