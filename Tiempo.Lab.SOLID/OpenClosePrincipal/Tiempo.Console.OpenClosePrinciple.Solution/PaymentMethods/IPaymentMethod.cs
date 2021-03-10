namespace LittleStoreSOLID.PaymentMethods
{
    public interface IPaymentMethod
    {
        string Description { get; }
        void Pay(decimal amount);
    }
}
