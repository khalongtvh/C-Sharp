using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ManagerDocument doc = new ManagerDocument();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=================Quản lý tài liệu=================");
                Console.WriteLine("1. Thêm tài liệu");
                Console.WriteLine("2. Tìm tài liệu");
                Console.WriteLine("3. Hiển thị danh sách tài liệu");
                Console.WriteLine("4. Xoá tài liệu theo id");
                Console.WriteLine("0. Thoát");
                Console.Write("Nhập công việc cần thực hiện: ");
                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        InsertDoc(doc);
                        break;

                    case "2":
                        searchDoc(doc);
                        break;

                    case "3":
                        Console.WriteLine("=================Hiển thị danh sách tài liệu=================");
                        doc.showDocument();
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("=================Xoá tài liệu theo id=================");
                        Console.Write("Nhập id tài liệu muốn xoá: ");
                        string id = Console.ReadLine();
                        doc.delDoc(id);
                        break;

                    case "0":
                        return;
                }
            }
        }

        static void InsertDoc(ManagerDocument doc)
        {
            while (true)
            {
                Console.WriteLine("=================Thêm tài liệu=================");
                Console.WriteLine("1. Thêm Sách");
                Console.WriteLine("2. Thêm Tạp Chí");
                Console.WriteLine("3. Thêm Báo");
                Console.WriteLine("0. Quay Lại");
                Console.Write("Nhập công việc cần thực hiện: ");

                string chooseInsert = Console.ReadLine();

                switch (chooseInsert)
                {
                    case "1":
                        Console.WriteLine("1. Thêm Sách");
                        init_Book:
                        Book book = new Book();
                        book.inputValue();
                        if (!doc.checkId(book.Id))
                        {
                            doc.addDoc(book);
                        }
                        else
                        {
                            Console.WriteLine("=================Trùng ID=================");
                            Console.WriteLine("Nhập lại!");
                            goto init_Book;
                        }
                        break;

                    case "2":
                        Console.WriteLine("2. Thêm Báo");
                        init_Newspaper:
                        Newspaper Newspaper = new Newspaper();
                        Newspaper.inputValue();
                        if(!doc.checkId(Newspaper.Id))
                        {
                            doc.addDoc(Newspaper);
                        }
                        else
                        {
                            Console.WriteLine("=================Trùng ID=================");
                            Console.WriteLine("Nhập lại!");
                            goto init_Newspaper;
                        }
                        break;

                    case "3":
                        Console.WriteLine("3. Thêm Tạp Chí");
                        init_Journal:
                        Journal Journal = new Journal();
                        Journal.inputValue();
                        if (!doc.checkId(Journal.Id))
                        {
                            doc.addDoc(Journal);
                        }
                        else
                        {
                            Console.WriteLine("=================Trùng ID=================");
                            Console.WriteLine("Nhập lại!");
                            goto init_Journal;
                        }
                        break;

                    case "0":
                        return;
                }

            }
        }

        static void searchDoc(ManagerDocument doc)
        {
            while (true)
            {
                Console.WriteLine("=================Tìm tài liệu=================");
                Console.WriteLine("1. Tìm Sách");
                Console.WriteLine("2. Tìm Tạp Chí");
                Console.WriteLine("3. Tìm Báo");
                Console.WriteLine("0. Quay lại");
                Console.Write("Nhập công việc cần thực hiện: ");
                string type = Console.ReadLine();
                Console.Write("Nhập id cần tìm: ");
                string id = Console.ReadLine();
                switch (type)
                {
                    case "1":
                        doc.search(id, "Book");
                        break;
                    case "2":
                        doc.search(id, "Journal");
                        break;
                    case "3":
                        doc.search(id, "Newspaper");
                        break;
                    case "0":
                        return;
                }

            }
        }
    }

}
