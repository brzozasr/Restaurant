using System;
using System.Collections.Generic;
using Restaurant.Clients;
using Restaurant.Menu;
using Restaurant.Order;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMenu> menu = SingletonMenu.Create();
            Restaurant restaurant = new Restaurant(10, menu);

            ClientRestaurant c = new Client();

            ClientOrder co = c.PlaceAnOrder(menu);

            foreach (var item in co.OrderedItems)
            {
                Console.WriteLine($"{item.ItemName} {item.Price}");
            }
            
            restaurant.Display();
        }
    }
}