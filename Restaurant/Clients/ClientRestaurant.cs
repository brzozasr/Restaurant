using System;
using System.Collections.Generic;
using System.Linq;
using Restaurant.Menu;
using Restaurant.Order;
using Restaurant.Utilities;

namespace Restaurant.Clients
{
    public abstract class ClientRestaurant
    {
        public double AmountOfMany { get; protected set; }
        public int LeftTimeInRestaurantInMin { get; protected set; }
        public TablePosition Position { get; protected set; }

        public ClientRestaurant()
        {
            AmountOfMany = Utility.Random.DoubleGenerator(50.0, 150.0);
            LeftTimeInRestaurantInMin = Utility.Random.Next(15, 61);
        }
        
        public abstract void Buy(double price);

        public abstract void CountTime(int elapsedMin);

        public abstract void SetTablePosition(int x, int y);

        public ClientOrder PlaceAnOrder(List<IMenu> menu)
        {
            ClientOrder clientOrder = new ClientOrder();

            List<int> tmpOrderNo = new List<int>();

            int i = 0;
            int clientTryToChoose = 9;
            double clientOrderValue = 0;
            
            while (i < clientTryToChoose && clientOrderValue <= AmountOfMany)
            {
                var menuItem = Utility.Random.Next(0, menu.Count);

                if (clientOrderValue + menu[menuItem].Price <= AmountOfMany && !tmpOrderNo.Contains(menuItem))
                {
                    clientOrderValue += menu[menuItem].Price;
                    clientOrder.OrderedItems.Add(menu[menuItem]);
                    tmpOrderNo.Add(menuItem);
                }
                
                i++;
            }

            return clientOrder;
        }
    }
}