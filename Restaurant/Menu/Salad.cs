using System;

namespace Restaurant.Menu
{
    public class Salad : IMenu
    {
        public Enum ItemName { get; }
        public double Price { get; }

        public Salad(SaladType itemName, double price)
        {
            ItemName = itemName;
            Price = price;
        }
    }
}