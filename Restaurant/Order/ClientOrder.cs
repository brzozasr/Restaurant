using System.Collections.Generic;
using Restaurant.Menu;

namespace Restaurant.Order
{
    public class ClientOrder
    {
        public List<IMenu> OrderedItems { get; set; } = new List<IMenu>();
    }
}