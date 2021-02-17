using System.Collections.Generic;
using Restaurant.Menu;
using Restaurant.Order;

namespace Restaurant.Client
{
    public class Client : ClientRestaurant
    {
        public override ClientOrder PlaceAnOrder(IEnumerable<IMenu> menu)
        {
            throw new System.NotImplementedException();
        }

        public override void Buy(double price)
        {
            AmountOfMany -= price;
        }

        public override void CountTime(int elapsedMin)
        {
            TimeInRestaurantInMin -= elapsedMin;
        }
    }
}