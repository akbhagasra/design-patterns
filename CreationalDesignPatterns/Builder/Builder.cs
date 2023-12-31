using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.BuilderSpace
{
    public class Wrapper: IPacking
    {
        public string pack()
        {
            return "Wrapper";
        }
    }
    public class Bottle: IPacking
    {
        public string pack()
        {
            return "Bottle";
        }
    }
    public abstract class Burger : IFoodItem
    {
        public abstract string name();
        public IPacking packing()
        {
            return new Wrapper();
        }
        public abstract float price();
    }
    public abstract class ColdDrink : IFoodItem
    {
        public abstract string name();
        public IPacking packing()
        {
            return new Bottle();
        }
        public abstract float price();
    }
    public class VegBurger : Burger
    {
        public override string name()
        {
            return "Veg Burger";
        }

        public override float price()
        {
            return 80f;
        }
    }
    public class NonVegBurger : Burger
    {
        public override string name()
        {
            return "Non-Veg Burger";
        }

        public override float price()
        {
            return 95f;
        }
    }
    public class Coke : ColdDrink
    {
        public override string name()
        {
            return "Coke";
        }

        public override float price()
        {
            return 20f;
        }
    }
    public class Pepsi : ColdDrink
    {
        public override string name()
        {
            return "Pepsi";
        }

        public override float price()
        {
            return 25f;
        }
    }
    public class Meal
    {
        private List<IFoodItem> items = new List<IFoodItem>();

        public void additem(IFoodItem item)
        {
            items.Add(item);
        }
        public float getCost()
        {
            float cost = 0.0f;
            foreach (IFoodItem i in items){
                cost += i.price();
            }
            return cost;
        }

        public void showMeal()
        {
            int cur = 1;
            foreach(IFoodItem i in items)
            {
                Console.Write($"{cur}.");
                Console.Write($" Item: {i.name()}");
                Console.Write($", Packing: {i.packing().pack()}");
                Console.Write($", Price: {i.price()}");
                Console.WriteLine();
                cur++;
            }
        }
    }
    public class MealBuilder
    {
        public static Meal prepareVegMeal()
        {
            Meal meal = new Meal();
            meal.additem(new VegBurger());
            meal.additem(new Coke());
            return meal;
        }
        public static Meal prepareNonVegMeal()
        {
            Meal meal = new Meal();
            meal.additem(new NonVegBurger());
            meal.additem(new Pepsi());
            return meal;
        }
    }
}
