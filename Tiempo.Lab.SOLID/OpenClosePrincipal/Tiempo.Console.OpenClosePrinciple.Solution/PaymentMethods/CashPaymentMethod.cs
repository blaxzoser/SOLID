using System;
namespace LittleStoreSOLID.PaymentMethods
{
    public class CashPaymentMethod: IPaymentMethod
    {
        public string Description => "Cash";

        public void Pay(decimal amount)
        {
            do
            {
                Console.WriteLine("type the exact amount");
                var amountReceivedText = Console.ReadLine();

                if (decimal.TryParse(amountReceivedText, out var amountReceived))
                {
                    if (amountReceived == amount)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
            } while (true);
        }
    }
}
