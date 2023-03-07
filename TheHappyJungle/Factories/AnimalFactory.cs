using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Factories.Interfaces;
using TheHappyJungle.Models.Foods;
using TheHappyJungle.Models.Interfaces;

namespace TheHappyJungle.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string[] animalTokens)
        {
            throw new NotImplementedException();
        }

        public IFood CreateFood(string type, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
