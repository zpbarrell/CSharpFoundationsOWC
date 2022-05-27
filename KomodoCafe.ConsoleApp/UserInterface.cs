using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomodoCafe.Repository;

namespace KomodoCafe.ConsoleApp
{
    public class UserInterface
    {
        MenuRepository _menuRepo = new MenuRepository();
        public void Run()
        {
            _menuRepo.SeedMenuData();
            _menuRepo.PrintMenu();
            string input = _menuRepo.GetUserInput();
            UserInputSwitchCase(input);
        }
        private void UserInputSwitchCase(string input)
        {
            switch(input)
            {
                case "1":
                CreateNewOrder();
                    break;
                case "2":
                _menuRepo.PrintAllOrders();
                    break;
                case "3":
                //DeleteExistingOrderByOrderNumber
                    break;
                default:
                    break;
            }
        }
        private void CreateNewOrder()
        {
            Console.WriteLine("Please enter a name for your order: ");
            string orderName = _menuRepo.GetUserInput();
            Console.WriteLine("Would you like a:\n" + "1. Panini?\n" + "2. Salad?\n" + "3. Coffee?\n" + "4. A Combination?\n");
            string orderSelection = _menuRepo.GetUserInput();
            OrderSelectionSwitchCase(orderSelection);

            //PrintNewOrderNumber();
            // Menu newOrder = new Menu(mealNumber, mealName, panini, salad, coffeeDrink, price);
            // _menuRepo.AddOrderToDataBase(newOrder);

        }
            //HELPERS
        private void OrderSelectionSwitchCase(string orderSelection)
        {
            switch(orderSelection)
            {
                case "1": 
                    Console.WriteLine("Select a panini that sounds nice?\n" + "1. Tomato Basil\n" + "2. Roasted Red-Pepper\n" + "3. Turkey Bacon Tomato");
                    string paniniSelection = _menuRepo.GetUserInput();
                    PaniniSelectionSwitchCase(paniniSelection);
                    break; 
                case "2":
                    Console.WriteLine("What type of salad would you prefer?\n" + "1. Cobb Salad\n" + "2. Summer Ceasar Salad\n");
                    string saladSelection = _menuRepo.GetUserInput();
                    SaladSelectionSwitchCase(saladSelection);
                    break;
                case "3":
                    Console.WriteLine("Ok, What type of Coffee drink would you like?\n" + "1. An Americano\n" + "2. Steaming Cup Of Maxwell House\n" + "3. Latte\n" + "4. Mocha Latte\n");
                    string coffeeSelection = _menuRepo.GetUserInput();
                    CoffeeSelectionSwitchCase(coffeeSelection);
                    break;
                case "4": 
                    Console.WriteLine("No Combos Here, Check Back soon!");
                    break;
                default:
                    Console.Write("You have successfully broken the app because I havent setup invalid entry handling");
                    break;
            }
        }
        private Panini? PaniniSelectionSwitchCase(string paniniSelection)
        {
            switch(paniniSelection)
            {
                case "1":
                    //Console.Write()ingrediants switch case
                    return Panini.TomatoBasil;
                case "2":
                    //Console.Write()ingrediants switch case
                    return Panini.RoastedRedPepper;
                case "3":
                    //Console.Write()ingrediants switch case
                    return Panini.TurkeyBacon;
                default:
                    return null;
                    break;
            }
        }
        private Salad? SaladSelectionSwitchCase(string saladSelection)
        {
            switch(saladSelection)
            {
                case "1":
                    return Salad.Cobb;
                case "2":
                    return Salad.Ceasar;
                default:
                    return null;
                    break;
                
            }
        }
        private CoffeeDrink? CoffeeSelectionSwitchCase(string coffeeSelection)
        {
            switch(coffeeSelection)
            {
                case "1": 
                    return CoffeeDrink.Americano;
                case "2":
                    return CoffeeDrink.Drip;
                case "3":
                    return CoffeeDrink.Latte;
                case "4":
                    return CoffeeDrink.MochaLatte;
                default:
                    return null;
                    break;
            }
        }
    }
}