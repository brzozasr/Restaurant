using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Menu
{
    public sealed class SingletonMenu
    {
        private static readonly Lazy<SingletonMenu> 
            Menu = new Lazy<SingletonMenu>(() => new SingletonMenu());

        public static SingletonMenu Instance
        {
            get => Menu.Value;
        }

        private SingletonMenu()
        {
        }

        public static List<IMenu> Create()
        {
            List<IMenu> menuList = new List<IMenu>();

            foreach (PizzaType pizza in Enum.GetValues(typeof(PizzaType)))
            {
                menuList.Add(new Pizza(pizza, MenuPrice.GetPizzaPrice(pizza)));
            }

            foreach (BurgerType burger in Enum.GetValues(typeof(BurgerType)))
            {
                menuList.Add(new Burger(burger, MenuPrice.GetBurgerPrice(burger)));
            }

            foreach (PastaType pasta in Enum.GetValues(typeof(PastaType)))
            {
                menuList.Add(new Pasta(pasta, MenuPrice.GetPastPrice(pasta)));
            }

            foreach (SaladType salad in Enum.GetValues(typeof(SaladType)))
            {
                menuList.Add(new Salad(salad, MenuPrice.GetSaladPrice(salad)));
            }

            foreach (BeverageType beverage in Enum.GetValues(typeof(BeverageType)))
            {
                menuList.Add(new Beverage(beverage, MenuPrice.GetBeveragePrice(beverage)));
            }

            return menuList;
        }
    }
}