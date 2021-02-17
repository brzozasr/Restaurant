using System;
using Restaurant.Utilities;

namespace Restaurant.Menu
{
    public class Beverage : IMenu
    {
        public Enum ItemName { get; }
        public double Price { get; }

        public Beverage(BeverageType itemName, double price)
        {
            ItemName = itemName;
            Price = price;
        }
    }
}