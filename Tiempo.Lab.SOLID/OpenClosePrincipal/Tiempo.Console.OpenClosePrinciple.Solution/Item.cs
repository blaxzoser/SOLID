namespace LittleStoreSOLID
{
    public class Item
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