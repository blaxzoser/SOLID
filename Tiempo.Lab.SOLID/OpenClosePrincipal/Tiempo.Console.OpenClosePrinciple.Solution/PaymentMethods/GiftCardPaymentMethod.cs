using System;
namespace LittleStoreSOLID.PaymentMethods
{
    public class GiftCardPaymentMethod : IPaymentMethod
    {
        public string Description => "Gift Card";

        public void Pay(decimal amount)
        {
            Console.WriteLine("type the gift card number");
            var giftNumber = Console.ReadLine();
            //Some fancy validation
            Console.WriteLine($"gift card '{giftNumber}' accepted");
        }
    }
}
