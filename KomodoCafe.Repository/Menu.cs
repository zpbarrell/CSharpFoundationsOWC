using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomodoCafe.Repository
{
    public class Menu
    {
        //Properties
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public Panini? Panini { get; set; }
        public Salad? Salad { get; set; }
        public CoffeeDrink? CoffeeDrink { get; set; }
        public Decimal Price { get; set; }

        public Menu(int mealNumber, string mealName, Panini panini, Salad salad, CoffeeDrink coffeeDrink, Decimal price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Panini = panini;
            Salad = salad;
            CoffeeDrink = coffeeDrink;
            Price = price;
        }
        public Menu(){}

    }
    public enum Panini { TomatoBasil, RoastedRedPepper, TurkeyBacon }
    public enum Salad { Cobb, Ceasar }
    public enum CoffeeDrink { Americano, Drip, Latte, MochaLatte }
}