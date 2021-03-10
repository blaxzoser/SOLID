using System;
using System.Collections.Generic;
using System.IO;
using LittleStoreSOLID.PaymentMethods;

namespace LittleStoreSOLID
{
    public class PaymentMethodsLoader
    {
        public Dictionary<string, IPaymentMethod> PaymentMethods { get; } = new Dictionary<string, IPaymentMethod>();

        public void Load()
        {
            var lines = File.ReadAllLines("PaymentMethods.txt");

            var index = 'a';

            foreach (var line in lines)
            {
                var fullName = $"LittleStoreSOLID.PaymentMethods.{line}";
                PaymentMethods[index.ToString()] = (IPaymentMethod)Activator.CreateInstance(Type.GetType(fullName));
                index++;
            }
        }
    }
}
