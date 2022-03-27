using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    interface IOrder:IDocument
    {
        void Payment();
    }
     class Order: Document, IOrder
    {
        protected string Status;
        protected DateTime DateShipment;
        protected DateTime DatePayment;
        protected int Price;
        public override void Delete()
        {
            Console.WriteLine("Заказ удален");
        }
        public override void Cancel()
        {
            Console.WriteLine("Заказ отменён");
        }
        public  void Payment()
        {
            Console.WriteLine("Заказ оплачен");
        }

        public Order(string Status)
        {
            this.Status = Status;
        }
        public Order() { }
        
        public Order(DateTime DatePayment, int Price) { }
        
    }
}
