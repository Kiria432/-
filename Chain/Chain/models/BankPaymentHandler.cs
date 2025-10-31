using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.models
{
    class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Reciever reciever)
        {
            if (reciever.BankTransfer==true)
            {
                Console.WriteLine("Выполняем банковский перевод");

            }
            else if(Successor!=null)
            {
                Successor.Handle(reciever);
            }
        }
    }
}
