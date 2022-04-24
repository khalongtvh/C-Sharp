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

        public void delDoc(string id)
        {
            this.docs.RemoveAt(docs.FindIndex(doc => doc.Id.Equals(id)));

            //foreach (var doc in docs)
            //{
            //    if (doc.Id.Equals(id))
            //    {
            //        this.docs.Remove(doc);
            //    }
            //}
        }

        public void search(string id, string typeSearch)
        {
            foreach (var doc in docs)
            {
                string docType = doc.GetType().ToString();
                if (docType.Contains(typeSearch) && doc.Id.Equals(id))
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
