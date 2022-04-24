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
                Console.WriteLine("Quản lý tài liệu");
                Console.WriteLine("1. Thêm tài liệu");
                Console.WriteLine("2. Tìm tài liệu");
                Console.WriteLine("3. Hiển thị danh sách tài liệu");
                Console.WriteLine("4. Xoá tài liệu theo id");
                Console.WriteLine("0. Thoát");
                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        Console.WriteLine("Quản lý tài liệu");
                        InsertDoc(doc);
                        break;
                    case "2":

                        break;
                    case "3":
                        Console.WriteLine("3. Hiển thị danh sách tài liệu");
                        break;
                    case "4":
                        Console.WriteLine("4. Xoá tài liệu theo id");
                        break;
                    case "0":

                        break;
                }
            }
            Newspaper book = new Newspaper("1", "1", 1, "1");
            Newspaper book1 = new Newspaper("2", "1", 1, "1");
            Newspaper book2 = new Newspaper("3", "1", 1, "1");
            Newspaper book3 = new Newspaper("4", "1", 1, "1");

            doc.addDoc(book);
            doc.addDoc(book1);
            doc.addDoc(book2);
            doc.addDoc(book3);
            doc.addDoc(new Book("5", "nxb", 1, "author", 10));
            
            doc.showDocument();
            doc.delDoc("4s");
            doc.showDocument();
            Console.ReadKey();
        }

        static void InsertDoc(ManagerDocument doc)
        {
            while (true)
            {
                Console.WriteLine("1. Thêm Sách");
                Console.WriteLine("2. Thêm Tạp Chí");
                Console.WriteLine("3. Thêm Báo");
                Console.WriteLine("0. Quay Lại");
                string chooseInsert = Console.ReadLine();

                switch (chooseInsert)
                {
                    case "1":
                        Console.WriteLine("1. Thêm Sách");
                        Book book = new Book();
                        book.inputValue();
                        doc.addDoc(book);
                        break;

                    case "2":
                        Console.WriteLine("1. Thêm Sách");
                        Newspaper Newspaper = new Newspaper();
                        Newspaper.inputValue();
                        doc.addDoc(Newspaper);
                        break;

                    case "3":
                        Console.WriteLine("1. Thêm Sách");
                        Journal Journal = new Journal();
                        Journal.inputValue();
                        doc.addDoc(Journal);
                        break;

                    case "0":
                        break;
                }

            }
        }
    }

}
