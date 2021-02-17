using System;
using Restaurant.Utilities;

namespace Restaurant.Menu
{
    public static class MenuFactory
    {
        private static IMenu PizzaFactory()
        {
            int pizzaCount = Enum.GetNames(typeof(PizzaType)).Length;

            int pizzaNo = Utilities.Utility.Random.Next(0, pizzaCount);
            
            switch (pizzaNo)
            {
                case (int) PizzaType.Margherita:
                    return new Pizza(PizzaType.Margherita, 27.45);
                
                case (int) PizzaType.Hawaiian:
                    return new Pizza(PizzaType.Hawaiian, 29.99);
                
                case (int) PizzaType.Farmhouse:
                    return new Pizza(PizzaType.Farmhouse, 31.5);
                
                case (int) PizzaType.Capricciosa:
                    return new Pizza(PizzaType.Capricciosa, 32.25);
                
                case (int) PizzaType.Carbonara:
                    return new Pizza(PizzaType.Carbonara, 32.99);
                
                case (int) PizzaType.NewYorker:
                    return new Pizza(PizzaType.NewYorker, 33.75);
                
                default:
                    throw new ArgumentException("This type of pizza is not on our menu!");
            }
        }

        private static IMenu BurgerFactory()
        {
            int burgerCount = Enum.GetNames(typeof(BurgerType)).Length;

            int burgerNo = Utilities.Utility.Random.Next(0, burgerCount);

            switch (burgerNo)
            {
                case (int) BurgerType.Hamburger:
                    return new Burger(BurgerType.Hamburger, 25.00);
                
                case (int) BurgerType.Cheeseburger:
                    return new Burger(BurgerType.Cheeseburger, 27.45);
                
                case (int) BurgerType.BigBurger:
                    return new Burger(BurgerType.BigBurger, 29.50);
                
                case (int) BurgerType.MegaBurger:
                    return new Burger(BurgerType.MegaBurger, 31.85);
                
                case (int) BurgerType.DoubleMeatBurger:
                    return new Burger(BurgerType.DoubleMeatBurger, 36.99);
                
                default:
                    throw new ArgumentException("This type of burger is not on our menu!");
            }
        }

        private static IMenu PastaFactory()
        {
            int pastaCount = Enum.GetNames(typeof(PastaType)).Length;

            int pastaNo = Utilities.Utility.Random.Next(0, pastaCount);

            switch (pastaNo)
            {
                case (int) PastaType.SpaghettiBolognese:
                    return new Pasta(PastaType.SpaghettiBolognese, 27.55);
                
                case (int) PastaType.SpaghettiCarbonara:
                    return new Pasta(PastaType.SpaghettiCarbonara, 29.15);
                
                case (int) PastaType.SpaghettiPomodoro:
                    return new Pasta(PastaType.SpaghettiPomodoro, 30.00);
                
                case (int) PastaType.RavioliDiRicotta:
                    return new Pasta(PastaType.RavioliDiRicotta, 32.65);
                
                case (int) PastaType.SpaghettiAlPesto:
                    return new Pasta(PastaType.SpaghettiAlPesto, 34.35);
                
                default:
                    throw new AggregateException("This type of pasta is not on our menu!");
            }
        }

        private static IMenu SaladFactory()
        {
            int saladCount = Enum.GetNames(typeof(SaladType)).Length;

            int saladNo = Utilities.Utility.Random.Next(0, saladCount);

            switch (saladNo)
            {
                case (int) SaladType.Greek:
                    return new Salad(SaladType.Greek, 22.50);
                
                case (int) SaladType.Caesar:
                    return new Salad(SaladType.Caesar, 23.75);
                
                case (int) SaladType.Garden:
                    return new Salad(SaladType.Garden, 24.10);
                
                case (int) SaladType.Chicken:
                    return new Salad(SaladType.Chicken, 25.99);
                
                case (int) SaladType.Seafood:
                    return new Salad(SaladType.Seafood, 29.95);
                
                default:
                    throw new ArgumentException("This type of salad is not on our menu!");
            }
        }

        private static IMenu BeverageFactory()
        {
            int beverageCount = Enum.GetNames(typeof(BeverageType)).Length;

            int beverageNo = Utilities.Utility.Random.Next(0, beverageCount);

            switch (beverageNo)
            {
                case (int) BeverageType.CocaCola:
                    return new Beverage(BeverageType.CocaCola, 9.50);
                
                case (int) BeverageType.Fanta:
                    return new Beverage(BeverageType.Fanta, 9.50);
                
                case (int) BeverageType.Sprite:
                    return new Beverage(BeverageType.Sprite, 9.50);
                
                case (int) BeverageType.Water:
                    return new Beverage(BeverageType.Water, 8.50);
                
                case (int) BeverageType.SparklingWater:
                    return new Beverage(BeverageType.SparklingWater, 8.50);
                
                case (int) BeverageType.Juice:
                    return new Beverage(BeverageType.Juice, 11.99);
                
                case (int) BeverageType.Beer:
                    return new Beverage(BeverageType.Beer, 15.50);
                
                default:
                    throw new ArgumentException("This type of beverage is not on our menu!");
            }
        }
    }
}