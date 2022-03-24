using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    public interface IDocument
    {
        void Delete();
        void Cancel();
         }
     class Document:IDocument
    {
        protected int Number;
        protected DateTime Date;

         public virtual void Delete()
        {
            Console.WriteLine("документ удалён");
        }
        public virtual void Cancel()
        {
            Console.WriteLine("документ отменён");
        }
        public Document(int Number)
        {
            this.Number = Number;
        }
        public Document(DateTime Date)
        {
            this.Date = Date;
        }
        public Document (int Number, DateTime Date)
        {
            this.Date = Date;
            this.Number = Number;
        }
    }
}
