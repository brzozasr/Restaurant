using System;

namespace Restaurant.Menu
{
    public class Pizza : IMenu
    {
        public Enum ItemName { get; }
        public double Price { get; }
        
        public Pizza(PizzaType itemName, double price)
        {
            ItemName = itemName;
            Price = price;
        }
    }
}