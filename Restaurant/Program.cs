using System;
using Restaurant.Clients;
using Restaurant.Menu;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = SingletonMenu.Create();

            foreach (var item in menu)
            {
                Console.WriteLine($"Name: {item.ItemName} - {item.Price} zł");
            }
        }
    }
}