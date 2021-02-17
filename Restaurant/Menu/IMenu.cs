using System;

namespace Restaurant.Menu
{
    public interface IMenu
    {
        Enum ItemName { get; }
        double Price { get; }
    }
}