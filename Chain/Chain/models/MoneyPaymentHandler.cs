using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.models
{
    class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Reciever reciever)
        {
            
            if (reciever.MoneyTransfer == true)
            {
                Console.WriteLine("Выполняем перевод через систему денежных переводов");

            }
            else 
            if (Successor != null)
            {
                Successor.Handle(reciever);
            }
        }
   
    }
}
