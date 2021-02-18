using System;
using Restaurant.Utilities;

namespace Restaurant.Clients
{
    public static class ClientFactory
    {
        public static ClientRestaurant Create()
        {
            int clientNo = Utility.Random.Next(0, 6);

            switch (clientNo)
            {
                case 0:
                    return new Client();
                case 1:
                    return new Client();
                case 2:
                    return new Client();
                case 3:
                    return new Client();
                case 4:
                    return new Client();
                case 5:
                    return new VipClient();
                default:
                    throw new ArgumentException("The client with the given ID does not exist!");
            }
        }
    }
}