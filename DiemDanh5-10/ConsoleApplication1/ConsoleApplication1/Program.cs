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
            int[] arr_229 = new int[10];
            arr_229 = nhapMang(arr_229);
            Console.WriteLine("mang da nhap: ");
            xuatMang(arr_229);
            Console.WriteLine($"max : {max_Array(arr_229)}");
            Console.WriteLine($"min : {min_Array(arr_229)}");
            Console.WriteLine("mang sap xep giam dan: ");
            sapxepGiamDan(arr_229);
            Console.WriteLine("mang sap xep tang dan: ");
            sapxepTangDan(arr_229);
            Console.ReadKey();
        }

        static int max_Array(int [] arr_229)
        {
            int max = arr_229[0];
            for(int i = 1; i< arr_229.Length; i++)
            {
                if(max < arr_229[i])
                {
                    max = arr_229[i];
                }
            }
            return max;
        }
        static int min_Array(int[] arr_229)
        {
            int min = arr_229[0];
            for (int i = 1; i < arr_229.Length; i++)
            {
                if (min > arr_229[i])
                {
                    min = arr_229[i];
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

        static void sapxepGiamDan(int[] arr_229)
        {
            for (int i = 0; i < arr_229.Length - 1; i++)
            {
                for (int j = i + 1; j < arr_229.Length; j++)
                {
                    if (arr_229[i] < arr_229[j])
                    {
                        swap(ref arr_229[i], ref arr_229[j]);
                    }
                }
            }

            xuatMang(arr_229);
        }
        static void sapxepTangDan(int[] arr_229)
        {
            for (int i = 0; i < arr_229.Length - 1; i++)
            {
                for (int j = i + 1; j < arr_229.Length; j++)
                {
                    if (arr_229[i] > arr_229[j])
                    {
                        swap(ref arr_229[i], ref arr_229[j]);
                    }
                }
            }

            xuatMang(arr_229);
        }
        static int[] nhapMang(int []arr_229)
        {
            for (int i = 0; i < arr_229.Length; i++)
            {
                Console.Write($"arr_229[{i}] = ");
                arr_229[i] = int.Parse(Console.ReadLine());
            }
            return arr_229;
        }

        static void xuatMang (int[] arr_229){
            for (int i = 0; i < arr_229.Length; i++)
            {
                Console.WriteLine($"arr_229[{i}] = {arr_229[i]}");
            }
        }
    }
}
