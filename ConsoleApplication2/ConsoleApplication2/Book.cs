using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Book : Document
    {
        private string author;
        private int pageNumber;

        public Book() { }

        public Book(String id, String nxb, int number, string author, int pageNumber) : base(id, nxb, number)
        {
            this.author = author;
            this.pageNumber = pageNumber;
        }

        protected string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        protected int PageNumber
        {
            get
            {
                return pageNumber;
            }

            set
            {
                pageNumber = value;
            }
        }

        public override void inputValue()
        {
            base.inputValue();
            Console.Write("Enter author: ");
            author = Console.ReadLine();
            Console.Write("Enter page  number: ");
            pageNumber = int.Parse(Console.ReadLine());
        }

        public override void toString()
        {
            base.toString();
            Console.WriteLine($"\tauthor: {author}");
            Console.WriteLine($"\tpageNumber: {pageNumber}");
        }
    }
}
