using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Repository
{
    public class AnimalRepository
    {
        // FAKE DATABASE
        private List<Animal> _animalListDB = new List<Animal>(); //FIELD

        // CRUD METHODS

        // CREATE
        // CreateAnimal
        public void AddAnimalToDataBase(Animal animal)
        {
            _animalListDB.Add(animal);
        }

        // READ
        //GetAllAnimals
        //GetAnimlas

        //UPDATE
        //update
        //updateAnimal

        //DELETE
        //DeleteAnimal

        // SEED DATA
        public void SeedAnimalData();
        {
            Animal tucker = new Animal("Tucker", DietType.Carnivore, 1, "Dog");
            Animal zelda = new Animal("Zelda", DietType.Carnivore, 3, "Cat");
            Animal finn = new Animal("Finn", DietType.Carnivore, 1, "Ghost Mantis");

            Animal[] animalArr = { tucker, zelda, finn, };

            foreach (Animal x in animalArr)
            {
                AddAnimalToDataBase(x);
            }
        }
    }
}