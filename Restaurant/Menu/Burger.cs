using System;
using Restaurant.Utilities;

namespace Restaurant.Menu
{
    public class Burger : IMenu
    {
        public Enum ItemName { get; }
        public double Price { get; }

        public Burger(BurgerType itemName, double price)
        {
            ItemName = itemName;
            Price = price;
        }
    }
}