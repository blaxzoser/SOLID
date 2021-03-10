using System.Collections.Generic;
using System.IO;

namespace LittleStoreSOLID
{
    public class ItemLoader
    {
        public Dictionary<string, Item> Items { get; } = new Dictionary<string, Item>();

        public void Load()
        {
            var lines  = File.ReadAllLines("items.txt");

            var index = 'a';

            foreach (var line in lines)
            {
                var segment = line.Split(' ');
                Items[index.ToString()] = new Item(segment[0], decimal.Parse(segment[1]));
                index++;
            }

            Items[index.ToString()] = new Item("Go to payment", 0.00m);
        }
    }
}
