namespace OOP.PaymentModule {
    interface IPaymentMethod {
        void ProcessPayment(decimal amount);
    }

    abstract class PaymentProcessor : IPaymentMethod {
        abstract void ProcessPayment (decimal ammout) 
    }

    class CreditCardPayment: PaymentProcessor {
        void ProcessPayment (decimal amount) {
            Console.WriteLine("Payment made through creditcard");
        }
    }

    class PayPalPayment: PaymentProcessor {
        void ProcessPayment (decimal amount) {
            Console.WriteLine("Payment made through Paypal");
        }
    }
}