

using LittleStoreSOLID;
using LittleStoreSOLID.PaymentMethods;
using System.Collections.Generic;
using System.Linq;

namespace Tiempo.Console.OpenClosePrinciple.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var selectItemList = new List<Item>();
            var requirePayment = false;

            var itemLoader = new ItemLoader();
            itemLoader.Load();

            var paymentMethodsLoader = new PaymentMethodsLoader();
            paymentMethodsLoader.Load();

            // to show the items
            do
            {
                System.Console.WriteLine($"Current total: {selectItemList.Sum(x => x.Price):c}");

                System.Console.WriteLine("Hello User");
                System.Console.WriteLine("Item List");

                foreach (var item in itemLoader.Items)
                {
                    System.Console.WriteLine($"{item.Key}) {item.Value.Description}");
                }

                System.Console.WriteLine("Select Option: ");

                //--------------------------------- read user Input ---
                var input = System.Console.ReadLine();

                if (input == itemLoader.Items.Last().Key)
                {
                    requirePayment = true;
                }
                //--------------------------------- add items---
                else if (itemLoader.Items.TryGetValue(input, out var item))
                {
                    selectItemList.Add(item);
                }
                else
                {
                    System.Console.WriteLine("Thats not a valid option");
                }

                System.Console.Clear();
            }
            while (!requirePayment);

            System.Console.Clear();

            //--------------------------------- Process Payment ---
            string paymentOption;
            decimal total = selectItemList.Sum(x => x.Price);
            IPaymentMethod paymentMethod = null;

            // receive payment
            do
            {
                System.Console.WriteLine($"Items Selected:");

                //----- display items
                foreach (var item in selectItemList)
                {
                    System.Console.WriteLine(item.Description);
                }

                System.Console.WriteLine();
                System.Console.WriteLine($"Current total: {total}");

                System.Console.WriteLine("Select Payment Method");

                //----- display payment methods
                foreach (var currentPaymentMethod in paymentMethodsLoader.PaymentMethods)
                {
                    System.Console.WriteLine($"{currentPaymentMethod.Key}) {currentPaymentMethod.Value.Description}");
                }

                System.Console.WriteLine();

                paymentOption = System.Console.ReadLine();

                if (paymentMethodsLoader.PaymentMethods.TryGetValue(paymentOption, out paymentMethod))
                {
                    break;
                }

                System.Console.Clear();
            }
            while (true);

            //-------------------------- here we pay
            paymentMethod.Pay(total);

            System.Console.WriteLine("Thank, have a good day :)");
        }
    }
}
