using System.Collections.Generic;
using Restaurant.Menu;
using Restaurant.Order;
using Restaurant.Utilities;

namespace Restaurant.Clients
{
    public class Client : ClientRestaurant
    {
        public override void Buy(double price)
        {
            AmountOfMany -= price;
        }

        public override void CountTime(int elapsedMin)
        {
            LeftTimeInRestaurantInMin -= elapsedMin;
        }

        public override void SetTablePosition(int x, int y)
        {
            Position = new TablePosition(x, y);
        }
    }
}