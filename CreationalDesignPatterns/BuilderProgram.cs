using CreationalDesignPatterns.BuilderSpace;
using CreationalDesignPatterns.PrototypeSpace;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    internal class BuilderProgram
    {
        public static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("Builder demo started");
            Console.WriteLine();

            Meal veg_meal = MealBuilder.prepareVegMeal();
            Meal nonveg_meal = MealBuilder.prepareNonVegMeal();

            Console.WriteLine("Veg Meal");
            veg_meal.showMeal();
            Console.WriteLine();

            Console.WriteLine("Non-veg Meal");
            nonveg_meal.showMeal();
            
            Console.WriteLine();
            Console.WriteLine("Builder demo ended");
            Console.ReadKey();
        }
    }
}
