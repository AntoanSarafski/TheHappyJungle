using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Factories.Interfaces;
using TheHappyJungle.Models.Animals;
using TheHappyJungle.Models.Foods;
using TheHappyJungle.Models.Interfaces;

namespace TheHappyJungle.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string[] animalTokens)
        {
            string type = animalTokens[0];
            string name = animalTokens[1];
            double weight = double.Parse(animalTokens[2]);

            switch (type)
            {
                case "Hen":
                    return new Hen(name,weight,double.Parse(animalTokens[3]));

                case "Owl":
                    return new Owl(name, weight, double.Parse(animalTokens[3]));

                case "Mouse":
                    return new Mouse(name, weight, animalTokens[3]);

                case "Cat":
                    return new Cat(name, weight, animalTokens[3], animalTokens[4]);

                case "Dog":
                    return new Dog(name, weight, animalTokens[3]);

                case "Tiger":
                    return new Cat(name, weight, animalTokens[3], animalTokens[4]);

                default:
                    throw new ArgumentException("Invalid type of animal");
            }
        }

        public IFood CreateFood(string type, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
