using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ManagerDocument
    {
        private List<Document> docs;

        public ManagerDocument()
        {
            this.docs = new List<Document>();
        }

        public void addDoc(Document newDoc)
        {
            this.docs.Add(newDoc);
        }

        public void searchBook(string id)
        {
            foreach (var doc in docs)
            {
                string docType = doc.GetType().ToString();
                if (docType.Contains("Book") && doc.Id.Equals(id))
                {
                    doc.toString();
                }
            }
        }
        public void searchNewspaper(string id, string search)
        {
            foreach (var doc in docs)
            {
                string docType = doc.GetType().ToString();
                if (docType.Contains("Newspaper") && doc.Id.Equals(id))
                {
                    doc.toString();
                }
            }
        }
        public void searchJournal(string id, string search)
        {
            foreach (var doc in docs)
            {
                string docType = doc.GetType().ToString();
                if (docType.Contains("Journal") && doc.Id.Equals(id))
                {
                    doc.toString();
                }
            }
        }

        public void showDocument()
        {
            Console.WriteLine("Xuất thông tin : ");
            docs.ForEach(delegate (Document itemDoc)
            {
                itemDoc.toString();
            });
        }
    }
}
