using System;
using TheHappyJungle.Core;
using TheHappyJungle.Core.Interfaces;
using TheHappyJungle.Factories;
using TheHappyJungle.Factories.Interfaces;
using TheHappyJungle.IO;
using TheHappyJungle.IO.Interfaces;

namespace TheHappyJungle
{
    class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IAnimalFactory animalFactory = new AnimalFactory();
            IFoodFactory foodFactory = new FoodFactory();

            IEngine engine = new Engine(reader, writer, animalFactory, foodFactory);
            engine.Run();
        }
    }
}