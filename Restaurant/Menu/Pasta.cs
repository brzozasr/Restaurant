using System;
using Restaurant.Utilities;

namespace Restaurant.Menu
{
    public class Pasta : IMenu
    {
        public Enum ItemName { get; }
        public double Price { get; }

        public Pasta(PastaType itemName, double price)
        {
            ItemName = itemName;
            Price = price;
        }
    }
}