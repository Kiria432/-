// See https://aka.ms/new-console-template for more information
using Chain.models;

Reciever reciever = new Reciever(false, true, true);
PaymentHandler bankPaymentHandler = new BankPaymentHandler();
PaymentHandler moneyPaymentHandler=new MoneyPaymentHandler();
PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();
bankPaymentHandler.Successor = paypalPaymentHandler;
paypalPaymentHandler.Successor = moneyPaymentHandler;
bankPaymentHandler.Handle(reciever);
moneyPaymentHandler.Handle(reciever);

Console.ReadKey();
