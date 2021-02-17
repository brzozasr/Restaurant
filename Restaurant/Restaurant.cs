using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Restaurant.Clients;
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
        public ClientRestaurant[,] SittingClients { get; private set; }

        public Restaurant(int width, List<IMenu> menu)
        {
            Width = width;
            Menu = menu;
            SittingClients = new ClientRestaurant[Width, Width];
        }

        public void Display()
        {
            StringBuilder sb = new StringBuilder();

            string line = string.Join("+--", new string[SittingClients.GetLength(0) + 1]);
            sb.Append($"{line}+\n");
            for (int i = 0; i < SittingClients.GetLength(0); i++)
            {
                for (int j = 0; j < SittingClients.GetLength(1); j++)
                {
                    if (SittingClients[i, j] != null)
                    {
                        var timeMin = SittingClients[i, j].LeftTimeInRestaurantInMin;
                        if (timeMin.ToString().Length == 1)
                        {
                            sb.Append($"|{ SittingClients[i, j].LeftTimeInRestaurantInMin}");
                        }
                        else
                        {
                            sb.Append($"|{SittingClients[i, j].LeftTimeInRestaurantInMin}");
                        }
                    }
                    else
                    {
                        sb.Append($"|  ");
                    }
                }
                sb.Append("|\n");
            }
            sb.Append($"{line}+\n");
            Console.Write(sb);
        }
    }
}