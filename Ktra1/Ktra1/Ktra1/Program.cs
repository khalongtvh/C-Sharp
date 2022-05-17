using System;

namespace Ktra1
{
    class Program
    {
        //Viết phương thức in ra tổng, hiệu, tích, thương của 2 số đc nhập vào bàn phím cho trước.
        void cau1()
        {
            Console.Write("Nhap so thu 1 : ");
            double a_29 = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 2 : ");
            double b_29 = double.Parse(Console.ReadLine());
            Console.WriteLine("ket qua: ");
            Console.WriteLine("{0}+{1}={2}", a_29, b_29, a_29 + b_29);
            Console.WriteLine("{0}-{1}={2}", a_29, b_29, a_29 - b_29);
            Console.WriteLine("{0}*{1}={2}", a_29, b_29, a_29 * b_29);
            Console.WriteLine("{0}/{1}={2}", a_29, b_29, a_29 / b_29);
        }


        //Viết phương thức In ra lá cờ Việt Nam bằng các dấu = và *
        void cau2()
        {
            Console.WriteLine("Nhap m > 0");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap n > 0");
            int n = Convert.ToInt32(Console.ReadLine());

            if (m > 0 && n > 0)
            {
                for (int i = 1; i <= m; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (i == 1 || i == m || j == 1 || j == n)
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Nhap m, n > 0");
            }
        }

        //Viết phương thức đổi số thập phân thành số nhị phân từ một số thập phân nhập vào từ bàn phím.
        void cau3()
        {
            Console.Write("Nhap so can chuyen : ");
            int a_29 = int.Parse(Console.ReadLine());
            double nhiPhan_29 = 0;
            int p_29 = 0;
            while (a_29 > 0)
            {
                nhiPhan_29 += (a_29 % 2) * Math.Pow(10, p_29);
                ++p_29;
                a_29 /= 2;
            }
            Console.WriteLine(nhiPhan_29);
        }

        //Viết phương thức in ra các thông tin của bản thân (họ tên, lớp, mã sv)
        void cau4()
        {
            Console.WriteLine("Ho ten : Tran Van Khanh");
            Console.WriteLine("ma sinh vien : 1911505310229");
            Console.WriteLine("lop : 221LTC02");
        }
        static void Main(string[] args)
        {
            //int choose = int.Parse(Console.ReadLine());
            Console.WriteLine("1. tinh tong , thuong , hieu , tich 2 so a, b");
            Console.WriteLine("2. in la co Viet Nam bang dau * va =");
            Console.WriteLine("3. chuyen so thap phan thanh nhi phan");
            Console.WriteLine("4. in thong tin ban than");
            Console.WriteLine("5. Thoat");
            Console.WriteLine("nhap lua chon : ");
            Program pr_29 = new Program();
            pr_29.cau2();
            Console.ReadKey();
        }
    }
}
