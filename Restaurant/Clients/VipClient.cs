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
            AmountOfMany = Utilities.Utility.Random.DoubleGenerator(300.0, 600.0);
        }

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

        public override void SetTablePosition(int x, int y)
        {
            Position = new TablePosition(x, y);
        }
    }
}