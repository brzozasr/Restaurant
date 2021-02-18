using System;
using System.Collections.Generic;
using Restaurant.Menu;
using Restaurant.Order;
using Restaurant.Utilities;

namespace Restaurant.Clients
{
    public class Client : ClientRestaurant, IDisposable
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

        public override void LeaveRestaurant()
        {
            if (LeftTimeInRestaurantInMin <= 0)
            {
                Position = null;
                Dispose();
            }
        }

        ~Client()
        {
            ReleaseUnmanagedResources();
        }

        private void ReleaseUnmanagedResources()
        {
            // TODO release unmanaged resources here
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }
    }
}