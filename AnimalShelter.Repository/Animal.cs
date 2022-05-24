using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//OBJECT
namespace AnimalShelter.Repository
{
    public class Animal
    {
        //PROPERTIES
        public string AnimalName { get; set; }
        public DietType TypeOfDiet { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        //CONSTRUCTORS
        // FULL
        public Animal(string animalName, DietType typeOfDiet, int age, string species)
        {
            AnimalName = animalName;
            TypeOfDiet = typeOfDiet;
            Age = age;
            Species = species;
        }
        // Empty
        public Animal() {}
    }
    //ENUMS
    public enum DietType { Herbivore, Omnivore, Carnivore }
}