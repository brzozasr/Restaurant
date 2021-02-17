using System.Collections.Generic;
using Restaurant.Menu;
using Restaurant.Order;
using Restaurant.Utilities;

namespace Restaurant.Clients
{
    public class VipClient : ClientRestaurant
    {
        public VipClient()
        {
            AmountOfMany = Utilities.Utility.Random.DoubleGenerator(151.0, 300.0);
        }

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