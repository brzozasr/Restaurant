using System.Collections.Generic;
using Restaurant.Menu;
using Restaurant.Order;
using Restaurant.Utilities;

namespace Restaurant.Clients
{
    public abstract class ClientRestaurant
    {
        public double AmountOfMany { get; protected set; }
        public int TimeInRestaurantInMin { get; protected set; }
        public TablePosition Position { get; protected set; }

        public ClientRestaurant()
        {
            AmountOfMany = Utilities.Utility.Random.DoubleGenerator(50.0, 300.0);
            TimeInRestaurantInMin = Utilities.Utility.Random.Next(15, 61);
        }

        public abstract ClientOrder PlaceAnOrder(IEnumerable<IMenu> menu);

        public abstract void Buy(double price);

        public abstract void CountTime(int elapsedMin);

        public abstract void SetTablePosition(int x, int y);
    }
}