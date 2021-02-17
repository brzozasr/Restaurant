using System.Collections.Generic;
using Restaurant.Menu;
using Restaurant.Order;

namespace Restaurant.Client
{
    public abstract class ClientRestaurant
    {
        public double AmountOfMany { get; protected set; }
        public int TimeInRestaurantInMin { get; protected set; }

        public ClientRestaurant()
        {
            AmountOfMany = Utilities.Random.DoubleGenerator(50.0, 300.0);
            TimeInRestaurantInMin = Utilities.Random.Next(15, 61);
        }

        public abstract ClientOrder PlaceAnOrder(IEnumerable<IMenu> menu);

        public abstract void Buy(double price);

        public abstract void CountTime(int elapsedMin);
    }
}