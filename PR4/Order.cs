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
      class Order: IOrder
    {
        protected string Status;
        protected DateTime DateShipment;
        protected DateTime DatePayment;
        protected int Price;
        public virtual void Delete()
        {
            Console.WriteLine("Заказ удален");
        }
        public virtual void Cancel()
        {
            Console.WriteLine("Заказ отменён");
        }
        public virtual void Payment()
        {
            Console.WriteLine("Заказ оплачен");
        }

        public Order(string Status)
        {
            this.Status = Status;
        }
        public Order(DateTime DateShipment)
        {
            this.DateShipment = DateShipment;
        }
        public Order(DateTime DatePayment, int Price)
        {
            this.DatePayment = DatePayment;
            this.Price = Price;
        }
    }
}
