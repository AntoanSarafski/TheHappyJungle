using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Core.Interfaces;
using TheHappyJungle.Factories.Interfaces;
using TheHappyJungle.IO.Interfaces;
using TheHappyJungle.Models.Interfaces;

namespace TheHappyJungle.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        private IAnimalFactory animalFactory;
        private IFoodFactory foodFactory;

        public Engine(IReader reader, IWriter writer, IAnimalFactory animalFactory, IFoodFactory foodFactory)
        {
            this.reader = reader;
            this.writer = writer;

            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;
        }

        public void Run()
        {

        }

        private IAnimal CreateAnimal(string command)
        {
            string[] animalTokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return animalFactory.CreateAnimal(animalTokens);
        }

        private IFood CreateFood()
        {
            string[] foodTokens = reader.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string foodType = foodTokens[0];
            int foodQuantity = int.Parse(foodTokens[1]);

            return foodFactory.CreateFood(foodType, foodQuantity);
        } 
    }
}
