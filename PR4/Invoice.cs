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
     class Invoice: Iinvoice
    {
        protected string status;
        protected DateTime DateShipment;
        protected int sum;
        public int weight;
        public string description;
        public string FullName;
        public virtual void Delete()
        {
            Console.WriteLine("Накладная удалена");
        }
        public virtual void Cancel()
        {
            Console.WriteLine("Накладная Отменена");
        }
        public Invoice(string Status)
        {
            this.status = Status;
        }
        public Invoice(DateTime DateShipment)
        {
            this.DateShipment = DateShipment;
        }
        public Invoice(string description, string FullName)
        {
            this.description = description;
            this.FullName = FullName;
        }
    }
}
