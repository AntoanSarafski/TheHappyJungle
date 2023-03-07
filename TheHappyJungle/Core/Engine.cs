using System;
using System.Collections.Generic;
using System.Text;
using TheHappyJungle.Core.Interfaces;
using TheHappyJungle.Factories.Interfaces;
using TheHappyJungle.IO.Interfaces;

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
    }
}
