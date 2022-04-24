using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Document
    {
        private string id;
        private string nxb;
        private int number;

        public Document(String id, String nxb, int number)
        {
            this.id = id;
            this.nxb = nxb;
            this.number = number;
        }

        public Document() { }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public string Nxb
        {
            get
            {
                return nxb;
            }

            set
            {
                nxb = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public virtual void inputValue()
        {
            try
            {
                Console.Write("Nhap id: ");
                id = Console.ReadLine();
                Console.Write("Nhap nxb: ");
                nxb = Console.ReadLine();
                Console.Write("Nhap so ban phat hanh: ");
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception e) { }
        }

        public virtual void toString()
        {
            Console.WriteLine($"\t\tid: {id}");
            Console.WriteLine($"\t\tnxb: {nxb}");
            Console.WriteLine($"\t\tnumber: {number}");
        }
    }
}
