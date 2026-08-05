using System;
namespace DiscountCalculator
//{
//    class Order
//    {
//        public string CustomerEmail;
//        public string CustomerSMS;

//    }
//    class OrderProcessor
//    {

//        private readonly INotifier _notifier;
//        public OrderProcessor(INotifier notifier)
//        {
//            _notifier = notifier;
//        }

//        public void Process(Order o)
//        {
//            _notifier.Send(o, "Your order is ready!");
//        }
//    }
//    interface INotifier
//    {
//        void Send(Order to, string message);

//    }
//    class EmailNotifier : INotifier
//    {
//        public void Send(Order to, string message) 
//        { Console.WriteLine($"Email to {to.CustomerEmail}: {message}"); }

//    }
//    class SmsNotifier : INotifier
//    {
//        public void Send(Order to, string message) 
//        {
//            Console.WriteLine($"SNS to {to.CustomerSMS}: {message}"); 
//        }

//    }
//    class Program
//    {
//        static void Main()
//        {
//            //var EmailOrder = new Order { CustomerEmail = "test@example.com" };
//            var SMSOrder = new Order { CustomerSMS = "+9027587452" };
//            var Notifier = new SmsNotifier();
//            //var Notifier = new EmailNotifier();
//            //var p1 = new OrderProcessor(Notifier);
//            //p1.Process(EmailOrder);
//            var p2 = new OrderProcessor(Notifier);
//            p2.Process(SMSOrder);
//        }
//    }



//}
{
    interface IDiscount
    {
        double Apply(double price);
    }
    class ShoppingCart
    {
        private readonly  IDiscount _discount = new PercentageDiscount();

        public decimal GetTotal(decimal price)
        {
            return _discount.Apply(price);
        }
    }

}