using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Newspaper : Document
    {
        private string dayIssue;

        public Newspaper() { }

        public Newspaper(String id, String nxb, int number, string dayIssue) : base(id, nxb, number) {
            this.dayIssue = dayIssue;
        }

        public override void inputValue()
        {
            base.inputValue();
            Console.Write("Nhập ngày phát hành: ");
            dayIssue = Console.ReadLine();
        }

        public override void toString()
        {
            //Console.WriteLine("\tBáo:");
            base.toString();
            Console.WriteLine($"\tNgày phát hành{dayIssue}");
        }
        protected string DayIssue
        {
            get
            {
                return dayIssue;
            }

            set
            {
                dayIssue = value;
            }
        }
    }
}
