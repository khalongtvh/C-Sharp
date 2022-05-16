using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai59
{
    class Program
    {
        static void bai59()
        {
            //Nhập vào năm Dương lịch, xuất tên năm Âm lịch. 
            //Xuất năm Dương lịch kế tiếp có cùng tên năm Âm lịch.
            Console.Write("Nhập năm dương lịch : ");
            int n = int.Parse(Console.ReadLine());
            string[] can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            string[] chi = { "Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };
            Console.Write("{0:D} - {1} {2}\n", n, can[n % 10], chi[n % 12]);
            Console.Write("{0:D} - {1} {2}\n", n + 60, can[n % 10], chi[n % 12]);
        }

        static int[] init_arr(int min, int max)
        {
            int n = -1;
            do
            {
                try
                {
                    Console.Write("Nhập số phần tử của mảng (n > 0): ");
                    n = int.Parse(Console.ReadLine());
                }catch(Exception e)
                {
                    n = -1;
                }
            } while (n <= 0);
            int[] arr = new int[n];

            Random rand = new Random();
            for (int i = 0;i < n; i++)
            {
                int x = rand.Next(min, max);
                arr[i] = x;
            }
            return arr;
        }
        
        static int[] tronArray(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];

            int iA = 0;
            int iB = 0;
            int nC = 0;
            //trộn mảng
            while (iA < a.Length && iB < b.Length)
            {
                c[nC++] = a[iA++];
                c[nC++] = b[iB++];
            }
            while (iA < a.Length)
            {
                c[nC++] = a[iA++];
            }
            while (iB < b.Length)
            {
                c[nC++] = b[iB++];
            }

            return c;
        }

        static void bai60()
        {
            //int[] arr = init_arr(-100, 100);
            int[] arr = new int[] { -33, 62, -12, 34, -89, 65, -3, -96, 86, 89, 39, 35};
            Console.WriteLine("Khởi tạo mảng ban đầu : ");
            Out_arr(arr, arr.Length);
            int[] c = perfectShuffle(arr);
            Console.WriteLine("perfect shuffle : ");
            Out_arr(c, c.Length);
            int count = 1;
            do
            {
                c = perfectShuffle(c);
                count++;
            } while ((!(arr.SequenceEqual(c))));

            Console.WriteLine($"Cần {count} lần shuffle để mảng trở về ban đầu" );
        }

        static int[] perfectShuffle(int[] arr)
        {
            int size = arr.Length / 2;
            int[] a = new int[size];
            int[] b = new int[arr.Length - size];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = arr[i];
            }
            int j = 0;
            //tách mảng 
            if (arr.Length % 2 == 0)
            {
                for (int i = b.Length; i < arr.Length; i++)
                {
                    b[j++] = arr[i];
                }
            }
            else
            {
                for (int i = b.Length - 1; i < arr.Length; i++)
                {
                    b[j++] = arr[i];
                }
            }
            int[] c = new int[arr.Length];
            return tronArray(a, b);
        }

        static int sum_arr(int[] arr)
        {
            int s = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    s += arr[i];
                }
            }
            return s;
        }

        static void Out_arr(int[] arr, int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine($"arr[{i}] = " + arr[i] );
            }
            Console.WriteLine();
        }

        static int Inp_K(int n)
        {
            int k = -1;
            do
            {
                try
                {
                    Console.Write("Nhập vị trí k muốn xoá (0 <= k <= {0}) : ", n - 1);
                    k = int.Parse(Console.ReadLine());
                }catch (Exception e)
                {
                    k = -1;
                }
                
            } while ((k < 0 || k >= n));
            return k;
        }

        static void Del_k(int[] arr, int k)
        {
            for (int i = k; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
        }

        static void bai61()
        {
            //init array
            int[] arr = init_arr(-100, 100);
            ////show values array
            Out_arr(arr, arr.Length);
            //sum a[i] > 0
            Console.WriteLine("Tổng phẩn tử nguyên dương trong mảng : {0} ", sum_arr(arr));
            //init value k
            int k = Inp_K(arr.Length);
            //del value a[k]
            Console.WriteLine($"Phần tử cần xoá arr[{k}] = {arr[k]}");
            Console.WriteLine($"Mảng sau khi xoá : ");
            Del_k(arr, k);
            //show values array
            Out_arr(arr, arr.Length-1);
        }
         
        static void check_sum(int[] arr)
        {
            int s1 = 0, s2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //tong le o vi tri chan
                if(i % 2 == 0 && arr[i] % 2 !=0)
                {
                    s1 += arr[i];
                }
                //tong chan o vi tri le
                if (i % 2 != 0 && arr[i] % 2 == 0)
                {
                    s2 += arr[i];
                }
            }
            Console.Write($"Tổng lẻ ở vị trí chẳn ({s1}) và tổng chẳn ở vị trí lẻ ({s2}) " );
            if (s1 == s2)
            {
                Console.WriteLine("bằng nhau");
            }
            else
            {
                Console.WriteLine("không bằng nhau");
            }
        }

        static int gcd(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

        static void check_coprime(int[] arr)
        {
            Console.WriteLine("Các cặp nguyên tố cùng nhau :");
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                for (int j = i + 1; j < arr.Length; ++j)
                    if(gcd(arr[i], arr[j]) == 1)
                        Console.WriteLine($"({arr[i]}, {arr[j]})");
            }
                
        }

        static void bai62()
        {
            //init array
            //int[] arr = init_arr(10, 20);
            int[] arr = { 14, 14, 11, 16, 12 };
            //show values array
            Out_arr(arr, arr.Length);
            //check sum 
            check_sum(arr);
            //check coprime
            check_coprime(arr);
        }

        static void max_min_array(int[] arr, out int max, out int min, out int iMax, out int iMin)
        {
            max = min = arr[0];
            iMax = iMin = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    iMax = i;
                }
                if (arr[i] < min)
                {
                    iMin = i;
                    min = arr[i];
                }
            }
        }
        static void found_del_Max_array(ref int[] arr, int max, int iMax, out int arr_length)
        {
            int countMax = 0;
            for (int i = iMax + 1; i < arr.Length; i++)
            {
                if (arr[i] == max)
                {
                    countMax++;
                    Del_k(arr, i);
                    i--;
                }
            }
            arr_length = arr.Length - countMax;
        }
        static void bai66()
        {
            //init array
            //int[] arr = init_arr(10, 20);
            int[] arr = { 21, 1, - 68, 24, 22, - 76, - 69, 0, 24, - 84 };
            //show values array
            Out_arr(arr, arr.Length);
            int min, max, iMax, iMin;
            max_min_array(arr, out max, out min, out iMax, out iMin);

            Console.WriteLine($"Max : arr[{iMax}]= {max}\nMin : arr[{ iMin}]= { min}\n");

            int arr_length;
            //Xóa các phần tử trong mảng có trị trùng với giá trị lớn nhất của mảng, 
            //trừ phần tử tìm được đầu tiên.
            Console.WriteLine("Mảng sau khi xoá các phần tử có giá trị trùng với giá trị lớn nhất : ");
            found_del_Max_array(ref arr, max, iMax, out arr_length);
            Out_arr(arr, arr_length);
        }

        static void Xoa(int[] a, ref int n, int vitrixoa)
        {
	        for(int i = vitrixoa + 1; i < n; i++)
	        {
		        a[i - 1] = a[i];
	        }
	        n--;
        }

        static void Xoa_Phan_Tu_Trung(int[] a, ref int n)
        {
	        for(int i = 0; i < n - 1; i++)
	        {
		        for(int j = i + 1; j < n; j++)
		        {
			        if(a[i] == a[j])
			        {
                        Xoa(a, ref n, j);
                        if (i > 0)
                        {
                            i--;
                        }
                        else
                        {
                            i = 0;
                        }
			        }
		        }
	        }
        }

        static void swap(ref int a, ref int b)
        {
            int temp = a;
			a = b;
			b = temp;
        }
        static void bai65()
        {
            //Xóa các phần tử có trị trùng nhau trong mảng, chỉ chừa lại một phần tử
            int[] arr = { 2,2,2,2,3,1,3,7,2 };
            int n = arr.Length;
            for (int i = 0; i < n; i++) {
				for (int j = i + 1; j < n; j++) {
					if (arr[i] > arr[j]) {
						swap(ref arr[i],ref arr[j]);
					}
				}
			}
            Out_arr(arr, n);
            
            for(int i = 0; i< n - 1; i++)
            {
                if(arr[i] == arr[i + 1])
                {
                    Del_k(arr, i+1);
                    i--;
                    n--;
                }
            }
            Out_arr(arr, n);


        }
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            int choose = 0;

            bai65();
            Console.ReadKey();
            /*
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("=================================================================================");
                    Console.WriteLine("1. Bai 59");
                    Console.WriteLine("2. Bai 60");
                    Console.WriteLine("3. Bai 61");
                    Console.WriteLine("4. Bai 62");
                    Console.WriteLine("5. Bai 66");
                    Console.WriteLine("0. Thoat");
                    Console.Write("Chon bai : ");
                    choose = int.Parse(Console.ReadLine());
                    Console.WriteLine("=================================================================================");
                    
                    switch (choose)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("========================================== Bài 59 : ==========================================");
                            Console.WriteLine("Nhập vào năm Dương lịch, xuất tên năm Âm lịch.\nXuất năm Dương lịch kế tiếp có cùng tên năm Âm lịch.");
                            Console.WriteLine("=================================================================================");
                            bai59();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("========================================== Bài 60 : ==========================================");
                            Console.WriteLine("a. Tạo ngẫu nhiên mảng một chiều n phần tử nguyên (n chẵn) có giá trị chứatrong đoạn [-100, 100] và xuất mảng.");
                            Console.WriteLine("b. Viết hàm thực hiện việc trộn hoàn hảo (perfect shuffle) một mảng: sao cho \ncác phần tử của một nửa mảng sau xen kẽ với các phần tử của một nửa mảng \nđầu. Xuất mảng sau khi trộn");
                            Console.WriteLine("c. Xác định số lần trộn hoàn hảo để mảng trở về như ban đầu.");
                            Console.WriteLine("=================================================================================");

                            bai60();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("========================================== Bài 61 : ==========================================");
                            Console.WriteLine("a. Tạo ngẫu nhiên mảng một chiều n phần tử nguyên có giá trị chứa trong đoạn [-100, 100] và xuất mảng.");
                            Console.WriteLine("b. Tính tổng các số nguyên dương có trong mảng.");
                            Console.WriteLine("c. Xóa phần tử có chỉ số p (p nhập từ bàn phím) trong mảng.");
                            Console.WriteLine("=================================================================================");
                            bai61();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("========================================== Bài 62 : ==========================================");
                            Console.WriteLine("a. Tạo ngẫu nhiên mảng một chiều n phần tử nguyên dương có giá trị chứa trong đoạn [10, 20] và xuất mảng.");
                            Console.WriteLine("b. Kiểm tra xem tổng các số chẵn ở vị trí lẻ có bằng tổng các số lẻ ở vị trí chẵn hay không?");
                            Console.WriteLine("c. Xác định xem mảng có cặp số nguyên tố cùng nhau (coprime) nào không");
                            Console.WriteLine("=================================================================================");
                            bai62();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("========================================== Bài 66 : ==========================================");
                            Console.WriteLine("a. Tạo ngẫu nhiên mảng một chiều n phần tử nguyên có giá trị chứa trong đoạn [-100, 100] và xuất mảng.");
                            Console.WriteLine("b. Dùng một vòng lặp, tìm phần tử có trị nhỏ nhất và lớn nhất của mảng.");
                            Console.WriteLine("c. Xóa các phần tử trong mảng có trị trùng với giá trị lớn nhất của mảng, trừ phần tử tìm được đầu tiên");
                            Console.WriteLine("=================================================================================");
                            bai66();
                            break;
                    }
                }
                catch (Exception e)
                {
                    choose = 0;
                }
                Console.Write("Nhấp phím bất kỳ để thoát");
                Console.ReadKey();
            } while (choose >= 1 && choose <= 5);
            */
        }
    }
}
