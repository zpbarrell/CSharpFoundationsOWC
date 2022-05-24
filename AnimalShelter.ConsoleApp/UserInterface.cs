using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalShelter.Repository;

namespace AnimalShelter.ConsoleApp
{
    public class UserInterface
    {
        //FIELDS

        //bool isRunning for our WHILE LOOP
        private bool isRunning = true;
        //new up instance of REPO class stored in a variable
        AnimalRepository _repo = new AnimalRepository();

        //METHODS
        //run
        public void Run()
        {
            _repo.SeedAnimalData();

            while (isRunning)
            {
                PrintMainMenu();

                string input = GetUserInput();

                //UserInputSwitchCase(input);
            }

        }
        //PrintMainMenu
        private void PrintMainMenu()
        {
            Console.WriteLine(" ");
        }
        //GetUserInput
        private string GetUserInput()
        {
            return Console.ReadLine();
        }
        //CRUD methods in the context of UI

    }
}