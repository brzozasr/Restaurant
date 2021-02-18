using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Restaurant.Clients;
using Restaurant.Menu;
using Restaurant.Order;
using Restaurant.Utilities;

namespace Restaurant
{
    public class Restaurant
    {
        public int Width { get; }
        public List<IMenu> Menu { get; }
        public double Income { get; private set; }
        public int NoClientsServed { get; private set; }
        public StringBuilder CurrentClientsOrders { get; private set; }
        public Queue<ClientRestaurant> ClientsQueue { get; }
        public ClientRestaurant[,] SittingClients { get; }

        public Restaurant(int width, List<IMenu> menu)
        {
            Width = width;
            Menu = menu;
            SittingClients = new ClientRestaurant[Width, Width];
            ClientsQueue = new Queue<ClientRestaurant>();
            CurrentClientsOrders = new StringBuilder();
        }

        public void Update()
        {
            CurrentClientsOrders.Clear();
            GenerateClients();
            GetClientsInside();
            UpdateClientLeftTime();
        }

        private void UpdateClientLeftTime()
        {
            for (int i = 0; i < SittingClients.GetLength(0); i++)
            {
                for (int j = 0; j < SittingClients.GetLength(1); j++)
                {
                    if (SittingClients[i, j] != null && SittingClients[i, j].Position != null)
                    {
                        SittingClients[i, j].CountTime(5);

                        if (SittingClients[i, j].LeftTimeInRestaurantInMin <= 0)
                        {
                            SittingClients[i, j].LeaveRestaurant();
                            SittingClients[i, j] = null;
                        }
                    }
                    else
                    {
                        SittingClients[i, j] = null;
                    }
                }
            }
        }

        private void GenerateClients()
        {
            var noClients = Utility.Random.Next(3, 12);

            for (int i = 0; i < noClients; i++)
            {
                var client = ClientFactory.Create();
                ClientsQueue.Enqueue(client);
            }
        }

        private void GetClientsInside()
        {
            for (int i = 0; i < SittingClients.GetLength(0); i++)
            {
                for (int j = 0; j < SittingClients.GetLength(1); j++)
                {
                    if (SittingClients[i, j] == null && ClientsQueue.Count > 0)
                    {
                        var client = ClientsQueue.Dequeue();
                        client.SetTablePosition(i, j);
                        NoClientsServed += 1;
                        ClientOrder order = client.PlaceAnOrder(Menu);
                        double spendMony = 0;
                        
                        CurrentClientsOrders.Append($"No: {NoClientsServed}, table no: {i}-{j}, ");

                        foreach (var item in order.OrderedItems)
                        {
                            Income += item.Price;
                            spendMony += item.Price;

                            CurrentClientsOrders.Append($"{item.ItemName}-{item.Price:0.00}, ");
                        }
                        CurrentClientsOrders.Append($"money in wallet: {client.AmountOfMany:0.00}, money spent: {spendMony:0.00}, ");
                        
                        client.Buy(spendMony);
                        
                        CurrentClientsOrders.Append($"left many: {client.AmountOfMany:0.00}.\n");
                        
                        SittingClients[i, j] = client;

                        if (ClientsQueue.Count == 0)
                        {
                            break;
                        }
                    }
                }

                if (ClientsQueue.Count == 0)
                {
                    break;
                }
            }
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
                            sb.Append($"| {SittingClients[i, j].LeftTimeInRestaurantInMin}");
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