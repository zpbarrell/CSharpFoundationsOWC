using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomodoGreenPlan.Repository
{
    public class CarRepository
    {
        //Empty Constructor
        Cars myCars = new Cars();
        //Database
        List<Cars> _carDB = new List<Cars>();
        //Methods to be used in CRUD
        public void AddCarToDatabase(Cars car)
        {
            _carDB.Add(car);
        }
        //READ
        public List<Cars> GetAllCars()
        {
            return _carDB;
        }

        public List<Cars> GetCarByCarType(string userInput)
        {
            List<Cars> carList = new List<Cars>();

            foreach (Cars x in _carDB)
            {
                string carType = x.CarType.ToString();
                if (carType == userInput)
                {
                    carList.Add(x);
                }
            }
            return carList;
        }
        //Update

        //Delete
        public bool DeleteCarFromDatabase(Cars car)
        {
            int totalCarsinDB = _carDB.Count();
            _carDB.Remove(car);
            if (totalCarsinDB == _carDB.Count())
            {
                return false;
            }
            return true;
        }

        //Main menu
        public void PrintMainMenu()
        {
            Console.WriteLine("1. New Vehicle Entry.\n" + "2. View All Vehicles.\n" + "3.View Vehicles By Engine Type\n" + "4. Update A Vehicle.\n" + "5. Delete A Vehicle");
        }
        //New Vehicle Entry
        //Veiw All
        //Veiw by Car Type
        //Gas
        //Hybrid
        //Electric
        //Update a vehicle
        //Delete a Vehicle
        public string GetUserInput()
        {
            return Console.ReadLine();
        }

        //Seed Data Method
        public void SeedCarData()
        {
            Cars tesla = new Cars("Tesla", "Model S", CarType.Electric);
            Cars rivian = new Cars("Rivian", "R1T", CarType.Electric);
            Cars audi = new Cars("Audi", "e-tron", CarType.Electric);
            Cars ford = new Cars("Ford", "Bronco", CarType.Gas);
            Cars honda = new Cars("Honda", "Insight", CarType.Hybrid);

            Cars[] carArr = { tesla, rivian, audi, ford, honda };

            foreach (Cars x in carArr)
            {
                AddCarToDatabase(x);
            }
        }
    }
}