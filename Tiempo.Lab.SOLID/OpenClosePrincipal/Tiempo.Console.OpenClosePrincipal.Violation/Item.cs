using System;
using System.Collections.Generic;
using System.Text;

namespace Tiempo.Console.OpenClosePrinciple.Violation
{
    internal class Item
    {
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Item(string description, decimal price)
        {
            Description = description;
            Price = price;
        }
    }
}
