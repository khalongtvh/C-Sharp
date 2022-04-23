using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Journal : Document
    {
        private int monthIssue;
        private int issueNumber;

        public int IssueNumber
        {
            get
            {
                return issueNumber;
            }

            set
            {
                issueNumber = value;
            }
        }

        public int MonthIssue
        {
            get
            {
                return monthIssue;
            }

            set
            {
                monthIssue = value;
            }
        }

        public Journal(String id, String nxb, int number, int issueNumber, int mouthIssue) : base(id, nxb, number)
        {
            this.MonthIssue = mouthIssue;
            this.IssueNumber = issueNumber;
        }

        public Journal() { }

        public override void inputValue()
        {
            base.inputValue();
            Console.Write("Nhập số phát hành: ");
            MonthIssue = int.Parse(Console.ReadLine());
            Console.Write("Nhập tháng phát hành: ");
            IssueNumber = int.Parse(Console.ReadLine());
        }

        public override void toString()
        {
            base.toString();
            Console.WriteLine($"\tSố phát hành : {issueNumber}");
            Console.WriteLine($"\tTháng phát hành : {monthIssue}");
        }
    }
}
