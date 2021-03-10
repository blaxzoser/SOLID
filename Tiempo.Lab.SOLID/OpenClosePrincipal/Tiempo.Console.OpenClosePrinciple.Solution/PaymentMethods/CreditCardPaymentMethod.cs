using System;
namespace LittleStoreSOLID.PaymentMethods
{
    public class CreditCardPaymentMethod : IPaymentMethod
    {
        public string Description => "Credit Card";

        public void Pay(decimal amount)
        {
            Console.WriteLine("type the credit card number");
            var creditCardNumber = Console.ReadLine();
            //Some fancy validation
            Console.WriteLine($"credit card '{creditCardNumber}' accepted");
        }
    }
}
