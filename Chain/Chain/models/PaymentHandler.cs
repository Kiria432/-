using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.models
{
    abstract class PaymentHandler
    {

        public PaymentHandler Successor { get;set; }
        public abstract void Handle(Reciever reciever);
    }
}
