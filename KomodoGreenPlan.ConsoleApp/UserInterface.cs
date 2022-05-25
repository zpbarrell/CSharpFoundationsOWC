using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomodoGreenPlan.CarRepository;

namespace KomodoGreenPlan.ConsoleApp
{
    public class UserInterface
    {
        //field
        Repository _repo = new Repository();
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
                    ViewAllVehicles();
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
        //Create
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
        //Read
        private void ViewAllVehicles()
        {
            List<Cars> allCars = _repo.GetAllCars();
            // Console.WriteLine($"{allCars}");
            PrintCars(allCars);
        }
        private void PrintCars(List<Cars> car)
        {
            foreach (Cars x in car)
            {
                PrintCar(x);
            }
        }
        private void PrintCar(Cars car)
        {
            Console.WriteLine($"Make: {car.Make}\n" +
                             $"Model: {car.Model}\n" +
                             $"Engine Type: {car.CarType}\n");

        }

        //Helpers
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
            }

        }
    }
}