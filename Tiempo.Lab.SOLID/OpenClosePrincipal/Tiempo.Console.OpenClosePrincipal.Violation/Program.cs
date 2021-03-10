using System;
using System.Collections.Generic;
using System.Linq;

namespace Tiempo.Console.OpenClosePrinciple.Violation
{
    class Program
    {
        static void Main(string[] args)
        {
            var itemList = new List<Item>();

            var requirePayment = false;

            // to show the items
            do
            {
                System.Console.WriteLine($"Current total: {itemList.Sum(x => x.Price):c}");

               System.Console.WriteLine("Hello User");
               System.Console.WriteLine("Item List");
               System.Console.WriteLine("a) Milk");
               System.Console.WriteLine("b) Bread");
               System.Console.WriteLine("c) Eggs");
               System.Console.WriteLine("d) Oil");
               System.Console.WriteLine("e) Sugar");
               System.Console.WriteLine("f) Go to playment");

               System.Console.WriteLine("Select Option: ");

                var input = System.Console.ReadLine();

                switch (input)
                {
                    case "a":
                        itemList.Add(new Item("Milk", 20.00m));
                        break;
                    case "b":
                        itemList.Add(new Item("Bread", 30.00m));
                        break;
                    case "c":
                        itemList.Add(new Item("Eggs", 25.00m));
                        break;
                    case "d":
                        itemList.Add(new Item("Oil", 10.00m));
                        break;
                    case "e":
                        itemList.Add(new Item("Sugar", 5.00m));
                        break;
                    case "f":
                        requirePayment = true;
                        break;
                    default:
                       System.Console.WriteLine("Thats not a valid option");
                        break;
                }

                System.Console.Clear();
            }
            while (!requirePayment);

            System.Console.Clear();

            string paymentOption;
            decimal total = itemList.Sum(x => x.Price);

            // receive payment
            do
            {
               System.Console.WriteLine($"Items Selected:");

                foreach (var item in itemList)
                {
                   System.Console.WriteLine(item.Description);
                }

               System.Console.WriteLine($"Current total: {total}");

               System.Console.WriteLine("Select Payment Method");


               System.Console.WriteLine("a) Cash");
               System.Console.WriteLine("b) Credit Card");
               System.Console.WriteLine("c) Gift Card");
               System.Console.WriteLine();

                paymentOption = System.Console.ReadLine();

                var paymentOptions = new List<string> { "a", "b", "c" };
                if (paymentOptions.Contains(paymentOption))
                {
                    break;
                }

                System.Console.Clear();
            }
            while (true);

            switch (paymentOption)
            {
                case "a": // Cash

                    do
                    {
                       System.Console.WriteLine("type the exact amount");
                        var amountReceivedText = System.Console.ReadLine();

                        if (decimal.TryParse(amountReceivedText, out var amountReceived))
                        {
                            if (amountReceived == total)
                            {
                                break;
                            }
                            else
                            {
                                System.Console.Clear();
                            }
                        }
                    } while (true);


                    break;
                case "b":

                   System.Console.WriteLine("type the credit card number");
                    var creditCardNumber = System.Console.ReadLine();
                    //Some fancy validation
                   System.Console.WriteLine("credit card accepted");

                    break;

                case "c":
                   System.Console.WriteLine("type the gift card number");
                    var giftNumber = System.Console.ReadLine();
                    //Some fancy validation
                   System.Console.WriteLine("gift card accepted");

                    break;
            }

           System.Console.WriteLine("Thank, have a good day :)");
        }
    }
}
