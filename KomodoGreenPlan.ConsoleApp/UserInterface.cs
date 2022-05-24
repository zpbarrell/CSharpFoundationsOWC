using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomodoGreenPlan.Repository;

namespace KomodoGreenPlan.ConsoleApp
{
    public class UserInterface
    {
        //field
        CarRepository _repo = new CarRepository();
        bool isRunning = true;
        public void Run()
        {
            _repo.SeedCarData();
            while (isRunning)
            {
                _repo.PrintMainMenu();
                string userInput = _repo.GetUserInput();
                UserInputSwitch(userInput);
            }
        }
        private void UserInputSwitch(string userInput)
        {
            switch(userInput)
            {
                case "1":
                    CreateNewVehicle();
                    break;
                case "2":
                    //ViewAllVehicles
                    _repo.GetAllCars();
                    break;
                case "3":
                    //ViewVehiclesByEngineType
                    //_repo.GetCarByCarType();
                    break;
                case "4":
                    //UpdateAVehicle();
                    break;
                case "5":
                    //DeleteAVehicle
                    //_repo.DeleteCarFromDatabase();
                    break;
                default:
                    //InvalidEntry();
                    break;
            }
        }
        private void CreateNewVehicle()
        {
            Console.Write("Enter Make of car: ");
            string carMake = _repo.GetUserInput();

            Console.Write("Enter Model of car: ");
            string carModel = _repo.GetUserInput();

            Console.Write("Select Engine Type.\n" +
            "1. Gas\n" + "2. Hybrid\n" + "3. Electric\n");
            string engineSelection = _repo.GetUserInput();

            CarType? engineType = EngineSelection(engineSelection);

            Cars newCar = new Cars(carMake, carModel, engineType);
            _repo.AddCarToDatabase(newCar);

        }
        private CarType? EngineSelection(string engineSelection)
        {
            switch(engineSelection)
            {
                case "1":
                    return CarType.Gas;
                case "2":
                    return CarType.Hybrid;
                case "3":
                    return CarType.Electric;
                default:
                    return null;
                    break;
            }

        }
    }
}