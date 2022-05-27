using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomodoCafe.Repository
{
    public class MenuRepository
    {
        public MenuRepository(){}

        List<Menu> _menuDB = new List<Menu>();
        //CRUD
        public void AddOrderToDataBase(Menu menu)
        {
            _menuDB.Add(menu);
        }
        public List<Menu> PrintAllOrders()
        {
            return _menuDB;
        }
        // public bool DeleteExistingOrderByOrderNumber(Menu menu)
        // {

        // }

        //Menu
        public void PrintMenu()
        {
            Console.WriteLine("1. Start New Order\n" + "2. Show All Existing Orders\n" + "3. Delete Existing Order By Order Number");
        }
        public string GetUserInput()
        {
            return Console.ReadLine();
        }

        public void SeedMenuData()
        {
            Menu[] menuArr = {};

            foreach(Menu x in menuArr)
            {
                AddOrderToDataBase(x);
            }
        }

    }
}