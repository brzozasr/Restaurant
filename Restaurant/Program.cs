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
            Restaurant restaurant = new Restaurant(9, menu);
            
            while (true)
            {
                Console.Clear();
                restaurant.Update();
                Console.WriteLine($"Clients waiting in queue: {restaurant.ClientsQueue.Count}");
                Console.WriteLine($"Restaurant income: {restaurant.Income:0.00}");
                Console.WriteLine($"Number of clients served: {restaurant.NoClientsServed}");
                Console.WriteLine($"Average amount spent by the client: {restaurant.Income / restaurant.NoClientsServed:0.00}");
                restaurant.Display();
                Console.Write(restaurant.CurrentClientsOrders);
                Console.ReadKey();
            }
        }
    }
}