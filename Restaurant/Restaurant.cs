using System.Collections.Generic;
using System.Linq;
using Restaurant.Client;
using Restaurant.Menu;

namespace Restaurant
{
    public class Restaurant
    {
        public int Width { get; }
        public List<IMenu> Menu { get; }
        public double Income { get; private set; }
        public Queue<ClientRestaurant> ClientsQueue { get; private set; }
        public List<ClientRestaurant> ClientsInside { get; private set; }

        public Restaurant(int width, List<IMenu> menu)
        {
            Width = width;
            Menu = menu;
        }
    }
}