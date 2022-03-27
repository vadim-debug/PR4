using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    interface Iinvoice : IDocument
    {

    }
     class Invoice:Document, Iinvoice
    {
        protected string status;
        protected DateTime DateShipment;
        protected int sum;
        public int weight;
        public string description;
        public string FullName;
        public override void Delete()
        {
            Console.WriteLine("Накладная удалена");
        }
        public override void Cancel()
        {
            Console.WriteLine("Накладная Отменена");
        }
        public Invoice(string Status) { }
        public Invoice(DateTime DateShipment) { }
        public Invoice(string description, string FullName) { }
        
    }
}
