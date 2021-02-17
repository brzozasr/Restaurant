using System;
using Restaurant.Menu;

namespace Restaurant.Utilities
{
    public static class MenuPrice
    {
        public static double GetPizzaPrice(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Margherita:
                    return 27.45;
                
                case PizzaType.Hawaiian:
                    return 29.99;
                
                case PizzaType.Farmhouse:
                    return 31.5;
                
                case PizzaType.Capricciosa:
                    return 32.25;
                
                case PizzaType.Carbonara:
                    return 32.99;
                
                case PizzaType.NewYorker:
                    return 33.75;
                
                default:
                    throw new ArgumentException("This pizza's price is not on our menu!");
            }
        }

        public static double GetBurgerPrice(BurgerType burgerType)
        {
            switch (burgerType)
            {
                case BurgerType.Hamburger:
                    return 25.00;
                
                case BurgerType.Cheeseburger:
                    return 27.45;
                
                case BurgerType.BigBurger:
                    return 29.50;
                
                case BurgerType.MegaBurger:
                    return 31.85;
                
                case BurgerType.DoubleMeatBurger:
                    return 36.99;
                
                default:
                    throw new ArgumentException("This burger's price is not on our menu!");
            }
        }

        public static double GetPastPrice(PastaType pastaType)
        {
            switch (pastaType)
            {
                case PastaType.SpaghettiBolognese:
                    return 27.55;
                
                case PastaType.SpaghettiCarbonara:
                    return 29.15;
                
                case PastaType.SpaghettiPomodoro:
                    return 30.00;
                
                case PastaType.RavioliDiRicotta:
                    return 32.65;
                
                case PastaType.SpaghettiAlPesto:
                    return 34.35;
                
                default:
                    throw new AggregateException("This pasta's price is not on our menu!");
            }
        }

        public static double GetSaladPrice(SaladType saladType)
        {
            switch (saladType)
            {
                case SaladType.Greek:
                    return 22.50;
                
                case SaladType.Caesar:
                    return 23.75;
                
                case SaladType.Garden:
                    return 24.10;
                
                case SaladType.Chicken:
                    return 25.99;
                
                case SaladType.Seafood:
                    return 29.95;
                
                default:
                    throw new ArgumentException("This salad's price is not on our menu!");
            }
        }

        public static double GetBeveragePrice(BeverageType beverageType)
        {
            switch (beverageType)
            {
                case BeverageType.CocaCola:
                    return 9.50;
                
                case BeverageType.Fanta:
                    return 9.50;
                
                case BeverageType.Sprite:
                    return 9.50;
                
                case BeverageType.Water:
                    return 8.50;
                
                case BeverageType.SparklingWater:
                    return 8.50;
                
                case BeverageType.Juice:
                    return 11.99;
                
                case BeverageType.Beer:
                    return 15.50;
                
                default:
                    throw new ArgumentException("This beverage's price is not on our menu!");
            }
        }
    }
}