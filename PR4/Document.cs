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
        public Document() { }
        public Document(int Number) { }
        
        public Document(DateTime Date) { }
        
        public Document(int Number, DateTime Date) { }
       
    }
}
