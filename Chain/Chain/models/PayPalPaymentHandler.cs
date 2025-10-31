using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.models
{
    class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Reciever reciever)
        {
           
            if (reciever.PayPalTransfer == true)
            {
                Console.WriteLine("Выполняем перевод через PayPal");

            }
            else if (Successor != null)
            {
                Successor.Handle(reciever);
            }
       
    }
    }
}
